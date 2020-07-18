using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002BF RID: 703
	internal static class Class_511
	{
		// Token: 0x06001755 RID: 5973 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
		public static int IntLength(ulong i)
		{
			if (i < 10000000000UL)
			{
				if (i < 10UL)
				{
					return 1;
				}
				if (i < 100UL)
				{
					return 2;
				}
				if (i < 1000UL)
				{
					return 3;
				}
				if (i < 10000UL)
				{
					return 4;
				}
				if (i < 100000UL)
				{
					return 5;
				}
				if (i < 1000000UL)
				{
					return 6;
				}
				if (i < 10000000UL)
				{
					return 7;
				}
				if (i < 100000000UL)
				{
					return 8;
				}
				if (i < 1000000000UL)
				{
					return 9;
				}
				return 10;
			}
			else
			{
				if (i < 100000000000UL)
				{
					return 11;
				}
				if (i < 1000000000000UL)
				{
					return 12;
				}
				if (i < 10000000000000UL)
				{
					return 13;
				}
				if (i < 100000000000000UL)
				{
					return 14;
				}
				if (i < 1000000000000000UL)
				{
					return 15;
				}
				if (i < 10000000000000000UL)
				{
					return 16;
				}
				if (i < 100000000000000000UL)
				{
					return 17;
				}
				if (i < 1000000000000000000UL)
				{
					return 18;
				}
				if (i < 10000000000000000000UL)
				{
					return 19;
				}
				return 20;
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0006E7F4 File Offset: 0x0006C9F4
		public static char IntToHex(int n)
		{
			if (n <= 9)
			{
				return (char)(n + 48);
			}
			return (char)(n - 10 + 97);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0006E80C File Offset: 0x0006CA0C
		public static int? Min(int? val1, int? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new int?(Math.Min(val1.Value, val2.Value));
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0006E842 File Offset: 0x0006CA42
		public static int? Max(int? val1, int? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new int?(Math.Max(val1.Value, val2.Value));
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0006E878 File Offset: 0x0006CA78
		public static double? Max(double? val1, double? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new double?(Math.Max(val1.Value, val2.Value));
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		public static bool ApproxEquals(double d1, double d2)
		{
			if (d1 == d2)
			{
				return true;
			}
			double num = (Math.Abs(d1) + Math.Abs(d2) + 10.0) * 2.2204460492503131E-16;
			double num2 = d1 - d2;
			return -num < num2 && num > num2;
		}
	}
}
