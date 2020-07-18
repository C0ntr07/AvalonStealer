using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020001EA RID: 490
	public class Class_363 : Class_362
	{
		// Token: 0x06000E9C RID: 3740 RVA: 0x0004D3FC File Offset: 0x0004B5FC
		public Class_363(Class_363 arg_0) : base(arg_0)
		{
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0004D405 File Offset: 0x0004B605
		public Class_363(object obje_0) : base(obje_0, Class_428.Raw)
		{
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0004D410 File Offset: 0x0004B610
		public static Class_363 gmethod_2633(Class_285 arg_0)
		{
			Class_363 result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				using (Class_412 class_ = new Class_412(stringWriter))
				{
					class_.dmethod_2016(arg_0);
					result = new Class_363(stringWriter.ToString());
				}
			}
			return result;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0004D480 File Offset: 0x0004B680
		internal virtual Class_361 cmethod_2634()
		{
			return new Class_363(this);
		}
	}
}
