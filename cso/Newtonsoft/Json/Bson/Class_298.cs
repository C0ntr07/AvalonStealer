using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000199 RID: 409
	public class Class_298
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00042555 File Offset: 0x00040755
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x0004255D File Offset: 0x0004075D
		public byte[] prop_0 { get; private set; }

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00042566 File Offset: 0x00040766
		public Class_298(byte[] byteDizi_0)
		{
			Class_517.ArgumentNotNull(byteDizi_0, "value");
			if (byteDizi_0.Length != 12)
			{
				throw new ArgumentException("An ObjectId must be 12 bytes", "value");
			}
			this.prop_0 = byteDizi_0;
		}

		// Token: 0x0400079E RID: 1950
		[CompilerGenerated]
		private byte[] field_0;
	}
}
