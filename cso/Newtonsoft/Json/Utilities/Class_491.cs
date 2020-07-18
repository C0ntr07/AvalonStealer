using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002A4 RID: 676
	internal class Class_491
	{
		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x0006A603 File Offset: 0x00068803
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x0006A60B File Offset: 0x0006880B
		public Class_482<object> prop_0 { get; private set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0006A614 File Offset: 0x00068814
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x0006A61C File Offset: 0x0006881C
		public IDictionary<string, Class_490> prop_1 { get; private set; }

		// Token: 0x0600168E RID: 5774 RVA: 0x0006A625 File Offset: 0x00068825
		public Class_491()
		{
			this.prop_1 = new Dictionary<string, Class_490>();
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0006A638 File Offset: 0x00068838
		public object tmethod_4062(object obje_0, string str_0)
		{
			Func<object, object> func = this.prop_1[str_0].prop_1;
			return func(obje_0);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0006A660 File Offset: 0x00068860
		public void gmethod_4063(object obje_0, string str_0, object obje_1)
		{
			Action<object, object> action = this.prop_1[str_0].prop_2;
			action(obje_0, obje_1);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0006A687 File Offset: 0x00068887
		public Type cmethod_4064(string str_0)
		{
			return this.prop_1[str_0].prop_0;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0006A69A File Offset: 0x0006889A
		public static Class_491 vmethod_4065(Type arg_0, params string[] strDizi_0)
		{
			return Class_491.dmethod_4066(arg_0, null, strDizi_0);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0006A6A4 File Offset: 0x000688A4
		public static Class_491 dmethod_4066(Type arg_0, MethodBase arg_1, params string[] strDizi_0)
		{
			Class_491 class_ = new Class_491();
			Class_480 reflectionDelegateFactory = Class_470.ReflectionDelegateFactory;
			if (arg_1 != null)
			{
				class_.prop_0 = reflectionDelegateFactory.pmethod_4009(arg_1);
			}
			else if (Class_514.HasDefaultConstructor(arg_0, false))
			{
				Class_491.NClass_0 nclass_ = new Class_491.NClass_0();
				nclass_.field_3 = reflectionDelegateFactory.smethod_4010<object>(arg_0);
				class_.prop_0 = new Class_482<object>(nclass_.nmethod_1);
			}
			int i = 0;
			while (i < strDizi_0.Length)
			{
				string text = strDizi_0[i];
				MemberInfo[] member = arg_0.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
				if (member.Length != 1)
				{
					throw new ArgumentException("Expected a single member with the name '{0}'.".FormatWith(CultureInfo.InvariantCulture, text));
				}
				MemberInfo memberInfo = member.Single<MemberInfo>();
				Class_490 class_2 = new Class_490();
				MemberTypes memberType = memberInfo.MemberType;
				if (memberType == MemberTypes.Field)
				{
					goto IL_CE;
				}
				if (memberType != MemberTypes.Method)
				{
					if (memberType == MemberTypes.Property)
					{
						goto IL_CE;
					}
					throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".FormatWith(CultureInfo.InvariantCulture, memberInfo.MemberType, memberInfo.Name));
				}
				else
				{
					MethodInfo methodInfo = (MethodInfo)memberInfo;
					if (methodInfo.IsPublic)
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
						{
							Class_491.NClass_1 nclass_2 = new Class_491.NClass_1();
							nclass_2.field_4 = reflectionDelegateFactory.lmethod_4008<object>(methodInfo);
							class_2.prop_1 = new Func<object, object>(nclass_2.nmethod_3);
						}
						else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
						{
							Class_491.NClass_2 nclass_3 = new Class_491.NClass_2();
							nclass_3.field_5 = reflectionDelegateFactory.lmethod_4008<object>(methodInfo);
							class_2.prop_2 = new Action<object, object>(nclass_3.nmethod_5);
						}
					}
				}
				IL_1F9:
				if (Class_514.CanReadMemberValue(memberInfo, false))
				{
					class_2.prop_1 = reflectionDelegateFactory.dmethod_4006<object>(memberInfo);
				}
				if (Class_514.CanSetMemberValue(memberInfo, false, false))
				{
					class_2.prop_2 = reflectionDelegateFactory.kmethod_4007<object>(memberInfo);
				}
				class_2.prop_0 = Class_514.GetMemberUnderlyingType(memberInfo);
				class_.prop_1[text] = class_2;
				i++;
				continue;
				IL_CE:
				if (Class_514.CanReadMemberValue(memberInfo, false))
				{
					class_2.prop_1 = reflectionDelegateFactory.dmethod_4006<object>(memberInfo);
				}
				if (Class_514.CanSetMemberValue(memberInfo, false, false))
				{
					class_2.prop_2 = reflectionDelegateFactory.kmethod_4007<object>(memberInfo);
					goto IL_1F9;
				}
				goto IL_1F9;
			}
			return class_;
		}

		// Token: 0x04000BCA RID: 3018
		[CompilerGenerated]
		private Class_482<object> field_0;

		// Token: 0x04000BCB RID: 3019
		[CompilerGenerated]
		private IDictionary<string, Class_490> field_1;

		// Token: 0x020002A5 RID: 677
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06001694 RID: 5780 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x0006A911 File Offset: 0x00068B11
			public object nmethod_1(object[] arg_0)
			{
				return this.field_3();
			}

			// Token: 0x04000BCC RID: 3020
			public Func<object> field_3;
		}

		// Token: 0x020002A6 RID: 678
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06001696 RID: 5782 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x0006A91E File Offset: 0x00068B1E
			public object nmethod_3(object obje_0)
			{
				return this.field_4(obje_0, new object[0]);
			}

			// Token: 0x04000BCD RID: 3021
			public Class_489<object, object> field_4;
		}

		// Token: 0x020002A7 RID: 679
		[CompilerGenerated]
		private sealed class NClass_2
		{
			// Token: 0x06001698 RID: 5784 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_4()
			{
				base..ctor();
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x0006A934 File Offset: 0x00068B34
			public void nmethod_5(object obje_0, object obje_1)
			{
				this.field_5(obje_0, new object[]
				{
					obje_1
				});
			}

			// Token: 0x04000BCE RID: 3022
			public Class_489<object, object> field_5;
		}
	}
}
