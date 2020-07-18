using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000042 RID: 66
	public static class Class_48
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00009296 File Offset: 0x00007496
		public static bool IsNotNull<T>(this T data)
		{
			return data != null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000092AD File Offset: 0x000074AD
		public static T IsNull<T>(this T value) where T : class
		{
			if (value == null)
			{
				return Activator.CreateInstance<T>();
			}
			return value;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000092CD File Offset: 0x000074CD
		public static T IsNull<T>(this T value, T def) where T : class
		{
			if (value != null)
			{
				return value;
			}
			if (def == null)
			{
				return Activator.CreateInstance<T>();
			}
			return def;
		}
	}
}
