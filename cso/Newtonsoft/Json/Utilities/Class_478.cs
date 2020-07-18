using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200028B RID: 651
	internal class Class_478 : SetMemberBinder
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x00068945 File Offset: 0x00066B45
		public Class_478(SetMemberBinder arg_0) : base(arg_0.Name, arg_0.IgnoreCase)
		{
			this.field_0 = arg_0;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00068960 File Offset: 0x00066B60
		public virtual DynamicMetaObject cmethod_4004(DynamicMetaObject arg_0, DynamicMetaObject arg_1, DynamicMetaObject arg_2)
		{
			DynamicMetaObject dynamicMetaObject = this.field_0.Bind(arg_0, new DynamicMetaObject[]
			{
				arg_1
			});
			Class_479 class_ = new Class_479();
			Expression expression = class_.Visit(dynamicMetaObject.Expression);
			return new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
		}

		// Token: 0x04000B9B RID: 2971
		private readonly SetMemberBinder field_0;
	}
}
