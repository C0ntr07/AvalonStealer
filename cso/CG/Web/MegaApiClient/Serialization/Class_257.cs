using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200015F RID: 351
	internal class Class_257 : Class_272
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x0003D128 File Offset: 0x0003B328
		public Class_257(Class_233 arg_0) : base("g")
		{
			this.prop_1 = arg_0.prop_0;
			Class_242 class_ = arg_0 as Class_242;
			if (class_ != null)
			{
				base.prop_1["n"] = class_.prop_0;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public new int prop_0
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003D16F File Offset: 0x0003B36F
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0003D177 File Offset: 0x0003B377
		[Class_410("n")]
		public new string prop_1 { get; private set; }

		// Token: 0x040006C3 RID: 1731
		[CompilerGenerated]
		private string field_0;
	}
}
