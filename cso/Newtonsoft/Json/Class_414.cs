using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000221 RID: 545
	[Serializable]
	public class Class_414 : Class_318
	{
		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00055138 File Offset: 0x00053338
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00055140 File Offset: 0x00053340
		public int prop_0 { get; private set; }

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00055149 File Offset: 0x00053349
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00055151 File Offset: 0x00053351
		public int prop_1 { get; private set; }

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005515A File Offset: 0x0005335A
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00055162 File Offset: 0x00053362
		public string prop_2 { get; private set; }

		// Token: 0x060010E0 RID: 4320 RVA: 0x000550DF File Offset: 0x000532DF
		public Class_414()
		{
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000550E7 File Offset: 0x000532E7
		public Class_414(string str_0) : base(str_0)
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000550F0 File Offset: 0x000532F0
		public Class_414(string str_0, Exception arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000550FA File Offset: 0x000532FA
		public Class_414(SerializationInfo arg_0, StreamingContext arg_1) : base(arg_0, arg_1)
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0005516B File Offset: 0x0005336B
		internal Class_414(string str_0, Exception arg_0, string str_1, int sayıInt_0, int sayıInt_1) : base(str_0, arg_0)
		{
			this.prop_2 = str_1;
			this.prop_0 = sayıInt_0;
			this.prop_1 = sayıInt_1;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0005518C File Offset: 0x0005338C
		internal static Class_414 lmethod_3098(Class_285 arg_0, string str_0)
		{
			return Class_414.pmethod_3099(arg_0, str_0, null);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00055196 File Offset: 0x00053396
		internal static Class_414 pmethod_3099(Class_285 arg_0, string str_0, Exception arg_1)
		{
			return Class_414.smethod_3100(arg_0 as Class_353, arg_0.prop_13, str_0, arg_1);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x000551AC File Offset: 0x000533AC
		internal static Class_414 smethod_3100(Class_353 arg_0, string str_0, string str_1, Exception arg_1)
		{
			str_1 = Class_326.FormatMessage(arg_0, str_0, str_1);
			int sayıInt_;
			int sayıInt_2;
			if (arg_0 != null && arg_0.lmethod_2368())
			{
				sayıInt_ = arg_0.prop_0;
				sayıInt_2 = arg_0.prop_1;
			}
			else
			{
				sayıInt_ = 0;
				sayıInt_2 = 0;
			}
			return new Class_414(str_1, arg_1, str_0, sayıInt_, sayıInt_2);
		}

		// Token: 0x040009A6 RID: 2470
		[CompilerGenerated]
		private int field_0;

		// Token: 0x040009A7 RID: 2471
		[CompilerGenerated]
		private int field_1;

		// Token: 0x040009A8 RID: 2472
		[CompilerGenerated]
		private string field_2;
	}
}
