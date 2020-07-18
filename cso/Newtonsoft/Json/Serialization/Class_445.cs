using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000253 RID: 595
	public class Class_445 : SerializationBinder
	{
		// Token: 0x060013E1 RID: 5089 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		private static Type lmethod_3598(Class_445.NClass_0 arg_0)
		{
			string field_ = arg_0.field_2;
			string field_2 = arg_0.field_3;
			if (field_ == null)
			{
				return Type.GetType(field_2);
			}
			Assembly assembly = Assembly.LoadWithPartialName(field_);
			if (assembly == null)
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly2 in assemblies)
				{
					if (assembly2.FullName == field_)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new Class_417("Could not load assembly '{0}'.".FormatWith(CultureInfo.InvariantCulture, field_));
			}
			Type type = assembly.GetType(field_2);
			if (type == null)
			{
				throw new Class_417("Could not find type '{0}' in assembly '{1}'.".FormatWith(CultureInfo.InvariantCulture, field_2, assembly.FullName));
			}
			return type;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005E394 File Offset: 0x0005C594
		public virtual Type pmethod_3599(string str_0, string str_1)
		{
			return this.field_1.Get(new Class_445.NClass_0(str_0, str_1));
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005E3A8 File Offset: 0x0005C5A8
		public virtual void smethod_3600(Type arg_0, out string arg_1, out string arg_2)
		{
			arg_1 = arg_0.Assembly.FullName;
			arg_2 = arg_0.FullName;
		}

		// Token: 0x04000A7E RID: 2686
		internal static readonly Class_445 field_0 = new Class_445();

		// Token: 0x04000A7F RID: 2687
		private readonly Class_493<Class_445.NClass_0, Type> field_1 = new Class_493<Class_445.NClass_0, Type>(new Func<Class_445.NClass_0, Type>(Class_445.lmethod_3598));

		// Token: 0x02000254 RID: 596
		internal struct NClass_0 : IEquatable<Class_445.NClass_0>
		{
			// Token: 0x060013E6 RID: 5094 RVA: 0x0005E3EA File Offset: 0x0005C5EA
			public void nmethod_0(string str_0, string str_1)
			{
				this.field_2 = str_0;
				this.field_3 = str_1;
			}

			// Token: 0x060013E7 RID: 5095 RVA: 0x0005E3FA File Offset: 0x0005C5FA
			public int nmethod_1()
			{
				return ((this.field_2 != null) ? this.field_2.GetHashCode() : 0) ^ ((this.field_3 != null) ? this.field_3.GetHashCode() : 0);
			}

			// Token: 0x060013E8 RID: 5096 RVA: 0x0005E435 File Offset: 0x0005C635
			public bool nmethod_2(object obje_0)
			{
				return obje_0 is Class_445.NClass_0 && this.nmethod_3((Class_445.NClass_0)obje_0);
			}

			// Token: 0x060013E9 RID: 5097 RVA: 0x0005E450 File Offset: 0x0005C650
			public bool nmethod_3(Class_445.NClass_0 arg_0)
			{
				return this.field_2 == arg_0.field_2 && this.field_3 == arg_0.field_3;
			}

			// Token: 0x04000A80 RID: 2688
			internal readonly string field_2;

			// Token: 0x04000A81 RID: 2689
			internal readonly string field_3;
		}
	}
}
