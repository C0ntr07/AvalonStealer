using System;
using System.Collections.Generic;
using System.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000241 RID: 577
	internal class Class_432
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0005B2D4 File Offset: 0x000594D4
		public Class_431 tmethod_3502(Class_459 arg_0)
		{
			this.field_0 = new Class_433();
			this.field_2 = this.gmethod_3503(null, arg_0);
			this.field_1 = new Dictionary<Class_434, Class_431>();
			return this.pmethod_3509(this.field_2);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0005B314 File Offset: 0x00059514
		public Class_434 gmethod_3503(Class_434 arg_0, Class_459 arg_1)
		{
			string key;
			if (arg_0 != null)
			{
				if (arg_0.prop_1.Contains(arg_1))
				{
					return arg_0;
				}
				key = Class_434.dmethod_3526(arg_0.prop_1.Union(new Class_459[]
				{
					arg_1
				}));
			}
			else
			{
				key = Class_434.dmethod_3526(new Class_459[]
				{
					arg_1
				});
			}
			if (this.field_0.Contains(key))
			{
				return this.field_0[key];
			}
			Class_434 class_ = (arg_0 != null) ? arg_0.vmethod_3525(arg_1) : new Class_434(arg_1);
			this.field_0.Add(class_);
			this.cmethod_3504(arg_1.prop_23, class_.prop_2);
			this.cmethod_3504(arg_1.prop_25, class_.prop_3);
			if (arg_1.prop_18 != null)
			{
				for (int i = 0; i < arg_1.prop_18.Count; i++)
				{
					this.dmethod_3506(class_, i, arg_1.prop_18[i]);
				}
			}
			if (arg_1.prop_20 != null)
			{
				this.lmethod_3508(class_, arg_1.prop_20);
			}
			if (arg_1.prop_24 != null)
			{
				this.kmethod_3507(class_, arg_1.prop_24);
			}
			if (arg_1.prop_31 != null)
			{
				foreach (Class_459 arg_2 in arg_1.prop_31)
				{
					class_ = this.gmethod_3503(class_, arg_2);
				}
			}
			return class_;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0005B4AC File Offset: 0x000596AC
		public void cmethod_3504(IDictionary<string, Class_459> arg_0, IDictionary<string, Class_434> arg_1)
		{
			if (arg_0 != null)
			{
				foreach (KeyValuePair<string, Class_459> keyValuePair in arg_0)
				{
					this.vmethod_3505(arg_1, keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0005B514 File Offset: 0x00059714
		public void vmethod_3505(IDictionary<string, Class_434> arg_0, string str_0, Class_459 arg_1)
		{
			Class_434 arg_2;
			arg_0.TryGetValue(str_0, out arg_2);
			arg_0[str_0] = this.gmethod_3503(arg_2, arg_1);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0005B53C File Offset: 0x0005973C
		public void dmethod_3506(Class_434 arg_0, int sayıInt_0, Class_459 arg_1)
		{
			Class_434 arg_2 = (arg_0.prop_4.Count > sayıInt_0) ? arg_0.prop_4[sayıInt_0] : null;
			Class_434 class_ = this.gmethod_3503(arg_2, arg_1);
			if (arg_0.prop_4.Count <= sayıInt_0)
			{
				arg_0.prop_4.Add(class_);
				return;
			}
			arg_0.prop_4[sayıInt_0] = class_;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0005B5A1 File Offset: 0x000597A1
		public void kmethod_3507(Class_434 arg_0, Class_459 arg_1)
		{
			arg_0.prop_5 = this.gmethod_3503(arg_0.prop_5, arg_1);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0005B5B6 File Offset: 0x000597B6
		public void lmethod_3508(Class_434 arg_0, Class_459 arg_1)
		{
			arg_0.prop_6 = this.gmethod_3503(arg_0.prop_6, arg_1);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0005B5CC File Offset: 0x000597CC
		private Class_431 pmethod_3509(Class_434 arg_0)
		{
			Class_431 class_;
			if (this.field_1.TryGetValue(arg_0, out class_))
			{
				return class_;
			}
			class_ = Class_431.smethod_3500(arg_0.prop_1);
			this.field_1[arg_0] = class_;
			foreach (KeyValuePair<string, Class_434> keyValuePair in arg_0.prop_2)
			{
				if (class_.prop_13 == null)
				{
					class_.prop_13 = new Dictionary<string, Class_431>();
				}
				class_.prop_13[keyValuePair.Key] = this.pmethod_3509(keyValuePair.Value);
			}
			foreach (KeyValuePair<string, Class_434> keyValuePair2 in arg_0.prop_3)
			{
				if (class_.prop_14 == null)
				{
					class_.prop_14 = new Dictionary<string, Class_431>();
				}
				class_.prop_14[keyValuePair2.Key] = this.pmethod_3509(keyValuePair2.Value);
			}
			foreach (Class_434 arg_ in arg_0.prop_4)
			{
				if (class_.prop_12 == null)
				{
					class_.prop_12 = new List<Class_431>();
				}
				class_.prop_12.Add(this.pmethod_3509(arg_));
			}
			if (arg_0.prop_5 != null)
			{
				class_.prop_15 = this.pmethod_3509(arg_0.prop_5);
			}
			if (arg_0.prop_6 != null)
			{
				class_.prop_16 = this.pmethod_3509(arg_0.prop_6);
			}
			return class_;
		}

		// Token: 0x04000A4B RID: 2635
		private Class_433 field_0 = new Class_433();

		// Token: 0x04000A4C RID: 2636
		private Dictionary<Class_434, Class_431> field_1 = new Dictionary<Class_434, Class_431>();

		// Token: 0x04000A4D RID: 2637
		private Class_434 field_2;
	}
}
