using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x020000E0 RID: 224
	[ComVisible(true)]
	public class Class_176 : Stream
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x00025AC2 File Offset: 0x00023CC2
		public Class_176(Stream stream_) : this(stream_, false)
		{
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00025ACC File Offset: 0x00023CCC
		public Class_176(string str_0)
		{
			Stream stream_ = File.Open(str_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			this.gmethod_993(stream_, false, str_0);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00025AF2 File Offset: 0x00023CF2
		public Class_176(Stream stream_, bool bool_0)
		{
			this.gmethod_993(stream_, bool_0, null);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00025B04 File Offset: 0x00023D04
		private void gmethod_993(Stream stream_, bool bool_0, string str_0)
		{
			this.field_0 = stream_;
			if (!this.field_0.CanRead)
			{
				throw new Class_135("The stream must be readable.");
			}
			this.field_5 = new Class_178(this);
			this.field_1 = Encoding.GetEncoding("IBM437");
			this.field_11 = bool_0;
			this.field_13 = true;
			this.field_10 = (str_0 ?? "(stream)");
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00025B70 File Offset: 0x00023D70
		public virtual string cmethod_994()
		{
			return string.Format("ZipInputStream::{0}(leaveOpen({1})))", this.field_10, this.field_11);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00025B8D File Offset: 0x00023D8D
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00025B95 File Offset: 0x00023D95
		public Encoding prop_0
		{
			get
			{
				return this.field_1;
			}
			set
			{
				this.field_1 = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00025B9E File Offset: 0x00023D9E
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00025BA6 File Offset: 0x00023DA6
		public int prop_1 { get; set; }

		// Token: 0x170000F9 RID: 249
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00025BAF File Offset: 0x00023DAF
		public string prop_2
		{
			set
			{
				if (this.field_12)
				{
					this.field_14 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				this.field_8 = value;
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00025BD5 File Offset: 0x00023DD5
		private void smethod_1000()
		{
			this.field_6 = this.field_2.tmethod_682(this.field_8);
			this.field_7 = this.field_6.Length;
			this.field_4 = false;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x00025C06 File Offset: 0x00023E06
		internal Stream prop_3
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00025C10 File Offset: 0x00023E10
		public virtual int tmethod_1002(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_12)
			{
				this.field_14 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			if (this.field_4)
			{
				this.smethod_1000();
			}
			if (this.field_7 == 0L)
			{
				return 0;
			}
			int count = (this.field_7 > (long)sayıInt_1) ? sayıInt_1 : ((int)this.field_7);
			int num = this.field_6.Read(byteDizi_0, sayıInt_0, count);
			this.field_7 -= (long)num;
			if (this.field_7 == 0L)
			{
				int sayıInt_2 = this.field_6.prop_1;
				this.field_2.smethod_690(sayıInt_2);
				this.field_0.Seek(this.field_9, SeekOrigin.Begin);
			}
			return num;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00025CCC File Offset: 0x00023ECC
		public Class_163 gmethod_1003()
		{
			if (this.field_13)
			{
				long num = Class_155.FindSignature(this.field_0, 67324752);
				if (num == -1L)
				{
					return null;
				}
				this.field_0.Seek(-4L, SeekOrigin.Current);
			}
			else if (this.field_3)
			{
				this.field_0.Seek(this.field_9, SeekOrigin.Begin);
			}
			this.field_2 = Class_163.kmethod_707(this.field_5, !this.field_3);
			this.field_9 = this.field_0.Position;
			this.field_3 = true;
			this.field_4 = true;
			this.field_13 = false;
			return this.field_2;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00025D78 File Offset: 0x00023F78
		protected virtual void cmethod_1004(bool bool_0)
		{
			if (this.field_12)
			{
				return;
			}
			if (bool_0)
			{
				if (this.field_14)
				{
					return;
				}
				if (!this.field_11)
				{
					this.field_0.Dispose();
				}
			}
			this.field_12 = true;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public virtual bool prop_4
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00025DB8 File Offset: 0x00023FB8
		public virtual bool prop_5
		{
			get
			{
				return this.field_0.CanSeek;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_6
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00025DC5 File Offset: 0x00023FC5
		public virtual long prop_7
		{
			get
			{
				return this.field_0.Length;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00025DD2 File Offset: 0x00023FD2
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00025DDF File Offset: 0x00023FDF
		public virtual long prop_8
		{
			get
			{
				return this.field_0.Position;
			}
			set
			{
				this.Seek(value, SeekOrigin.Begin);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00025DEA File Offset: 0x00023FEA
		public virtual void xmethod_1011()
		{
			throw new NotSupportedException("Flush");
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00025DF6 File Offset: 0x00023FF6
		public virtual void tmethod_1012(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotSupportedException("Write");
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00025E04 File Offset: 0x00024004
		public virtual long gmethod_1013(long sayıUınt_0, SeekOrigin arg_0)
		{
			this.field_13 = true;
			return this.field_0.Seek(sayıUınt_0, arg_0);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void cmethod_1014(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000366 RID: 870
		private Stream field_0;

		// Token: 0x04000367 RID: 871
		private Encoding field_1;

		// Token: 0x04000368 RID: 872
		private Class_163 field_2;

		// Token: 0x04000369 RID: 873
		private bool field_3;

		// Token: 0x0400036A RID: 874
		private bool field_4;

		// Token: 0x0400036B RID: 875
		private Class_178 field_5;

		// Token: 0x0400036C RID: 876
		private Class_216 field_6;

		// Token: 0x0400036D RID: 877
		private long field_7;

		// Token: 0x0400036E RID: 878
		internal string field_8;

		// Token: 0x0400036F RID: 879
		private long field_9;

		// Token: 0x04000370 RID: 880
		private string field_10;

		// Token: 0x04000371 RID: 881
		private bool field_11;

		// Token: 0x04000372 RID: 882
		private bool field_12;

		// Token: 0x04000373 RID: 883
		private bool field_13;

		// Token: 0x04000374 RID: 884
		private bool field_14;

		// Token: 0x04000375 RID: 885
		[CompilerGenerated]
		private int field_15;
	}
}
