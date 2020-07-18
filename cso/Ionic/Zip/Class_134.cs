using System;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000AD RID: 173
	[ComVisible(true)]
	public class Class_134 : Class_129
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00016443 File Offset: 0x00014643
		private Class_134()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00016740 File Offset: 0x00014940
		internal static Class_134 dmethod_456(string str_0, Class_163 arg_0, Exception arg_1)
		{
			return new Class_134
			{
				prop_3 = Class_128.Error_Saving,
				prop_4 = str_0,
				prop_1 = arg_0,
				field_0 = arg_1
			};
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00016773 File Offset: 0x00014973
		public new Exception prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001677B File Offset: 0x0001497B
		public new string prop_1
		{
			get
			{
				return base.prop_1.prop_11;
			}
		}

		// Token: 0x04000219 RID: 537
		private Exception field_0;
	}
}
