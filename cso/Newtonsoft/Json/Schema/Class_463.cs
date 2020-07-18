using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000269 RID: 617
	[Flags]
	public enum Class_463
	{
		// Token: 0x04000B28 RID: 2856
		None = 0,
		// Token: 0x04000B29 RID: 2857
		String = 1,
		// Token: 0x04000B2A RID: 2858
		Float = 2,
		// Token: 0x04000B2B RID: 2859
		Integer = 4,
		// Token: 0x04000B2C RID: 2860
		Boolean = 8,
		// Token: 0x04000B2D RID: 2861
		Object = 16,
		// Token: 0x04000B2E RID: 2862
		Array = 32,
		// Token: 0x04000B2F RID: 2863
		Null = 64,
		// Token: 0x04000B30 RID: 2864
		Any = 127
	}
}
