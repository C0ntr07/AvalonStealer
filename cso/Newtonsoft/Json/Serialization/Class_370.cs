using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001F1 RID: 497
	public class Class_370 : Class_346
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x0004D7D7 File Offset: 0x0004B9D7
		public Class_370(MemberInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "memberInfo");
			this.field_0 = arg_0;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		public void vmethod_2665(object obje_0, object obje_1)
		{
			try
			{
				if (this.field_2 == null)
				{
					this.field_2 = Class_481.field_0.kmethod_4007<object>(this.field_0);
				}
				this.field_2(obje_0, obje_1);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error setting value to '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0004D86C File Offset: 0x0004BA6C
		public object dmethod_2666(object obje_0)
		{
			object result;
			try
			{
				if (this.field_1 == null)
				{
					this.field_1 = Class_481.field_0.dmethod_4006<object>(this.field_0);
				}
				result = this.field_1(obje_0);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error getting value from '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
			return result;
		}

		// Token: 0x040008F2 RID: 2290
		private readonly MemberInfo field_0;

		// Token: 0x040008F3 RID: 2291
		private Func<object, object> field_1;

		// Token: 0x040008F4 RID: 2292
		private Action<object, object> field_2;
	}
}
