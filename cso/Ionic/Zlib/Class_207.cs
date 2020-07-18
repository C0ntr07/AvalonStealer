using System;

namespace Ionic.Zlib
{
	// Token: 0x0200010A RID: 266
	internal static class Class_207
	{
		// Token: 0x04000585 RID: 1413
		internal static readonly int MAX_BITS = 15;

		// Token: 0x04000586 RID: 1414
		internal static readonly int BL_CODES = 19;

		// Token: 0x04000587 RID: 1415
		internal static readonly int D_CODES = 30;

		// Token: 0x04000588 RID: 1416
		internal static readonly int LITERALS = 256;

		// Token: 0x04000589 RID: 1417
		internal static readonly int LENGTH_CODES = 29;

		// Token: 0x0400058A RID: 1418
		internal static readonly int L_CODES = Class_207.LITERALS + 1 + Class_207.LENGTH_CODES;

		// Token: 0x0400058B RID: 1419
		internal static readonly int MAX_BL_BITS = 7;

		// Token: 0x0400058C RID: 1420
		internal static readonly int REP_3_6 = 16;

		// Token: 0x0400058D RID: 1421
		internal static readonly int REPZ_3_10 = 17;

		// Token: 0x0400058E RID: 1422
		internal static readonly int REPZ_11_138 = 18;
	}
}
