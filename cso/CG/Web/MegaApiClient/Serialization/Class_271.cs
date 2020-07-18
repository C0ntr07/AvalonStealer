using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200016E RID: 366
	internal class Class_271 : Class_272
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x0003D62F File Offset: 0x0003B82F
		public Class_271(Class_233 arg_0, string str_0) : base("a")
		{
			this.prop_0 = arg_0.prop_0;
			this.prop_1 = str_0;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0003D64F File Offset: 0x0003B84F
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0003D657 File Offset: 0x0003B857
		[Class_410("n")]
		public new string prop_0 { get; private set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0003D660 File Offset: 0x0003B860
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0003D668 File Offset: 0x0003B868
		[Class_410("attr")]
		public new string prop_1 { get; set; }

		// Token: 0x040006E2 RID: 1762
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006E3 RID: 1763
		[CompilerGenerated]
		private string field_1;
	}
}
