using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002BA RID: 698
	internal class Class_506<T> where T : struct
	{
		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0006DB46 File Offset: 0x0006BD46
		public string prop_0
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x0006DB4E File Offset: 0x0006BD4E
		public T prop_1
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0006DB56 File Offset: 0x0006BD56
		public Class_506(string str_0, T arg_0)
		{
			this._name = str_0;
			this._value = arg_0;
		}

		// Token: 0x04000C30 RID: 3120
		private readonly string field_0;

		// Token: 0x04000C31 RID: 3121
		private readonly T field_1;
	}
}
