using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc
{
	// Token: 0x02000113 RID: 275
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	public class Class_215
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0003500C File Offset: 0x0003320C
		public long prop_0
		{
			get
			{
				return this.field_2;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00035014 File Offset: 0x00033214
		public int prop_1
		{
			get
			{
				return (int)(~(int)this.field_5);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0003501D File Offset: 0x0003321D
		public int vmethod_1365(Stream stream_)
		{
			return this.dmethod_1366(stream_, null);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00035028 File Offset: 0x00033228
		public int dmethod_1366(Stream stream_, Stream stream_)
		{
			if (stream_ == null)
			{
				throw new Exception("The input stream must not be null.");
			}
			byte[] array = new byte[8192];
			int count = 8192;
			this.field_2 = 0L;
			int i = stream_.Read(array, 0, count);
			if (stream_ != null)
			{
				stream_.Write(array, 0, i);
			}
			this.field_2 += (long)i;
			while (i > 0)
			{
				this.pmethod_1369(array, 0, i);
				i = stream_.Read(array, 0, count);
				if (stream_ != null)
				{
					stream_.Write(array, 0, i);
				}
				this.field_2 += (long)i;
			}
			return (int)(~(int)this.field_5);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000350C8 File Offset: 0x000332C8
		public int kmethod_1367(int sayıInt_0, byte byte_0)
		{
			return this.lmethod_1368((uint)sayıInt_0, byte_0);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000350D2 File Offset: 0x000332D2
		internal int lmethod_1368(uint arg_0, byte byte_0)
		{
			return (int)(this.field_4[(int)((UIntPtr)((arg_0 ^ (uint)byte_0) & 255U))] ^ arg_0 >> 8);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000350EC File Offset: 0x000332EC
		public void pmethod_1369(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (byteDizi_0 == null)
			{
				throw new Exception("The data buffer must not be null.");
			}
			for (int i = 0; i < sayıInt_1; i++)
			{
				int num = sayıInt_0 + i;
				byte b = byteDizi_0[num];
				if (this.field_3)
				{
					uint num2 = this.field_5 >> 24 ^ (uint)b;
					this.field_5 = (this.field_5 << 8 ^ this.field_4[(int)((UIntPtr)num2)]);
				}
				else
				{
					uint num3 = (this.field_5 & 255U) ^ (uint)b;
					this.field_5 = (this.field_5 >> 8 ^ this.field_4[(int)((UIntPtr)num3)]);
				}
			}
			this.field_2 += (long)sayıInt_1;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00035190 File Offset: 0x00033390
		public void smethod_1370(byte byte_0)
		{
			if (this.field_3)
			{
				uint num = this.field_5 >> 24 ^ (uint)byte_0;
				this.field_5 = (this.field_5 << 8 ^ this.field_4[(int)((UIntPtr)num)]);
				return;
			}
			uint num2 = (this.field_5 & 255U) ^ (uint)byte_0;
			this.field_5 = (this.field_5 >> 8 ^ this.field_4[(int)((UIntPtr)num2)]);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000351F4 File Offset: 0x000333F4
		public void xmethod_1371(byte byte_0, int sayıInt_0)
		{
			while (sayıInt_0-- > 0)
			{
				if (this.field_3)
				{
					uint num = this.field_5 >> 24 ^ (uint)byte_0;
					this.field_5 = (this.field_5 << 8 ^ this.field_4[(int)((UIntPtr)((num >= 0U) ? num : (num + 256U)))]);
				}
				else
				{
					uint num2 = (this.field_5 & 255U) ^ (uint)byte_0;
					this.field_5 = (this.field_5 >> 8 ^ this.field_4[(int)((UIntPtr)((num2 >= 0U) ? num2 : (num2 + 256U)))]);
				}
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00035294 File Offset: 0x00033494
		private static uint tmethod_1372(uint arg_0)
		{
			uint num = (arg_0 & 1431655765U) << 1 | (arg_0 >> 1 & 1431655765U);
			num = ((num & 858993459U) << 2 | (num >> 2 & 858993459U));
			num = ((num & 252645135U) << 4 | (num >> 4 & 252645135U));
			return num << 24 | (num & 65280U) << 8 | (num >> 8 & 65280U) | num >> 24;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00035300 File Offset: 0x00033500
		private static byte gmethod_1373(byte byte_0)
		{
			uint num = (uint)byte_0 * 131586U;
			uint num2 = 17055760U;
			uint num3 = num & num2;
			uint num4 = num << 2 & num2 << 1;
			return (byte)(16781313U * (num3 + num4) >> 24);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00035334 File Offset: 0x00033534
		private void cmethod_1374()
		{
			this.field_4 = new uint[256];
			byte b = 0;
			do
			{
				uint num = (uint)b;
				for (byte b2 = 8; b2 > 0; b2 -= 1)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ this.field_1);
					}
					else
					{
						num >>= 1;
					}
				}
				if (this.field_3)
				{
					this.field_4[(int)Class_215.gmethod_1373(b)] = Class_215.tmethod_1372(num);
				}
				else
				{
					this.field_4[(int)b] = num;
				}
				b += 1;
			}
			while (b != 0);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000353B8 File Offset: 0x000335B8
		private uint vmethod_1375(uint[] arg_0, uint arg_1)
		{
			uint num = 0U;
			int num2 = 0;
			while (arg_1 != 0U)
			{
				if ((arg_1 & 1U) == 1U)
				{
					num ^= arg_0[num2];
				}
				arg_1 >>= 1;
				num2++;
			}
			return num;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000353EC File Offset: 0x000335EC
		private void dmethod_1376(uint[] arg_0, uint[] arg_1)
		{
			for (int i = 0; i < 32; i++)
			{
				arg_0[i] = this.vmethod_1375(arg_1, arg_1[i]);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00035418 File Offset: 0x00033618
		public void kmethod_1377(int sayıInt_0, int sayıInt_1)
		{
			uint[] array = new uint[32];
			uint[] array2 = new uint[32];
			if (sayıInt_1 == 0)
			{
				return;
			}
			uint num = ~this.field_5;
			array2[0] = this.field_1;
			uint num2 = 1U;
			for (int i = 1; i < 32; i++)
			{
				array2[i] = num2;
				num2 <<= 1;
			}
			this.dmethod_1376(array, array2);
			this.dmethod_1376(array2, array);
			uint num3 = (uint)sayıInt_1;
			do
			{
				this.dmethod_1376(array, array2);
				if ((num3 & 1U) == 1U)
				{
					num = this.vmethod_1375(array, num);
				}
				num3 >>= 1;
				if (num3 == 0U)
				{
					break;
				}
				this.dmethod_1376(array2, array);
				if ((num3 & 1U) == 1U)
				{
					num = this.vmethod_1375(array2, num);
				}
				num3 >>= 1;
			}
			while (num3 != 0U);
			num ^= (uint)sayıInt_0;
			this.field_5 = ~num;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000354DE File Offset: 0x000336DE
		public Class_215() : this(false)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000354E7 File Offset: 0x000336E7
		public Class_215(bool bool_0) : this(-306674912, bool_0)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000354F5 File Offset: 0x000336F5
		public Class_215(int sayıInt_0, bool bool_0)
		{
			this.field_3 = bool_0;
			this.field_1 = (uint)sayıInt_0;
			this.cmethod_1374();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00035518 File Offset: 0x00033718
		public void lmethod_1378()
		{
			this.field_5 = uint.MaxValue;
		}

		// Token: 0x040005D0 RID: 1488
		private const int field_0 = 8192;

		// Token: 0x040005D1 RID: 1489
		private uint field_1;

		// Token: 0x040005D2 RID: 1490
		private long field_2;

		// Token: 0x040005D3 RID: 1491
		private bool field_3;

		// Token: 0x040005D4 RID: 1492
		private uint[] field_4;

		// Token: 0x040005D5 RID: 1493
		private uint field_5 = uint.MaxValue;
	}
}
