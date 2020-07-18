using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200018A RID: 394
	public class Class_286 : Class_285
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0003F924 File Offset: 0x0003DB24
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0003F92C File Offset: 0x0003DB2C
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public new bool prop_0
		{
			get
			{
				return this.field_13;
			}
			set
			{
				this.field_13 = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0003F935 File Offset: 0x0003DB35
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0003F93D File Offset: 0x0003DB3D
		public new bool prop_1
		{
			get
			{
				return this.field_12;
			}
			set
			{
				this.field_12 = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0003F946 File Offset: 0x0003DB46
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0003F94E File Offset: 0x0003DB4E
		public new DateTimeKind prop_2
		{
			get
			{
				return this.field_14;
			}
			set
			{
				this.field_14 = value;
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0003F957 File Offset: 0x0003DB57
		public Class_286(Stream stream_) : this(stream_, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0003F962 File Offset: 0x0003DB62
		public Class_286(BinaryReader arg_0) : this(arg_0, false, DateTimeKind.Local)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0003F96D File Offset: 0x0003DB6D
		public Class_286(Stream stream_, bool bool_0, DateTimeKind arg_0)
		{
			Class_517.ArgumentNotNull(stream_, "stream");
			this.field_5 = new BinaryReader(stream_);
			this.field_6 = new List<Class_286.NClass_1>();
			this.field_12 = bool_0;
			this.field_14 = arg_0;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0003F9A5 File Offset: 0x0003DBA5
		public Class_286(BinaryReader arg_0, bool bool_0, DateTimeKind arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			this.field_5 = arg_0;
			this.field_6 = new List<Class_286.NClass_1>();
			this.field_12 = bool_0;
			this.field_14 = arg_1;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0003F9D8 File Offset: 0x0003DBD8
		private string pmethod_1919()
		{
			this.field_9 = this.dmethod_1946();
			return this.kmethod_1937();
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0003F9F9 File Offset: 0x0003DBF9
		public virtual byte[] smethod_1920()
		{
			return base.cmethod_1894();
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0003FA01 File Offset: 0x0003DC01
		public virtual decimal? xmethod_1921()
		{
			return base.vmethod_1895();
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0003FA09 File Offset: 0x0003DC09
		public virtual int? tmethod_1922()
		{
			return base.dmethod_1896();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0003FA11 File Offset: 0x0003DC11
		public virtual string gmethod_1923()
		{
			return base.kmethod_1897();
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0003FA19 File Offset: 0x0003DC19
		public virtual DateTime? cmethod_1924()
		{
			return base.lmethod_1898();
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003FA21 File Offset: 0x0003DC21
		public virtual DateTimeOffset? vmethod_1925()
		{
			return base.gmethod_1893();
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0003FA29 File Offset: 0x0003DC29
		public virtual bool dmethod_1926()
		{
			this.field_4 = Class_408.Read;
			return this.tmethod_1892();
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0003FA38 File Offset: 0x0003DC38
		internal virtual bool kmethod_1927()
		{
			bool result;
			try
			{
				bool flag;
				switch (this.field_10)
				{
				case Class_286.NClass_0.field_17:
					flag = this.xmethod_1931();
					break;
				case Class_286.NClass_0.field_18:
				case Class_286.NClass_0.field_19:
				case Class_286.NClass_0.field_20:
					flag = this.smethod_1930();
					break;
				case Class_286.NClass_0.field_21:
				case Class_286.NClass_0.field_22:
				case Class_286.NClass_0.field_23:
				case Class_286.NClass_0.field_24:
				case Class_286.NClass_0.field_25:
					flag = this.pmethod_1929();
					break;
				default:
					throw Class_414.lmethod_3098(this, "Unexpected state: {0}".FormatWith(CultureInfo.InvariantCulture, this.field_10));
				}
				if (!flag)
				{
					base.xmethod_1901(Class_508.None);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (EndOfStreamException)
			{
				base.xmethod_1901(Class_508.None);
				result = false;
			}
			return result;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0003FAFC File Offset: 0x0003DCFC
		public virtual void lmethod_1928()
		{
			base.tmethod_1912();
			if (base.prop_1 && this.field_5 != null)
			{
				this.field_5.Close();
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0003FB28 File Offset: 0x0003DD28
		private bool pmethod_1929()
		{
			switch (this.field_10)
			{
			case Class_286.NClass_0.field_21:
				base.tmethod_1902(Class_508.PropertyName, "$code");
				this.field_10 = Class_286.NClass_0.field_22;
				return true;
			case Class_286.NClass_0.field_22:
				this.cmethod_1944();
				base.tmethod_1902(Class_508.String, this.lmethod_1938());
				this.field_10 = Class_286.NClass_0.field_23;
				return true;
			case Class_286.NClass_0.field_23:
			{
				if (base.prop_0 == Class_285.NClass_0.field_13)
				{
					base.tmethod_1902(Class_508.PropertyName, "$scope");
					return true;
				}
				base.xmethod_1901(Class_508.StartObject);
				this.field_10 = Class_286.NClass_0.field_24;
				Class_286.NClass_1 nclass_ = new Class_286.NClass_1(Class_295.Object);
				this.gmethod_1933(nclass_);
				nclass_.field_27 = this.cmethod_1944();
				return true;
			}
			case Class_286.NClass_0.field_24:
			{
				bool flag = this.xmethod_1931();
				if (flag && this.prop_9 == Class_508.EndObject)
				{
					this.field_10 = Class_286.NClass_0.field_25;
				}
				return flag;
			}
			case Class_286.NClass_0.field_25:
				base.xmethod_1901(Class_508.EndObject);
				this.field_10 = Class_286.NClass_0.field_17;
				return true;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0003FC10 File Offset: 0x0003DE10
		private bool smethod_1930()
		{
			Class_285.NClass_0 nclass_ = base.prop_0;
			switch (nclass_)
			{
			case Class_285.NClass_0.field_7:
				if (this.field_10 == Class_286.NClass_0.field_19)
				{
					base.tmethod_1902(Class_508.String, this.lmethod_1938());
					return true;
				}
				if (this.field_10 == Class_286.NClass_0.field_20)
				{
					base.tmethod_1902(Class_508.Bytes, this.lmethod_1948(12));
					return true;
				}
				throw Class_414.lmethod_3098(this, "Unexpected state when reading BSON reference: " + this.field_10);
			case Class_285.NClass_0.field_8:
				base.tmethod_1902(Class_508.PropertyName, "$ref");
				this.field_10 = Class_286.NClass_0.field_19;
				return true;
			default:
				if (nclass_ != Class_285.NClass_0.field_13)
				{
					throw Class_414.lmethod_3098(this, "Unexpected state when reading BSON reference: " + base.prop_0);
				}
				if (this.field_10 == Class_286.NClass_0.field_19)
				{
					base.tmethod_1902(Class_508.PropertyName, "$id");
					this.field_10 = Class_286.NClass_0.field_20;
					return true;
				}
				if (this.field_10 == Class_286.NClass_0.field_20)
				{
					base.xmethod_1901(Class_508.EndObject);
					this.field_10 = Class_286.NClass_0.field_17;
					return true;
				}
				throw Class_414.lmethod_3098(this, "Unexpected state when reading BSON reference: " + this.field_10);
			}
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0003FD20 File Offset: 0x0003DF20
		private bool xmethod_1931()
		{
			switch (base.prop_0)
			{
			case Class_285.NClass_0.field_5:
			{
				Class_508 arg_ = (!this.field_12) ? Class_508.StartObject : Class_508.StartArray;
				Class_295 arg_2 = (!this.field_12) ? Class_295.Object : Class_295.Array;
				base.xmethod_1901(arg_);
				Class_286.NClass_1 nclass_ = new Class_286.NClass_1(arg_2);
				this.gmethod_1933(nclass_);
				nclass_.field_27 = this.cmethod_1944();
				return true;
			}
			case Class_285.NClass_0.field_6:
			case Class_285.NClass_0.field_12:
				return false;
			case Class_285.NClass_0.field_7:
				this.vmethod_1935(this.field_9);
				return true;
			case Class_285.NClass_0.field_8:
			case Class_285.NClass_0.field_10:
			case Class_285.NClass_0.field_13:
			{
				Class_286.NClass_1 nclass_2 = this.field_11;
				if (nclass_2 == null)
				{
					return false;
				}
				int num = nclass_2.field_27 - 1;
				if (nclass_2.field_28 < num)
				{
					if (nclass_2.field_26 == Class_295.Array)
					{
						this.pmethod_1919();
						this.vmethod_1935(this.field_9);
						return true;
					}
					base.tmethod_1902(Class_508.PropertyName, this.pmethod_1919());
					return true;
				}
				else
				{
					if (nclass_2.field_28 != num)
					{
						throw Class_414.lmethod_3098(this, "Read past end of current container context.");
					}
					if (this.cmethod_1934() != 0)
					{
						throw Class_414.lmethod_3098(this, "Unexpected end of object byte value.");
					}
					this.tmethod_1932();
					if (this.field_11 != null)
					{
						this.kmethod_1947(nclass_2.field_27);
					}
					Class_508 arg_3 = (nclass_2.field_26 == Class_295.Object) ? Class_508.EndObject : Class_508.EndArray;
					base.xmethod_1901(arg_3);
					return true;
				}
				break;
			}
			case Class_285.NClass_0.field_14:
			case Class_285.NClass_0.field_15:
			case Class_285.NClass_0.field_16:
			case Class_285.NClass_0.field_17:
				return false;
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		private void tmethod_1932()
		{
			this.field_6.RemoveAt(this.field_6.Count - 1);
			if (this.field_6.Count == 0)
			{
				this.field_11 = null;
				return;
			}
			this.field_11 = this.field_6[this.field_6.Count - 1];
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0003FEFB File Offset: 0x0003E0FB
		private void gmethod_1933(Class_286.NClass_1 arg_0)
		{
			this.field_6.Add(arg_0);
			this.field_11 = arg_0;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0003FF10 File Offset: 0x0003E110
		private byte cmethod_1934()
		{
			this.kmethod_1947(1);
			return this.field_5.ReadByte();
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0003FF24 File Offset: 0x0003E124
		private void vmethod_1935(Class_295 arg_0)
		{
			switch (arg_0)
			{
			case Class_295.Number:
			{
				double num = this.gmethod_1943();
				if (this.field_11 == Class_315.Decimal)
				{
					base.tmethod_1902(Class_508.Float, Convert.ToDecimal(num, CultureInfo.InvariantCulture));
					return;
				}
				base.tmethod_1902(Class_508.Float, num);
				return;
			}
			case Class_295.String:
			case Class_295.Symbol:
				base.tmethod_1902(Class_508.String, this.lmethod_1938());
				return;
			case Class_295.Object:
			{
				base.xmethod_1901(Class_508.StartObject);
				Class_286.NClass_1 nclass_ = new Class_286.NClass_1(Class_295.Object);
				this.gmethod_1933(nclass_);
				nclass_.field_27 = this.cmethod_1944();
				return;
			}
			case Class_295.Array:
			{
				base.xmethod_1901(Class_508.StartArray);
				Class_286.NClass_1 nclass_2 = new Class_286.NClass_1(Class_295.Array);
				this.gmethod_1933(nclass_2);
				nclass_2.field_27 = this.cmethod_1944();
				return;
			}
			case Class_295.Binary:
			{
				Class_283 class_;
				byte[] array = this.dmethod_1936(out class_);
				object obje_ = (class_ != Class_283.Uuid) ? array : new Guid(array);
				base.tmethod_1902(Class_508.Bytes, obje_);
				return;
			}
			case Class_295.Undefined:
				base.xmethod_1901(Class_508.Undefined);
				return;
			case Class_295.Oid:
			{
				byte[] obje_2 = this.lmethod_1948(12);
				base.tmethod_1902(Class_508.Bytes, obje_2);
				return;
			}
			case Class_295.Boolean:
			{
				bool flag = Convert.ToBoolean(this.cmethod_1934());
				base.tmethod_1902(Class_508.Boolean, flag);
				return;
			}
			case Class_295.Date:
			{
				long javaScriptTicks = this.vmethod_1945();
				DateTime dateTime = Class_502.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
				DateTime dateTime2;
				switch (this.prop_2)
				{
				case DateTimeKind.Unspecified:
					dateTime2 = DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified);
					goto IL_1A7;
				case DateTimeKind.Local:
					dateTime2 = dateTime.ToLocalTime();
					goto IL_1A7;
				}
				dateTime2 = dateTime;
				IL_1A7:
				base.tmethod_1902(Class_508.Date, dateTime2);
				return;
			}
			case Class_295.Null:
				base.xmethod_1901(Class_508.Null);
				return;
			case Class_295.Regex:
			{
				string str = this.kmethod_1937();
				string str2 = this.kmethod_1937();
				string obje_3 = "/" + str + "/" + str2;
				base.tmethod_1902(Class_508.String, obje_3);
				return;
			}
			case Class_295.Reference:
				base.xmethod_1901(Class_508.StartObject);
				this.field_10 = Class_286.NClass_0.field_18;
				return;
			case Class_295.Code:
				base.tmethod_1902(Class_508.String, this.lmethod_1938());
				return;
			case Class_295.CodeWScope:
				base.xmethod_1901(Class_508.StartObject);
				this.field_10 = Class_286.NClass_0.field_21;
				return;
			case Class_295.Integer:
				base.tmethod_1902(Class_508.Integer, (long)this.cmethod_1944());
				return;
			case Class_295.TimeStamp:
			case Class_295.Long:
				base.tmethod_1902(Class_508.Integer, this.vmethod_1945());
				return;
			default:
				throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + arg_0);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00040190 File Offset: 0x0003E390
		private byte[] dmethod_1936(out Class_283 arg_0)
		{
			int sayıInt_ = this.cmethod_1944();
			arg_0 = (Class_283)this.cmethod_1934();
			if (arg_0 == Class_283.BinaryOld && !this.field_13)
			{
				sayıInt_ = this.cmethod_1944();
			}
			return this.lmethod_1948(sayıInt_);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000401D0 File Offset: 0x0003E3D0
		private string kmethod_1937()
		{
			this.tmethod_1942();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num4;
			for (;;)
			{
				int num3 = num2;
				byte b;
				while (num3 < 128 && (b = this.field_5.ReadByte()) > 0)
				{
					this.field_7[num3++] = b;
				}
				num4 = num3 - num2;
				num += num4;
				if (num3 < 128 && stringBuilder == null)
				{
					break;
				}
				int num5 = this.smethod_1940(num3 - 1);
				int chars = Encoding.UTF8.GetChars(this.field_7, 0, num5 + 1, this.field_8, 0);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(256);
				}
				stringBuilder.Append(this.field_8, 0, chars);
				if (num5 < num4 - 1)
				{
					num2 = num4 - num5 - 1;
					Array.Copy(this.field_7, num5 + 1, this.field_7, 0, num2);
				}
				else
				{
					if (num3 < 128)
					{
						goto Block_6;
					}
					num2 = 0;
				}
			}
			int chars2 = Encoding.UTF8.GetChars(this.field_7, 0, num4, this.field_8, 0);
			this.kmethod_1947(num + 1);
			return new string(this.field_8, 0, chars2);
			Block_6:
			this.kmethod_1947(num + 1);
			return stringBuilder.ToString();
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00040304 File Offset: 0x0003E504
		private string lmethod_1938()
		{
			int num = this.cmethod_1944();
			this.kmethod_1947(num);
			string result = this.pmethod_1939(num - 1);
			this.field_5.ReadByte();
			return result;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00040338 File Offset: 0x0003E538
		private string pmethod_1939(int sayıInt_0)
		{
			if (sayıInt_0 == 0)
			{
				return string.Empty;
			}
			this.tmethod_1942();
			StringBuilder stringBuilder = null;
			int num = 0;
			int num2 = 0;
			int num3;
			for (;;)
			{
				int count = (sayıInt_0 - num > 128 - num2) ? (128 - num2) : (sayıInt_0 - num);
				num3 = this.field_5.Read(this.field_7, num2, count);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num3 += num2;
				if (num3 == sayıInt_0)
				{
					goto Block_4;
				}
				int num4 = this.smethod_1940(num3 - 1);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(sayıInt_0);
				}
				int chars = Encoding.UTF8.GetChars(this.field_7, 0, num4 + 1, this.field_8, 0);
				stringBuilder.Append(this.field_8, 0, chars);
				if (num4 < num3 - 1)
				{
					num2 = num3 - num4 - 1;
					Array.Copy(this.field_7, num4 + 1, this.field_7, 0, num2);
				}
				else
				{
					num2 = 0;
				}
				if (num >= sayıInt_0)
				{
					goto Block_7;
				}
			}
			throw new EndOfStreamException("Unable to read beyond the end of the stream.");
			Block_4:
			int chars2 = Encoding.UTF8.GetChars(this.field_7, 0, num3, this.field_8, 0);
			return new string(this.field_8, 0, chars2);
			Block_7:
			return stringBuilder.ToString();
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00040468 File Offset: 0x0003E668
		private int smethod_1940(int sayıInt_0)
		{
			int i = sayıInt_0;
			int num = 0;
			while (i >= 0)
			{
				num = this.xmethod_1941(this.field_7[i]);
				if (num == 0)
				{
					i--;
				}
				else
				{
					if (num != 1)
					{
						i--;
						break;
					}
					break;
				}
			}
			if (num == sayıInt_0 - i)
			{
				return sayıInt_0;
			}
			return i;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000404BC File Offset: 0x0003E6BC
		private int xmethod_1941(byte byte_0)
		{
			if (byte_0 <= Class_286.field_1[1])
			{
				return 1;
			}
			if (byte_0 >= Class_286.field_2[0] && byte_0 <= Class_286.field_2[1])
			{
				return 2;
			}
			if (byte_0 >= Class_286.field_3[0] && byte_0 <= Class_286.field_3[1])
			{
				return 3;
			}
			if (byte_0 >= Class_286.field_4[0] && byte_0 <= Class_286.field_4[1])
			{
				return 4;
			}
			return 0;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00040530 File Offset: 0x0003E730
		private void tmethod_1942()
		{
			if (this.field_7 == null)
			{
				this.field_7 = new byte[128];
			}
			if (this.field_8 == null)
			{
				int maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
				this.field_8 = new char[maxCharCount];
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0004057F File Offset: 0x0003E77F
		private double gmethod_1943()
		{
			this.kmethod_1947(8);
			return this.field_5.ReadDouble();
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00040593 File Offset: 0x0003E793
		private int cmethod_1944()
		{
			this.kmethod_1947(4);
			return this.field_5.ReadInt32();
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000405A7 File Offset: 0x0003E7A7
		private long vmethod_1945()
		{
			this.kmethod_1947(8);
			return this.field_5.ReadInt64();
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x000405BB File Offset: 0x0003E7BB
		private Class_295 dmethod_1946()
		{
			this.kmethod_1947(1);
			return (Class_295)this.field_5.ReadSByte();
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x000405CF File Offset: 0x0003E7CF
		private void kmethod_1947(int sayıInt_0)
		{
			this.field_11.field_28 += sayıInt_0;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x000405E4 File Offset: 0x0003E7E4
		private byte[] lmethod_1948(int sayıInt_0)
		{
			this.kmethod_1947(sayıInt_0);
			return this.field_5.ReadBytes(sayıInt_0);
		}

		// Token: 0x04000744 RID: 1860
		private const int field_0 = 128;

		// Token: 0x04000745 RID: 1861
		private static readonly byte[] field_1 = new byte[]
		{
			0,
			127
		};

		// Token: 0x04000746 RID: 1862
		private new static readonly byte[] field_2 = new byte[]
		{
			194,
			223
		};

		// Token: 0x04000747 RID: 1863
		private new static readonly byte[] field_3 = new byte[]
		{
			224,
			239
		};

		// Token: 0x04000748 RID: 1864
		private new static readonly byte[] field_4 = new byte[]
		{
			240,
			244
		};

		// Token: 0x04000749 RID: 1865
		private readonly BinaryReader field_5;

		// Token: 0x0400074A RID: 1866
		private readonly List<Class_286.NClass_1> field_6;

		// Token: 0x0400074B RID: 1867
		private byte[] field_7;

		// Token: 0x0400074C RID: 1868
		private char[] field_8;

		// Token: 0x0400074D RID: 1869
		private Class_295 field_9;

		// Token: 0x0400074E RID: 1870
		private new Class_286.NClass_0 field_10;

		// Token: 0x0400074F RID: 1871
		private new Class_286.NClass_1 field_11;

		// Token: 0x04000750 RID: 1872
		private bool field_12;

		// Token: 0x04000751 RID: 1873
		private bool field_13;

		// Token: 0x04000752 RID: 1874
		private DateTimeKind field_14;

		// Token: 0x0200018B RID: 395
		private new enum NClass_0
		{
			// Token: 0x04000754 RID: 1876
			field_17,
			// Token: 0x04000755 RID: 1877
			field_18,
			// Token: 0x04000756 RID: 1878
			field_19,
			// Token: 0x04000757 RID: 1879
			field_20,
			// Token: 0x04000758 RID: 1880
			field_21,
			// Token: 0x04000759 RID: 1881
			field_22,
			// Token: 0x0400075A RID: 1882
			field_23,
			// Token: 0x0400075B RID: 1883
			field_24,
			// Token: 0x0400075C RID: 1884
			field_25
		}

		// Token: 0x0200018C RID: 396
		private class NClass_1
		{
			// Token: 0x06000B1C RID: 2844 RVA: 0x00040672 File Offset: 0x0003E872
			public void nmethod_0(Class_295 arg_0)
			{
				base..ctor();
				this.field_26 = arg_0;
			}

			// Token: 0x0400075D RID: 1885
			public readonly Class_295 field_26;

			// Token: 0x0400075E RID: 1886
			public int field_27;

			// Token: 0x0400075F RID: 1887
			public int field_28;
		}
	}
}
