using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001D6 RID: 470
	public class Class_350 : Class_349
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00048063 File Offset: 0x00046263
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0004806C File Offset: 0x0004626C
		internal new Class_349 prop_0
		{
			get
			{
				return this.field_0;
			}
			set
			{
				this.field_0 = value;
				if (this.field_0 != null)
				{
					this.field_1 = (this.field_0.prop_0.IsSealed ? this.field_0 : null);
					return;
				}
				this.field_1 = null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x000480BA File Offset: 0x000462BA
		internal new Class_349 prop_1
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000480C2 File Offset: 0x000462C2
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000480CA File Offset: 0x000462CA
		public new Class_299 prop_2 { get; set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000480D3 File Offset: 0x000462D3
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000480DB File Offset: 0x000462DB
		public new bool? prop_3 { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000480E4 File Offset: 0x000462E4
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x000480EC File Offset: 0x000462EC
		public new Class_458? prop_4 { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000480F5 File Offset: 0x000462F5
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x000480FD File Offset: 0x000462FD
		public new Class_494? prop_5 { get; set; }

		// Token: 0x06000D3F RID: 3391 RVA: 0x00048108 File Offset: 0x00046308
		internal Class_350(Type arg_0) : base(arg_0)
		{
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(arg_0);
			if (cachedAttribute != null)
			{
				if (cachedAttribute.prop_3 != null)
				{
					this.prop_2 = Class_470.CreateJsonConverterInstance(cachedAttribute.prop_3, cachedAttribute.prop_4);
				}
				this.prop_3 = cachedAttribute.field_1;
				this.prop_4 = cachedAttribute.field_2;
				this.prop_5 = cachedAttribute.field_3;
			}
		}

		// Token: 0x0400087C RID: 2172
		private new Class_349 field_0;

		// Token: 0x0400087D RID: 2173
		private new Class_349 field_1;

		// Token: 0x0400087E RID: 2174
		[CompilerGenerated]
		private new Class_299 field_2;

		// Token: 0x0400087F RID: 2175
		[CompilerGenerated]
		private new bool? field_3;

		// Token: 0x04000880 RID: 2176
		[CompilerGenerated]
		private new Class_458? field_4;

		// Token: 0x04000881 RID: 2177
		[CompilerGenerated]
		private new Class_494? field_5;
	}
}
