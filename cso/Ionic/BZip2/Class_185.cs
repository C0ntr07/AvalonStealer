using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Ionic.BZip2
{
	// Token: 0x020000EE RID: 238
	internal class Class_185
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0002B154 File Offset: 0x00029354
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0002B15C File Offset: 0x0002935C
		public Class_181 prop_0 { get; private set; }

		// Token: 0x060006A7 RID: 1703 RVA: 0x0002B165 File Offset: 0x00029365
		public Class_185(int sayıInt_0, int sayıInt_1)
		{
			this.field_1 = new MemoryStream();
			this.field_3 = new Class_180(this.field_1);
			this.prop_0 = new Class_181(this.field_3, sayıInt_1);
			this.field_0 = sayıInt_0;
		}

		// Token: 0x0400042D RID: 1069
		public int field_0;

		// Token: 0x0400042E RID: 1070
		public MemoryStream field_1;

		// Token: 0x0400042F RID: 1071
		public int field_2;

		// Token: 0x04000430 RID: 1072
		public Class_180 field_3;

		// Token: 0x04000431 RID: 1073
		[CompilerGenerated]
		private Class_181 field_4;
	}
}
