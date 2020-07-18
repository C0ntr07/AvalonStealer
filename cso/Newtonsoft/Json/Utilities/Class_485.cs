using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000296 RID: 662
	internal static class Class_485
	{
		// Token: 0x06001654 RID: 5716 RVA: 0x00069EA1 File Offset: 0x000680A1
		public static void PushInstance(this ILGenerator generator, Type type)
		{
			generator.Emit(OpCodes.Ldarg_0);
			if (type.IsValueType)
			{
				generator.Emit(OpCodes.Unbox, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00069ED2 File Offset: 0x000680D2
		public static void PushArrayInstance(this ILGenerator generator, int argsIndex, int arrayIndex)
		{
			generator.Emit(OpCodes.Ldarg, argsIndex);
			generator.Emit(OpCodes.Ldc_I4, arrayIndex);
			generator.Emit(OpCodes.Ldelem_Ref);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00069EF7 File Offset: 0x000680F7
		public static void BoxIfNeeded(this ILGenerator generator, Type type)
		{
			if (type.IsValueType)
			{
				generator.Emit(OpCodes.Box, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00069F1D File Offset: 0x0006811D
		public static void UnboxIfNeeded(this ILGenerator generator, Type type)
		{
			if (type.IsValueType)
			{
				generator.Emit(OpCodes.Unbox_Any, type);
				return;
			}
			generator.Emit(OpCodes.Castclass, type);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x00069F43 File Offset: 0x00068143
		public static void CallMethod(this ILGenerator generator, MethodInfo methodInfo)
		{
			if (methodInfo.IsFinal || !methodInfo.IsVirtual)
			{
				generator.Emit(OpCodes.Call, methodInfo);
				return;
			}
			generator.Emit(OpCodes.Callvirt, methodInfo);
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00069F74 File Offset: 0x00068174
		public static void Return(this ILGenerator generator)
		{
			generator.Emit(OpCodes.Ret);
		}
	}
}
