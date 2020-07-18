using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000162 RID: 354
	internal class Class_260 : Class_272
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		public Class_260(Class_233 arg_0) : base("l")
		{
			this.prop_0 = arg_0.prop_0;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0003D1F1 File Offset: 0x0003B3F1
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x0003D1F9 File Offset: 0x0003B3F9
		[Class_410("n")]
		public new string prop_0 { get; private set; }

		// Token: 0x040006C8 RID: 1736
		[CompilerGenerated]
		private string field_0;
	}
}
