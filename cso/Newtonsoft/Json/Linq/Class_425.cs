using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000236 RID: 566
	public class Class_425 : Class_285, Class_353
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00059F13 File Offset: 0x00058113
		public new Class_361 prop_0
		{
			get
			{
				return this.field_3;
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00059F1B File Offset: 0x0005811B
		public Class_425(Class_361 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "token");
			this.field_1 = arg_0;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00059F35 File Offset: 0x00058135
		internal Class_425(Class_361 arg_0, string str_0) : this(arg_0)
		{
			this.field_0 = str_0;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0003F9F9 File Offset: 0x0003DBF9
		public virtual byte[] gmethod_3373()
		{
			return base.cmethod_1894();
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003FA01 File Offset: 0x0003DC01
		public virtual decimal? cmethod_3374()
		{
			return base.vmethod_1895();
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0003FA09 File Offset: 0x0003DC09
		public virtual int? vmethod_3375()
		{
			return base.dmethod_1896();
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0003FA11 File Offset: 0x0003DC11
		public virtual string dmethod_3376()
		{
			return base.kmethod_1897();
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0003FA19 File Offset: 0x0003DC19
		public virtual DateTime? kmethod_3377()
		{
			return base.lmethod_1898();
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003FA21 File Offset: 0x0003DC21
		public virtual DateTimeOffset? lmethod_3378()
		{
			return base.gmethod_1893();
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00059F48 File Offset: 0x00058148
		internal virtual bool pmethod_3379()
		{
			if (base.prop_0 == Class_285.NClass_0.field_5)
			{
				this.field_3 = this.field_1;
				this.dmethod_3386(this.field_3);
				return true;
			}
			if (this.field_3 == null)
			{
				return false;
			}
			Class_420 class_ = this.field_3 as Class_420;
			if (class_ != null && this.field_2 != class_)
			{
				return this.cmethod_3384(class_);
			}
			return this.xmethod_3381(this.field_3);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0003FA29 File Offset: 0x0003DC29
		public virtual bool smethod_3380()
		{
			this.field_4 = Class_408.Read;
			return this.tmethod_1892();
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00059FBC File Offset: 0x000581BC
		private bool xmethod_3381(Class_361 arg_0)
		{
			if (arg_0 == this.field_1)
			{
				return this.tmethod_3382();
			}
			Class_361 class_ = arg_0.prop_5;
			if (class_ != null && class_ != arg_0 && arg_0 != arg_0.prop_1.prop_10)
			{
				this.field_3 = class_;
				this.dmethod_3386(this.field_3);
				return true;
			}
			if (arg_0.prop_1 == null)
			{
				return this.tmethod_3382();
			}
			return this.vmethod_3385(arg_0.prop_1);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0005A034 File Offset: 0x00058234
		private bool tmethod_3382()
		{
			this.field_3 = null;
			base.xmethod_1901(Class_508.None);
			return false;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0005A048 File Offset: 0x00058248
		private Class_508? gmethod_3383(Class_420 arg_0)
		{
			switch (arg_0.prop_3)
			{
			case Class_428.Object:
				return new Class_508?(Class_508.EndObject);
			case Class_428.Array:
				return new Class_508?(Class_508.EndArray);
			case Class_428.Constructor:
				return new Class_508?(Class_508.EndConstructor);
			case Class_428.Property:
				return null;
			default:
				throw Class_513.CreateArgumentOutOfRangeException("Type", arg_0.prop_3, "Unexpected JContainer type.");
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0005A0B8 File Offset: 0x000582B8
		private bool cmethod_3384(Class_420 arg_0)
		{
			Class_361 class_ = arg_0.prop_9;
			if (class_ == null)
			{
				return this.vmethod_3385(arg_0);
			}
			this.dmethod_3386(class_);
			this.field_3 = class_;
			this.field_2 = arg_0;
			return true;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0005A0F0 File Offset: 0x000582F0
		private bool vmethod_3385(Class_420 arg_0)
		{
			Class_508? class_ = this.gmethod_3383(arg_0);
			if (class_ != null)
			{
				base.xmethod_1901(class_.Value);
				this.field_3 = arg_0;
				this.field_2 = arg_0;
				return true;
			}
			return this.xmethod_3381(arg_0);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0005A138 File Offset: 0x00058338
		private void dmethod_3386(Class_361 arg_0)
		{
			switch (arg_0.prop_3)
			{
			case Class_428.Object:
				base.xmethod_1901(Class_508.StartObject);
				return;
			case Class_428.Array:
				base.xmethod_1901(Class_508.StartArray);
				return;
			case Class_428.Constructor:
				base.tmethod_1902(Class_508.StartConstructor, ((Class_421)arg_0).prop_1);
				return;
			case Class_428.Property:
				base.tmethod_1902(Class_508.PropertyName, ((Class_427)arg_0).prop_1);
				return;
			case Class_428.Comment:
				base.tmethod_1902(Class_508.Comment, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Integer:
				base.tmethod_1902(Class_508.Integer, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Float:
				base.tmethod_1902(Class_508.Float, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.String:
				base.tmethod_1902(Class_508.String, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Boolean:
				base.tmethod_1902(Class_508.Boolean, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Null:
				base.tmethod_1902(Class_508.Null, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Undefined:
				base.tmethod_1902(Class_508.Undefined, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Date:
				base.tmethod_1902(Class_508.Date, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Raw:
				base.tmethod_1902(Class_508.Raw, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Bytes:
				base.tmethod_1902(Class_508.Bytes, ((Class_362)arg_0).prop_2);
				return;
			case Class_428.Guid:
				base.tmethod_1902(Class_508.String, this.kmethod_3387(((Class_362)arg_0).prop_2));
				return;
			case Class_428.Uri:
				base.tmethod_1902(Class_508.String, this.kmethod_3387(((Class_362)arg_0).prop_2));
				return;
			case Class_428.TimeSpan:
				base.tmethod_1902(Class_508.String, this.kmethod_3387(((Class_362)arg_0).prop_2));
				return;
			default:
				throw Class_513.CreateArgumentOutOfRangeException("Type", arg_0.prop_3, "Unexpected JTokenType.");
			}
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0005A2FF File Offset: 0x000584FF
		private string kmethod_3387(object obje_0)
		{
			if (obje_0 == null)
			{
				return null;
			}
			return obje_0.ToString();
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0005A310 File Offset: 0x00058510
		bool Class_353.lmethod_3388()
		{
			if (base.prop_0 == Class_285.NClass_0.field_5)
			{
				return false;
			}
			Class_353 class_ = this.field_3;
			return class_ != null && class_.lmethod_2368();
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0005A340 File Offset: 0x00058540
		int Class_353.prop_1
		{
			get
			{
				if (base.prop_0 == Class_285.NClass_0.field_5)
				{
					return 0;
				}
				Class_353 class_ = this.field_3;
				if (class_ != null)
				{
					return class_.prop_0;
				}
				return 0;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0005A370 File Offset: 0x00058570
		int Class_353.prop_2
		{
			get
			{
				if (base.prop_0 == Class_285.NClass_0.field_5)
				{
					return 0;
				}
				Class_353 class_ = this.field_3;
				if (class_ != null)
				{
					return class_.prop_1;
				}
				return 0;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0005A3A0 File Offset: 0x000585A0
		public virtual string prop_3
		{
			get
			{
				string text = base.prop_13;
				if (!string.IsNullOrEmpty(this.field_0))
				{
					if (string.IsNullOrEmpty(text))
					{
						return this.field_0;
					}
					if (this.field_0.EndsWith(']') || text.StartsWith('['))
					{
						text = this.field_0 + text;
					}
					else
					{
						text = this.field_0 + "." + text;
					}
				}
				return text;
			}
		}

		// Token: 0x04000A0E RID: 2574
		private readonly string field_0;

		// Token: 0x04000A0F RID: 2575
		private readonly Class_361 field_1;

		// Token: 0x04000A10 RID: 2576
		private new Class_361 field_2;

		// Token: 0x04000A11 RID: 2577
		private new Class_361 field_3;
	}
}
