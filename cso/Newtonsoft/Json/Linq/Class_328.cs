using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001B7 RID: 439
	public class Class_328
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000448CC File Offset: 0x00042ACC
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x000448D4 File Offset: 0x00042AD4
		public Class_342 prop_0
		{
			get
			{
				return this.field_0;
			}
			set
			{
				if (value < Class_342.Concat || value > Class_342.Merge)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.field_0 = value;
			}
		}

		// Token: 0x040007E0 RID: 2016
		private Class_342 field_0;
	}
}
