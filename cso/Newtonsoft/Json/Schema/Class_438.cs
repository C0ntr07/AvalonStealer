using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000248 RID: 584
	public class Class_438 : EventArgs
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x0005C25F File Offset: 0x0005A45F
		internal Class_438(Class_430 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "ex");
			this.field_0 = arg_0;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0005C279 File Offset: 0x0005A479
		public Class_430 prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0005C281 File Offset: 0x0005A481
		public string prop_1
		{
			get
			{
				return this.field_0.prop_2;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0005C28E File Offset: 0x0005A48E
		public string prop_2
		{
			get
			{
				return this.field_0.Message;
			}
		}

		// Token: 0x04000A60 RID: 2656
		private readonly Class_430 field_0;
	}
}
