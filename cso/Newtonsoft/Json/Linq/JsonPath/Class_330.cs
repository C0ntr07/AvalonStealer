using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001B9 RID: 441
	internal class Class_330 : Class_329
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000449BF File Offset: 0x00042BBF
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x000449C7 File Offset: 0x00042BC7
		public int? prop_0 { get; set; }

		// Token: 0x06000C79 RID: 3193 RVA: 0x000449D0 File Offset: 0x00042BD0
		public virtual IEnumerable<Class_361> pmethod_2249(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 class_ in arg_0)
			{
				if (this.prop_0 != null)
				{
					Class_361 class_2 = Class_329.dmethod_2246(class_, bool_0, this.prop_0.Value);
					if (class_2 != null)
					{
						yield return class_2;
					}
				}
				else if (class_ is Class_424 || class_ is Class_421)
				{
					foreach (Class_361 class_3 in ((IEnumerable<Class_361>)class_))
					{
						yield return class_3;
					}
				}
				else if (bool_0)
				{
					throw new Class_318("Index * not valid on {0}.".FormatWith(CultureInfo.InvariantCulture, class_.GetType().Name));
				}
			}
			yield break;
		}

		// Token: 0x040007E1 RID: 2017
		[CompilerGenerated]
		private int? field_0;
	}
}
