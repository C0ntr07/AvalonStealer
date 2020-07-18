using System;
using System.Diagnostics;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200008D RID: 141
	internal class Class_107
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00014516 File Offset: 0x00012716
		public static int tmethod_382()
		{
			if (Class_107.gmethod_383() == 1)
			{
				return 1;
			}
			if (Class_107.cmethod_384() == 1)
			{
				return 1;
			}
			if (Class_107.vmethod_385() == 1)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001454B File Offset: 0x0001274B
		private static int gmethod_383()
		{
			if (Debugger.IsAttached)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00014565 File Offset: 0x00012765
		private static int cmethod_384()
		{
			if (Class_22.dmethod_66())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00014580 File Offset: 0x00012780
		private static int vmethod_385()
		{
			bool flag = false;
			if (Class_22.vmethod_65(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				return 1;
			}
			return 0;
		}
	}
}
