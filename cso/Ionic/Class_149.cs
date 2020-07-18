using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BC RID: 188
	internal class Class_149 : Class_145
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00016C9E File Offset: 0x00014E9E
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00016CAC File Offset: 0x00014EAC
		internal new string prop_0
		{
			get
			{
				return this.field_0.ToString();
			}
			set
			{
				if (value.Length != 1 || (value[0] != 'D' && value[0] != 'F'))
				{
					throw new ArgumentException("Specify a single character: either D or F");
				}
				this.field_0 = value[0];
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00016CFC File Offset: 0x00014EFC
		public virtual string pmethod_479()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("type ").Append(Class_153.GetDescription(this.field_1)).Append(" ").Append(this.prop_0);
			return stringBuilder.ToString();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00016D4C File Offset: 0x00014F4C
		internal virtual bool smethod_480(string str_0)
		{
			bool flag = (this.field_0 == 'D') ? Directory.Exists(str_0) : File.Exists(str_0);
			if (this.field_1 != Class_144.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00016D8C File Offset: 0x00014F8C
		internal virtual bool xmethod_481(Class_163 arg_0)
		{
			bool flag = (this.field_0 == 'D') ? arg_0.prop_27 : (!arg_0.prop_27);
			if (this.field_1 != Class_144.EqualTo)
			{
				flag = !flag;
			}
			return flag;
		}

		// Token: 0x04000239 RID: 569
		private char field_0;

		// Token: 0x0400023A RID: 570
		internal Class_144 field_1;
	}
}
