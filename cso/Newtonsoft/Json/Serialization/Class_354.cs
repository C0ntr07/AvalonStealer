using System;
using System.Globalization;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001DA RID: 474
	internal class Class_354 : Class_285, Class_353
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x000482F8 File Offset: 0x000464F8
		public Class_354(Class_285 arg_0)
		{
			this.field_0 = arg_0;
			this.field_2 = new StringWriter(CultureInfo.InvariantCulture);
			this.field_1 = new Class_412(this.field_2);
			this.field_1.prop_5 = Class_322.Indented;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00048334 File Offset: 0x00046534
		public string xmethod_2371()
		{
			return this.field_2.ToString();
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00048344 File Offset: 0x00046544
		public virtual bool tmethod_2372()
		{
			bool result = this.field_0.vmethod_1885();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00048374 File Offset: 0x00046574
		public virtual int? gmethod_2373()
		{
			int? result = this.field_0.dmethod_1886();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000483A4 File Offset: 0x000465A4
		public virtual string cmethod_2374()
		{
			string result = this.field_0.kmethod_1887();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000483D4 File Offset: 0x000465D4
		public virtual byte[] vmethod_2375()
		{
			byte[] result = this.field_0.lmethod_1888();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00048404 File Offset: 0x00046604
		public virtual decimal? dmethod_2376()
		{
			decimal? result = this.field_0.pmethod_1889();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00048434 File Offset: 0x00046634
		public virtual DateTime? kmethod_2377()
		{
			DateTime? result = this.field_0.smethod_1890();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00048464 File Offset: 0x00046664
		public virtual DateTimeOffset? lmethod_2378()
		{
			DateTimeOffset? result = this.field_0.xmethod_1891();
			this.field_1.smethod_2020(this.field_0, false, false);
			return result;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00048491 File Offset: 0x00046691
		public virtual int prop_0
		{
			get
			{
				return this.field_0.prop_12;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0004849E File Offset: 0x0004669E
		public virtual string prop_1
		{
			get
			{
				return this.field_0.prop_13;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000484AB File Offset: 0x000466AB
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000484B8 File Offset: 0x000466B8
		public virtual char prop_2
		{
			get
			{
				return this.field_0.prop_3;
			}
			protected internal set
			{
				this.field_0.prop_3 = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000484C6 File Offset: 0x000466C6
		public virtual Class_508 prop_3
		{
			get
			{
				return this.field_0.prop_9;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x000484D3 File Offset: 0x000466D3
		public virtual object prop_4
		{
			get
			{
				return this.field_0.prop_10;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000484E0 File Offset: 0x000466E0
		public virtual Type prop_5
		{
			get
			{
				return this.field_0.prop_11;
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000484ED File Offset: 0x000466ED
		public virtual void dmethod_2386()
		{
			this.field_0.tmethod_1912();
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000484FC File Offset: 0x000466FC
		bool Class_353.kmethod_2387()
		{
			Class_353 class_ = this.field_0 as Class_353;
			return class_ != null && class_.lmethod_2368();
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00048524 File Offset: 0x00046724
		int Class_353.prop_6
		{
			get
			{
				Class_353 class_ = this.field_0 as Class_353;
				if (class_ == null)
				{
					return 0;
				}
				return class_.prop_0;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0004854C File Offset: 0x0004674C
		int Class_353.prop_7
		{
			get
			{
				Class_353 class_ = this.field_0 as Class_353;
				if (class_ == null)
				{
					return 0;
				}
				return class_.prop_1;
			}
		}

		// Token: 0x04000885 RID: 2181
		private readonly Class_285 field_0;

		// Token: 0x04000886 RID: 2182
		private readonly Class_412 field_1;

		// Token: 0x04000887 RID: 2183
		private new readonly StringWriter field_2;
	}
}
