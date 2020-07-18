using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x020001FB RID: 507
	public class Class_380
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0004DB74 File Offset: 0x0004BD74
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0004DB9D File Offset: 0x0004BD9D
		public Class_458 prop_0
		{
			get
			{
				Class_458? class_ = this.field_41;
				if (class_ == null)
				{
					return Class_458.Error;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_41 = new Class_458?(value);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0004DBAC File Offset: 0x0004BDAC
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x0004DBD5 File Offset: 0x0004BDD5
		public Class_456 prop_1
		{
			get
			{
				Class_456? class_ = this.field_40;
				if (class_ == null)
				{
					return Class_456.Ignore;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_40 = new Class_456?(value);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0004DC0D File Offset: 0x0004BE0D
		public Class_384 prop_2
		{
			get
			{
				Class_384? class_ = this.field_39;
				if (class_ == null)
				{
					return Class_384.Auto;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_39 = new Class_384?(value);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0004DC1C File Offset: 0x0004BE1C
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x0004DC45 File Offset: 0x0004BE45
		public Class_457 prop_3
		{
			get
			{
				Class_457? class_ = this.field_38;
				if (class_ == null)
				{
					return Class_457.Include;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_38 = new Class_457?(value);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0004DC54 File Offset: 0x0004BE54
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0004DC7D File Offset: 0x0004BE7D
		public Class_377 prop_4
		{
			get
			{
				Class_377? class_ = this.field_36;
				if (class_ == null)
				{
					return Class_377.Include;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_36 = new Class_377?(value);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0004DC8B File Offset: 0x0004BE8B
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x0004DC93 File Offset: 0x0004BE93
		public IList<Class_299> prop_5 { get; set; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0004DC9C File Offset: 0x0004BE9C
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0004DCC5 File Offset: 0x0004BEC5
		public Class_375 prop_6
		{
			get
			{
				Class_375? class_ = this.field_37;
				if (class_ == null)
				{
					return Class_375.None;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_37 = new Class_375?(value);
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0004DCD4 File Offset: 0x0004BED4
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x0004DCFD File Offset: 0x0004BEFD
		public Class_494 prop_7
		{
			get
			{
				Class_494? class_ = this.field_44;
				if (class_ == null)
				{
					return Class_494.None;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_44 = new Class_494?(value);
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0004DD0C File Offset: 0x0004BF0C
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x0004DD35 File Offset: 0x0004BF35
		public Class_343 prop_8
		{
			get
			{
				Class_343? class_ = this.field_45;
				if (class_ == null)
				{
					return Class_343.Default;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_45 = new Class_343?(value);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0004DD44 File Offset: 0x0004BF44
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x0004DD6D File Offset: 0x0004BF6D
		public FormatterAssemblyStyle prop_9
		{
			get
			{
				FormatterAssemblyStyle? formatterAssemblyStyle = this.field_35;
				if (formatterAssemblyStyle == null)
				{
					return FormatterAssemblyStyle.Simple;
				}
				return formatterAssemblyStyle.GetValueOrDefault();
			}
			set
			{
				this.field_35 = new FormatterAssemblyStyle?(value);
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0004DD7C File Offset: 0x0004BF7C
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x0004DDA5 File Offset: 0x0004BFA5
		public Class_312 prop_10
		{
			get
			{
				Class_312? class_ = this.field_43;
				if (class_ == null)
				{
					return Class_312.Default;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_43 = new Class_312?(value);
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0004DDB3 File Offset: 0x0004BFB3
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x0004DDBB File Offset: 0x0004BFBB
		public Class_440 prop_11 { get; set; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0004DDC4 File Offset: 0x0004BFC4
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		public Class_373 prop_12 { get; set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0004DDD5 File Offset: 0x0004BFD5
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x0004DDDD File Offset: 0x0004BFDD
		public Class_344 prop_13 { get; set; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0004DDE6 File Offset: 0x0004BFE6
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x0004DDEE File Offset: 0x0004BFEE
		public SerializationBinder prop_14 { get; set; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0004DDF7 File Offset: 0x0004BFF7
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x0004DDFF File Offset: 0x0004BFFF
		public EventHandler<Class_371> prop_15 { get; set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0004DE08 File Offset: 0x0004C008
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x0004DE35 File Offset: 0x0004C035
		public StreamingContext prop_16
		{
			get
			{
				StreamingContext? streamingContext = this.field_42;
				if (streamingContext == null)
				{
					return Class_380.field_20;
				}
				return streamingContext.GetValueOrDefault();
			}
			set
			{
				this.field_42 = new StreamingContext?(value);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0004DE43 File Offset: 0x0004C043
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x0004DE57 File Offset: 0x0004C057
		public string prop_17
		{
			get
			{
				return this.field_33 ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			set
			{
				this.field_33 = value;
				this.field_34 = true;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0004DE67 File Offset: 0x0004C067
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x0004DE70 File Offset: 0x0004C070
		public int? prop_18
		{
			get
			{
				return this.field_31;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentException("Value must be positive.", "value");
				}
				this.field_31 = value;
				this.field_32 = true;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x0004DEE5 File Offset: 0x0004C0E5
		public Class_322 prop_19
		{
			get
			{
				Class_322? class_ = this.field_22;
				if (class_ == null)
				{
					return Class_322.None;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_22 = new Class_322?(value);
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x0004DF1D File Offset: 0x0004C11D
		public Class_319 prop_20
		{
			get
			{
				Class_319? class_ = this.field_23;
				if (class_ == null)
				{
					return Class_319.IsoDateFormat;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_23 = new Class_319?(value);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0004DF2C File Offset: 0x0004C12C
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x0004DF55 File Offset: 0x0004C155
		public Class_321 prop_21
		{
			get
			{
				Class_321? class_ = this.field_24;
				if (class_ == null)
				{
					return Class_321.RoundtripKind;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_24 = new Class_321?(value);
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0004DF64 File Offset: 0x0004C164
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x0004DF8D File Offset: 0x0004C18D
		public Class_320 prop_22
		{
			get
			{
				Class_320? class_ = this.field_25;
				if (class_ == null)
				{
					return Class_320.DateTime;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_25 = new Class_320?(value);
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0004DF9C File Offset: 0x0004C19C
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x0004DFC5 File Offset: 0x0004C1C5
		public Class_314 prop_23
		{
			get
			{
				Class_314? class_ = this.field_26;
				if (class_ == null)
				{
					return Class_314.String;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_26 = new Class_314?(value);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x0004DFFD File Offset: 0x0004C1FD
		public Class_315 prop_24
		{
			get
			{
				Class_315? class_ = this.field_27;
				if (class_ == null)
				{
					return Class_315.Double;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_27 = new Class_315?(value);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0004E00C File Offset: 0x0004C20C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x0004E035 File Offset: 0x0004C235
		public Class_356 prop_25
		{
			get
			{
				Class_356? class_ = this.field_28;
				if (class_ == null)
				{
					return Class_356.Default;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_28 = new Class_356?(value);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x0004E043 File Offset: 0x0004C243
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x0004E057 File Offset: 0x0004C257
		public CultureInfo prop_26
		{
			get
			{
				return this.field_29 ?? Class_380.field_21;
			}
			set
			{
				this.field_29 = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0004E060 File Offset: 0x0004C260
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x0004E089 File Offset: 0x0004C289
		public bool prop_27
		{
			get
			{
				return this.field_30 ?? false;
			}
			set
			{
				this.field_30 = new bool?(value);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004E0AE File Offset: 0x0004C2AE
		public Class_380()
		{
			this.prop_5 = new List<Class_299>();
		}

		// Token: 0x04000907 RID: 2311
		internal const Class_458 field_0 = Class_458.Error;

		// Token: 0x04000908 RID: 2312
		internal const Class_456 field_1 = Class_456.Ignore;

		// Token: 0x04000909 RID: 2313
		internal const Class_457 field_2 = Class_457.Include;

		// Token: 0x0400090A RID: 2314
		internal const Class_377 field_3 = Class_377.Include;

		// Token: 0x0400090B RID: 2315
		internal const Class_384 field_4 = Class_384.Auto;

		// Token: 0x0400090C RID: 2316
		internal const Class_375 field_5 = Class_375.None;

		// Token: 0x0400090D RID: 2317
		internal const Class_312 field_6 = Class_312.Default;

		// Token: 0x0400090E RID: 2318
		internal const Class_494 field_7 = Class_494.None;

		// Token: 0x0400090F RID: 2319
		internal const Class_343 field_8 = Class_343.Default;

		// Token: 0x04000910 RID: 2320
		internal const FormatterAssemblyStyle field_9 = FormatterAssemblyStyle.Simple;

		// Token: 0x04000911 RID: 2321
		internal const Class_322 field_10 = Class_322.None;

		// Token: 0x04000912 RID: 2322
		internal const Class_319 field_11 = Class_319.IsoDateFormat;

		// Token: 0x04000913 RID: 2323
		internal const Class_321 field_12 = Class_321.RoundtripKind;

		// Token: 0x04000914 RID: 2324
		internal const Class_320 field_13 = Class_320.DateTime;

		// Token: 0x04000915 RID: 2325
		internal const Class_315 field_14 = Class_315.Double;

		// Token: 0x04000916 RID: 2326
		internal const Class_314 field_15 = Class_314.String;

		// Token: 0x04000917 RID: 2327
		internal const Class_356 field_16 = Class_356.Default;

		// Token: 0x04000918 RID: 2328
		internal const FormatterAssemblyStyle field_17 = FormatterAssemblyStyle.Simple;

		// Token: 0x04000919 RID: 2329
		internal const bool field_18 = false;

		// Token: 0x0400091A RID: 2330
		internal const string field_19 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x0400091B RID: 2331
		internal static readonly StreamingContext field_20 = default(StreamingContext);

		// Token: 0x0400091C RID: 2332
		internal static readonly CultureInfo field_21 = CultureInfo.InvariantCulture;

		// Token: 0x0400091D RID: 2333
		internal Class_322? field_22;

		// Token: 0x0400091E RID: 2334
		internal Class_319? field_23;

		// Token: 0x0400091F RID: 2335
		internal Class_321? field_24;

		// Token: 0x04000920 RID: 2336
		internal Class_320? field_25;

		// Token: 0x04000921 RID: 2337
		internal Class_314? field_26;

		// Token: 0x04000922 RID: 2338
		internal Class_315? field_27;

		// Token: 0x04000923 RID: 2339
		internal Class_356? field_28;

		// Token: 0x04000924 RID: 2340
		internal CultureInfo field_29;

		// Token: 0x04000925 RID: 2341
		internal bool? field_30;

		// Token: 0x04000926 RID: 2342
		internal int? field_31;

		// Token: 0x04000927 RID: 2343
		internal bool field_32;

		// Token: 0x04000928 RID: 2344
		internal string field_33;

		// Token: 0x04000929 RID: 2345
		internal bool field_34;

		// Token: 0x0400092A RID: 2346
		internal FormatterAssemblyStyle? field_35;

		// Token: 0x0400092B RID: 2347
		internal Class_377? field_36;

		// Token: 0x0400092C RID: 2348
		internal Class_375? field_37;

		// Token: 0x0400092D RID: 2349
		internal Class_457? field_38;

		// Token: 0x0400092E RID: 2350
		internal Class_384? field_39;

		// Token: 0x0400092F RID: 2351
		internal Class_456? field_40;

		// Token: 0x04000930 RID: 2352
		internal Class_458? field_41;

		// Token: 0x04000931 RID: 2353
		internal StreamingContext? field_42;

		// Token: 0x04000932 RID: 2354
		internal Class_312? field_43;

		// Token: 0x04000933 RID: 2355
		internal Class_494? field_44;

		// Token: 0x04000934 RID: 2356
		internal Class_343? field_45;

		// Token: 0x04000935 RID: 2357
		[CompilerGenerated]
		private IList<Class_299> field_46;

		// Token: 0x04000936 RID: 2358
		[CompilerGenerated]
		private Class_440 field_47;

		// Token: 0x04000937 RID: 2359
		[CompilerGenerated]
		private Class_373 field_48;

		// Token: 0x04000938 RID: 2360
		[CompilerGenerated]
		private Class_344 field_49;

		// Token: 0x04000939 RID: 2361
		[CompilerGenerated]
		private SerializationBinder field_50;

		// Token: 0x0400093A RID: 2362
		[CompilerGenerated]
		private EventHandler<Class_371> field_51;
	}
}
