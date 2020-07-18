using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000030 RID: 48
	internal abstract class Class_34
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00006F25 File Offset: 0x00005125
		internal static uint[] kmethod_97(byte[] byteDizi_0)
		{
			return new uint[]
			{
				Class_40.BE_To_UInt32(byteDizi_0, 0),
				Class_40.BE_To_UInt32(byteDizi_0, 4),
				Class_40.BE_To_UInt32(byteDizi_0, 8),
				Class_40.BE_To_UInt32(byteDizi_0, 12)
			};
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00006F64 File Offset: 0x00005164
		internal static void lmethod_98(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			byte[] array = Class_29.Clone(byteDizi_0);
			byte[] array2 = new byte[16];
			for (int i = 0; i < 16; i++)
			{
				byte b = byteDizi_1[i];
				for (int j = 7; j >= 0; j--)
				{
					if (((int)b & 1 << j) != 0)
					{
						Class_34.cmethod_104(array2, array);
					}
					bool flag = (array[15] & 1) > 0;
					Class_34.xmethod_101(array);
					if (flag)
					{
						byte[] array3 = array;
						int num = 0;
						array3[num] = array3[num];
					}
				}
			}
			Array.Copy(array2, 0, byteDizi_0, 0, 16);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00006FF8 File Offset: 0x000051F8
		internal static void pmethod_99(uint[] arg_0)
		{
			bool flag = (arg_0[3] & 1U) > 0U;
			Class_34.tmethod_102(arg_0);
			if (flag)
			{
				int num = 0;
				arg_0[num] = arg_0[num];
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000702C File Offset: 0x0000522C
		internal static void smethod_100(uint[] arg_0)
		{
			uint num = arg_0[3];
			Class_34.gmethod_103(arg_0, 8);
			for (int i = 7; i >= 0; i--)
			{
				if (((ulong)num & (ulong)(1L << (i & 31))) != 0UL)
				{
					arg_0[0] ^= 3774873600U >> 7 - i;
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00007088 File Offset: 0x00005288
		internal static void xmethod_101(byte[] byteDizi_0)
		{
			int num = 0;
			byte b = 0;
			for (;;)
			{
				byte b2 = byteDizi_0[num];
				byteDizi_0[num] = (byte)(b2 >> 1 | (int)b);
				if (++num == 16)
				{
					break;
				}
				b = (byte)(b2 << 7);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000070C8 File Offset: 0x000052C8
		internal static void tmethod_102(uint[] arg_0)
		{
			int num = 0;
			uint num2 = 0U;
			for (;;)
			{
				uint num3 = arg_0[num];
				arg_0[num] = (num3 >> 1 | num2);
				if (++num == 4)
				{
					break;
				}
				num2 = num3 << 31;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007104 File Offset: 0x00005304
		internal static void gmethod_103(uint[] arg_0, int sayıInt_0)
		{
			int num = 0;
			uint num2 = 0U;
			for (;;)
			{
				uint num3 = arg_0[num];
				arg_0[num] = (num3 >> sayıInt_0 | num2);
				if (++num == 4)
				{
					break;
				}
				num2 = num3 << 32 - sayıInt_0;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007148 File Offset: 0x00005348
		internal static void cmethod_104(byte[] byteDizi_0, byte[] byteDizi_1)
		{
			for (int i = 15; i >= 0; i--)
			{
				int num = i;
				byteDizi_0[num] ^= byteDizi_1[i];
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00007180 File Offset: 0x00005380
		internal static void vmethod_105(uint[] arg_0, uint[] arg_1)
		{
			for (int i = 3; i >= 0; i--)
			{
				arg_0[i] ^= arg_1[i];
			}
		}
	}
}
