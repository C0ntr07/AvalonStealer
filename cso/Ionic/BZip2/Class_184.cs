using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x020000EC RID: 236
	[ComVisible(true)]
	public class Class_184 : Stream
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0002AD2F File Offset: 0x00028F2F
		public Class_184(Stream stream_) : this(stream_, Class_183.MaxBlockSize, false)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002AD3E File Offset: 0x00028F3E
		public Class_184(Stream stream_, int sayıInt_0) : this(stream_, sayıInt_0, false)
		{
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002AD49 File Offset: 0x00028F49
		public Class_184(Stream stream_, bool bool_0) : this(stream_, Class_183.MaxBlockSize, bool_0)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002AD58 File Offset: 0x00028F58
		public Class_184(Stream stream_, int sayıInt_0, bool bool_0)
		{
			if (sayıInt_0 < Class_183.MinBlockSize || sayıInt_0 > Class_183.MaxBlockSize)
			{
				string message = string.Format("blockSize={0} is out of range; must be between {1} and {2}", sayıInt_0, Class_183.MinBlockSize, Class_183.MaxBlockSize);
				throw new ArgumentException(message, "blockSize");
			}
			this.field_4 = stream_;
			if (!this.field_4.CanWrite)
			{
				throw new ArgumentException("The stream is not writable.", "output");
			}
			this.field_5 = new Class_180(this.field_4);
			this.field_6 = sayıInt_0;
			this.field_2 = new Class_181(this.field_5, sayıInt_0);
			this.field_1 = bool_0;
			this.field_3 = 0U;
			this.xmethod_1191();
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002AE20 File Offset: 0x00029020
		public virtual void pmethod_1189()
		{
			if (this.field_4 != null)
			{
				Stream stream = this.field_4;
				this.gmethod_1193();
				if (!this.field_1)
				{
					stream.Close();
				}
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002AE56 File Offset: 0x00029056
		public virtual void smethod_1190()
		{
			if (this.field_4 != null)
			{
				this.field_5.smethod_1120();
				this.field_4.Flush();
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002AE7C File Offset: 0x0002907C
		private void xmethod_1191()
		{
			byte[] array = new byte[]
			{
				66,
				90,
				104,
				0
			};
			array[3] = (byte)(48 + this.field_6);
			byte[] array2 = array;
			this.field_4.Write(array2, 0, array2.Length);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002AEBC File Offset: 0x000290BC
		private void tmethod_1192()
		{
			this.field_5.lmethod_1118(23);
			this.field_5.lmethod_1118(114);
			this.field_5.lmethod_1118(69);
			this.field_5.lmethod_1118(56);
			this.field_5.lmethod_1118(80);
			this.field_5.lmethod_1118(144);
			this.field_5.pmethod_1119(this.field_3);
			this.field_5.xmethod_1121();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002AF38 File Offset: 0x00029138
		private void gmethod_1193()
		{
			try
			{
				this.field_5.prop_2;
				this.field_2.tmethod_1132();
				this.field_3 = (this.field_3 << 1 | this.field_3 >> 31);
				this.field_3 ^= this.field_2.prop_1;
				this.tmethod_1192();
			}
			finally
			{
				this.field_4 = null;
				this.field_2 = null;
				this.field_5 = null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002AFC0 File Offset: 0x000291C0
		public int prop_0
		{
			get
			{
				return this.field_6;
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002AFC8 File Offset: 0x000291C8
		public virtual void vmethod_1195(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
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
			if (this.field_4 == null)
			{
				throw new IOException("the stream is not open");
			}
			if (sayıInt_1 == 0)
			{
				return;
			}
			int num = 0;
			int num2 = sayıInt_1;
			do
			{
				int num3 = this.field_2.pmethod_1129(byteDizi_0, sayıInt_0, num2);
				if (num3 != num2)
				{
					this.field_5.prop_2;
					this.field_2.tmethod_1132();
					this.field_3 = (this.field_3 << 1 | this.field_3 >> 31);
					this.field_3 ^= this.field_2.prop_1;
					sayıInt_0 += num3;
				}
				num2 -= num3;
				num += num3;
			}
			while (num2 > 0);
			this.field_0 += num;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_1
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0002B0DB File Offset: 0x000292DB
		public virtual bool prop_3
		{
			get
			{
				if (this.field_4 == null)
				{
					throw new ObjectDisposedException("BZip2Stream");
				}
				return this.field_4.CanWrite;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_4
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x0002B0FE File Offset: 0x000292FE
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_5
		{
			get
			{
				return (long)this.field_0;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long tmethod_1202(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void gmethod_1203(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00018443 File Offset: 0x00016643
		public virtual int cmethod_1204(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0002B108 File Offset: 0x00029308
		[Conditional("Trace")]
		private void vmethod_1205(Class_184.NClass_0 arg_0, string str_0, params object[] arg_1)
		{
			if ((arg_0 & this.field_7) != Class_184.NClass_0.field_29)
			{
				int hashCode = Thread.CurrentThread.GetHashCode();
				Console.ForegroundColor = hashCode % 8 + ConsoleColor.Green;
				Console.Write("{0:000} PBOS ", hashCode);
				Console.WriteLine(str_0, arg_1);
				Console.ResetColor();
			}
		}

		// Token: 0x04000420 RID: 1056
		private int field_0;

		// Token: 0x04000421 RID: 1057
		private bool field_1;

		// Token: 0x04000422 RID: 1058
		private Class_181 field_2;

		// Token: 0x04000423 RID: 1059
		private uint field_3;

		// Token: 0x04000424 RID: 1060
		private Stream field_4;

		// Token: 0x04000425 RID: 1061
		private Class_180 field_5;

		// Token: 0x04000426 RID: 1062
		private int field_6;

		// Token: 0x04000427 RID: 1063
		private Class_184.NClass_0 field_7 = Class_184.NClass_0.field_30 | Class_184.NClass_0.field_31;

		// Token: 0x020000ED RID: 237
		[Flags]
		private enum NClass_0 : uint
		{
			// Token: 0x04000429 RID: 1065
			field_29 = 0U,
			// Token: 0x0400042A RID: 1066
			field_30 = 1U,
			// Token: 0x0400042B RID: 1067
			field_31 = 2U,
			// Token: 0x0400042C RID: 1068
			field_32 = 4294967295U
		}
	}
}
