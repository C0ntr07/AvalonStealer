using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class Class_413 : Class_318
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000550CE File Offset: 0x000532CE
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x000550D6 File Offset: 0x000532D6
		public string prop_0 { get; private set; }

		// Token: 0x060010D3 RID: 4307 RVA: 0x000550DF File Offset: 0x000532DF
		public Class_413()
		{
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000550E7 File Offset: 0x000532E7
		public Class_413(string str_0) : base(str_0)
		{
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000550F0 File Offset: 0x000532F0
		public Class_413(string str_0, Exception arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000550FA File Offset: 0x000532FA
		public Class_413(SerializationInfo arg_0, StreamingContext arg_1) : base(arg_0, arg_1)
		{
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00055104 File Offset: 0x00053304
		internal Class_413(string str_0, Exception arg_0, string str_1) : base(str_0, arg_0)
		{
			this.prop_0 = str_1;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00055115 File Offset: 0x00053315
		internal static Class_413 smethod_3090(Class_296 arg_0, string str_0, Exception arg_1)
		{
			return Class_413.xmethod_3091(arg_0.prop_3, str_0, arg_1);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00055124 File Offset: 0x00053324
		internal static Class_413 xmethod_3091(string str_0, string str_1, Exception arg_0)
		{
			str_1 = Class_326.FormatMessage(null, str_0, str_1);
			return new Class_413(str_1, arg_0, str_0);
		}

		// Token: 0x040009A5 RID: 2469
		[CompilerGenerated]
		private string field_0;
	}
}
