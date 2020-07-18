using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001C8 RID: 456
	internal class Class_340 : Class_329
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00047174 File Offset: 0x00045374
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x0004717C File Offset: 0x0004537C
		public Class_337 prop_0 { get; set; }

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00047188 File Offset: 0x00045388
		public virtual IEnumerable<Class_361> lmethod_2298(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 class_ in arg_0)
			{
				foreach (Class_361 class_2 in ((IEnumerable<Class_361>)class_))
				{
					if (this.prop_0.kmethod_2287(class_2))
					{
						yield return class_2;
					}
				}
			}
			yield break;
		}

		// Token: 0x04000841 RID: 2113
		[CompilerGenerated]
		private Class_337 field_0;
	}
}
