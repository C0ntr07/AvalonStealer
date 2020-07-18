using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000228 RID: 552
	[Serializable]
	public class Class_417 : Class_318
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x000550DF File Offset: 0x000532DF
		public Class_417()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000550E7 File Offset: 0x000532E7
		public Class_417(string str_0) : base(str_0)
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000550F0 File Offset: 0x000532F0
		public Class_417(string str_0, Exception arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000550FA File Offset: 0x000532FA
		public Class_417(SerializationInfo arg_0, StreamingContext arg_1) : base(arg_0, arg_1)
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00055DB1 File Offset: 0x00053FB1
		internal static Class_417 xmethod_3101(Class_285 arg_0, string str_0)
		{
			return Class_417.tmethod_3102(arg_0, str_0, null);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00055DBB File Offset: 0x00053FBB
		internal static Class_417 tmethod_3102(Class_285 arg_0, string str_0, Exception arg_1)
		{
			return Class_417.gmethod_3103(arg_0 as Class_353, arg_0.prop_13, str_0, arg_1);
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00055DD0 File Offset: 0x00053FD0
		internal static Class_417 gmethod_3103(Class_353 arg_0, string str_0, string str_1, Exception arg_1)
		{
			str_1 = Class_326.FormatMessage(arg_0, str_0, str_1);
			return new Class_417(str_1, arg_1);
		}
	}
}
