using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200028D RID: 653
	internal abstract class Class_480
	{
		// Token: 0x0600160A RID: 5642 RVA: 0x000689F8 File Offset: 0x00066BF8
		public Func<T, object> dmethod_4006<T>(MemberInfo arg_0)
		{
			PropertyInfo propertyInfo = arg_0 as PropertyInfo;
			if (propertyInfo != null)
			{
				return this.xmethod_4011<T>(propertyInfo);
			}
			FieldInfo fieldInfo = arg_0 as FieldInfo;
			if (fieldInfo != null)
			{
				return this.tmethod_4012<T>(fieldInfo);
			}
			throw new Exception("Could not create getter for {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0));
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00068A50 File Offset: 0x00066C50
		public Action<T, object> kmethod_4007<T>(MemberInfo arg_0)
		{
			PropertyInfo propertyInfo = arg_0 as PropertyInfo;
			if (propertyInfo != null)
			{
				return this.cmethod_4014<T>(propertyInfo);
			}
			FieldInfo fieldInfo = arg_0 as FieldInfo;
			if (fieldInfo != null)
			{
				return this.gmethod_4013<T>(fieldInfo);
			}
			throw new Exception("Could not create setter for {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0));
		}

		// Token: 0x0600160C RID: 5644
		public abstract Class_489<T, object> lmethod_4008<T>(MethodBase arg_0);

		// Token: 0x0600160D RID: 5645
		public abstract Class_482<object> pmethod_4009(MethodBase arg_0);

		// Token: 0x0600160E RID: 5646
		public abstract Func<T> smethod_4010<T>(Type arg_0);

		// Token: 0x0600160F RID: 5647
		public abstract Func<T, object> xmethod_4011<T>(PropertyInfo arg_0);

		// Token: 0x06001610 RID: 5648
		public abstract Func<T, object> tmethod_4012<T>(FieldInfo arg_0);

		// Token: 0x06001611 RID: 5649
		public abstract Action<T, object> gmethod_4013<T>(FieldInfo arg_0);

		// Token: 0x06001612 RID: 5650
		public abstract Action<T, object> cmethod_4014<T>(PropertyInfo arg_0);
	}
}
