using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000157 RID: 343
	internal class Class_252 : Class_229
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0003CB41 File Offset: 0x0003AD41
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0003CB49 File Offset: 0x0003AD49
		[Class_410("mstrg")]
		public long prop_0 { get; private set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0003CB52 File Offset: 0x0003AD52
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0003CB5A File Offset: 0x0003AD5A
		[Class_410("cstrg")]
		public long prop_1 { get; private set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0003CB63 File Offset: 0x0003AD63
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0003CB6B File Offset: 0x0003AD6B
		[Class_410("cstrgn")]
		private Dictionary<string, long[]> prop_2 { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0003CB74 File Offset: 0x0003AD74
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0003CB7C File Offset: 0x0003AD7C
		public IEnumerable<Class_230> prop_3 { get; private set; }

		// Token: 0x060009CA RID: 2506 RVA: 0x0003CB85 File Offset: 0x0003AD85
		[OnDeserialized]
		public void cmethod_1724(StreamingContext arg_0)
		{
			this.prop_3 = this.prop_2.Select(new Func<KeyValuePair<string, long[]>, Class_230>(Class_252.NClass_1.field_4.nmethod_7));
		}

		// Token: 0x040006A7 RID: 1703
		[CompilerGenerated]
		private long field_0;

		// Token: 0x040006A8 RID: 1704
		[CompilerGenerated]
		private long field_1;

		// Token: 0x040006A9 RID: 1705
		[CompilerGenerated]
		private Dictionary<string, long[]> field_2;

		// Token: 0x040006AA RID: 1706
		[CompilerGenerated]
		private IEnumerable<Class_230> field_3;

		// Token: 0x02000158 RID: 344
		private class NClass_0 : Class_230
		{
			// Token: 0x060009CC RID: 2508 RVA: 0x0003CBBA File Offset: 0x0003ADBA
			public void nmethod_0(string str_0, long[] uıntSayıDizi_0)
			{
				base..ctor();
				this.field_0 = str_0;
				this.field_1 = uıntSayıDizi_0[0];
				this.field_2 = uıntSayıDizi_0[1];
				this.field_3 = uıntSayıDizi_0[2];
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x060009CD RID: 2509 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
			public string nprop_0 { get; }

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x060009CE RID: 2510 RVA: 0x0003CBEC File Offset: 0x0003ADEC
			public long nprop_1 { get; }

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x060009CF RID: 2511 RVA: 0x0003CBF4 File Offset: 0x0003ADF4
			public long nprop_2 { get; }

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003CBFC File Offset: 0x0003ADFC
			public long nprop_3 { get; }

			// Token: 0x040006AB RID: 1707
			[CompilerGenerated]
			private readonly string field_0;

			// Token: 0x040006AC RID: 1708
			[CompilerGenerated]
			private readonly long field_1;

			// Token: 0x040006AD RID: 1709
			[CompilerGenerated]
			private readonly long field_2;

			// Token: 0x040006AE RID: 1710
			[CompilerGenerated]
			private readonly long field_3;
		}

		// Token: 0x02000159 RID: 345
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_1
		{
			// Token: 0x060009D1 RID: 2513 RVA: 0x0003CC04 File Offset: 0x0003AE04
			private static void nmethod_5()
			{
				Class_252.NClass_1.field_4 = new Class_252.NClass_1();
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_6()
			{
				base..ctor();
			}

			// Token: 0x060009D3 RID: 2515 RVA: 0x0003CC10 File Offset: 0x0003AE10
			internal Class_230 nmethod_7(KeyValuePair<string, long[]> arg_0)
			{
				return new Class_252.NClass_0(arg_0.Key, arg_0.Value);
			}

			// Token: 0x040006AF RID: 1711
			public static readonly Class_252.NClass_1 field_4;

			// Token: 0x040006B0 RID: 1712
			public static Func<KeyValuePair<string, long[]>, Class_230> field_5;
		}
	}
}
