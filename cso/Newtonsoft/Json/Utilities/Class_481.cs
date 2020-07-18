using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200028E RID: 654
	internal class Class_481 : Class_480
	{
		// Token: 0x06001614 RID: 5652 RVA: 0x00068AA8 File Offset: 0x00066CA8
		private static DynamicMethod vmethod_4015(string str_0, Type arg_0, Type[] arg_1, Type arg_2)
		{
			return (!arg_2.IsInterface) ? new DynamicMethod(str_0, arg_0, arg_1, arg_2, true) : new DynamicMethod(str_0, arg_0, arg_1, arg_2.Module, true);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00068AE0 File Offset: 0x00066CE0
		public virtual Class_482<object> dmethod_4016(MethodBase arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015(arg_0.ToString(), typeof(object), new Type[]
			{
				typeof(object[])
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.lmethod_4018(arg_0, ilgenerator, 0);
			return (Class_482<object>)dynamicMethod.CreateDelegate(typeof(Class_482<object>));
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00068B48 File Offset: 0x00066D48
		public virtual Class_489<T, object> kmethod_4017<T>(MethodBase arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015(arg_0.ToString(), typeof(object), new Type[]
			{
				typeof(object),
				typeof(object[])
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.lmethod_4018(arg_0, ilgenerator, 1);
			return (Class_489<T, object>)dynamicMethod.CreateDelegate(typeof(Class_489<T, object>));
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00068BC0 File Offset: 0x00066DC0
		private void lmethod_4018(MethodBase arg_0, ILGenerator arg_1, int sayıInt_0)
		{
			ParameterInfo[] parameters = arg_0.GetParameters();
			Label label = arg_1.DefineLabel();
			arg_1.Emit(OpCodes.Ldarg, sayıInt_0);
			arg_1.Emit(OpCodes.Ldlen);
			arg_1.Emit(OpCodes.Ldc_I4, parameters.Length);
			arg_1.Emit(OpCodes.Beq, label);
			arg_1.Emit(OpCodes.Newobj, typeof(TargetParameterCountException).GetConstructor(Class_514.EmptyTypes));
			arg_1.Emit(OpCodes.Throw);
			arg_1.MarkLabel(label);
			if (!arg_0.IsConstructor && !arg_0.IsStatic)
			{
				arg_1.PushInstance(arg_0.DeclaringType);
			}
			int num = 0;
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					LocalBuilder local = arg_1.DeclareLocal(type);
					if (!parameterInfo.IsOut)
					{
						arg_1.PushArrayInstance(sayıInt_0, i);
						if (type.IsValueType)
						{
							Label label2 = arg_1.DefineLabel();
							Label label3 = arg_1.DefineLabel();
							arg_1.Emit(OpCodes.Brtrue_S, label2);
							arg_1.Emit(OpCodes.Ldloca_S, local);
							arg_1.Emit(OpCodes.Initobj, type);
							arg_1.Emit(OpCodes.Br_S, label3);
							arg_1.MarkLabel(label2);
							arg_1.PushArrayInstance(sayıInt_0, i);
							arg_1.UnboxIfNeeded(type);
							arg_1.Emit(OpCodes.Stloc, num);
							arg_1.MarkLabel(label3);
						}
						else
						{
							arg_1.UnboxIfNeeded(type);
							arg_1.Emit(OpCodes.Stloc, num);
						}
					}
					arg_1.Emit(OpCodes.Ldloca_S, local);
					num++;
				}
				else if (type.IsValueType)
				{
					arg_1.PushArrayInstance(sayıInt_0, i);
					Label label4 = arg_1.DefineLabel();
					Label label5 = arg_1.DefineLabel();
					arg_1.Emit(OpCodes.Brtrue_S, label4);
					LocalBuilder local2 = arg_1.DeclareLocal(type);
					arg_1.Emit(OpCodes.Ldloca_S, local2);
					arg_1.Emit(OpCodes.Initobj, type);
					arg_1.Emit(OpCodes.Ldloc, num);
					arg_1.Emit(OpCodes.Br_S, label5);
					arg_1.MarkLabel(label4);
					arg_1.PushArrayInstance(sayıInt_0, i);
					arg_1.UnboxIfNeeded(type);
					arg_1.MarkLabel(label5);
					num++;
				}
				else
				{
					arg_1.PushArrayInstance(sayıInt_0, i);
					arg_1.UnboxIfNeeded(type);
				}
			}
			if (arg_0.IsConstructor)
			{
				arg_1.Emit(OpCodes.Newobj, (ConstructorInfo)arg_0);
			}
			else
			{
				arg_1.CallMethod((MethodInfo)arg_0);
			}
			Type type2 = arg_0.IsConstructor ? arg_0.DeclaringType : ((MethodInfo)arg_0).ReturnType;
			if (type2 != typeof(void))
			{
				arg_1.BoxIfNeeded(type2);
			}
			else
			{
				arg_1.Emit(OpCodes.Ldnull);
			}
			arg_1.Return();
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00068E90 File Offset: 0x00067090
		public virtual Func<T> pmethod_4019<T>(Type arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015("Create" + arg_0.FullName, typeof(T), Class_514.EmptyTypes, arg_0);
			dynamicMethod.InitLocals = true;
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.smethod_4020(arg_0, ilgenerator);
			return (Func<T>)dynamicMethod.CreateDelegate(typeof(Func<T>));
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00068EF0 File Offset: 0x000670F0
		private void smethod_4020(Type arg_0, ILGenerator arg_1)
		{
			if (arg_0.IsValueType)
			{
				arg_1.DeclareLocal(arg_0);
				arg_1.Emit(OpCodes.Ldloc_0);
				arg_1.Emit(OpCodes.Box, arg_0);
			}
			else
			{
				ConstructorInfo constructor = arg_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Class_514.EmptyTypes, null);
				if (constructor == null)
				{
					throw new ArgumentException("Could not get constructor for {0}.".FormatWith(CultureInfo.InvariantCulture, arg_0));
				}
				arg_1.Emit(OpCodes.Newobj, constructor);
			}
			arg_1.Return();
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00068F70 File Offset: 0x00067170
		public virtual Func<T, object> xmethod_4021<T>(PropertyInfo arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015("Get" + arg_0.Name, typeof(T), new Type[]
			{
				typeof(object)
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.tmethod_4022(arg_0, ilgenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00068FE0 File Offset: 0x000671E0
		private void tmethod_4022(PropertyInfo arg_0, ILGenerator arg_1)
		{
			MethodInfo getMethod = arg_0.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new ArgumentException("Property '{0}' does not have a getter.".FormatWith(CultureInfo.InvariantCulture, arg_0.Name));
			}
			if (!getMethod.IsStatic)
			{
				arg_1.PushInstance(arg_0.DeclaringType);
			}
			arg_1.CallMethod(getMethod);
			arg_1.BoxIfNeeded(arg_0.PropertyType);
			arg_1.Return();
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x0006904C File Offset: 0x0006724C
		public virtual Func<T, object> gmethod_4023<T>(FieldInfo arg_0)
		{
			if (arg_0.IsLiteral)
			{
				Class_481<T>.NClass_0 nclass_ = new Class_481<T>.NClass_0();
				nclass_.constantValue = arg_0.GetValue(null);
				return new Func<T, object>(nclass_.<CreateGet>b__0);
			}
			DynamicMethod dynamicMethod = Class_481.vmethod_4015("Get" + arg_0.Name, typeof(T), new Type[]
			{
				typeof(object)
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.cmethod_4024(arg_0, ilgenerator);
			return (Func<T, object>)dynamicMethod.CreateDelegate(typeof(Func<T, object>));
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000690EC File Offset: 0x000672EC
		private void cmethod_4024(FieldInfo arg_0, ILGenerator arg_1)
		{
			if (!arg_0.IsStatic)
			{
				arg_1.PushInstance(arg_0.DeclaringType);
				arg_1.Emit(OpCodes.Ldfld, arg_0);
			}
			else
			{
				arg_1.Emit(OpCodes.Ldsfld, arg_0);
			}
			arg_1.BoxIfNeeded(arg_0.FieldType);
			arg_1.Return();
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00069140 File Offset: 0x00067340
		public virtual Action<T, object> vmethod_4025<T>(FieldInfo arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015("Set" + arg_0.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			Class_481.dmethod_4026(arg_0, ilgenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000691B8 File Offset: 0x000673B8
		internal static void dmethod_4026(FieldInfo arg_0, ILGenerator arg_1)
		{
			if (!arg_0.IsStatic)
			{
				arg_1.PushInstance(arg_0.DeclaringType);
			}
			arg_1.Emit(OpCodes.Ldarg_1);
			arg_1.UnboxIfNeeded(arg_0.FieldType);
			if (!arg_0.IsStatic)
			{
				arg_1.Emit(OpCodes.Stfld, arg_0);
			}
			else
			{
				arg_1.Emit(OpCodes.Stsfld, arg_0);
			}
			arg_1.Return();
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00069224 File Offset: 0x00067424
		public virtual Action<T, object> kmethod_4027<T>(PropertyInfo arg_0)
		{
			DynamicMethod dynamicMethod = Class_481.vmethod_4015("Set" + arg_0.Name, null, new Type[]
			{
				typeof(T),
				typeof(object)
			}, arg_0.DeclaringType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			Class_481.lmethod_4028(arg_0, ilgenerator);
			return (Action<T, object>)dynamicMethod.CreateDelegate(typeof(Action<T, object>));
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0006929C File Offset: 0x0006749C
		internal static void lmethod_4028(PropertyInfo arg_0, ILGenerator arg_1)
		{
			MethodInfo setMethod = arg_0.GetSetMethod(true);
			if (!setMethod.IsStatic)
			{
				arg_1.PushInstance(arg_0.DeclaringType);
			}
			arg_1.Emit(OpCodes.Ldarg_1);
			arg_1.UnboxIfNeeded(arg_0.PropertyType);
			arg_1.CallMethod(setMethod);
			arg_1.Return();
		}

		// Token: 0x04000B9D RID: 2973
		public static Class_481 field_0 = new Class_481();

		// Token: 0x0200028F RID: 655
		[CompilerGenerated]
		private sealed class NClass_0<T>
		{
			// Token: 0x06001624 RID: 5668 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06001625 RID: 5669 RVA: 0x00069300 File Offset: 0x00067500
			public object nmethod_1(T arg_0)
			{
				return this.constantValue;
			}

			// Token: 0x04000B9E RID: 2974
			public object field_0;
		}
	}
}
