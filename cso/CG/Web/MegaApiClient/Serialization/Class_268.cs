using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200016B RID: 363
	internal class Class_268 : Class_299
	{
		// Token: 0x06000A3A RID: 2618 RVA: 0x0003D526 File Offset: 0x0003B726
		public Class_268(byte[] byteDizi_0, ref List<Class_277> arg_0)
		{
			this.field_0 = byteDizi_0;
			this.field_1 = arg_0;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0003D53D File Offset: 0x0003B73D
		public virtual bool vmethod_1795(Type arg_0)
		{
			return typeof(Class_241) == arg_0;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0003D550 File Offset: 0x0003B750
		public virtual object dmethod_1796(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			Class_361 class_ = Class_423.pmethod_3309(arg_0);
			Class_241 class_2 = new Class_241(this.field_0, ref this.field_1);
			Class_285 class_3 = class_.lmethod_2558();
			class_3.prop_14 = arg_0.prop_14;
			class_3.prop_7 = arg_0.prop_7;
			class_3.prop_5 = arg_0.prop_5;
			class_3.prop_4 = arg_0.prop_4;
			class_3.prop_6 = arg_0.prop_6;
			class_3.prop_8 = arg_0.prop_8;
			class_3.prop_2 = arg_0.prop_2;
			arg_2.vmethod_3165(class_3, class_2);
			return class_2;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void kmethod_1797(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040006DD RID: 1757
		private readonly byte[] field_0;

		// Token: 0x040006DE RID: 1758
		private List<Class_277> field_1;
	}
}
