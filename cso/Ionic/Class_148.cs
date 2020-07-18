using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BB RID: 187
	internal class Class_148 : Class_145
	{
		// Token: 0x1700005F RID: 95
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00016B1C File Offset: 0x00014D1C
		internal new virtual string prop_0
		{
			set
			{
				if (Directory.Exists(value))
				{
					this.field_3 = ".\\" + value + "\\*.*";
				}
				else
				{
					this.field_3 = value;
				}
				this.field_1 = "^" + Regex.Escape(this.field_3).Replace("\\\\\\*\\.\\*", "\\\\([^\\.]+|.*\\.[^\\\\\\.]*)").Replace("\\.\\*", "\\.[^\\\\\\.]*").Replace("\\*", ".*").Replace("\\?", "[^\\\\\\.]") + "$";
				this.field_0 = new Regex(this.field_1, RegexOptions.IgnoreCase);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00016BC4 File Offset: 0x00014DC4
		public virtual string gmethod_473()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("name ").Append(Class_153.GetDescription(this.field_2)).Append(" '").Append(this.field_3).Append("'");
			return stringBuilder.ToString();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00016C1D File Offset: 0x00014E1D
		internal virtual bool cmethod_474(string str_0)
		{
			return this.vmethod_475(str_0);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00016C28 File Offset: 0x00014E28
		private bool vmethod_475(string str_0)
		{
			string input = (this.field_3.IndexOf('\\') == -1) ? Path.GetFileName(str_0) : str_0;
			bool flag = this.field_0.IsMatch(input);
			if (this.field_2 != Class_144.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00016C74 File Offset: 0x00014E74
		internal virtual bool dmethod_476(Class_163 arg_0)
		{
			string str_ = arg_0.prop_12.Replace("/", "\\");
			return this.vmethod_475(str_);
		}

		// Token: 0x04000235 RID: 565
		private Regex field_0;

		// Token: 0x04000236 RID: 566
		private string field_1;

		// Token: 0x04000237 RID: 567
		internal Class_144 field_2;

		// Token: 0x04000238 RID: 568
		private string field_3;
	}
}
