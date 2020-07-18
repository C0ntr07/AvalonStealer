using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x0200010C RID: 268
	[ComVisible(true)]
	public sealed class Class_209
	{
		// Token: 0x06000789 RID: 1929 RVA: 0x000337FC File Offset: 0x000319FC
		public static uint Adler32(uint adler, byte[] buf, int index, int len)
		{
			if (buf == null)
			{
				return 1U;
			}
			uint num = adler & 65535U;
			uint num2 = adler >> 16 & 65535U;
			while (len > 0)
			{
				int i = (len < Class_209.NMAX) ? len : Class_209.NMAX;
				len -= i;
				while (i >= 16)
				{
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					num += (uint)buf[index++];
					num2 += num;
					i -= 16;
				}
				if (i != 0)
				{
					do
					{
						num += (uint)buf[index++];
						num2 += num;
					}
					while (--i != 0);
				}
				num %= Class_209.BASE;
				num2 %= Class_209.BASE;
			}
			return num2 << 16 | num;
		}

		// Token: 0x04000599 RID: 1433
		private static readonly uint BASE = 65521U;

		// Token: 0x0400059A RID: 1434
		private static readonly int NMAX = 5552;
	}
}
