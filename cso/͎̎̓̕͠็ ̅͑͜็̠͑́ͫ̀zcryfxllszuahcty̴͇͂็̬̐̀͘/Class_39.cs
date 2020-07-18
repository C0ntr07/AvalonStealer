using System;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000035 RID: 53
	public class Class_39 : Class_44
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x000071B6 File Offset: 0x000053B6
		public Class_39(byte[] byteDizi_0)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			this.field_0 = (byte[])byteDizi_0.Clone();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000071EC File Offset: 0x000053EC
		public byte[] tmethod_112()
		{
			return (byte[])this.field_0.Clone();
		}

		// Token: 0x04000089 RID: 137
		private readonly byte[] field_0;
	}
}
