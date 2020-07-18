using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200014B RID: 331
	public class Class_244
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x0003BE68 File Offset: 0x0003A068
		public Class_244(string str_0 = "axhQiYyQ", bool bool_0 = true, Class_244.NClass_0 arg_0 = null, int sayıInt_0 = 65536, int sayıInt_1 = 1048576)
		{
			this.prop_0 = str_0;
			this.prop_1 = bool_0;
			this.prop_2 = (arg_0 ?? new Class_244.NClass_0(this.dmethod_1656));
			this.prop_3 = sayıInt_0;
			this.prop_4 = sayıInt_1;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
		public string prop_0 { get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		public bool prop_1 { get; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0003BEB8 File Offset: 0x0003A0B8
		public Class_244.NClass_0 prop_2 { get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0003BEC0 File Offset: 0x0003A0C0
		public int prop_3 { get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0003BEC8 File Offset: 0x0003A0C8
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0003BED0 File Offset: 0x0003A0D0
		public int prop_4 { get; internal set; }

		// Token: 0x06000970 RID: 2416 RVA: 0x0003BEDC File Offset: 0x0003A0DC
		private bool dmethod_1656(int sayıInt_0, out TimeSpan arg_0)
		{
			if (sayıInt_0 > 17)
			{
				arg_0 = default(TimeSpan);
				return false;
			}
			int num = Enumerable.Range(0, sayıInt_0).Aggregate(0, new Func<int, int, int>(Class_244.NClass_1.field_2.nmethod_6));
			arg_0 = TimeSpan.FromMilliseconds((double)num);
			return true;
		}

		// Token: 0x04000675 RID: 1653
		public const string field_0 = "axhQiYyQ";

		// Token: 0x04000676 RID: 1654
		public const bool field_1 = true;

		// Token: 0x04000677 RID: 1655
		public const int field_2 = 17;

		// Token: 0x04000678 RID: 1656
		public const int field_3 = 100;

		// Token: 0x04000679 RID: 1657
		public const float field_4 = 1.5f;

		// Token: 0x0400067A RID: 1658
		public const int field_5 = 65536;

		// Token: 0x0400067B RID: 1659
		public const int field_6 = 1048576;

		// Token: 0x0400067C RID: 1660
		[CompilerGenerated]
		private readonly string field_7;

		// Token: 0x0400067D RID: 1661
		[CompilerGenerated]
		private readonly bool field_8;

		// Token: 0x0400067E RID: 1662
		[CompilerGenerated]
		private readonly Class_244.NClass_0 field_9;

		// Token: 0x0400067F RID: 1663
		[CompilerGenerated]
		private readonly int field_10;

		// Token: 0x04000680 RID: 1664
		[CompilerGenerated]
		private int field_11;

		// Token: 0x0200014C RID: 332
		public delegate NClass_0();

		// Token: 0x0200014D RID: 333
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_1
		{
			// Token: 0x06000975 RID: 2421 RVA: 0x0003BF38 File Offset: 0x0003A138
			private static void nmethod_4()
			{
				Class_244.NClass_1.field_2 = new Class_244.NClass_1();
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_5()
			{
				base..ctor();
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x0003BF44 File Offset: 0x0003A144
			internal int nmethod_6(int sayıInt_0, int sayıInt_1)
			{
				return (int)((sayıInt_0 == 0) ? 100f : ((float)sayıInt_0 * 1.5f));
			}

			// Token: 0x04000681 RID: 1665
			public static readonly Class_244.NClass_1 field_2;

			// Token: 0x04000682 RID: 1666
			public static Func<int, int, int> field_3;
		}
	}
}
