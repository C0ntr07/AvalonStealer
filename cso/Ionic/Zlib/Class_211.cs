using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x0200010E RID: 270
	internal class Class_211 : Stream
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00033996 File Offset: 0x00031B96
		internal int prop_0
		{
			get
			{
				if (this.field_12 == null)
				{
					return 0;
				}
				return this.field_12.prop_1;
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000339B0 File Offset: 0x00031BB0
		public Class_211(Stream stream_, Class_204 arg_0, Class_202 arg_1, Class_210 arg_2, bool bool_0)
		{
			this.field_2 = Class_201.None;
			this.field_10 = stream_;
			this.field_6 = bool_0;
			this.field_4 = arg_0;
			this.field_3 = arg_2;
			this.field_5 = arg_1;
			if (arg_2 == Class_210.GZIP)
			{
				this.field_12 = new Class_215();
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00033A24 File Offset: 0x00031C24
		protected internal bool prop_1
		{
			get
			{
				return this.field_4 == Class_204.Compress;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00033A30 File Offset: 0x00031C30
		private Class_212 prop_2
		{
			get
			{
				if (this.field_0 == null)
				{
					bool flag = this.field_3 == Class_210.ZLIB;
					this.field_0 = new Class_212();
					if (this.field_4 == Class_204.Decompress)
					{
						this.field_0.InitializeInflate(flag);
					}
					else
					{
						this.field_0.Strategy = this.field_11;
						this.field_0.InitializeDeflate(this.field_5, flag);
					}
				}
				return this.field_0;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00033AA9 File Offset: 0x00031CA9
		private byte[] prop_3
		{
			get
			{
				if (this.field_7 == null)
				{
					this.field_7 = new byte[this.field_8];
				}
				return this.field_7;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00033AD0 File Offset: 0x00031CD0
		public virtual void xmethod_1321(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_12 != null)
			{
				this.field_12.pmethod_1369(byteDizi_0, sayıInt_0, sayıInt_1);
			}
			if (this.field_1 == Class_211.NClass_0.field_3)
			{
				this.field_1 = Class_211.NClass_0.field_1;
			}
			else if (this.field_1 != Class_211.NClass_0.field_1)
			{
				throw new Class_205("Cannot Write after Reading.");
			}
			if (sayıInt_1 == 0)
			{
				return;
			}
			this.prop_2.InputBuffer = byteDizi_0;
			this.field_0.NextIn = sayıInt_0;
			this.field_0.AvailableBytesIn = sayıInt_1;
			for (;;)
			{
				this.field_0.OutputBuffer = this.prop_3;
				this.field_0.NextOut = 0;
				this.field_0.AvailableBytesOut = this.field_7.Length;
				int num = this.prop_1 ? this.field_0.Deflate(this.field_2) : this.field_0.Inflate(this.field_2);
				if (num != 0 && num != 1)
				{
					break;
				}
				this.field_10.Write(this.field_7, 0, this.field_7.Length - this.field_0.AvailableBytesOut);
				bool flag = this.field_0.AvailableBytesIn == 0 && this.field_0.AvailableBytesOut != 0;
				if (this.field_3 == Class_210.GZIP && !this.prop_1)
				{
					flag = (this.field_0.AvailableBytesIn == 8 && this.field_0.AvailableBytesOut != 0);
				}
				if (flag)
				{
					return;
				}
			}
			throw new Class_205((this.prop_1 ? "de" : "in") + "flating: " + this.field_0.Message);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00033C90 File Offset: 0x00031E90
		private void tmethod_1322()
		{
			if (this.field_0 == null)
			{
				return;
			}
			if (this.field_1 == Class_211.NClass_0.field_1)
			{
				int num;
				for (;;)
				{
					this.field_0.OutputBuffer = this.prop_3;
					this.field_0.NextOut = 0;
					this.field_0.AvailableBytesOut = this.field_7.Length;
					num = (this.prop_1 ? this.field_0.Deflate(Class_201.Finish) : this.field_0.Inflate(Class_201.Finish));
					if (num != 1 && num != 0)
					{
						break;
					}
					if (this.field_7.Length - this.field_0.AvailableBytesOut > 0)
					{
						this.field_10.Write(this.field_7, 0, this.field_7.Length - this.field_0.AvailableBytesOut);
					}
					bool flag = this.field_0.AvailableBytesIn == 0 && this.field_0.AvailableBytesOut != 0;
					if (this.field_3 == Class_210.GZIP && !this.prop_1)
					{
						flag = (this.field_0.AvailableBytesIn == 8 && this.field_0.AvailableBytesOut != 0);
					}
					if (flag)
					{
						goto Block_12;
					}
				}
				string text = (this.prop_1 ? "de" : "in") + "flating";
				if (this.field_0.Message == null)
				{
					throw new Class_205(string.Format("{0}: (rc = {1})", text, num));
				}
				throw new Class_205(text + ": " + this.field_0.Message);
				Block_12:
				this.Flush();
				if (this.field_3 == Class_210.GZIP)
				{
					if (this.prop_1)
					{
						int value = this.field_12.prop_1;
						this.field_10.Write(BitConverter.GetBytes(value), 0, 4);
						int value2 = (int)(this.field_12.prop_0 & (long)((ulong)-1));
						this.field_10.Write(BitConverter.GetBytes(value2), 0, 4);
						return;
					}
					throw new Class_205("Writing with decompression is not supported.");
				}
			}
			else if (this.field_1 == Class_211.NClass_0.field_2 && this.field_3 == Class_210.GZIP)
			{
				if (this.prop_1)
				{
					throw new Class_205("Reading with compression is not supported.");
				}
				if (this.field_0.TotalBytesOut == 0L)
				{
					return;
				}
				byte[] array = new byte[8];
				if (this.field_0.AvailableBytesIn < 8)
				{
					Array.Copy(this.field_0.InputBuffer, this.field_0.NextIn, array, 0, this.field_0.AvailableBytesIn);
					int num2 = 8 - this.field_0.AvailableBytesIn;
					int num3 = this.field_10.Read(array, this.field_0.AvailableBytesIn, num2);
					if (num2 != num3)
					{
						throw new Class_205(string.Format("Missing or incomplete GZIP trailer. Expected 8 bytes, got {0}.", this.field_0.AvailableBytesIn + num3));
					}
				}
				else
				{
					Array.Copy(this.field_0.InputBuffer, this.field_0.NextIn, array, 0, array.Length);
				}
				int num4 = BitConverter.ToInt32(array, 0);
				int num5 = this.field_12.prop_1;
				int num6 = BitConverter.ToInt32(array, 4);
				int num7 = (int)(this.field_0.TotalBytesOut & (long)((ulong)-1));
				if (num5 != num4)
				{
					throw new Class_205(string.Format("Bad CRC32 in GZIP trailer. (actual({0:X8})!=expected({1:X8}))", num5, num4));
				}
				if (num7 != num6)
				{
					throw new Class_205(string.Format("Bad size in GZIP trailer. (actual({0})!=expected({1}))", num7, num6));
				}
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00034027 File Offset: 0x00032227
		private void gmethod_1323()
		{
			if (this.prop_2 == null)
			{
				return;
			}
			if (this.prop_1)
			{
				this.field_0.EndDeflate();
			}
			else
			{
				this.field_0.EndInflate();
			}
			this.field_0 = null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00034064 File Offset: 0x00032264
		public virtual void cmethod_1324()
		{
			if (this.field_10 == null)
			{
				return;
			}
			try
			{
				this.tmethod_1322();
			}
			finally
			{
				this.gmethod_1323();
				if (!this.field_6)
				{
					this.field_10.Close();
				}
				this.field_10 = null;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000340BC File Offset: 0x000322BC
		public virtual void vmethod_1325()
		{
			this.field_10.Flush();
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long dmethod_1326(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000340C9 File Offset: 0x000322C9
		public virtual void kmethod_1327(long sayıUınt_0)
		{
			this.field_10.SetLength(sayıUınt_0);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000340D8 File Offset: 0x000322D8
		private string lmethod_1328()
		{
			List<byte> list = new List<byte>();
			bool flag = false;
			for (;;)
			{
				int num = this.field_10.Read(this.field_9, 0, 1);
				if (num != 1)
				{
					break;
				}
				if (this.field_9[0] == 0)
				{
					flag = true;
				}
				else
				{
					list.Add(this.field_9[0]);
				}
				if (flag)
				{
					goto Block_3;
				}
			}
			throw new Class_205("Unexpected EOF reading GZIP header.");
			Block_3:
			byte[] array = list.ToArray();
			return Class_192.field_9.GetString(array, 0, array.Length);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00034150 File Offset: 0x00032350
		private int pmethod_1329()
		{
			int num = 0;
			byte[] array = new byte[10];
			int num2 = this.field_10.Read(array, 0, array.Length);
			if (num2 == 0)
			{
				return 0;
			}
			if (num2 != 10)
			{
				throw new Class_205("Not a valid GZIP stream.");
			}
			if (array[0] != 31 || array[1] != 139 || array[2] != 8)
			{
				throw new Class_205("Bad GZIP header.");
			}
			int num3 = BitConverter.ToInt32(array, 4);
			this.field_15 = Class_192.field_8.AddSeconds((double)num3);
			num += num2;
			if ((array[3] & 4) == 4)
			{
				num2 = this.field_10.Read(array, 0, 2);
				num += num2;
				short num4 = (short)((int)array[0] + (int)array[1] * 256);
				byte[] array2 = new byte[(int)num4];
				num2 = this.field_10.Read(array2, 0, array2.Length);
				if (num2 != (int)num4)
				{
					throw new Class_205("Unexpected end-of-file reading GZIP header.");
				}
				num += num2;
			}
			if ((array[3] & 8) == 8)
			{
				this.field_13 = this.lmethod_1328();
			}
			if ((array[3] & 16) == 16)
			{
				this.field_14 = this.lmethod_1328();
			}
			if ((array[3] & 2) == 2)
			{
				this.Read(this.field_9, 0, 1);
			}
			return num;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0003428C File Offset: 0x0003248C
		public virtual int smethod_1330(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_1 == Class_211.NClass_0.field_3)
			{
				if (!this.field_10.CanRead)
				{
					throw new Class_205("The stream is not readable.");
				}
				this.field_1 = Class_211.NClass_0.field_2;
				this.prop_2.AvailableBytesIn = 0;
				if (this.field_3 == Class_210.GZIP)
				{
					this.field_16 = this.pmethod_1329();
					if (this.field_16 == 0)
					{
						return 0;
					}
				}
			}
			if (this.field_1 != Class_211.NClass_0.field_2)
			{
				throw new Class_205("Cannot Read after Writing.");
			}
			if (sayıInt_1 == 0)
			{
				return 0;
			}
			if (this.field_17 && this.prop_1)
			{
				return 0;
			}
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (sayıInt_1 < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (sayıInt_0 < byteDizi_0.GetLowerBound(0))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (sayıInt_0 + sayıInt_1 > byteDizi_0.GetLength(0))
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.field_0.OutputBuffer = byteDizi_0;
			this.field_0.NextOut = sayıInt_0;
			this.field_0.AvailableBytesOut = sayıInt_1;
			this.field_0.InputBuffer = this.prop_3;
			int num;
			for (;;)
			{
				if (this.field_0.AvailableBytesIn == 0 && !this.field_17)
				{
					this.field_0.NextIn = 0;
					this.field_0.AvailableBytesIn = this.field_10.Read(this.field_7, 0, this.field_7.Length);
					if (this.field_0.AvailableBytesIn == 0)
					{
						this.field_17 = true;
					}
				}
				num = (this.prop_1 ? this.field_0.Deflate(this.field_2) : this.field_0.Inflate(this.field_2));
				if (this.field_17 && num == -5)
				{
					break;
				}
				if (num != 0 && num != 1)
				{
					goto Block_20;
				}
				if (((this.field_17 || num == 1) && this.field_0.AvailableBytesOut == sayıInt_1) || this.field_0.AvailableBytesOut <= 0 || this.field_17 || num != 0)
				{
					goto IL_25E;
				}
			}
			return 0;
			Block_20:
			throw new Class_205(string.Format("{0}flating:  rc={1}  msg={2}", this.prop_1 ? "de" : "in", num, this.field_0.Message));
			IL_25E:
			if (this.field_0.AvailableBytesOut > 0)
			{
				if (num == 0)
				{
					int availableBytesIn = this.field_0.AvailableBytesIn;
				}
				if (this.field_17 && this.prop_1)
				{
					num = this.field_0.Deflate(Class_201.Finish);
					if (num != 0 && num != 1)
					{
						throw new Class_205(string.Format("Deflating:  rc={0}  msg={1}", num, this.field_0.Message));
					}
				}
			}
			num = sayıInt_1 - this.field_0.AvailableBytesOut;
			if (this.field_12 != null)
			{
				this.field_12.pmethod_1369(byteDizi_0, sayıInt_0, num);
			}
			return num;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00034593 File Offset: 0x00032793
		public virtual bool prop_4
		{
			get
			{
				return this.field_10.CanRead;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x000345A0 File Offset: 0x000327A0
		public virtual bool prop_5
		{
			get
			{
				return this.field_10.CanSeek;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000345AD File Offset: 0x000327AD
		public virtual bool prop_6
		{
			get
			{
				return this.field_10.CanWrite;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000345BA File Offset: 0x000327BA
		public virtual long prop_7
		{
			get
			{
				return this.field_10.Length;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00018443 File Offset: 0x00016643
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_8
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

		// Token: 0x060007A1 RID: 1953 RVA: 0x000345C8 File Offset: 0x000327C8
		public static void kmethod_1337(string str_0, Stream stream_)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(str_0);
			try
			{
				stream_.Write(bytes, 0, bytes.Length);
			}
			finally
			{
				if (stream_ != null)
				{
					((IDisposable)stream_).Dispose();
				}
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00034610 File Offset: 0x00032810
		public static void lmethod_1338(byte[] byteDizi_0, Stream stream_)
		{
			try
			{
				stream_.Write(byteDizi_0, 0, byteDizi_0.Length);
			}
			finally
			{
				if (stream_ != null)
				{
					((IDisposable)stream_).Dispose();
				}
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0003464C File Offset: 0x0003284C
		public static string pmethod_1339(byte[] byteDizi_0, Stream stream_)
		{
			byte[] array = new byte[1024];
			Encoding utf = Encoding.UTF8;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				try
				{
					int count;
					while ((count = stream_.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					if (stream_ != null)
					{
						((IDisposable)stream_).Dispose();
					}
				}
				memoryStream.Seek(0L, SeekOrigin.Begin);
				StreamReader streamReader = new StreamReader(memoryStream, utf);
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000346F0 File Offset: 0x000328F0
		public static byte[] smethod_1340(byte[] byteDizi_0, Stream stream_)
		{
			byte[] array = new byte[1024];
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				try
				{
					int count;
					while ((count = stream_.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					if (stream_ != null)
					{
						((IDisposable)stream_).Dispose();
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0400059F RID: 1439
		protected internal Class_212 field_0;

		// Token: 0x040005A0 RID: 1440
		protected internal Class_211.NClass_0 field_1 = Class_211.NClass_0.field_3;

		// Token: 0x040005A1 RID: 1441
		protected internal Class_201 field_2;

		// Token: 0x040005A2 RID: 1442
		protected internal Class_210 field_3;

		// Token: 0x040005A3 RID: 1443
		protected internal Class_204 field_4;

		// Token: 0x040005A4 RID: 1444
		protected internal Class_202 field_5;

		// Token: 0x040005A5 RID: 1445
		protected internal bool field_6;

		// Token: 0x040005A6 RID: 1446
		protected internal byte[] field_7;

		// Token: 0x040005A7 RID: 1447
		protected internal int field_8 = 16384;

		// Token: 0x040005A8 RID: 1448
		protected internal byte[] field_9 = new byte[1];

		// Token: 0x040005A9 RID: 1449
		protected internal Stream field_10;

		// Token: 0x040005AA RID: 1450
		protected internal Class_203 field_11;

		// Token: 0x040005AB RID: 1451
		private Class_215 field_12;

		// Token: 0x040005AC RID: 1452
		protected internal string field_13;

		// Token: 0x040005AD RID: 1453
		protected internal string field_14;

		// Token: 0x040005AE RID: 1454
		protected internal DateTime field_15;

		// Token: 0x040005AF RID: 1455
		protected internal int field_16;

		// Token: 0x040005B0 RID: 1456
		private bool field_17;

		// Token: 0x0200010F RID: 271
		internal enum NClass_0
		{
			// Token: 0x040005B2 RID: 1458
			field_1,
			// Token: 0x040005B3 RID: 1459
			field_2,
			// Token: 0x040005B4 RID: 1460
			field_3
		}
	}
}
