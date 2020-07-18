using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000229 RID: 553
	public class Class_418
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06001146 RID: 4422 RVA: 0x00055DE4 File Offset: 0x00053FE4
		// (remove) Token: 0x06001147 RID: 4423 RVA: 0x00055E1C File Offset: 0x0005401C
		public virtual event EventHandler<Class_371> Error
		{
			add
			{
				EventHandler<Class_371> eventHandler = this.field_29;
				EventHandler<Class_371> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_371> value2 = (EventHandler<Class_371>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_371>>(ref this.field_29, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_371> eventHandler = this.field_29;
				EventHandler<Class_371> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_371> value2 = (EventHandler<Class_371>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_371>>(ref this.field_29, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00055E51 File Offset: 0x00054051
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00055E59 File Offset: 0x00054059
		public virtual Class_373 prop_0
		{
			get
			{
				return this.pmethod_3179();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value", "Reference resolver cannot be null.");
				}
				this.field_15 = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00055E78 File Offset: 0x00054078
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00055E80 File Offset: 0x00054080
		public virtual SerializationBinder prop_1
		{
			get
			{
				return this.field_13;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value", "Serialization binder cannot be null.");
				}
				this.field_13 = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00055E9F File Offset: 0x0005409F
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00055EA7 File Offset: 0x000540A7
		public virtual Class_344 prop_2
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

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00055EB0 File Offset: 0x000540B0
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00055EB8 File Offset: 0x000540B8
		public virtual Class_494 prop_3
		{
			get
			{
				return this.field_0;
			}
			set
			{
				if (value < Class_494.None || value > Class_494.Auto)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_0 = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00055EDA File Offset: 0x000540DA
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00055EE2 File Offset: 0x000540E2
		public virtual FormatterAssemblyStyle prop_4
		{
			get
			{
				return this.field_1;
			}
			set
			{
				if (value < FormatterAssemblyStyle.Simple || value > FormatterAssemblyStyle.Full)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_1 = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00055F04 File Offset: 0x00054104
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00055F0C File Offset: 0x0005410C
		public virtual Class_375 prop_5
		{
			get
			{
				return this.field_2;
			}
			set
			{
				if (value < Class_375.None || value > Class_375.All)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_2 = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00055F2E File Offset: 0x0005412E
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00055F36 File Offset: 0x00054136
		public virtual Class_458 prop_6
		{
			get
			{
				return this.field_3;
			}
			set
			{
				if (value < Class_458.Error || value > Class_458.Serialize)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_3 = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00055F58 File Offset: 0x00054158
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00055F60 File Offset: 0x00054160
		public virtual Class_456 prop_7
		{
			get
			{
				return this.field_4;
			}
			set
			{
				if (value < Class_456.Ignore || value > Class_456.Error)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_4 = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00055F82 File Offset: 0x00054182
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00055F8A File Offset: 0x0005418A
		public virtual Class_457 prop_8
		{
			get
			{
				return this.field_6;
			}
			set
			{
				if (value < Class_457.Include || value > Class_457.Ignore)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_6 = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00055FAC File Offset: 0x000541AC
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00055FB4 File Offset: 0x000541B4
		public virtual Class_377 prop_9
		{
			get
			{
				return this.field_7;
			}
			set
			{
				if (value < Class_377.Include || value > Class_377.IgnoreAndPopulate)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_7 = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00055FD6 File Offset: 0x000541D6
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x00055FDE File Offset: 0x000541DE
		public virtual Class_384 prop_10
		{
			get
			{
				return this.field_5;
			}
			set
			{
				if (value < Class_384.Auto || value > Class_384.Replace)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_5 = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00056000 File Offset: 0x00054200
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00056008 File Offset: 0x00054208
		public virtual Class_312 prop_11
		{
			get
			{
				return this.field_8;
			}
			set
			{
				if (value < Class_312.Default || value > Class_312.AllowNonPublicDefaultConstructor)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_8 = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0005602A File Offset: 0x0005422A
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x00056032 File Offset: 0x00054232
		public virtual Class_343 prop_12
		{
			get
			{
				return this.field_9;
			}
			set
			{
				if (value < Class_343.Default || value > Class_343.Ignore)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_9 = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00056054 File Offset: 0x00054254
		public virtual Class_415 prop_13
		{
			get
			{
				if (this.field_10 == null)
				{
					this.field_10 = new Class_415();
				}
				return this.field_10;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x00056072 File Offset: 0x00054272
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0005607A File Offset: 0x0005427A
		public virtual Class_440 prop_14
		{
			get
			{
				return this.field_11;
			}
			set
			{
				this.field_11 = (value ?? Class_441.prop_0);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0005608F File Offset: 0x0005428F
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00056097 File Offset: 0x00054297
		public virtual StreamingContext prop_15
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

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x000560A0 File Offset: 0x000542A0
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x000560C9 File Offset: 0x000542C9
		public virtual Class_322 prop_16
		{
			get
			{
				Class_322? class_ = this.field_16;
				if (class_ == null)
				{
					return Class_322.None;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_16 = new Class_322?(value);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x000560D8 File Offset: 0x000542D8
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x00056101 File Offset: 0x00054301
		public virtual Class_319 prop_17
		{
			get
			{
				Class_319? class_ = this.field_17;
				if (class_ == null)
				{
					return Class_319.IsoDateFormat;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_17 = new Class_319?(value);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00056110 File Offset: 0x00054310
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00056139 File Offset: 0x00054339
		public virtual Class_321 prop_18
		{
			get
			{
				Class_321? class_ = this.field_18;
				if (class_ == null)
				{
					return Class_321.RoundtripKind;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_18 = new Class_321?(value);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00056148 File Offset: 0x00054348
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00056171 File Offset: 0x00054371
		public virtual Class_320 prop_19
		{
			get
			{
				Class_320? class_ = this.field_19;
				if (class_ == null)
				{
					return Class_320.DateTime;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_19 = new Class_320?(value);
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00056180 File Offset: 0x00054380
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x000561A9 File Offset: 0x000543A9
		public virtual Class_315 prop_20
		{
			get
			{
				Class_315? class_ = this.field_21;
				if (class_ == null)
				{
					return Class_315.Double;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_21 = new Class_315?(value);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x000561B8 File Offset: 0x000543B8
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x000561E1 File Offset: 0x000543E1
		public virtual Class_314 prop_21
		{
			get
			{
				Class_314? class_ = this.field_20;
				if (class_ == null)
				{
					return Class_314.String;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_20 = new Class_314?(value);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000561F0 File Offset: 0x000543F0
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00056219 File Offset: 0x00054419
		public virtual Class_356 prop_22
		{
			get
			{
				Class_356? class_ = this.field_22;
				if (class_ == null)
				{
					return Class_356.Default;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_22 = new Class_356?(value);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00056227 File Offset: 0x00054427
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0005623B File Offset: 0x0005443B
		public virtual string prop_23
		{
			get
			{
				return this.field_27 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			set
			{
				this.field_27 = value;
				this.field_28 = true;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0005624B File Offset: 0x0005444B
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0005625F File Offset: 0x0005445F
		public virtual CultureInfo prop_24
		{
			get
			{
				return this.field_23 ?? Class_380.field_21;
			}
			set
			{
				this.field_23 = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x00056268 File Offset: 0x00054468
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x00056270 File Offset: 0x00054470
		public virtual int? prop_25
		{
			get
			{
				return this.field_24;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this.field_24 = value;
				this.field_25 = true;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000562BC File Offset: 0x000544BC
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x000562E5 File Offset: 0x000544E5
		public virtual bool prop_26
		{
			get
			{
				return this.field_26 ?? false;
			}
			set
			{
				this.field_26 = new bool?(value);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000562F3 File Offset: 0x000544F3
		internal bool pmethod_3159()
		{
			return this.field_26 != null;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00056300 File Offset: 0x00054500
		public Class_418()
		{
			this.field_3 = Class_458.Error;
			this.field_4 = Class_456.Ignore;
			this.field_6 = Class_457.Include;
			this.field_7 = Class_377.Include;
			this.field_5 = Class_384.Auto;
			this.field_2 = Class_375.None;
			this.field_8 = Class_312.Default;
			this.field_0 = Class_494.None;
			this.field_9 = Class_343.Default;
			this.field_14 = Class_380.field_20;
			this.field_13 = Class_445.field_0;
			this.field_23 = Class_380.field_21;
			this.field_11 = Class_441.prop_0;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00056380 File Offset: 0x00054580
		public static Class_418 smethod_3160(Class_380 arg_0)
		{
			Class_418 class_ = new Class_418();
			if (arg_0 != null)
			{
				Class_418.gmethod_3163(class_, arg_0);
			}
			return class_;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x000563A4 File Offset: 0x000545A4
		public static Class_418 xmethod_3161()
		{
			Func<Class_380> defaultSettings = Class_416.DefaultSettings;
			Class_380 arg_ = (defaultSettings != null) ? defaultSettings() : null;
			return Class_418.smethod_3160(arg_);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000563D0 File Offset: 0x000545D0
		public static Class_418 tmethod_3162(Class_380 arg_0)
		{
			Class_418 class_ = Class_418.xmethod_3161();
			if (arg_0 != null)
			{
				Class_418.gmethod_3163(class_, arg_0);
			}
			return class_;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x000563F4 File Offset: 0x000545F4
		private static void gmethod_3163(Class_418 arg_0, Class_380 arg_1)
		{
			if (!Class_510.IsNullOrEmpty<Class_299>(arg_1.prop_5))
			{
				for (int i = 0; i < arg_1.prop_5.Count; i++)
				{
					arg_0.prop_13.Insert(i, arg_1.prop_5[i]);
				}
			}
			if (arg_1.field_44 != null)
			{
				arg_0.prop_3 = arg_1.prop_7;
			}
			if (arg_1.field_45 != null)
			{
				arg_0.prop_12 = arg_1.prop_8;
			}
			if (arg_1.field_35 != null)
			{
				arg_0.prop_4 = arg_1.prop_9;
			}
			if (arg_1.field_37 != null)
			{
				arg_0.prop_5 = arg_1.prop_6;
			}
			if (arg_1.field_41 != null)
			{
				arg_0.prop_6 = arg_1.prop_0;
			}
			if (arg_1.field_40 != null)
			{
				arg_0.prop_7 = arg_1.prop_1;
			}
			if (arg_1.field_39 != null)
			{
				arg_0.prop_10 = arg_1.prop_2;
			}
			if (arg_1.field_38 != null)
			{
				arg_0.prop_8 = arg_1.prop_3;
			}
			if (arg_1.field_36 != null)
			{
				arg_0.prop_9 = arg_1.prop_4;
			}
			if (arg_1.field_43 != null)
			{
				arg_0.prop_11 = arg_1.prop_10;
			}
			if (arg_1.field_42 != null)
			{
				arg_0.prop_15 = arg_1.prop_16;
			}
			if (arg_1.field_30 != null)
			{
				arg_0.field_26 = arg_1.field_30;
			}
			if (arg_1.prop_15 != null)
			{
				arg_0.Error += arg_1.prop_15;
			}
			if (arg_1.prop_11 != null)
			{
				arg_0.prop_14 = arg_1.prop_11;
			}
			if (arg_1.prop_12 != null)
			{
				arg_0.prop_0 = arg_1.prop_12;
			}
			if (arg_1.prop_13 != null)
			{
				arg_0.prop_2 = arg_1.prop_13;
			}
			if (arg_1.prop_14 != null)
			{
				arg_0.prop_1 = arg_1.prop_14;
			}
			if (arg_1.field_22 != null)
			{
				arg_0.field_16 = arg_1.field_22;
			}
			if (arg_1.field_23 != null)
			{
				arg_0.field_17 = arg_1.field_23;
			}
			if (arg_1.field_24 != null)
			{
				arg_0.field_18 = arg_1.field_24;
			}
			if (arg_1.field_25 != null)
			{
				arg_0.field_19 = arg_1.field_25;
			}
			if (arg_1.field_34)
			{
				arg_0.field_27 = arg_1.field_33;
				arg_0.field_28 = arg_1.field_34;
			}
			if (arg_1.field_26 != null)
			{
				arg_0.field_20 = arg_1.field_26;
			}
			if (arg_1.field_27 != null)
			{
				arg_0.field_21 = arg_1.field_27;
			}
			if (arg_1.field_28 != null)
			{
				arg_0.field_22 = arg_1.field_28;
			}
			if (arg_1.field_29 != null)
			{
				arg_0.field_23 = arg_1.field_29;
			}
			if (arg_1.field_32)
			{
				arg_0.field_24 = arg_1.field_31;
				arg_0.field_25 = arg_1.field_32;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00056726 File Offset: 0x00054926
		public void cmethod_3164(TextReader arg_0, object obje_0)
		{
			this.vmethod_3165(new Class_409(arg_0), obje_0);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00056735 File Offset: 0x00054935
		public void vmethod_3165(Class_285 arg_0, object obje_0)
		{
			this.dmethod_3166(arg_0, obje_0);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00056740 File Offset: 0x00054940
		internal virtual void dmethod_3166(Class_285 arg_0, object obje_0)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			Class_517.ArgumentNotNull(obje_0, "target");
			CultureInfo arg_;
			Class_321? arg_2;
			Class_320? arg_3;
			Class_315? arg_4;
			int? arg_5;
			string str_;
			this.tmethod_3172(arg_0, out arg_, out arg_2, out arg_3, out arg_4, out arg_5, out str_);
			Class_354 class_ = (this.prop_2 != null && this.prop_2.prop_0 >= TraceLevel.Verbose) ? new Class_354(arg_0) : null;
			Class_466 class_2 = new Class_466(this);
			class_2.xmethod_3851(class_ ?? arg_0, obje_0);
			if (class_ != null)
			{
				this.prop_2.gmethod_2303(TraceLevel.Verbose, "Deserialized JSON: " + Environment.NewLine + class_.xmethod_2371(), null);
			}
			this.gmethod_3173(arg_0, arg_, arg_2, arg_3, arg_4, arg_5, str_);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000567F3 File Offset: 0x000549F3
		public object kmethod_3167(Class_285 arg_0)
		{
			return this.smethod_3170(arg_0, null);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000567FD File Offset: 0x000549FD
		public object lmethod_3168(TextReader arg_0, Type arg_1)
		{
			return this.smethod_3170(new Class_409(arg_0), arg_1);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0005680C File Offset: 0x00054A0C
		public T pmethod_3169<T>(Class_285 arg_0)
		{
			return (T)((object)this.smethod_3170(arg_0, typeof(T)));
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00056824 File Offset: 0x00054A24
		public object smethod_3170(Class_285 arg_0, Type arg_1)
		{
			return this.xmethod_3171(arg_0, arg_1);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00056830 File Offset: 0x00054A30
		internal virtual object xmethod_3171(Class_285 arg_0, Type arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			CultureInfo arg_2;
			Class_321? arg_3;
			Class_320? arg_4;
			Class_315? arg_5;
			int? arg_6;
			string str_;
			this.tmethod_3172(arg_0, out arg_2, out arg_3, out arg_4, out arg_5, out arg_6, out str_);
			Class_354 class_ = (this.prop_2 != null && this.prop_2.prop_0 >= TraceLevel.Verbose) ? new Class_354(arg_0) : null;
			Class_466 class_2 = new Class_466(this);
			object result = class_2.gmethod_3853(class_ ?? arg_0, arg_1, this.prop_26);
			if (class_ != null)
			{
				this.prop_2.gmethod_2303(TraceLevel.Verbose, "Deserialized JSON: " + Environment.NewLine + class_.xmethod_2371(), null);
			}
			this.gmethod_3173(arg_0, arg_2, arg_3, arg_4, arg_5, arg_6, str_);
			return result;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000568E4 File Offset: 0x00054AE4
		private void tmethod_3172(Class_285 arg_0, out CultureInfo arg_1, out Class_321? arg_2, out Class_320? arg_3, out Class_315? arg_4, out int? arg_5, out string arg_6)
		{
			if (this.field_23 != null && !this.field_23.Equals(arg_0.prop_14))
			{
				arg_1 = arg_0.prop_14;
				arg_0.prop_14 = this.field_23;
			}
			else
			{
				arg_1 = null;
			}
			if (this.field_18 != null && arg_0.prop_4 != this.field_18)
			{
				arg_2 = new Class_321?(arg_0.prop_4);
				arg_0.prop_4 = this.field_18.Value;
			}
			else
			{
				arg_2 = null;
			}
			if (this.field_19 != null && arg_0.prop_5 != this.field_19)
			{
				arg_3 = new Class_320?(arg_0.prop_5);
				arg_0.prop_5 = this.field_19.Value;
			}
			else
			{
				arg_3 = null;
			}
			if (this.field_21 != null && arg_0.prop_6 != this.field_21)
			{
				arg_4 = new Class_315?(arg_0.prop_6);
				arg_0.prop_6 = this.field_21.Value;
			}
			else
			{
				arg_4 = null;
			}
			if (this.field_25 && arg_0.prop_8 != this.field_24)
			{
				arg_5 = arg_0.prop_8;
				arg_0.prop_8 = this.field_24;
			}
			else
			{
				arg_5 = null;
			}
			if (this.field_28 && arg_0.prop_7 != this.field_27)
			{
				arg_6 = arg_0.prop_7;
				arg_0.prop_7 = this.field_27;
			}
			else
			{
				arg_6 = null;
			}
			Class_409 class_ = arg_0 as Class_409;
			if (class_ != null)
			{
				Class_441 class_2 = this.field_11 as Class_441;
				if (class_2 != null)
				{
					class_.field_11 = class_2.gmethod_3553().field_1;
				}
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00056B68 File Offset: 0x00054D68
		private void gmethod_3173(Class_285 arg_0, CultureInfo arg_1, Class_321? arg_2, Class_320? arg_3, Class_315? arg_4, int? arg_5, string str_0)
		{
			if (arg_1 != null)
			{
				arg_0.prop_14 = arg_1;
			}
			if (arg_2 != null)
			{
				arg_0.prop_4 = arg_2.Value;
			}
			if (arg_3 != null)
			{
				arg_0.prop_5 = arg_3.Value;
			}
			if (arg_4 != null)
			{
				arg_0.prop_6 = arg_4.Value;
			}
			if (this.field_25)
			{
				arg_0.prop_8 = arg_5;
			}
			if (this.field_28)
			{
				arg_0.prop_7 = str_0;
			}
			Class_409 class_ = arg_0 as Class_409;
			if (class_ != null)
			{
				class_.field_11 = null;
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00056C07 File Offset: 0x00054E07
		public void cmethod_3174(TextWriter arg_0, object obje_0)
		{
			this.kmethod_3177(new Class_412(arg_0), obje_0);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00056C16 File Offset: 0x00054E16
		public void vmethod_3175(Class_296 arg_0, object obje_0, Type arg_1)
		{
			this.lmethod_3178(arg_0, obje_0, arg_1);
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00056C21 File Offset: 0x00054E21
		public void dmethod_3176(TextWriter arg_0, object obje_0, Type arg_1)
		{
			this.vmethod_3175(new Class_412(arg_0), obje_0, arg_1);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00056C31 File Offset: 0x00054E31
		public void kmethod_3177(Class_296 arg_0, object obje_0)
		{
			this.lmethod_3178(arg_0, obje_0, null);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00056C3C File Offset: 0x00054E3C
		internal virtual void lmethod_3178(Class_296 arg_0, object obje_0, Type arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "jsonWriter");
			Class_322? class_ = null;
			if (this.field_16 != null && arg_0.prop_5 != this.field_16)
			{
				class_ = new Class_322?(arg_0.prop_5);
				arg_0.prop_5 = this.field_16.Value;
			}
			Class_319? class_2 = null;
			if (this.field_17 != null && arg_0.prop_6 != this.field_17)
			{
				class_2 = new Class_319?(arg_0.prop_6);
				arg_0.prop_6 = this.field_17.Value;
			}
			Class_321? class_3 = null;
			if (this.field_18 != null && arg_0.prop_7 != this.field_18)
			{
				class_3 = new Class_321?(arg_0.prop_7);
				arg_0.prop_7 = this.field_18.Value;
			}
			Class_314? class_4 = null;
			if (this.field_20 != null && arg_0.prop_9 != this.field_20)
			{
				class_4 = new Class_314?(arg_0.prop_9);
				arg_0.prop_9 = this.field_20.Value;
			}
			Class_356? class_5 = null;
			if (this.field_22 != null && arg_0.prop_8 != this.field_22)
			{
				class_5 = new Class_356?(arg_0.prop_8);
				arg_0.prop_8 = this.field_22.Value;
			}
			CultureInfo cultureInfo = null;
			if (this.field_23 != null && !this.field_23.Equals(arg_0.prop_11))
			{
				cultureInfo = arg_0.prop_11;
				arg_0.prop_11 = this.field_23;
			}
			string str_ = null;
			if (this.field_28 && arg_0.prop_10 != this.field_27)
			{
				str_ = arg_0.prop_10;
				arg_0.prop_10 = this.field_27;
			}
			Class_355 class_6 = (this.prop_2 != null && this.prop_2.prop_0 >= TraceLevel.Verbose) ? new Class_355(arg_0) : null;
			Class_467 class_7 = new Class_467(this);
			class_7.tmethod_3902(class_6 ?? arg_0, obje_0, arg_1);
			if (class_6 != null)
			{
				this.prop_2.gmethod_2303(TraceLevel.Verbose, "Serialized JSON: " + Environment.NewLine + class_6.smethod_2390(), null);
			}
			if (class_ != null)
			{
				arg_0.prop_5 = class_.Value;
			}
			if (class_2 != null)
			{
				arg_0.prop_6 = class_2.Value;
			}
			if (class_3 != null)
			{
				arg_0.prop_7 = class_3.Value;
			}
			if (class_4 != null)
			{
				arg_0.prop_9 = class_4.Value;
			}
			if (class_5 != null)
			{
				arg_0.prop_8 = class_5.Value;
			}
			if (this.field_28)
			{
				arg_0.prop_10 = str_;
			}
			if (cultureInfo != null)
			{
				arg_0.prop_11 = cultureInfo;
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00056FDC File Offset: 0x000551DC
		internal Class_373 pmethod_3179()
		{
			if (this.field_15 == null)
			{
				this.field_15 = new Class_374();
			}
			return this.field_15;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00056FFA File Offset: 0x000551FA
		internal Class_299 smethod_3180(Type arg_0)
		{
			return Class_418.xmethod_3181(this.field_10, arg_0);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00057008 File Offset: 0x00055208
		internal static Class_299 xmethod_3181(IList<Class_299> arg_0, Type arg_1)
		{
			if (arg_0 != null)
			{
				for (int i = 0; i < arg_0.Count; i++)
				{
					Class_299 class_ = arg_0[i];
					if (class_.cmethod_2134(arg_1))
					{
						return class_;
					}
				}
			}
			return null;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00057048 File Offset: 0x00055248
		internal void tmethod_3182(Class_371 arg_0)
		{
			EventHandler<Class_371> eventHandler = this.field_29;
			if (eventHandler != null)
			{
				eventHandler(this, arg_0);
			}
		}

		// Token: 0x040009BC RID: 2492
		internal Class_494 field_0;

		// Token: 0x040009BD RID: 2493
		internal FormatterAssemblyStyle field_1;

		// Token: 0x040009BE RID: 2494
		internal Class_375 field_2;

		// Token: 0x040009BF RID: 2495
		internal Class_458 field_3;

		// Token: 0x040009C0 RID: 2496
		internal Class_456 field_4;

		// Token: 0x040009C1 RID: 2497
		internal Class_384 field_5;

		// Token: 0x040009C2 RID: 2498
		internal Class_457 field_6;

		// Token: 0x040009C3 RID: 2499
		internal Class_377 field_7;

		// Token: 0x040009C4 RID: 2500
		internal Class_312 field_8;

		// Token: 0x040009C5 RID: 2501
		internal Class_343 field_9;

		// Token: 0x040009C6 RID: 2502
		internal Class_415 field_10;

		// Token: 0x040009C7 RID: 2503
		internal Class_440 field_11;

		// Token: 0x040009C8 RID: 2504
		internal Class_344 field_12;

		// Token: 0x040009C9 RID: 2505
		internal SerializationBinder field_13;

		// Token: 0x040009CA RID: 2506
		internal StreamingContext field_14;

		// Token: 0x040009CB RID: 2507
		private Class_373 field_15;

		// Token: 0x040009CC RID: 2508
		private Class_322? field_16;

		// Token: 0x040009CD RID: 2509
		private Class_319? field_17;

		// Token: 0x040009CE RID: 2510
		private Class_321? field_18;

		// Token: 0x040009CF RID: 2511
		private Class_320? field_19;

		// Token: 0x040009D0 RID: 2512
		private Class_314? field_20;

		// Token: 0x040009D1 RID: 2513
		private Class_315? field_21;

		// Token: 0x040009D2 RID: 2514
		private Class_356? field_22;

		// Token: 0x040009D3 RID: 2515
		private CultureInfo field_23;

		// Token: 0x040009D4 RID: 2516
		private int? field_24;

		// Token: 0x040009D5 RID: 2517
		private bool field_25;

		// Token: 0x040009D6 RID: 2518
		private bool? field_26;

		// Token: 0x040009D7 RID: 2519
		private string field_27;

		// Token: 0x040009D8 RID: 2520
		private bool field_28;

		// Token: 0x040009D9 RID: 2521
		private EventHandler<Class_371> field_29;
	}
}
