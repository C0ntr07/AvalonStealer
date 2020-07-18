using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000B9 RID: 185
	internal class Class_146 : Class_145
	{
		// Token: 0x0600035B RID: 859 RVA: 0x000167E4 File Offset: 0x000149E4
		public virtual string cmethod_464()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("size ").Append(Class_153.GetDescription(this.field_0)).Append(" ").Append(this.field_1.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00016838 File Offset: 0x00014A38
		internal virtual bool vmethod_465(string str_0)
		{
			FileInfo fileInfo = new FileInfo(str_0);
			return this.dmethod_466(fileInfo.Length);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00016858 File Offset: 0x00014A58
		private bool dmethod_466(long sayıUınt_0)
		{
			bool result;
			switch (this.field_0)
			{
			case Class_144.GreaterThan:
				result = (sayıUınt_0 > this.field_1);
				break;
			case Class_144.GreaterThanOrEqualTo:
				result = (sayıUınt_0 >= this.field_1);
				break;
			case Class_144.LesserThan:
				result = (sayıUınt_0 < this.field_1);
				break;
			case Class_144.LesserThanOrEqualTo:
				result = (sayıUınt_0 <= this.field_1);
				break;
			case Class_144.EqualTo:
				result = (sayıUınt_0 == this.field_1);
				break;
			case Class_144.NotEqualTo:
				result = (sayıUınt_0 != this.field_1);
				break;
			default:
				throw new ArgumentException("Operator");
			}
			return result;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00016900 File Offset: 0x00014B00
		internal virtual bool kmethod_467(Class_163 arg_0)
		{
			return this.dmethod_466(arg_0.prop_24);
		}

		// Token: 0x04000230 RID: 560
		internal Class_144 field_0;

		// Token: 0x04000231 RID: 561
		internal long field_1;
	}
}
