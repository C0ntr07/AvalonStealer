using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200003C RID: 60
	public class Class_43 : Class_37
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00008294 File Offset: 0x00006494
		public void kmethod_127(byte[] byteDizi_0)
		{
			this.field_0[0] = new uint[16][];
			this.field_0[1] = new uint[16][];
			this.field_0[0][0] = new uint[4];
			this.field_0[1][0] = new uint[4];
			this.field_0[1][8] = Class_34.kmethod_97(byteDizi_0);
			for (int i = 4; i >= 1; i >>= 1)
			{
				uint[] array = (uint[])this.field_0[1][i + i].Clone();
				Class_34.pmethod_99(array);
				this.field_0[1][i] = array;
			}
			uint[] array2 = (uint[])this.field_0[1][1].Clone();
			Class_34.pmethod_99(array2);
			this.field_0[0][8] = array2;
			for (int j = 4; j >= 1; j >>= 1)
			{
				uint[] array3 = (uint[])this.field_0[0][j + j].Clone();
				Class_34.pmethod_99(array3);
				this.field_0[0][j] = array3;
			}
			int num = 0;
			for (;;)
			{
				for (int k = 2; k < 16; k += k)
				{
					for (int l = 1; l < k; l++)
					{
						uint[] array4 = (uint[])this.field_0[num][k].Clone();
						Class_34.vmethod_105(array4, this.field_0[num][l]);
						this.field_0[num][k + l] = array4;
					}
				}
				if (++num == 32)
				{
					break;
				}
				if (num > 1)
				{
					this.field_0[num] = new uint[16][];
					this.field_0[num][0] = new uint[4];
					for (int m = 8; m > 0; m >>= 1)
					{
						uint[] array5 = (uint[])this.field_0[num - 2][m].Clone();
						Class_34.smethod_100(array5);
						this.field_0[num][m] = array5;
					}
				}
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000084FC File Offset: 0x000066FC
		public void lmethod_128(byte[] byteDizi_0)
		{
			uint[] array = new uint[4];
			for (int i = 15; i >= 0; i--)
			{
				uint[] array2 = this.field_0[i + i][(int)(byteDizi_0[i] & 15)];
				array[0] ^= array2[0];
				array[1] ^= array2[1];
				array[2] ^= array2[2];
				array[3] ^= array2[3];
				array2 = this.field_0[i + i + 1][(byteDizi_0[i] & 240) >> 4];
				array[0] ^= array2[0];
				array[1] ^= array2[1];
				array[2] ^= array2[2];
				array[3] ^= array2[3];
			}
			Class_40.UInt32_To_BE(array[0], byteDizi_0, 0);
			Class_40.UInt32_To_BE(array[1], byteDizi_0, 4);
			Class_40.UInt32_To_BE(array[2], byteDizi_0, 8);
			Class_40.UInt32_To_BE(array[3], byteDizi_0, 12);
		}

		// Token: 0x0400009A RID: 154
		private readonly uint[][][] field_0 = new uint[32][][];
	}
}
