using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BD RID: 189
	internal class Class_150 : Class_145
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00016DD0 File Offset: 0x00014FD0
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00016E84 File Offset: 0x00015084
		internal new string prop_0
		{
			get
			{
				string text = "";
				if ((this.field_0 & FileAttributes.Hidden) != (FileAttributes)0)
				{
					text += "H";
				}
				if ((this.field_0 & FileAttributes.System) != (FileAttributes)0)
				{
					text += "S";
				}
				if ((this.field_0 & FileAttributes.ReadOnly) != (FileAttributes)0)
				{
					text += "R";
				}
				if ((this.field_0 & FileAttributes.Archive) != (FileAttributes)0)
				{
					text += "A";
				}
				if ((this.field_0 & FileAttributes.ReparsePoint) != (FileAttributes)0)
				{
					text += "L";
				}
				if ((this.field_0 & FileAttributes.NotContentIndexed) != (FileAttributes)0)
				{
					text += "I";
				}
				return text;
			}
			set
			{
				this.field_0 = FileAttributes.Normal;
				foreach (char c in value.ToUpper())
				{
					char c2 = c;
					if (c2 != 'A')
					{
						switch (c2)
						{
						case 'H':
							if ((this.field_0 & FileAttributes.Hidden) != (FileAttributes)0)
							{
								throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
							}
							this.field_0 |= FileAttributes.Hidden;
							goto IL_1D9;
						case 'I':
							if ((this.field_0 & FileAttributes.NotContentIndexed) != (FileAttributes)0)
							{
								throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
							}
							this.field_0 |= FileAttributes.NotContentIndexed;
							goto IL_1D9;
						case 'J':
						case 'K':
							break;
						case 'L':
							if ((this.field_0 & FileAttributes.ReparsePoint) != (FileAttributes)0)
							{
								throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
							}
							this.field_0 |= FileAttributes.ReparsePoint;
							goto IL_1D9;
						default:
							switch (c2)
							{
							case 'R':
								if ((this.field_0 & FileAttributes.ReadOnly) != (FileAttributes)0)
								{
									throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this.field_0 |= FileAttributes.ReadOnly;
								goto IL_1D9;
							case 'S':
								if ((this.field_0 & FileAttributes.System) != (FileAttributes)0)
								{
									throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
								}
								this.field_0 |= FileAttributes.System;
								goto IL_1D9;
							}
							break;
						}
						throw new ArgumentException(value);
					}
					if ((this.field_0 & FileAttributes.Archive) != (FileAttributes)0)
					{
						throw new ArgumentException(string.Format("Repeated flag. ({0})", c), "value");
					}
					this.field_0 |= FileAttributes.Archive;
					IL_1D9:;
				}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001707C File Offset: 0x0001527C
		public virtual string cmethod_484()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("attributes ").Append(Class_153.GetDescription(this.field_1)).Append(" ").Append(this.prop_0);
			return stringBuilder.ToString();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000170CC File Offset: 0x000152CC
		private bool vmethod_485(FileAttributes arg_0, FileAttributes arg_1)
		{
			return (this.field_0 & arg_1) != arg_1 || (arg_0 & arg_1) == arg_1;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000170F8 File Offset: 0x000152F8
		internal virtual bool dmethod_486(string str_0)
		{
			if (Directory.Exists(str_0))
			{
				return this.field_1 != Class_144.EqualTo;
			}
			FileAttributes attributes = File.GetAttributes(str_0);
			return this.kmethod_487(attributes);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001712C File Offset: 0x0001532C
		private bool kmethod_487(FileAttributes arg_0)
		{
			bool flag = this.vmethod_485(arg_0, FileAttributes.Hidden);
			if (flag)
			{
				flag = this.vmethod_485(arg_0, FileAttributes.System);
			}
			if (flag)
			{
				flag = this.vmethod_485(arg_0, FileAttributes.ReadOnly);
			}
			if (flag)
			{
				flag = this.vmethod_485(arg_0, FileAttributes.Archive);
			}
			if (flag)
			{
				flag = this.vmethod_485(arg_0, FileAttributes.NotContentIndexed);
			}
			if (flag)
			{
				flag = this.vmethod_485(arg_0, FileAttributes.ReparsePoint);
			}
			if (this.field_1 != Class_144.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000171A8 File Offset: 0x000153A8
		internal virtual bool lmethod_488(Class_163 arg_0)
		{
			FileAttributes arg_ = arg_0.prop_10;
			return this.kmethod_487(arg_);
		}

		// Token: 0x0400023B RID: 571
		private FileAttributes field_0;

		// Token: 0x0400023C RID: 572
		internal Class_144 field_1;
	}
}
