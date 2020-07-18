using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000196 RID: 406
	public abstract class Class_296 : IDisposable
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x00040838 File Offset: 0x0003EA38
		internal static Class_296.NClass_0[][] pmethod_1979()
		{
			List<Class_296.NClass_0[]> list = Class_296.field_1.ToList<Class_296.NClass_0[]>();
			Class_296.NClass_0[] item = Class_296.field_1[0];
			Class_296.NClass_0[] item2 = Class_296.field_1[7];
			foreach (object obj in Class_505.GetValues(typeof(Class_508)))
			{
				Class_508 class_ = (Class_508)obj;
				if (list.Count <= (int)class_)
				{
					switch (class_)
					{
					case Class_508.Integer:
					case Class_508.Float:
					case Class_508.String:
					case Class_508.Boolean:
					case Class_508.Null:
					case Class_508.Undefined:
					case Class_508.Date:
					case Class_508.Bytes:
						list.Add(item2);
						continue;
					}
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00040920 File Offset: 0x0003EB20
		static Class_296()
		{
			Class_296.field_0 = Class_296.pmethod_1979();
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00040B3E File Offset: 0x0003ED3E
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00040B46 File Offset: 0x0003ED46
		public bool prop_0 { get; set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00040B50 File Offset: 0x0003ED50
		protected internal int prop_1
		{
			get
			{
				int num = this.field_2.Count;
				if (this.cmethod_2004() != Class_325.None)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00040B7C File Offset: 0x0003ED7C
		public Class_518 prop_2
		{
			get
			{
				switch (this.field_4)
				{
				case Class_296.NClass_0.field_3:
					return Class_518.Start;
				case Class_296.NClass_0.field_4:
					return Class_518.Property;
				case Class_296.NClass_0.field_5:
				case Class_296.NClass_0.field_6:
					return Class_518.Object;
				case Class_296.NClass_0.field_7:
				case Class_296.NClass_0.field_8:
					return Class_518.Array;
				case Class_296.NClass_0.field_9:
				case Class_296.NClass_0.field_10:
					return Class_518.Constructor;
				case Class_296.NClass_0.field_11:
					return Class_518.Closed;
				case Class_296.NClass_0.field_12:
					return Class_518.Error;
				default:
					throw Class_413.smethod_3090(this, "Invalid state: " + this.field_4, null);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00040BED File Offset: 0x0003EDED
		internal string prop_3
		{
			get
			{
				if (this.field_3.Type == Class_325.None)
				{
					return string.Empty;
				}
				return Class_326.BuildPath(this.field_2);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00040C10 File Offset: 0x0003EE10
		public string prop_4
		{
			get
			{
				if (this.field_3.Type == Class_325.None)
				{
					return string.Empty;
				}
				bool flag = this.field_4 != Class_296.NClass_0.field_7 && this.field_4 != Class_296.NClass_0.field_9 && this.field_4 != Class_296.NClass_0.field_5;
				IEnumerable<Class_326> positions = (!flag) ? this.field_2 : this.field_2.Concat(new Class_326[]
				{
					this.field_3
				});
				return Class_326.BuildPath(positions);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00040C9B File Offset: 0x0003EE9B
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00040CA3 File Offset: 0x0003EEA3
		public Class_322 prop_5
		{
			get
			{
				return this.field_5;
			}
			set
			{
				this.field_5 = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00040CAC File Offset: 0x0003EEAC
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00040CB4 File Offset: 0x0003EEB4
		public Class_319 prop_6
		{
			get
			{
				return this.field_6;
			}
			set
			{
				this.field_6 = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00040CBD File Offset: 0x0003EEBD
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00040CC5 File Offset: 0x0003EEC5
		public Class_321 prop_7
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00040CCE File Offset: 0x0003EECE
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00040CD6 File Offset: 0x0003EED6
		public Class_356 prop_8
		{
			get
			{
				return this.field_8;
			}
			set
			{
				this.field_8 = value;
				this.cmethod_1994();
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002050 File Offset: 0x00000250
		internal virtual void cmethod_1994()
		{
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00040CE5 File Offset: 0x0003EEE5
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00040CED File Offset: 0x0003EEED
		public Class_314 prop_9
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00040CF6 File Offset: 0x0003EEF6
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00040CFE File Offset: 0x0003EEFE
		public string prop_10
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

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00040D07 File Offset: 0x0003EF07
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00040D1B File Offset: 0x0003EF1B
		public CultureInfo prop_11
		{
			get
			{
				return this.field_11 ?? CultureInfo.InvariantCulture;
			}
			set
			{
				this.field_11 = value;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00040D24 File Offset: 0x0003EF24
		protected Class_296()
		{
			this.field_2 = new List<Class_326>(4);
			this.field_4 = Class_296.NClass_0.field_3;
			this.field_5 = Class_322.None;
			this.field_7 = Class_321.RoundtripKind;
			this.prop_0 = true;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00040D54 File Offset: 0x0003EF54
		internal void xmethod_2001()
		{
			if (this.field_3.HasIndex)
			{
				this.field_3.Position = this.field_3.Position + 1;
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00040D79 File Offset: 0x0003EF79
		private void tmethod_2002(Class_325 arg_0)
		{
			if (this.field_3.Type != Class_325.None)
			{
				this.field_2.Add(this.field_3);
			}
			this.field_3 = new Class_326(arg_0);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00040DA8 File Offset: 0x0003EFA8
		private Class_325 gmethod_2003()
		{
			Class_326 class_ = this.field_3;
			if (this.field_2.Count > 0)
			{
				this.field_3 = this.field_2[this.field_2.Count - 1];
				this.field_2.RemoveAt(this.field_2.Count - 1);
			}
			else
			{
				this.field_3 = default(Class_326);
			}
			return class_.Type;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00040E1B File Offset: 0x0003F01B
		private Class_325 cmethod_2004()
		{
			return this.field_3.Type;
		}

		// Token: 0x06000B5F RID: 2911
		public abstract void vmethod_2005();

		// Token: 0x06000B60 RID: 2912 RVA: 0x00040E28 File Offset: 0x0003F028
		public virtual void dmethod_2006()
		{
			this.vmethod_2025();
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00040E30 File Offset: 0x0003F030
		public virtual void kmethod_2007()
		{
			this.vmethod_2085(Class_508.StartObject, Class_325.Object);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00040E3A File Offset: 0x0003F03A
		public virtual void lmethod_2008()
		{
			this.tmethod_2082(Class_325.Object);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00040E43 File Offset: 0x0003F043
		public virtual void pmethod_2009()
		{
			this.vmethod_2085(Class_508.StartArray, Class_325.Array);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00040E4D File Offset: 0x0003F04D
		public virtual void smethod_2010()
		{
			this.tmethod_2082(Class_325.Array);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00040E56 File Offset: 0x0003F056
		public virtual void xmethod_2011(string str_0)
		{
			this.vmethod_2085(Class_508.StartConstructor, Class_325.Constructor);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00040E60 File Offset: 0x0003F060
		public virtual void tmethod_2012()
		{
			this.tmethod_2082(Class_325.Constructor);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00040E69 File Offset: 0x0003F069
		public virtual void gmethod_2013(string str_0)
		{
			this.gmethod_2083(str_0);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00040E72 File Offset: 0x0003F072
		public virtual void cmethod_2014(string str_0, bool bool_0)
		{
			this.gmethod_2013(str_0);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00040E7B File Offset: 0x0003F07B
		public virtual void vmethod_2015()
		{
			this.cmethod_2024(this.cmethod_2004());
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00040E89 File Offset: 0x0003F089
		public void dmethod_2016(Class_285 arg_0)
		{
			this.smethod_2020(arg_0, true, true);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00040E94 File Offset: 0x0003F094
		public void kmethod_2017(Class_285 arg_0, bool bool_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			this.smethod_2020(arg_0, bool_0, true);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00040EAA File Offset: 0x0003F0AA
		public void lmethod_2018(Class_508 arg_0, object obje_0)
		{
			this.tmethod_2022(arg_0, obje_0);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00040EB4 File Offset: 0x0003F0B4
		public void pmethod_2019(Class_508 arg_0)
		{
			this.tmethod_2022(arg_0, null);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00040EC0 File Offset: 0x0003F0C0
		internal void smethod_2020(Class_285 arg_0, bool bool_0, bool bool_1)
		{
			int sayıInt_;
			if (arg_0.prop_9 == Class_508.None)
			{
				sayıInt_ = -1;
			}
			else if (!Class_486.IsStartToken(arg_0.prop_9))
			{
				sayıInt_ = arg_0.prop_12 + 1;
			}
			else
			{
				sayıInt_ = arg_0.prop_12;
			}
			this.xmethod_2021(arg_0, sayıInt_, bool_0, bool_1);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00040F10 File Offset: 0x0003F110
		internal void xmethod_2021(Class_285 arg_0, int sayıInt_0, bool bool_0, bool bool_1)
		{
			do
			{
				if (bool_1 && arg_0.prop_9 == Class_508.StartConstructor && string.Equals(arg_0.prop_10.ToString(), "Date", StringComparison.Ordinal))
				{
					this.gmethod_2023(arg_0);
				}
				else
				{
					this.tmethod_2022(arg_0.prop_9, arg_0.prop_10);
				}
			}
			while (sayıInt_0 - 1 < arg_0.prop_12 - (Class_486.IsEndToken(arg_0.prop_9) ? 1 : 0) && bool_0 && arg_0.vmethod_1885());
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00040FA0 File Offset: 0x0003F1A0
		private void tmethod_2022(Class_508 arg_0, object obje_0)
		{
			switch (arg_0)
			{
			case Class_508.None:
				return;
			case Class_508.StartObject:
				this.kmethod_2007();
				return;
			case Class_508.StartArray:
				this.pmethod_2009();
				return;
			case Class_508.StartConstructor:
				Class_517.ArgumentNotNull(obje_0, "value");
				this.xmethod_2011(obje_0.ToString());
				return;
			case Class_508.PropertyName:
				Class_517.ArgumentNotNull(obje_0, "value");
				this.gmethod_2013(obje_0.ToString());
				return;
			case Class_508.Comment:
				this.vmethod_2075((obje_0 != null) ? obje_0.ToString() : null);
				return;
			case Class_508.Raw:
				this.dmethod_2036((obje_0 != null) ? obje_0.ToString() : null);
				return;
			case Class_508.Integer:
				Class_517.ArgumentNotNull(obje_0, "value");
				if (obje_0 is BigInteger)
				{
					this.cmethod_2074((BigInteger)obje_0);
					return;
				}
				this.smethod_2040(Convert.ToInt64(obje_0, CultureInfo.InvariantCulture));
				return;
			case Class_508.Float:
				Class_517.ArgumentNotNull(obje_0, "value");
				if (obje_0 is decimal)
				{
					this.smethod_2050((decimal)obje_0);
					return;
				}
				if (obje_0 is double)
				{
					this.gmethod_2043((double)obje_0);
					return;
				}
				if (obje_0 is float)
				{
					this.tmethod_2042((float)obje_0);
					return;
				}
				this.gmethod_2043(Convert.ToDouble(obje_0, CultureInfo.InvariantCulture));
				return;
			case Class_508.String:
				Class_517.ArgumentNotNull(obje_0, "value");
				this.kmethod_2037(obje_0.ToString());
				return;
			case Class_508.Boolean:
				Class_517.ArgumentNotNull(obje_0, "value");
				this.cmethod_2044(Convert.ToBoolean(obje_0, CultureInfo.InvariantCulture));
				return;
			case Class_508.Null:
				this.gmethod_2033();
				return;
			case Class_508.Undefined:
				this.cmethod_2034();
				return;
			case Class_508.EndObject:
				this.lmethod_2008();
				return;
			case Class_508.EndArray:
				this.smethod_2010();
				return;
			case Class_508.EndConstructor:
				this.tmethod_2012();
				return;
			case Class_508.Date:
				Class_517.ArgumentNotNull(obje_0, "value");
				if (obje_0 is DateTimeOffset)
				{
					this.tmethod_2052((DateTimeOffset)obje_0);
					return;
				}
				this.xmethod_2051(Convert.ToDateTime(obje_0, CultureInfo.InvariantCulture));
				return;
			case Class_508.Bytes:
				Class_517.ArgumentNotNull(obje_0, "value");
				if (obje_0 is Guid)
				{
					this.gmethod_2053((Guid)obje_0);
					return;
				}
				this.tmethod_2072((byte[])obje_0);
				return;
			default:
				throw Class_513.CreateArgumentOutOfRangeException("TokenType", arg_0, "Unexpected token type.");
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000411E4 File Offset: 0x0003F3E4
		private void gmethod_2023(Class_285 arg_0)
		{
			if (!arg_0.vmethod_1885())
			{
				throw Class_413.smethod_3090(this, "Unexpected end when reading date constructor.", null);
			}
			if (arg_0.prop_9 != Class_508.Integer)
			{
				throw Class_413.smethod_3090(this, "Unexpected token when reading date constructor. Expected Integer, got " + arg_0.prop_9, null);
			}
			long javaScriptTicks = (long)arg_0.prop_10;
			DateTime arg_ = Class_502.ConvertJavaScriptTicksToDateTime(javaScriptTicks);
			if (!arg_0.vmethod_1885())
			{
				throw Class_413.smethod_3090(this, "Unexpected end when reading date constructor.", null);
			}
			if (arg_0.prop_9 != Class_508.EndConstructor)
			{
				throw Class_413.smethod_3090(this, "Unexpected token when reading date constructor. Expected EndConstructor, got " + arg_0.prop_9, null);
			}
			this.xmethod_2051(arg_);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00041290 File Offset: 0x0003F490
		private void cmethod_2024(Class_325 arg_0)
		{
			switch (arg_0)
			{
			case Class_325.Object:
				this.lmethod_2008();
				return;
			case Class_325.Array:
				this.smethod_2010();
				return;
			case Class_325.Constructor:
				this.tmethod_2012();
				return;
			default:
				throw Class_413.smethod_3090(this, "Unexpected type when writing end: " + arg_0, null);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000412E4 File Offset: 0x0003F4E4
		private void vmethod_2025()
		{
			while (this.prop_1 > 0)
			{
				this.vmethod_2015();
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000412FC File Offset: 0x0003F4FC
		private Class_508 dmethod_2026(Class_325 arg_0)
		{
			switch (arg_0)
			{
			case Class_325.Object:
				return Class_508.EndObject;
			case Class_325.Array:
				return Class_508.EndArray;
			case Class_325.Constructor:
				return Class_508.EndConstructor;
			default:
				throw Class_413.smethod_3090(this, "No close token for type: " + arg_0, null);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00041344 File Offset: 0x0003F544
		private void kmethod_2027(Class_325 arg_0)
		{
			int num = 0;
			if (this.field_3.Type == arg_0)
			{
				num = 1;
			}
			else
			{
				int num2 = this.prop_1 - 2;
				for (int i = num2; i >= 0; i--)
				{
					int index = num2 - i;
					if (this.field_2[index].Type == arg_0)
					{
						num = i + 2;
						break;
					}
				}
			}
			if (num == 0)
			{
				throw Class_413.smethod_3090(this, "No token to close.", null);
			}
			for (int j = 0; j < num; j++)
			{
				Class_508 arg_ = this.dmethod_2026(this.gmethod_2003());
				if (this.field_4 == Class_296.NClass_0.field_4)
				{
					this.gmethod_2033();
				}
				if (this.field_5 == Class_322.Indented && this.field_4 != Class_296.NClass_0.field_5 && this.field_4 != Class_296.NClass_0.field_7)
				{
					this.pmethod_2029();
				}
				this.lmethod_2028(arg_);
				Class_325 class_ = this.cmethod_2004();
				switch (class_)
				{
				case Class_325.None:
					this.field_4 = Class_296.NClass_0.field_3;
					break;
				case Class_325.Object:
					this.field_4 = Class_296.NClass_0.field_6;
					break;
				case Class_325.Array:
					this.field_4 = Class_296.NClass_0.field_8;
					break;
				case Class_325.Constructor:
					this.field_4 = Class_296.NClass_0.field_8;
					break;
				default:
					throw Class_413.smethod_3090(this, "Unknown JsonType: " + class_, null);
				}
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void lmethod_2028(Class_508 arg_0)
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void pmethod_2029()
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void smethod_2030()
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void xmethod_2031()
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00041494 File Offset: 0x0003F694
		internal void tmethod_2032(Class_508 arg_0)
		{
			Class_296.NClass_0 nclass_ = Class_296.field_0[(int)arg_0][(int)this.field_4];
			if (nclass_ == Class_296.NClass_0.field_12)
			{
				throw Class_413.smethod_3090(this, "Token {0} in state {1} would result in an invalid JSON object.".FormatWith(CultureInfo.InvariantCulture, arg_0.ToString(), this.field_4.ToString()), null);
			}
			if ((this.field_4 == Class_296.NClass_0.field_6 || this.field_4 == Class_296.NClass_0.field_8 || this.field_4 == Class_296.NClass_0.field_10) && arg_0 != Class_508.Comment)
			{
				this.smethod_2030();
			}
			if (this.field_5 == Class_322.Indented)
			{
				if (this.field_4 == Class_296.NClass_0.field_4)
				{
					this.xmethod_2031();
				}
				if (this.field_4 == Class_296.NClass_0.field_8 || this.field_4 == Class_296.NClass_0.field_7 || this.field_4 == Class_296.NClass_0.field_10 || this.field_4 == Class_296.NClass_0.field_9 || (arg_0 == Class_508.PropertyName && this.field_4 != Class_296.NClass_0.field_3))
				{
					this.pmethod_2029();
				}
			}
			this.field_4 = nclass_;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0004158C File Offset: 0x0003F78C
		public virtual void gmethod_2033()
		{
			this.dmethod_2086(Class_508.Null);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00041596 File Offset: 0x0003F796
		public virtual void cmethod_2034()
		{
			this.dmethod_2086(Class_508.Undefined);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000415A0 File Offset: 0x0003F7A0
		public virtual void vmethod_2035(string str_0)
		{
			this.cmethod_2084();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000415A8 File Offset: 0x0003F7A8
		public virtual void dmethod_2036(string str_0)
		{
			this.xmethod_2001();
			this.tmethod_2032(Class_508.Undefined);
			this.vmethod_2035(str_0);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000415BF File Offset: 0x0003F7BF
		public virtual void kmethod_2037(string str_0)
		{
			this.dmethod_2086(Class_508.String);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public virtual void lmethod_2038(int sayıInt_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000415C9 File Offset: 0x0003F7C9
		[CLSCompliant(false)]
		public virtual void pmethod_2039(uint arg_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public virtual void smethod_2040(long sayıUınt_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000415C9 File Offset: 0x0003F7C9
		[CLSCompliant(false)]
		public virtual void xmethod_2041(ulong arg_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000415D2 File Offset: 0x0003F7D2
		public virtual void tmethod_2042(float arg_0)
		{
			this.dmethod_2086(Class_508.Float);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000415D2 File Offset: 0x0003F7D2
		public virtual void gmethod_2043(double double_0)
		{
			this.dmethod_2086(Class_508.Float);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000415DB File Offset: 0x0003F7DB
		public virtual void cmethod_2044(bool bool_0)
		{
			this.dmethod_2086(Class_508.Boolean);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public virtual void vmethod_2045(short sayıShort_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000415C9 File Offset: 0x0003F7C9
		[CLSCompliant(false)]
		public virtual void dmethod_2046(ushort arg_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000415BF File Offset: 0x0003F7BF
		public virtual void kmethod_2047(char char_0)
		{
			this.dmethod_2086(Class_508.String);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public virtual void lmethod_2048(byte byte_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000415C9 File Offset: 0x0003F7C9
		[CLSCompliant(false)]
		public virtual void pmethod_2049(sbyte arg_0)
		{
			this.dmethod_2086(Class_508.Integer);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000415D2 File Offset: 0x0003F7D2
		public virtual void smethod_2050(decimal arg_0)
		{
			this.dmethod_2086(Class_508.Float);
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000415E5 File Offset: 0x0003F7E5
		public virtual void xmethod_2051(DateTime arg_0)
		{
			this.dmethod_2086(Class_508.Date);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000415E5 File Offset: 0x0003F7E5
		public virtual void tmethod_2052(DateTimeOffset arg_0)
		{
			this.dmethod_2086(Class_508.Date);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000415BF File Offset: 0x0003F7BF
		public virtual void gmethod_2053(Guid arg_0)
		{
			this.dmethod_2086(Class_508.String);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000415BF File Offset: 0x0003F7BF
		public virtual void cmethod_2054(TimeSpan arg_0)
		{
			this.dmethod_2086(Class_508.String);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000415EF File Offset: 0x0003F7EF
		public virtual void vmethod_2055(int? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.lmethod_2038(arg_0.Value);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00041611 File Offset: 0x0003F811
		[CLSCompliant(false)]
		public virtual void dmethod_2056(uint? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.pmethod_2039(arg_0.Value);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00041633 File Offset: 0x0003F833
		public virtual void kmethod_2057(long? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.smethod_2040(arg_0.Value);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00041655 File Offset: 0x0003F855
		[CLSCompliant(false)]
		public virtual void lmethod_2058(ulong? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.xmethod_2041(arg_0.Value);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00041677 File Offset: 0x0003F877
		public virtual void pmethod_2059(float? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.tmethod_2042(arg_0.Value);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00041699 File Offset: 0x0003F899
		public virtual void smethod_2060(double? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.gmethod_2043(arg_0.Value);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000416BB File Offset: 0x0003F8BB
		public virtual void xmethod_2061(bool? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.cmethod_2044(arg_0.Value);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000416E0 File Offset: 0x0003F8E0
		public virtual void tmethod_2062(short? arg_0)
		{
			short? num = arg_0;
			int? num2 = (num != null) ? new int?((int)num.GetValueOrDefault()) : null;
			if (num2 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.vmethod_2045(arg_0.Value);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00041738 File Offset: 0x0003F938
		[CLSCompliant(false)]
		public virtual void gmethod_2063(ushort? arg_0)
		{
			ushort? num = arg_0;
			int? num2 = (num != null) ? new int?((int)num.GetValueOrDefault()) : null;
			if (num2 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.dmethod_2046(arg_0.Value);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00041790 File Offset: 0x0003F990
		public virtual void cmethod_2064(char? arg_0)
		{
			char? c = arg_0;
			int? num = (c != null) ? new int?((int)c.GetValueOrDefault()) : null;
			if (num == null)
			{
				this.gmethod_2033();
				return;
			}
			this.kmethod_2047(arg_0.Value);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000417E8 File Offset: 0x0003F9E8
		public virtual void vmethod_2065(byte? arg_0)
		{
			byte? b = arg_0;
			int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			if (num == null)
			{
				this.gmethod_2033();
				return;
			}
			this.lmethod_2048(arg_0.Value);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00041840 File Offset: 0x0003FA40
		[CLSCompliant(false)]
		public virtual void dmethod_2066(sbyte? arg_0)
		{
			sbyte? b = arg_0;
			int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			if (num == null)
			{
				this.gmethod_2033();
				return;
			}
			this.pmethod_2049(arg_0.Value);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00041896 File Offset: 0x0003FA96
		public virtual void kmethod_2067(decimal? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.smethod_2050(arg_0.Value);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000418B8 File Offset: 0x0003FAB8
		public virtual void lmethod_2068(DateTime? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.xmethod_2051(arg_0.Value);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000418DA File Offset: 0x0003FADA
		public virtual void pmethod_2069(DateTimeOffset? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.tmethod_2052(arg_0.Value);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000418FC File Offset: 0x0003FAFC
		public virtual void smethod_2070(Guid? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.gmethod_2053(arg_0.Value);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004191E File Offset: 0x0003FB1E
		public virtual void xmethod_2071(TimeSpan? arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.cmethod_2054(arg_0.Value);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00041940 File Offset: 0x0003FB40
		public virtual void tmethod_2072(byte[] byteDizi_0)
		{
			if (byteDizi_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.dmethod_2086(Class_508.Bytes);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00041957 File Offset: 0x0003FB57
		public virtual void gmethod_2073(Uri arg_0)
		{
			if (arg_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			this.dmethod_2086(Class_508.String);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00041974 File Offset: 0x0003FB74
		public virtual void cmethod_2074(object obje_0)
		{
			if (obje_0 == null)
			{
				this.gmethod_2033();
				return;
			}
			if (obje_0 is BigInteger)
			{
				throw Class_296.smethod_2080(this, obje_0);
			}
			Class_296.pmethod_2079(this, Class_499.GetTypeCode(obje_0.GetType()), obje_0);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000419A8 File Offset: 0x0003FBA8
		public virtual void vmethod_2075(string str_0)
		{
			this.lmethod_2088();
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000419B0 File Offset: 0x0003FBB0
		public virtual void dmethod_2076(string str_0)
		{
			this.kmethod_2087(str_0);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000419B9 File Offset: 0x0003FBB9
		void IDisposable.kmethod_2077()
		{
			this.lmethod_2078(true);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000419C2 File Offset: 0x0003FBC2
		private void lmethod_2078(bool bool_0)
		{
			if (this.field_4 != Class_296.NClass_0.field_11)
			{
				this.dmethod_2006();
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000419D8 File Offset: 0x0003FBD8
		internal static void pmethod_2079(Class_296 arg_0, Class_496 arg_1, object obje_0)
		{
			switch (arg_1)
			{
			case Class_496.Char:
				arg_0.kmethod_2047((char)obje_0);
				return;
			case Class_496.CharNullable:
				arg_0.cmethod_2064((obje_0 == null) ? null : new char?((char)obje_0));
				return;
			case Class_496.Boolean:
				arg_0.cmethod_2044((bool)obje_0);
				return;
			case Class_496.BooleanNullable:
				arg_0.xmethod_2061((obje_0 == null) ? null : new bool?((bool)obje_0));
				return;
			case Class_496.SByte:
				arg_0.pmethod_2049((sbyte)obje_0);
				return;
			case Class_496.SByteNullable:
				arg_0.dmethod_2066((obje_0 == null) ? null : new sbyte?((sbyte)obje_0));
				return;
			case Class_496.Int16:
				arg_0.vmethod_2045((short)obje_0);
				return;
			case Class_496.Int16Nullable:
				arg_0.tmethod_2062((obje_0 == null) ? null : new short?((short)obje_0));
				return;
			case Class_496.UInt16:
				arg_0.dmethod_2046((ushort)obje_0);
				return;
			case Class_496.UInt16Nullable:
				arg_0.gmethod_2063((obje_0 == null) ? null : new ushort?((ushort)obje_0));
				return;
			case Class_496.Int32:
				arg_0.lmethod_2038((int)obje_0);
				return;
			case Class_496.Int32Nullable:
				arg_0.vmethod_2055((obje_0 == null) ? null : new int?((int)obje_0));
				return;
			case Class_496.Byte:
				arg_0.lmethod_2048((byte)obje_0);
				return;
			case Class_496.ByteNullable:
				arg_0.vmethod_2065((obje_0 == null) ? null : new byte?((byte)obje_0));
				return;
			case Class_496.UInt32:
				arg_0.pmethod_2039((uint)obje_0);
				return;
			case Class_496.UInt32Nullable:
				arg_0.dmethod_2056((obje_0 == null) ? null : new uint?((uint)obje_0));
				return;
			case Class_496.Int64:
				arg_0.smethod_2040((long)obje_0);
				return;
			case Class_496.Int64Nullable:
				arg_0.kmethod_2057((obje_0 == null) ? null : new long?((long)obje_0));
				return;
			case Class_496.UInt64:
				arg_0.xmethod_2041((ulong)obje_0);
				return;
			case Class_496.UInt64Nullable:
				arg_0.lmethod_2058((obje_0 == null) ? null : new ulong?((ulong)obje_0));
				return;
			case Class_496.Single:
				arg_0.tmethod_2042((float)obje_0);
				return;
			case Class_496.SingleNullable:
				arg_0.pmethod_2059((obje_0 == null) ? null : new float?((float)obje_0));
				return;
			case Class_496.Double:
				arg_0.gmethod_2043((double)obje_0);
				return;
			case Class_496.DoubleNullable:
				arg_0.smethod_2060((obje_0 == null) ? null : new double?((double)obje_0));
				return;
			case Class_496.DateTime:
				arg_0.xmethod_2051((DateTime)obje_0);
				return;
			case Class_496.DateTimeNullable:
				arg_0.lmethod_2068((obje_0 == null) ? null : new DateTime?((DateTime)obje_0));
				return;
			case Class_496.DateTimeOffset:
				arg_0.tmethod_2052((DateTimeOffset)obje_0);
				return;
			case Class_496.DateTimeOffsetNullable:
				arg_0.pmethod_2069((obje_0 == null) ? null : new DateTimeOffset?((DateTimeOffset)obje_0));
				return;
			case Class_496.Decimal:
				arg_0.smethod_2050((decimal)obje_0);
				return;
			case Class_496.DecimalNullable:
				arg_0.kmethod_2067((obje_0 == null) ? null : new decimal?((decimal)obje_0));
				return;
			case Class_496.Guid:
				arg_0.gmethod_2053((Guid)obje_0);
				return;
			case Class_496.GuidNullable:
				arg_0.smethod_2070((obje_0 == null) ? null : new Guid?((Guid)obje_0));
				return;
			case Class_496.TimeSpan:
				arg_0.cmethod_2054((TimeSpan)obje_0);
				return;
			case Class_496.TimeSpanNullable:
				arg_0.xmethod_2071((obje_0 == null) ? null : new TimeSpan?((TimeSpan)obje_0));
				return;
			case Class_496.BigInteger:
				arg_0.cmethod_2074((BigInteger)obje_0);
				return;
			case Class_496.BigIntegerNullable:
				arg_0.cmethod_2074((obje_0 == null) ? null : new BigInteger?((BigInteger)obje_0));
				return;
			case Class_496.Uri:
				arg_0.gmethod_2073((Uri)obje_0);
				return;
			case Class_496.String:
				arg_0.kmethod_2037((string)obje_0);
				return;
			case Class_496.Bytes:
				arg_0.tmethod_2072((byte[])obje_0);
				return;
			case Class_496.DBNull:
				arg_0.gmethod_2033();
				return;
			default:
				if (obje_0 is IConvertible)
				{
					IConvertible convertible = (IConvertible)obje_0;
					Class_497 typeInformation = Class_499.GetTypeInformation(convertible);
					Class_496 arg_2 = (typeInformation.prop_1 == Class_496.Object) ? Class_496.String : typeInformation.prop_1;
					Type conversionType = (typeInformation.prop_1 == Class_496.Object) ? typeof(string) : typeInformation.prop_0;
					object obje_ = convertible.ToType(conversionType, CultureInfo.InvariantCulture);
					Class_296.pmethod_2079(arg_0, arg_2, obje_);
					return;
				}
				throw Class_296.smethod_2080(arg_0, obje_0);
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00041EF1 File Offset: 0x000400F1
		private static Class_413 smethod_2080(Class_296 arg_0, object obje_0)
		{
			return Class_413.smethod_3090(arg_0, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(CultureInfo.InvariantCulture, obje_0.GetType()), null);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00041F10 File Offset: 0x00040110
		protected void xmethod_2081(Class_508 arg_0, object obje_0)
		{
			switch (arg_0)
			{
			case Class_508.StartObject:
				this.vmethod_2085(arg_0, Class_325.Object);
				return;
			case Class_508.StartArray:
				this.vmethod_2085(arg_0, Class_325.Array);
				return;
			case Class_508.StartConstructor:
				this.vmethod_2085(arg_0, Class_325.Constructor);
				return;
			case Class_508.PropertyName:
				if (!(obje_0 is string))
				{
					throw new ArgumentException("A name is required when setting property name state.", "value");
				}
				this.gmethod_2083((string)obje_0);
				return;
			case Class_508.Comment:
				this.lmethod_2088();
				return;
			case Class_508.Raw:
				this.cmethod_2084();
				return;
			case Class_508.Integer:
			case Class_508.Float:
			case Class_508.String:
			case Class_508.Boolean:
			case Class_508.Null:
			case Class_508.Undefined:
			case Class_508.Date:
			case Class_508.Bytes:
				this.dmethod_2086(arg_0);
				return;
			case Class_508.EndObject:
				this.tmethod_2082(Class_325.Object);
				return;
			case Class_508.EndArray:
				this.tmethod_2082(Class_325.Array);
				return;
			case Class_508.EndConstructor:
				this.tmethod_2082(Class_325.Constructor);
				return;
			default:
				throw new ArgumentOutOfRangeException("token");
			}
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00041FEB File Offset: 0x000401EB
		internal void tmethod_2082(Class_325 arg_0)
		{
			this.kmethod_2027(arg_0);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00041FF4 File Offset: 0x000401F4
		internal void gmethod_2083(string str_0)
		{
			this.field_3.PropertyName = str_0;
			this.tmethod_2032(Class_508.PropertyName);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		internal void cmethod_2084()
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00042009 File Offset: 0x00040209
		internal void vmethod_2085(Class_508 arg_0, Class_325 arg_1)
		{
			this.xmethod_2001();
			this.tmethod_2032(arg_0);
			this.tmethod_2002(arg_1);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0004201F File Offset: 0x0004021F
		internal void dmethod_2086(Class_508 arg_0)
		{
			this.xmethod_2001();
			this.tmethod_2032(arg_0);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004202E File Offset: 0x0004022E
		internal void kmethod_2087(string str_0)
		{
			if (str_0 != null && !Class_515.IsWhiteSpace(str_0))
			{
				throw Class_413.smethod_3090(this, "Only white space characters should be used.", null);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0004204E File Offset: 0x0004024E
		internal void lmethod_2088()
		{
			this.tmethod_2032(Class_508.Comment);
		}

		// Token: 0x04000782 RID: 1922
		private static readonly Class_296.NClass_0[][] field_0;

		// Token: 0x04000783 RID: 1923
		internal static readonly Class_296.NClass_0[][] field_1 = new Class_296.NClass_0[][]
		{
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_9,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_4,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_4,
				Class_296.NClass_0.field_4,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_3,
				Class_296.NClass_0.field_4,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_6,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_8,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_3,
				Class_296.NClass_0.field_4,
				Class_296.NClass_0.field_5,
				Class_296.NClass_0.field_6,
				Class_296.NClass_0.field_7,
				Class_296.NClass_0.field_8,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			},
			new Class_296.NClass_0[]
			{
				Class_296.NClass_0.field_3,
				Class_296.NClass_0.field_6,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_8,
				Class_296.NClass_0.field_8,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_10,
				Class_296.NClass_0.field_12,
				Class_296.NClass_0.field_12
			}
		};

		// Token: 0x04000784 RID: 1924
		private readonly List<Class_326> field_2;

		// Token: 0x04000785 RID: 1925
		private Class_326 field_3;

		// Token: 0x04000786 RID: 1926
		private Class_296.NClass_0 field_4;

		// Token: 0x04000787 RID: 1927
		private Class_322 field_5;

		// Token: 0x04000788 RID: 1928
		private Class_319 field_6;

		// Token: 0x04000789 RID: 1929
		private Class_321 field_7;

		// Token: 0x0400078A RID: 1930
		private Class_356 field_8;

		// Token: 0x0400078B RID: 1931
		private Class_314 field_9;

		// Token: 0x0400078C RID: 1932
		private string field_10;

		// Token: 0x0400078D RID: 1933
		private CultureInfo field_11;

		// Token: 0x0400078E RID: 1934
		[CompilerGenerated]
		private bool field_12;

		// Token: 0x02000197 RID: 407
		internal enum NClass_0
		{
			// Token: 0x04000790 RID: 1936
			field_3,
			// Token: 0x04000791 RID: 1937
			field_4,
			// Token: 0x04000792 RID: 1938
			field_5,
			// Token: 0x04000793 RID: 1939
			field_6,
			// Token: 0x04000794 RID: 1940
			field_7,
			// Token: 0x04000795 RID: 1941
			field_8,
			// Token: 0x04000796 RID: 1942
			field_9,
			// Token: 0x04000797 RID: 1943
			field_10,
			// Token: 0x04000798 RID: 1944
			field_11,
			// Token: 0x04000799 RID: 1945
			field_12
		}
	}
}
