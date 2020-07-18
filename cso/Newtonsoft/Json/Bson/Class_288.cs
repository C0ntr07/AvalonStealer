using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200018E RID: 398
	internal class Class_288 : Class_287, IEnumerable, IEnumerable<Class_294>
	{
		// Token: 0x06000B23 RID: 2851 RVA: 0x000406A4 File Offset: 0x0003E8A4
		public void cmethod_1954(string str_0, Class_287 arg_0)
		{
			this.field_0.Add(new Class_294
			{
				prop_0 = new Class_291(str_0, false),
				prop_1 = arg_0
			});
			arg_0.prop_1 = this;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x000406DE File Offset: 0x0003E8DE
		public virtual Class_295 prop_0
		{
			get
			{
				return Class_295.Object;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000406E1 File Offset: 0x0003E8E1
		public IEnumerator<Class_294> dmethod_1956()
		{
			return this.field_0.GetEnumerator();
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x000406F3 File Offset: 0x0003E8F3
		IEnumerator IEnumerable.kmethod_1957()
		{
			return this.dmethod_1956();
		}

		// Token: 0x04000762 RID: 1890
		private readonly List<Class_294> field_0 = new List<Class_294>();
	}
}
