using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000178 RID: 376
	internal class Class_278 : Class_272
	{
		// Token: 0x06000A7A RID: 2682 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		public Class_278(Class_233 arg_0, byte[] byteDizi_0, IEnumerable<Class_233> arg_1) : base("s2")
		{
			this.prop_0 = arg_0.prop_0;
			this.prop_2 = new object[]
			{
				new Class_218<int, string>(0, "EXP")
			};
			Class_234 class_ = (Class_234)arg_0;
			byte[] array = class_.prop_1;
			if (array == null)
			{
				array = Class_223.dmethod_1476();
			}
			this.prop_4 = Class_223.smethod_1470(array, byteDizi_0).ToBase64();
			if (class_.prop_1 == null)
			{
				this.prop_3 = new Class_275(arg_0.prop_0);
				this.prop_3.vmethod_1815(arg_0.prop_0, class_.prop_4, array);
				foreach (Class_233 class_2 in this.gmethod_1823(arg_1.ToArray<Class_233>(), arg_0))
				{
					this.prop_3.vmethod_1815(class_2.prop_0, ((Class_234)class_2).prop_4, array);
				}
			}
			byte[] byteDizi_ = (arg_0.prop_0 + arg_0.prop_0).ToBytes();
			this.prop_1 = Class_223.smethod_1470(byteDizi_, byteDizi_0).ToBase64();
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0003DC1C File Offset: 0x0003BE1C
		private IEnumerable<Class_233> gmethod_1823(Class_233[] arg_0, Class_233 arg_1)
		{
			using (IEnumerator<Class_233> enumerator = arg_0.Where(new Func<Class_233, bool>(Class_278.NClass_1.field_3.nmethod_4)).GetEnumerator())
			{
				IL_F9:
				while (enumerator.MoveNext())
				{
					Class_233 class_ = enumerator.Current;
					Class_278.NClass_0 nclass_ = new Class_278.NClass_0();
					nclass_.field_2 = class_.prop_0;
					for (;;)
					{
						Class_278.NClass_0 nclass_2 = nclass_;
						Class_233 class_2 = arg_0.FirstOrDefault(new Func<Class_233, bool>(nclass_.nmethod_1));
						nclass_2.field_2 = ((class_2 != null) ? class_2.prop_0 : null);
						if (nclass_.field_2 == arg_1.prop_0)
						{
							break;
						}
						if (nclass_.field_2 == null)
						{
							goto IL_F9;
						}
					}
					yield return class_;
				}
			}
			IEnumerator<Class_233> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0003DC33 File Offset: 0x0003BE33
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x0003DC3B File Offset: 0x0003BE3B
		[Class_410("n")]
		public new string prop_0 { get; private set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0003DC44 File Offset: 0x0003BE44
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0003DC4C File Offset: 0x0003BE4C
		[Class_410("ha")]
		public new string prop_1 { get; private set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0003DC55 File Offset: 0x0003BE55
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0003DC5D File Offset: 0x0003BE5D
		[Class_410("s")]
		public object[] prop_2 { get; private set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0003DC66 File Offset: 0x0003BE66
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0003DC6E File Offset: 0x0003BE6E
		[Class_410("cr")]
		public Class_275 prop_3 { get; private set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0003DC77 File Offset: 0x0003BE77
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0003DC7F File Offset: 0x0003BE7F
		[Class_410("ok")]
		public string prop_4 { get; private set; }

		// Token: 0x040006F4 RID: 1780
		[CompilerGenerated]
		private string field_0;

		// Token: 0x040006F5 RID: 1781
		[CompilerGenerated]
		private string field_1;

		// Token: 0x040006F6 RID: 1782
		[CompilerGenerated]
		private object[] field_2;

		// Token: 0x040006F7 RID: 1783
		[CompilerGenerated]
		private Class_275 field_3;

		// Token: 0x040006F8 RID: 1784
		[CompilerGenerated]
		private string field_4;

		// Token: 0x02000179 RID: 377
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000A86 RID: 2694 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06000A87 RID: 2695 RVA: 0x0003DC88 File Offset: 0x0003BE88
			internal bool nmethod_1(Class_233 arg_0)
			{
				return arg_0.prop_0 == this.field_2;
			}

			// Token: 0x040006F9 RID: 1785
			public string field_2;
		}

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_1
		{
			// Token: 0x06000A88 RID: 2696 RVA: 0x0003DC9B File Offset: 0x0003BE9B
			private static void nmethod_2()
			{
				Class_278.NClass_1.field_3 = new Class_278.NClass_1();
			}

			// Token: 0x06000A89 RID: 2697 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_3()
			{
				base..ctor();
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x0003DCA7 File Offset: 0x0003BEA7
			internal bool nmethod_4(Class_233 arg_0)
			{
				return arg_0.prop_1 == Class_235.Directory || arg_0.prop_1 == Class_235.File;
			}

			// Token: 0x040006FA RID: 1786
			public static readonly Class_278.NClass_1 field_3;

			// Token: 0x040006FB RID: 1787
			public static Func<Class_233, bool> field_4;
		}
	}
}
