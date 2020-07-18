using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200005F RID: 95
	public class Class_72
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000F29C File Offset: 0x0000D49C
		public Class_72(string str_0)
		{
			int num = int.Parse(str_0.Substring(2, 2), NumberStyles.HexNumber) * 2;
			this.field_0 = str_0.Substring(6, num);
			int num2 = str_0.Length - (6 + num + 36);
			this.field_1 = str_0.Substring(6 + num + 36, num2);
			this.field_2 = str_0.Substring(6 + num + 4 + num2);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000F312 File Offset: 0x0000D512
		public string prop_0 { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000F326 File Offset: 0x0000D526
		public string prop_1 { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000F33A File Offset: 0x0000D53A
		public string prop_2 { get; }

		// Token: 0x0400011F RID: 287
		[CompilerGenerated]
		private readonly string field_0;

		// Token: 0x04000120 RID: 288
		[CompilerGenerated]
		private readonly string field_1;

		// Token: 0x04000121 RID: 289
		[CompilerGenerated]
		private readonly string field_2;
	}
}
