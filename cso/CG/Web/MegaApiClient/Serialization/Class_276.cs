using System;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000176 RID: 374
	internal class Class_276 : Class_299
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x0003D980 File Offset: 0x0003BB80
		public virtual void dmethod_1816(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_275 class_ = obje_0 as Class_275;
			if (class_ == null)
			{
				throw new ArgumentException("invalid data to serialize");
			}
			arg_0.pmethod_2009();
			arg_0.pmethod_2009();
			arg_0.kmethod_2037(class_.prop_0);
			arg_0.smethod_2010();
			arg_0.pmethod_2009();
			foreach (Class_275.NClass_0 nclass_ in class_.prop_1)
			{
				arg_0.kmethod_2037(nclass_.nprop_0);
			}
			arg_0.smethod_2010();
			arg_0.pmethod_2009();
			int num = 0;
			foreach (Class_275.NClass_0 nclass_2 in class_.prop_1)
			{
				arg_0.lmethod_2038(0);
				arg_0.lmethod_2038(num++);
				arg_0.kmethod_2037(Class_223.smethod_1470(nclass_2.nprop_1, nclass_2.nprop_2).ToBase64());
			}
			arg_0.smethod_2010();
			arg_0.smethod_2010();
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00018443 File Offset: 0x00016643
		public virtual object kmethod_1817(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
		public virtual bool lmethod_1818(Type arg_0)
		{
			return arg_0 == typeof(Class_275);
		}
	}
}
