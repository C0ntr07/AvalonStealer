using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000294 RID: 660
	internal static class Class_484
	{
		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x00069AD6 File Offset: 0x00067CD6
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x00069ADD File Offset: 0x00067CDD
		public static Assembly FSharpCoreAssembly { get; private set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x00069AE5 File Offset: 0x00067CE5
		// (set) Token: 0x0600163D RID: 5693 RVA: 0x00069AEC File Offset: 0x00067CEC
		public static Class_489<object, object> IsUnion { get; private set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x00069AF4 File Offset: 0x00067CF4
		// (set) Token: 0x0600163F RID: 5695 RVA: 0x00069AFB File Offset: 0x00067CFB
		public static Class_489<object, object> GetUnionFields { get; private set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00069B03 File Offset: 0x00067D03
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00069B0A File Offset: 0x00067D0A
		public static Class_489<object, object> GetUnionCases { get; private set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00069B12 File Offset: 0x00067D12
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00069B19 File Offset: 0x00067D19
		public static Class_489<object, object> MakeUnion { get; private set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00069B21 File Offset: 0x00067D21
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00069B28 File Offset: 0x00067D28
		public static Func<object, object> GetUnionCaseInfoName { get; private set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00069B30 File Offset: 0x00067D30
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00069B37 File Offset: 0x00067D37
		public static Func<object, object> GetUnionCaseInfo { get; private set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00069B3F File Offset: 0x00067D3F
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00069B46 File Offset: 0x00067D46
		public static Func<object, object> GetUnionCaseFields { get; private set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00069B4E File Offset: 0x00067D4E
		// (set) Token: 0x0600164B RID: 5707 RVA: 0x00069B55 File Offset: 0x00067D55
		public static Class_489<object, object> GetUnionCaseInfoFields { get; private set; }

		// Token: 0x0600164C RID: 5708 RVA: 0x00069B60 File Offset: 0x00067D60
		public static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
			if (!Class_484._initialized)
			{
				lock (Class_484.Lock)
				{
					if (!Class_484._initialized)
					{
						Class_484.FSharpCoreAssembly = fsharpCoreAssembly;
						Type type = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpType");
						MethodInfo method = type.GetMethod("IsUnion", BindingFlags.Static | BindingFlags.Public);
						Class_484.IsUnion = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method);
						MethodInfo method2 = type.GetMethod("GetUnionCases", BindingFlags.Static | BindingFlags.Public);
						Class_484.GetUnionCases = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method2);
						Type type2 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.FSharpValue");
						MethodInfo method3 = type2.GetMethod("GetUnionFields", BindingFlags.Static | BindingFlags.Public);
						Class_484.GetUnionFields = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method3);
						Class_484.GetUnionCaseInfo = Class_470.ReflectionDelegateFactory.xmethod_4011<object>(method3.ReturnType.GetProperty("Item1"));
						Class_484.GetUnionCaseFields = Class_470.ReflectionDelegateFactory.xmethod_4011<object>(method3.ReturnType.GetProperty("Item2"));
						MethodInfo method4 = type2.GetMethod("MakeUnion", BindingFlags.Static | BindingFlags.Public);
						Class_484.MakeUnion = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method4);
						Type type3 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Reflection.UnionCaseInfo");
						Class_484.GetUnionCaseInfoName = Class_470.ReflectionDelegateFactory.xmethod_4011<object>(type3.GetProperty("Name"));
						Class_484.GetUnionCaseInfoFields = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(type3.GetMethod("GetFields"));
						Type type4 = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.ListModule");
						Class_484._ofSeq = type4.GetMethod("OfSeq");
						Class_484._mapType = fsharpCoreAssembly.GetType("Microsoft.FSharp.Collections.FSharpMap`2");
						Thread.MemoryBarrier();
						Class_484._initialized = true;
					}
				}
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00069D1C File Offset: 0x00067F1C
		public static Class_482<object> CreateSeq(Type t)
		{
			MethodInfo arg_ = Class_484._ofSeq.MakeGenericMethod(new Type[]
			{
				t
			});
			return Class_470.ReflectionDelegateFactory.pmethod_4009(arg_);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00069D50 File Offset: 0x00067F50
		public static Class_482<object> CreateMap(Type keyType, Type valueType)
		{
			MethodInfo method = typeof(Class_484).GetMethod("BuildMapCreator");
			MethodInfo methodInfo = method.MakeGenericMethod(new Type[]
			{
				keyType,
				valueType
			});
			return (Class_482<object>)methodInfo.Invoke(null, null);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00069DA0 File Offset: 0x00067FA0
		public static Class_482<object> BuildMapCreator<TKey, TValue>()
		{
			Type type = Class_484._mapType.MakeGenericType(new Type[]
			{
				typeof(TKey),
				typeof(TValue)
			});
			ConstructorInfo constructor = type.GetConstructor(new Type[]
			{
				typeof(IEnumerable<Tuple<TKey, TValue>>)
			});
			Class_482<object> ctorDelegate = Class_470.ReflectionDelegateFactory.pmethod_4009(constructor);
			return delegate(object[] args)
			{
				IEnumerable<KeyValuePair<TKey, TValue>> source = (IEnumerable<KeyValuePair<TKey, TValue>>)args[0];
				IEnumerable<Tuple<TKey, TValue>> enumerable = from kv in source
				select new Tuple<TKey, TValue>(kv.Key, kv.Value);
				return ctorDelegate(new object[]
				{
					enumerable
				});
			};
		}

		// Token: 0x04000BA4 RID: 2980
		public const string FSharpSetTypeName = "FSharpSet`1";

		// Token: 0x04000BA5 RID: 2981
		public const string FSharpListTypeName = "FSharpList`1";

		// Token: 0x04000BA6 RID: 2982
		public const string FSharpMapTypeName = "FSharpMap`2";

		// Token: 0x04000BA7 RID: 2983
		private static readonly object Lock = new object();

		// Token: 0x04000BA8 RID: 2984
		private static bool _initialized;

		// Token: 0x04000BA9 RID: 2985
		private static MethodInfo _ofSeq;

		// Token: 0x04000BAA RID: 2986
		private static Type _mapType;
	}
}
