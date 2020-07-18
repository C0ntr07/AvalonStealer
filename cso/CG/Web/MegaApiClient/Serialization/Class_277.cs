using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000177 RID: 375
	[DebuggerDisplay("Id: {Id} / Key: {Key}")]
	internal class Class_277
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x0003DAB2 File Offset: 0x0003BCB2
		public Class_277(string str_0, string str_1)
		{
			this.prop_0 = str_0;
			this.prop_1 = str_1;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003DAC8 File Offset: 0x0003BCC8
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
		[Class_410("h")]
		public string prop_0 { get; private set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0003DAD9 File Offset: 0x0003BCD9
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0003DAE1 File Offset: 0x0003BCE1
		[Class_410("k")]
		public string prop_1 { get; private set; }

		// Token: 0x040006F2 RID: 1778
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006F3 RID: 1779
		[CompilerGenerated]
		private string field_1;
	}
}
