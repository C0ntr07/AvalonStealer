using System;

namespace Newtonsoft.Json
{
	// Token: 0x020001FA RID: 506
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class Class_379 : Class_316
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0004DB1B File Offset: 0x0004BD1B
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x0004DB23 File Offset: 0x0004BD23
		public Class_383 MemberSerialization
		{
			get
			{
				return this._memberSerialization;
			}
			set
			{
				this._memberSerialization = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0004DB2C File Offset: 0x0004BD2C
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x0004DB55 File Offset: 0x0004BD55
		public Class_364 ItemRequired
		{
			get
			{
				Class_364? itemRequired = this._itemRequired;
				if (itemRequired == null)
				{
					return Class_364.Default;
				}
				return itemRequired.GetValueOrDefault();
			}
			set
			{
				this._itemRequired = new Class_364?(value);
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00044296 File Offset: 0x00042496
		public Class_379()
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0004DB63 File Offset: 0x0004BD63
		public Class_379(Class_383 memberSerialization)
		{
			this.MemberSerialization = memberSerialization;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0004429E File Offset: 0x0004249E
		public Class_379(string id) : base(id)
		{
		}

		// Token: 0x04000905 RID: 2309
		private Class_383 _memberSerialization;

		// Token: 0x04000906 RID: 2310
		internal Class_364? _itemRequired;
	}
}
