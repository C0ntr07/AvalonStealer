using System;
using System.IO;
using System.Threading;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200014F RID: 335
	public class Class_246 : Stream
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x0003C072 File Offset: 0x0003A272
		public Class_246(Stream stream_, CancellationToken arg_0)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.field_0 = stream_;
			this.field_1 = arg_0;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0003C09C File Offset: 0x0003A29C
		public virtual bool prop_0
		{
			get
			{
				this.field_1.ThrowIfCancellationRequested();
				return this.field_0.CanRead;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
		public virtual bool prop_1
		{
			get
			{
				this.field_1.ThrowIfCancellationRequested();
				return this.field_0.CanSeek;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0003C0EC File Offset: 0x0003A2EC
		public virtual bool prop_2
		{
			get
			{
				this.field_1.ThrowIfCancellationRequested();
				return this.field_0.CanWrite;
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0003C114 File Offset: 0x0003A314
		public virtual void vmethod_1675()
		{
			this.field_1.ThrowIfCancellationRequested();
			this.field_0.Flush();
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0003C13C File Offset: 0x0003A33C
		public virtual long prop_3
		{
			get
			{
				this.field_1.ThrowIfCancellationRequested();
				return this.field_0.Length;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0003C164 File Offset: 0x0003A364
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0003C18C File Offset: 0x0003A38C
		public virtual long prop_4
		{
			get
			{
				this.field_1.ThrowIfCancellationRequested();
				return this.field_0.Position;
			}
			set
			{
				this.field_1.ThrowIfCancellationRequested();
				this.field_0.Position = value;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0003C1B4 File Offset: 0x0003A3B4
		public virtual int pmethod_1679(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			this.field_1.ThrowIfCancellationRequested();
			return this.field_0.Read(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0003C1E0 File Offset: 0x0003A3E0
		public virtual long smethod_1680(long sayıUınt_0, SeekOrigin arg_0)
		{
			this.field_1.ThrowIfCancellationRequested();
			return this.field_0.Seek(sayıUınt_0, arg_0);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0003C208 File Offset: 0x0003A408
		public virtual void xmethod_1681(long sayıUınt_0)
		{
			this.field_1.ThrowIfCancellationRequested();
			this.field_0.SetLength(sayıUınt_0);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0003C230 File Offset: 0x0003A430
		public virtual void tmethod_1682(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			this.field_1.ThrowIfCancellationRequested();
			this.field_0.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0003C259 File Offset: 0x0003A459
		protected virtual void gmethod_1683(bool bool_0)
		{
			if (bool_0)
			{
				Stream stream = this.field_0;
				if (stream != null)
				{
					stream.Dispose();
				}
				this.field_0 = null;
			}
		}

		// Token: 0x04000688 RID: 1672
		private Stream field_0;

		// Token: 0x04000689 RID: 1673
		private readonly CancellationToken field_1;
	}
}
