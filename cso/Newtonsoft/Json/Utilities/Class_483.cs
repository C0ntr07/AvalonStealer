using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000291 RID: 657
	internal class Class_483 : Class_480
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00069308 File Offset: 0x00067508
		internal static Class_480 prop_0
		{
			get
			{
				return Class_483.field_0;
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00069310 File Offset: 0x00067510
		public virtual Class_482<object> smethod_4030(MethodBase arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "method");
			Type typeFromHandle = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
			Expression body = this.tmethod_4032(arg_0, typeFromHandle, null, parameterExpression);
			LambdaExpression lambdaExpression = Expression.Lambda(typeof(Class_482<object>), body, new ParameterExpression[]
			{
				parameterExpression
			});
			return (Class_482<object>)lambdaExpression.Compile();
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00069388 File Offset: 0x00067588
		public virtual Class_489<T, object> xmethod_4031<T>(MethodBase arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "method");
			Type typeFromHandle = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "target");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), "args");
			Expression body = this.tmethod_4032(arg_0, typeFromHandle, parameterExpression, parameterExpression2);
			LambdaExpression lambdaExpression = Expression.Lambda(typeof(Class_489<T, object>), body, new ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			});
			return (Class_489<T, object>)lambdaExpression.Compile();
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00069418 File Offset: 0x00067618
		private Expression tmethod_4032(MethodBase arg_0, Type arg_1, ParameterExpression arg_2, ParameterExpression arg_3)
		{
			ParameterInfo[] parameters = arg_0.GetParameters();
			Expression[] array = new Expression[parameters.Length];
			IList<Class_483.NClass_0> list = new List<Class_483.NClass_0>();
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				bool flag = false;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					flag = true;
				}
				Expression index = Expression.Constant(i);
				Expression expression = Expression.ArrayIndex(arg_3, index);
				Expression expression2;
				if (type.IsValueType)
				{
					BinaryExpression arg_4 = Expression.Coalesce(expression, Expression.New(type));
					expression2 = this.lmethod_4038(arg_4, type);
				}
				else
				{
					expression2 = this.lmethod_4038(expression, type);
				}
				if (flag)
				{
					ParameterExpression parameterExpression = Expression.Variable(type);
					list.Add(new Class_483.NClass_0
					{
						field_1 = expression2,
						field_2 = parameterExpression,
						field_3 = parameterInfo.IsOut
					});
					expression2 = parameterExpression;
				}
				array[i] = expression2;
			}
			Expression expression3;
			if (arg_0.IsConstructor)
			{
				expression3 = Expression.New((ConstructorInfo)arg_0, array);
			}
			else if (arg_0.IsStatic)
			{
				expression3 = Expression.Call((MethodInfo)arg_0, array);
			}
			else
			{
				Expression instance = this.lmethod_4038(arg_2, arg_0.DeclaringType);
				expression3 = Expression.Call(instance, (MethodInfo)arg_0, array);
			}
			if (arg_0 is MethodInfo)
			{
				MethodInfo methodInfo = (MethodInfo)arg_0;
				if (methodInfo.ReturnType != typeof(void))
				{
					expression3 = this.lmethod_4038(expression3, arg_1);
				}
				else
				{
					expression3 = Expression.Block(expression3, Expression.Constant(null));
				}
			}
			else
			{
				expression3 = this.lmethod_4038(expression3, arg_1);
			}
			if (list.Count > 0)
			{
				IList<ParameterExpression> list2 = new List<ParameterExpression>();
				IList<Expression> list3 = new List<Expression>();
				foreach (Class_483.NClass_0 nclass_ in list)
				{
					if (!nclass_.field_3)
					{
						list3.Add(Expression.Assign(nclass_.field_2, nclass_.field_1));
					}
					list2.Add(nclass_.field_2);
				}
				list3.Add(expression3);
				expression3 = Expression.Block(list2, list3);
			}
			return expression3;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00069678 File Offset: 0x00067878
		public virtual Func<T> gmethod_4033<T>(Type arg_0)
		{
			Func<T> func = null;
			Class_483<T>.NClass_1 nclass_ = new Class_483<T>.NClass_1();
			nclass_.type = arg_0;
			Class_517.ArgumentNotNull(nclass_.type, "type");
			if (nclass_.type.IsAbstract)
			{
				return new Func<T>(nclass_.<CreateDefaultConstructor>b__1);
			}
			Func<T> result;
			try
			{
				Type typeFromHandle = typeof(T);
				Expression expression = Expression.New(nclass_.type);
				expression = this.lmethod_4038(expression, typeFromHandle);
				LambdaExpression lambdaExpression = Expression.Lambda(typeof(Func<T>), expression, new ParameterExpression[0]);
				Func<T> func2 = (Func<T>)lambdaExpression.Compile();
				result = func2;
			}
			catch
			{
				if (func == null)
				{
					func = new Func<T>(nclass_.<CreateDefaultConstructor>b__2);
				}
				result = func;
			}
			return result;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00069740 File Offset: 0x00067940
		public virtual Func<T, object> cmethod_4034<T>(PropertyInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "propertyInfo");
			Type typeFromHandle = typeof(T);
			Type typeFromHandle2 = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
			MethodInfo getMethod = arg_0.GetGetMethod(true);
			Expression expression;
			if (getMethod.IsStatic)
			{
				expression = Expression.MakeMemberAccess(null, arg_0);
			}
			else
			{
				Expression expression2 = this.lmethod_4038(parameterExpression, arg_0.DeclaringType);
				expression = Expression.MakeMemberAccess(expression2, arg_0);
			}
			expression = this.lmethod_4038(expression, typeFromHandle2);
			LambdaExpression lambdaExpression = Expression.Lambda(typeof(Func<T, object>), expression, new ParameterExpression[]
			{
				parameterExpression
			});
			return (Func<T, object>)lambdaExpression.Compile();
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000697F8 File Offset: 0x000679F8
		public virtual Func<T, object> vmethod_4035<T>(FieldInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "fieldInfo");
			ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
			Expression expression;
			if (arg_0.IsStatic)
			{
				expression = Expression.Field(null, arg_0);
			}
			else
			{
				Expression expression2 = this.lmethod_4038(parameterExpression, arg_0.DeclaringType);
				expression = Expression.Field(expression2, arg_0);
			}
			expression = this.lmethod_4038(expression, typeof(object));
			return Expression.Lambda<Func<T, object>>(expression, new ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00069884 File Offset: 0x00067A84
		public virtual Action<T, object> dmethod_4036<T>(FieldInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "fieldInfo");
			if (arg_0.DeclaringType.IsValueType || arg_0.IsInitOnly)
			{
				return Class_488.prop_0.gmethod_4013<T>(arg_0);
			}
			ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
			Expression expression;
			if (arg_0.IsStatic)
			{
				expression = Expression.Field(null, arg_0);
			}
			else
			{
				Expression expression2 = this.lmethod_4038(parameterExpression, arg_0.DeclaringType);
				expression = Expression.Field(expression2, arg_0);
			}
			Expression right = this.lmethod_4038(parameterExpression2, expression.Type);
			BinaryExpression body = Expression.Assign(expression, right);
			LambdaExpression lambdaExpression = Expression.Lambda(typeof(Action<T, object>), body, new ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			});
			return (Action<T, object>)lambdaExpression.Compile();
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00069974 File Offset: 0x00067B74
		public virtual Action<T, object> kmethod_4037<T>(PropertyInfo arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "propertyInfo");
			if (arg_0.DeclaringType.IsValueType)
			{
				return Class_488.prop_0.cmethod_4014<T>(arg_0);
			}
			Type typeFromHandle = typeof(T);
			Type typeFromHandle2 = typeof(object);
			ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeFromHandle2, "value");
			Expression expression = this.lmethod_4038(parameterExpression2, arg_0.PropertyType);
			MethodInfo setMethod = arg_0.GetSetMethod(true);
			Expression body;
			if (setMethod.IsStatic)
			{
				body = Expression.Call(setMethod, expression);
			}
			else
			{
				Expression instance = this.lmethod_4038(parameterExpression, arg_0.DeclaringType);
				body = Expression.Call(instance, setMethod, new Expression[]
				{
					expression
				});
			}
			LambdaExpression lambdaExpression = Expression.Lambda(typeof(Action<T, object>), body, new ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			});
			return (Action<T, object>)lambdaExpression.Compile();
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00069A78 File Offset: 0x00067C78
		private Expression lmethod_4038(Expression arg_0, Type arg_1)
		{
			Type type = arg_0.Type;
			if (type == arg_1 || (!type.IsValueType && arg_1.IsAssignableFrom(type)))
			{
				return arg_0;
			}
			return Expression.Convert(arg_0, arg_1);
		}

		// Token: 0x04000B9F RID: 2975
		private static readonly Class_483 field_0 = new Class_483();

		// Token: 0x02000292 RID: 658
		private class NClass_0
		{
			// Token: 0x06001636 RID: 5686 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x04000BA0 RID: 2976
			public Expression field_1;

			// Token: 0x04000BA1 RID: 2977
			public ParameterExpression field_2;

			// Token: 0x04000BA2 RID: 2978
			public bool field_3;
		}

		// Token: 0x02000293 RID: 659
		[CompilerGenerated]
		private sealed class NClass_1<T>
		{
			// Token: 0x06001637 RID: 5687 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x06001638 RID: 5688 RVA: 0x00069AC4 File Offset: 0x00067CC4
			public T nmethod_2()
			{
				return (T)((object)Activator.CreateInstance(this.type));
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x00069AC4 File Offset: 0x00067CC4
			public T nmethod_3()
			{
				return (T)((object)Activator.CreateInstance(this.type));
			}

			// Token: 0x04000BA3 RID: 2979
			public Type field_4;
		}
	}
}
