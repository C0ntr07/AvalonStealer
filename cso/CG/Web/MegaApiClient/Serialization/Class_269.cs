using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200016C RID: 364
	internal class Class_269 : Class_272
	{
		// Token: 0x06000A3E RID: 2622 RVA: 0x0003D5E8 File Offset: 0x0003B7E8
		public Class_269(string str_0) : base("us0")
		{
			this.prop_0 = str_0;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0003D5FC File Offset: 0x0003B7FC
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0003D604 File Offset: 0x0003B804
		[Class_410("user")]
		public new string prop_0 { get; private set; }

		// Token: 0x040006DF RID: 1759
		[CompilerGenerated]
		private string field_0;
	}
}
