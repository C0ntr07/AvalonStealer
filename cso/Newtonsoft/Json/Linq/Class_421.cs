using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000230 RID: 560
	[DefaultMember("Item")]
	public class Class_421 : Class_420
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00058CA9 File Offset: 0x00056EA9
		protected virtual IList<Class_361> prop_0
		{
			get
			{
				return this.field_1;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00058CB4 File Offset: 0x00056EB4
		internal virtual void lmethod_3278(object obje_0, Class_328 arg_0)
		{
			Class_421 class_ = obje_0 as Class_421;
			if (class_ == null)
			{
				return;
			}
			if (class_.prop_1 != null)
			{
				this.prop_1 = class_.prop_1;
			}
			Class_420.dmethod_3276(this, class_, arg_0);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00058CEE File Offset: 0x00056EEE
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00058CF6 File Offset: 0x00056EF6
		public new string prop_1
		{
			get
			{
				return this.field_0;
			}
			set
			{
				this.field_0 = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000406DE File Offset: 0x0003E8DE
		public virtual Class_428 prop_2
		{
			get
			{
				return Class_428.Constructor;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00058CFF File Offset: 0x00056EFF
		public Class_421()
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00058D12 File Offset: 0x00056F12
		public Class_421(Class_421 arg_0) : base(arg_0)
		{
			this.field_0 = arg_0.prop_1;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00058D32 File Offset: 0x00056F32
		public Class_421(string str_0, params object[] arg_0) : this(str_0, arg_0)
		{
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00058D3C File Offset: 0x00056F3C
		public Class_421(string str_0, object obje_0) : this(str_0)
		{
			this.lmethod_3218(obje_0);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00058D4C File Offset: 0x00056F4C
		public Class_421(string str_0)
		{
			Class_517.ArgumentNotNullOrEmpty(str_0, "name");
			this.field_0 = str_0;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00058D74 File Offset: 0x00056F74
		internal virtual bool tmethod_3282(Class_361 arg_0)
		{
			Class_421 class_ = arg_0 as Class_421;
			return class_ != null && this.field_0 == class_.prop_1 && base.dmethod_3196(class_);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00058DAD File Offset: 0x00056FAD
		internal virtual Class_361 gmethod_3283()
		{
			return new Class_421(this);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x00058DB8 File Offset: 0x00056FB8
		public virtual void cmethod_3284(Class_296 arg_0, params Class_299[] arg_1)
		{
			arg_0.xmethod_2011(this.field_0);
			foreach (Class_361 class_ in this.pmethod_2469())
			{
				class_.cmethod_2474(arg_0, arg_1);
			}
			arg_0.tmethod_2012();
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00058E24 File Offset: 0x00057024
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00058E63 File Offset: 0x00057063
		public virtual Class_361 prop_3
		{
			get
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				if (!(obje_0 is int))
				{
					throw new ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				return this.smethod_3210((int)obje_0);
			}
			set
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				if (!(obje_0 is int))
				{
					throw new ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				this.xmethod_3211((int)obje_0, value);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00058EA3 File Offset: 0x000570A3
		internal virtual int kmethod_3287()
		{
			return this.field_0.GetHashCode() ^ base.xmethod_3231();
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00058EB8 File Offset: 0x000570B8
		public static Class_421 lmethod_3288(Class_285 arg_0)
		{
			if (arg_0.prop_9 == Class_508.None && !arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JConstructor from JsonReader.");
			}
			while (arg_0.prop_9 == Class_508.Comment)
			{
				arg_0.vmethod_1885();
			}
			if (arg_0.prop_9 != Class_508.StartConstructor)
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			Class_421 class_ = new Class_421((string)arg_0.prop_10);
			class_.lmethod_2568(arg_0 as Class_353);
			class_.pmethod_3229(arg_0);
			return class_;
		}

		// Token: 0x040009FF RID: 2559
		private new string field_0;

		// Token: 0x04000A00 RID: 2560
		private new readonly List<Class_361> field_1 = new List<Class_361>();
	}
}
