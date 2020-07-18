using System;
using System.Runtime.CompilerServices;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000163 RID: 355
	internal class Class_261 : Class_272
	{
		// Token: 0x06000A0C RID: 2572 RVA: 0x0003D202 File Offset: 0x0003B402
		public Class_261(string str_0 = null) : base("f")
		{
			this.prop_0 = 1;
			if (str_0 != null)
			{
				base.prop_1["n"] = str_0;
				this.prop_1 = 1;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003D234 File Offset: 0x0003B434
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x0003D23C File Offset: 0x0003B43C
		public new int prop_0 { get; private set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003D245 File Offset: 0x0003B445
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x0003D24D File Offset: 0x0003B44D
		public new int prop_1 { get; private set; }

		// Token: 0x040006C9 RID: 1737
		[CompilerGenerated]
		private int field_0;

		// Token: 0x040006CA RID: 1738
		[CompilerGenerated]
		private int field_1;
	}
}
