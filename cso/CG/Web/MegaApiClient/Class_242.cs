using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000148 RID: 328
	[DebuggerDisplay("PublicNode - Type: {Type} - Name: {Name} - Id: {Id}")]
	internal class Class_242 : IEquatable<Class_232>, Class_232, Class_233, Class_234
	{
		// Token: 0x06000954 RID: 2388 RVA: 0x0003BC32 File Offset: 0x00039E32
		internal Class_242(Class_241 arg_0, string str_0)
		{
			this.field_0 = arg_0;
			this.prop_0 = str_0;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0003BC48 File Offset: 0x00039E48
		public string prop_0 { get; }

		// Token: 0x06000956 RID: 2390 RVA: 0x0003BC50 File Offset: 0x00039E50
		public bool vmethod_1635(Class_232 arg_0)
		{
			if (this.field_0.smethod_1600(arg_0))
			{
				string a = this.prop_0;
				Class_242 class_ = arg_0 as Class_242;
				return a == ((class_ != null) ? class_.prop_0 : null);
			}
			return false;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0003BC88 File Offset: 0x00039E88
		public long prop_1
		{
			get
			{
				return this.field_0.prop_1;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0003BC95 File Offset: 0x00039E95
		public string prop_2
		{
			get
			{
				return this.field_0.prop_0;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0003BCA2 File Offset: 0x00039EA2
		public DateTime? prop_3
		{
			get
			{
				return this.field_0.prop_4;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0003BCAF File Offset: 0x00039EAF
		public string prop_4
		{
			get
			{
				return this.field_0.prop_6.prop_1;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0003BCC1 File Offset: 0x00039EC1
		public string prop_5
		{
			get
			{
				return this.field_0.prop_3;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0003BCCE File Offset: 0x00039ECE
		public string prop_6
		{
			get
			{
				if (!this.field_0.prop_14)
				{
					return this.field_0.prop_0;
				}
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0003BCED File Offset: 0x00039EED
		public string prop_7
		{
			get
			{
				return this.field_0.prop_1;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0003BCFA File Offset: 0x00039EFA
		public Class_235 prop_8
		{
			get
			{
				if (!this.field_0.prop_14 || this.field_0.prop_2 != Class_235.Directory)
				{
					return this.field_0.prop_2;
				}
				return Class_235.Root;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0003BD2A File Offset: 0x00039F2A
		public DateTime prop_9
		{
			get
			{
				return this.field_0.prop_4;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0003BD37 File Offset: 0x00039F37
		public byte[] prop_10
		{
			get
			{
				return this.field_0.prop_5;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0003BD44 File Offset: 0x00039F44
		public byte[] prop_11
		{
			get
			{
				return this.field_0.prop_7;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0003BD51 File Offset: 0x00039F51
		public byte[] prop_12
		{
			get
			{
				return this.field_0.prop_8;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0003BD5E File Offset: 0x00039F5E
		public byte[] prop_13
		{
			get
			{
				return this.field_0.prop_9;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0003BD6B File Offset: 0x00039F6B
		public byte[] prop_14
		{
			get
			{
				return this.field_0.prop_6;
			}
		}

		// Token: 0x04000672 RID: 1650
		private readonly Class_241 field_0;

		// Token: 0x04000673 RID: 1651
		[CompilerGenerated]
		private readonly string field_1;
	}
}
