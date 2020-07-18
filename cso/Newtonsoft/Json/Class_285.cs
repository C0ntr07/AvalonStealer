using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000188 RID: 392
	public abstract class Class_285 : IDisposable
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0003E961 File Offset: 0x0003CB61
		protected Class_285.NClass_0 prop_0
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0003E969 File Offset: 0x0003CB69
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0003E971 File Offset: 0x0003CB71
		public bool prop_1 { get; set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0003E97A File Offset: 0x0003CB7A
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0003E982 File Offset: 0x0003CB82
		public bool prop_2 { get; set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0003E98B File Offset: 0x0003CB8B
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0003E993 File Offset: 0x0003CB93
		public virtual char prop_3
		{
			get
			{
				return this.field_2;
			}
			protected internal set
			{
				this.field_2 = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0003E99C File Offset: 0x0003CB9C
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
		public Class_321 prop_4
		{
			get
			{
				return this.field_7;
			}
			set
			{
				this.field_7 = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0003E9AD File Offset: 0x0003CBAD
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x0003E9B5 File Offset: 0x0003CBB5
		public Class_320 prop_5
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0003E9BE File Offset: 0x0003CBBE
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x0003E9C6 File Offset: 0x0003CBC6
		public Class_315 prop_6
		{
			get
			{
				return this.field_11;
			}
			set
			{
				this.field_11 = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0003E9CF File Offset: 0x0003CBCF
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x0003E9D7 File Offset: 0x0003CBD7
		public string prop_7
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0003E9E0 File Offset: 0x0003CBE0
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0003E9E8 File Offset: 0x0003CBE8
		public int? prop_8
		{
			get
			{
				return this.field_8;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this.field_8 = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0003EA2D File Offset: 0x0003CC2D
		public virtual Class_508 prop_9
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0003EA35 File Offset: 0x0003CC35
		public virtual object prop_10
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0003EA3D File Offset: 0x0003CC3D
		public virtual Type prop_11
		{
			get
			{
				if (this.field_1 == null)
				{
					return null;
				}
				return this.field_1.GetType();
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0003EA58 File Offset: 0x0003CC58
		public virtual int prop_12
		{
			get
			{
				int count = this.field_13.Count;
				if (Class_486.IsStartToken(this.prop_9) || this.field_5.Type == Class_325.None)
				{
					return count;
				}
				return count + 1;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0003EA98 File Offset: 0x0003CC98
		public virtual string prop_13
		{
			get
			{
				if (this.field_5.Type == Class_325.None)
				{
					return string.Empty;
				}
				bool flag = this.field_3 != Class_285.NClass_0.field_10 && this.field_3 != Class_285.NClass_0.field_14 && this.field_3 != Class_285.NClass_0.field_8;
				IEnumerable<Class_326> positions = (!flag) ? this.field_13 : this.field_13.Concat(new Class_326[]
				{
					this.field_5
				});
				return Class_326.BuildPath(positions);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0003EB24 File Offset: 0x0003CD24
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0003EB38 File Offset: 0x0003CD38
		public CultureInfo prop_14
		{
			get
			{
				return this.field_6 ?? CultureInfo.InvariantCulture;
			}
			set
			{
				this.field_6 = value;
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003EB41 File Offset: 0x0003CD41
		internal Class_326 xmethod_1881(int sayıInt_0)
		{
			if (sayıInt_0 < this.field_13.Count)
			{
				return this.field_13[sayıInt_0];
			}
			return this.field_5;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003EB67 File Offset: 0x0003CD67
		protected Class_285()
		{
			this.field_3 = Class_285.NClass_0.field_5;
			this.field_13 = new List<Class_326>(4);
			this.field_7 = Class_321.RoundtripKind;
			this.field_10 = Class_320.DateTime;
			this.field_11 = Class_315.Double;
			this.prop_1 = true;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003EBA0 File Offset: 0x0003CDA0
		private void tmethod_1882(Class_325 arg_0)
		{
			this.vmethod_1905();
			if (this.field_5.Type == Class_325.None)
			{
				this.field_5 = new Class_326(arg_0);
				return;
			}
			this.field_13.Add(this.field_5);
			this.field_5 = new Class_326(arg_0);
			if (this.field_8 != null && this.prop_12 + 1 > this.field_8 && !this.field_9)
			{
				this.field_9 = true;
				throw Class_414.lmethod_3098(this, "The reader's MaxDepth of {0} has been exceeded.".FormatWith(CultureInfo.InvariantCulture, this.field_8));
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0003EC60 File Offset: 0x0003CE60
		private Class_325 gmethod_1883()
		{
			Class_326 class_;
			if (this.field_13.Count > 0)
			{
				class_ = this.field_5;
				this.field_5 = this.field_13[this.field_13.Count - 1];
				this.field_13.RemoveAt(this.field_13.Count - 1);
			}
			else
			{
				class_ = this.field_5;
				this.field_5 = default(Class_326);
			}
			if (this.field_8 != null && this.prop_12 <= this.field_8)
			{
				this.field_9 = false;
			}
			return class_.Type;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0003ED1E File Offset: 0x0003CF1E
		private Class_325 cmethod_1884()
		{
			return this.field_5.Type;
		}

		// Token: 0x06000AD7 RID: 2775
		public abstract bool vmethod_1885();

		// Token: 0x06000AD8 RID: 2776
		public abstract int? dmethod_1886();

		// Token: 0x06000AD9 RID: 2777
		public abstract string kmethod_1887();

		// Token: 0x06000ADA RID: 2778
		public abstract byte[] lmethod_1888();

		// Token: 0x06000ADB RID: 2779
		public abstract decimal? pmethod_1889();

		// Token: 0x06000ADC RID: 2780
		public abstract DateTime? smethod_1890();

		// Token: 0x06000ADD RID: 2781
		public abstract DateTimeOffset? xmethod_1891();

		// Token: 0x06000ADE RID: 2782 RVA: 0x00018443 File Offset: 0x00016643
		internal virtual bool tmethod_1892()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0003ED2C File Offset: 0x0003CF2C
		internal DateTimeOffset? gmethod_1893()
		{
			this.field_4 = Class_408.ReadAsDateTimeOffset;
			while (this.tmethod_1892())
			{
				Class_508 class_ = this.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (class_ == Class_508.Date)
					{
						if (this.prop_10 is DateTime)
						{
							this.gmethod_1903(Class_508.Date, new DateTimeOffset((DateTime)this.prop_10), false);
						}
						return new DateTimeOffset?((DateTimeOffset)this.prop_10);
					}
					if (class_ == Class_508.Null)
					{
						return null;
					}
					if (class_ == Class_508.String)
					{
						string text = (string)this.prop_10;
						if (string.IsNullOrEmpty(text))
						{
							this.xmethod_1901(Class_508.Null);
							return null;
						}
						object obj;
						DateTimeOffset dateTimeOffset;
						if (Class_502.TryParseDateTime(text, Class_320.DateTimeOffset, this.prop_4, this.field_12, this.prop_14, out obj))
						{
							dateTimeOffset = (DateTimeOffset)obj;
							this.gmethod_1903(Class_508.Date, dateTimeOffset, false);
							return new DateTimeOffset?(dateTimeOffset);
						}
						if (DateTimeOffset.TryParse(text, this.prop_14, DateTimeStyles.RoundtripKind, out dateTimeOffset))
						{
							this.gmethod_1903(Class_508.Date, dateTimeOffset, false);
							return new DateTimeOffset?(dateTimeOffset);
						}
						throw Class_414.lmethod_3098(this, "Could not convert string to DateTimeOffset: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_10));
					}
					else
					{
						if (class_ == Class_508.EndArray)
						{
							return null;
						}
						throw Class_414.lmethod_3098(this, "Error reading date. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, class_));
					}
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		internal byte[] cmethod_1894()
		{
			this.field_4 = Class_408.ReadAsBytes;
			while (this.tmethod_1892())
			{
				Class_508 class_ = this.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (this.pmethod_1899())
					{
						byte[] array = this.lmethod_1888();
						this.tmethod_1892();
						this.gmethod_1903(Class_508.Bytes, array, false);
						return array;
					}
					if (class_ == Class_508.String)
					{
						string text = (string)this.prop_10;
						byte[] array2;
						Guid guid;
						if (text.Length == 0)
						{
							array2 = new byte[0];
						}
						else if (Guid.TryParse(text, out guid))
						{
							array2 = guid.ToByteArray();
						}
						else
						{
							array2 = Convert.FromBase64String(text);
						}
						this.gmethod_1903(Class_508.Bytes, array2, false);
						return array2;
					}
					if (class_ == Class_508.Null)
					{
						return null;
					}
					if (class_ == Class_508.Bytes)
					{
						if (this.prop_11 == typeof(Guid))
						{
							byte[] array3 = ((Guid)this.prop_10).ToByteArray();
							this.gmethod_1903(Class_508.Bytes, array3, false);
							return array3;
						}
						return (byte[])this.prop_10;
					}
					else
					{
						if (class_ == Class_508.StartArray)
						{
							List<byte> list = new List<byte>();
							while (this.tmethod_1892())
							{
								class_ = this.prop_9;
								Class_508 class_2 = class_;
								switch (class_2)
								{
								case Class_508.Comment:
									continue;
								case Class_508.Raw:
									break;
								case Class_508.Integer:
									list.Add(Convert.ToByte(this.prop_10, CultureInfo.InvariantCulture));
									continue;
								default:
									if (class_2 == Class_508.EndArray)
									{
										byte[] array4 = list.ToArray();
										this.gmethod_1903(Class_508.Bytes, array4, false);
										return array4;
									}
									break;
								}
								throw Class_414.lmethod_3098(this, "Unexpected token when reading bytes: {0}.".FormatWith(CultureInfo.InvariantCulture, class_));
							}
							throw Class_414.lmethod_3098(this, "Unexpected end when reading bytes.");
						}
						if (class_ == Class_508.EndArray)
						{
							return null;
						}
						throw Class_414.lmethod_3098(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, class_));
					}
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0003F088 File Offset: 0x0003D288
		internal decimal? vmethod_1895()
		{
			this.field_4 = Class_408.ReadAsDecimal;
			while (this.tmethod_1892())
			{
				Class_508 class_ = this.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (class_ == Class_508.Integer || class_ == Class_508.Float)
					{
						if (!(this.prop_10 is decimal))
						{
							this.gmethod_1903(Class_508.Float, Convert.ToDecimal(this.prop_10, CultureInfo.InvariantCulture), false);
						}
						return new decimal?((decimal)this.prop_10);
					}
					if (class_ == Class_508.Null)
					{
						return null;
					}
					if (class_ == Class_508.String)
					{
						string text = (string)this.prop_10;
						if (string.IsNullOrEmpty(text))
						{
							this.xmethod_1901(Class_508.Null);
							return null;
						}
						decimal num;
						if (decimal.TryParse(text, NumberStyles.Number, this.prop_14, out num))
						{
							this.gmethod_1903(Class_508.Float, num, false);
							return new decimal?(num);
						}
						throw Class_414.lmethod_3098(this, "Could not convert string to decimal: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_10));
					}
					else
					{
						if (class_ == Class_508.EndArray)
						{
							return null;
						}
						throw Class_414.lmethod_3098(this, "Error reading decimal. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, class_));
					}
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0003F1CC File Offset: 0x0003D3CC
		internal int? dmethod_1896()
		{
			this.field_4 = Class_408.ReadAsInt32;
			while (this.tmethod_1892())
			{
				Class_508 class_ = this.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (class_ == Class_508.Integer || class_ == Class_508.Float)
					{
						if (!(this.prop_10 is int))
						{
							this.gmethod_1903(Class_508.Integer, Convert.ToInt32(this.prop_10, CultureInfo.InvariantCulture), false);
						}
						return new int?((int)this.prop_10);
					}
					if (class_ == Class_508.Null)
					{
						return null;
					}
					if (class_ == Class_508.String)
					{
						string text = (string)this.prop_10;
						if (string.IsNullOrEmpty(text))
						{
							this.xmethod_1901(Class_508.Null);
							return null;
						}
						int num;
						if (int.TryParse(text, NumberStyles.Integer, this.prop_14, out num))
						{
							this.gmethod_1903(Class_508.Integer, num, false);
							return new int?(num);
						}
						throw Class_414.lmethod_3098(this, "Could not convert string to integer: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_10));
					}
					else
					{
						if (class_ == Class_508.EndArray)
						{
							return null;
						}
						throw Class_414.lmethod_3098(this, "Error reading integer. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_9));
					}
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003F314 File Offset: 0x0003D514
		internal string kmethod_1897()
		{
			this.field_4 = Class_408.ReadAsString;
			while (this.tmethod_1892())
			{
				Class_508 class_ = this.prop_9;
				if (class_ != Class_508.Comment)
				{
					if (class_ == Class_508.String)
					{
						return (string)this.prop_10;
					}
					if (class_ == Class_508.Null)
					{
						return null;
					}
					if (Class_486.IsPrimitiveToken(class_) && this.prop_10 != null)
					{
						string text;
						if (this.prop_10 is IFormattable)
						{
							text = ((IFormattable)this.prop_10).ToString(null, this.prop_14);
						}
						else
						{
							text = this.prop_10.ToString();
						}
						this.gmethod_1903(Class_508.String, text, false);
						return text;
					}
					if (class_ == Class_508.EndArray)
					{
						return null;
					}
					throw Class_414.lmethod_3098(this, "Error reading string. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, class_));
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0003F3E8 File Offset: 0x0003D5E8
		internal DateTime? lmethod_1898()
		{
			this.field_4 = Class_408.ReadAsDateTime;
			while (this.tmethod_1892())
			{
				if (this.prop_9 != Class_508.Comment)
				{
					if (this.prop_9 == Class_508.Date)
					{
						return new DateTime?((DateTime)this.prop_10);
					}
					if (this.prop_9 == Class_508.Null)
					{
						return null;
					}
					if (this.prop_9 == Class_508.String)
					{
						string text = (string)this.prop_10;
						if (string.IsNullOrEmpty(text))
						{
							this.xmethod_1901(Class_508.Null);
							return null;
						}
						object obj;
						DateTime dateTime;
						if (Class_502.TryParseDateTime(text, Class_320.DateTime, this.prop_4, this.field_12, this.prop_14, out obj))
						{
							dateTime = (DateTime)obj;
							dateTime = Class_502.EnsureDateTime(dateTime, this.prop_4);
							this.gmethod_1903(Class_508.Date, dateTime, false);
							return new DateTime?(dateTime);
						}
						if (DateTime.TryParse(text, this.prop_14, DateTimeStyles.RoundtripKind, out dateTime))
						{
							dateTime = Class_502.EnsureDateTime(dateTime, this.prop_4);
							this.gmethod_1903(Class_508.Date, dateTime, false);
							return new DateTime?(dateTime);
						}
						throw Class_414.lmethod_3098(this, "Could not convert string to DateTime: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_10));
					}
					else
					{
						if (this.prop_9 == Class_508.EndArray)
						{
							return null;
						}
						throw Class_414.lmethod_3098(this, "Error reading date. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, this.prop_9));
					}
				}
			}
			this.xmethod_1901(Class_508.None);
			return null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003F570 File Offset: 0x0003D770
		private bool pmethod_1899()
		{
			this.field_4 = Class_408.Read;
			if (this.prop_9 != Class_508.StartObject)
			{
				return false;
			}
			if (!this.tmethod_1892())
			{
				throw Class_414.lmethod_3098(this, "Unexpected end when reading bytes.");
			}
			if (this.prop_10.ToString() == "$type")
			{
				this.tmethod_1892();
				if (this.prop_10 != null && this.prop_10.ToString().StartsWith("System.Byte[]", StringComparison.Ordinal))
				{
					this.tmethod_1892();
					if (this.prop_10.ToString() == "$value")
					{
						return true;
					}
				}
			}
			throw Class_414.lmethod_3098(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(CultureInfo.InvariantCulture, Class_508.StartObject));
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003F630 File Offset: 0x0003D830
		public void smethod_1900()
		{
			if (this.prop_9 == Class_508.PropertyName)
			{
				this.vmethod_1885();
			}
			if (Class_486.IsStartToken(this.prop_9))
			{
				int num = this.prop_12;
				while (this.vmethod_1885() && num < this.prop_12)
				{
				}
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003F67B File Offset: 0x0003D87B
		protected void xmethod_1901(Class_508 arg_0)
		{
			this.gmethod_1903(arg_0, null, true);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003F686 File Offset: 0x0003D886
		protected void tmethod_1902(Class_508 arg_0, object obje_0)
		{
			this.gmethod_1903(arg_0, obje_0, true);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003F694 File Offset: 0x0003D894
		internal void gmethod_1903(Class_508 arg_0, object obje_0, bool bool_0)
		{
			this.field_0 = arg_0;
			this.field_1 = obje_0;
			switch (arg_0)
			{
			case Class_508.StartObject:
				this.field_3 = Class_285.NClass_0.field_8;
				this.tmethod_1882(Class_325.Object);
				return;
			case Class_508.StartArray:
				this.field_3 = Class_285.NClass_0.field_10;
				this.tmethod_1882(Class_325.Array);
				return;
			case Class_508.StartConstructor:
				this.field_3 = Class_285.NClass_0.field_14;
				this.tmethod_1882(Class_325.Constructor);
				return;
			case Class_508.PropertyName:
				this.field_3 = Class_285.NClass_0.field_7;
				this.field_5.PropertyName = (string)obje_0;
				return;
			case Class_508.Comment:
				break;
			case Class_508.Raw:
			case Class_508.Integer:
			case Class_508.Float:
			case Class_508.String:
			case Class_508.Boolean:
			case Class_508.Null:
			case Class_508.Undefined:
			case Class_508.Date:
			case Class_508.Bytes:
				this.cmethod_1904(bool_0);
				break;
			case Class_508.EndObject:
				this.dmethod_1906(Class_508.EndObject);
				return;
			case Class_508.EndArray:
				this.dmethod_1906(Class_508.EndArray);
				return;
			case Class_508.EndConstructor:
				this.dmethod_1906(Class_508.EndConstructor);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003F767 File Offset: 0x0003D967
		internal void cmethod_1904(bool bool_0)
		{
			if (this.cmethod_1884() != Class_325.None)
			{
				this.field_3 = Class_285.NClass_0.field_13;
			}
			else
			{
				this.lmethod_1908();
			}
			if (bool_0)
			{
				this.vmethod_1905();
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003F792 File Offset: 0x0003D992
		private void vmethod_1905()
		{
			if (this.field_5.HasIndex)
			{
				this.field_5.Position = this.field_5.Position + 1;
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003F7B8 File Offset: 0x0003D9B8
		private void dmethod_1906(Class_508 arg_0)
		{
			Class_325 class_ = this.gmethod_1883();
			if (this.pmethod_1909(arg_0) != class_)
			{
				throw Class_414.lmethod_3098(this, "JsonToken {0} is not valid for closing JsonType {1}.".FormatWith(CultureInfo.InvariantCulture, arg_0, class_));
			}
			if (this.cmethod_1884() != Class_325.None)
			{
				this.field_3 = Class_285.NClass_0.field_13;
				return;
			}
			this.lmethod_1908();
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0003F814 File Offset: 0x0003DA14
		protected void kmethod_1907()
		{
			Class_325 class_ = this.cmethod_1884();
			switch (class_)
			{
			case Class_325.None:
				this.lmethod_1908();
				return;
			case Class_325.Object:
				this.field_3 = Class_285.NClass_0.field_9;
				return;
			case Class_325.Array:
				this.field_3 = Class_285.NClass_0.field_11;
				return;
			case Class_325.Constructor:
				this.field_3 = Class_285.NClass_0.field_15;
				return;
			default:
				throw Class_414.lmethod_3098(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".FormatWith(CultureInfo.InvariantCulture, class_));
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0003F880 File Offset: 0x0003DA80
		private void lmethod_1908()
		{
			if (this.prop_2)
			{
				this.field_3 = Class_285.NClass_0.field_5;
				return;
			}
			this.field_3 = Class_285.NClass_0.field_17;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003F8A0 File Offset: 0x0003DAA0
		private Class_325 pmethod_1909(Class_508 arg_0)
		{
			switch (arg_0)
			{
			case Class_508.EndObject:
				return Class_325.Object;
			case Class_508.EndArray:
				return Class_325.Array;
			case Class_508.EndConstructor:
				return Class_325.Constructor;
			default:
				throw Class_414.lmethod_3098(this, "Not a valid close JsonToken: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0));
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003F8EA File Offset: 0x0003DAEA
		void IDisposable.smethod_1910()
		{
			this.xmethod_1911(true);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0003F8F3 File Offset: 0x0003DAF3
		protected virtual void xmethod_1911(bool bool_0)
		{
			if (this.field_3 != Class_285.NClass_0.field_12 && bool_0)
			{
				this.tmethod_1912();
			}
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003F90D File Offset: 0x0003DB0D
		public virtual void tmethod_1912()
		{
			this.field_3 = Class_285.NClass_0.field_12;
			this.field_0 = Class_508.None;
			this.field_1 = null;
		}

		// Token: 0x04000726 RID: 1830
		private Class_508 field_0;

		// Token: 0x04000727 RID: 1831
		private object field_1;

		// Token: 0x04000728 RID: 1832
		internal char field_2;

		// Token: 0x04000729 RID: 1833
		internal Class_285.NClass_0 field_3;

		// Token: 0x0400072A RID: 1834
		internal Class_408 field_4;

		// Token: 0x0400072B RID: 1835
		private Class_326 field_5;

		// Token: 0x0400072C RID: 1836
		private CultureInfo field_6;

		// Token: 0x0400072D RID: 1837
		private Class_321 field_7;

		// Token: 0x0400072E RID: 1838
		private int? field_8;

		// Token: 0x0400072F RID: 1839
		private bool field_9;

		// Token: 0x04000730 RID: 1840
		internal Class_320 field_10;

		// Token: 0x04000731 RID: 1841
		internal Class_315 field_11;

		// Token: 0x04000732 RID: 1842
		private string field_12;

		// Token: 0x04000733 RID: 1843
		private readonly List<Class_326> field_13;

		// Token: 0x04000734 RID: 1844
		[CompilerGenerated]
		private bool field_14;

		// Token: 0x04000735 RID: 1845
		[CompilerGenerated]
		private bool field_15;

		// Token: 0x02000189 RID: 393
		protected internal enum NClass_0
		{
			// Token: 0x04000737 RID: 1847
			field_5,
			// Token: 0x04000738 RID: 1848
			field_6,
			// Token: 0x04000739 RID: 1849
			field_7,
			// Token: 0x0400073A RID: 1850
			field_8,
			// Token: 0x0400073B RID: 1851
			field_9,
			// Token: 0x0400073C RID: 1852
			field_10,
			// Token: 0x0400073D RID: 1853
			field_11,
			// Token: 0x0400073E RID: 1854
			field_12,
			// Token: 0x0400073F RID: 1855
			field_13,
			// Token: 0x04000740 RID: 1856
			field_14,
			// Token: 0x04000741 RID: 1857
			field_15,
			// Token: 0x04000742 RID: 1858
			field_16,
			// Token: 0x04000743 RID: 1859
			field_17
		}
	}
}
