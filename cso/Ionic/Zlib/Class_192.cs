using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Ionic.Zlib
{
	// Token: 0x020000F8 RID: 248
	[ComVisible(true)]
	public class Class_192 : Stream
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0002E770 File Offset: 0x0002C970
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0002E778 File Offset: 0x0002C978
		public string prop_0
		{
			get
			{
				return this.field_6;
			}
			set
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				this.field_6 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0002E797 File Offset: 0x0002C997
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0002E7A0 File Offset: 0x0002C9A0
		public string prop_1
		{
			get
			{
				return this.field_5;
			}
			set
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				this.field_5 = value;
				if (this.field_5 == null)
				{
					return;
				}
				if (this.field_5.IndexOf("/") != -1)
				{
					this.field_5 = this.field_5.Replace("/", "\\");
				}
				if (this.field_5.EndsWith("\\"))
				{
					throw new Exception("Illegal filename");
				}
				if (this.field_5.IndexOf("\\") != -1)
				{
					this.field_5 = Path.GetFileName(this.field_5);
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002E84E File Offset: 0x0002CA4E
		public int prop_2
		{
			get
			{
				return this.field_7;
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0002E856 File Offset: 0x0002CA56
		public Class_192(Stream stream_, Class_204 arg_0) : this(stream_, arg_0, Class_202.Default, false)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0002E862 File Offset: 0x0002CA62
		public Class_192(Stream stream_, Class_204 arg_0, Class_202 arg_1) : this(stream_, arg_0, arg_1, false)
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0002E86E File Offset: 0x0002CA6E
		public Class_192(Stream stream_, Class_204 arg_0, bool bool_0) : this(stream_, arg_0, Class_202.Default, bool_0)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0002E87A File Offset: 0x0002CA7A
		public Class_192(Stream stream_, Class_204 arg_0, Class_202 arg_1, bool bool_0)
		{
			this.field_2 = new Class_211(stream_, arg_0, arg_1, Class_210.GZIP, bool_0);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002E897 File Offset: 0x0002CA97
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x0002E8A4 File Offset: 0x0002CAA4
		public virtual Class_201 prop_3
		{
			get
			{
				return this.field_2.field_2;
			}
			set
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				this.field_2.field_2 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		public int prop_4
		{
			get
			{
				return this.field_2.field_8;
			}
			set
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				if (this.field_2.field_7 != null)
				{
					throw new Class_205("The working buffer is already set.");
				}
				if (value < 1024)
				{
					throw new Class_205(string.Format("Don't be silly. {0} bytes?? Use a bigger buffer, at least {1}.", value, 1024));
				}
				this.field_2.field_8 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0002E94D File Offset: 0x0002CB4D
		public virtual long prop_5
		{
			get
			{
				return this.field_2.field_0.TotalBytesIn;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0002E95F File Offset: 0x0002CB5F
		public virtual long prop_6
		{
			get
			{
				return this.field_2.field_0.TotalBytesOut;
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0002E974 File Offset: 0x0002CB74
		protected virtual void dmethod_1266(bool bool_0)
		{
			try
			{
				if (!this.field_3)
				{
					if (bool_0 && this.field_2 != null)
					{
						this.field_2.Close();
						this.field_7 = this.field_2.prop_0;
					}
					this.field_3 = true;
				}
			}
			finally
			{
				base.Dispose(bool_0);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		public virtual bool prop_7
		{
			get
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				return this.field_2.field_10.CanRead;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_8
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0002EA08 File Offset: 0x0002CC08
		public virtual bool prop_9
		{
			get
			{
				if (this.field_3)
				{
					throw new ObjectDisposedException("GZipStream");
				}
				return this.field_2.field_10.CanWrite;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0002EA30 File Offset: 0x0002CC30
		public virtual void smethod_1270()
		{
			if (this.field_3)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			this.field_2.Flush();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_10
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0002EA54 File Offset: 0x0002CC54
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_11
		{
			get
			{
				if (this.field_2.field_1 == Class_211.NClass_0.field_1)
				{
					return this.field_2.field_0.TotalBytesOut + (long)this.field_1;
				}
				if (this.field_2.field_1 == Class_211.NClass_0.field_2)
				{
					return this.field_2.field_0.TotalBytesIn + (long)this.field_2.field_16;
				}
				return 0L;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0002EABC File Offset: 0x0002CCBC
		public virtual int cmethod_1274(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_3)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			int result = this.field_2.Read(byteDizi_0, sayıInt_0, sayıInt_1);
			if (!this.field_4)
			{
				this.field_4 = true;
				this.prop_1 = this.field_2.field_13;
				this.prop_0 = this.field_2.field_14;
			}
			return result;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long vmethod_1275(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void dmethod_1276(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0002EB24 File Offset: 0x0002CD24
		public virtual void kmethod_1277(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_3)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			if (this.field_2.field_1 == Class_211.NClass_0.field_3)
			{
				if (!this.field_2.prop_1)
				{
					throw new InvalidOperationException();
				}
				this.field_1 = this.lmethod_1278();
			}
			this.field_2.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0002EB90 File Offset: 0x0002CD90
		private int lmethod_1278()
		{
			byte[] array = (this.prop_0 == null) ? null : Class_192.field_9.GetBytes(this.prop_0);
			byte[] array2 = (this.prop_1 == null) ? null : Class_192.field_9.GetBytes(this.prop_1);
			int num = (this.prop_0 == null) ? 0 : (array.Length + 1);
			int num2 = (this.prop_1 == null) ? 0 : (array2.Length + 1);
			int num3 = 10 + num + num2;
			byte[] array3 = new byte[num3];
			int num4 = 0;
			array3[num4++] = 31;
			array3[num4++] = 139;
			array3[num4++] = 8;
			byte b = 0;
			if (this.prop_0 != null)
			{
				b = b;
			}
			if (this.prop_1 != null)
			{
				b = b;
			}
			array3[num4++] = b;
			if (this.field_0 == null)
			{
				this.field_0 = new DateTime?(DateTime.Now);
			}
			int value = (int)(this.field_0.Value - Class_192.field_8).TotalSeconds;
			Array.Copy(BitConverter.GetBytes(value), 0, array3, num4, 4);
			num4 += 4;
			array3[num4++] = 0;
			array3[num4++] = byte.MaxValue;
			if (num2 != 0)
			{
				Array.Copy(array2, 0, array3, num4, num2 - 1);
				num4 += num2 - 1;
				array3[num4++] = 0;
			}
			if (num != 0)
			{
				Array.Copy(array, 0, array3, num4, num - 1);
				num4 += num - 1;
				array3[num4++] = 0;
			}
			this.field_2.field_10.Write(array3, 0, array3.Length);
			return array3.Length;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0002ED5C File Offset: 0x0002CF5C
		public static byte[] pmethod_1279(string str_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_192(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.kmethod_1337(str_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0002EDAC File Offset: 0x0002CFAC
		public static byte[] smethod_1280(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Stream stream_ = new Class_192(memoryStream, Class_204.Compress, Class_202.BestCompression);
				Class_211.lmethod_1338(byteDizi_0, stream_);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		public static string xmethod_1281(byte[] byteDizi_0)
		{
			string result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_192(memoryStream, Class_204.Decompress);
				result = Class_211.pmethod_1339(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0002EE44 File Offset: 0x0002D044
		public static byte[] tmethod_1282(byte[] byteDizi_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(byteDizi_0))
			{
				Stream stream_ = new Class_192(memoryStream, Class_204.Decompress);
				result = Class_211.smethod_1340(byteDizi_0, stream_);
			}
			return result;
		}

		// Token: 0x040004AD RID: 1197
		public DateTime? field_0;

		// Token: 0x040004AE RID: 1198
		private int field_1;

		// Token: 0x040004AF RID: 1199
		internal Class_211 field_2;

		// Token: 0x040004B0 RID: 1200
		private bool field_3;

		// Token: 0x040004B1 RID: 1201
		private bool field_4;

		// Token: 0x040004B2 RID: 1202
		private string field_5;

		// Token: 0x040004B3 RID: 1203
		private string field_6;

		// Token: 0x040004B4 RID: 1204
		private int field_7;

		// Token: 0x040004B5 RID: 1205
		internal static readonly DateTime field_8 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x040004B6 RID: 1206
		internal static readonly Encoding field_9 = Encoding.GetEncoding("iso-8859-1");
	}
}
