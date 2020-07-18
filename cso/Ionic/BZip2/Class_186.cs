using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x020000EF RID: 239
	[ComVisible(true)]
	public class Class_186 : Stream
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x0002B1A2 File Offset: 0x000293A2
		public Class_186(Stream stream_) : this(stream_, Class_183.MaxBlockSize, false)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002B1B1 File Offset: 0x000293B1
		public Class_186(Stream stream_, int sayıInt_0) : this(stream_, sayıInt_0, false)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002B1BC File Offset: 0x000293BC
		public Class_186(Stream stream_, bool bool_0) : this(stream_, Class_183.MaxBlockSize, bool_0)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0002B1CC File Offset: 0x000293CC
		public Class_186(Stream stream_, int sayıInt_0, bool bool_0)
		{
			if (sayıInt_0 < Class_183.MinBlockSize || sayıInt_0 > Class_183.MaxBlockSize)
			{
				string message = string.Format("blockSize={0} is out of range; must be between {1} and {2}", sayıInt_0, Class_183.MinBlockSize, Class_183.MaxBlockSize);
				throw new ArgumentException(message, "blockSize");
			}
			this.field_21 = stream_;
			if (!this.field_21.CanWrite)
			{
				throw new ArgumentException("The stream is not writable.", "output");
			}
			this.field_22 = new Class_180(this.field_21);
			this.field_23 = sayıInt_0;
			this.field_19 = bool_0;
			this.field_20 = 0U;
			this.prop_0 = 16;
			this.cmethod_1214();
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0002B2AC File Offset: 0x000294AC
		private void lmethod_1208()
		{
			this.field_10 = new Queue<int>();
			this.field_11 = new Queue<int>();
			this.field_12 = new List<Class_185>();
			int num = Class_186.field_0 * Environment.ProcessorCount;
			num = Math.Min(num, this.prop_0);
			for (int i = 0; i < num; i++)
			{
				this.field_12.Add(new Class_185(i, this.field_23));
				this.field_11.Enqueue(i);
			}
			this.field_16 = new AutoResetEvent(false);
			this.field_6 = -1;
			this.field_3 = -1;
			this.field_4 = -1;
			this.field_5 = -1;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002B34D File Offset: 0x0002954D
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0002B355 File Offset: 0x00029555
		public int prop_0
		{
			get
			{
				return this.field_1;
			}
			set
			{
				if (value < 4)
				{
					throw new ArgumentException("MaxWorkers", "Value must be 4 or greater.");
				}
				this.field_1 = value;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002B378 File Offset: 0x00029578
		public virtual void xmethod_1211()
		{
			if (this.field_7 != null)
			{
				this.field_8 = true;
				Exception ex = this.field_7;
				this.field_7 = null;
				throw ex;
			}
			if (this.field_8)
			{
				return;
			}
			if (this.field_21 == null)
			{
				return;
			}
			Stream stream = this.field_21;
			try
			{
				this.tmethod_1212(true);
			}
			finally
			{
				this.field_21 = null;
				this.field_22 = null;
			}
			if (!this.field_19)
			{
				stream.Close();
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002B408 File Offset: 0x00029608
		private void tmethod_1212(bool bool_0)
		{
			if (this.field_9)
			{
				return;
			}
			if (this.field_6 >= 0)
			{
				Class_185 obje_ = this.field_12[this.field_6];
				this.pmethod_1219(obje_);
				this.field_6 = -1;
			}
			if (bool_0)
			{
				this.lmethod_1218(true, false);
				this.vmethod_1215();
				return;
			}
			this.lmethod_1218(false, false);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002B46A File Offset: 0x0002966A
		public virtual void gmethod_1213()
		{
			if (this.field_21 != null)
			{
				this.tmethod_1212(false);
				this.field_22.smethod_1120();
				this.field_21.Flush();
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002B494 File Offset: 0x00029694
		private void cmethod_1214()
		{
			byte[] array = new byte[]
			{
				66,
				90,
				104,
				0
			};
			array[3] = (byte)(48 + this.field_23);
			byte[] array2 = array;
			this.field_21.Write(array2, 0, array2.Length);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0002B4D4 File Offset: 0x000296D4
		private void vmethod_1215()
		{
			this.field_22.lmethod_1118(23);
			this.field_22.lmethod_1118(114);
			this.field_22.lmethod_1118(69);
			this.field_22.lmethod_1118(56);
			this.field_22.lmethod_1118(80);
			this.field_22.lmethod_1118(144);
			this.field_22.pmethod_1119(this.field_20);
			this.field_22.xmethod_1121();
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0002B54E File Offset: 0x0002974E
		public int prop_1
		{
			get
			{
				return this.field_23;
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002B558 File Offset: 0x00029758
		public virtual void kmethod_1217(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			bool bool_ = false;
			if (this.field_21 == null)
			{
				throw new IOException("the stream is not open");
			}
			if (this.field_7 != null)
			{
				this.field_8 = true;
				Exception ex = this.field_7;
				this.field_7 = null;
				throw ex;
			}
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
			if (sayıInt_1 == 0)
			{
				return;
			}
			if (!this.field_2)
			{
				this.lmethod_1208();
				this.field_2 = true;
			}
			int num = 0;
			int num2 = sayıInt_1;
			for (;;)
			{
				this.lmethod_1218(false, bool_);
				bool_ = false;
				int index;
				if (this.field_6 >= 0)
				{
					index = this.field_6;
					goto IL_124;
				}
				if (this.field_11.Count != 0)
				{
					index = this.field_11.Dequeue();
					this.field_3++;
					goto IL_124;
				}
				bool_ = true;
				IL_1A0:
				if (num2 <= 0)
				{
					goto Block_12;
				}
				continue;
				IL_124:
				Class_185 class_ = this.field_12[index];
				class_.field_2 = this.field_3;
				int num3 = class_.prop_0.pmethod_1129(byteDizi_0, sayıInt_0, num2);
				if (num3 != num2)
				{
					if (!ThreadPool.QueueUserWorkItem(new WaitCallback(this.pmethod_1219), class_))
					{
						break;
					}
					this.field_6 = -1;
					sayıInt_0 += num3;
				}
				else
				{
					this.field_6 = index;
				}
				num2 -= num3;
				num += num3;
				goto IL_1A0;
			}
			throw new Exception("Cannot enqueue workitem");
			Block_12:
			this.field_17 += (long)num;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002B71C File Offset: 0x0002991C
		private void lmethod_1218(bool bool_0, bool bool_1)
		{
			if (this.field_9)
			{
				return;
			}
			this.field_9 = true;
			if (bool_0 || bool_1)
			{
				this.field_16.WaitOne();
			}
			do
			{
				int num = -1;
				int num2 = bool_0 ? 200 : (bool_1 ? -1 : 0);
				int num3 = -1;
				do
				{
					if (Monitor.TryEnter(this.field_10, num2))
					{
						num3 = -1;
						try
						{
							if (this.field_10.Count > 0)
							{
								num3 = this.field_10.Dequeue();
							}
						}
						finally
						{
							Monitor.Exit(this.field_10);
						}
						if (num3 >= 0)
						{
							Class_185 class_ = this.field_12[num3];
							if (class_.field_2 != this.field_4 + 1)
							{
								lock (this.field_10)
								{
									this.field_10.Enqueue(num3);
								}
								if (num == num3)
								{
									this.field_16.WaitOne();
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
								Class_180 class_2 = class_.field_3;
								class_2.smethod_1120();
								MemoryStream memoryStream = class_.field_1;
								memoryStream.Seek(0L, SeekOrigin.Begin);
								long num4 = 0L;
								byte[] array = new byte[1024];
								int num5;
								while ((num5 = memoryStream.Read(array, 0, array.Length)) > 0)
								{
									for (int i = 0; i < num5; i++)
									{
										this.field_22.lmethod_1118(array[i]);
									}
									num4 += (long)num5;
								}
								if (class_2.prop_1 > 0)
								{
									this.field_22.kmethod_1117(class_2.prop_1, (uint)class_2.prop_0);
								}
								this.field_20 = (this.field_20 << 1 | this.field_20 >> 31);
								this.field_20 ^= class_.prop_0.prop_1;
								this.field_18 += num4;
								class_2.dmethod_1116();
								this.field_4 = class_.field_2;
								class_.field_2 = -1;
								this.field_11.Enqueue(class_.field_0);
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
			while (bool_0 && this.field_4 != this.field_5);
			this.field_9 = false;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0002B98C File Offset: 0x00029B8C
		private void pmethod_1219(object obje_0)
		{
			Class_185 class_ = (Class_185)obje_0;
			try
			{
				class_.prop_0.tmethod_1132();
				lock (this.field_13)
				{
					if (class_.field_2 > this.field_5)
					{
						this.field_5 = class_.field_2;
					}
				}
				lock (this.field_10)
				{
					this.field_10.Enqueue(class_.field_0);
				}
				this.field_16.Set();
			}
			catch (Exception ex)
			{
				lock (this.field_14)
				{
					if (this.field_7 != null)
					{
						this.field_7 = ex;
					}
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_3
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0002BA88 File Offset: 0x00029C88
		public virtual bool prop_4
		{
			get
			{
				if (this.field_21 == null)
				{
					throw new ObjectDisposedException("BZip2Stream");
				}
				return this.field_21.CanWrite;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_5
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0002BAAB File Offset: 0x00029CAB
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long prop_6
		{
			get
			{
				return this.field_17;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0002BAB3 File Offset: 0x00029CB3
		public long prop_7
		{
			get
			{
				return this.field_18;
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00018443 File Offset: 0x00016643
		public virtual long kmethod_1227(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00018443 File Offset: 0x00016643
		public virtual void lmethod_1228(long sayıUınt_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00018443 File Offset: 0x00016643
		public virtual int pmethod_1229(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0002BABC File Offset: 0x00029CBC
		[Conditional("Trace")]
		private void smethod_1230(Class_186.NClass_0 arg_0, string str_0, params object[] arg_1)
		{
			if ((arg_0 & this.field_24) != Class_186.NClass_0.field_6)
			{
				lock (this.field_15)
				{
					int hashCode = Thread.CurrentThread.GetHashCode();
					Console.ForegroundColor = hashCode % 8 + ConsoleColor.Green;
					Console.Write("{0:000} PBOS ", hashCode);
					Console.WriteLine(str_0, arg_1);
					Console.ResetColor();
				}
			}
		}

		// Token: 0x04000432 RID: 1074
		private static readonly int field_0 = 4;

		// Token: 0x04000433 RID: 1075
		private int field_1;

		// Token: 0x04000434 RID: 1076
		private bool field_2;

		// Token: 0x04000435 RID: 1077
		private int field_3;

		// Token: 0x04000436 RID: 1078
		private int field_4;

		// Token: 0x04000437 RID: 1079
		private int field_5;

		// Token: 0x04000438 RID: 1080
		private int field_6;

		// Token: 0x04000439 RID: 1081
		private volatile Exception field_7;

		// Token: 0x0400043A RID: 1082
		private bool field_8;

		// Token: 0x0400043B RID: 1083
		private bool field_9;

		// Token: 0x0400043C RID: 1084
		private Queue<int> field_10;

		// Token: 0x0400043D RID: 1085
		private Queue<int> field_11;

		// Token: 0x0400043E RID: 1086
		private List<Class_185> field_12;

		// Token: 0x0400043F RID: 1087
		private object field_13 = new object();

		// Token: 0x04000440 RID: 1088
		private object field_14 = new object();

		// Token: 0x04000441 RID: 1089
		private object field_15 = new object();

		// Token: 0x04000442 RID: 1090
		private AutoResetEvent field_16;

		// Token: 0x04000443 RID: 1091
		private long field_17;

		// Token: 0x04000444 RID: 1092
		private long field_18;

		// Token: 0x04000445 RID: 1093
		private bool field_19;

		// Token: 0x04000446 RID: 1094
		private uint field_20;

		// Token: 0x04000447 RID: 1095
		private Stream field_21;

		// Token: 0x04000448 RID: 1096
		private Class_180 field_22;

		// Token: 0x04000449 RID: 1097
		private int field_23;

		// Token: 0x0400044A RID: 1098
		private Class_186.NClass_0 field_24 = Class_186.NClass_0.field_7 | Class_186.NClass_0.field_8;

		// Token: 0x020000F0 RID: 240
		[Flags]
		private enum NClass_0 : uint
		{
			// Token: 0x0400044C RID: 1100
			field_6 = 0U,
			// Token: 0x0400044D RID: 1101
			field_7 = 1U,
			// Token: 0x0400044E RID: 1102
			field_8 = 2U,
			// Token: 0x0400044F RID: 1103
			field_9 = 4294967295U
		}
	}
}
