using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001CA RID: 458
	internal class Class_341 : Class_329
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00047405 File Offset: 0x00045605
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0004740D File Offset: 0x0004560D
		public string prop_0 { get; set; }

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00047418 File Offset: 0x00045618
		public virtual IEnumerable<Class_361> xmethod_2301(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 class_ in arg_0)
			{
				if (this.prop_0 == null)
				{
					yield return class_;
				}
				Class_361 class_2 = class_;
				Class_361 class_3 = class_;
				for (;;)
				{
					if (class_3 != null && class_3.prop_4)
					{
						class_2 = class_3.prop_9;
					}
					else
					{
						while (class_2 != null && class_2 != class_ && class_2 == class_2.prop_1.prop_10)
						{
							class_2 = class_2.prop_1;
						}
						if (class_2 == null || class_2 == class_)
						{
							break;
						}
						class_2 = class_2.prop_5;
					}
					Class_427 class_4 = class_2 as Class_427;
					if (class_4 != null)
					{
						if (class_4.prop_1 == this.prop_0)
						{
							yield return class_4.prop_2;
						}
					}
					else if (this.prop_0 == null)
					{
						yield return class_2;
					}
					class_3 = (class_2 as Class_420);
				}
			}
			yield break;
		}

		// Token: 0x0400084C RID: 2124
		[CompilerGenerated]
		private string field_0;
	}
}
