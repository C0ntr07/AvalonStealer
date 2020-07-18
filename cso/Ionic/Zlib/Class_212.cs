using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x02000110 RID: 272
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	public sealed class Class_212
	{
		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00034778 File Offset: 0x00032978
		public int Adler32
		{
			get
			{
				return (int)this._Adler32;
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00034780 File Offset: 0x00032980
		public Class_212()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00034798 File Offset: 0x00032998
		public Class_212(Class_204 mode)
		{
			if (mode == Class_204.Compress)
			{
				int num = this.InitializeDeflate();
				if (num != 0)
				{
					throw new Class_205("Cannot initialize for deflate.");
				}
			}
			else
			{
				if (mode != Class_204.Decompress)
				{
					throw new Class_205("Invalid ZlibStreamFlavor.");
				}
				int num2 = this.InitializeInflate();
				if (num2 != 0)
				{
					throw new Class_205("Cannot initialize for inflate.");
				}
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00034802 File Offset: 0x00032A02
		public int InitializeInflate()
		{
			return this.InitializeInflate(this.WindowBits);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00034810 File Offset: 0x00032A10
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return this.InitializeInflate(this.WindowBits, expectRfc1950Header);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0003481F File Offset: 0x00032A1F
		public int InitializeInflate(int windowBits)
		{
			this.WindowBits = windowBits;
			return this.InitializeInflate(windowBits, true);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00034830 File Offset: 0x00032A30
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			this.WindowBits = windowBits;
			if (this.dstate != null)
			{
				throw new Class_205("You may not call InitializeInflate() after calling InitializeDeflate().");
			}
			this.istate = new Class_196(expectRfc1950Header);
			return this.istate.Initialize(this, windowBits);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00034868 File Offset: 0x00032A68
		public int Inflate(Class_201 flush)
		{
			if (this.istate == null)
			{
				throw new Class_205("No Inflate State!");
			}
			return this.istate.Inflate(flush);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003488C File Offset: 0x00032A8C
		public int EndInflate()
		{
			if (this.istate == null)
			{
				throw new Class_205("No Inflate State!");
			}
			int result = this.istate.End();
			this.istate = null;
			return result;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000348C3 File Offset: 0x00032AC3
		public int SyncInflate()
		{
			if (this.istate == null)
			{
				throw new Class_205("No Inflate State!");
			}
			return this.istate.Sync();
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000348E6 File Offset: 0x00032AE6
		public int InitializeDeflate()
		{
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000348EF File Offset: 0x00032AEF
		public int InitializeDeflate(Class_202 level)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000348FF File Offset: 0x00032AFF
		public int InitializeDeflate(Class_202 level, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0003490F File Offset: 0x00032B0F
		public int InitializeDeflate(Class_202 level, int bits)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00034926 File Offset: 0x00032B26
		public int InitializeDeflate(Class_202 level, int bits, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00034940 File Offset: 0x00032B40
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			if (this.istate != null)
			{
				throw new Class_205("You may not call InitializeDeflate() after calling InitializeInflate().");
			}
			this.dstate = new Class_190();
			this.dstate.WantRfc1950HeaderBytes = wantRfc1950Header;
			return this.dstate.Initialize(this, this.CompressLevel, this.WindowBits, this.Strategy);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00034998 File Offset: 0x00032B98
		public int Deflate(Class_201 flush)
		{
			if (this.dstate == null)
			{
				throw new Class_205("No Deflate State!");
			}
			return this.dstate.Deflate(flush);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000349BC File Offset: 0x00032BBC
		public int EndDeflate()
		{
			if (this.dstate == null)
			{
				throw new Class_205("No Deflate State!");
			}
			this.dstate = null;
			return 0;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000349DC File Offset: 0x00032BDC
		public void ResetDeflate()
		{
			if (this.dstate == null)
			{
				throw new Class_205("No Deflate State!");
			}
			this.dstate.Reset();
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000349FF File Offset: 0x00032BFF
		public int SetDeflateParams(Class_202 level, Class_203 strategy)
		{
			if (this.dstate == null)
			{
				throw new Class_205("No Deflate State!");
			}
			return this.dstate.SetParams(level, strategy);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00034A24 File Offset: 0x00032C24
		public int SetDictionary(byte[] dictionary)
		{
			if (this.istate != null)
			{
				return this.istate.SetDictionary(dictionary);
			}
			if (this.dstate != null)
			{
				return this.dstate.SetDictionary(dictionary);
			}
			throw new Class_205("No Inflate or Deflate state!");
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00034A60 File Offset: 0x00032C60
		internal void flush_pending()
		{
			int num = this.dstate.pendingCount;
			if (num > this.AvailableBytesOut)
			{
				num = this.AvailableBytesOut;
			}
			if (num == 0)
			{
				return;
			}
			if (this.dstate.pending.Length <= this.dstate.nextPending || this.OutputBuffer.Length <= this.NextOut || this.dstate.pending.Length < this.dstate.nextPending + num || this.OutputBuffer.Length < this.NextOut + num)
			{
				throw new Class_205(string.Format("Invalid State. (pending.Length={0}, pendingCount={1})", this.dstate.pending.Length, this.dstate.pendingCount));
			}
			Array.Copy(this.dstate.pending, this.dstate.nextPending, this.OutputBuffer, this.NextOut, num);
			this.NextOut += num;
			this.dstate.nextPending += num;
			this.TotalBytesOut += (long)num;
			this.AvailableBytesOut -= num;
			this.dstate.pendingCount -= num;
			if (this.dstate.pendingCount == 0)
			{
				this.dstate.nextPending = 0;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00034BC0 File Offset: 0x00032DC0
		internal int read_buf(byte[] buf, int start, int size)
		{
			int num = this.AvailableBytesIn;
			if (num > size)
			{
				num = size;
			}
			if (num == 0)
			{
				return 0;
			}
			this.AvailableBytesIn -= num;
			if (this.dstate.WantRfc1950HeaderBytes)
			{
				this._Adler32 = Class_209.Adler32(this._Adler32, this.InputBuffer, this.NextIn, num);
			}
			Array.Copy(this.InputBuffer, this.NextIn, buf, start, num);
			this.NextIn += num;
			this.TotalBytesIn += (long)num;
			return num;
		}

		// Token: 0x040005B5 RID: 1461
		public byte[] InputBuffer;

		// Token: 0x040005B6 RID: 1462
		public int NextIn;

		// Token: 0x040005B7 RID: 1463
		public int AvailableBytesIn;

		// Token: 0x040005B8 RID: 1464
		public long TotalBytesIn;

		// Token: 0x040005B9 RID: 1465
		public byte[] OutputBuffer;

		// Token: 0x040005BA RID: 1466
		public int NextOut;

		// Token: 0x040005BB RID: 1467
		public int AvailableBytesOut;

		// Token: 0x040005BC RID: 1468
		public long TotalBytesOut;

		// Token: 0x040005BD RID: 1469
		public string Message;

		// Token: 0x040005BE RID: 1470
		internal Class_190 dstate;

		// Token: 0x040005BF RID: 1471
		internal Class_196 istate;

		// Token: 0x040005C0 RID: 1472
		internal uint _Adler32;

		// Token: 0x040005C1 RID: 1473
		public Class_202 CompressLevel = Class_202.Default;

		// Token: 0x040005C2 RID: 1474
		public int WindowBits = 15;

		// Token: 0x040005C3 RID: 1475
		public Class_203 Strategy;
	}
}
