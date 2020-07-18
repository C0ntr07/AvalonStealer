using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000250 RID: 592
	public class Class_442 : Class_441
	{
		// Token: 0x060013DA RID: 5082 RVA: 0x0005E222 File Offset: 0x0005C422
		public Class_442() : base(true)
		{
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005E22B File Offset: 0x0005C42B
		protected internal virtual string kmethod_3597(string str_0)
		{
			return Class_515.ToCamelCase(str_0);
		}
	}
}
