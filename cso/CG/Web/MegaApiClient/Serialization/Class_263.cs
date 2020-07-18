using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000166 RID: 358
	internal class Class_263 : Class_299
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x0003D369 File Offset: 0x0003B569
		public Class_263(byte[] byteDizi_0)
		{
			this.field_0 = byteDizi_0;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0003D378 File Offset: 0x0003B578
		public virtual bool cmethod_1774(Type arg_0)
		{
			return typeof(Class_262) == arg_0;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0003D38C File Offset: 0x0003B58C
		public virtual object vmethod_1775(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 == Class_508.Null)
			{
				return null;
			}
			Class_361 class_ = Class_423.pmethod_3309(arg_0);
			Class_262 class_2 = new Class_262(this.field_0);
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

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void dmethod_1776(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x040006D3 RID: 1747
		private readonly byte[] field_0;
	}
}
