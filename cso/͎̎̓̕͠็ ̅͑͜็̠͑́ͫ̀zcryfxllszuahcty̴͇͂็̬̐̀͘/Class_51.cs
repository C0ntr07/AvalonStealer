using System;
using System.Diagnostics;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000047 RID: 71
	internal class Class_51
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0000B968 File Offset: 0x00009B68
		public static void pmethod_149()
		{
			foreach (object obj in Process.GetCurrentProcess().Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = Class_22.lmethod_58(Class_119.\u0350\u0313\u0E47\u0020i\u036D\u0315\u0310\u0339\u0E47\u0352\u0E47\u0324\u0313\u035A\u0368ymsiidbyrmagclmb\u0020\u0311\u0307\u0323\u0020\u0362\u0324\u0316\u0355\u035B\u0318\u0350\u0314\u0357\u0020\u0329pamhagwqyoctltpv, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					Class_51.smethod_150(intPtr);
					Class_22.pmethod_59(intPtr);
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000B9FC File Offset: 0x00009BFC
		public static bool smethod_150(IntPtr arg_0)
		{
			return Class_22.kmethod_57(arg_0, Class_118.\u0316\u034D\u0020\u032E\u035C\u0356\u0314\u0342\u0324\u0323\u036D\u0020c\u0E47\u034E\u0020cdszfyqwttqpjcko\u0329\u034B\u034E\u0020\u0306\u0322\u0E47\u034A\u0342\u0339\u0E47\u0340\u0349\u0329\u0020\u0329ihcvpihcsvtayuok, IntPtr.Zero, 0) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl;
		}
	}
}
