using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x020000E1 RID: 225
	[ComVisible(true)]
	public class Class_177 : Stream
	{
		// Token: 0x060005D2 RID: 1490 RVA: 0x00025E27 File Offset: 0x00024027
		public Class_177(Stream stream_) : this(stream_, false)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00025E34 File Offset: 0x00024034
		public Class_177(string str_0)
		{
			this.field_10 = Encoding.GetEncoding("IBM437");
			this.field_25 = 16;
			base..ctor();
			Stream stream_ = File.Open(str_0, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
			this.vmethod_1015(stream_, false, str_0);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00025E72 File Offset: 0x00024072
		public Class_177(Stream stream_, bool bool_0)
		{
			this.field_10 = Encoding.GetEncoding("IBM437");
			this.field_25 = 16;
			base..ctor();
			this.vmethod_1015(stream_, bool_0, null);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00025E9C File Offset: 0x0002409C
		private void vmethod_1015(Stream stream_, bool bool_0, string str_0)
		{
			this.field_4 = (stream_.CanRead ? stream_ : new Class_156(stream_));
			this.prop_5 = Class_202.Default;
			this.prop_6 = Class_165.Deflate;
			this.field_0 = Class_123.None;
			this.field_7 = new Dictionary<string, Class_163>(StringComparer.Ordinal);
			this.field_6 = Class_169.Default;
			this.field_11 = bool_0;
			this.prop_3 = Class_203.Default;
			this.field_21 = (str_0 ?? "(stream)");
			this.prop_16 = -1L;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00025F1B File Offset: 0x0002411B
		public virtual string dmethod_1016()
		{
			return string.Format("ZipOutputStream::{0}(leaveOpen({1})))", this.field_21, this.field_11);
		}

		// Token: 0x17000100 RID: 256
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00025F38 File Offset: 0x00024138
		public string prop_0
		{
			set
			{
				if (this.field_12)
				{
					this.field_13 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				this.field_2 = value;
				if (this.field_2 == null)
				{
					this.field_0 = Class_123.None;
					return;
				}
				if (this.field_0 == Class_123.None)
				{
					this.field_0 = Class_123.PkzipWeak;
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00025F8E File Offset: 0x0002418E
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00025F96 File Offset: 0x00024196
		public Class_123 prop_1
		{
			get
			{
				return this.field_0;
			}
			set
			{
				if (this.field_12)
				{
					this.field_13 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				if (value == Class_123.Unsupported)
				{
					this.field_13 = true;
					throw new InvalidOperationException("You may not set Encryption to that value.");
				}
				this.field_0 = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00025FD5 File Offset: 0x000241D5
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00025FDD File Offset: 0x000241DD
		public int prop_2 { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00025FE6 File Offset: 0x000241E6
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00025FEE File Offset: 0x000241EE
		public Class_203 prop_3 { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00025FF7 File Offset: 0x000241F7
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00025FFF File Offset: 0x000241FF
		public Class_164 prop_4
		{
			get
			{
				return this.field_1;
			}
			set
			{
				if (this.field_12)
				{
					this.field_13 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				this.field_1 = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00026025 File Offset: 0x00024225
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0002602D File Offset: 0x0002422D
		public Class_202 prop_5 { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00026036 File Offset: 0x00024236
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0002603E File Offset: 0x0002423E
		public Class_165 prop_6 { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00026047 File Offset: 0x00024247
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0002604F File Offset: 0x0002424F
		public string prop_7
		{
			get
			{
				return this.field_3;
			}
			set
			{
				if (this.field_12)
				{
					this.field_13 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				this.field_3 = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00026075 File Offset: 0x00024275
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0002607D File Offset: 0x0002427D
		public Class_169 prop_8
		{
			get
			{
				return this.field_6;
			}
			set
			{
				if (this.field_12)
				{
					this.field_13 = true;
					throw new InvalidOperationException("The stream has been closed.");
				}
				this.field_6 = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000260A3 File Offset: 0x000242A3
		public bool prop_9
		{
			get
			{
				return this.field_14 || this.field_15;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000260B8 File Offset: 0x000242B8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000260C3 File Offset: 0x000242C3
		public bool prop_10
		{
			get
			{
				return !this.field_22;
			}
			set
			{
				this.field_22 = !value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000260CF File Offset: 0x000242CF
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000260EC File Offset: 0x000242EC
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool prop_11
		{
			get
			{
				return this.field_10 == Encoding.UTF8 && this.prop_14 == Class_170.AsNecessary;
			}
			set
			{
				if (value)
				{
					this.field_10 = Encoding.UTF8;
					this.field_9 = Class_170.AsNecessary;
					return;
				}
				this.field_10 = Class_177.prop_15;
				this.field_9 = Class_170.Default;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00026119 File Offset: 0x00024319
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0002612F File Offset: 0x0002432F
		[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		public Encoding prop_12
		{
			get
			{
				if (this.field_9 == Class_170.AsNecessary)
				{
					return this.field_10;
				}
				return null;
			}
			set
			{
				this.field_10 = value;
				this.field_9 = Class_170.AsNecessary;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0002613F File Offset: 0x0002433F
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00026147 File Offset: 0x00024347
		public Encoding prop_13
		{
			get
			{
				return this.field_10;
			}
			set
			{
				this.field_10 = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00026150 File Offset: 0x00024350
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00026158 File Offset: 0x00024358
		public Class_170 prop_14
		{
			get
			{
				return this.field_9;
			}
			set
			{
				this.field_9 = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00026161 File Offset: 0x00024361
		public static Encoding prop_15
		{
			get
			{
				return Encoding.GetEncoding("IBM437");
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0002619D File Offset: 0x0002439D
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0002616D File Offset: 0x0002436D
		public long prop_16
		{
			get
			{
				return this.field_24;
			}
			set
			{
				if (value != 0L && value != -1L && value < 65536L)
				{
					throw new ArgumentOutOfRangeException("value must be greater than 64k, or 0, or -1");
				}
				this.field_24 = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x000261A5 File Offset: 0x000243A5
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000261AD File Offset: 0x000243AD
		public int prop_17
		{
			get
			{
				return this.field_25;
			}
			set
			{
				if (value < 4)
				{
					throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
				}
				this.field_25 = value;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000261CD File Offset: 0x000243CD
		private void smethod_1050(Class_163 arg_0)
		{
			if (this.field_7.ContainsKey(arg_0.prop_12))
			{
				this.field_13 = true;
				throw new ArgumentException(string.Format("The entry '{0}' already exists in the zip archive.", arg_0.prop_12));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00026202 File Offset: 0x00024402
		internal Stream prop_18
		{
			get
			{
				return this.field_4;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0002620A File Offset: 0x0002440A
		internal string prop_19
		{
			get
			{
				return this.field_21;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00026212 File Offset: 0x00024412
		public bool gmethod_1053(string str_0)
		{
			return this.field_7.ContainsKey(Class_155.NormalizePathForUseInZipFile(str_0));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00026228 File Offset: 0x00024428
		public virtual void cmethod_1054(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_12)
			{
				this.field_13 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			if (byteDizi_0 == null)
			{
				this.field_13 = true;
				throw new ArgumentNullException("buffer");
			}
			if (this.field_5 == null)
			{
				this.field_13 = true;
				throw new InvalidOperationException("You must call PutNextEntry() before calling Write().");
			}
			if (this.field_5.prop_27)
			{
				this.field_13 = true;
				throw new InvalidOperationException("You cannot Write() data for an entry that is a directory.");
			}
			if (this.field_20)
			{
				this.dmethod_1056(false);
			}
			if (sayıInt_1 != 0)
			{
				this.field_19.Write(byteDizi_0, sayıInt_0, sayıInt_1);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000262D0 File Offset: 0x000244D0
		public Class_163 vmethod_1055(string str_0)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("entryName");
			}
			if (this.field_12)
			{
				this.field_13 = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			this.kmethod_1057();
			this.field_5 = Class_163.lmethod_658(str_0);
			this.field_5.field_43 = new Class_178(this);
			Class_163 class_ = this.field_5;
			class_.field_22 |= 8;
			this.field_5.xmethod_601(DateTime.Now, DateTime.Now, DateTime.Now);
			this.field_5.prop_22 = this.prop_5;
			this.field_5.prop_21 = this.prop_6;
			this.field_5.prop_30 = this.field_2;
			this.field_5.prop_29 = this.prop_1;
			this.field_5.prop_38 = this.prop_13;
			this.field_5.prop_39 = this.prop_14;
			if (str_0.EndsWith("/"))
			{
				this.field_5.smethod_660();
			}
			this.field_5.prop_7 = ((this.field_1 & Class_164.Windows) != Class_164.None);
			this.field_5.prop_8 = ((this.field_1 & Class_164.Unix) != Class_164.None);
			this.smethod_1050(this.field_5);
			this.field_20 = true;
			return this.field_5;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00026430 File Offset: 0x00024630
		private void dmethod_1056(bool bool_0)
		{
			this.field_7.Add(this.field_5.prop_12, this.field_5);
			this.field_8++;
			if (this.field_8 > 65534 && this.field_6 == Class_169.Default)
			{
				this.field_13 = true;
				throw new InvalidOperationException("Too many entries. Consider setting ZipOutputStream.EnableZip64.");
			}
			this.field_5.cmethod_724(this.field_4, bool_0 ? 99 : 0);
			this.field_5.pmethod_739();
			if (!this.field_5.prop_27)
			{
				this.field_5.xmethod_741(this.field_4);
				this.field_5.cmethod_734(this.field_4, bool_0 ? 0L : -1L, out this.field_16, out this.field_17, out this.field_18, out this.field_19);
			}
			this.field_20 = false;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00026520 File Offset: 0x00024720
		private void kmethod_1057()
		{
			if (this.field_5 != null)
			{
				if (this.field_20)
				{
					this.dmethod_1056(true);
				}
				this.field_5.xmethod_731(this.field_4, this.field_16, this.field_17, this.field_18, this.field_19);
				this.field_5.tmethod_732(this.field_4);
				if (this.field_5.prop_19 != null)
				{
					this.field_14 |= this.field_5.prop_19.Value;
				}
				this.field_16 = null;
				this.field_17 = (this.field_18 = null);
				this.field_19 = null;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000265DC File Offset: 0x000247DC
		protected virtual void lmethod_1058(bool bool_0)
		{
			if (this.field_12)
			{
				return;
			}
			if (bool_0 && !this.field_13)
			{
				this.kmethod_1057();
				this.field_15 = Class_173.WriteCentralDirectoryStructure(this.field_4, this.field_7.Values, 1U, this.field_6, this.prop_7, new Class_178(this));
				Class_156 class_ = this.field_4 as Class_156;
				Stream stream;
				if (class_ != null)
				{
					stream = class_.prop_0;
					class_.Dispose();
				}
				else
				{
					stream = this.field_4;
				}
				if (!this.field_11)
				{
					stream.Dispose();
				}
				this.field_4 = null;
			}
			this.field_12 = true;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_20
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_21
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public virtual bool prop_22
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_23
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00026687 File Offset: 0x00024887
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long prop_24
		{
			get
			{
				return this.field_4.Position;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		public virtual void vmethod_1065()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00026694 File Offset: 0x00024894
		public virtual int dmethod_1066(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotSupportedException("Read");
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000266A0 File Offset: 0x000248A0
		public virtual long kmethod_1067(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException("Seek");
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void lmethod_1068(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000376 RID: 886
		private Class_123 field_0;

		// Token: 0x04000377 RID: 887
		private Class_164 field_1;

		// Token: 0x04000378 RID: 888
		internal string field_2;

		// Token: 0x04000379 RID: 889
		private string field_3;

		// Token: 0x0400037A RID: 890
		private Stream field_4;

		// Token: 0x0400037B RID: 891
		private Class_163 field_5;

		// Token: 0x0400037C RID: 892
		internal Class_169 field_6;

		// Token: 0x0400037D RID: 893
		private Dictionary<string, Class_163> field_7;

		// Token: 0x0400037E RID: 894
		private int field_8;

		// Token: 0x0400037F RID: 895
		private Class_170 field_9;

		// Token: 0x04000380 RID: 896
		private Encoding field_10;

		// Token: 0x04000381 RID: 897
		private bool field_11;

		// Token: 0x04000382 RID: 898
		private bool field_12;

		// Token: 0x04000383 RID: 899
		private bool field_13;

		// Token: 0x04000384 RID: 900
		private bool field_14;

		// Token: 0x04000385 RID: 901
		private bool field_15;

		// Token: 0x04000386 RID: 902
		private Class_156 field_16;

		// Token: 0x04000387 RID: 903
		private Stream field_17;

		// Token: 0x04000388 RID: 904
		private Stream field_18;

		// Token: 0x04000389 RID: 905
		private Class_216 field_19;

		// Token: 0x0400038A RID: 906
		private bool field_20;

		// Token: 0x0400038B RID: 907
		private string field_21;

		// Token: 0x0400038C RID: 908
		private bool field_22;

		// Token: 0x0400038D RID: 909
		internal Class_199 field_23;

		// Token: 0x0400038E RID: 910
		private long field_24;

		// Token: 0x0400038F RID: 911
		private int field_25;

		// Token: 0x04000390 RID: 912
		[CompilerGenerated]
		private int field_26;

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private Class_203 field_27;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private Class_202 field_28;

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private Class_165 field_29;
	}
}
