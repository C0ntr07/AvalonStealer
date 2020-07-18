using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200028A RID: 650
	internal class Class_477 : GetMemberBinder
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x000688E7 File Offset: 0x00066AE7
		public Class_477(GetMemberBinder arg_0) : base(arg_0.Name, arg_0.IgnoreCase)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00068904 File Offset: 0x00066B04
		public virtual DynamicMetaObject gmethod_4003(DynamicMetaObject arg_0, DynamicMetaObject arg_1)
		{
			DynamicMetaObject dynamicMetaObject = this.field_0.Bind(arg_0, new DynamicMetaObject[0]);
			Class_479 class_ = new Class_479();
			Expression expression = class_.Visit(dynamicMetaObject.Expression);
			return new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
		}

		// Token: 0x04000B9A RID: 2970
		private readonly GetMemberBinder field_0;
	}
}
