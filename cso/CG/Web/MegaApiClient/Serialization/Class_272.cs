using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200016F RID: 367
	internal abstract class Class_272
	{
		// Token: 0x06000A4B RID: 2635 RVA: 0x0003D671 File Offset: 0x0003B871
		protected Class_272(string str_0)
		{
			this.prop_0 = str_0;
			this.prop_1 = new Dictionary<string, string>();
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0003D68B File Offset: 0x0003B88B
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x0003D693 File Offset: 0x0003B893
		[Class_410("a")]
		public string prop_0 { get; private set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0003D69C File Offset: 0x0003B89C
		[Class_411]
		public Dictionary<string, string> prop_1 { get; }

		// Token: 0x040006E4 RID: 1764
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006E5 RID: 1765
		[CompilerGenerated]
		private readonly Dictionary<string, string> field_1;
	}
}
