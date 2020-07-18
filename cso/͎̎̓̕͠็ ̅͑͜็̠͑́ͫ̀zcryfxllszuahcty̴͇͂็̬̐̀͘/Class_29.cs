using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000029 RID: 41
	public static class Class_29
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000656C File Offset: 0x0000476C
		public static bool ConstantTimeAreEqual(byte[] a, byte[] b)
		{
			int num = a.Length;
			if (num != b.Length)
			{
				return false;
			}
			int num2 = 0;
			while (num != 0)
			{
				num--;
				num2 |= (int)(a[num] ^ b[num]);
			}
			return num2 == 0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000065B0 File Offset: 0x000047B0
		public static byte[] Clone(byte[] data)
		{
			return (byte[])((data != null) ? data.Clone() : null);
		}
	}
}
