using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200024B RID: 587
	public class Class_441 : Class_440
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0005C29B File Offset: 0x0005A49B
		internal static Class_440 prop_0
		{
			get
			{
				return Class_441.field_0;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0005C2A2 File Offset: 0x0005A4A2
		public bool prop_1
		{
			get
			{
				return Class_470.DynamicCodeGeneration;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0005C2A9 File Offset: 0x0005A4A9
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0005C2B1 File Offset: 0x0005A4B1
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags prop_2 { get; set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0005C2BA File Offset: 0x0005A4BA
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x0005C2C2 File Offset: 0x0005A4C2
		public bool prop_3 { get; set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0005C2CB File Offset: 0x0005A4CB
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x0005C2D3 File Offset: 0x0005A4D3
		public bool prop_4 { get; set; }

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0005C2DC File Offset: 0x0005A4DC
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x0005C2E4 File Offset: 0x0005A4E4
		public bool prop_5 { get; set; }

		// Token: 0x0600139C RID: 5020 RVA: 0x0005C2ED File Offset: 0x0005A4ED
		public Class_441() : this(false)
		{
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0005C2F6 File Offset: 0x0005A4F6
		public Class_441(bool bool_0)
		{
			this.prop_2 = (BindingFlags.Instance | BindingFlags.Public);
			this.prop_5 = true;
			this.field_5 = bool_0;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0005C31F File Offset: 0x0005A51F
		internal Class_444 gmethod_3553()
		{
			if (this.field_5)
			{
				return Class_441.field_3;
			}
			return this.field_4;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005C338 File Offset: 0x0005A538
		public virtual Class_349 cmethod_3554(Type arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("type");
			}
			Class_444 class_ = this.gmethod_3553();
			Class_443 key = new Class_443(base.GetType(), arg_0);
			Dictionary<Class_443, Class_349> dictionary = class_.field_0;
			Class_349 class_2;
			if (dictionary == null || !dictionary.TryGetValue(key, out class_2))
			{
				class_2 = this.kmethod_3577(arg_0);
				lock (Class_441.field_2)
				{
					dictionary = class_.field_0;
					Dictionary<Class_443, Class_349> dictionary2 = (dictionary != null) ? new Dictionary<Class_443, Class_349>(dictionary) : new Dictionary<Class_443, Class_349>();
					dictionary2[key] = class_2;
					class_.field_0 = dictionary2;
				}
			}
			return class_2;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005C3FC File Offset: 0x0005A5FC
		protected virtual List<MemberInfo> vmethod_3555(Type arg_0)
		{
			bool ignoreSerializableAttribute = this.prop_5;
			Class_383 objectMemberSerialization = Class_470.GetObjectMemberSerialization(arg_0, ignoreSerializableAttribute);
			IEnumerable<MemberInfo> fieldsAndProperties = Class_514.GetFieldsAndProperties(arg_0, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (Class_441.field_10 == null)
			{
				Class_441.field_10 = new Func<MemberInfo, bool>(Class_441.xmethod_3591);
			}
			List<MemberInfo> list = fieldsAndProperties.Where(Class_441.field_10).ToList<MemberInfo>();
			List<MemberInfo> list2 = new List<MemberInfo>();
			if (objectMemberSerialization != Class_383.Fields)
			{
				DataContractAttribute dataContractAttribute = Class_470.GetDataContractAttribute(arg_0);
				IEnumerable<MemberInfo> fieldsAndProperties2 = Class_514.GetFieldsAndProperties(arg_0, this.prop_2);
				if (Class_441.field_11 == null)
				{
					Class_441.field_11 = new Func<MemberInfo, bool>(Class_441.tmethod_3592);
				}
				List<MemberInfo> list3 = fieldsAndProperties2.Where(Class_441.field_11).ToList<MemberInfo>();
				foreach (MemberInfo memberInfo in list)
				{
					if (this.prop_3 || !memberInfo.IsDefined(typeof(CompilerGeneratedAttribute), true))
					{
						if (list3.Contains(memberInfo))
						{
							list2.Add(memberInfo);
						}
						else if (Class_470.GetAttribute<Class_410>(memberInfo) != null)
						{
							list2.Add(memberInfo);
						}
						else if (dataContractAttribute != null && Class_470.GetAttribute<DataMemberAttribute>(memberInfo) != null)
						{
							list2.Add(memberInfo);
						}
						else if (objectMemberSerialization == Class_383.Fields && memberInfo.MemberType == MemberTypes.Field)
						{
							list2.Add(memberInfo);
						}
					}
				}
				Type type;
				if (arg_0.AssignableToTypeName("System.Data.Objects.DataClasses.EntityObject", out type))
				{
					list2 = list2.Where(new Func<MemberInfo, bool>(this.dmethod_3556)).ToList<MemberInfo>();
				}
			}
			else
			{
				foreach (MemberInfo memberInfo2 in list)
				{
					FieldInfo fieldInfo = memberInfo2 as FieldInfo;
					if (fieldInfo != null && !fieldInfo.IsStatic)
					{
						list2.Add(memberInfo2);
					}
				}
			}
			return list2;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005C608 File Offset: 0x0005A808
		private bool dmethod_3556(MemberInfo arg_0)
		{
			PropertyInfo propertyInfo = arg_0 as PropertyInfo;
			return !(propertyInfo != null) || !propertyInfo.PropertyType.IsGenericType || !(propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1");
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0005C65C File Offset: 0x0005A85C
		protected virtual Class_464 kmethod_3557(Type arg_0)
		{
			Class_464 class_ = new Class_464(arg_0);
			this.dmethod_3566(class_);
			bool ignoreSerializableAttribute = this.prop_5;
			class_.prop_0 = Class_470.GetObjectMemberSerialization(class_.field_3, ignoreSerializableAttribute);
			class_.prop_2.AddRange(this.gmethod_3583(class_.field_3, class_.prop_0));
			Class_379 cachedAttribute = Class_470.GetCachedAttribute<Class_379>(class_.field_3);
			if (cachedAttribute != null)
			{
				class_.prop_1 = cachedAttribute._itemRequired;
			}
			if (class_.field_8)
			{
				ConstructorInfo constructorInfo = this.smethod_3560(class_.field_3);
				if (constructorInfo != null)
				{
					class_.prop_5 = constructorInfo;
					class_.prop_4.AddRange(this.tmethod_3562(constructorInfo, class_.prop_2));
				}
				else if (class_.prop_0 == Class_383.Fields)
				{
					if (Class_470.FullyTrusted)
					{
						class_.prop_15 = new Func<object>(class_.dmethod_3846);
					}
				}
				else if (class_.prop_15 == null || class_.prop_16)
				{
					ConstructorInfo constructorInfo2 = this.xmethod_3561(class_.field_3);
					if (constructorInfo2 != null)
					{
						class_.prop_6 = constructorInfo2;
						class_.prop_4.AddRange(this.tmethod_3562(constructorInfo2, class_.prop_2));
					}
				}
			}
			MemberInfo memberInfo = this.lmethod_3558(class_.field_3);
			if (memberInfo != null)
			{
				Class_441.pmethod_3559(class_, memberInfo);
			}
			return class_;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005C7B8 File Offset: 0x0005A9B8
		private MemberInfo lmethod_3558(Type arg_0)
		{
			IEnumerable<Type> source = this.pmethod_3569(arg_0);
			if (Class_441.field_12 == null)
			{
				Class_441.field_12 = new Func<Type, IEnumerable<MemberInfo>>(Class_441.gmethod_3593);
			}
			IEnumerable<MemberInfo> enumerable = source.SelectMany(Class_441.field_12);
			IEnumerable<MemberInfo> source2 = enumerable;
			if (Class_441.field_13 == null)
			{
				Class_441.field_13 = new Func<MemberInfo, bool>(Class_441.cmethod_3594);
			}
			return source2.LastOrDefault(Class_441.field_13);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005C81C File Offset: 0x0005AA1C
		private static void pmethod_3559(Class_464 arg_0, MemberInfo arg_1)
		{
			Class_441.NClass_1 nclass_ = new Class_441.NClass_1();
			Class_324 attribute = Class_514.GetAttribute<Class_324>(arg_1);
			if (attribute == null)
			{
				return;
			}
			Type memberUnderlyingType = Class_514.GetMemberUnderlyingType(arg_1);
			Type type;
			Class_514.ImplementsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >), out type);
			Type type2 = type.GetGenericArguments()[0];
			Type type3 = type.GetGenericArguments()[1];
			nclass_.field_1 = typeof(Class_361).IsAssignableFrom(type3);
			Type arg_2;
			if (Class_514.IsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >)))
			{
				arg_2 = typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					type2,
					type3
				});
			}
			else
			{
				arg_2 = memberUnderlyingType;
			}
			MethodInfo method = memberUnderlyingType.GetMethod("Add", new Type[]
			{
				type2,
				type3
			});
			nclass_.field_2 = Class_470.ReflectionDelegateFactory.dmethod_4006<object>(arg_1);
			nclass_.field_3 = Class_470.ReflectionDelegateFactory.kmethod_4007<object>(arg_1);
			nclass_.field_4 = Class_470.ReflectionDelegateFactory.smethod_4010<object>(arg_2);
			nclass_.field_5 = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method);
			Class_451 arg_3 = new Class_451(nclass_.nmethod_9);
			Type type4 = typeof(Class_441.NClass_0<, >).MakeGenericType(new Type[]
			{
				type2,
				type3
			});
			ConstructorInfo arg_4 = type4.GetConstructors().First<ConstructorInfo>();
			nclass_.field_6 = Class_470.ReflectionDelegateFactory.pmethod_4009(arg_4);
			Class_452 arg_5 = new Class_452(nclass_.nmethod_10);
			if (attribute.prop_1)
			{
				arg_0.prop_9 = arg_3;
			}
			if (attribute.prop_0)
			{
				arg_0.prop_10 = arg_5;
			}
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0005C9D8 File Offset: 0x0005ABD8
		private ConstructorInfo smethod_3560(Type arg_0)
		{
			IEnumerable<ConstructorInfo> constructors = arg_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (Class_441.field_14 == null)
			{
				Class_441.field_14 = new Func<ConstructorInfo, bool>(Class_441.vmethod_3595);
			}
			IList<ConstructorInfo> list = constructors.Where(Class_441.field_14).ToList<ConstructorInfo>();
			if (list.Count > 1)
			{
				throw new Class_318("Multiple constructors with the JsonConstructorAttribute.");
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			if (arg_0 == typeof(Version))
			{
				return arg_0.GetConstructor(new Type[]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				});
			}
			return null;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0005CAAC File Offset: 0x0005ACAC
		private ConstructorInfo xmethod_3561(Type arg_0)
		{
			IList<ConstructorInfo> list = arg_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public).ToList<ConstructorInfo>();
			if (list.Count == 1)
			{
				return list[0];
			}
			return null;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0005CADC File Offset: 0x0005ACDC
		protected virtual IList<Class_454> tmethod_3562(ConstructorInfo arg_0, Class_455 arg_1)
		{
			ParameterInfo[] parameters = arg_0.GetParameters();
			Class_455 class_ = new Class_455(arg_0.DeclaringType);
			foreach (ParameterInfo parameterInfo in parameters)
			{
				Class_454 class_2 = (parameterInfo.Name != null) ? arg_1.cmethod_3704(parameterInfo.Name) : null;
				if (class_2 != null && class_2.prop_7 != parameterInfo.ParameterType)
				{
					class_2 = null;
				}
				if (class_2 != null || parameterInfo.Name != null)
				{
					Class_454 class_3 = this.gmethod_3563(class_2, parameterInfo);
					if (class_3 != null)
					{
						class_.gmethod_3703(class_3);
					}
				}
			}
			return class_;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0005CB90 File Offset: 0x0005AD90
		protected virtual Class_454 gmethod_3563(Class_454 arg_0, ParameterInfo arg_1)
		{
			Class_454 class_ = new Class_454();
			class_.prop_7 = arg_1.ParameterType;
			class_.prop_6 = new Class_352(arg_1);
			bool flag;
			this.dmethod_3586(class_, arg_1, arg_1.Name, arg_1.Member.DeclaringType, Class_383.OptOut, out flag);
			class_.prop_11 = false;
			class_.prop_12 = true;
			if (arg_0 != null)
			{
				class_.prop_1 = ((class_.prop_1 != arg_1.Name) ? class_.prop_1 : arg_0.prop_1);
				class_.prop_8 = (class_.prop_8 ?? arg_0.prop_8);
				class_.prop_9 = (class_.prop_9 ?? arg_0.prop_9);
				if (!class_.field_1 && arg_0.field_1)
				{
					class_.prop_14 = arg_0.prop_14;
				}
				Class_454 class_2 = class_;
				Class_364? class_3 = class_.field_0;
				class_2.field_0 = ((class_3 != null) ? new Class_364?(class_3.GetValueOrDefault()) : arg_0.field_0);
				Class_454 class_4 = class_;
				bool? flag2 = class_.prop_16;
				class_4.prop_16 = ((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : arg_0.prop_16);
				Class_454 class_5 = class_;
				Class_457? class_6 = class_.prop_17;
				class_5.prop_17 = ((class_6 != null) ? new Class_457?(class_6.GetValueOrDefault()) : arg_0.prop_17);
				Class_454 class_7 = class_;
				Class_377? class_8 = class_.prop_18;
				class_7.prop_18 = ((class_8 != null) ? new Class_377?(class_8.GetValueOrDefault()) : arg_0.prop_18);
				Class_454 class_9 = class_;
				Class_458? class_10 = class_.prop_19;
				class_9.prop_19 = ((class_10 != null) ? new Class_458?(class_10.GetValueOrDefault()) : arg_0.prop_19);
				Class_454 class_11 = class_;
				Class_384? class_12 = class_.prop_20;
				class_11.prop_20 = ((class_12 != null) ? new Class_384?(class_12.GetValueOrDefault()) : arg_0.prop_20);
				Class_454 class_13 = class_;
				Class_494? class_14 = class_.prop_21;
				class_13.prop_21 = ((class_14 != null) ? new Class_494?(class_14.GetValueOrDefault()) : arg_0.prop_21);
			}
			return class_;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0005CDC2 File Offset: 0x0005AFC2
		protected virtual Class_299 cmethod_3564(Type arg_0)
		{
			return Class_470.GetJsonConverter(arg_0);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0005CDCA File Offset: 0x0005AFCA
		private Func<object> vmethod_3565(Type arg_0)
		{
			return Class_470.ReflectionDelegateFactory.smethod_4010<object>(arg_0);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0005CDD8 File Offset: 0x0005AFD8
		[SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Runtime.Serialization.DataContractAttribute.#get_IsReference()")]
		private void dmethod_3566(Class_349 arg_0)
		{
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(arg_0.field_3);
			if (cachedAttribute != null)
			{
				arg_0.prop_2 = cachedAttribute.field_0;
			}
			else
			{
				DataContractAttribute dataContractAttribute = Class_470.GetDataContractAttribute(arg_0.field_3);
				if (dataContractAttribute != null && dataContractAttribute.IsReference)
				{
					arg_0.prop_2 = new bool?(true);
				}
			}
			arg_0.prop_3 = this.cmethod_3564(arg_0.field_3);
			arg_0.prop_4 = Class_418.xmethod_3181(Class_441.field_1, arg_0.field_3);
			if (arg_0.field_8 && (Class_514.HasDefaultConstructor(arg_0.prop_1, true) || arg_0.prop_1.IsValueType))
			{
				arg_0.prop_15 = this.vmethod_3565(arg_0.prop_1);
				arg_0.prop_16 = (!arg_0.prop_1.IsValueType && Class_514.GetDefaultConstructor(arg_0.prop_1) == null);
			}
			this.kmethod_3567(arg_0, arg_0.field_3);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0005CED4 File Offset: 0x0005B0D4
		private void kmethod_3567(Class_349 arg_0, Type arg_1)
		{
			List<Class_449> list;
			List<Class_449> list2;
			List<Class_449> list3;
			List<Class_449> list4;
			List<Class_450> list5;
			this.lmethod_3568(arg_1, out list, out list2, out list3, out list4, out list5);
			if (list != null && arg_1.Name != "FSharpSet`1" && arg_1.Name != "FSharpMap`2")
			{
				arg_0.prop_8.AddRange(list);
			}
			if (list2 != null)
			{
				arg_0.prop_7.AddRange(list2);
			}
			if (list3 != null)
			{
				arg_0.prop_6.AddRange(list3);
			}
			if (list4 != null && arg_1.Name != "FSharpSet`1" && arg_1.Name != "FSharpMap`2" && (!arg_1.IsGenericType || arg_1.GetGenericTypeDefinition() != typeof(ConcurrentDictionary<, >)))
			{
				arg_0.prop_5.AddRange(list4);
			}
			if (list5 != null)
			{
				arg_0.prop_9.AddRange(list5);
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0005CFC8 File Offset: 0x0005B1C8
		private void lmethod_3568(Type arg_0, out List<Class_449> arg_1, out List<Class_449> arg_2, out List<Class_449> arg_3, out List<Class_449> arg_4, out List<Class_450> arg_5)
		{
			arg_1 = null;
			arg_2 = null;
			arg_3 = null;
			arg_4 = null;
			arg_5 = null;
			foreach (Type type in this.pmethod_3569(arg_0))
			{
				MethodInfo arg_6 = null;
				MethodInfo arg_7 = null;
				MethodInfo arg_8 = null;
				MethodInfo arg_9 = null;
				MethodInfo arg_10 = null;
				foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					if (!methodInfo.ContainsGenericParameters)
					{
						Type type2 = null;
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (Class_441.xmethod_3581(methodInfo, parameters, typeof(OnSerializingAttribute), arg_6, ref type2))
						{
							arg_1 = (arg_1 ?? new List<Class_449>());
							arg_1.Add(Class_349.lmethod_2348(methodInfo));
							arg_6 = methodInfo;
						}
						if (Class_441.xmethod_3581(methodInfo, parameters, typeof(OnSerializedAttribute), arg_7, ref type2))
						{
							arg_2 = (arg_2 ?? new List<Class_449>());
							arg_2.Add(Class_349.lmethod_2348(methodInfo));
							arg_7 = methodInfo;
						}
						if (Class_441.xmethod_3581(methodInfo, parameters, typeof(OnDeserializingAttribute), arg_8, ref type2))
						{
							arg_3 = (arg_3 ?? new List<Class_449>());
							arg_3.Add(Class_349.lmethod_2348(methodInfo));
							arg_8 = methodInfo;
						}
						if (Class_441.xmethod_3581(methodInfo, parameters, typeof(OnDeserializedAttribute), arg_9, ref type2))
						{
							arg_4 = (arg_4 ?? new List<Class_449>());
							arg_4.Add(Class_349.lmethod_2348(methodInfo));
							arg_9 = methodInfo;
						}
						if (Class_441.xmethod_3581(methodInfo, parameters, typeof(Class_473), arg_10, ref type2))
						{
							arg_5 = (arg_5 ?? new List<Class_450>());
							arg_5.Add(Class_349.pmethod_2349(methodInfo));
							arg_10 = methodInfo;
						}
					}
				}
			}
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0005D1CC File Offset: 0x0005B3CC
		private List<Type> pmethod_3569(Type arg_0)
		{
			List<Type> list = new List<Type>();
			Type type = arg_0;
			while (type != null && type != typeof(object))
			{
				list.Add(type);
				type = type.BaseType;
			}
			list.Reverse();
			return list;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005D21C File Offset: 0x0005B41C
		protected virtual Class_453 smethod_3570(Type arg_0)
		{
			Class_453 class_ = new Class_453(arg_0);
			this.dmethod_3566(class_);
			class_.prop_0 = new Func<string, string>(this.pmethod_3589);
			return class_;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005D24C File Offset: 0x0005B44C
		protected virtual Class_447 xmethod_3571(Type arg_0)
		{
			Class_447 class_ = new Class_447(arg_0);
			this.dmethod_3566(class_);
			return class_;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005D268 File Offset: 0x0005B468
		protected virtual Class_369 tmethod_3572(Type arg_0)
		{
			Class_369 class_ = new Class_369(arg_0);
			this.dmethod_3566(class_);
			return class_;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0005D284 File Offset: 0x0005B484
		protected virtual Class_368 gmethod_3573(Type arg_0)
		{
			Class_368 class_ = new Class_368(arg_0);
			this.dmethod_3566(class_);
			return class_;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0005D2A0 File Offset: 0x0005B4A0
		protected virtual Class_367 cmethod_3574(Type arg_0)
		{
			Class_367 class_ = new Class_367(arg_0);
			this.dmethod_3566(class_);
			ConstructorInfo constructor = class_.field_3.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (constructor != null)
			{
				Class_482<object> arg_ = Class_470.ReflectionDelegateFactory.pmethod_4009(constructor);
				class_.prop_0 = arg_;
			}
			return class_;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0005D318 File Offset: 0x0005B518
		protected virtual Class_365 vmethod_3575(Type arg_0)
		{
			Class_365 class_ = new Class_365(arg_0);
			this.dmethod_3566(class_);
			class_.prop_1 = new Func<string, string>(this.pmethod_3589);
			class_.prop_0.AddRange(this.gmethod_3583(arg_0, Class_383.OptOut));
			return class_;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0005D35C File Offset: 0x0005B55C
		protected virtual Class_469 dmethod_3576(Type arg_0)
		{
			Class_469 class_ = new Class_469(arg_0);
			this.dmethod_3566(class_);
			return class_;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0005D378 File Offset: 0x0005B578
		protected virtual Class_349 kmethod_3577(Type arg_0)
		{
			if (Class_441.lmethod_3578(arg_0))
			{
				return this.tmethod_3572(arg_0);
			}
			Type type = Class_514.EnsureNotNullableType(arg_0);
			Class_316 cachedAttribute = Class_470.GetCachedAttribute<Class_316>(type);
			if (cachedAttribute is Class_379)
			{
				return this.kmethod_3557(arg_0);
			}
			if (cachedAttribute is Class_376)
			{
				return this.xmethod_3571(arg_0);
			}
			if (cachedAttribute is Class_317)
			{
				return this.smethod_3570(arg_0);
			}
			if (type == typeof(Class_361) || type.IsSubclassOf(typeof(Class_361)))
			{
				return this.gmethod_3573(arg_0);
			}
			if (Class_510.IsDictionaryType(type))
			{
				return this.smethod_3570(arg_0);
			}
			if (typeof(IEnumerable).IsAssignableFrom(type))
			{
				return this.xmethod_3571(arg_0);
			}
			if (Class_441.smethod_3580(type))
			{
				return this.dmethod_3576(arg_0);
			}
			if (!this.prop_4 && typeof(ISerializable).IsAssignableFrom(type))
			{
				return this.cmethod_3574(arg_0);
			}
			if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
			{
				return this.vmethod_3575(arg_0);
			}
			if (Class_441.pmethod_3579(type))
			{
				return this.tmethod_3572(type);
			}
			return this.kmethod_3557(arg_0);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0005D4B4 File Offset: 0x0005B6B4
		internal static bool lmethod_3578(Type arg_0)
		{
			Class_496 typeCode = Class_499.GetTypeCode(arg_0);
			return typeCode != Class_496.Empty && typeCode != Class_496.Object;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0005D4D8 File Offset: 0x0005B6D8
		internal static bool pmethod_3579(Type arg_0)
		{
			return (typeof(IConvertible).IsAssignableFrom(arg_0) || (Class_514.IsNullableType(arg_0) && typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(arg_0)))) && !typeof(Class_361).IsAssignableFrom(arg_0);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0005D534 File Offset: 0x0005B734
		internal static bool smethod_3580(Type arg_0)
		{
			TypeConverter typeConverter = Class_470.GetTypeConverter(arg_0);
			return (typeConverter != null && !(typeConverter is ComponentConverter) && !(typeConverter is ReferenceConverter) && typeConverter.GetType() != typeof(TypeConverter) && typeConverter.CanConvertTo(typeof(string))) || (arg_0 == typeof(Type) || arg_0.IsSubclassOf(typeof(Type)));
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0005D5C4 File Offset: 0x0005B7C4
		private static bool xmethod_3581(MethodInfo arg_0, ParameterInfo[] arg_1, Type arg_2, MethodInfo arg_3, ref Type arg_4)
		{
			if (!arg_0.IsDefined(arg_2, false))
			{
				return false;
			}
			if (arg_3 != null)
			{
				throw new Class_318("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".FormatWith(CultureInfo.InvariantCulture, arg_0, arg_3, Class_441.tmethod_3582(arg_0.DeclaringType), arg_2));
			}
			if (arg_4 != null)
			{
				throw new Class_318("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".FormatWith(CultureInfo.InvariantCulture, arg_4, arg_2, Class_441.tmethod_3582(arg_0.DeclaringType), arg_0));
			}
			if (arg_0.IsVirtual)
			{
				throw new Class_318("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".FormatWith(CultureInfo.InvariantCulture, arg_0, Class_441.tmethod_3582(arg_0.DeclaringType), arg_2));
			}
			if (arg_0.ReturnType != typeof(void))
			{
				throw new Class_318("Serialization Callback '{1}' in type '{0}' must return void.".FormatWith(CultureInfo.InvariantCulture, Class_441.tmethod_3582(arg_0.DeclaringType), arg_0));
			}
			if (arg_2 == typeof(Class_473))
			{
				if (arg_1 == null || arg_1.Length != 2 || arg_1[0].ParameterType != typeof(StreamingContext) || arg_1[1].ParameterType != typeof(Class_446))
				{
					throw new Class_318("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".FormatWith(CultureInfo.InvariantCulture, Class_441.tmethod_3582(arg_0.DeclaringType), arg_0, typeof(StreamingContext), typeof(Class_446)));
				}
			}
			else if (arg_1 == null || arg_1.Length != 1 || arg_1[0].ParameterType != typeof(StreamingContext))
			{
				throw new Class_318("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".FormatWith(CultureInfo.InvariantCulture, Class_441.tmethod_3582(arg_0.DeclaringType), arg_0, typeof(StreamingContext)));
			}
			arg_4 = arg_2;
			return true;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
		internal static string tmethod_3582(Type arg_0)
		{
			if (arg_0.IsGenericTypeDefinition || !arg_0.ContainsGenericParameters)
			{
				return arg_0.FullName;
			}
			return string.Format(CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				arg_0.Namespace,
				arg_0.Name
			});
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
		protected virtual IList<Class_454> gmethod_3583(Type arg_0, Class_383 arg_1)
		{
			List<MemberInfo> list = this.vmethod_3555(arg_0);
			if (list == null)
			{
				throw new Class_417("Null collection of seralizable members returned.");
			}
			Class_455 class_ = new Class_455(arg_0);
			foreach (MemberInfo arg_2 in list)
			{
				Class_454 class_2 = this.vmethod_3585(arg_2, arg_1);
				if (class_2 != null)
				{
					Class_444 class_3 = this.gmethod_3553();
					lock (class_3.field_1)
					{
						class_2.prop_1 = class_3.field_1.smethod_4040(class_2.prop_1);
					}
					class_.gmethod_3703(class_2);
				}
			}
			IEnumerable<Class_454> source = class_;
			if (Class_441.field_15 == null)
			{
				Class_441.field_15 = new Func<Class_454, int>(Class_441.dmethod_3596);
			}
			return source.OrderBy(Class_441.field_15).ToList<Class_454>();
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0005D904 File Offset: 0x0005BB04
		protected virtual Class_346 cmethod_3584(MemberInfo arg_0)
		{
			Class_346 result;
			if (this.prop_1)
			{
				result = new Class_370(arg_0);
			}
			else
			{
				result = new Class_472(arg_0);
			}
			return result;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0005D930 File Offset: 0x0005BB30
		protected virtual Class_454 vmethod_3585(MemberInfo arg_0, Class_383 arg_1)
		{
			Class_454 class_ = new Class_454();
			class_.prop_7 = Class_514.GetMemberUnderlyingType(arg_0);
			class_.prop_2 = arg_0.DeclaringType;
			class_.prop_5 = this.cmethod_3584(arg_0);
			class_.prop_6 = new Class_352(arg_0);
			bool flag;
			this.dmethod_3586(class_, arg_0, arg_0.Name, arg_0.DeclaringType, arg_1, out flag);
			if (arg_1 != Class_383.Fields)
			{
				class_.prop_11 = Class_514.CanReadMemberValue(arg_0, flag);
				class_.prop_12 = Class_514.CanSetMemberValue(arg_0, flag, class_.prop_13);
			}
			else
			{
				class_.prop_11 = true;
				class_.prop_12 = true;
			}
			class_.prop_22 = this.kmethod_3587(arg_0);
			this.lmethod_3588(class_, arg_0, flag);
			return class_;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0005D9DC File Offset: 0x0005BBDC
		private void dmethod_3586(Class_454 arg_0, object obje_0, string str_0, Type arg_1, Class_383 arg_2, out bool arg_3)
		{
			DataContractAttribute dataContractAttribute = Class_470.GetDataContractAttribute(arg_1);
			MemberInfo memberInfo = obje_0 as MemberInfo;
			DataMemberAttribute dataMemberAttribute;
			if (dataContractAttribute != null && memberInfo != null)
			{
				dataMemberAttribute = Class_470.GetDataMemberAttribute(memberInfo);
			}
			else
			{
				dataMemberAttribute = null;
			}
			Class_410 attribute = Class_470.GetAttribute<Class_410>(obje_0);
			if (attribute != null)
			{
				arg_0.prop_13 = true;
			}
			string str_;
			if (attribute != null && attribute.PropertyName != null)
			{
				str_ = attribute.PropertyName;
			}
			else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
			{
				str_ = dataMemberAttribute.Name;
			}
			else
			{
				str_ = str_0;
			}
			arg_0.prop_1 = this.pmethod_3589(str_);
			arg_0.prop_4 = str_0;
			bool flag = false;
			if (attribute != null)
			{
				arg_0.field_0 = attribute._required;
				arg_0.prop_3 = attribute._order;
				arg_0.prop_18 = attribute._defaultValueHandling;
				flag = true;
			}
			else if (dataMemberAttribute != null)
			{
				arg_0.field_0 = new Class_364?(dataMemberAttribute.IsRequired ? Class_364.AllowNull : Class_364.Default);
				arg_0.prop_3 = ((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
				arg_0.prop_18 = ((!dataMemberAttribute.EmitDefaultValue) ? new Class_377?(Class_377.Ignore) : null);
				flag = true;
			}
			bool flag2 = Class_470.GetAttribute<Class_411>(obje_0) != null || Class_470.GetAttribute<Class_324>(obje_0) != null || Class_470.GetAttribute<NonSerializedAttribute>(obje_0) != null;
			if (arg_2 != Class_383.OptIn)
			{
				bool flag3 = Class_470.GetAttribute<IgnoreDataMemberAttribute>(obje_0) != null;
				arg_0.prop_10 = (flag2 || flag3);
			}
			else
			{
				arg_0.prop_10 = (flag2 || !flag);
			}
			arg_0.prop_8 = Class_470.GetJsonConverter(obje_0);
			arg_0.prop_9 = Class_470.GetJsonConverter(obje_0);
			DefaultValueAttribute attribute2 = Class_470.GetAttribute<DefaultValueAttribute>(obje_0);
			if (attribute2 != null)
			{
				arg_0.prop_14 = attribute2.Value;
			}
			arg_0.prop_17 = ((attribute != null) ? attribute._nullValueHandling : null);
			arg_0.prop_19 = ((attribute != null) ? attribute._referenceLoopHandling : null);
			arg_0.prop_20 = ((attribute != null) ? attribute._objectCreationHandling : null);
			arg_0.prop_21 = ((attribute != null) ? attribute._typeNameHandling : null);
			arg_0.prop_16 = ((attribute != null) ? attribute._isReference : null);
			arg_0.prop_26 = ((attribute != null) ? attribute._itemIsReference : null);
			arg_0.prop_25 = ((attribute != null && attribute.ItemConverterType != null) ? Class_470.CreateJsonConverterInstance(attribute.ItemConverterType, attribute.ItemConverterParameters) : null);
			arg_0.prop_28 = ((attribute != null) ? attribute._itemReferenceLoopHandling : null);
			arg_0.prop_27 = ((attribute != null) ? attribute._itemTypeNameHandling : null);
			arg_3 = false;
			if ((this.prop_2 & BindingFlags.NonPublic) == BindingFlags.NonPublic)
			{
				arg_3 = true;
			}
			if (attribute != null)
			{
				arg_3 = true;
			}
			if (arg_2 == Class_383.Fields)
			{
				arg_3 = true;
			}
			if (dataMemberAttribute != null)
			{
				arg_3 = true;
				arg_0.prop_13 = true;
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0005DD54 File Offset: 0x0005BF54
		private Predicate<object> kmethod_3587(MemberInfo arg_0)
		{
			Class_441.NClass_2 nclass_ = new Class_441.NClass_2();
			MethodInfo method = arg_0.DeclaringType.GetMethod("ShouldSerialize" + arg_0.Name, Class_514.EmptyTypes);
			if (method == null || method.ReturnType != typeof(bool))
			{
				return null;
			}
			nclass_.field_7 = Class_470.ReflectionDelegateFactory.lmethod_4008<object>(method);
			return new Predicate<object>(nclass_.nmethod_12);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005DDD0 File Offset: 0x0005BFD0
		private void lmethod_3588(Class_454 arg_0, MemberInfo arg_1, bool bool_0)
		{
			Class_441.NClass_3 nclass_ = new Class_441.NClass_3();
			MemberInfo memberInfo = arg_1.DeclaringType.GetProperty(arg_1.Name + "Specified");
			if (memberInfo == null)
			{
				memberInfo = arg_1.DeclaringType.GetField(arg_1.Name + "Specified");
			}
			if (memberInfo == null || Class_514.GetMemberUnderlyingType(memberInfo) != typeof(bool))
			{
				return;
			}
			nclass_.field_8 = Class_470.ReflectionDelegateFactory.dmethod_4006<object>(memberInfo);
			arg_0.prop_23 = new Predicate<object>(nclass_.nmethod_14);
			if (Class_514.CanSetMemberValue(memberInfo, bool_0, false))
			{
				arg_0.prop_24 = Class_470.ReflectionDelegateFactory.kmethod_4007<object>(memberInfo);
			}
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0005DE8F File Offset: 0x0005C08F
		protected internal virtual string pmethod_3589(string str_0)
		{
			return str_0;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0005DE92 File Offset: 0x0005C092
		public string smethod_3590(string str_0)
		{
			return this.pmethod_3589(str_0);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0005DE9B File Offset: 0x0005C09B
		[CompilerGenerated]
		private static bool xmethod_3591(MemberInfo arg_0)
		{
			return !Class_514.IsIndexedProperty(arg_0);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0005DE9B File Offset: 0x0005C09B
		[CompilerGenerated]
		private static bool tmethod_3592(MemberInfo arg_0)
		{
			return !Class_514.IsIndexedProperty(arg_0);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		[CompilerGenerated]
		private static IEnumerable<MemberInfo> gmethod_3593(Type arg_0)
		{
			IList<MemberInfo> list = new List<MemberInfo>();
			list.AddRange(arg_0.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			list.AddRange(arg_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			return list;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0005DED8 File Offset: 0x0005C0D8
		[CompilerGenerated]
		private static bool cmethod_3594(MemberInfo arg_0)
		{
			MemberTypes memberType = arg_0.MemberType;
			if (memberType != MemberTypes.Property && memberType != MemberTypes.Field)
			{
				return false;
			}
			if (!arg_0.IsDefined(typeof(Class_324), false))
			{
				return false;
			}
			Type memberUnderlyingType = Class_514.GetMemberUnderlyingType(arg_0);
			Type type;
			if (Class_514.ImplementsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >), out type))
			{
				Type type2 = type.GetGenericArguments()[0];
				Type type3 = type.GetGenericArguments()[1];
				if (type2.IsAssignableFrom(typeof(string)) && type3.IsAssignableFrom(typeof(Class_361)))
				{
					return true;
				}
			}
			throw new Class_318("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".FormatWith(CultureInfo.InvariantCulture, Class_441.tmethod_3582(arg_0.DeclaringType), arg_0.Name));
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005DFA0 File Offset: 0x0005C1A0
		[CompilerGenerated]
		private static bool vmethod_3595(ConstructorInfo arg_0)
		{
			return arg_0.IsDefined(typeof(Class_323), true);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005DFB4 File Offset: 0x0005C1B4
		[CompilerGenerated]
		private static int dmethod_3596(Class_454 arg_0)
		{
			int? num = arg_0.prop_3;
			if (num == null)
			{
				return -1;
			}
			return num.GetValueOrDefault();
		}

		// Token: 0x04000A61 RID: 2657
		private static readonly Class_440 field_0 = new Class_441(true);

		// Token: 0x04000A62 RID: 2658
		private static readonly Class_299[] field_1 = new Class_299[]
		{
			new Class_306(),
			new Class_307(),
			new Class_407(),
			new Class_300(),
			new Class_301(),
			new Class_302(),
			new Class_305(),
			new Class_308(),
			new Class_309(),
			new Class_310()
		};

		// Token: 0x04000A63 RID: 2659
		private static readonly object field_2 = new object();

		// Token: 0x04000A64 RID: 2660
		private static readonly Class_444 field_3 = new Class_444();

		// Token: 0x04000A65 RID: 2661
		private readonly Class_444 field_4 = new Class_444();

		// Token: 0x04000A66 RID: 2662
		private readonly bool field_5;

		// Token: 0x04000A67 RID: 2663
		[CompilerGenerated]
		private BindingFlags field_6;

		// Token: 0x04000A68 RID: 2664
		[CompilerGenerated]
		private bool field_7;

		// Token: 0x04000A69 RID: 2665
		[CompilerGenerated]
		private bool field_8;

		// Token: 0x04000A6A RID: 2666
		[CompilerGenerated]
		private bool field_9;

		// Token: 0x04000A6B RID: 2667
		[CompilerGenerated]
		private static Func<MemberInfo, bool> field_10;

		// Token: 0x04000A6C RID: 2668
		[CompilerGenerated]
		private static Func<MemberInfo, bool> field_11;

		// Token: 0x04000A6D RID: 2669
		[CompilerGenerated]
		private static Func<Type, IEnumerable<MemberInfo>> field_12;

		// Token: 0x04000A6E RID: 2670
		[CompilerGenerated]
		private static Func<MemberInfo, bool> field_13;

		// Token: 0x04000A6F RID: 2671
		[CompilerGenerated]
		private static Func<ConstructorInfo, bool> field_14;

		// Token: 0x04000A70 RID: 2672
		[CompilerGenerated]
		private static Func<Class_454, int> field_15;

		// Token: 0x0200024C RID: 588
		internal struct NClass_0<TEnumeratorKey, TEnumeratorValue> : IEnumerable, IEnumerator, IDisposable, IEnumerable<KeyValuePair<object, object>>, IEnumerator<KeyValuePair<object, object>>
		{
			// Token: 0x060013CB RID: 5067 RVA: 0x0005E093 File Offset: 0x0005C293
			public void nmethod_0(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> arg_0)
			{
				Class_517.ArgumentNotNull(arg_0, "e");
				this._e = arg_0.GetEnumerator();
			}

			// Token: 0x060013CC RID: 5068 RVA: 0x0005E0AC File Offset: 0x0005C2AC
			public bool nmethod_1()
			{
				return this._e.MoveNext();
			}

			// Token: 0x060013CD RID: 5069 RVA: 0x0005E0B9 File Offset: 0x0005C2B9
			public void nmethod_2()
			{
				this._e.Reset();
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x060013CE RID: 5070 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
			public KeyValuePair<object, object> nprop_0
			{
				get
				{
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair = this._e.Current;
					object key = keyValuePair.Key;
					KeyValuePair<TEnumeratorKey, TEnumeratorValue> keyValuePair2 = this._e.Current;
					return new KeyValuePair<object, object>(key, keyValuePair2.Value);
				}
			}

			// Token: 0x060013CF RID: 5071 RVA: 0x0005E10A File Offset: 0x0005C30A
			public void nmethod_4()
			{
				this._e.Dispose();
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0005E117 File Offset: 0x0005C317
			object IEnumerator.nprop_1
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x060013D1 RID: 5073 RVA: 0x0005E124 File Offset: 0x0005C324
			public IEnumerator<KeyValuePair<object, object>> nmethod_6()
			{
				return this;
			}

			// Token: 0x060013D2 RID: 5074 RVA: 0x0005E124 File Offset: 0x0005C324
			IEnumerator IEnumerable.nmethod_7()
			{
				return this;
			}

			// Token: 0x04000A71 RID: 2673
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> field_0;
		}

		// Token: 0x0200024D RID: 589
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x060013D3 RID: 5075 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_8()
			{
				base..ctor();
			}

			// Token: 0x060013D4 RID: 5076 RVA: 0x0005E134 File Offset: 0x0005C334
			public void nmethod_9(object obje_0, string str_0, object obje_1)
			{
				object obj = this.field_2(obje_0);
				if (obj == null)
				{
					obj = this.field_4();
					this.field_3(obje_0, obj);
				}
				if (this.field_1 && !(obje_1 is Class_361))
				{
					obje_1 = ((obje_1 != null) ? Class_361.smethod_2560(obje_1) : Class_362.kmethod_2597());
				}
				this.field_5(obj, new object[]
				{
					str_0,
					obje_1
				});
			}

			// Token: 0x060013D5 RID: 5077 RVA: 0x0005E1B8 File Offset: 0x0005C3B8
			public IEnumerable<KeyValuePair<object, object>> nmethod_10(object obje_0)
			{
				object obj = this.field_2(obje_0);
				if (obj == null)
				{
					return null;
				}
				return (IEnumerable<KeyValuePair<object, object>>)this.field_6(new object[]
				{
					obj
				});
			}

			// Token: 0x04000A72 RID: 2674
			public bool field_1;

			// Token: 0x04000A73 RID: 2675
			public Func<object, object> field_2;

			// Token: 0x04000A74 RID: 2676
			public Action<object, object> field_3;

			// Token: 0x04000A75 RID: 2677
			public Func<object> field_4;

			// Token: 0x04000A76 RID: 2678
			public Class_489<object, object> field_5;

			// Token: 0x04000A77 RID: 2679
			public Class_482<object> field_6;
		}

		// Token: 0x0200024E RID: 590
		[CompilerGenerated]
		private sealed class NClass_2
		{
			// Token: 0x060013D6 RID: 5078 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_11()
			{
				base..ctor();
			}

			// Token: 0x060013D7 RID: 5079 RVA: 0x0005E1F6 File Offset: 0x0005C3F6
			public bool nmethod_12(object obje_0)
			{
				return (bool)this.field_7(obje_0, new object[0]);
			}

			// Token: 0x04000A78 RID: 2680
			public Class_489<object, object> field_7;
		}

		// Token: 0x0200024F RID: 591
		[CompilerGenerated]
		private sealed class NClass_3
		{
			// Token: 0x060013D8 RID: 5080 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_13()
			{
				base..ctor();
			}

			// Token: 0x060013D9 RID: 5081 RVA: 0x0005E20F File Offset: 0x0005C40F
			public bool nmethod_14(object obje_0)
			{
				return (bool)this.field_8(obje_0);
			}

			// Token: 0x04000A79 RID: 2681
			public Func<object, object> field_8;
		}
	}
}
