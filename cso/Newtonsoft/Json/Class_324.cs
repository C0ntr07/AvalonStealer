using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x020001B3 RID: 435
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public class Class_324 : Attribute
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000442B9 File Offset: 0x000424B9
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000442C1 File Offset: 0x000424C1
		public bool prop_0 { get; set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x000442CA File Offset: 0x000424CA
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x000442D2 File Offset: 0x000424D2
		public bool prop_1 { get; set; }

		// Token: 0x06000C57 RID: 3159 RVA: 0x000442DB File Offset: 0x000424DB
		public Class_324()
		{
			this.prop_0 = true;
			this.prop_1 = true;
		}

		// Token: 0x040007D2 RID: 2002
		[CompilerGenerated]
		private bool field_0;

		// Token: 0x040007D3 RID: 2003
		[CompilerGenerated]
		private bool field_1;
	}
}
