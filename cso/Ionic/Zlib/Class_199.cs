using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000101 RID: 257
	[ComVisible(true)]
	public class Class_199 : Stream
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x000325D6 File Offset: 0x000307D6
		public Class_199(Stream stream_) : this(stream_, Class_202.Default, Class_203.Default, false)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000325E2 File Offset: 0x000307E2
		public Class_199(Stream stream_, Class_202 arg_0) : this(stream_, arg_0, Class_203.Default, false)
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000325EE File Offset: 0x000307EE
		public Class_199(Stream stream_, bool bool_0) : this(stream_, Class_202.Default, Class_203.Default, bool_0)
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000325FA File Offset: 0x000307FA
		public Class_199(Stream stream_, Class_202 arg_0, bool bool_0) : this(stream_, Class_202.Default, Class_203.Default, bool_0)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00032608 File Offset: 0x00030808
		public Class_199(Stream stream_, Class_202 arg_0, Class_203 arg_1, bool bool_0)
		{
			this.field_5 = stream_;
			this.field_22 = arg_0;
			this.prop_0 = arg_1;
			this.field_3 = bool_0;
			this.prop_1 = 16;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00032677 File Offset: 0x00030877
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x0003267F File Offset: 0x0003087F
		public Class_203 prop_0 { get; private set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00032688 File Offset: 0x00030888
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00032690 File Offset: 0x00030890
		public int prop_1
		{
			get
			{
				return this.field_6;
			}
			set
			{
				if (value < 4)
				{
					throw new ArgumentException("MaxBufferPairs", "Value must be 4 or greater.");
				}
				this.field_6 = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x000326B0 File Offset: 0x000308B0
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x000326B8 File Offset: 0x000308B8
		public int prop_2
		{
			get
			{
				return this.field_7;
			}
			set
			{
				if (value < 1024)
				{
					throw new ArgumentOutOfRangeException("BufferSize", "BufferSize must be greater than 1024 bytes");
				}
				this.field_7 = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x000326DC File Offset: 0x000308DC
		public int prop_3
		{
			get
			{
				return this.field_16;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x000326E4 File Offset: 0x000308E4
		public long prop_4
		{
			get
			{
				return this.field_21;
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000326EC File Offset: 0x000308EC
		private void xmethod_1291()
		{
			this.field_19 = new Queue<int>();
			this.field_20 = new Queue<int>();
			this.field_2 = new List<Class_198>();
			int num = Class_199.field_1 * Environment.ProcessorCount;
			num = Math.Min(num, this.field_6);
			for (int i = 0; i < num; i++)
			{
				this.field_2.Add(new Class_198(this.field_7, this.field_22, this.prop_0, i));
				this.field_20.Enqueue(i);
			}
			this.field_8 = new AutoResetEvent(false);
			this.field_17 = new Class_215();
			this.field_12 = -1;
			this.field_13 = -1;
			this.field_14 = -1;
			this.field_15 = -1;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000327A4 File Offset: 0x000309A4
		public virtual void tmethod_1292(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			bool bool_ = false;
			if (this.field_10)
			{
				throw new InvalidOperationException();
			}
			if (this.field_23 != null)
			{
				this.field_24 = true;
				Exception ex = this.field_23;
				this.field_23 = null;
				throw ex;
			}
			if (sayıInt_1 == 0)
			{
				return;
			}
			if (!this.field_11)
			{
				this.xmethod_1291();
				this.field_11 = true;
			}
			for (;;)
			{
				this.smethod_1300(false, bool_);
				bool_ = false;
				int index;
				if (this.field_12 >= 0)
				{
					index = this.field_12;
					goto IL_AF;
				}
				if (this.field_20.Count != 0)
				{
					index = this.field_20.Dequeue();
					this.field_13++;
					goto IL_AF;
				}
				bool_ = true;
				IL_170:
				if (sayıInt_1 <= 0)
				{
					return;
				}
				continue;
				IL_AF:
				Class_198 class_ = this.field_2[index];
				int num = (class_.field_0.Length - class_.field_5 > sayıInt_1) ? sayıInt_1 : (class_.field_0.Length - class_.field_5);
				class_.field_4 = this.field_13;
				Buffer.BlockCopy(byteDizi_0, sayıInt_0, class_.field_0, class_.field_5, num);
				sayıInt_1 -= num;
				sayıInt_0 += num;
				class_.field_5 += num;
				if (class_.field_5 == class_.field_0.Length)
				{
					if (!ThreadPool.QueueUserWorkItem(new WaitCallback(this.xmethod_1301), class_))
					{
						break;
					}
					this.field_12 = -1;
				}
				else
				{
					this.field_12 = index;
				}
				goto IL_170;
			}
			throw new Exception("Cannot enqueue workitem");
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00032928 File Offset: 0x00030B28
		private void gmethod_1293()
		{
			byte[] array = new byte[128];
			Class_212 class_ = new Class_212();
			int num = class_.InitializeDeflate(this.field_22, false);
			class_.InputBuffer = null;
			class_.NextIn = 0;
			class_.AvailableBytesIn = 0;
			class_.OutputBuffer = array;
			class_.NextOut = 0;
			class_.AvailableBytesOut = array.Length;
			num = class_.Deflate(Class_201.Finish);
			if (num != 1 && num != 0)
			{
				throw new Exception("deflating: " + class_.Message);
			}
			if (array.Length - class_.AvailableBytesOut > 0)
			{
				this.field_5.Write(array, 0, array.Length - class_.AvailableBytesOut);
			}
			class_.EndDeflate();
			this.field_16 = this.field_17.prop_1;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000329EC File Offset: 0x00030BEC
		private void cmethod_1294(bool bool_0)
		{
			if (this.field_10)
			{
				throw new InvalidOperationException();
			}
			if (this.field_4)
			{
				return;
			}
			if (this.field_12 >= 0)
			{
				Class_198 obje_ = this.field_2[this.field_12];
				this.xmethod_1301(obje_);
				this.field_12 = -1;
			}
			if (bool_0)
			{
				this.smethod_1300(true, false);
				this.gmethod_1293();
				return;
			}
			this.smethod_1300(false, false);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00032A60 File Offset: 0x00030C60
		public virtual void vmethod_1295()
		{
			if (this.field_23 != null)
			{
				this.field_24 = true;
				Exception ex = this.field_23;
				this.field_23 = null;
				throw ex;
			}
			if (this.field_24)
			{
				return;
			}
			this.cmethod_1294(false);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00032AA8 File Offset: 0x00030CA8
		public virtual void dmethod_1296()
		{
			if (this.field_23 != null)
			{
				this.field_24 = true;
				Exception ex = this.field_23;
				this.field_23 = null;
				throw ex;
			}
			if (this.field_24)
			{
				return;
			}
			if (this.field_10)
			{
				return;
			}
			this.cmethod_1294(true);
			if (!this.field_3)
			{
				this.field_5.Close();
			}
			this.field_10 = true;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00032B19 File Offset: 0x00030D19
		public void kmethod_1297()
		{
			this.Close();
			this.field_2 = null;
			this.Dispose(true);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00032B2F File Offset: 0x00030D2F
		protected virtual void lmethod_1298(bool bool_0)
		{
			base.Dispose(bool_0);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00032B38 File Offset: 0x00030D38
		public void pmethod_1299(Stream stream_)
		{
			if (!this.field_11)
			{
				return;
			}
			this.field_19.Clear();
			this.field_20.Clear();
			foreach (Class_198 class_ in this.field_2)
			{
				this.field_20.Enqueue(class_.field_3);
				class_.field_4 = -1;
			}
			this.field_11 = false;
			this.field_21 = 0L;
			this.field_17 = new Class_215();
			this.field_10 = false;
			this.field_12 = -1;
			this.field_13 = -1;
			this.field_14 = -1;
			this.field_15 = -1;
			this.field_5 = stream_;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00032C08 File Offset: 0x00030E08
		private void smethod_1300(bool bool_0, bool bool_1)
		{
			if (this.field_4)
			{
				return;
			}
			this.field_4 = true;
			if (bool_0 || bool_1)
			{
				this.field_8.WaitOne();
			}
			do
			{
				int num = -1;
				int num2 = bool_0 ? 200 : (bool_1 ? -1 : 0);
				int num3 = -1;
				do
				{
					if (Monitor.TryEnter(this.field_19, num2))
					{
						num3 = -1;
						try
						{
							if (this.field_19.Count > 0)
							{
								num3 = this.field_19.Dequeue();
							}
						}
						finally
						{
							Monitor.Exit(this.field_19);
						}
						if (num3 >= 0)
						{
							Class_198 class_ = this.field_2[num3];
							if (class_.field_4 != this.field_14 + 1)
							{
								lock (this.field_19)
								{
									this.field_19.Enqueue(num3);
								}
								if (num == num3)
								{
									this.field_8.WaitOne();
									num = -1;
								}
								else if (num == -1)
								{
									num = num3;
								}
							}
							else
							{
								num = -1;
								this.field_5.Write(class_.field_1, 0, class_.field_6);
								this.field_17.kmethod_1377(class_.field_2, class_.field_5);
								this.field_21 += (long)class_.field_5;
								class_.field_5 = 0;
								this.field_14 = class_.field_4;
								this.field_20.Enqueue(class_.field_3);
								if (num2 == -1)
								{
									num2 = 0;
								}
							}
						}
					}
					else
					{
						num3 = -1;
					}
				}
				while (num3 >= 0);
			}
			while (bool_0 && this.field_14 != this.field_15);
			this.field_4 = false;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00032DD4 File Offset: 0x00030FD4
		private void xmethod_1301(object obje_0)
		{
			Class_198 class_ = (Class_198)obje_0;
			try
			{
				int num = class_.field_3;
				Class_215 class_2 = new Class_215();
				class_2.pmethod_1369(class_.field_0, 0, class_.field_5);
				this.tmethod_1302(class_);
				class_.field_2 = class_2.prop_1;
				lock (this.field_18)
				{
					if (class_.field_4 > this.field_15)
					{
						this.field_15 = class_.field_4;
					}
				}
				lock (this.field_19)
				{
					this.field_19.Enqueue(class_.field_3);
				}
				this.field_8.Set();
			}
			catch (Exception ex)
			{
				lock (this.field_25)
				{
					if (this.field_23 != null)
					{
						this.field_23 = ex;
					}
				}
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00032EFC File Offset: 0x000310FC
		private bool tmethod_1302(Class_198 arg_0)
		{
			Class_212 class_ = arg_0.field_7;
			class_.ResetDeflate();
			class_.NextIn = 0;
			class_.AvailableBytesIn = arg_0.field_5;
			class_.NextOut = 0;
			class_.AvailableBytesOut = arg_0.field_1.Length;
			do
			{
				class_.Deflate(Class_201.None);
			}
			while (class_.AvailableBytesIn > 0 || class_.AvailableBytesOut == 0);
			class_.Deflate(Class_201.Sync);
			arg_0.field_6 = (int)class_.TotalBytesOut;
			return true;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00032F70 File Offset: 0x00031170
		[Conditional("Trace")]
		private void gmethod_1303(Class_199.NClass_0 arg_0, string str_0, params object[] arg_1)
		{
			if ((arg_0 & this.field_26) != Class_199.NClass_0.field_9)
			{
				lock (this.field_9)
				{
					int hashCode = Thread.CurrentThread.GetHashCode();
					Console.ForegroundColor = hashCode % 8 + ConsoleColor.DarkGray;
					Console.Write("{0:000} PDOS ", hashCode);
					Console.WriteLine(str_0, arg_1);
					Console.ResetColor();
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_5
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_6
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00032FE4 File Offset: 0x000311E4
		public virtual bool prop_7
		{
			get
			{
				return this.field_5.CanWrite;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_8
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00032FF1 File Offset: 0x000311F1
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_9
		{
			get
			{
				return this.field_5.Position;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual int smethod_1310(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long xmethod_1311(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void tmethod_1312(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400052D RID: 1325
		private static readonly int field_0 = 65536;

		// Token: 0x0400052E RID: 1326
		private static readonly int field_1 = 4;

		// Token: 0x0400052F RID: 1327
		private List<Class_198> field_2;

		// Token: 0x04000530 RID: 1328
		private bool field_3;

		// Token: 0x04000531 RID: 1329
		private bool field_4;

		// Token: 0x04000532 RID: 1330
		private Stream field_5;

		// Token: 0x04000533 RID: 1331
		private int field_6;

		// Token: 0x04000534 RID: 1332
		private int field_7 = Class_199.field_0;

		// Token: 0x04000535 RID: 1333
		private AutoResetEvent field_8;

		// Token: 0x04000536 RID: 1334
		private object field_9 = new object();

		// Token: 0x04000537 RID: 1335
		private bool field_10;

		// Token: 0x04000538 RID: 1336
		private bool field_11;

		// Token: 0x04000539 RID: 1337
		private int field_12;

		// Token: 0x0400053A RID: 1338
		private int field_13;

		// Token: 0x0400053B RID: 1339
		private int field_14;

		// Token: 0x0400053C RID: 1340
		private int field_15;

		// Token: 0x0400053D RID: 1341
		private int field_16;

		// Token: 0x0400053E RID: 1342
		private Class_215 field_17;

		// Token: 0x0400053F RID: 1343
		private object field_18 = new object();

		// Token: 0x04000540 RID: 1344
		private Queue<int> field_19;

		// Token: 0x04000541 RID: 1345
		private Queue<int> field_20;

		// Token: 0x04000542 RID: 1346
		private long field_21;

		// Token: 0x04000543 RID: 1347
		private Class_202 field_22;

		// Token: 0x04000544 RID: 1348
		private volatile Exception field_23;

		// Token: 0x04000545 RID: 1349
		private bool field_24;

		// Token: 0x04000546 RID: 1350
		private object field_25 = new object();

		// Token: 0x04000547 RID: 1351
		private Class_199.NClass_0 field_26 = Class_199.NClass_0.field_11 | Class_199.NClass_0.field_12 | Class_199.NClass_0.field_13 | Class_199.NClass_0.field_14 | Class_199.NClass_0.field_15 | Class_199.NClass_0.field_19 | Class_199.NClass_0.field_22 | Class_199.NClass_0.field_24 | Class_199.NClass_0.field_25;

		// Token: 0x04000548 RID: 1352
		[CompilerGenerated]
		private Class_203 field_27;

		// Token: 0x02000102 RID: 258
		[Flags]
		private enum NClass_0 : uint
		{
			// Token: 0x0400054A RID: 1354
			field_9 = 0U,
			// Token: 0x0400054B RID: 1355
			field_10 = 1U,
			// Token: 0x0400054C RID: 1356
			field_11 = 2U,
			// Token: 0x0400054D RID: 1357
			field_12 = 4U,
			// Token: 0x0400054E RID: 1358
			field_13 = 8U,
			// Token: 0x0400054F RID: 1359
			field_14 = 16U,
			// Token: 0x04000550 RID: 1360
			field_15 = 32U,
			// Token: 0x04000551 RID: 1361
			field_16 = 58U,
			// Token: 0x04000552 RID: 1362
			field_17 = 64U,
			// Token: 0x04000553 RID: 1363
			field_18 = 128U,
			// Token: 0x04000554 RID: 1364
			field_19 = 256U,
			// Token: 0x04000555 RID: 1365
			field_20 = 512U,
			// Token: 0x04000556 RID: 1366
			field_21 = 1024U,
			// Token: 0x04000557 RID: 1367
			field_22 = 2048U,
			// Token: 0x04000558 RID: 1368
			field_23 = 4096U,
			// Token: 0x04000559 RID: 1369
			field_24 = 8192U,
			// Token: 0x0400055A RID: 1370
			field_25 = 16384U,
			// Token: 0x0400055B RID: 1371
			field_26 = 4294967295U
		}
	}
}
