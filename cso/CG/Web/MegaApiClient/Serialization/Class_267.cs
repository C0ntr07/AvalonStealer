using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200016A RID: 362
	internal class Class_267 : Class_272
	{
		// Token: 0x06000A35 RID: 2613 RVA: 0x0003D4DF File Offset: 0x0003B6DF
		public Class_267(Class_233 arg_0, Class_233 arg_1) : base("m")
		{
			this.prop_0 = arg_0.prop_0;
			this.prop_1 = arg_1.prop_0;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0003D504 File Offset: 0x0003B704
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x0003D50C File Offset: 0x0003B70C
		[Class_410("n")]
		public new string prop_0 { get; private set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0003D515 File Offset: 0x0003B715
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x0003D51D File Offset: 0x0003B71D
		[Class_410("t")]
		public new string prop_1 { get; private set; }

		// Token: 0x040006DB RID: 1755
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006DC RID: 1756
		[CompilerGenerated]
		private string field_1;
	}
}
