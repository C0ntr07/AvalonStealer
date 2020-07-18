using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000164 RID: 356
	internal class Class_262
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x0003D256 File Offset: 0x0003B456
		public Class_262(byte[] byteDizi_0)
		{
			this.field_0 = byteDizi_0;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0003D265 File Offset: 0x0003B465
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0003D26D File Offset: 0x0003B46D
		public Class_241[] prop_0 { get; private set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0003D276 File Offset: 0x0003B476
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0003D27E File Offset: 0x0003B47E
		public Class_241[] prop_1 { get; private set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003D287 File Offset: 0x0003B487
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x0003D28F File Offset: 0x0003B48F
		[Class_410("f")]
		public Class_363 prop_2 { get; private set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003D298 File Offset: 0x0003B498
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x0003D2A0 File Offset: 0x0003B4A0
		[Class_410("ok")]
		public List<Class_277> prop_3
		{
			get
			{
				return this.field_1;
			}
			private set
			{
				this.field_1 = value;
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0003D2AC File Offset: 0x0003B4AC
		[OnDeserialized]
		public void gmethod_1773(StreamingContext arg_0)
		{
			Class_241[] source = Class_416.DeserializeObject<Class_241[]>(this.prop_2.ToString(), new Class_299[]
			{
				new Class_268(this.field_0, ref this.field_1)
			});
			this.prop_1 = source.Where(new Func<Class_241, bool>(Class_262.NClass_0.field_2.nmethod_2)).ToArray<Class_241>();
			this.prop_0 = source.Where(new Func<Class_241, bool>(Class_262.NClass_0.field_2.nmethod_3)).ToArray<Class_241>();
		}

		// Token: 0x040006CB RID: 1739
		private readonly byte[] field_0;

		// Token: 0x040006CC RID: 1740
		private List<Class_277> field_1;

		// Token: 0x040006CD RID: 1741
		[CompilerGenerated]
		private Class_241[] field_2;

		// Token: 0x040006CE RID: 1742
		[CompilerGenerated]
		private Class_241[] field_3;

		// Token: 0x040006CF RID: 1743
		[CompilerGenerated]
		private Class_363 field_4;

		// Token: 0x02000165 RID: 357
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_0
		{
			// Token: 0x06000A1B RID: 2587 RVA: 0x0003D34A File Offset: 0x0003B54A
			private static void nmethod_0()
			{
				Class_262.NClass_0.field_2 = new Class_262.NClass_0();
			}

			// Token: 0x06000A1C RID: 2588 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x06000A1D RID: 2589 RVA: 0x0003D356 File Offset: 0x0003B556
			internal bool nmethod_2(Class_241 arg_0)
			{
				return arg_0.prop_10;
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x0003D35E File Offset: 0x0003B55E
			internal bool nmethod_3(Class_241 arg_0)
			{
				return !arg_0.prop_10;
			}

			// Token: 0x040006D0 RID: 1744
			public static readonly Class_262.NClass_0 field_2;

			// Token: 0x040006D1 RID: 1745
			public static Func<Class_241, bool> field_3;

			// Token: 0x040006D2 RID: 1746
			public static Func<Class_241, bool> field_4;
		}
	}
}
