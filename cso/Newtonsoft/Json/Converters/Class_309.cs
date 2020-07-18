using System;
using System.Globalization;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001A4 RID: 420
	public class Class_309 : Class_299
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x00043A60 File Offset: 0x00041C60
		public virtual void tmethod_2182(Class_296 arg_0, object obje_0, Class_418 arg_1)
		{
			Class_298 class_ = (Class_298)obje_0;
			Class_297 class_2 = arg_0 as Class_297;
			if (class_2 != null)
			{
				class_2.lmethod_2128(class_.prop_0);
				return;
			}
			arg_0.tmethod_2072(class_.prop_0);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00043A9C File Offset: 0x00041C9C
		public virtual object gmethod_2183(Class_285 arg_0, Type arg_1, object obje_0, Class_418 arg_2)
		{
			if (arg_0.prop_9 != Class_508.Bytes)
			{
				throw new Class_417("Expected Bytes but got {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0.prop_9));
			}
			byte[] byteDizi_ = (byte[])arg_0.prop_10;
			return new Class_298(byteDizi_);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00043AE8 File Offset: 0x00041CE8
		public virtual bool cmethod_2184(Type arg_0)
		{
			return arg_0 == typeof(Class_298);
		}
	}
}
