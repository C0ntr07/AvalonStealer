using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001FE RID: 510
	public class Class_382 : IEqualityComparer<Class_361>
	{
		// Token: 0x06000F75 RID: 3957 RVA: 0x0004FB9A File Offset: 0x0004DD9A
		public bool lmethod_2798(Class_361 arg_0, Class_361 arg_1)
		{
			return Class_361.xmethod_2451(arg_0, arg_1);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0004FBA3 File Offset: 0x0004DDA3
		public int pmethod_2799(Class_361 arg_0)
		{
			if (arg_0 == null)
			{
				return 0;
			}
			return arg_0.dmethod_2556();
		}
	}
}
