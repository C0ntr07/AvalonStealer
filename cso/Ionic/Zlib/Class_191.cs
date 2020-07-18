using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x020000F7 RID: 247
	[ComVisible(true)]
	public class Class_191 : Stream
	{
		// Token: 0x060006F6 RID: 1782 RVA: 0x0002E382 File Offset: 0x0002C582
		public Class_191(Stream stream_, Class_204 arg_0) : this(stream_, arg_0, Class_202.Default, false)
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0002E38E File Offset: 0x0002C58E
		public Class_191(Stream stream_, Class_204 arg_0, Class_202 arg_1) : this(stream_, arg_0, arg_1, false)
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0002E39A File Offset: 0x0002C59A
		public Class_191(Stream stream_, Class_204 arg_0, bool bool_0) : this(stream_, arg_0, Class_202.Default, bool_0)
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0002E3A6 File Offset: 0x0002C5A6
		public Class_191(Stream stream_, Class_204 arg_0, Class_202 arg_1, bool bool_0)
		{
			this.field_1 = stream_;
			this.field_0 = new Class_211(stream_, arg_0, arg_1, Class_210.DEFLATE, bool_0);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0002E3CA File Offset: 0x0002C5CA
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0002E3D7 File Offset: 0x0002C5D7
		public virtual Class_201 prop_0
		{
			get
			{
				return this.field_0.field_2;
			}
			set
			{
				if (this.field_2)
				{
					throw new ObjectDisposedException("DeflateStream");
				}
				this.field_0.field_2 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002E3FB File Offset: 0x0002C5FB
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0002E408 File Offset: 0x0002C608
		public int prop_1
		{
			get
			{
				return this.field_0.field_8;
			}
			set
			{
				if (this.field_2)
				{
					throw new ObjectDisposedException("DeflateStream");
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

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0002E47D File Offset: 0x0002C67D
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0002E48A File Offset: 0x0002C68A
		public Class_203 prop_2
		{
			get
			{
				return this.field_0.field_11;
			}
			set
			{
				if (this.field_2)
				{
					throw new ObjectDisposedException("DeflateStream");
				}
				this.field_0.field_11 = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0002E4AE File Offset: 0x0002C6AE
		public virtual long prop_3
		{
			get
			{
				return this.field_0.field_0.TotalBytesIn;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0002E4C0 File Offset: 0x0002C6C0
		public virtual long prop_4
		{
			get
			{
				return this.field_0.field_0.TotalBytesOut;
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
		protected virtual void pmethod_1239(bool bool_0)
		{
			try
			{
				if (!this.field_2)
				{
					if (bool_0 && this.field_0 != null)
					{
						this.field_0.Close();
					}
					this.field_2 = true;
				}
			}
			finally
			{
				base.Dispose(bool_0);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0002E52C File Offset: 0x0002C72C
		public virtual bool prop_5
		{
			get
			{
				if (this.field_2)
				{
					throw new ObjectDisposedException("DeflateStream");
				}
				return this.field_0.field_10.CanRead;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_6
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0002E554 File Offset: 0x0002C754
		public virtual bool prop_7
		{
			get
			{
				if (this.field_2)
				{
					throw new ObjectDisposedException("DeflateStream");
				}
				return this.field_0.field_10.CanWrite;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0002E57C File Offset: 0x0002C77C
		public virtual void gmethod_1243()
		{
			if (this.field_2)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			this.field_0.Flush();
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_8
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_9
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
				throw new NotImplementedException();
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0002E5F2 File Offset: 0x0002C7F2
		public virtual int kmethod_1247(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_2)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			return this.field_0.Read(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long lmethod_1248(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void pmethod_1249(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002E618 File Offset: 0x0002C818
		public virtual void smethod_1250(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_2)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			this.field_0.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0002E640 File Offset: 0x0002C840
		public static byte[] xmethod_1251(string str_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_191(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.kmethod_1337(str_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0002E690 File Offset: 0x0002C890
		public static byte[] tmethod_1252(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_191(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.lmethod_1338(byteDizi_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0002E6E0 File Offset: 0x0002C8E0
		public static string gmethod_1253(byte[] byteDizi_0)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_191(memoryStream, Class_204.Decompress);
				result = Class_211.pmethod_1339(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0002E728 File Offset: 0x0002C928
		public static byte[] cmethod_1254(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_191(memoryStream, Class_204.Decompress);
				result = Class_211.smethod_1340(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x040004AA RID: 1194
		internal Class_211 field_0;

		// Token: 0x040004AB RID: 1195
		internal Stream field_1;

		// Token: 0x040004AC RID: 1196
		private bool field_2;
	}
}
