using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001F0 RID: 496
	public class Class_369 : Class_349
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0004D7A3 File Offset: 0x0004B9A3
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x0004D7AB File Offset: 0x0004B9AB
		internal new Class_496 prop_0 { get; set; }

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0004D7B4 File Offset: 0x0004B9B4
		public Class_369(Type arg_0) : base(arg_0)
		{
			this.field_5 = Class_448.Primitive;
			this.prop_0 = Class_499.GetTypeCode(arg_0);
			this.field_6 = true;
		}

		// Token: 0x040008F1 RID: 2289
		[CompilerGenerated]
		private new Class_496 field_0;
	}
}
