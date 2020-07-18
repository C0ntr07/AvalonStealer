using System;
using System.IO;
using System.Runtime.InteropServices;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x020000E8 RID: 232
	[ComVisible(true)]
	public class Class_182 : Stream
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x0002949B File Offset: 0x0002769B
		public Class_182(Stream stream_) : this(stream_, false)
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000294A5 File Offset: 0x000276A5
		public Class_182(Stream stream_, bool bool_0)
		{
			this.field_11 = stream_;
			this.field_1 = bool_0;
			this.kmethod_1167();
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000294DC File Offset: 0x000276DC
		public virtual int gmethod_1153(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_0 < 0)
			{
				throw new IndexOutOfRangeException(string.Format("offset ({0}) must be > 0", sayıInt_0));
			}
			if (sayıInt_1 < 0)
			{
				throw new IndexOutOfRangeException(string.Format("count ({0}) must be > 0", sayıInt_1));
			}
			if (sayıInt_0 + sayıInt_1 > byteDizi_0.Length)
			{
				throw new IndexOutOfRangeException(string.Format("offset({0}) count({1}) bLength({2})", sayıInt_0, sayıInt_1, byteDizi_0.Length));
			}
			if (this.field_11 == null)
			{
				throw new IOException("the stream is not open");
			}
			int num = sayıInt_0 + sayıInt_1;
			int num2 = sayıInt_0;
			int num3;
			while (num2 < num && (num3 = this.ReadByte()) >= 0)
			{
				byteDizi_0[num2++] = (byte)num3;
			}
			if (num2 != sayıInt_0)
			{
				return num2 - sayıInt_0;
			}
			return -1;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002959C File Offset: 0x0002779C
		private void cmethod_1154()
		{
			bool[] field_ = this.field_27.field_35;
			byte[] field_2 = this.field_27.field_36;
			int num = 0;
			for (int i = 0; i < 256; i++)
			{
				if (field_[i])
				{
					field_2[num++] = (byte)i;
				}
			}
			this.field_10 = num;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000295F0 File Offset: 0x000277F0
		public virtual int vmethod_1155()
		{
			int result = this.field_12;
			this.field_2 += 1L;
			switch (this.field_13)
			{
			case Class_182.NClass_0.field_27:
				return -1;
			case Class_182.NClass_0.field_28:
				throw new IOException("bad state");
			case Class_182.NClass_0.field_29:
				throw new IOException("bad state");
			case Class_182.NClass_0.field_30:
				this.vmethod_1185();
				break;
			case Class_182.NClass_0.field_31:
				this.dmethod_1186();
				break;
			case Class_182.NClass_0.field_32:
				throw new IOException("bad state");
			case Class_182.NClass_0.field_33:
				this.kmethod_1187();
				break;
			case Class_182.NClass_0.field_34:
				this.lmethod_1188();
				break;
			default:
				throw new IOException("bad state");
			}
			return result;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000296A0 File Offset: 0x000278A0
		public virtual bool prop_0
		{
			get
			{
				if (this.field_0)
				{
					throw new ObjectDisposedException("BZip2Stream");
				}
				return this.field_11.CanRead;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_1
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000296C3 File Offset: 0x000278C3
		public virtual bool prop_2
		{
			get
			{
				if (this.field_0)
				{
					throw new ObjectDisposedException("BZip2Stream");
				}
				return this.field_11.CanWrite;
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000296E6 File Offset: 0x000278E6
		public virtual void pmethod_1159()
		{
			if (this.field_0)
			{
				throw new ObjectDisposedException("BZip2Stream");
			}
			this.field_11.Flush();
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_3
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00029709 File Offset: 0x00027909
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_4
		{
			get
			{
				return this.field_2;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long gmethod_1163(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void cmethod_1164(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void vmethod_1165(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00029714 File Offset: 0x00027914
		protected virtual void dmethod_1166(bool bool_0)
		{
			try
			{
				if (!this.field_0)
				{
					if (bool_0 && this.field_11 != null)
					{
						this.field_11.Close();
					}
					this.field_0 = true;
				}
			}
			finally
			{
				base.Dispose(bool_0);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002976C File Offset: 0x0002796C
		private void kmethod_1167()
		{
			if (this.field_11 == null)
			{
				throw new IOException("No input Stream");
			}
			if (!this.field_11.CanRead)
			{
				throw new IOException("Unreadable input Stream");
			}
			this.lmethod_1168('B', 0);
			this.lmethod_1168('Z', 1);
			this.lmethod_1168('h', 2);
			int num = this.field_11.ReadByte();
			if (num < 49 || num > 57)
			{
				throw new IOException("Stream is not BZip2 formatted: illegal blocksize " + (char)num);
			}
			this.field_5 = num - 48;
			this.pmethod_1169();
			this.tmethod_1182();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00029810 File Offset: 0x00027A10
		private void lmethod_1168(char char_0, int sayıInt_0)
		{
			int num = this.field_11.ReadByte();
			if (num != (int)char_0)
			{
				string message = string.Format("Not a valid BZip2 stream. byte {0}, expected '{1}', got '{2}'", sayıInt_0, (int)char_0, num);
				throw new IOException(message);
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00029854 File Offset: 0x00027A54
		private void pmethod_1169()
		{
			char c = this.vmethod_1175();
			char c2 = this.vmethod_1175();
			char c3 = this.vmethod_1175();
			char c4 = this.vmethod_1175();
			char c5 = this.vmethod_1175();
			char c6 = this.vmethod_1175();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.xmethod_1171();
				return;
			}
			if (c != '1' || c2 != 'A' || c3 != 'Y' || c4 != '&' || c5 != 'S' || c6 != 'Y')
			{
				this.field_13 = Class_182.NClass_0.field_27;
				string message = string.Format("bad block header at offset 0x{0:X}", this.field_11.Position);
				throw new IOException(message);
			}
			this.field_14 = this.dmethod_1176();
			this.field_6 = (this.gmethod_1173(1) == 1);
			if (this.field_27 == null)
			{
				this.field_27 = new Class_182.NClass_1(this.field_5);
			}
			this.smethod_1180();
			this.field_9.lmethod_1378();
			this.field_13 = Class_182.NClass_0.field_28;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00029978 File Offset: 0x00027B78
		private void smethod_1170()
		{
			this.field_16 = (uint)this.field_9.prop_1;
			if (this.field_14 != this.field_16)
			{
				string message = string.Format("BZip2 CRC error (expected {0:X8}, computed {1:X8})", this.field_14, this.field_16);
				throw new IOException(message);
			}
			this.field_17 = (this.field_17 << 1 | this.field_17 >> 31);
			this.field_17 ^= this.field_16;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000299FC File Offset: 0x00027BFC
		private void xmethod_1171()
		{
			this.field_15 = this.dmethod_1176();
			this.field_13 = Class_182.NClass_0.field_27;
			this.field_27 = null;
			if (this.field_15 != this.field_17)
			{
				string message = string.Format("BZip2 CRC error (expected {0:X8}, computed {1:X8})", this.field_15, this.field_17);
				throw new IOException(message);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00029A5C File Offset: 0x00027C5C
		public virtual void tmethod_1172()
		{
			Stream stream = this.field_11;
			if (stream != null)
			{
				try
				{
					if (!this.field_1)
					{
						stream.Close();
					}
				}
				finally
				{
					this.field_27 = null;
					this.field_11 = null;
				}
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00029AAC File Offset: 0x00027CAC
		private int gmethod_1173(int sayıInt_0)
		{
			int num = this.field_8;
			int num2 = this.field_7;
			if (num < sayıInt_0)
			{
				for (;;)
				{
					int num3 = this.field_11.ReadByte();
					if (num3 < 0)
					{
						break;
					}
					num2 = (num2 << 8 | num3);
					num += 8;
					if (num >= sayıInt_0)
					{
						goto Block_2;
					}
				}
				throw new IOException("unexpected end of stream");
				Block_2:
				this.field_7 = num2;
			}
			this.field_8 = num - sayıInt_0;
			return num2 >> num - sayıInt_0 & (1 << sayıInt_0) - 1;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00029B1C File Offset: 0x00027D1C
		private bool cmethod_1174()
		{
			int num = this.gmethod_1173(1);
			return num != 0;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00029B38 File Offset: 0x00027D38
		private char vmethod_1175()
		{
			return (char)this.gmethod_1173(8);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00029B42 File Offset: 0x00027D42
		private uint dmethod_1176()
		{
			return (uint)(((this.gmethod_1173(8) << 8 | this.gmethod_1173(8)) << 8 | this.gmethod_1173(8)) << 8 | this.gmethod_1173(8));
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00029B6C File Offset: 0x00027D6C
		private static void kmethod_1177(int[] ıntSayıDizi_0, int[] ıntSayıDizi_1, int[] ıntSayıDizi_2, char[] charDizi_0, int sayıInt_0, int sayıInt_1, int sayıInt_2)
		{
			int i = sayıInt_0;
			int num = 0;
			while (i <= sayıInt_1)
			{
				for (int j = 0; j < sayıInt_2; j++)
				{
					if ((int)charDizi_0[j] == i)
					{
						ıntSayıDizi_2[num++] = j;
					}
				}
				i++;
			}
			int num2 = Class_183.MaxCodeLength;
			while (--num2 > 0)
			{
				ıntSayıDizi_1[num2] = 0;
				ıntSayıDizi_0[num2] = 0;
			}
			for (int k = 0; k < sayıInt_2; k++)
			{
				ıntSayıDizi_1[(int)(charDizi_0[k] + '\u0001')]++;
			}
			int l = 1;
			int num3 = ıntSayıDizi_1[0];
			while (l < Class_183.MaxCodeLength)
			{
				num3 += ıntSayıDizi_1[l];
				ıntSayıDizi_1[l] = num3;
				l++;
			}
			int m = sayıInt_0;
			int num4 = 0;
			int num5 = ıntSayıDizi_1[m];
			while (m <= sayıInt_1)
			{
				int num6 = ıntSayıDizi_1[m + 1];
				num4 += num6 - num5;
				num5 = num6;
				ıntSayıDizi_0[m] = num4 - 1;
				num4 <<= 1;
				m++;
			}
			for (int n = sayıInt_0 + 1; n <= sayıInt_1; n++)
			{
				ıntSayıDizi_1[n] = (ıntSayıDizi_0[n - 1] + 1 << 1) - ıntSayıDizi_1[n];
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00029C84 File Offset: 0x00027E84
		private void lmethod_1178()
		{
			Class_182.NClass_1 nclass_ = this.field_27;
			bool[] field_ = nclass_.field_35;
			byte[] field_2 = nclass_.field_47;
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				if (this.cmethod_1174())
				{
					num |= 1 << i;
				}
			}
			int num2 = 256;
			while (--num2 >= 0)
			{
				field_[num2] = false;
			}
			for (int j = 0; j < 16; j++)
			{
				if ((num & 1 << j) != 0)
				{
					int num3 = j << 4;
					for (int k = 0; k < 16; k++)
					{
						if (this.cmethod_1174())
						{
							field_[num3 + k] = true;
						}
					}
				}
			}
			this.cmethod_1154();
			int num4 = this.field_10 + 2;
			int num5 = this.gmethod_1173(3);
			int num6 = this.gmethod_1173(15);
			for (int l = 0; l < num6; l++)
			{
				int num7 = 0;
				while (this.cmethod_1174())
				{
					num7++;
				}
				nclass_.field_38[l] = (byte)num7;
			}
			int num8 = num5;
			while (--num8 >= 0)
			{
				field_2[num8] = (byte)num8;
			}
			for (int m = 0; m < num6; m++)
			{
				int n = (int)nclass_.field_38[m];
				byte b = field_2[n];
				while (n > 0)
				{
					field_2[n] = field_2[n - 1];
					n--;
				}
				field_2[0] = b;
				nclass_.field_37[m] = b;
			}
			char[][] field_3 = nclass_.field_46;
			for (int num9 = 0; num9 < num5; num9++)
			{
				int num10 = this.gmethod_1173(5);
				char[] array = field_3[num9];
				for (int num11 = 0; num11 < num4; num11++)
				{
					while (this.cmethod_1174())
					{
						num10 += (this.cmethod_1174() ? -1 : 1);
					}
					array[num11] = (char)num10;
				}
			}
			this.pmethod_1179(num4, num5);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00029E74 File Offset: 0x00028074
		private void pmethod_1179(int sayıInt_0, int sayıInt_1)
		{
			Class_182.NClass_1 nclass_ = this.field_27;
			char[][] field_ = nclass_.field_46;
			for (int i = 0; i < sayıInt_1; i++)
			{
				int num = 32;
				int num2 = 0;
				char[] array = field_[i];
				int num3 = sayıInt_0;
				while (--num3 >= 0)
				{
					char c = array[num3];
					if ((int)c > num2)
					{
						num2 = (int)c;
					}
					if ((int)c < num)
					{
						num = (int)c;
					}
				}
				Class_182.kmethod_1177(nclass_.field_40[i], nclass_.field_41[i], nclass_.field_42[i], field_[i], num, num2, sayıInt_0);
				nclass_.field_43[i] = num;
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00029F20 File Offset: 0x00028120
		private void smethod_1180()
		{
			Class_182.NClass_1 nclass_ = this.field_27;
			this.field_4 = this.gmethod_1173(24);
			if (this.field_4 < 0)
			{
				throw new IOException("BZ_DATA_ERROR");
			}
			if (this.field_4 > 10 + Class_183.BlockSizeMultiple * this.field_5)
			{
				throw new IOException("BZ_DATA_ERROR");
			}
			this.lmethod_1178();
			byte[] field_ = nclass_.field_45;
			int num = this.field_5 * Class_183.BlockSizeMultiple;
			int num2 = 256;
			while (--num2 >= 0)
			{
				field_[num2] = (byte)num2;
				nclass_.field_39[num2] = 0;
			}
			int num3 = 0;
			int num4 = Class_183.G_SIZE - 1;
			int num5 = this.field_10 + 1;
			int num6 = this.xmethod_1181(0);
			int num7 = this.field_7;
			int i = this.field_8;
			int num8 = -1;
			int num9 = (int)(nclass_.field_37[num3] & byte.MaxValue);
			int[] array = nclass_.field_41[num9];
			int[] array2 = nclass_.field_40[num9];
			int[] array3 = nclass_.field_42[num9];
			int num10 = nclass_.field_43[num9];
			while (num6 != num5)
			{
				if (num6 == (int)Class_183.RUNA || num6 == (int)Class_183.RUNB)
				{
					int num11 = -1;
					int num12 = 1;
					for (;;)
					{
						if (num6 == (int)Class_183.RUNA)
						{
							num11 += num12;
						}
						else
						{
							if (num6 != (int)Class_183.RUNB)
							{
								break;
							}
							num11 += num12 << 1;
						}
						if (num4 == 0)
						{
							num4 = Class_183.G_SIZE - 1;
							num9 = (int)(nclass_.field_37[++num3] & byte.MaxValue);
							array = nclass_.field_41[num9];
							array2 = nclass_.field_40[num9];
							array3 = nclass_.field_42[num9];
							num10 = nclass_.field_43[num9];
						}
						else
						{
							num4--;
						}
						int num13 = num10;
						while (i < num13)
						{
							int num14 = this.field_11.ReadByte();
							if (num14 < 0)
							{
								goto IL_1F2;
							}
							num7 = (num7 << 8 | num14);
							i += 8;
						}
						int j = num7 >> i - num13 & (1 << num13) - 1;
						i -= num13;
						while (j > array2[num13])
						{
							num13++;
							while (i < 1)
							{
								int num15 = this.field_11.ReadByte();
								if (num15 < 0)
								{
									goto IL_25A;
								}
								num7 = (num7 << 8 | num15);
								i += 8;
							}
							i--;
							j = (j << 1 | (num7 >> i & 1));
						}
						num6 = array3[j - array[num13]];
						num12 <<= 1;
					}
					byte b = nclass_.field_36[(int)field_[0]];
					nclass_.field_39[(int)(b & byte.MaxValue)] += num11 + 1;
					while (num11-- >= 0)
					{
						nclass_.field_49[++num8] = b;
					}
					if (num8 >= num)
					{
						throw new IOException("block overrun");
					}
					continue;
					IL_1F2:
					throw new IOException("unexpected end of stream");
					IL_25A:
					throw new IOException("unexpected end of stream");
				}
				if (++num8 >= num)
				{
					throw new IOException("block overrun");
				}
				byte b2 = field_[num6 - 1];
				nclass_.field_39[(int)(nclass_.field_36[(int)b2] & byte.MaxValue)]++;
				nclass_.field_49[num8] = nclass_.field_36[(int)b2];
				if (num6 <= 16)
				{
					int k = num6 - 1;
					while (k > 0)
					{
						field_[k] = field_[--k];
					}
				}
				else
				{
					Buffer.BlockCopy(field_, 0, field_, 1, num6 - 1);
				}
				field_[0] = b2;
				if (num4 == 0)
				{
					num4 = Class_183.G_SIZE - 1;
					num9 = (int)(nclass_.field_37[++num3] & byte.MaxValue);
					array = nclass_.field_41[num9];
					array2 = nclass_.field_40[num9];
					array3 = nclass_.field_42[num9];
					num10 = nclass_.field_43[num9];
				}
				else
				{
					num4--;
				}
				int num16 = num10;
				while (i < num16)
				{
					int num17 = this.field_11.ReadByte();
					if (num17 < 0)
					{
						throw new IOException("unexpected end of stream");
					}
					num7 = (num7 << 8 | num17);
					i += 8;
				}
				int l = num7 >> i - num16 & (1 << num16) - 1;
				i -= num16;
				while (l > array2[num16])
				{
					num16++;
					while (i < 1)
					{
						int num18 = this.field_11.ReadByte();
						if (num18 < 0)
						{
							throw new IOException("unexpected end of stream");
						}
						num7 = (num7 << 8 | num18);
						i += 8;
					}
					i--;
					l = (l << 1 | (num7 >> i & 1));
				}
				num6 = array3[l - array[num16]];
			}
			this.field_3 = num8;
			this.field_8 = i;
			this.field_7 = num7;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002A418 File Offset: 0x00028618
		private int xmethod_1181(int sayıInt_0)
		{
			Class_182.NClass_1 nclass_ = this.field_27;
			int num = (int)(nclass_.field_37[sayıInt_0] & byte.MaxValue);
			int[] array = nclass_.field_40[num];
			int num2 = nclass_.field_43[num];
			int i = this.gmethod_1173(num2);
			int j = this.field_8;
			int num3 = this.field_7;
			while (i > array[num2])
			{
				num2++;
				while (j < 1)
				{
					int num4 = this.field_11.ReadByte();
					if (num4 < 0)
					{
						throw new IOException("unexpected end of stream");
					}
					num3 = (num3 << 8 | num4);
					j += 8;
				}
				j--;
				i = (i << 1 | (num3 >> j & 1));
			}
			this.field_8 = j;
			this.field_7 = num3;
			return nclass_.field_42[num][i - nclass_.field_41[num][num2]];
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002A500 File Offset: 0x00028700
		private void tmethod_1182()
		{
			if (this.field_27 == null)
			{
				return;
			}
			Class_182.NClass_1 nclass_ = this.field_27;
			int[] array = nclass_.nmethod_1(this.field_3 + 1);
			int i;
			for (i = 0; i <= 255; i++)
			{
				if (nclass_.field_39[i] < 0 || nclass_.field_39[i] > this.field_3)
				{
					throw new Exception("BZ_DATA_ERROR");
				}
			}
			nclass_.field_44[0] = 0;
			for (i = 1; i <= 256; i++)
			{
				nclass_.field_44[i] = nclass_.field_39[i - 1];
			}
			for (i = 1; i <= 256; i++)
			{
				nclass_.field_44[i] += nclass_.field_44[i - 1];
			}
			for (i = 0; i <= 256; i++)
			{
				if (nclass_.field_44[i] < 0 || nclass_.field_44[i] > this.field_3 + 1)
				{
					string message = string.Format("BZ_DATA_ERROR: cftab[{0}]={1} last={2}", i, nclass_.field_44[i], this.field_3);
					throw new Exception(message);
				}
			}
			for (i = 1; i <= 256; i++)
			{
				if (nclass_.field_44[i - 1] > nclass_.field_44[i])
				{
					throw new Exception("BZ_DATA_ERROR");
				}
			}
			i = 0;
			int num = this.field_3;
			while (i <= num)
			{
				array[nclass_.field_44[(int)(nclass_.field_49[i] & byte.MaxValue)]++] = i;
				i++;
			}
			if (this.field_4 < 0 || this.field_4 >= array.Length)
			{
				throw new IOException("stream corrupted");
			}
			this.field_25 = array[this.field_4];
			this.field_18 = 0;
			this.field_21 = 0;
			this.field_19 = 256;
			if (this.field_6)
			{
				this.field_23 = 0;
				this.field_24 = 0;
				this.gmethod_1183();
				return;
			}
			this.cmethod_1184();
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002A714 File Offset: 0x00028914
		private void gmethod_1183()
		{
			/*
An exception occurred when decompiling this method (06000686)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Ionic.BZip2.Class_182::gmethod_1183()
 ---> System.Exception: Inconsistent stack size at IL_B0
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 279
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002A81C File Offset: 0x00028A1C
		private void cmethod_1184()
		{
			if (this.field_21 <= this.field_3)
			{
				this.field_20 = this.field_19;
				int num = (int)(this.field_27.field_49[this.field_25] & byte.MaxValue);
				this.field_19 = num;
				this.field_25 = this.field_27.field_48[this.field_25];
				this.field_21++;
				this.field_12 = num;
				this.field_13 = Class_182.NClass_0.field_33;
				this.field_9.smethod_1370((byte)num);
				return;
			}
			this.field_13 = Class_182.NClass_0.field_32;
			this.smethod_1170();
			this.pmethod_1169();
			this.tmethod_1182();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002A8C4 File Offset: 0x00028AC4
		private void vmethod_1185()
		{
			if (this.field_19 != this.field_20)
			{
				this.field_13 = Class_182.NClass_0.field_29;
				this.field_18 = 1;
				this.gmethod_1183();
				return;
			}
			if (++this.field_18 >= 4)
			{
				this.field_26 = (char)(this.field_27.field_49[this.field_25] & byte.MaxValue);
				this.field_25 = this.field_27.field_48[this.field_25];
				if (this.field_23 == 0)
				{
					this.field_23 = Class_187.Rnums(this.field_24) - 1;
					if (++this.field_24 == 512)
					{
						this.field_24 = 0;
					}
				}
				else
				{
					this.field_23--;
				}
				this.field_22 = 0;
				this.field_13 = Class_182.NClass_0.field_31;
				if (this.field_23 == 1)
				{
					this.field_26 = this.field_26;
				}
				this.dmethod_1186();
				return;
			}
			this.field_13 = Class_182.NClass_0.field_29;
			this.gmethod_1183();
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		private void dmethod_1186()
		{
			if (this.field_22 < (int)this.field_26)
			{
				this.field_12 = this.field_19;
				this.field_9.smethod_1370((byte)this.field_19);
				this.field_22++;
				return;
			}
			this.field_13 = Class_182.NClass_0.field_29;
			this.field_21++;
			this.field_18 = 0;
			this.gmethod_1183();
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002AA48 File Offset: 0x00028C48
		private void kmethod_1187()
		{
			if (this.field_19 != this.field_20)
			{
				this.field_18 = 1;
				this.cmethod_1184();
				return;
			}
			if (++this.field_18 >= 4)
			{
				this.field_26 = (char)(this.field_27.field_49[this.field_25] & byte.MaxValue);
				this.field_25 = this.field_27.field_48[this.field_25];
				this.field_22 = 0;
				this.lmethod_1188();
				return;
			}
			this.cmethod_1184();
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		private void lmethod_1188()
		{
			if (this.field_22 < (int)this.field_26)
			{
				int num = this.field_19;
				this.field_12 = num;
				this.field_9.smethod_1370((byte)num);
				this.field_22++;
				this.field_13 = Class_182.NClass_0.field_34;
				return;
			}
			this.field_21++;
			this.field_18 = 0;
			this.cmethod_1184();
		}

		// Token: 0x040003DF RID: 991
		private bool field_0;

		// Token: 0x040003E0 RID: 992
		private bool field_1;

		// Token: 0x040003E1 RID: 993
		private long field_2;

		// Token: 0x040003E2 RID: 994
		private int field_3;

		// Token: 0x040003E3 RID: 995
		private int field_4;

		// Token: 0x040003E4 RID: 996
		private int field_5;

		// Token: 0x040003E5 RID: 997
		private bool field_6;

		// Token: 0x040003E6 RID: 998
		private int field_7;

		// Token: 0x040003E7 RID: 999
		private int field_8;

		// Token: 0x040003E8 RID: 1000
		private readonly Class_215 field_9 = new Class_215(true);

		// Token: 0x040003E9 RID: 1001
		private int field_10;

		// Token: 0x040003EA RID: 1002
		private Stream field_11;

		// Token: 0x040003EB RID: 1003
		private int field_12 = -1;

		// Token: 0x040003EC RID: 1004
		private Class_182.NClass_0 field_13 = Class_182.NClass_0.field_28;

		// Token: 0x040003ED RID: 1005
		private uint field_14;

		// Token: 0x040003EE RID: 1006
		private uint field_15;

		// Token: 0x040003EF RID: 1007
		private uint field_16;

		// Token: 0x040003F0 RID: 1008
		private uint field_17;

		// Token: 0x040003F1 RID: 1009
		private int field_18;

		// Token: 0x040003F2 RID: 1010
		private int field_19;

		// Token: 0x040003F3 RID: 1011
		private int field_20;

		// Token: 0x040003F4 RID: 1012
		private int field_21;

		// Token: 0x040003F5 RID: 1013
		private int field_22;

		// Token: 0x040003F6 RID: 1014
		private int field_23;

		// Token: 0x040003F7 RID: 1015
		private int field_24;

		// Token: 0x040003F8 RID: 1016
		private int field_25;

		// Token: 0x040003F9 RID: 1017
		private char field_26;

		// Token: 0x040003FA RID: 1018
		private Class_182.NClass_1 field_27;

		// Token: 0x020000E9 RID: 233
		private enum NClass_0
		{
			// Token: 0x040003FC RID: 1020
			field_27,
			// Token: 0x040003FD RID: 1021
			field_28,
			// Token: 0x040003FE RID: 1022
			field_29,
			// Token: 0x040003FF RID: 1023
			field_30,
			// Token: 0x04000400 RID: 1024
			field_31,
			// Token: 0x04000401 RID: 1025
			field_32,
			// Token: 0x04000402 RID: 1026
			field_33,
			// Token: 0x04000403 RID: 1027
			field_34
		}

		// Token: 0x020000EA RID: 234
		private sealed class NClass_1
		{
			// Token: 0x0600068C RID: 1676 RVA: 0x0002AB44 File Offset: 0x00028D44
			public void nmethod_0(int sayıInt_0)
			{
				this.field_35 = new bool[256];
				this.field_36 = new byte[256];
				this.field_37 = new byte[Class_183.MaxSelectors];
				this.field_38 = new byte[Class_183.MaxSelectors];
				base..ctor();
				this.field_39 = new int[256];
				this.field_40 = Class_183.InitRectangularArray<int>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_41 = Class_183.InitRectangularArray<int>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_42 = Class_183.InitRectangularArray<int>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_43 = new int[Class_183.NGroups];
				this.field_44 = new int[257];
				this.field_45 = new byte[256];
				this.field_46 = Class_183.InitRectangularArray<char>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_47 = new byte[Class_183.NGroups];
				this.field_49 = new byte[sayıInt_0 * Class_183.BlockSizeMultiple];
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x0002AC50 File Offset: 0x00028E50
			public int[] nmethod_1(int sayıInt_0)
			{
				int[] array = this.field_48;
				if (array == null || array.Length < sayıInt_0)
				{
					array = (this.field_48 = new int[sayıInt_0]);
				}
				return array;
			}

			// Token: 0x04000404 RID: 1028
			public readonly bool[] field_35;

			// Token: 0x04000405 RID: 1029
			public readonly byte[] field_36;

			// Token: 0x04000406 RID: 1030
			public readonly byte[] field_37;

			// Token: 0x04000407 RID: 1031
			public readonly byte[] field_38;

			// Token: 0x04000408 RID: 1032
			public readonly int[] field_39;

			// Token: 0x04000409 RID: 1033
			public readonly int[][] field_40;

			// Token: 0x0400040A RID: 1034
			public readonly int[][] field_41;

			// Token: 0x0400040B RID: 1035
			public readonly int[][] field_42;

			// Token: 0x0400040C RID: 1036
			public readonly int[] field_43;

			// Token: 0x0400040D RID: 1037
			public readonly int[] field_44;

			// Token: 0x0400040E RID: 1038
			public readonly byte[] field_45;

			// Token: 0x0400040F RID: 1039
			public readonly char[][] field_46;

			// Token: 0x04000410 RID: 1040
			public readonly byte[] field_47;

			// Token: 0x04000411 RID: 1041
			public int[] field_48;

			// Token: 0x04000412 RID: 1042
			public byte[] field_49;
		}
	}
}
