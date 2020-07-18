using System;

namespace Newtonsoft.Json
{
	// Token: 0x020001F7 RID: 503
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class Class_376 : Class_316
	{
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0004DAAC File Offset: 0x0004BCAC
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x0004DAB4 File Offset: 0x0004BCB4
		public bool AllowNullItems
		{
			get
			{
				return this._allowNullItems;
			}
			set
			{
				this._allowNullItems = value;
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00044296 File Offset: 0x00042496
		public Class_376()
		{
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0004DABD File Offset: 0x0004BCBD
		public Class_376(bool allowNullItems)
		{
			this._allowNullItems = allowNullItems;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0004429E File Offset: 0x0004249E
		public Class_376(string id) : base(id)
		{
		}

		// Token: 0x040008FD RID: 2301
		private bool _allowNullItems;
	}
}
