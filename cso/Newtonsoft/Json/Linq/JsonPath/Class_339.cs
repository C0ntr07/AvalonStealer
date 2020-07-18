using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001C7 RID: 455
	internal class Class_339 : Class_337
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00046FD8 File Offset: 0x000451D8
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00046FE0 File Offset: 0x000451E0
		public new List<Class_329> prop_0 { get; set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00046FE9 File Offset: 0x000451E9
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00046FF1 File Offset: 0x000451F1
		public Class_362 prop_1 { get; set; }

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00046FFC File Offset: 0x000451FC
		public virtual bool vmethod_2295(Class_361 arg_0)
		{
			IEnumerable<Class_361> enumerable = Class_335.cmethod_2284(this.prop_0, arg_0, false);
			foreach (Class_361 class_ in enumerable)
			{
				Class_362 class_2 = class_ as Class_362;
				switch (base.prop_0)
				{
				case Class_336.Equals:
					if (class_2 != null && class_2.kmethod_2607(this.prop_1))
					{
						return true;
					}
					break;
				case Class_336.NotEquals:
					if (class_2 != null && !class_2.kmethod_2607(this.prop_1))
					{
						return true;
					}
					break;
				case Class_336.Exists:
					return true;
				case Class_336.LessThan:
					if (class_2 != null && class_2.dmethod_2616(this.prop_1) < 0)
					{
						return true;
					}
					break;
				case Class_336.LessThanOrEquals:
					if (class_2 != null && class_2.dmethod_2616(this.prop_1) <= 0)
					{
						return true;
					}
					break;
				case Class_336.GreaterThan:
					if (class_2 != null && class_2.dmethod_2616(this.prop_1) > 0)
					{
						return true;
					}
					break;
				case Class_336.GreaterThanOrEquals:
					if (class_2 != null && class_2.dmethod_2616(this.prop_1) >= 0)
					{
						return true;
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
			}
			return false;
		}

		// Token: 0x0400083F RID: 2111
		[CompilerGenerated]
		private List<Class_329> field_0;

		// Token: 0x04000840 RID: 2112
		[CompilerGenerated]
		private Class_362 field_1;
	}
}
