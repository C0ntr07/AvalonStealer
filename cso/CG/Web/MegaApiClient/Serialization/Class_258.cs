using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000160 RID: 352
	internal class Class_258 : Class_272
	{
		// Token: 0x060009FE RID: 2558 RVA: 0x0003D180 File Offset: 0x0003B380
		public Class_258(string str_0) : base("g")
		{
			this.prop_1 = str_0;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public new int prop_0
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0003D194 File Offset: 0x0003B394
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0003D19C File Offset: 0x0003B39C
		[Class_410("p")]
		public new string prop_1 { get; private set; }

		// Token: 0x040006C4 RID: 1732
		[CompilerGenerated]
		private string field_0;
	}
}
