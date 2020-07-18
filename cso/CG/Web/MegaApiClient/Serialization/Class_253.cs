using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200015A RID: 346
	internal class Class_253 : Class_272
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x0003CC25 File Offset: 0x0003AE25
		public Class_253(string str_0, string str_1) : base("up")
		{
			this.prop_0 = str_0;
			this.prop_1 = str_1;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0003CC40 File Offset: 0x0003AE40
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[Class_410("k")]
		public new string prop_0 { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0003CC51 File Offset: 0x0003AE51
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0003CC59 File Offset: 0x0003AE59
		[Class_410("ts")]
		public new string prop_1 { get; set; }

		// Token: 0x040006B1 RID: 1713
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006B2 RID: 1714
		[CompilerGenerated]
		private string field_1;
	}
}
