using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000279 RID: 633
	internal sealed class Class_475<T> : DynamicMetaObject
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x00067A60 File Offset: 0x00065C60
		internal Class_475(Expression expression, T value, Class_359<T> proxy, bool dontFallbackFirst) : base(expression, BindingRestrictions.Empty, value)
		{
			this._proxy = proxy;
			this._dontFallbackFirst = dontFallbackFirst;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00067A83 File Offset: 0x00065C83
		private new T Value
		{
			get
			{
				return (T)((object)base.Value);
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00067A90 File Offset: 0x00065C90
		private bool IsOverridden(string method)
		{
			return Class_514.IsMethodOverridden(this._proxy.GetType(), typeof(Class_359<T>), method);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00067AB0 File Offset: 0x00065CB0
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			if (!this.IsOverridden("TryGetMember"))
			{
				return base.BindGetMember(binder);
			}
			return this.CallMethodWithResult("TryGetMember", binder, Class_475<T>.NoArgs, (DynamicMetaObject e) => binder.FallbackGetMember(this, e), null);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00067B14 File Offset: 0x00065D14
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			if (!this.IsOverridden("TrySetMember"))
			{
				return base.BindSetMember(binder, value);
			}
			return this.CallMethodReturnLast("TrySetMember", binder, Class_475<T>.GetArgs(new DynamicMetaObject[]
			{
				value
			}), (DynamicMetaObject e) => binder.FallbackSetMember(this, value, e));
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00067B98 File Offset: 0x00065D98
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			if (!this.IsOverridden("TryDeleteMember"))
			{
				return base.BindDeleteMember(binder);
			}
			return this.CallMethodNoResult("TryDeleteMember", binder, Class_475<T>.NoArgs, (DynamicMetaObject e) => binder.FallbackDeleteMember(this, e));
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00067BF8 File Offset: 0x00065DF8
		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			if (!this.IsOverridden("TryConvert"))
			{
				return base.BindConvert(binder);
			}
			return this.CallMethodWithResult("TryConvert", binder, Class_475<T>.NoArgs, (DynamicMetaObject e) => binder.FallbackConvert(this, e), null);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00067C5C File Offset: 0x00065E5C
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryInvokeMember"))
			{
				return base.BindInvokeMember(binder, args);
			}
			Class_475<T>.Fallback fallback = (DynamicMetaObject e) => binder.FallbackInvokeMember(this, args, e);
			DynamicMetaObject dynamicMetaObject = this.BuildCallMethodWithResult("TryInvokeMember", binder, Class_475<T>.GetArgArray(args), this.BuildCallMethodWithResult("TryGetMember", new Class_475<T>.GetBinderAdapter(binder), Class_475<T>.NoArgs, fallback(null), (DynamicMetaObject e) => binder.FallbackInvoke(e, args, null)), null);
			if (!this._dontFallbackFirst)
			{
				return fallback(dynamicMetaObject);
			}
			return dynamicMetaObject;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00067D14 File Offset: 0x00065F14
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryCreateInstance"))
			{
				return base.BindCreateInstance(binder, args);
			}
			return this.CallMethodWithResult("TryCreateInstance", binder, Class_475<T>.GetArgArray(args), (DynamicMetaObject e) => binder.FallbackCreateInstance(this, args, e), null);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00067D88 File Offset: 0x00065F88
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			if (!this.IsOverridden("TryInvoke"))
			{
				return base.BindInvoke(binder, args);
			}
			return this.CallMethodWithResult("TryInvoke", binder, Class_475<T>.GetArgArray(args), (DynamicMetaObject e) => binder.FallbackInvoke(this, args, e), null);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00067DFC File Offset: 0x00065FFC
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			if (!this.IsOverridden("TryBinaryOperation"))
			{
				return base.BindBinaryOperation(binder, arg);
			}
			return this.CallMethodWithResult("TryBinaryOperation", binder, Class_475<T>.GetArgs(new DynamicMetaObject[]
			{
				arg
			}), (DynamicMetaObject e) => binder.FallbackBinaryOperation(this, arg, e), null);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00067E80 File Offset: 0x00066080
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			if (!this.IsOverridden("TryUnaryOperation"))
			{
				return base.BindUnaryOperation(binder);
			}
			return this.CallMethodWithResult("TryUnaryOperation", binder, Class_475<T>.NoArgs, (DynamicMetaObject e) => binder.FallbackUnaryOperation(this, e), null);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00067EE4 File Offset: 0x000660E4
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			if (!this.IsOverridden("TryGetIndex"))
			{
				return base.BindGetIndex(binder, indexes);
			}
			return this.CallMethodWithResult("TryGetIndex", binder, Class_475<T>.GetArgArray(indexes), (DynamicMetaObject e) => binder.FallbackGetIndex(this, indexes, e), null);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00067F58 File Offset: 0x00066158
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			if (!this.IsOverridden("TrySetIndex"))
			{
				return base.BindSetIndex(binder, indexes, value);
			}
			return this.CallMethodReturnLast("TrySetIndex", binder, Class_475<T>.GetArgArray(indexes, value), (DynamicMetaObject e) => binder.FallbackSetIndex(this, indexes, value, e));
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00067FE0 File Offset: 0x000661E0
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			if (!this.IsOverridden("TryDeleteIndex"))
			{
				return base.BindDeleteIndex(binder, indexes);
			}
			return this.CallMethodNoResult("TryDeleteIndex", binder, Class_475<T>.GetArgArray(indexes), (DynamicMetaObject e) => binder.FallbackDeleteIndex(this, indexes, e));
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00068053 File Offset: 0x00066253
		private static Expression[] GetArgs(params DynamicMetaObject[] args)
		{
			return (from arg in args
			select Expression.Convert(arg.Expression, typeof(object))).ToArray<UnaryExpression>();
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00068080 File Offset: 0x00066280
		private static Expression[] GetArgArray(DynamicMetaObject[] args)
		{
			return new NewArrayExpression[]
			{
				Expression.NewArrayInit(typeof(object), Class_475<T>.GetArgs(args))
			};
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000680B4 File Offset: 0x000662B4
		private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value)
		{
			return new Expression[]
			{
				Expression.NewArrayInit(typeof(object), Class_475<T>.GetArgs(args)),
				Expression.Convert(value.Expression, typeof(object))
			};
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00068104 File Offset: 0x00066304
		private static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			Type type = binder.GetType();
			while (!type.IsVisible)
			{
				type = type.BaseType;
			}
			return Expression.Constant(binder, type);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00068134 File Offset: 0x00066334
		private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Class_475<T>.Fallback fallback, Class_475<T>.Fallback fallbackInvoke = null)
		{
			DynamicMetaObject fallbackResult = fallback(null);
			DynamicMetaObject dynamicMetaObject = this.BuildCallMethodWithResult(methodName, binder, args, fallbackResult, fallbackInvoke);
			if (!this._dontFallbackFirst)
			{
				return fallback(dynamicMetaObject);
			}
			return dynamicMetaObject;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0006816C File Offset: 0x0006636C
		private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicMetaObject fallbackResult, Class_475<T>.Fallback fallbackInvoke)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(Class_475<T>.Constant(binder));
			list.AddRange(args);
			list.Add(parameterExpression);
			DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
			if (binder.ReturnType != typeof(object))
			{
				UnaryExpression expression = Expression.Convert(dynamicMetaObject.Expression, binder.ReturnType);
				dynamicMetaObject = new DynamicMetaObject(expression, dynamicMetaObject.Restrictions);
			}
			if (fallbackInvoke != null)
			{
				dynamicMetaObject = fallbackInvoke(dynamicMetaObject);
			}
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, new Expression[]
			{
				Expression.Condition(Expression.Call(Expression.Constant(this._proxy), typeof(Class_359<T>).GetMethod(methodName), list), dynamicMetaObject.Expression, fallbackResult.Expression, binder.ReturnType)
			}), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions).Merge(fallbackResult.Restrictions));
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000682A4 File Offset: 0x000664A4
		private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Class_475<T>.Fallback fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(Class_475<T>.Constant(binder));
			list.AddRange(args);
			list[args.Length + 1] = Expression.Assign(parameterExpression, list[args.Length + 1]);
			DynamicMetaObject dynamicMetaObject2 = new DynamicMetaObject(Expression.Block(new ParameterExpression[]
			{
				parameterExpression
			}, new Expression[]
			{
				Expression.Condition(Expression.Call(Expression.Constant(this._proxy), typeof(Class_359<T>).GetMethod(methodName), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))
			}), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
			if (!this._dontFallbackFirst)
			{
				return fallback(dynamicMetaObject2);
			}
			return dynamicMetaObject2;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000683A8 File Offset: 0x000665A8
		private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, Class_475<T>.Fallback fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(Class_475<T>.Constant(binder));
			list.AddRange(args);
			DynamicMetaObject dynamicMetaObject2 = new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this._proxy), typeof(Class_359<T>).GetMethod(methodName), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
			if (!this._dontFallbackFirst)
			{
				return fallback(dynamicMetaObject2);
			}
			return dynamicMetaObject2;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00068459 File Offset: 0x00066659
		private BindingRestrictions GetRestrictions()
		{
			if (this.Value != null || !base.HasValue)
			{
				return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
			}
			return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00068494 File Offset: 0x00066694
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return this._proxy.GetDynamicMemberNames(this.Value);
		}

		// Token: 0x04000B6B RID: 2923
		private readonly Class_359<T> _proxy;

		// Token: 0x04000B6C RID: 2924
		private readonly bool _dontFallbackFirst;

		// Token: 0x04000B6D RID: 2925
		private static readonly Expression[] NoArgs = new Expression[0];

		// Token: 0x0200027A RID: 634
		// (Invoke) Token: 0x060015DF RID: 5599
		private delegate DynamicMetaObject Fallback(DynamicMetaObject errorSuggestion);

		// Token: 0x0200027B RID: 635
		private sealed class GetBinderAdapter : GetMemberBinder
		{
			// Token: 0x060015E2 RID: 5602 RVA: 0x000684CB File Offset: 0x000666CB
			internal GetBinderAdapter(InvokeMemberBinder binder) : base(binder.Name, binder.IgnoreCase)
			{
			}

			// Token: 0x060015E3 RID: 5603 RVA: 0x0001429B File Offset: 0x0001249B
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
			{
				throw new NotSupportedException();
			}
		}
	}
}
