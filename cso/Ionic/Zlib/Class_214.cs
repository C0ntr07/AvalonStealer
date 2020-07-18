using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x02000112 RID: 274
	[ComVisible(true)]
	public class Class_214 : Stream
	{
		// Token: 0x060007BC RID: 1980 RVA: 0x00034C53 File Offset: 0x00032E53
		public Class_214(Stream stream_, Class_204 arg_0) : this(stream_, arg_0, Class_202.Default, false)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00034C5F File Offset: 0x00032E5F
		public Class_214(Stream stream_, Class_204 arg_0, Class_202 arg_1) : this(stream_, arg_0, arg_1, false)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00034C6B File Offset: 0x00032E6B
		public Class_214(Stream stream_, Class_204 arg_0, bool bool_0) : this(stream_, arg_0, Class_202.Default, bool_0)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00034C77 File Offset: 0x00032E77
		public Class_214(Stream stream_, Class_204 arg_0, Class_202 arg_1, bool bool_0)
		{
			this.field_0 = new Class_211(stream_, arg_0, arg_1, Class_210.ZLIB, bool_0);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00034C94 File Offset: 0x00032E94
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00034CA1 File Offset: 0x00032EA1
		public virtual Class_201 prop_0
		{
			get
			{
				return this.field_0.field_2;
			}
			set
			{
				if (this.field_1)
				{
					throw new ObjectDisposedException("ZlibStream");
				}
				this.field_0.field_2 = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00034CC5 File Offset: 0x00032EC5
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00034CD4 File Offset: 0x00032ED4
		public int prop_1
		{
			get
			{
				return this.field_0.field_8;
			}
			set
			{
				if (this.field_1)
				{
					throw new ObjectDisposedException("ZlibStream");
				}
				if (this.field_0.field_7 != null)
				{
					throw new Class_205("The working buffer is already set.");
				}
				if (value < 1024)
				{
					throw new Class_205(string.Format("Don't be silly. {0} bytes?? Use a bigger buffer, at least {1}.", value, 1024));
				}
				this.field_0.field_8 = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00034D49 File Offset: 0x00032F49
		public virtual long prop_2
		{
			get
			{
				return this.field_0.field_0.TotalBytesIn;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00034D5B File Offset: 0x00032F5B
		public virtual long prop_3
		{
			get
			{
				return this.field_0.field_0.TotalBytesOut;
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00034D70 File Offset: 0x00032F70
		protected virtual void kmethod_1347(bool bool_0)
		{
			try
			{
				if (!this.field_1)
				{
					if (bool_0 && this.field_0 != null)
					{
						this.field_0.Close();
					}
					this.field_1 = true;
				}
			}
			finally
			{
				base.Dispose(bool_0);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00034DC8 File Offset: 0x00032FC8
		public virtual bool prop_4
		{
			get
			{
				if (this.field_1)
				{
					throw new ObjectDisposedException("ZlibStream");
				}
				return this.field_0.field_10.CanRead;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_5
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00034DF0 File Offset: 0x00032FF0
		public virtual bool prop_6
		{
			get
			{
				if (this.field_1)
				{
					throw new ObjectDisposedException("ZlibStream");
				}
				return this.field_0.field_10.CanWrite;
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00034E18 File Offset: 0x00033018
		public virtual void xmethod_1351()
		{
			if (this.field_1)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			this.field_0.Flush();
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_7
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00034E3C File Offset: 0x0003303C
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_8
		{
			get
			{
				if (this.field_0.field_1 == Class_211.NClass_0.field_1)
				{
					return this.field_0.field_0.TotalBytesOut;
				}
				if (this.field_0.field_1 == Class_211.NClass_0.field_2)
				{
					return this.field_0.field_0.TotalBytesIn;
				}
				return 0L;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00034E8E File Offset: 0x0003308E
		public virtual int vmethod_1355(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_1)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			return this.field_0.Read(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long dmethod_1356(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void kmethod_1357(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00034EB4 File Offset: 0x000330B4
		public virtual void lmethod_1358(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_1)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			this.field_0.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00034EDC File Offset: 0x000330DC
		public static byte[] pmethod_1359(string str_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_214(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.kmethod_1337(str_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00034F2C File Offset: 0x0003312C
		public static byte[] smethod_1360(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_214(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.lmethod_1338(byteDizi_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00034F7C File Offset: 0x0003317C
		public static string xmethod_1361(byte[] byteDizi_0)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_214(memoryStream, Class_204.Decompress);
				result = Class_211.pmethod_1339(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00034FC4 File Offset: 0x000331C4
		public static byte[] tmethod_1362(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_214(memoryStream, Class_204.Decompress);
				result = Class_211.smethod_1340(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x040005CE RID: 1486
		internal Class_211 field_0;

		// Token: 0x040005CF RID: 1487
		private bool field_1;
	}
}
