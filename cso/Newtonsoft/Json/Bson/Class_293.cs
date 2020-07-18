using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000193 RID: 403
	internal class Class_293 : Class_287
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x000407CE File Offset: 0x0003E9CE
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x000407D6 File Offset: 0x0003E9D6
		public new Class_291 prop_0 { get; set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x000407DF File Offset: 0x0003E9DF
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x000407E7 File Offset: 0x0003E9E7
		public new Class_291 prop_1 { get; set; }

		// Token: 0x06000B3C RID: 2876 RVA: 0x000407F0 File Offset: 0x0003E9F0
		public Class_293(string str_0, string str_1)
		{
			this.prop_0 = new Class_291(str_0, false);
			this.prop_1 = new Class_291(str_1, false);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00040812 File Offset: 0x0003EA12
		public virtual Class_295 prop_2
		{
			get
			{
				return Class_295.Regex;
			}
		}

		// Token: 0x04000769 RID: 1897
		[CompilerGenerated]
		private Class_291 field_0;

		// Token: 0x0400076A RID: 1898
		[CompilerGenerated]
		private Class_291 field_1;
	}
}
