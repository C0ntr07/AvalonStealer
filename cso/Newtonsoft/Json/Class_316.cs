using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x020001AB RID: 427
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class Class_316 : Attribute
	{
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0004414A File Offset: 0x0004234A
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00044152 File Offset: 0x00042352
		public string prop_0 { get; set; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0004415B File Offset: 0x0004235B
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00044163 File Offset: 0x00042363
		public string prop_1 { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0004416C File Offset: 0x0004236C
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00044174 File Offset: 0x00042374
		public string prop_2 { get; set; }

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0004417D File Offset: 0x0004237D
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00044185 File Offset: 0x00042385
		public Type prop_3 { get; set; }

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0004418E File Offset: 0x0004238E
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00044196 File Offset: 0x00042396
		public object[] prop_4 { get; set; }

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000441A0 File Offset: 0x000423A0
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000441C9 File Offset: 0x000423C9
		public bool prop_5
		{
			get
			{
				return this.field_0 ?? false;
			}
			set
			{
				this.field_0 = new bool?(value);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000441D8 File Offset: 0x000423D8
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00044201 File Offset: 0x00042401
		public bool prop_6
		{
			get
			{
				return this.field_1 ?? false;
			}
			set
			{
				this.field_1 = new bool?(value);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00044210 File Offset: 0x00042410
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00044239 File Offset: 0x00042439
		public Class_458 prop_7
		{
			get
			{
				Class_458? class_ = this.field_2;
				if (class_ == null)
				{
					return Class_458.Error;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_2 = new Class_458?(value);
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00044248 File Offset: 0x00042448
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00044271 File Offset: 0x00042471
		public Class_494 prop_8
		{
			get
			{
				Class_494? class_ = this.field_3;
				if (class_ == null)
				{
					return Class_494.None;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_3 = new Class_494?(value);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0004427F File Offset: 0x0004247F
		protected Class_316()
		{
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00044287 File Offset: 0x00042487
		protected Class_316(string str_0)
		{
			this.prop_0 = str_0;
		}

		// Token: 0x040007BA RID: 1978
		internal bool? field_0;

		// Token: 0x040007BB RID: 1979
		internal bool? field_1;

		// Token: 0x040007BC RID: 1980
		internal Class_458? field_2;

		// Token: 0x040007BD RID: 1981
		internal Class_494? field_3;

		// Token: 0x040007BE RID: 1982
		[CompilerGenerated]
		private string field_4;

		// Token: 0x040007BF RID: 1983
		[CompilerGenerated]
		private string field_5;

		// Token: 0x040007C0 RID: 1984
		[CompilerGenerated]
		private string field_6;

		// Token: 0x040007C1 RID: 1985
		[CompilerGenerated]
		private Type field_7;

		// Token: 0x040007C2 RID: 1986
		[CompilerGenerated]
		private object[] field_8;
	}
}
