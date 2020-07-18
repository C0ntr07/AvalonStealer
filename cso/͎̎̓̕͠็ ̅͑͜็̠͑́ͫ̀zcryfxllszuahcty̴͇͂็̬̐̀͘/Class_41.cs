using System;
using System.Runtime.CompilerServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000037 RID: 55
	public abstract class Class_41 : Class_44
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x000072E4 File Offset: 0x000054E4
		public Class_41(Class_44 arg_0, byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentNullException("iv");
			}
			if (arg_0 == null)
			{
				throw new ArgumentNullException("parameters");
			}
			this.field_1 = arg_0;
			this.field_0 = new byte[sayıInt_1];
			Array.Copy(byteDizi_0, sayıInt_0, this.field_0, 0, sayıInt_1);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000734A File Offset: 0x0000554A
		public Class_44 prop_0 { get; }

		// Token: 0x060000DA RID: 218 RVA: 0x0000735E File Offset: 0x0000555E
		public byte[] cmethod_114()
		{
			return (byte[])this.field_0.Clone();
		}

		// Token: 0x0400008A RID: 138
		private readonly byte[] field_0;

		// Token: 0x0400008B RID: 139
		[CompilerGenerated]
		private readonly Class_44 field_1;
	}
}
