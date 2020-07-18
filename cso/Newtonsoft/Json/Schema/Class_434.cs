using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000243 RID: 579
	internal class Class_434
	{
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0005B7CE File Offset: 0x000599CE
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0005B7D6 File Offset: 0x000599D6
		public string prop_0 { get; private set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0005B7DF File Offset: 0x000599DF
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x0005B7E7 File Offset: 0x000599E7
		public ReadOnlyCollection<Class_459> prop_1 { get; private set; }

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0005B7F0 File Offset: 0x000599F0
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x0005B7F8 File Offset: 0x000599F8
		public Dictionary<string, Class_434> prop_2 { get; private set; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0005B801 File Offset: 0x00059A01
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x0005B809 File Offset: 0x00059A09
		public Dictionary<string, Class_434> prop_3 { get; private set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005B812 File Offset: 0x00059A12
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x0005B81A File Offset: 0x00059A1A
		public List<Class_434> prop_4 { get; private set; }

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0005B823 File Offset: 0x00059A23
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0005B82B File Offset: 0x00059A2B
		public Class_434 prop_5 { get; set; }

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0005B834 File Offset: 0x00059A34
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0005B83C File Offset: 0x00059A3C
		public Class_434 prop_6 { get; set; }

		// Token: 0x06001374 RID: 4980 RVA: 0x0005B848 File Offset: 0x00059A48
		public Class_434(Class_459 arg_0)
		{
			this.prop_1 = new ReadOnlyCollection<Class_459>(new Class_459[]
			{
				arg_0
			});
			this.prop_2 = new Dictionary<string, Class_434>();
			this.prop_3 = new Dictionary<string, Class_434>();
			this.prop_4 = new List<Class_434>();
			this.prop_0 = Class_434.dmethod_3526(this.prop_1);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0005B8A8 File Offset: 0x00059AA8
		private Class_434(Class_434 arg_0, Class_459 arg_1)
		{
			this.prop_1 = new ReadOnlyCollection<Class_459>(arg_0.prop_1.Union(new Class_459[]
			{
				arg_1
			}).ToList<Class_459>());
			this.prop_2 = new Dictionary<string, Class_434>(arg_0.prop_2);
			this.prop_3 = new Dictionary<string, Class_434>(arg_0.prop_3);
			this.prop_4 = new List<Class_434>(arg_0.prop_4);
			this.prop_5 = arg_0.prop_5;
			this.prop_6 = arg_0.prop_6;
			this.prop_0 = Class_434.dmethod_3526(this.prop_1);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0005B942 File Offset: 0x00059B42
		public Class_434 vmethod_3525(Class_459 arg_0)
		{
			return new Class_434(this, arg_0);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0005B94C File Offset: 0x00059B4C
		public static string dmethod_3526(IEnumerable<Class_459> arg_0)
		{
			string separator = "-";
			if (Class_434.field_7 == null)
			{
				Class_434.field_7 = new Func<Class_459, string>(Class_434.kmethod_3527);
			}
			IEnumerable<string> source = arg_0.Select(Class_434.field_7);
			if (Class_434.field_8 == null)
			{
				Class_434.field_8 = new Func<string, string>(Class_434.lmethod_3528);
			}
			return string.Join(separator, source.OrderBy(Class_434.field_8, StringComparer.Ordinal).ToArray<string>());
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0005B9B8 File Offset: 0x00059BB8
		[CompilerGenerated]
		private static string kmethod_3527(Class_459 arg_0)
		{
			return arg_0.prop_34;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0004FB80 File Offset: 0x0004DD80
		[CompilerGenerated]
		private static string lmethod_3528(string str_0)
		{
			return str_0;
		}

		// Token: 0x04000A4E RID: 2638
		[CompilerGenerated]
		private string field_0;

		// Token: 0x04000A4F RID: 2639
		[CompilerGenerated]
		private ReadOnlyCollection<Class_459> field_1;

		// Token: 0x04000A50 RID: 2640
		[CompilerGenerated]
		private Dictionary<string, Class_434> field_2;

		// Token: 0x04000A51 RID: 2641
		[CompilerGenerated]
		private Dictionary<string, Class_434> field_3;

		// Token: 0x04000A52 RID: 2642
		[CompilerGenerated]
		private List<Class_434> field_4;

		// Token: 0x04000A53 RID: 2643
		[CompilerGenerated]
		private Class_434 field_5;

		// Token: 0x04000A54 RID: 2644
		[CompilerGenerated]
		private Class_434 field_6;

		// Token: 0x04000A55 RID: 2645
		[CompilerGenerated]
		private static Func<Class_459, string> field_7;

		// Token: 0x04000A56 RID: 2646
		[CompilerGenerated]
		private static Func<string, string> field_8;
	}
}
