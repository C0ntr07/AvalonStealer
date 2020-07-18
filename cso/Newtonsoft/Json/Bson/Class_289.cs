using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200018F RID: 399
	internal class Class_289 : Class_287, IEnumerable, IEnumerable<Class_287>
	{
		// Token: 0x06000B28 RID: 2856 RVA: 0x0004070E File Offset: 0x0003E90E
		public void lmethod_1958(Class_287 arg_0)
		{
			this.field_0.Add(arg_0);
			arg_0.prop_1 = this;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00040723 File Offset: 0x0003E923
		public virtual Class_295 prop_0
		{
			get
			{
				return Class_295.Array;
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00040726 File Offset: 0x0003E926
		public IEnumerator<Class_287> smethod_1960()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00040738 File Offset: 0x0003E938
		IEnumerator IEnumerable.xmethod_1961()
		{
			return this.smethod_1960();
		}

		// Token: 0x04000763 RID: 1891
		private readonly List<Class_287> field_0 = new List<Class_287>();
	}
}
