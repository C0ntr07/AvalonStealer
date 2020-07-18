using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000167 RID: 359
	internal class Class_264 : Class_272
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x0003D41E File Offset: 0x0003B61E
		public Class_264(string str_0, string str_1) : base("us")
		{
			this.prop_0 = str_0;
			this.prop_1 = str_1;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0003D439 File Offset: 0x0003B639
		public Class_264(string str_0, string str_1, string str_2) : base("us")
		{
			this.prop_0 = str_0;
			this.prop_1 = str_1;
			this.prop_2 = str_2;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0003D45B File Offset: 0x0003B65B
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0003D463 File Offset: 0x0003B663
		[Class_410("user")]
		public new string prop_0 { get; private set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0003D46C File Offset: 0x0003B66C
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0003D474 File Offset: 0x0003B674
		[Class_410("uh")]
		public new string prop_1 { get; private set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0003D47D File Offset: 0x0003B67D
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0003D485 File Offset: 0x0003B685
		[Class_410("mfa")]
		public string prop_2 { get; private set; }

		// Token: 0x040006D4 RID: 1748
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006D5 RID: 1749
		[CompilerGenerated]
		private string field_1;

		// Token: 0x040006D6 RID: 1750
		[CompilerGenerated]
		private string field_2;
	}
}
