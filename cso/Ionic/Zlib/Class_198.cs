using System;

namespace Ionic.Zlib
{
	// Token: 0x02000100 RID: 256
	internal class Class_198
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x00032558 File Offset: 0x00030758
		public Class_198(int sayıInt_0, Class_202 arg_0, Class_203 arg_1, int sayıInt_1)
		{
			this.field_0 = new byte[sayıInt_0];
			int num = sayıInt_0 + (sayıInt_0 / 32768 + 1) * 5 * 2;
			this.field_1 = new byte[num];
			this.field_7 = new Class_212();
			this.field_7.InitializeDeflate(arg_0, false);
			this.field_7.OutputBuffer = this.field_1;
			this.field_7.InputBuffer = this.field_0;
			this.field_3 = sayıInt_1;
		}

		// Token: 0x04000525 RID: 1317
		public byte[] field_0;

		// Token: 0x04000526 RID: 1318
		public byte[] field_1;

		// Token: 0x04000527 RID: 1319
		public int field_2;

		// Token: 0x04000528 RID: 1320
		public int field_3;

		// Token: 0x04000529 RID: 1321
		public int field_4;

		// Token: 0x0400052A RID: 1322
		public int field_5;

		// Token: 0x0400052B RID: 1323
		public int field_6;

		// Token: 0x0400052C RID: 1324
		public Class_212 field_7;
	}
}
