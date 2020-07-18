using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020001D1 RID: 465
	public class Class_347 : Class_346
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x000478A8 File Offset: 0x00045AA8
		public Class_347(MemberInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "memberInfo");
			this.field_0 = arg_0;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000478C4 File Offset: 0x00045AC4
		public void smethod_2310(object obje_0, object obje_1)
		{
			try
			{
				if (this.field_2 == null)
				{
					this.field_2 = Class_483.prop_0.kmethod_4007<object>(this.field_0);
				}
				this.field_2(obje_0, obje_1);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error setting value to '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0004793C File Offset: 0x00045B3C
		public object xmethod_2311(object obje_0)
		{
			object result;
			try
			{
				if (this.field_1 == null)
				{
					this.field_1 = Class_483.prop_0.dmethod_4006<object>(this.field_0);
				}
				result = this.field_1(obje_0);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error getting value from '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
			return result;
		}

		// Token: 0x04000862 RID: 2146
		private readonly MemberInfo field_0;

		// Token: 0x04000863 RID: 2147
		private Func<object, object> field_1;

		// Token: 0x04000864 RID: 2148
		private Action<object, object> field_2;
	}
}
