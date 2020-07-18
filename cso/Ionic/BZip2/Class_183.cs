using System;

namespace Ionic.BZip2
{
	// Token: 0x020000EB RID: 235
	internal static class Class_183
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x0002AC84 File Offset: 0x00028E84
		internal static T[][] InitRectangularArray<T>(int d1, int d2)
		{
			T[][] array = new T[d1][];
			for (int i = 0; i < d1; i++)
			{
				array[i] = new T[d2];
			}
			return array;
		}

		// Token: 0x04000413 RID: 1043
		public static readonly int BlockSizeMultiple = 100000;

		// Token: 0x04000414 RID: 1044
		public static readonly int MinBlockSize = 1;

		// Token: 0x04000415 RID: 1045
		public static readonly int MaxBlockSize = 9;

		// Token: 0x04000416 RID: 1046
		public static readonly int MaxAlphaSize = 258;

		// Token: 0x04000417 RID: 1047
		public static readonly int MaxCodeLength = 23;

		// Token: 0x04000418 RID: 1048
		public static readonly char RUNA = '\0';

		// Token: 0x04000419 RID: 1049
		public static readonly char RUNB = '\u0001';

		// Token: 0x0400041A RID: 1050
		public static readonly int NGroups = 6;

		// Token: 0x0400041B RID: 1051
		public static readonly int G_SIZE = 50;

		// Token: 0x0400041C RID: 1052
		public static readonly int N_ITERS = 4;

		// Token: 0x0400041D RID: 1053
		public static readonly int MaxSelectors = 2 + 900000 / Class_183.G_SIZE;

		// Token: 0x0400041E RID: 1054
		public static readonly int NUM_OVERSHOOT_BYTES = 20;

		// Token: 0x0400041F RID: 1055
		internal static readonly int QSORT_STACK_SIZE = 1000;
	}
}
