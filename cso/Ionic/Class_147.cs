using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BA RID: 186
	internal class Class_147 : Class_145
	{
		// Token: 0x06000360 RID: 864 RVA: 0x00016918 File Offset: 0x00014B18
		public virtual string lmethod_468()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.field_1.ToString()).Append(" ").Append(Class_153.GetDescription(this.field_0)).Append(" ").Append(this.field_2.ToString("yyyy-MM-dd-HH:mm:ss"));
			return stringBuilder.ToString();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00016988 File Offset: 0x00014B88
		internal virtual bool pmethod_469(string str_0)
		{
			DateTime arg_;
			switch (this.field_1)
			{
			case Class_143.atime:
				arg_ = File.GetLastAccessTime(str_0).ToUniversalTime();
				break;
			case Class_143.mtime:
				arg_ = File.GetLastWriteTime(str_0).ToUniversalTime();
				break;
			case Class_143.ctime:
				arg_ = File.GetCreationTime(str_0).ToUniversalTime();
				break;
			default:
				throw new ArgumentException("Operator");
			}
			return this.smethod_470(arg_);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00016A04 File Offset: 0x00014C04
		private bool smethod_470(DateTime arg_0)
		{
			bool result;
			switch (this.field_0)
			{
			case Class_144.GreaterThan:
				result = (arg_0 > this.field_2);
				break;
			case Class_144.GreaterThanOrEqualTo:
				result = (arg_0 >= this.field_2);
				break;
			case Class_144.LesserThan:
				result = (arg_0 < this.field_2);
				break;
			case Class_144.LesserThanOrEqualTo:
				result = (arg_0 <= this.field_2);
				break;
			case Class_144.EqualTo:
				result = (arg_0 == this.field_2);
				break;
			case Class_144.NotEqualTo:
				result = (arg_0 != this.field_2);
				break;
			default:
				throw new ArgumentException("Operator");
			}
			return result;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00016AB8 File Offset: 0x00014CB8
		internal virtual bool xmethod_471(Class_163 arg_0)
		{
			DateTime arg_;
			switch (this.field_1)
			{
			case Class_143.atime:
				arg_ = arg_0.prop_5;
				break;
			case Class_143.mtime:
				arg_ = arg_0.prop_4;
				break;
			case Class_143.ctime:
				arg_ = arg_0.prop_6;
				break;
			default:
				throw new ArgumentException("??time");
			}
			return this.smethod_470(arg_);
		}

		// Token: 0x04000232 RID: 562
		internal Class_144 field_0;

		// Token: 0x04000233 RID: 563
		internal Class_143 field_1;

		// Token: 0x04000234 RID: 564
		internal DateTime field_2;
	}
}
