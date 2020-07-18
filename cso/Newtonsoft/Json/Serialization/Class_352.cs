using System;
using System.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001D8 RID: 472
	public class Class_352 : Class_348
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x000482C0 File Offset: 0x000464C0
		public Class_352(object obje_0)
		{
			Class_517.ArgumentNotNull(obje_0, "attributeProvider");
			this.field_0 = obje_0;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x000482DA File Offset: 0x000464DA
		public IList<Attribute> dmethod_2366(bool bool_0)
		{
			return Class_514.GetAttributes(this.field_0, null, bool_0);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x000482E9 File Offset: 0x000464E9
		public IList<Attribute> kmethod_2367(Type arg_0, bool bool_0)
		{
			return Class_514.GetAttributes(this.field_0, arg_0, bool_0);
		}

		// Token: 0x04000884 RID: 2180
		private readonly object field_0;
	}
}
