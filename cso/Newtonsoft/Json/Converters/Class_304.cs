using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019F RID: 415
	public abstract class Class_304 : Class_299
	{
		// Token: 0x06000C01 RID: 3073 RVA: 0x00042F18 File Offset: 0x00041118
		public virtual bool pmethod_2159(Type arg_0)
		{
			return arg_0 == typeof(DateTime) || arg_0 == typeof(DateTime?) || (arg_0 == typeof(DateTimeOffset) || arg_0 == typeof(DateTimeOffset?));
		}
	}
}
