using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200002F RID: 47
	public class Class_33 : Class_35
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x000067E0 File Offset: 0x000049E0
		public Class_33(Class_36 arg_0, Class_37 arg_1 = null)
		{
			if (arg_0.kmethod_107() != 16)
			{
				throw new ArgumentException("cipher required with a block size of " + 16.ToString() + ".");
			}
			if (arg_1 == null)
			{
				arg_1 = new Class_43();
			}
			this.field_1 = arg_0;
			this.field_2 = arg_1;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006848 File Offset: 0x00004A48
		public virtual void pmethod_89(bool bool_0, Class_44 arg_0)
		{
			this.field_7 = bool_0;
			this.field_12 = null;
			if (arg_0 is Class_26)
			{
				Class_26 class_ = (Class_26)arg_0;
				this.field_14 = class_.gmethod_73();
				this.field_3 = class_.tmethod_72();
				int num = class_.prop_1;
				if (num < 96 || num > 128 || num % 8 != 0)
				{
					throw new ArgumentException("Invalid value for MAC size: " + num.ToString());
				}
				this.field_13 = num / 8;
				this.field_11 = class_.prop_0;
			}
			else
			{
				if (!(arg_0 is Class_41))
				{
					throw new ArgumentException("invalid parameters passed to GCM");
				}
				Class_41 class_2 = (Class_41)arg_0;
				this.field_14 = class_2.cmethod_114();
				this.field_3 = null;
				this.field_13 = 16;
				this.field_11 = (Class_39)class_2.prop_0;
			}
			int num2 = bool_0 ? 16 : (16 + this.field_13);
			this.field_4 = new byte[num2];
			if (this.field_14 == null || this.field_14.Length < 1)
			{
				throw new ArgumentException("IV must be at least 1 byte");
			}
			if (this.field_3 == null)
			{
				this.field_3 = new byte[0];
			}
			this.field_1.dmethod_106(true, this.field_11);
			this.field_8 = new byte[16];
			this.field_1.lmethod_108(this.field_8, 0, this.field_8, 0);
			this.field_2.smethod_110(this.field_8);
			this.field_9 = this.vmethod_95(this.field_3);
			if (this.field_14.Length == 12)
			{
				this.field_10 = new byte[16];
				Array.Copy(this.field_14, 0, this.field_10, 0, this.field_14.Length);
				this.field_10[15] = 1;
			}
			else
			{
				this.field_10 = this.vmethod_95(this.field_14);
				byte[] array = new byte[16];
				Class_33.dmethod_96((ulong)((long)this.field_14.Length * 8L), array, 8);
				Class_34.cmethod_104(this.field_10, array);
				this.field_2.xmethod_111(this.field_10);
			}
			this.field_15 = Class_29.Clone(this.field_9);
			this.field_6 = Class_29.Clone(this.field_10);
			this.field_5 = 0;
			this.field_16 = 0UL;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006AB3 File Offset: 0x00004CB3
		public virtual int smethod_90(int sayıInt_0)
		{
			if (this.field_7)
			{
				return sayıInt_0 + this.field_5 + this.field_13;
			}
			return sayıInt_0 + this.field_5 - this.field_13;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006AEC File Offset: 0x00004CEC
		public virtual int xmethod_91(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1, byte[] byteDizi_1, int sayıInt_2)
		{
			int num = 0;
			for (int num2 = 0; num2 != sayıInt_1; num2++)
			{
				byte[] array = this.field_4;
				int num3 = this.field_5;
				this.field_5 = num3 + 1;
				array[num3] = byteDizi_0[sayıInt_0 + num2];
				if (this.field_5 == this.field_4.Length)
				{
					this.cmethod_94(this.field_4, 16, byteDizi_1, sayıInt_2 + num);
					if (!this.field_7)
					{
						Array.Copy(this.field_4, 16, this.field_4, 0, this.field_13);
					}
					this.field_5 = this.field_4.Length - 16;
					num += 16;
				}
			}
			return num;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006B9C File Offset: 0x00004D9C
		public void tmethod_92(byte[] byteDizi_0, int sayıInt_0)
		{
			int num = this.field_5;
			if (!this.field_7)
			{
				if (num < this.field_13)
				{
					throw new Class_38("data too short");
				}
				num -= this.field_13;
			}
			if (num > 0)
			{
				byte[] array = new byte[16];
				Array.Copy(this.field_4, 0, array, 0, num);
				this.cmethod_94(array, num, byteDizi_0, sayıInt_0);
			}
			byte[] array2 = new byte[16];
			Class_33.dmethod_96((ulong)((long)this.field_3.Length * 8L), array2, 0);
			Class_33.dmethod_96(this.field_16 * 8UL, array2, 8);
			Class_34.cmethod_104(this.field_15, array2);
			this.field_2.xmethod_111(this.field_15);
			byte[] array3 = new byte[16];
			this.field_1.lmethod_108(this.field_10, 0, array3, 0);
			Class_34.cmethod_104(array3, this.field_15);
			this.field_12 = new byte[this.field_13];
			Array.Copy(array3, 0, this.field_12, 0, this.field_13);
			if (this.field_7)
			{
				Array.Copy(this.field_12, 0, byteDizi_0, sayıInt_0 + this.field_5, this.field_13);
			}
			else
			{
				byte[] array4 = new byte[this.field_13];
				Array.Copy(this.field_4, num, array4, 0, this.field_13);
				if (!Class_29.ConstantTimeAreEqual(this.field_12, array4))
				{
					throw new Class_38("mac check in GCM failed");
				}
			}
			this.gmethod_93(false);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006D18 File Offset: 0x00004F18
		private void gmethod_93(bool bool_0)
		{
			this.field_15 = Class_29.Clone(this.field_9);
			this.field_6 = Class_29.Clone(this.field_10);
			this.field_5 = 0;
			this.field_16 = 0UL;
			if (this.field_4 != null)
			{
				Array.Clear(this.field_4, 0, this.field_4.Length);
			}
			if (bool_0)
			{
				this.field_12 = null;
			}
			this.field_1.pmethod_109();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006D9C File Offset: 0x00004F9C
		private void cmethod_94(byte[] byteDizi_0, int sayıInt_0, byte[] byteDizi_1, int sayıInt_1)
		{
			for (int i = 15; i >= 12; i--)
			{
				byte[] array = this.field_6;
				int num = i;
				byte b = array[num] + 1;
				array[num] = b;
				if (b != 0)
				{
					break;
				}
			}
			byte[] array2 = new byte[16];
			this.field_1.lmethod_108(this.field_6, 0, array2, 0);
			byte[] byteDizi_2;
			if (this.field_7)
			{
				Array.Copy(Class_33.field_0, sayıInt_0, array2, sayıInt_0, 16 - sayıInt_0);
				byteDizi_2 = array2;
			}
			else
			{
				byteDizi_2 = byteDizi_0;
			}
			for (int j = sayıInt_0 - 1; j >= 0; j--)
			{
				byte[] array3 = array2;
				int num2 = j;
				array3[num2] ^= byteDizi_0[j];
				byteDizi_1[sayıInt_1 + j] = array2[j];
			}
			Class_34.cmethod_104(this.field_15, byteDizi_2);
			this.field_2.xmethod_111(this.field_15);
			this.field_16 += (ulong)((long)sayıInt_0);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006E80 File Offset: 0x00005080
		private byte[] vmethod_95(byte[] byteDizi_0)
		{
			byte[] array = new byte[16];
			for (int i = 0; i < byteDizi_0.Length; i += 16)
			{
				byte[] array2 = new byte[16];
				int length = Math.Min(byteDizi_0.Length - i, 16);
				Array.Copy(byteDizi_0, i, array2, 0, length);
				Class_34.cmethod_104(array, array2);
				this.field_2.xmethod_111(array);
			}
			return array;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006EE6 File Offset: 0x000050E6
		private static void dmethod_96(ulong arg_0, byte[] byteDizi_0, int sayıInt_0)
		{
			Class_40.UInt32_To_BE((uint)(arg_0 >> 32), byteDizi_0, sayıInt_0);
			Class_40.UInt32_To_BE((uint)arg_0, byteDizi_0, sayıInt_0 + 4);
		}

		// Token: 0x04000078 RID: 120
		private static readonly byte[] field_0 = new byte[16];

		// Token: 0x04000079 RID: 121
		private readonly Class_36 field_1;

		// Token: 0x0400007A RID: 122
		private readonly Class_37 field_2;

		// Token: 0x0400007B RID: 123
		private byte[] field_3;

		// Token: 0x0400007C RID: 124
		private byte[] field_4;

		// Token: 0x0400007D RID: 125
		private int field_5;

		// Token: 0x0400007E RID: 126
		private byte[] field_6;

		// Token: 0x0400007F RID: 127
		private bool field_7;

		// Token: 0x04000080 RID: 128
		private byte[] field_8;

		// Token: 0x04000081 RID: 129
		private byte[] field_9;

		// Token: 0x04000082 RID: 130
		private byte[] field_10;

		// Token: 0x04000083 RID: 131
		private Class_39 field_11;

		// Token: 0x04000084 RID: 132
		private byte[] field_12;

		// Token: 0x04000085 RID: 133
		private int field_13;

		// Token: 0x04000086 RID: 134
		private byte[] field_14;

		// Token: 0x04000087 RID: 135
		private byte[] field_15;

		// Token: 0x04000088 RID: 136
		private ulong field_16;
	}
}
