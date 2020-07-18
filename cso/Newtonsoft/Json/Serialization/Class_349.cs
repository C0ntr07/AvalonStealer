using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001D3 RID: 467
	public abstract class Class_349
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000479B8 File Offset: 0x00045BB8
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000479C0 File Offset: 0x00045BC0
		public Type prop_0 { get; private set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000479C9 File Offset: 0x00045BC9
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x000479D4 File Offset: 0x00045BD4
		public Type prop_1
		{
			get
			{
				return this.field_14;
			}
			set
			{
				this.field_14 = value;
				this.field_7 = this.field_14.IsSealed;
				this.field_8 = (!this.field_14.IsInterface && !this.field_14.IsAbstract);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00047A23 File Offset: 0x00045C23
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00047A2B File Offset: 0x00045C2B
		public bool? prop_2 { get; set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00047A34 File Offset: 0x00045C34
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00047A3C File Offset: 0x00045C3C
		public Class_299 prop_3 { get; set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00047A45 File Offset: 0x00045C45
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00047A4D File Offset: 0x00045C4D
		internal Class_299 prop_4 { get; set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00047A56 File Offset: 0x00045C56
		public IList<Class_449> prop_5
		{
			get
			{
				if (this.field_9 == null)
				{
					this.field_9 = new List<Class_449>();
				}
				return this.field_9;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00047A74 File Offset: 0x00045C74
		public IList<Class_449> prop_6
		{
			get
			{
				if (this.field_10 == null)
				{
					this.field_10 = new List<Class_449>();
				}
				return this.field_10;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00047A92 File Offset: 0x00045C92
		public IList<Class_449> prop_7
		{
			get
			{
				if (this.field_11 == null)
				{
					this.field_11 = new List<Class_449>();
				}
				return this.field_11;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00047AB0 File Offset: 0x00045CB0
		public IList<Class_449> prop_8
		{
			get
			{
				if (this.field_12 == null)
				{
					this.field_12 = new List<Class_449>();
				}
				return this.field_12;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00047ACE File Offset: 0x00045CCE
		public IList<Class_450> prop_9
		{
			get
			{
				if (this.field_13 == null)
				{
					this.field_13 = new List<Class_450>();
				}
				return this.field_13;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x00047AEC File Offset: 0x00045CEC
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00047B12 File Offset: 0x00045D12
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
		public MethodInfo prop_10
		{
			get
			{
				if (this.prop_5.Count <= 0)
				{
					return null;
				}
				return this.prop_5[0].Method;
			}
			set
			{
				this.prop_5.Clear();
				this.prop_5.Add(Class_349.lmethod_2348(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x00047B30 File Offset: 0x00045D30
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00047B56 File Offset: 0x00045D56
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
		public MethodInfo prop_11
		{
			get
			{
				if (this.prop_6.Count <= 0)
				{
					return null;
				}
				return this.prop_6[0].Method;
			}
			set
			{
				this.prop_6.Clear();
				this.prop_6.Add(Class_349.lmethod_2348(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00047B74 File Offset: 0x00045D74
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00047B9A File Offset: 0x00045D9A
		[Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
		public MethodInfo prop_12
		{
			get
			{
				if (this.prop_7.Count <= 0)
				{
					return null;
				}
				return this.prop_7[0].Method;
			}
			set
			{
				this.prop_7.Clear();
				this.prop_7.Add(Class_349.lmethod_2348(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00047BB8 File Offset: 0x00045DB8
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00047BDE File Offset: 0x00045DDE
		[Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
		public MethodInfo prop_13
		{
			get
			{
				if (this.prop_8.Count <= 0)
				{
					return null;
				}
				return this.prop_8[0].Method;
			}
			set
			{
				this.prop_8.Clear();
				this.prop_8.Add(Class_349.lmethod_2348(value));
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00047BFC File Offset: 0x00045DFC
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00047C22 File Offset: 0x00045E22
		[Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
		public MethodInfo prop_14
		{
			get
			{
				if (this.prop_9.Count <= 0)
				{
					return null;
				}
				return this.prop_9[0].Method;
			}
			set
			{
				this.prop_9.Clear();
				this.prop_9.Add(Class_349.pmethod_2349(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00047C40 File Offset: 0x00045E40
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00047C48 File Offset: 0x00045E48
		public Func<object> prop_15 { get; set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00047C51 File Offset: 0x00045E51
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00047C59 File Offset: 0x00045E59
		public bool prop_16 { get; set; }

		// Token: 0x06000D28 RID: 3368 RVA: 0x00047C64 File Offset: 0x00045E64
		internal Class_349(Type arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "underlyingType");
			this.prop_0 = arg_0;
			this.field_0 = Class_514.IsNullable(arg_0);
			this.field_3 = ((this.field_0 && Class_514.IsNullableType(arg_0)) ? Nullable.GetUnderlyingType(arg_0) : arg_0);
			this.prop_1 = this.field_3;
			this.field_1 = Class_499.IsConvertible(this.field_3);
			this.field_2 = this.field_3.IsEnum;
			if (this.field_3 == typeof(byte[]))
			{
				this.field_4 = Class_408.ReadAsBytes;
				return;
			}
			if (this.field_3 == typeof(int))
			{
				this.field_4 = Class_408.ReadAsInt32;
				return;
			}
			if (this.field_3 == typeof(decimal))
			{
				this.field_4 = Class_408.ReadAsDecimal;
				return;
			}
			if (this.field_3 == typeof(string))
			{
				this.field_4 = Class_408.ReadAsString;
				return;
			}
			if (this.field_3 == typeof(DateTime))
			{
				this.field_4 = Class_408.ReadAsDateTime;
				return;
			}
			if (this.field_3 == typeof(DateTimeOffset))
			{
				this.field_4 = Class_408.ReadAsDateTimeOffset;
				return;
			}
			this.field_4 = Class_408.Read;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00047DC0 File Offset: 0x00045FC0
		internal void gmethod_2343(object obje_0, StreamingContext arg_0)
		{
			if (this.field_12 != null)
			{
				foreach (Class_449 class_ in this.field_12)
				{
					class_(obje_0, arg_0);
				}
			}
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00047E24 File Offset: 0x00046024
		internal void cmethod_2344(object obje_0, StreamingContext arg_0)
		{
			if (this.field_11 != null)
			{
				foreach (Class_449 class_ in this.field_11)
				{
					class_(obje_0, arg_0);
				}
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00047E88 File Offset: 0x00046088
		internal void vmethod_2345(object obje_0, StreamingContext arg_0)
		{
			if (this.field_10 != null)
			{
				foreach (Class_449 class_ in this.field_10)
				{
					class_(obje_0, arg_0);
				}
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00047EEC File Offset: 0x000460EC
		internal void dmethod_2346(object obje_0, StreamingContext arg_0)
		{
			if (this.field_9 != null)
			{
				foreach (Class_449 class_ in this.field_9)
				{
					class_(obje_0, arg_0);
				}
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00047F54 File Offset: 0x00046154
		internal void kmethod_2347(object obje_0, StreamingContext arg_0, Class_446 arg_1)
		{
			if (this.field_13 != null)
			{
				foreach (Class_450 class_ in this.field_13)
				{
					class_(obje_0, arg_0, arg_1);
				}
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00047FB8 File Offset: 0x000461B8
		internal static Class_449 lmethod_2348(MethodInfo arg_0)
		{
			Class_349.NClass_0 nclass_ = new Class_349.NClass_0();
			nclass_.field_0 = arg_0;
			return new Class_449(nclass_.nmethod_1);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00047FE0 File Offset: 0x000461E0
		internal static Class_450 pmethod_2349(MethodInfo arg_0)
		{
			Class_349.NClass_1 nclass_ = new Class_349.NClass_1();
			nclass_.field_1 = arg_0;
			return new Class_450(nclass_.nmethod_3);
		}

		// Token: 0x04000865 RID: 2149
		internal bool field_0;

		// Token: 0x04000866 RID: 2150
		internal bool field_1;

		// Token: 0x04000867 RID: 2151
		internal bool field_2;

		// Token: 0x04000868 RID: 2152
		internal Type field_3;

		// Token: 0x04000869 RID: 2153
		internal Class_408 field_4;

		// Token: 0x0400086A RID: 2154
		internal Class_448 field_5;

		// Token: 0x0400086B RID: 2155
		internal bool field_6;

		// Token: 0x0400086C RID: 2156
		internal bool field_7;

		// Token: 0x0400086D RID: 2157
		internal bool field_8;

		// Token: 0x0400086E RID: 2158
		private List<Class_449> field_9;

		// Token: 0x0400086F RID: 2159
		private IList<Class_449> field_10;

		// Token: 0x04000870 RID: 2160
		private IList<Class_449> field_11;

		// Token: 0x04000871 RID: 2161
		private IList<Class_449> field_12;

		// Token: 0x04000872 RID: 2162
		private IList<Class_450> field_13;

		// Token: 0x04000873 RID: 2163
		private Type field_14;

		// Token: 0x04000874 RID: 2164
		[CompilerGenerated]
		private Type field_15;

		// Token: 0x04000875 RID: 2165
		[CompilerGenerated]
		private bool? field_16;

		// Token: 0x04000876 RID: 2166
		[CompilerGenerated]
		private Class_299 field_17;

		// Token: 0x04000877 RID: 2167
		[CompilerGenerated]
		private Class_299 field_18;

		// Token: 0x04000878 RID: 2168
		[CompilerGenerated]
		private Func<object> field_19;

		// Token: 0x04000879 RID: 2169
		[CompilerGenerated]
		private bool field_20;

		// Token: 0x020001D4 RID: 468
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000D30 RID: 3376 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06000D31 RID: 3377 RVA: 0x00048008 File Offset: 0x00046208
			public void nmethod_1(object obje_0, StreamingContext arg_0)
			{
				this.field_0.Invoke(obje_0, new object[]
				{
					arg_0
				});
			}

			// Token: 0x0400087A RID: 2170
			public MethodInfo field_0;
		}

		// Token: 0x020001D5 RID: 469
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06000D32 RID: 3378 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00048034 File Offset: 0x00046234
			public void nmethod_3(object obje_0, StreamingContext arg_0, Class_446 arg_1)
			{
				this.field_1.Invoke(obje_0, new object[]
				{
					arg_0,
					arg_1
				});
			}

			// Token: 0x0400087B RID: 2171
			public MethodInfo field_1;
		}
	}
}
