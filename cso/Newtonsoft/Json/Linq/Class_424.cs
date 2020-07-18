using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000235 RID: 565
	[DefaultMember("Item")]
	public class Class_424 : Class_420, IEnumerable, IEnumerable<Class_361>, IList<Class_361>, ICollection<Class_361>
	{
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00059C2B File Offset: 0x00057E2B
		protected virtual IList<Class_361> prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00059C33 File Offset: 0x00057E33
		public virtual Class_428 prop_1
		{
			get
			{
				return Class_428.Array;
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00059C36 File Offset: 0x00057E36
		public Class_424()
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00059C49 File Offset: 0x00057E49
		public Class_424(Class_424 arg_0) : base(arg_0)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00059C5D File Offset: 0x00057E5D
		public Class_424(params object[] arg_0) : this(arg_0)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00059C66 File Offset: 0x00057E66
		public Class_424(object obje_0)
		{
			this.lmethod_3218(obje_0);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00059C80 File Offset: 0x00057E80
		internal virtual bool pmethod_3349(Class_361 arg_0)
		{
			Class_424 class_ = arg_0 as Class_424;
			return class_ != null && base.dmethod_3196(class_);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00059CA3 File Offset: 0x00057EA3
		internal virtual Class_361 smethod_3350()
		{
			return new Class_424(this);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00059CAC File Offset: 0x00057EAC
		public static Class_424 xmethod_3351(Class_285 arg_0)
		{
			if (arg_0.prop_9 == Class_508.None && !arg_0.vmethod_1885())
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JArray from JsonReader.");
			}
			while (arg_0.prop_9 == Class_508.Comment)
			{
				arg_0.vmethod_1885();
			}
			if (arg_0.prop_9 != Class_508.StartArray)
			{
				throw Class_414.lmethod_3098(arg_0, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			Class_424 class_ = new Class_424();
			class_.lmethod_2568(arg_0 as Class_353);
			class_.pmethod_3229(arg_0);
			return class_;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00059D34 File Offset: 0x00057F34
		public static Class_424 tmethod_3352(string str_0)
		{
			Class_424 result;
			using (Class_285 class_ = new Class_409(new StringReader(str_0)))
			{
				Class_424 class_2 = Class_424.xmethod_3351(class_);
				if (class_.vmethod_1885() && class_.prop_9 != Class_508.Comment)
				{
					throw Class_414.lmethod_3098(class_, "Additional text found in JSON string after parsing content.");
				}
				result = class_2;
			}
			return result;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00059D9C File Offset: 0x00057F9C
		public static Class_424 gmethod_3353(object obje_0)
		{
			return Class_424.cmethod_3354(obje_0, Class_418.xmethod_3161());
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00059DAC File Offset: 0x00057FAC
		public static Class_424 cmethod_3354(object obje_0, Class_418 arg_0)
		{
			Class_361 class_ = Class_361.pmethod_2559(obje_0, arg_0);
			if (class_.prop_3 != Class_428.Array)
			{
				throw new ArgumentException("Object serialized to {0}. JArray instance expected.".FormatWith(CultureInfo.InvariantCulture, class_.prop_3));
			}
			return (Class_424)class_;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00059DF4 File Offset: 0x00057FF4
		public virtual void vmethod_3355(Class_296 arg_0, params Class_299[] arg_1)
		{
			arg_0.pmethod_2009();
			for (int i = 0; i < this.field_0.Count; i++)
			{
				this.field_0[i].cmethod_2474(arg_0, arg_1);
			}
			arg_0.smethod_2010();
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00059E39 File Offset: 0x00058039
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x00059E78 File Offset: 0x00058078
		public virtual Class_361 prop_2
		{
			get
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				if (!(obje_0 is int))
				{
					throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Array position index expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				return this.smethod_3210((int)obje_0);
			}
			set
			{
				Class_517.ArgumentNotNull(obje_0, "o");
				if (!(obje_0 is int))
				{
					throw new ArgumentException("Set JArray values with invalid key value: {0}. Array position index expected.".FormatWith(CultureInfo.InvariantCulture, Class_513.ToString(obje_0)));
				}
				this.xmethod_3211((int)obje_0, value);
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00058610 File Offset: 0x00056810
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00058619 File Offset: 0x00056819
		public new Class_361 prop_3
		{
			get
			{
				return this.smethod_3210(sayıInt_0);
			}
			set
			{
				this.xmethod_3211(sayıInt_0, value);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00059EB8 File Offset: 0x000580B8
		internal virtual void smethod_3360(object obje_0, Class_328 arg_0)
		{
			IEnumerable enumerable = (base.cmethod_3204(obje_0) || obje_0 is Class_424) ? ((IEnumerable)obje_0) : null;
			if (enumerable == null)
			{
				return;
			}
			Class_420.dmethod_3276(this, enumerable, arg_0);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000585F3 File Offset: 0x000567F3
		public int xmethod_3361(Class_361 arg_0)
		{
			return base.dmethod_3206(arg_0);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000585FC File Offset: 0x000567FC
		public void tmethod_3362(int sayıInt_0, Class_361 arg_0)
		{
			this.kmethod_3207(sayıInt_0, arg_0, false);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00058607 File Offset: 0x00056807
		public void gmethod_3363(int sayıInt_0)
		{
			this.lmethod_3208(sayıInt_0);
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00059EF8 File Offset: 0x000580F8
		public IEnumerator<Class_361> cmethod_3364()
		{
			return this.pmethod_2469().GetEnumerator();
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00058623 File Offset: 0x00056823
		public void vmethod_3365(Class_361 arg_0)
		{
			this.lmethod_3218(arg_0);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00058285 File Offset: 0x00056485
		public void dmethod_3366()
		{
			this.tmethod_3212();
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005862C File Offset: 0x0005682C
		public bool kmethod_3367(Class_361 arg_0)
		{
			return this.cmethod_3214(arg_0);
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00058635 File Offset: 0x00056835
		public void lmethod_3368(Class_361[] arg_0, int sayıInt_0)
		{
			this.vmethod_3215(arg_0, sayıInt_0);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00018464 File Offset: 0x00016664
		public new bool prop_4
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0005863F File Offset: 0x0005683F
		public bool smethod_3370(Class_361 arg_0)
		{
			return this.pmethod_3209(arg_0);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0005994F File Offset: 0x00057B4F
		internal virtual int xmethod_3371()
		{
			return base.xmethod_3231();
		}

		// Token: 0x04000A0D RID: 2573
		private new readonly List<Class_361> field_0 = new List<Class_361>();
	}
}
