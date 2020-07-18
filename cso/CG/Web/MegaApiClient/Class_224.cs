using System;
using System.Runtime.CompilerServices;

namespace CG.Web.MegaApiClient
{
	// Token: 0x0200012B RID: 299
	public class Class_224 : Exception
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x000399D2 File Offset: 0x00037BD2
		internal Class_224(Class_227 arg_0)
		{
			this.prop_0 = arg_0;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000399E1 File Offset: 0x00037BE1
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x000399E9 File Offset: 0x00037BE9
		public Class_227 prop_0 { get; private set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000399F2 File Offset: 0x00037BF2
		public virtual string prop_1
		{
			get
			{
				return string.Format("API response: {0}", this.prop_0);
			}
		}

		// Token: 0x04000614 RID: 1556
		[CompilerGenerated]
		private Class_227 field_0;
	}
}
