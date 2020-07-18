using System;
using System.Runtime.InteropServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000021 RID: 33
	internal static class Class_23
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00004EF0 File Offset: 0x000030F0
		public static string GetText()
		{
			if (Class_22.lmethod_48(13U) && Class_22.pmethod_49(IntPtr.Zero))
			{
				string result = string.Empty;
				IntPtr arg_ = Class_22.kmethod_47(13U);
				if (!arg_.Equals(IntPtr.Zero))
				{
					IntPtr intPtr = Class_22.tmethod_52(arg_);
					if (!intPtr.Equals(IntPtr.Zero))
					{
						try
						{
							result = Marshal.PtrToStringUni(intPtr);
							Class_22.gmethod_53(intPtr);
						}
						catch
						{
						}
					}
				}
				Class_22.smethod_50();
				return result;
			}
			return null;
		}

		// Token: 0x04000057 RID: 87
		private const uint \u0347\u0320\u035A\u030F\u0314\u0332\u0E47\u0020\u0355\u035A\u0329\u0335\u035F\u035C\u032D\u0309zvtetglrxdzqilqx\u0347\u0324\u0356\u0320\u0366\u033B\u033A\u0307\u0331\u0E47\u035E\u034A\u0305\u0E47\u0020\u0325zopnjkxrnroqhflo = 13U;
	}
}
