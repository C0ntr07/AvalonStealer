using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000190 RID: 400
	internal class Class_290 : Class_287
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x00040753 File Offset: 0x0003E953
		public Class_290(object obje_0, Class_295 arg_0)
		{
			this.field_0 = obje_0;
			this.field_1 = arg_0;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00040769 File Offset: 0x0003E969
		public new object prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00040771 File Offset: 0x0003E971
		public virtual Class_295 prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x04000764 RID: 1892
		private readonly object field_0;

		// Token: 0x04000765 RID: 1893
		private readonly Class_295 field_1;
	}
}
