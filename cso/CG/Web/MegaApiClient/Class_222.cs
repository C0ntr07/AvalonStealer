using System;
using System.Runtime.CompilerServices;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000128 RID: 296
	public class Class_222 : EventArgs
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x00039593 File Offset: 0x00037793
		public Class_222(Uri arg_0, int sayıInt_0, TimeSpan arg_1, Class_227 arg_2, string str_0) : this(arg_0, sayıInt_0, arg_1, arg_2, str_0, null)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000395A3 File Offset: 0x000377A3
		public Class_222(Uri arg_0, int sayıInt_0, TimeSpan arg_1, Class_227 arg_2, Exception arg_3) : this(arg_0, sayıInt_0, arg_1, arg_2, null, arg_3)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000395B3 File Offset: 0x000377B3
		private Class_222(Uri arg_0, int sayıInt_0, TimeSpan arg_1, Class_227 arg_2, string str_0, Exception arg_3)
		{
			this.prop_0 = arg_0;
			this.prop_3 = sayıInt_0;
			this.prop_4 = arg_1;
			this.prop_1 = arg_2;
			this.prop_2 = str_0;
			this.prop_5 = arg_3;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000395E8 File Offset: 0x000377E8
		public Uri prop_0 { get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000395F0 File Offset: 0x000377F0
		public Class_227 prop_1 { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x000395F8 File Offset: 0x000377F8
		public string prop_2 { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00039600 File Offset: 0x00037800
		public int prop_3 { get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00039608 File Offset: 0x00037808
		public TimeSpan prop_4 { get; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00039610 File Offset: 0x00037810
		public Exception prop_5 { get; }

		// Token: 0x0400060A RID: 1546
		[CompilerGenerated]
		private readonly Uri field_0;

		// Token: 0x0400060B RID: 1547
		[CompilerGenerated]
		private readonly Class_227 field_1;

		// Token: 0x0400060C RID: 1548
		[CompilerGenerated]
		private readonly string field_2;

		// Token: 0x0400060D RID: 1549
		[CompilerGenerated]
		private readonly int field_3;

		// Token: 0x0400060E RID: 1550
		[CompilerGenerated]
		private readonly TimeSpan field_4;

		// Token: 0x0400060F RID: 1551
		[CompilerGenerated]
		private readonly Exception field_5;
	}
}
