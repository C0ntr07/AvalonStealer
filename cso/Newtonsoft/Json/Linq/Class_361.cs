using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001E1 RID: 481
	[DefaultMember("Item")]
	public abstract class Class_361 : IEnumerable, IEnumerable<Class_361>, IDynamicMetaObjectProvider, Class_360<Class_361>, ICloneable, Class_353
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00049119 File Offset: 0x00047319
		public static Class_382 prop_0
		{
			get
			{
				if (Class_361.field_0 == null)
				{
					Class_361.field_0 = new Class_382();
				}
				return Class_361.field_0;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00049134 File Offset: 0x00047334
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0004913C File Offset: 0x0004733C
		public Class_420 prop_1
		{
			[DebuggerStepThrough]
			get
			{
				return this.field_1;
			}
			internal set
			{
				this.field_1 = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00049148 File Offset: 0x00047348
		public Class_361 prop_2
		{
			get
			{
				Class_420 class_ = this.prop_1;
				if (class_ == null)
				{
					return this;
				}
				while (class_.prop_1 != null)
				{
					class_ = class_.prop_1;
				}
				return class_;
			}
		}

		// Token: 0x06000DA4 RID: 3492
		internal abstract Class_361 kmethod_2447();

		// Token: 0x06000DA5 RID: 3493
		internal abstract bool lmethod_2448(Class_361 arg_0);

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000DA6 RID: 3494
		public abstract Class_428 prop_3 { get; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000DA7 RID: 3495
		public abstract bool prop_4 { get; }

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00049174 File Offset: 0x00047374
		public static bool xmethod_2451(Class_361 arg_0, Class_361 arg_1)
		{
			return arg_0 == arg_1 || (arg_0 != null && arg_1 != null && arg_0.lmethod_2448(arg_1));
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00049194 File Offset: 0x00047394
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0004919C File Offset: 0x0004739C
		public Class_361 prop_5
		{
			get
			{
				return this.field_3;
			}
			internal set
			{
				this.field_3 = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x000491A5 File Offset: 0x000473A5
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x000491AD File Offset: 0x000473AD
		public Class_361 prop_6
		{
			get
			{
				return this.field_2;
			}
			internal set
			{
				this.field_2 = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000491B8 File Offset: 0x000473B8
		public string prop_7
		{
			get
			{
				if (this.prop_1 == null)
				{
					return string.Empty;
				}
				IList<Class_361> list = this.smethod_2460().Reverse<Class_361>().ToList<Class_361>();
				IList<Class_326> list2 = new List<Class_326>();
				for (int i = 0; i < list.Count; i++)
				{
					Class_361 class_ = list[i];
					Class_361 class_2 = null;
					if (i + 1 < list.Count)
					{
						class_2 = list[i + 1];
					}
					else if (list[i].prop_3 == Class_428.Property)
					{
						class_2 = list[i];
					}
					if (class_2 != null)
					{
						switch (class_.prop_3)
						{
						case Class_428.Array:
						case Class_428.Constructor:
						{
							int position = ((IList<Class_361>)class_).IndexOf(class_2);
							list2.Add(new Class_326(Class_325.Array)
							{
								Position = position
							});
							break;
						}
						case Class_428.Property:
						{
							Class_427 class_3 = (Class_427)class_;
							list2.Add(new Class_326(Class_325.Object)
							{
								PropertyName = class_3.prop_1
							});
							break;
						}
						}
					}
				}
				return Class_326.BuildPath(list2);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0000237C File Offset: 0x0000057C
		internal Class_361()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000492CC File Offset: 0x000474CC
		public void kmethod_2457(object obje_0)
		{
			if (this.field_1 == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int num = this.field_1.dmethod_3206(this);
			this.field_1.xmethod_3221(num + 1, obje_0, false);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0004930C File Offset: 0x0004750C
		public void lmethod_2458(object obje_0)
		{
			if (this.field_1 == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			int sayıInt_ = this.field_1.dmethod_3206(this);
			this.field_1.xmethod_3221(sayıInt_, obje_0, false);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0004934A File Offset: 0x0004754A
		public IEnumerable<Class_361> pmethod_2459()
		{
			return this.xmethod_2461(false);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00049353 File Offset: 0x00047553
		public IEnumerable<Class_361> smethod_2460()
		{
			return this.xmethod_2461(true);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0004935C File Offset: 0x0004755C
		internal IEnumerable<Class_361> xmethod_2461(bool bool_0)
		{
			for (Class_361 class_ = bool_0 ? this : this.prop_1; class_ != null; class_ = class_.prop_1)
			{
				yield return class_;
			}
			yield break;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00049380 File Offset: 0x00047580
		public IEnumerable<Class_361> tmethod_2462()
		{
			if (this.prop_1 != null)
			{
				for (Class_361 class_ = this.prop_5; class_ != null; class_ = class_.prop_5)
				{
					yield return class_;
				}
			}
			yield break;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000493A0 File Offset: 0x000475A0
		public IEnumerable<Class_361> gmethod_2463()
		{
			for (Class_361 class_ = this.prop_1.prop_9; class_ != this; class_ = class_.prop_5)
			{
				yield return class_;
			}
			yield break;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000493BD File Offset: 0x000475BD
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000493D9 File Offset: 0x000475D9
		public virtual Class_361 prop_8
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
			set
			{
				throw new InvalidOperationException("Cannot set child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000493F8 File Offset: 0x000475F8
		public virtual T dmethod_2466<T>(object obje_0)
		{
			Class_361 class_ = this.cmethod_2464(obje_0);
			if (class_ != null)
			{
				return class_.Convert<Class_361, T>();
			}
			return default(T);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x000493BD File Offset: 0x000475BD
		public virtual Class_361 prop_9
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000493BD File Offset: 0x000475BD
		public virtual Class_361 prop_10
		{
			get
			{
				throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00049423 File Offset: 0x00047623
		public virtual Class_422<Class_361> pmethod_2469()
		{
			return Class_422<Class_361>.Empty;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0004942A File Offset: 0x0004762A
		public Class_422<T> smethod_2470<T>() where T : Class_361
		{
			return new Class_422<T>(this.pmethod_2469().OfType<T>());
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000493BD File Offset: 0x000475BD
		public virtual IEnumerable<T> xmethod_2471<T>()
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".FormatWith(CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00049441 File Offset: 0x00047641
		public void tmethod_2472()
		{
			if (this.field_1 == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this.field_1.pmethod_3209(this);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00049466 File Offset: 0x00047666
		public void gmethod_2473(Class_361 arg_0)
		{
			if (this.field_1 == null)
			{
				throw new InvalidOperationException("The parent is missing.");
			}
			this.field_1.gmethod_3213(this, arg_0);
		}

		// Token: 0x06000DC0 RID: 3520
		public abstract void cmethod_2474(Class_296 arg_0, params Class_299[] arg_1);

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0004948B File Offset: 0x0004768B
		public virtual string vmethod_2475()
		{
			return this.dmethod_2476(Class_322.Indented, new Class_299[0]);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0004949C File Offset: 0x0004769C
		public string dmethod_2476(Class_322 arg_0, params Class_299[] arg_1)
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				this.cmethod_2474(new Class_412(stringWriter)
				{
					prop_5 = arg_0
				}, arg_1);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000494F4 File Offset: 0x000476F4
		private static Class_362 kmethod_2477(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			if (arg_0 is Class_427)
			{
				arg_0 = ((Class_427)arg_0).prop_2;
			}
			return arg_0 as Class_362;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00049532 File Offset: 0x00047732
		private static string lmethod_2478(Class_361 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "token");
			if (arg_0 is Class_427)
			{
				arg_0 = ((Class_427)arg_0).prop_2;
			}
			return arg_0.prop_3.ToString();
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00049567 File Offset: 0x00047767
		private static bool pmethod_2479(Class_361 arg_0, Class_428[] arg_1, bool bool_0)
		{
			return Array.IndexOf<Class_428>(arg_1, arg_0.prop_3) != -1 || (bool_0 && (arg_0.prop_3 == Class_428.Null || arg_0.prop_3 == Class_428.Undefined));
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x000495A0 File Offset: 0x000477A0
		public static bool smethod_2480(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_5, false))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return Convert.ToBoolean((int)((BigInteger)class_.prop_2));
			}
			return Convert.ToBoolean(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0004961C File Offset: 0x0004781C
		public static DateTimeOffset xmethod_2481(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_13, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is DateTimeOffset)
			{
				return (DateTimeOffset)class_.prop_2;
			}
			if (class_.prop_2 is string)
			{
				return DateTimeOffset.Parse((string)class_.prop_2, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x000496BC File Offset: 0x000478BC
		public static bool? tmethod_2482(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_5, true))
			{
				throw new ArgumentException("Can not convert {0} to Boolean.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new bool?(Convert.ToBoolean((int)((BigInteger)class_.prop_2)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new bool?(Convert.ToBoolean(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00049768 File Offset: 0x00047968
		public static long gmethod_2483(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (long)((BigInteger)class_.prop_2);
			}
			return Convert.ToInt64(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000497E0 File Offset: 0x000479E0
		public static DateTime? cmethod_2484(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_13, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is DateTimeOffset)
			{
				return new DateTime?(((DateTimeOffset)class_.prop_2).DateTime);
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new DateTime?(Convert.ToDateTime(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0004988C File Offset: 0x00047A8C
		public static DateTimeOffset? vmethod_2485(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_13, true))
			{
				throw new ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			if (class_.prop_2 is DateTimeOffset)
			{
				return (DateTimeOffset?)class_.prop_2;
			}
			if (class_.prop_2 is string)
			{
				return new DateTimeOffset?(DateTimeOffset.Parse((string)class_.prop_2, CultureInfo.InvariantCulture));
			}
			return new DateTimeOffset?(new DateTimeOffset(Convert.ToDateTime(class_.prop_2, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00049958 File Offset: 0x00047B58
		public static decimal? dmethod_2486(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new decimal?((decimal)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new decimal?(Convert.ToDecimal(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00049A00 File Offset: 0x00047C00
		public static double? kmethod_2487(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new double?((double)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new double?(Convert.ToDouble(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00049AA8 File Offset: 0x00047CA8
		public static char? lmethod_2488(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_12, true))
			{
				throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new char?((char)((ushort)((BigInteger)class_.prop_2)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new char?(Convert.ToChar(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00049B50 File Offset: 0x00047D50
		public static int pmethod_2489(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (int)((BigInteger)class_.prop_2);
			}
			return Convert.ToInt32(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00049BC8 File Offset: 0x00047DC8
		public static short smethod_2490(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (short)((BigInteger)class_.prop_2);
			}
			return Convert.ToInt16(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00049C40 File Offset: 0x00047E40
		[CLSCompliant(false)]
		public static ushort xmethod_2491(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (ushort)((BigInteger)class_.prop_2);
			}
			return Convert.ToUInt16(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00049CB8 File Offset: 0x00047EB8
		[CLSCompliant(false)]
		public static char tmethod_2492(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_12, false))
			{
				throw new ArgumentException("Can not convert {0} to Char.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (char)((ushort)((BigInteger)class_.prop_2));
			}
			return Convert.ToChar(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00049D30 File Offset: 0x00047F30
		public static byte gmethod_2493(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (byte)((BigInteger)class_.prop_2);
			}
			return Convert.ToByte(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00049DA8 File Offset: 0x00047FA8
		[CLSCompliant(false)]
		public static sbyte cmethod_2494(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (sbyte)((BigInteger)class_.prop_2);
			}
			return Convert.ToSByte(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00049E20 File Offset: 0x00048020
		public static int? vmethod_2495(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Int32.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new int?((int)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new int?(Convert.ToInt32(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00049EC8 File Offset: 0x000480C8
		public static short? dmethod_2496(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Int16.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new short?((short)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new short?(Convert.ToInt16(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00049F70 File Offset: 0x00048170
		[CLSCompliant(false)]
		public static ushort? kmethod_2497(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt16.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new ushort?((ushort)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new ushort?(Convert.ToUInt16(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004A018 File Offset: 0x00048218
		public static byte? lmethod_2498(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Byte.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new byte?((byte)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new byte?(Convert.ToByte(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0004A0C0 File Offset: 0x000482C0
		[CLSCompliant(false)]
		public static sbyte? pmethod_2499(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to SByte.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new sbyte?((sbyte)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new sbyte?(Convert.ToSByte(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004A168 File Offset: 0x00048368
		public static DateTime smethod_2500(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_13, false))
			{
				throw new ArgumentException("Can not convert {0} to DateTime.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is DateTimeOffset)
			{
				return ((DateTimeOffset)class_.prop_2).DateTime;
			}
			return Convert.ToDateTime(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0004A1E4 File Offset: 0x000483E4
		public static long? xmethod_2501(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Int64.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new long?((long)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new long?(Convert.ToInt64(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0004A28C File Offset: 0x0004848C
		public static float? tmethod_2502(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new float?((float)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new float?(Convert.ToSingle(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0004A334 File Offset: 0x00048534
		public static decimal gmethod_2503(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Decimal.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (decimal)((BigInteger)class_.prop_2);
			}
			return Convert.ToDecimal(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0004A3AC File Offset: 0x000485AC
		[CLSCompliant(false)]
		public static uint? cmethod_2504(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new uint?((uint)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new uint?(Convert.ToUInt32(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0004A454 File Offset: 0x00048654
		[CLSCompliant(false)]
		public static ulong? vmethod_2505(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, true))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return new ulong?((ulong)((BigInteger)class_.prop_2));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new ulong?(Convert.ToUInt64(class_.prop_2, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0004A4FC File Offset: 0x000486FC
		public static double dmethod_2506(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Double.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (double)((BigInteger)class_.prop_2);
			}
			return Convert.ToDouble(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004A574 File Offset: 0x00048774
		public static float kmethod_2507(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to Single.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (float)((BigInteger)class_.prop_2);
			}
			return Convert.ToSingle(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004A5EC File Offset: 0x000487EC
		public static string lmethod_2508(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_8, true))
			{
				throw new ArgumentException("Can not convert {0} to String.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			if (class_.prop_2 is byte[])
			{
				return Convert.ToBase64String((byte[])class_.prop_2);
			}
			if (class_.prop_2 is BigInteger)
			{
				return ((BigInteger)class_.prop_2).ToString(CultureInfo.InvariantCulture);
			}
			return Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0004A6A4 File Offset: 0x000488A4
		[CLSCompliant(false)]
		public static uint pmethod_2509(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt32.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (uint)((BigInteger)class_.prop_2);
			}
			return Convert.ToUInt32(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004A71C File Offset: 0x0004891C
		[CLSCompliant(false)]
		public static ulong smethod_2510(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_6, false))
			{
				throw new ArgumentException("Can not convert {0} to UInt64.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is BigInteger)
			{
				return (ulong)((BigInteger)class_.prop_2);
			}
			return Convert.ToUInt64(class_.prop_2, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0004A794 File Offset: 0x00048994
		public static byte[] xmethod_2511(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_14, false))
			{
				throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is string)
			{
				return Convert.FromBase64String(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture));
			}
			if (class_.prop_2 is BigInteger)
			{
				return ((BigInteger)class_.prop_2).ToByteArray();
			}
			if (class_.prop_2 is byte[])
			{
				return (byte[])class_.prop_2;
			}
			throw new ArgumentException("Can not convert {0} to byte array.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0004A864 File Offset: 0x00048A64
		public static Guid tmethod_2512(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_9, false))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 is byte[])
			{
				return new Guid((byte[])class_.prop_2);
			}
			if (!(class_.prop_2 is Guid))
			{
				return new Guid(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture));
			}
			return (Guid)class_.prop_2;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0004A8FC File Offset: 0x00048AFC
		public static Guid? gmethod_2513(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_9, true))
			{
				throw new ArgumentException("Can not convert {0} to Guid.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			if (class_.prop_2 is byte[])
			{
				return new Guid?(new Guid((byte[])class_.prop_2));
			}
			return new Guid?((class_.prop_2 is Guid) ? ((Guid)class_.prop_2) : new Guid(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0004A9C8 File Offset: 0x00048BC8
		public static TimeSpan cmethod_2514(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_10, false))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (!(class_.prop_2 is TimeSpan))
			{
				return Class_499.ParseTimeSpan(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture));
			}
			return (TimeSpan)class_.prop_2;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0004AA40 File Offset: 0x00048C40
		public static TimeSpan? vmethod_2515(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_10, true))
			{
				throw new ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new TimeSpan?((class_.prop_2 is TimeSpan) ? ((TimeSpan)class_.prop_2) : Class_499.ParseTimeSpan(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0004AAE8 File Offset: 0x00048CE8
		public static Uri dmethod_2516(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return null;
			}
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_11, true))
			{
				throw new ArgumentException("Can not convert {0} to Uri.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			if (!(class_.prop_2 is Uri))
			{
				return new Uri(Convert.ToString(class_.prop_2, CultureInfo.InvariantCulture));
			}
			return (Uri)class_.prop_2;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0004AB74 File Offset: 0x00048D74
		private static BigInteger kmethod_2517(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_7, false))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			return Class_499.ToBigInteger(class_.prop_2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		private static BigInteger? lmethod_2518(Class_361 arg_0)
		{
			Class_362 class_ = Class_361.kmethod_2477(arg_0);
			if (class_ == null || !Class_361.pmethod_2479(class_, Class_361.field_7, true))
			{
				throw new ArgumentException("Can not convert {0} to BigInteger.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2478(arg_0)));
			}
			if (class_.prop_2 == null)
			{
				return null;
			}
			return new BigInteger?(Class_499.ToBigInteger(class_.prop_2));
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0004AC33 File Offset: 0x00048E33
		public static Class_361 pmethod_2519(bool bool_0)
		{
			return new Class_362(bool_0);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0004AC3B File Offset: 0x00048E3B
		public static Class_361 smethod_2520(DateTimeOffset arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0004AC43 File Offset: 0x00048E43
		public static Class_361 xmethod_2521(byte byte_0)
		{
			return new Class_362((long)((ulong)byte_0));
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0004AC4C File Offset: 0x00048E4C
		public static Class_361 tmethod_2522(byte? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0004AC59 File Offset: 0x00048E59
		[CLSCompliant(false)]
		public static Class_361 gmethod_2523(sbyte arg_0)
		{
			return new Class_362((long)arg_0);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0004AC62 File Offset: 0x00048E62
		[CLSCompliant(false)]
		public static Class_361 cmethod_2524(sbyte? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0004AC6F File Offset: 0x00048E6F
		public static Class_361 vmethod_2525(bool? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0004AC7C File Offset: 0x00048E7C
		public static Class_361 dmethod_2526(long sayıUınt_0)
		{
			return new Class_362(sayıUınt_0);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0004AC84 File Offset: 0x00048E84
		public static Class_361 kmethod_2527(DateTime? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0004AC91 File Offset: 0x00048E91
		public static Class_361 lmethod_2528(DateTimeOffset? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0004AC9E File Offset: 0x00048E9E
		public static Class_361 pmethod_2529(decimal? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0004ACAB File Offset: 0x00048EAB
		public static Class_361 smethod_2530(double? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0004AC59 File Offset: 0x00048E59
		[CLSCompliant(false)]
		public static Class_361 xmethod_2531(short sayıShort_0)
		{
			return new Class_362((long)sayıShort_0);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0004AC43 File Offset: 0x00048E43
		[CLSCompliant(false)]
		public static Class_361 tmethod_2532(ushort arg_0)
		{
			return new Class_362((long)((ulong)arg_0));
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0004AC59 File Offset: 0x00048E59
		public static Class_361 gmethod_2533(int sayıInt_0)
		{
			return new Class_362((long)sayıInt_0);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0004ACB8 File Offset: 0x00048EB8
		public static Class_361 cmethod_2534(int? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0004ACC5 File Offset: 0x00048EC5
		public static Class_361 vmethod_2535(DateTime arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0004ACCD File Offset: 0x00048ECD
		public static Class_361 dmethod_2536(long? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x0004ACDA File Offset: 0x00048EDA
		public static Class_361 kmethod_2537(float? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0004ACE7 File Offset: 0x00048EE7
		public static Class_361 lmethod_2538(decimal arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0004ACEF File Offset: 0x00048EEF
		[CLSCompliant(false)]
		public static Class_361 pmethod_2539(short? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0004ACFC File Offset: 0x00048EFC
		[CLSCompliant(false)]
		public static Class_361 smethod_2540(ushort? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0004AD09 File Offset: 0x00048F09
		[CLSCompliant(false)]
		public static Class_361 xmethod_2541(uint? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0004AD16 File Offset: 0x00048F16
		[CLSCompliant(false)]
		public static Class_361 tmethod_2542(ulong? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0004AD23 File Offset: 0x00048F23
		public static Class_361 gmethod_2543(double double_0)
		{
			return new Class_362(double_0);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0004AD2B File Offset: 0x00048F2B
		public static Class_361 cmethod_2544(float arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0004AD33 File Offset: 0x00048F33
		public static Class_361 vmethod_2545(string str_0)
		{
			return new Class_362(str_0);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0004AC43 File Offset: 0x00048E43
		[CLSCompliant(false)]
		public static Class_361 dmethod_2546(uint arg_0)
		{
			return new Class_362((long)((ulong)arg_0));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0004AD3B File Offset: 0x00048F3B
		[CLSCompliant(false)]
		public static Class_361 kmethod_2547(ulong arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0004AD43 File Offset: 0x00048F43
		public static Class_361 lmethod_2548(byte[] byteDizi_0)
		{
			return new Class_362(byteDizi_0);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0004AD4B File Offset: 0x00048F4B
		public static Class_361 pmethod_2549(Uri arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0004AD53 File Offset: 0x00048F53
		public static Class_361 smethod_2550(TimeSpan arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0004AD5B File Offset: 0x00048F5B
		public static Class_361 xmethod_2551(TimeSpan? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0004AD68 File Offset: 0x00048F68
		public static Class_361 tmethod_2552(Guid arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0004AD70 File Offset: 0x00048F70
		public static Class_361 gmethod_2553(Guid? arg_0)
		{
			return new Class_362(arg_0);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0004AD7D File Offset: 0x00048F7D
		IEnumerator IEnumerable.cmethod_2554()
		{
			return ((IEnumerable<Class_361>)this).GetEnumerator();
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0004AD88 File Offset: 0x00048F88
		IEnumerator<Class_361> IEnumerable<Class_361>.vmethod_2555()
		{
			return this.pmethod_2469().GetEnumerator();
		}

		// Token: 0x06000E12 RID: 3602
		internal abstract int dmethod_2556();

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0004ADA3 File Offset: 0x00048FA3
		Class_360<Class_361> Class_360<Class_361>.prop_11
		{
			get
			{
				return this.cmethod_2464(obje_0);
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0004ADAC File Offset: 0x00048FAC
		public Class_285 lmethod_2558()
		{
			return new Class_425(this, this.prop_7);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0004ADBC File Offset: 0x00048FBC
		internal static Class_361 pmethod_2559(object obje_0, Class_418 arg_0)
		{
			Class_517.ArgumentNotNull(obje_0, "o");
			Class_517.ArgumentNotNull(arg_0, "jsonSerializer");
			Class_361 result;
			using (Class_426 class_ = new Class_426())
			{
				arg_0.kmethod_3177(class_, obje_0);
				result = class_.prop_1;
			}
			return result;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0004AE18 File Offset: 0x00049018
		public static Class_361 smethod_2560(object obje_0)
		{
			return Class_361.pmethod_2559(obje_0, Class_418.xmethod_3161());
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0004AE25 File Offset: 0x00049025
		public static Class_361 xmethod_2561(object obje_0, Class_418 arg_0)
		{
			return Class_361.pmethod_2559(obje_0, arg_0);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0004AE2E File Offset: 0x0004902E
		public T tmethod_2562<T>()
		{
			return (T)((object)this.gmethod_2563(typeof(T)));
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0004AE48 File Offset: 0x00049048
		public object gmethod_2563(Type arg_0)
		{
			if (Class_416.DefaultSettings == null)
			{
				bool flag;
				Class_496 typeCode = Class_499.GetTypeCode(arg_0, out flag);
				if (flag && this.prop_3 == Class_428.String)
				{
					Type type = arg_0.IsEnum ? arg_0 : Nullable.GetUnderlyingType(arg_0);
					try
					{
						return Enum.Parse(type, Class_361.lmethod_2508(this), true);
					}
					catch (Exception innerException)
					{
						throw new ArgumentException("Could not convert '{0}' to {1}.".FormatWith(CultureInfo.InvariantCulture, Class_361.lmethod_2508(this), type.Name), innerException);
					}
				}
				switch (typeCode)
				{
				case Class_496.Char:
					return Class_361.tmethod_2492(this);
				case Class_496.CharNullable:
					return Class_361.lmethod_2488(this);
				case Class_496.Boolean:
					return Class_361.smethod_2480(this);
				case Class_496.BooleanNullable:
					return Class_361.tmethod_2482(this);
				case Class_496.SByte:
					return Class_361.pmethod_2499(this);
				case Class_496.SByteNullable:
					return Class_361.cmethod_2494(this);
				case Class_496.Int16:
					return Class_361.smethod_2490(this);
				case Class_496.Int16Nullable:
					return Class_361.dmethod_2496(this);
				case Class_496.UInt16:
					return Class_361.xmethod_2491(this);
				case Class_496.UInt16Nullable:
					return Class_361.kmethod_2497(this);
				case Class_496.Int32:
					return Class_361.pmethod_2489(this);
				case Class_496.Int32Nullable:
					return Class_361.vmethod_2495(this);
				case Class_496.Byte:
					return Class_361.gmethod_2493(this);
				case Class_496.ByteNullable:
					return Class_361.lmethod_2498(this);
				case Class_496.UInt32:
					return Class_361.pmethod_2509(this);
				case Class_496.UInt32Nullable:
					return Class_361.cmethod_2504(this);
				case Class_496.Int64:
					return Class_361.gmethod_2483(this);
				case Class_496.Int64Nullable:
					return Class_361.xmethod_2501(this);
				case Class_496.UInt64:
					return Class_361.smethod_2510(this);
				case Class_496.UInt64Nullable:
					return Class_361.vmethod_2505(this);
				case Class_496.Single:
					return Class_361.kmethod_2507(this);
				case Class_496.SingleNullable:
					return Class_361.tmethod_2502(this);
				case Class_496.Double:
					return Class_361.dmethod_2506(this);
				case Class_496.DoubleNullable:
					return Class_361.kmethod_2487(this);
				case Class_496.DateTime:
					return Class_361.smethod_2500(this);
				case Class_496.DateTimeNullable:
					return Class_361.cmethod_2484(this);
				case Class_496.DateTimeOffset:
					return Class_361.xmethod_2481(this);
				case Class_496.DateTimeOffsetNullable:
					return Class_361.vmethod_2485(this);
				case Class_496.Decimal:
					return Class_361.gmethod_2503(this);
				case Class_496.DecimalNullable:
					return Class_361.dmethod_2486(this);
				case Class_496.Guid:
					return Class_361.tmethod_2512(this);
				case Class_496.GuidNullable:
					return Class_361.gmethod_2513(this);
				case Class_496.TimeSpan:
					return Class_361.cmethod_2514(this);
				case Class_496.TimeSpanNullable:
					return Class_361.vmethod_2515(this);
				case Class_496.BigInteger:
					return Class_361.kmethod_2517(this);
				case Class_496.BigIntegerNullable:
					return Class_361.lmethod_2518(this);
				case Class_496.Uri:
					return Class_361.dmethod_2516(this);
				case Class_496.String:
					return Class_361.lmethod_2508(this);
				}
			}
			return this.vmethod_2565(arg_0, Class_418.xmethod_3161());
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0004B154 File Offset: 0x00049354
		public T cmethod_2564<T>(Class_418 arg_0)
		{
			return (T)((object)this.vmethod_2565(typeof(T), arg_0));
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0004B16C File Offset: 0x0004936C
		public object vmethod_2565(Type arg_0, Class_418 arg_1)
		{
			Class_517.ArgumentNotNull(arg_1, "jsonSerializer");
			object result;
			using (Class_425 class_ = new Class_425(this))
			{
				result = arg_1.smethod_3170(class_, arg_0);
			}
			return result;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0004B1B8 File Offset: 0x000493B8
		public static Class_361 dmethod_2566(Class_285 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			if (arg_0.prop_9 == Class_508.None && !arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JToken from JsonReader.");
			}
			Class_353 arg_ = arg_0 as Class_353;
			switch (arg_0.prop_9)
			{
			case Class_508.StartObject:
				return Class_423.pmethod_3309(arg_0);
			case Class_508.StartArray:
				return Class_424.xmethod_3351(arg_0);
			case Class_508.StartConstructor:
				return Class_421.lmethod_3288(arg_0);
			case Class_508.PropertyName:
				return Class_427.kmethod_3447(arg_0);
			case Class_508.Comment:
			{
				Class_362 class_ = Class_362.vmethod_2595(arg_0.prop_10.ToString());
				class_.lmethod_2568(arg_);
				return class_;
			}
			case Class_508.Integer:
			case Class_508.Float:
			case Class_508.String:
			case Class_508.Boolean:
			case Class_508.Date:
			case Class_508.Bytes:
			{
				Class_362 class_ = new Class_362(arg_0.prop_10);
				class_.lmethod_2568(arg_);
				return class_;
			}
			case Class_508.Null:
			{
				Class_362 class_ = Class_362.kmethod_2597();
				class_.lmethod_2568(arg_);
				return class_;
			}
			case Class_508.Undefined:
			{
				Class_362 class_ = Class_362.lmethod_2598();
				class_.lmethod_2568(arg_);
				return class_;
			}
			}
			throw Class_414.lmethod_3098(arg_0, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0004B2DC File Offset: 0x000494DC
		public static Class_361 kmethod_2567(string str_0)
		{
			Class_361 result;
			using (Class_285 class_ = new Class_409(new StringReader(str_0)))
			{
				Class_361 class_2 = Class_361.dmethod_2566(class_);
				if (class_.vmethod_1885() && class_.prop_9 != Class_508.Comment)
				{
					throw Class_414.lmethod_3098(class_, "Additional text found in JSON string after parsing content.");
				}
				result = class_2;
			}
			return result;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0004B344 File Offset: 0x00049544
		internal void lmethod_2568(Class_353 arg_0)
		{
			if (arg_0 == null || !arg_0.lmethod_2368())
			{
				return;
			}
			this.pmethod_2569(arg_0.prop_0, arg_0.prop_1);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0004B36A File Offset: 0x0004956A
		internal void pmethod_2569(int sayıInt_0, int sayıInt_1)
		{
			this.xmethod_2581(new Class_361.NClass_0(sayıInt_0, sayıInt_1));
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0004B379 File Offset: 0x00049579
		bool Class_353.smethod_2570()
		{
			return this.tmethod_2582<Class_361.NClass_0>() != null;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0004B388 File Offset: 0x00049588
		int Class_353.prop_12
		{
			get
			{
				Class_361.NClass_0 nclass_ = this.tmethod_2582<Class_361.NClass_0>();
				if (nclass_ != null)
				{
					return nclass_.field_0;
				}
				return 0;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0004B3AC File Offset: 0x000495AC
		int Class_353.prop_13
		{
			get
			{
				Class_361.NClass_0 nclass_ = this.tmethod_2582<Class_361.NClass_0>();
				if (nclass_ != null)
				{
					return nclass_.field_1;
				}
				return 0;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0004B3CE File Offset: 0x000495CE
		public Class_361 gmethod_2573(string str_0)
		{
			return this.cmethod_2574(str_0, false);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0004B3D8 File Offset: 0x000495D8
		public Class_361 cmethod_2574(string str_0, bool bool_0)
		{
			Class_335 class_ = new Class_335(str_0);
			Class_361 class_2 = null;
			foreach (Class_361 class_3 in class_.gmethod_2283(this, bool_0))
			{
				if (class_2 != null)
				{
					throw new Class_318("Path returned multiple tokens.");
				}
				class_2 = class_3;
			}
			return class_2;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0004B448 File Offset: 0x00049648
		public IEnumerable<Class_361> vmethod_2575(string str_0)
		{
			return this.dmethod_2576(str_0, false);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0004B454 File Offset: 0x00049654
		public IEnumerable<Class_361> dmethod_2576(string str_0, bool bool_0)
		{
			Class_335 class_ = new Class_335(str_0);
			return class_.gmethod_2283(this, bool_0);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0004B470 File Offset: 0x00049670
		protected virtual DynamicMetaObject kmethod_2577(Expression arg_0)
		{
			return new Class_475<Class_361>(arg_0, this, new Class_359<Class_361>(), true);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0004B47F File Offset: 0x0004967F
		DynamicMetaObject IDynamicMetaObjectProvider.lmethod_2578(Expression arg_0)
		{
			return this.kmethod_2577(arg_0);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0004B488 File Offset: 0x00049688
		object ICloneable.pmethod_2579()
		{
			return this.smethod_2580();
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0004B490 File Offset: 0x00049690
		public Class_361 smethod_2580()
		{
			return this.kmethod_2447();
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0004B498 File Offset: 0x00049698
		public void xmethod_2581(object obje_0)
		{
			if (obje_0 == null)
			{
				throw new ArgumentNullException("annotation");
			}
			if (this.field_4 == null)
			{
				this.field_4 = ((obje_0 is object[]) ? new object[]
				{
					obje_0
				} : obje_0);
				return;
			}
			object[] array = this.field_4 as object[];
			if (array == null)
			{
				this.field_4 = new object[]
				{
					this.field_4,
					obje_0
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				Array.Resize<object>(ref array, num * 2);
				this.field_4 = array;
			}
			array[num] = obje_0;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0004B54C File Offset: 0x0004974C
		public T tmethod_2582<T>() where T : class
		{
			if (this.field_4 != null)
			{
				object[] array = this.field_4 as object[];
				if (array == null)
				{
					return this.field_4 as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0004B5C8 File Offset: 0x000497C8
		public object gmethod_2583(Type arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.field_4 != null)
			{
				object[] array = this.field_4 as object[];
				if (array == null)
				{
					if (arg_0.IsInstanceOfType(this.field_4))
					{
						return this.field_4;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (arg_0.IsInstanceOfType(obj))
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0004B64C File Offset: 0x0004984C
		public IEnumerable<T> cmethod_2584<T>() where T : class
		{
			Class_361<T>.NClass_4 nclass_ = new Class_361<T>.NClass_4(-2);
			nclass_.<>4__this = this;
			return nclass_;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0004B66C File Offset: 0x0004986C
		public IEnumerable<object> vmethod_2585(Type arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.field_4 != null)
			{
				object[] array = this.field_4 as object[];
				if (array != null)
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (arg_0.IsInstanceOfType(obj))
						{
							yield return obj;
						}
					}
				}
				else if (arg_0.IsInstanceOfType(this.field_4))
				{
					yield return this.field_4;
				}
			}
			yield break;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0004B690 File Offset: 0x00049890
		public void dmethod_2586<T>() where T : class
		{
			if (this.field_4 != null)
			{
				object[] array = this.field_4 as object[];
				if (array == null)
				{
					if (this.field_4 is T)
					{
						this.field_4 = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this.field_4 = null;
				}
			}
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0004B724 File Offset: 0x00049924
		public void kmethod_2587(Type arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.field_4 != null)
			{
				object[] array = this.field_4 as object[];
				if (array == null)
				{
					if (arg_0.IsInstanceOfType(this.field_4))
					{
						this.field_4 = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!arg_0.IsInstanceOfType(obj))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this.field_4 = null;
				}
			}
		}

		// Token: 0x040008AF RID: 2223
		private static Class_382 field_0;

		// Token: 0x040008B0 RID: 2224
		private Class_420 field_1;

		// Token: 0x040008B1 RID: 2225
		private Class_361 field_2;

		// Token: 0x040008B2 RID: 2226
		private Class_361 field_3;

		// Token: 0x040008B3 RID: 2227
		private object field_4;

		// Token: 0x040008B4 RID: 2228
		private static readonly Class_428[] field_5 = new Class_428[]
		{
			Class_428.Integer,
			Class_428.Float,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Boolean
		};

		// Token: 0x040008B5 RID: 2229
		private static readonly Class_428[] field_6 = new Class_428[]
		{
			Class_428.Integer,
			Class_428.Float,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Boolean
		};

		// Token: 0x040008B6 RID: 2230
		private static readonly Class_428[] field_7 = new Class_428[]
		{
			Class_428.Integer,
			Class_428.Float,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Boolean,
			Class_428.Bytes
		};

		// Token: 0x040008B7 RID: 2231
		private static readonly Class_428[] field_8 = new Class_428[]
		{
			Class_428.Date,
			Class_428.Integer,
			Class_428.Float,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Boolean,
			Class_428.Bytes,
			Class_428.Guid,
			Class_428.TimeSpan,
			Class_428.Uri
		};

		// Token: 0x040008B8 RID: 2232
		private static readonly Class_428[] field_9 = new Class_428[]
		{
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Guid,
			Class_428.Bytes
		};

		// Token: 0x040008B9 RID: 2233
		private static readonly Class_428[] field_10 = new Class_428[]
		{
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.TimeSpan
		};

		// Token: 0x040008BA RID: 2234
		private static readonly Class_428[] field_11 = new Class_428[]
		{
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Uri
		};

		// Token: 0x040008BB RID: 2235
		private static readonly Class_428[] field_12 = new Class_428[]
		{
			Class_428.Integer,
			Class_428.Float,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw
		};

		// Token: 0x040008BC RID: 2236
		private static readonly Class_428[] field_13 = new Class_428[]
		{
			Class_428.Date,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw
		};

		// Token: 0x040008BD RID: 2237
		private static readonly Class_428[] field_14 = new Class_428[]
		{
			Class_428.Bytes,
			Class_428.String,
			Class_428.Comment,
			Class_428.Raw,
			Class_428.Integer
		};

		// Token: 0x020001E2 RID: 482
		private class NClass_0
		{
			// Token: 0x06000E33 RID: 3635 RVA: 0x0004B987 File Offset: 0x00049B87
			public void nmethod_0(int sayıInt_0, int sayıInt_1)
			{
				base..ctor();
				this.field_0 = sayıInt_0;
				this.field_1 = sayıInt_1;
			}

			// Token: 0x040008BE RID: 2238
			internal readonly int field_0;

			// Token: 0x040008BF RID: 2239
			internal readonly int field_1;
		}
	}
}
