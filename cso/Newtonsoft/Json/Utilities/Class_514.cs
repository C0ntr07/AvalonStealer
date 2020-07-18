using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002C2 RID: 706
	internal static class Class_514
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x0006EB5C File Offset: 0x0006CD5C
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			Class_517.ArgumentNotNull(propertyInfo, "propertyInfo");
			MethodInfo methodInfo = propertyInfo.GetGetMethod();
			if (methodInfo != null && methodInfo.IsVirtual)
			{
				return true;
			}
			methodInfo = propertyInfo.GetSetMethod();
			return methodInfo != null && methodInfo.IsVirtual;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0006EBB8 File Offset: 0x0006CDB8
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			Class_517.ArgumentNotNull(propertyInfo, "propertyInfo");
			MethodInfo methodInfo = propertyInfo.GetGetMethod();
			if (methodInfo != null)
			{
				return methodInfo.GetBaseDefinition();
			}
			methodInfo = propertyInfo.GetSetMethod();
			if (methodInfo != null)
			{
				return methodInfo.GetBaseDefinition();
			}
			return null;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0006EC08 File Offset: 0x0006CE08
		public static bool IsPublic(PropertyInfo property)
		{
			return (property.GetGetMethod() != null && property.GetGetMethod().IsPublic) || (property.GetSetMethod() != null && property.GetSetMethod().IsPublic);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0006EC5C File Offset: 0x0006CE5C
		public static Type GetObjectType(object v)
		{
			if (v == null)
			{
				return null;
			}
			return v.GetType();
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0006EC6C File Offset: 0x0006CE6C
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			string text2;
			if (binder != null)
			{
				string text;
				string str;
				binder.BindToName(t, out text, out str);
				text2 = str + ((text == null) ? "" : (", " + text));
			}
			else
			{
				text2 = t.AssemblyQualifiedName;
			}
			switch (assemblyFormat)
			{
			case FormatterAssemblyStyle.Simple:
				return Class_514.RemoveAssemblyDetails(text2);
			case FormatterAssemblyStyle.Full:
				return text2;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0006ECDC File Offset: 0x0006CEDC
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			bool flag2 = false;
			foreach (char c in fullyQualifiedTypeName)
			{
				char c2 = c;
				if (c2 != ',')
				{
					switch (c2)
					{
					case '[':
						flag = false;
						flag2 = false;
						stringBuilder.Append(c);
						goto IL_92;
					case ']':
						flag = false;
						flag2 = false;
						stringBuilder.Append(c);
						goto IL_92;
					}
					if (!flag2)
					{
						stringBuilder.Append(c);
					}
				}
				else if (!flag)
				{
					flag = true;
					stringBuilder.Append(c);
				}
				else
				{
					flag2 = true;
				}
				IL_92:;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0006ED91 File Offset: 0x0006CF91
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			Class_517.ArgumentNotNull(t, "t");
			return t.IsValueType || Class_514.GetDefaultConstructor(t, nonPublic) != null;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0006EDB8 File Offset: 0x0006CFB8
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			return Class_514.GetDefaultConstructor(t, false);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
			if (nonPublic)
			{
				bindingFlags |= BindingFlags.NonPublic;
			}
			return t.GetConstructors(bindingFlags).SingleOrDefault((ConstructorInfo c) => !c.GetParameters().Any<ParameterInfo>());
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0006EE0B File Offset: 0x0006D00B
		public static bool IsNullable(Type t)
		{
			Class_517.ArgumentNotNull(t, "t");
			return !t.IsValueType || Class_514.IsNullableType(t);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0006EE2B File Offset: 0x0006D02B
		public static bool IsNullableType(Type t)
		{
			Class_517.ArgumentNotNull(t, "t");
			return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0006EE5A File Offset: 0x0006D05A
		public static Type EnsureNotNullableType(Type t)
		{
			if (!Class_514.IsNullableType(t))
			{
				return t;
			}
			return Nullable.GetUnderlyingType(t);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0006EE70 File Offset: 0x0006D070
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			if (!type.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == genericInterfaceDefinition;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0006EE98 File Offset: 0x0006D098
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			Type type2;
			return Class_514.ImplementsGenericDefinition(type, genericInterfaceDefinition, out type2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0006EEB0 File Offset: 0x0006D0B0
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			Class_517.ArgumentNotNull(type, "type");
			Class_517.ArgumentNotNull(genericInterfaceDefinition, "genericInterfaceDefinition");
			if (!genericInterfaceDefinition.IsInterface || !genericInterfaceDefinition.IsGenericTypeDefinition)
			{
				throw new ArgumentNullException("'{0}' is not a generic interface definition.".FormatWith(CultureInfo.InvariantCulture, genericInterfaceDefinition));
			}
			if (type.IsInterface && type.IsGenericType)
			{
				Type genericTypeDefinition = type.GetGenericTypeDefinition();
				if (genericInterfaceDefinition == genericTypeDefinition)
				{
					implementingType = type;
					return true;
				}
			}
			foreach (Type type2 in type.GetInterfaces())
			{
				if (type2.IsGenericType)
				{
					Type genericTypeDefinition2 = type2.GetGenericTypeDefinition();
					if (genericInterfaceDefinition == genericTypeDefinition2)
					{
						implementingType = type2;
						return true;
					}
				}
			}
			implementingType = null;
			return false;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0006EF80 File Offset: 0x0006D180
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			Type type2;
			return Class_514.InheritsGenericDefinition(type, genericClassDefinition, out type2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0006EF98 File Offset: 0x0006D198
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			Class_517.ArgumentNotNull(type, "type");
			Class_517.ArgumentNotNull(genericClassDefinition, "genericClassDefinition");
			if (!genericClassDefinition.IsClass || !genericClassDefinition.IsGenericTypeDefinition)
			{
				throw new ArgumentNullException("'{0}' is not a generic class definition.".FormatWith(CultureInfo.InvariantCulture, genericClassDefinition));
			}
			return Class_514.InheritsGenericDefinitionInternal(type, genericClassDefinition, out implementingType);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			if (currentType.IsGenericType)
			{
				Type genericTypeDefinition = currentType.GetGenericTypeDefinition();
				if (genericClassDefinition == genericTypeDefinition)
				{
					implementingType = currentType;
					return true;
				}
			}
			if (currentType.BaseType == null)
			{
				implementingType = null;
				return false;
			}
			return Class_514.InheritsGenericDefinitionInternal(currentType.BaseType, genericClassDefinition, out implementingType);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0006F044 File Offset: 0x0006D244
		public static Type GetCollectionItemType(Type type)
		{
			Class_517.ArgumentNotNull(type, "type");
			if (type.IsArray)
			{
				return type.GetElementType();
			}
			Type type2;
			if (Class_514.ImplementsGenericDefinition(type, typeof(IEnumerable<>), out type2))
			{
				if (type2.IsGenericTypeDefinition)
				{
					throw new Exception("Type {0} is not a collection.".FormatWith(CultureInfo.InvariantCulture, type));
				}
				return type2.GetGenericArguments()[0];
			}
			else
			{
				if (typeof(IEnumerable).IsAssignableFrom(type))
				{
					return null;
				}
				throw new Exception("Type {0} is not a collection.".FormatWith(CultureInfo.InvariantCulture, type));
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0006F0E0 File Offset: 0x0006D2E0
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			Class_517.ArgumentNotNull(dictionaryType, "type");
			Type type;
			if (Class_514.ImplementsGenericDefinition(dictionaryType, typeof(IDictionary<, >), out type))
			{
				if (type.IsGenericTypeDefinition)
				{
					throw new Exception("Type {0} is not a dictionary.".FormatWith(CultureInfo.InvariantCulture, dictionaryType));
				}
				Type[] genericArguments = type.GetGenericArguments();
				keyType = genericArguments[0];
				valueType = genericArguments[1];
				return;
			}
			else
			{
				if (typeof(IDictionary).IsAssignableFrom(dictionaryType))
				{
					keyType = null;
					valueType = null;
					return;
				}
				throw new Exception("Type {0} is not a dictionary.".FormatWith(CultureInfo.InvariantCulture, dictionaryType));
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0006F17C File Offset: 0x0006D37C
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			Class_517.ArgumentNotNull(member, "member");
			MemberTypes memberType = member.MemberType;
			switch (memberType)
			{
			case MemberTypes.Event:
				return ((EventInfo)member).EventHandlerType;
			case MemberTypes.Constructor | MemberTypes.Event:
				break;
			case MemberTypes.Field:
				return ((FieldInfo)member).FieldType;
			default:
				if (memberType == MemberTypes.Method)
				{
					return ((MethodInfo)member).ReturnType;
				}
				if (memberType == MemberTypes.Property)
				{
					return ((PropertyInfo)member).PropertyType;
				}
				break;
			}
			throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "member");
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0006F204 File Offset: 0x0006D404
		public static bool IsIndexedProperty(MemberInfo member)
		{
			Class_517.ArgumentNotNull(member, "member");
			PropertyInfo propertyInfo = member as PropertyInfo;
			return propertyInfo != null && Class_514.IsIndexedProperty(propertyInfo);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0006F237 File Offset: 0x0006D437
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			Class_517.ArgumentNotNull(property, "property");
			return property.GetIndexParameters().Length > 0;
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0006F250 File Offset: 0x0006D450
		public static object GetMemberValue(MemberInfo member, object target)
		{
			Class_517.ArgumentNotNull(member, "member");
			Class_517.ArgumentNotNull(target, "target");
			MemberTypes memberType = member.MemberType;
			if (memberType != MemberTypes.Field)
			{
				if (memberType == MemberTypes.Property)
				{
					try
					{
						return ((PropertyInfo)member).GetValue(target, null);
					}
					catch (TargetParameterCountException innerException)
					{
						throw new ArgumentException("MemberInfo '{0}' has index parameters".FormatWith(CultureInfo.InvariantCulture, member.Name), innerException);
					}
				}
				throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".FormatWith(CultureInfo.InvariantCulture, CultureInfo.InvariantCulture, member.Name), "member");
			}
			return ((FieldInfo)member).GetValue(target);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0006F304 File Offset: 0x0006D504
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
			Class_517.ArgumentNotNull(member, "member");
			Class_517.ArgumentNotNull(target, "target");
			MemberTypes memberType = member.MemberType;
			if (memberType == MemberTypes.Field)
			{
				((FieldInfo)member).SetValue(target, value);
				return;
			}
			if (memberType != MemberTypes.Property)
			{
				throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".FormatWith(CultureInfo.InvariantCulture, member.Name), "member");
			}
			((PropertyInfo)member).SetValue(target, value, null);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0006F380 File Offset: 0x0006D580
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			MemberTypes memberType = member.MemberType;
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				return nonPublic || fieldInfo.IsPublic;
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			return propertyInfo.CanRead && (nonPublic || propertyInfo.GetGetMethod(nonPublic) != null);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0006F3F4 File Offset: 0x0006D5F4
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			MemberTypes memberType = member.MemberType;
			if (memberType == MemberTypes.Field)
			{
				FieldInfo fieldInfo = (FieldInfo)member;
				return !fieldInfo.IsLiteral && (!fieldInfo.IsInitOnly || canSetReadOnly) && (nonPublic || fieldInfo.IsPublic);
			}
			if (memberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)member;
			return propertyInfo.CanWrite && (nonPublic || propertyInfo.GetSetMethod(nonPublic) != null);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x0006F488 File Offset: 0x0006D688
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			List<MemberInfo> list = new List<MemberInfo>();
			list.AddRange(Class_514.GetFields(type, bindingAttr));
			list.AddRange(Class_514.GetProperties(type, bindingAttr));
			List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
			foreach (IGrouping<string, MemberInfo> source in from m in list
			group m by m.Name)
			{
				int num = source.Count<MemberInfo>();
				IList<MemberInfo> list3 = source.ToList<MemberInfo>();
				if (num == 1)
				{
					list2.Add(list3.First<MemberInfo>());
				}
				else
				{
					IList<MemberInfo> list4 = new List<MemberInfo>();
					foreach (MemberInfo memberInfo in list3)
					{
						if (list4.Count == 0)
						{
							list4.Add(memberInfo);
						}
						else if (!Class_514.IsOverridenGenericMember(memberInfo, bindingAttr) || memberInfo.Name == "Item")
						{
							list4.Add(memberInfo);
						}
					}
					list2.AddRange(list4);
				}
			}
			return list2;
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0006F5E8 File Offset: 0x0006D7E8
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			if (memberInfo.MemberType != MemberTypes.Property)
			{
				return false;
			}
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
			if (!propertyInfo.IsVirtual())
			{
				return false;
			}
			Type declaringType = propertyInfo.DeclaringType;
			if (!declaringType.IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
			if (genericTypeDefinition == null)
			{
				return false;
			}
			MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, bindingAttr);
			if (member.Length == 0)
			{
				return false;
			}
			Type memberUnderlyingType = Class_514.GetMemberUnderlyingType(member[0]);
			return memberUnderlyingType.IsGenericParameter;
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0006F676 File Offset: 0x0006D876
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			return Class_514.GetAttribute<T>(attributeProvider, true);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0006F680 File Offset: 0x0006D880
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			T[] attributes = Class_514.GetAttributes<T>(attributeProvider, inherit);
			if (attributes == null)
			{
				return default(T);
			}
			return attributes.FirstOrDefault<T>();
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0006F6AC File Offset: 0x0006D8AC
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			Attribute[] attributes = Class_514.GetAttributes(attributeProvider, typeof(T), inherit);
			T[] array = attributes as T[];
			if (array != null)
			{
				return array;
			}
			return attributes.Cast<T>().ToArray<T>();
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0006F6E8 File Offset: 0x0006D8E8
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			Class_517.ArgumentNotNull(attributeProvider, "attributeProvider");
			if (attributeProvider is Type)
			{
				Type type = (Type)attributeProvider;
				object[] source = (attributeType != null) ? type.GetCustomAttributes(attributeType, inherit) : type.GetCustomAttributes(inherit);
				return source.Cast<Attribute>().ToArray<Attribute>();
			}
			if (attributeProvider is Assembly)
			{
				Assembly element = (Assembly)attributeProvider;
				if (!(attributeType != null))
				{
					return Attribute.GetCustomAttributes(element);
				}
				return Attribute.GetCustomAttributes(element, attributeType);
			}
			else if (attributeProvider is MemberInfo)
			{
				MemberInfo element2 = (MemberInfo)attributeProvider;
				if (!(attributeType != null))
				{
					return Attribute.GetCustomAttributes(element2, inherit);
				}
				return Attribute.GetCustomAttributes(element2, attributeType, inherit);
			}
			else if (attributeProvider is Module)
			{
				Module element3 = (Module)attributeProvider;
				if (!(attributeType != null))
				{
					return Attribute.GetCustomAttributes(element3, inherit);
				}
				return Attribute.GetCustomAttributes(element3, attributeType, inherit);
			}
			else
			{
				if (!(attributeProvider is ParameterInfo))
				{
					ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)attributeProvider;
					object[] array = (attributeType != null) ? customAttributeProvider.GetCustomAttributes(attributeType, inherit) : customAttributeProvider.GetCustomAttributes(inherit);
					return (Attribute[])array;
				}
				ParameterInfo element4 = (ParameterInfo)attributeProvider;
				if (!(attributeType != null))
				{
					return Attribute.GetCustomAttributes(element4, inherit);
				}
				return Attribute.GetCustomAttributes(element4, attributeType, inherit);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0006F83C File Offset: 0x0006DA3C
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			int? assemblyDelimiterIndex = Class_514.GetAssemblyDelimiterIndex(fullyQualifiedTypeName);
			if (assemblyDelimiterIndex != null)
			{
				typeName = fullyQualifiedTypeName.Substring(0, assemblyDelimiterIndex.Value).Trim();
				assemblyName = fullyQualifiedTypeName.Substring(assemblyDelimiterIndex.Value + 1, fullyQualifiedTypeName.Length - assemblyDelimiterIndex.Value - 1).Trim();
				return;
			}
			typeName = fullyQualifiedTypeName;
			assemblyName = null;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0006F8A0 File Offset: 0x0006DAA0
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			int num = 0;
			for (int i = 0; i < fullyQualifiedTypeName.Length; i++)
			{
				char c = fullyQualifiedTypeName[i];
				char c2 = c;
				if (c2 != ',')
				{
					switch (c2)
					{
					case '[':
						num++;
						break;
					case ']':
						num--;
						break;
					}
				}
				else if (num == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0006F918 File Offset: 0x0006DB18
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			MemberTypes memberType = memberInfo.MemberType;
			if (memberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
				Type[] types = (from p in propertyInfo.GetIndexParameters()
				select p.ParameterType).ToArray<Type>();
				return targetType.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
			}
			return targetType.GetMember(memberInfo.Name, memberInfo.MemberType, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault<MemberInfo>();
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0006F9A0 File Offset: 0x0006DBA0
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			Class_517.ArgumentNotNull(targetType, "targetType");
			List<MemberInfo> list = new List<MemberInfo>(targetType.GetFields(bindingAttr));
			Class_514.GetChildPrivateFields(list, targetType, bindingAttr);
			return list.Cast<FieldInfo>();
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0006F9D4 File Offset: 0x0006DBD4
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
			if ((bindingAttr & BindingFlags.NonPublic) != BindingFlags.Default)
			{
				BindingFlags bindingAttr2 = bindingAttr.RemoveFlag(BindingFlags.Public);
				while ((targetType = targetType.BaseType) != null)
				{
					IEnumerable<MemberInfo> collection = (from f in targetType.GetFields(bindingAttr2)
					where f.IsPrivate
					select f).Cast<MemberInfo>();
					initialFields.AddRange(collection);
				}
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0006FA44 File Offset: 0x0006DC44
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			Class_517.ArgumentNotNull(targetType, "targetType");
			List<PropertyInfo> list = new List<PropertyInfo>(targetType.GetProperties(bindingAttr));
			Class_514.GetChildPrivateProperties(list, targetType, bindingAttr);
			for (int i = 0; i < list.Count; i++)
			{
				PropertyInfo propertyInfo = list[i];
				if (propertyInfo.DeclaringType != targetType)
				{
					PropertyInfo value = (PropertyInfo)Class_514.GetMemberInfoFromType(propertyInfo.DeclaringType, propertyInfo);
					list[i] = value;
				}
			}
			return list;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0006FAB9 File Offset: 0x0006DCB9
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			if ((bindingAttr & flag) != flag)
			{
				return bindingAttr;
			}
			return bindingAttr ^ flag;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0006FACC File Offset: 0x0006DCCC
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
			while ((targetType = targetType.BaseType) != null)
			{
				PropertyInfo[] properties = targetType.GetProperties(bindingAttr);
				for (int i = 0; i < properties.Length; i++)
				{
					PropertyInfo subTypeProperty2 = properties[i];
					PropertyInfo subTypeProperty = subTypeProperty2;
					if (!Class_514.IsPublic(subTypeProperty))
					{
						int num = initialProperties.IndexOf((PropertyInfo p) => p.Name == subTypeProperty.Name);
						if (num == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
						else
						{
							PropertyInfo property = initialProperties[num];
							if (!Class_514.IsPublic(property))
							{
								initialProperties[num] = subTypeProperty;
							}
						}
					}
					else if (!subTypeProperty.IsVirtual())
					{
						int num2 = initialProperties.IndexOf((PropertyInfo p) => p.Name == subTypeProperty.Name && p.DeclaringType == subTypeProperty.DeclaringType);
						if (num2 == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
					}
					else
					{
						int num3 = initialProperties.IndexOf((PropertyInfo p) => p.Name == subTypeProperty.Name && p.IsVirtual() && p.GetBaseDefinition() != null && p.GetBaseDefinition().DeclaringType.IsAssignableFrom(subTypeProperty.DeclaringType));
						if (num3 == -1)
						{
							initialProperties.Add(subTypeProperty);
						}
					}
				}
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0006FC20 File Offset: 0x0006DE20
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			return currentType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any((MethodInfo info) => info.Name == method && info.DeclaringType != methodDeclaringType && info.GetBaseDefinition().DeclaringType == methodDeclaringType);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0006FC5C File Offset: 0x0006DE5C
		public static object GetDefaultValue(Type type)
		{
			if (!type.IsValueType)
			{
				return null;
			}
			Class_496 typeCode = Class_499.GetTypeCode(type);
			switch (typeCode)
			{
			case Class_496.Char:
			case Class_496.SByte:
			case Class_496.Int16:
			case Class_496.UInt16:
			case Class_496.Int32:
			case Class_496.Byte:
			case Class_496.UInt32:
				return 0;
			case Class_496.CharNullable:
			case Class_496.BooleanNullable:
			case Class_496.SByteNullable:
			case Class_496.Int16Nullable:
			case Class_496.UInt16Nullable:
			case Class_496.Int32Nullable:
			case Class_496.ByteNullable:
			case Class_496.UInt32Nullable:
			case Class_496.Int64Nullable:
			case Class_496.UInt64Nullable:
			case Class_496.SingleNullable:
			case Class_496.DoubleNullable:
			case Class_496.DateTimeNullable:
			case Class_496.DateTimeOffsetNullable:
			case Class_496.DecimalNullable:
				break;
			case Class_496.Boolean:
				return false;
			case Class_496.Int64:
			case Class_496.UInt64:
				return 0L;
			case Class_496.Single:
				return 0f;
			case Class_496.Double:
				return 0.0;
			case Class_496.DateTime:
				return default(DateTime);
			case Class_496.DateTimeOffset:
				return default(DateTimeOffset);
			case Class_496.Decimal:
				return 0m;
			case Class_496.Guid:
				return default(Guid);
			default:
				if (typeCode == Class_496.BigInteger)
				{
					return default(BigInteger);
				}
				break;
			}
			if (Class_514.IsNullable(type))
			{
				return null;
			}
			return Activator.CreateInstance(type);
		}

		// Token: 0x04000C4C RID: 3148
		public static readonly Type[] EmptyTypes = Type.EmptyTypes;
	}
}
