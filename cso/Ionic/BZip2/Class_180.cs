using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x020000E5 RID: 229
	internal class Class_180
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00027090 File Offset: 0x00025290
		public Class_180(Stream stream_)
		{
			this.field_2 = stream_;
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0002709F File Offset: 0x0002529F
		public byte prop_0
		{
			get
			{
				return (byte)(this.field_0 >> 32 - this.field_1 & 255U);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x000270BB File Offset: 0x000252BB
		public int prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x000270C3 File Offset: 0x000252C3
		public int prop_2
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000270CB File Offset: 0x000252CB
		public void dmethod_1116()
		{
			this.field_0 = 0U;
			this.field_1 = 0;
			this.field_3 = 0;
			this.field_2.Seek(0L, SeekOrigin.Begin);
			this.field_2.SetLength(0L);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00027100 File Offset: 0x00025300
		public void kmethod_1117(int sayıInt_0, uint arg_0)
		{
			int i = this.field_1;
			uint num = this.field_0;
			while (i >= 8)
			{
				this.field_2.WriteByte((byte)(num >> 24 & 255U));
				this.field_3++;
				num <<= 8;
				i -= 8;
			}
			this.field_0 = (num | arg_0 << 32 - i - sayıInt_0);
			this.field_1 = i + sayıInt_0;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002716C File Offset: 0x0002536C
		public void lmethod_1118(byte byte_0)
		{
			this.kmethod_1117(8, (uint)byte_0);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00027178 File Offset: 0x00025378
		public void pmethod_1119(uint arg_0)
		{
			this.kmethod_1117(8, arg_0 >> 24 & 255U);
			this.kmethod_1117(8, arg_0 >> 16 & 255U);
			this.kmethod_1117(8, arg_0 >> 8 & 255U);
			this.kmethod_1117(8, arg_0 & 255U);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000271C5 File Offset: 0x000253C5
		public void smethod_1120()
		{
			this.kmethod_1117(0, 0U);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000271D0 File Offset: 0x000253D0
		public void xmethod_1121()
		{
			this.smethod_1120();
			if (this.prop_1 > 0)
			{
				byte value = (byte)(this.field_0 >> 24 & 255U);
				this.field_2.WriteByte(value);
				this.field_3++;
			}
		}

		// Token: 0x040003A6 RID: 934
		private uint field_0;

		// Token: 0x040003A7 RID: 935
		private int field_1;

		// Token: 0x040003A8 RID: 936
		private Stream field_2;

		// Token: 0x040003A9 RID: 937
		private int field_3;
	}
}
