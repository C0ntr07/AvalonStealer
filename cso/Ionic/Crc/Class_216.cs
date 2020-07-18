using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Ionic.Crc
{
	// Token: 0x02000114 RID: 276
	[ComVisible(true)]
	public class Class_216 : Stream, IDisposable
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x00035521 File Offset: 0x00033721
		public Class_216(Stream stream_) : this(true, Class_216.field_0, stream_, null)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00035531 File Offset: 0x00033731
		public Class_216(Stream stream_, bool bool_0) : this(bool_0, Class_216.field_0, stream_, null)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00035541 File Offset: 0x00033741
		public Class_216(Stream stream_, long sayıUınt_0) : this(true, sayıUınt_0, stream_, null)
		{
			if (sayıUınt_0 < 0L)
			{
				throw new ArgumentException("length");
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00035560 File Offset: 0x00033760
		public Class_216(Stream stream_, long sayıUınt_0, bool bool_0) : this(bool_0, sayıUınt_0, stream_, null)
		{
			if (sayıUınt_0 < 0L)
			{
				throw new ArgumentException("length");
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0003557F File Offset: 0x0003377F
		public Class_216(Stream stream_, long sayıUınt_0, bool bool_0, Class_215 arg_0) : this(bool_0, sayıUınt_0, stream_, arg_0)
		{
			if (sayıUınt_0 < 0L)
			{
				throw new ArgumentException("length");
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0003559F File Offset: 0x0003379F
		private Class_216(bool bool_0, long sayıUınt_0, Stream stream_, Class_215 arg_0)
		{
			this.field_1 = stream_;
			this.field_2 = (arg_0 ?? new Class_215());
			this.field_3 = sayıUınt_0;
			this.field_4 = bool_0;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000355D9 File Offset: 0x000337D9
		public long prop_0
		{
			get
			{
				return this.field_2.prop_0;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000355E6 File Offset: 0x000337E6
		public int prop_1
		{
			get
			{
				return this.field_2.prop_1;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000355F3 File Offset: 0x000337F3
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000355FB File Offset: 0x000337FB
		public bool prop_2
		{
			get
			{
				return this.field_4;
			}
			set
			{
				this.field_4 = value;
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00035604 File Offset: 0x00033804
		public virtual int gmethod_1383(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			int count = sayıInt_1;
			if (this.field_3 != Class_216.field_0)
			{
				if (this.field_2.prop_0 >= this.field_3)
				{
					return 0;
				}
				long num = this.field_3 - this.field_2.prop_0;
				if (num < (long)sayıInt_1)
				{
					count = (int)num;
				}
			}
			int num2 = this.field_1.Read(byteDizi_0, sayıInt_0, count);
			if (num2 > 0)
			{
				this.field_2.pmethod_1369(byteDizi_0, sayıInt_0, num2);
			}
			return num2;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0003567E File Offset: 0x0003387E
		public virtual void cmethod_1384(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_1 > 0)
			{
				this.field_2.pmethod_1369(byteDizi_0, sayıInt_0, sayıInt_1);
			}
			this.field_1.Write(byteDizi_0, sayıInt_0, sayıInt_1);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000356A3 File Offset: 0x000338A3
		public virtual bool prop_3
		{
			get
			{
				return this.field_1.CanRead;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_4
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000356B0 File Offset: 0x000338B0
		public virtual bool prop_5
		{
			get
			{
				return this.field_1.CanWrite;
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000356BD File Offset: 0x000338BD
		public virtual void lmethod_1388()
		{
			this.field_1.Flush();
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000356CA File Offset: 0x000338CA
		public virtual long prop_6
		{
			get
			{
				if (this.field_3 == Class_216.field_0)
				{
					return this.field_1.Length;
				}
				return this.field_3;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000355D9 File Offset: 0x000337D9
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_7
		{
			get
			{
				return this.field_2.prop_0;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long tmethod_1392(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void gmethod_1393(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000184C7 File Offset: 0x000166C7
		void IDisposable.cmethod_1394()
		{
			this.Close();
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000356EE File Offset: 0x000338EE
		public virtual void vmethod_1395()
		{
			base.Close();
			if (!this.field_4)
			{
				this.field_1.Close();
			}
		}

		// Token: 0x040005D6 RID: 1494
		private static readonly long field_0 = -99L;

		// Token: 0x040005D7 RID: 1495
		internal Stream field_1;

		// Token: 0x040005D8 RID: 1496
		private Class_215 field_2;

		// Token: 0x040005D9 RID: 1497
		private long field_3 = -99L;

		// Token: 0x040005DA RID: 1498
		private bool field_4;
	}
}
