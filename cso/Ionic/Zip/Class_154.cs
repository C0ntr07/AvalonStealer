using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x020000C3 RID: 195
	internal class Class_154 : Stream, IDisposable
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00018418 File Offset: 0x00016618
		public Class_154(Stream stream_)
		{
			this.field_0 = stream_.Position;
			this.field_1 = stream_;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00018433 File Offset: 0x00016633
		public virtual int lmethod_508(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			return this.field_1.Read(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void pmethod_509(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0001844A File Offset: 0x0001664A
		public virtual bool prop_0
		{
			get
			{
				return this.field_1.CanRead;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00018457 File Offset: 0x00016657
		public virtual bool prop_1
		{
			get
			{
				return this.field_1.CanSeek;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00018467 File Offset: 0x00016667
		public virtual void gmethod_513()
		{
			this.field_1.Flush();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00018474 File Offset: 0x00016674
		public virtual long prop_3
		{
			get
			{
				return this.field_1.Length;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00018481 File Offset: 0x00016681
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00018495 File Offset: 0x00016695
		public virtual long prop_4
		{
			get
			{
				return this.field_1.Position - this.field_0;
			}
			set
			{
				this.field_1.Position = this.field_0 + value;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000184AA File Offset: 0x000166AA
		public virtual long kmethod_517(long sayıUınt_0, SeekOrigin arg_0)
		{
			return this.field_1.Seek(this.field_0 + sayıUınt_0, arg_0) - this.field_0;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void lmethod_518(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000184C7 File Offset: 0x000166C7
		void IDisposable.pmethod_519()
		{
			this.Close();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000184CF File Offset: 0x000166CF
		public virtual void smethod_520()
		{
			base.Close();
		}

		// Token: 0x0400024C RID: 588
		private long field_0;

		// Token: 0x0400024D RID: 589
		private Stream field_1;
	}
}
