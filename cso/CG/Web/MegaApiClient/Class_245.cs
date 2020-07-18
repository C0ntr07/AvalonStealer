using System;
using System.IO;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200014E RID: 334
	internal class Class_245 : Stream
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x0003BF5F File Offset: 0x0003A15F
		public Class_245(Stream stream_)
		{
			this.field_1 = stream_;
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0003BF7E File Offset: 0x0003A17E
		public byte[] prop_0
		{
			get
			{
				return this.field_2;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0003BF86 File Offset: 0x0003A186
		public int prop_1
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0003BF8E File Offset: 0x0003A18E
		public int prop_2
		{
			get
			{
				return this.field_4;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void smethod_1660()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long xmethod_1661(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void tmethod_1662(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003BF98 File Offset: 0x0003A198
		public virtual int gmethod_1663(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			int num = 0;
			do
			{
				int num2 = Math.Min(this.field_4, sayıInt_1);
				if (num2 != 0)
				{
					Array.Copy(this.field_2, this.field_3, byteDizi_0, sayıInt_0, num2);
					sayıInt_0 += num2;
					sayıInt_1 -= num2;
					this.field_3 += num2;
					this.field_4 -= num2;
					num += num2;
				}
				if (sayıInt_1 == 0)
				{
					break;
				}
				this.field_3 = 0;
				this.field_4 = 0;
				this.cmethod_1664();
			}
			while (this.field_4 != 0);
			return num;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0003C01C File Offset: 0x0003A21C
		public void cmethod_1664()
		{
			for (;;)
			{
				int num = this.field_3 + this.field_4;
				int num2 = this.field_2.Length - num;
				if (num2 == 0)
				{
					break;
				}
				int num3 = this.field_1.Read(this.field_2, num, num2);
				if (num3 == 0)
				{
					break;
				}
				this.field_4 += num3;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void vmethod_1665(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public virtual bool prop_3
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_4
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_5
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_6
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00018443 File Offset: 0x00016643
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_7
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x04000683 RID: 1667
		private const int field_0 = 65536;

		// Token: 0x04000684 RID: 1668
		private Stream field_1;

		// Token: 0x04000685 RID: 1669
		private byte[] field_2 = new byte[65536];

		// Token: 0x04000686 RID: 1670
		private int field_3;

		// Token: 0x04000687 RID: 1671
		private int field_4;
	}
}
