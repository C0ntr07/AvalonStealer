using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020001BB RID: 443
	internal class Class_331 : Class_329
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00044D31 File Offset: 0x00042F31
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00044D39 File Offset: 0x00042F39
		public List<int> prop_0 { get; set; }

		// Token: 0x06000C87 RID: 3207 RVA: 0x00044D44 File Offset: 0x00042F44
		public virtual IEnumerable<Class_361> tmethod_2252(IEnumerable<Class_361> arg_0, bool bool_0)
		{
			foreach (Class_361 arg_ in arg_0)
			{
				foreach (int sayıInt_ in this.prop_0)
				{
					Class_361 class_ = Class_329.dmethod_2246(arg_, bool_0, sayıInt_);
					if (class_ != null)
					{
						yield return class_;
					}
				}
			}
			yield break;
		}

		// Token: 0x040007EF RID: 2031
		[CompilerGenerated]
		private List<int> field_0;
	}
}
