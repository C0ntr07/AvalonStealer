using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x020001AD RID: 429
	[Serializable]
	public class Class_318 : Exception
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00016788 File Offset: 0x00014988
		public Class_318()
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00016790 File Offset: 0x00014990
		public Class_318(string str_0) : base(str_0)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00016799 File Offset: 0x00014999
		public Class_318(string str_0, Exception arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000167A3 File Offset: 0x000149A3
		public Class_318(SerializationInfo arg_0, StreamingContext arg_1) : base(arg_0, arg_1)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000442A7 File Offset: 0x000424A7
		internal static Class_318 xmethod_2221(Class_353 arg_0, string str_0, string str_1)
		{
			str_1 = Class_326.FormatMessage(arg_0, str_0, str_1);
			return new Class_318(str_1);
		}
	}
}
