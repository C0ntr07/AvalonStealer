using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000186 RID: 390
	internal enum Class_283 : byte
	{
		// Token: 0x0400071B RID: 1819
		Binary,
		// Token: 0x0400071C RID: 1820
		Function,
		// Token: 0x0400071D RID: 1821
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x0400071E RID: 1822
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x0400071F RID: 1823
		Uuid,
		// Token: 0x04000720 RID: 1824
		Md5,
		// Token: 0x04000721 RID: 1825
		UserDefined = 128
	}
}
