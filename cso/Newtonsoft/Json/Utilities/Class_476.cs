using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000288 RID: 648
	internal static class Class_476
	{
		// Token: 0x060015FD RID: 5629 RVA: 0x0006861C File Offset: 0x0006681C
		public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			DynamicMetaObject metaObject = dynamicProvider.GetMetaObject(Expression.Constant(dynamicProvider));
			return metaObject.GetDynamicMemberNames();
		}

		// Token: 0x02000289 RID: 649
		internal static class BinderWrapper
		{
			// Token: 0x060015FE RID: 5630 RVA: 0x0006863C File Offset: 0x0006683C
			private static void Init()
			{
				if (!Class_476.BinderWrapper._init)
				{
					Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false);
					if (type == null)
					{
						throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".FormatWith(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
					}
					int[] values = new int[1];
					Class_476.BinderWrapper._getCSharpArgumentInfoArray = Class_476.BinderWrapper.CreateSharpArgumentInfoArray(values);
					Class_476.BinderWrapper._setCSharpArgumentInfoArray = Class_476.BinderWrapper.CreateSharpArgumentInfoArray(new int[]
					{
						0,
						3
					});
					Class_476.BinderWrapper.CreateMemberCalls();
					Class_476.BinderWrapper._init = true;
				}
			}

			// Token: 0x060015FF RID: 5631 RVA: 0x000686B8 File Offset: 0x000668B8
			private static object CreateSharpArgumentInfoArray(params int[] values)
			{
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				Array array = Array.CreateInstance(type, values.Length);
				for (int i = 0; i < values.Length; i++)
				{
					MethodInfo method = type.GetMethod("Create", new Type[]
					{
						type2,
						typeof(string)
					});
					MethodBase methodBase = method;
					object obj = null;
					object[] array2 = new object[2];
					array2[0] = 0;
					object value = methodBase.Invoke(obj, array2);
					array.SetValue(value, i);
				}
				return array;
			}

			// Token: 0x06001600 RID: 5632 RVA: 0x00068750 File Offset: 0x00066950
			private static void CreateMemberCalls()
			{
				Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
				Type type4 = typeof(IEnumerable<>).MakeGenericType(new Type[]
				{
					type
				});
				MethodInfo method = type3.GetMethod("GetMember", new Type[]
				{
					type2,
					typeof(string),
					typeof(Type),
					type4
				});
				Class_476.BinderWrapper._getMemberCall = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method);
				MethodInfo method2 = type3.GetMethod("SetMember", new Type[]
				{
					type2,
					typeof(string),
					typeof(Type),
					type4
				});
				Class_476.BinderWrapper._setMemberCall = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method2);
			}

			// Token: 0x06001601 RID: 5633 RVA: 0x00068860 File Offset: 0x00066A60
			public static CallSiteBinder GetMember(string name, Type context)
			{
				Class_476.BinderWrapper.Init();
				return (CallSiteBinder)Class_476.BinderWrapper._getMemberCall(null, new object[]
				{
					0,
					name,
					context,
					Class_476.BinderWrapper._getCSharpArgumentInfoArray
				});
			}

			// Token: 0x06001602 RID: 5634 RVA: 0x000688A4 File Offset: 0x00066AA4
			public static CallSiteBinder SetMember(string name, Type context)
			{
				Class_476.BinderWrapper.Init();
				return (CallSiteBinder)Class_476.BinderWrapper._setMemberCall(null, new object[]
				{
					0,
					name,
					context,
					Class_476.BinderWrapper._setCSharpArgumentInfoArray
				});
			}

			// Token: 0x04000B90 RID: 2960
			public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000B91 RID: 2961
			private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000B92 RID: 2962
			private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000B93 RID: 2963
			private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000B94 RID: 2964
			private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

			// Token: 0x04000B95 RID: 2965
			private static object _getCSharpArgumentInfoArray;

			// Token: 0x04000B96 RID: 2966
			private static object _setCSharpArgumentInfoArray;

			// Token: 0x04000B97 RID: 2967
			private static Class_489<object, object> _getMemberCall;

			// Token: 0x04000B98 RID: 2968
			private static Class_489<object, object> _setMemberCall;

			// Token: 0x04000B99 RID: 2969
			private static bool _init;
		}
	}
}
