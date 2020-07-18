using System;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200028C RID: 652
	internal class Class_479 : ExpressionVisitor
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x000689AD File Offset: 0x00066BAD
		protected virtual Expression vmethod_4005(ConditionalExpression arg_0)
		{
			if (arg_0.IfFalse.NodeType == ExpressionType.Throw)
			{
				return Expression.Condition(arg_0.Test, arg_0.IfTrue, Expression.Constant(Class_479.field_0));
			}
			return base.VisitConditional(arg_0);
		}

		// Token: 0x04000B9C RID: 2972
		internal static readonly object field_0 = new object();
	}
}
