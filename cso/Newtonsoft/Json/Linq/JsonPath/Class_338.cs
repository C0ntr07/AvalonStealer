using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001C6 RID: 454
	internal class Class_338 : Class_337
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00046ECD File Offset: 0x000450CD
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00046ED5 File Offset: 0x000450D5
		public new List<Class_337> prop_0 { get; set; }

		// Token: 0x06000CDA RID: 3290 RVA: 0x00046EDE File Offset: 0x000450DE
		public Class_338()
		{
			this.prop_0 = new List<Class_337>();
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00046EF4 File Offset: 0x000450F4
		public virtual bool smethod_2290(Class_361 arg_0)
		{
			switch (base.prop_0)
			{
			case Class_336.And:
				foreach (Class_337 class_ in this.prop_0)
				{
					if (!class_.kmethod_2287(arg_0))
					{
						return false;
					}
				}
				return true;
			case Class_336.Or:
				foreach (Class_337 class_2 in this.prop_0)
				{
					if (class_2.kmethod_2287(arg_0))
					{
						return true;
					}
				}
				return false;
			default:
				throw new ArgumentOutOfRangeException();
			}
			bool result;
			return result;
		}

		// Token: 0x0400083E RID: 2110
		[CompilerGenerated]
		private List<Class_337> field_0;
	}
}
