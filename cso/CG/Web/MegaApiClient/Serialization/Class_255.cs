using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200015C RID: 348
	internal class Class_255 : Class_272
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		private Class_255(Class_233 arg_0, Class_235 arg_1, string str_0, string str_1, byte[] byteDizi_0, string str_2) : base("p")
		{
			this.prop_0 = arg_0.prop_0;
			this.prop_2 = new Class_255.NClass_0[]
			{
				new Class_255.NClass_0
				{
					nprop_2 = str_0,
					nprop_3 = str_1,
					nprop_1 = arg_1,
					nprop_0 = str_2
				}
			};
			Class_234 class_ = arg_0 as Class_234;
			if (class_ == null)
			{
				throw new ArgumentException("parentNode node must implement INodeCrypto");
			}
			if (class_.prop_1 != null)
			{
				this.prop_1 = new Class_275(arg_0.prop_0);
				this.prop_1.vmethod_1815(str_2, byteDizi_0, class_.prop_1);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0003D067 File Offset: 0x0003B267
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0003D06F File Offset: 0x0003B26F
		[Class_410("t")]
		public new string prop_0 { get; private set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003D078 File Offset: 0x0003B278
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0003D080 File Offset: 0x0003B280
		[Class_410("cr")]
		public new Class_275 prop_1 { get; private set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003D089 File Offset: 0x0003B289
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0003D091 File Offset: 0x0003B291
		[Class_410("n")]
		public Class_255.NClass_0[] prop_2 { get; private set; }

		// Token: 0x060009EC RID: 2540 RVA: 0x0003D09A File Offset: 0x0003B29A
		public static Class_255 gmethod_1743(Class_233 arg_0, string str_0, string str_1, byte[] byteDizi_0, string str_2)
		{
			return new Class_255(arg_0, Class_235.File, str_0, str_1, byteDizi_0, str_2);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0003D0A8 File Offset: 0x0003B2A8
		public static Class_255 cmethod_1744(Class_233 arg_0, string str_0, string str_1, byte[] byteDizi_0)
		{
			return new Class_255(arg_0, Class_235.Directory, str_0, str_1, byteDizi_0, "xxxxxxxx");
		}

		// Token: 0x040006BB RID: 1723
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006BC RID: 1724
		[CompilerGenerated]
		private Class_275 field_1;

		// Token: 0x040006BD RID: 1725
		[CompilerGenerated]
		private Class_255.NClass_0[] field_2;

		// Token: 0x0200015D RID: 349
		internal class NClass_0
		{
			// Token: 0x17000217 RID: 535
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x0003D0B9 File Offset: 0x0003B2B9
			// (set) Token: 0x060009EF RID: 2543 RVA: 0x0003D0C1 File Offset: 0x0003B2C1
			[Class_410("h")]
			public string nprop_0 { get; set; }

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003D0CA File Offset: 0x0003B2CA
			// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0003D0D2 File Offset: 0x0003B2D2
			[Class_410("t")]
			public Class_235 nprop_1 { get; set; }

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003D0DB File Offset: 0x0003B2DB
			// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0003D0E3 File Offset: 0x0003B2E3
			[Class_410("a")]
			public string nprop_2 { get; set; }

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0003D0EC File Offset: 0x0003B2EC
			// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0003D0F4 File Offset: 0x0003B2F4
			[Class_410("k")]
			public string nprop_3 { get; set; }

			// Token: 0x060009F6 RID: 2550 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_8()
			{
				base..ctor();
			}

			// Token: 0x040006BE RID: 1726
			[CompilerGenerated]
			private string field_8;

			// Token: 0x040006BF RID: 1727
			[CompilerGenerated]
			private Class_235 field_9;

			// Token: 0x040006C0 RID: 1728
			[CompilerGenerated]
			private string field_10;

			// Token: 0x040006C1 RID: 1729
			[CompilerGenerated]
			private string field_11;
		}
	}
}
