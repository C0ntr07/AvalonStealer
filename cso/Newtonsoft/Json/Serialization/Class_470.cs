using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000273 RID: 627
	internal static class Class_470
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x0006711D File Offset: 0x0006531D
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			return Class_471<T>.GetAttribute(attributeProvider);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00067128 File Offset: 0x00065328
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			Type type2 = type;
			while (type2 != null)
			{
				DataContractAttribute attribute = Class_471<DataContractAttribute>.GetAttribute(type2);
				if (attribute != null)
				{
					return attribute;
				}
				type2 = type2.BaseType;
			}
			return null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006715C File Offset: 0x0006535C
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			if (memberInfo.MemberType == MemberTypes.Field)
			{
				return Class_471<DataMemberAttribute>.GetAttribute(memberInfo);
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
			DataMemberAttribute attribute = Class_471<DataMemberAttribute>.GetAttribute(propertyInfo);
			if (attribute == null && propertyInfo.IsVirtual())
			{
				Type type = propertyInfo.DeclaringType;
				while (attribute == null && type != null)
				{
					PropertyInfo propertyInfo2 = (PropertyInfo)Class_514.GetMemberInfoFromType(type, propertyInfo);
					if (propertyInfo2 != null && propertyInfo2.IsVirtual())
					{
						attribute = Class_471<DataMemberAttribute>.GetAttribute(propertyInfo2);
					}
					type = type.BaseType;
				}
			}
			return attribute;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000671EC File Offset: 0x000653EC
		public static Class_383 GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			Class_379 cachedAttribute = Class_470.GetCachedAttribute<Class_379>(objectType);
			if (cachedAttribute != null)
			{
				return cachedAttribute.MemberSerialization;
			}
			DataContractAttribute dataContractAttribute = Class_470.GetDataContractAttribute(objectType);
			if (dataContractAttribute != null)
			{
				return Class_383.OptIn;
			}
			if (!ignoreSerializableAttribute)
			{
				SerializableAttribute cachedAttribute2 = Class_470.GetCachedAttribute<SerializableAttribute>(objectType);
				if (cachedAttribute2 != null)
				{
					return Class_383.Fields;
				}
			}
			return Class_383.OptOut;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00067234 File Offset: 0x00065434
		public static Class_299 GetJsonConverter(object attributeProvider)
		{
			Class_378 cachedAttribute = Class_470.GetCachedAttribute<Class_378>(attributeProvider);
			if (cachedAttribute != null)
			{
				Func<object[], Class_299> func = Class_470.JsonConverterCreatorCache.Get(cachedAttribute.ConverterType);
				if (func != null)
				{
					return func(cachedAttribute.ConverterParameters);
				}
			}
			return null;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00067274 File Offset: 0x00065474
		public static Class_299 CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			Func<object[], Class_299> func = Class_470.JsonConverterCreatorCache.Get(converterType);
			return func(converterArgs);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00067294 File Offset: 0x00065494
		private static Func<object[], Class_299> GetJsonConverterCreator(Type converterType)
		{
			Func<object> defaultConstructor = Class_514.HasDefaultConstructor(converterType, false) ? Class_470.ReflectionDelegateFactory.smethod_4010<object>(converterType) : null;
			return delegate(object[] parameters)
			{
				Class_299 result;
				try
				{
					if (parameters != null)
					{
						Type[] types = (from param in parameters
						select param.GetType()).ToArray<Type>();
						ConstructorInfo constructor = converterType.GetConstructor(types);
						if (!(null != constructor))
						{
							throw new Class_318("No matching parameterized constructor found for '{0}'.".FormatWith(CultureInfo.InvariantCulture, converterType));
						}
						Class_482<object> class_ = Class_470.ReflectionDelegateFactory.pmethod_4009(constructor);
						result = (Class_299)class_(parameters);
					}
					else
					{
						if (defaultConstructor == null)
						{
							throw new Class_318("No parameterless constructor defined for '{0}'.".FormatWith(CultureInfo.InvariantCulture, converterType));
						}
						result = (Class_299)defaultConstructor();
					}
				}
				catch (Exception arg_)
				{
					throw new Class_318("Error creating '{0}'.".FormatWith(CultureInfo.InvariantCulture, converterType), arg_);
				}
				return result;
			};
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000672E7 File Offset: 0x000654E7
		public static TypeConverter GetTypeConverter(Type type)
		{
			return TypeDescriptor.GetConverter(type);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x000672EF File Offset: 0x000654EF
		private static Type GetAssociatedMetadataType(Type type)
		{
			return Class_470.AssociatedMetadataTypesCache.Get(type);
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000672FC File Offset: 0x000654FC
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			Attribute[] attributes = Class_514.GetAttributes(type, null, true);
			foreach (Attribute attribute in attributes)
			{
				Type type2 = attribute.GetType();
				if (string.Equals(type2.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
				{
					if (Class_470._metadataTypeAttributeReflectionObject == null)
					{
						Class_470._metadataTypeAttributeReflectionObject = Class_491.vmethod_4065(type2, new string[]
						{
							"MetadataClassType"
						});
					}
					return (Type)Class_470._metadataTypeAttributeReflectionObject.tmethod_4062(attribute, "MetadataClassType");
				}
			}
			return null;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0006739C File Offset: 0x0006559C
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			Type associatedMetadataType = Class_470.GetAssociatedMetadataType(type);
			T attribute;
			if (associatedMetadataType != null)
			{
				attribute = Class_514.GetAttribute<T>(associatedMetadataType, true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			attribute = Class_514.GetAttribute<T>(type, true);
			if (attribute != null)
			{
				return attribute;
			}
			foreach (Type attributeProvider in type.GetInterfaces())
			{
				attribute = Class_514.GetAttribute<T>(attributeProvider, true);
				if (attribute != null)
				{
					return attribute;
				}
			}
			return default(T);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00067430 File Offset: 0x00065630
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			Type associatedMetadataType = Class_470.GetAssociatedMetadataType(memberInfo.DeclaringType);
			T attribute;
			if (associatedMetadataType != null)
			{
				MemberInfo memberInfoFromType = Class_514.GetMemberInfoFromType(associatedMetadataType, memberInfo);
				if (memberInfoFromType != null)
				{
					attribute = Class_514.GetAttribute<T>(memberInfoFromType, true);
					if (attribute != null)
					{
						return attribute;
					}
				}
			}
			attribute = Class_514.GetAttribute<T>(memberInfo, true);
			if (attribute != null)
			{
				return attribute;
			}
			if (memberInfo.DeclaringType != null)
			{
				foreach (Type targetType in memberInfo.DeclaringType.GetInterfaces())
				{
					MemberInfo memberInfoFromType2 = Class_514.GetMemberInfoFromType(targetType, memberInfo);
					if (memberInfoFromType2 != null)
					{
						attribute = Class_514.GetAttribute<T>(memberInfoFromType2, true);
						if (attribute != null)
						{
							return attribute;
						}
					}
				}
			}
			return default(T);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00067510 File Offset: 0x00065710
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			Type type = provider as Type;
			if (type != null)
			{
				return Class_470.GetAttribute<T>(type);
			}
			MemberInfo memberInfo = provider as MemberInfo;
			if (memberInfo != null)
			{
				return Class_470.GetAttribute<T>(memberInfo);
			}
			return Class_514.GetAttribute<T>(provider, true);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00067558 File Offset: 0x00065758
		public static bool DynamicCodeGeneration
		{
			[SecuritySafeCritical]
			get
			{
				if (Class_470._dynamicCodeGeneration == null)
				{
					try
					{
						new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
						new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
						new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
						new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
						new SecurityPermission(PermissionState.Unrestricted).Demand();
						Class_470._dynamicCodeGeneration = new bool?(true);
					}
					catch (Exception)
					{
						Class_470._dynamicCodeGeneration = new bool?(false);
					}
				}
				return Class_470._dynamicCodeGeneration.Value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000675E8 File Offset: 0x000657E8
		public static bool FullyTrusted
		{
			get
			{
				if (Class_470._fullyTrusted == null)
				{
					AppDomain currentDomain = AppDomain.CurrentDomain;
					Class_470._fullyTrusted = new bool?(currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
				}
				return Class_470._fullyTrusted.Value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00067635 File Offset: 0x00065835
		public static Class_480 ReflectionDelegateFactory
		{
			get
			{
				if (Class_470.DynamicCodeGeneration)
				{
					return Class_481.field_0;
				}
				return Class_488.prop_0;
			}
		}

		// Token: 0x04000B54 RID: 2900
		public const string IdPropertyName = "$id";

		// Token: 0x04000B55 RID: 2901
		public const string RefPropertyName = "$ref";

		// Token: 0x04000B56 RID: 2902
		public const string TypePropertyName = "$type";

		// Token: 0x04000B57 RID: 2903
		public const string ValuePropertyName = "$value";

		// Token: 0x04000B58 RID: 2904
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x04000B59 RID: 2905
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x04000B5A RID: 2906
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x04000B5B RID: 2907
		private static bool? _dynamicCodeGeneration;

		// Token: 0x04000B5C RID: 2908
		private static bool? _fullyTrusted;

		// Token: 0x04000B5D RID: 2909
		private static readonly Class_493<Type, Func<object[], Class_299>> JsonConverterCreatorCache = new Class_493<Type, Func<object[], Class_299>>(new Func<Type, Func<object[], Class_299>>(Class_470.GetJsonConverterCreator));

		// Token: 0x04000B5E RID: 2910
		private static readonly Class_493<Type, Type> AssociatedMetadataTypesCache = new Class_493<Type, Type>(new Func<Type, Type>(Class_470.GetAssociateMetadataTypeFromAttribute));

		// Token: 0x04000B5F RID: 2911
		private static Class_491 _metadataTypeAttributeReflectionObject;
	}
}
