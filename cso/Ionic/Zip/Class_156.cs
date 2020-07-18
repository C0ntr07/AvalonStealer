using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Zip
{
	// Token: 0x020000C5 RID: 197
	[ComVisible(true)]
	public class Class_156 : Stream
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x00018DC4 File Offset: 0x00016FC4
		public Class_156(Stream stream_)
		{
			this.field_0 = stream_;
			try
			{
				this.field_3 = this.field_0.Position;
			}
			catch
			{
				this.field_3 = 0L;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00018E14 File Offset: 0x00017014
		public Stream prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00018E1C File Offset: 0x0001701C
		public long prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00018E24 File Offset: 0x00017024
		public long prop_2
		{
			get
			{
				return this.field_2;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00018E2C File Offset: 0x0001702C
		public void cmethod_524(long sayıUınt_0)
		{
			this.field_1 -= sayıUınt_0;
			if (this.field_1 < 0L)
			{
				throw new InvalidOperationException();
			}
			if (this.field_0 is Class_156)
			{
				((Class_156)this.field_0).cmethod_524(sayıUınt_0);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00018E7C File Offset: 0x0001707C
		public virtual int vmethod_525(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			int num = this.field_0.Read(byteDizi_0, sayıInt_0, sayıInt_1);
			this.field_2 += (long)num;
			return num;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00018EA8 File Offset: 0x000170A8
		public virtual void dmethod_526(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_1 == 0)
			{
				return;
			}
			this.field_0.Write(byteDizi_0, sayıInt_0, sayıInt_1);
			this.field_1 += (long)sayıInt_1;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00018ECE File Offset: 0x000170CE
		public virtual bool prop_3
		{
			get
			{
				return this.field_0.CanRead;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00018EDB File Offset: 0x000170DB
		public virtual bool prop_4
		{
			get
			{
				return this.field_0.CanSeek;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00018EE8 File Offset: 0x000170E8
		public virtual bool prop_5
		{
			get
			{
				return this.field_0.CanWrite;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00018EF5 File Offset: 0x000170F5
		public virtual void smethod_530()
		{
			this.field_0.Flush();
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00018F02 File Offset: 0x00017102
		public virtual long prop_6
		{
			get
			{
				return this.field_0.Length;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00018F0F File Offset: 0x0001710F
		public long prop_7
		{
			get
			{
				return this.field_3 + this.field_1;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00018F1E File Offset: 0x0001711E
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00018F2B File Offset: 0x0001712B
		public virtual long prop_8
		{
			get
			{
				return this.field_0.Position;
			}
			set
			{
				this.field_0.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00018F3B File Offset: 0x0001713B
		public virtual long vmethod_535(long sayıUınt_0, SeekOrigin arg_0)
		{
			return this.field_0.Seek(sayıUınt_0, arg_0);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00018F4A File Offset: 0x0001714A
		public virtual void dmethod_536(long sayıUınt_0)
		{
			this.field_0.SetLength(sayıUınt_0);
		}

		// Token: 0x04000251 RID: 593
		private Stream field_0;

		// Token: 0x04000252 RID: 594
		private long field_1;

		// Token: 0x04000253 RID: 595
		private long field_2;

		// Token: 0x04000254 RID: 596
		private long field_3;
	}
}
