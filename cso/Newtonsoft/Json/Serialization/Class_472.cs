using System;
using System.Globalization;
using System.Reflection;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000276 RID: 630
	public class Class_472 : Class_346
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x000677A9 File Offset: 0x000659A9
		public Class_472(MemberInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "memberInfo");
			this.field_0 = arg_0;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000677C4 File Offset: 0x000659C4
		public void lmethod_3998(object obje_0, object obje_1)
		{
			try
			{
				Class_514.SetMemberValue(this.field_0, obje_0, obje_1);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error setting value to '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0006781C File Offset: 0x00065A1C
		public object pmethod_3999(object obje_0)
		{
			object memberValue;
			try
			{
				memberValue = Class_514.GetMemberValue(this.field_0, obje_0);
			}
			catch (Exception arg_)
			{
				throw new Class_417("Error getting value from '{0}' on '{1}'.".FormatWith(CultureInfo.InvariantCulture, this.field_0.Name, obje_0.GetType()), arg_);
			}
			return memberValue;
		}

		// Token: 0x04000B64 RID: 2916
		private readonly MemberInfo field_0;
	}
}
