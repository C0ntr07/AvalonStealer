using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200029A RID: 666
	internal class Class_488 : Class_480
	{
		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x0006A30C File Offset: 0x0006850C
		internal static Class_480 prop_0
		{
			get
			{
				return Class_488.field_0;
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0006A314 File Offset: 0x00068514
		public virtual Class_482<object> vmethod_4045(MethodBase arg_0)
		{
			Class_488.NClass_0 nclass_ = new Class_488.NClass_0();
			nclass_.field_4 = arg_0;
			Class_517.ArgumentNotNull(nclass_.field_4, "method");
			ConstructorInfo constructorInfo = nclass_.field_4 as ConstructorInfo;
			if (constructorInfo != null)
			{
				return new Class_482<object>(constructorInfo.Invoke);
			}
			return new Class_482<object>(nclass_.nmethod_1);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0006A370 File Offset: 0x00068570
		public virtual Class_489<T, object> dmethod_4046<T>(MethodBase arg_0)
		{
			Class_488<T>.NClass_1 nclass_ = new Class_488<T>.NClass_1();
			nclass_.method = arg_0;
			Class_517.ArgumentNotNull(nclass_.method, "method");
			nclass_.c = (nclass_.method as ConstructorInfo);
			if (nclass_.c != null)
			{
				return new Class_489<T, object>(nclass_.<CreateMethodCall>b__3);
			}
			return new Class_489<T, object>(nclass_.<CreateMethodCall>b__4);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0006A3D8 File Offset: 0x000685D8
		public virtual Func<T> kmethod_4047<T>(Type arg_0)
		{
			Class_488<T>.NClass_2 nclass_ = new Class_488<T>.NClass_2();
			nclass_.type = arg_0;
			Class_517.ArgumentNotNull(nclass_.type, "type");
			if (nclass_.type.IsValueType)
			{
				return new Func<T>(nclass_.<CreateDefaultConstructor>b__7);
			}
			nclass_.constructorInfo = Class_514.GetDefaultConstructor(nclass_.type, true);
			return new Func<T>(nclass_.<CreateDefaultConstructor>b__8);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006A440 File Offset: 0x00068640
		public virtual Func<T, object> lmethod_4048<T>(PropertyInfo arg_0)
		{
			Class_488<T>.NClass_3 nclass_ = new Class_488<T>.NClass_3();
			nclass_.propertyInfo = arg_0;
			Class_517.ArgumentNotNull(nclass_.propertyInfo, "propertyInfo");
			return new Func<T, object>(nclass_.<CreateGet>b__b);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0006A478 File Offset: 0x00068678
		public virtual Func<T, object> pmethod_4049<T>(FieldInfo arg_0)
		{
			Class_488<T>.NClass_4 nclass_ = new Class_488<T>.NClass_4();
			nclass_.fieldInfo = arg_0;
			Class_517.ArgumentNotNull(nclass_.fieldInfo, "fieldInfo");
			return new Func<T, object>(nclass_.<CreateGet>b__e);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0006A4B0 File Offset: 0x000686B0
		public virtual Action<T, object> smethod_4050<T>(FieldInfo arg_0)
		{
			Class_488<T>.NClass_5 nclass_ = new Class_488<T>.NClass_5();
			nclass_.fieldInfo = arg_0;
			Class_517.ArgumentNotNull(nclass_.fieldInfo, "fieldInfo");
			return new Action<T, object>(nclass_.<CreateSet>b__11);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0006A4E8 File Offset: 0x000686E8
		public virtual Action<T, object> xmethod_4051<T>(PropertyInfo arg_0)
		{
			Class_488<T>.NClass_6 nclass_ = new Class_488<T>.NClass_6();
			nclass_.propertyInfo = arg_0;
			Class_517.ArgumentNotNull(nclass_.propertyInfo, "propertyInfo");
			return new Action<T, object>(nclass_.<CreateSet>b__14);
		}

		// Token: 0x04000BBD RID: 3005
		private static readonly Class_488 field_0 = new Class_488();

		// Token: 0x0200029B RID: 667
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x0600166F RID: 5743 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06001670 RID: 5744 RVA: 0x0006A52A File Offset: 0x0006872A
			public object nmethod_1(object[] arg_0)
			{
				return this.field_4.Invoke(null, arg_0);
			}

			// Token: 0x04000BBE RID: 3006
			public MethodBase field_4;
		}

		// Token: 0x0200029C RID: 668
		[CompilerGenerated]
		private sealed class NClass_1<T>
		{
			// Token: 0x06001671 RID: 5745 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06001672 RID: 5746 RVA: 0x0006A539 File Offset: 0x00068739
			public object nmethod_3(T arg_0, object[] arg_1)
			{
				return this.c.Invoke(arg_1);
			}

			// Token: 0x06001673 RID: 5747 RVA: 0x0006A547 File Offset: 0x00068747
			public object nmethod_4(T arg_0, object[] arg_1)
			{
				return this.method.Invoke(arg_0, arg_1);
			}

			// Token: 0x04000BBF RID: 3007
			public ConstructorInfo field_5;

			// Token: 0x04000BC0 RID: 3008
			public MethodBase field_6;
		}

		// Token: 0x0200029D RID: 669
		[CompilerGenerated]
		private sealed class NClass_2<T>
		{
			// Token: 0x06001674 RID: 5748 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_5()
			{
				base..ctor();
			}

			// Token: 0x06001675 RID: 5749 RVA: 0x0006A55B File Offset: 0x0006875B
			public T nmethod_6()
			{
				return (T)((object)Activator.CreateInstance(this.type));
			}

			// Token: 0x06001676 RID: 5750 RVA: 0x0006A56D File Offset: 0x0006876D
			public T nmethod_7()
			{
				return (T)((object)this.constructorInfo.Invoke(null));
			}

			// Token: 0x04000BC1 RID: 3009
			public ConstructorInfo field_7;

			// Token: 0x04000BC2 RID: 3010
			public Type field_8;
		}

		// Token: 0x0200029E RID: 670
		[CompilerGenerated]
		private sealed class NClass_3<T>
		{
			// Token: 0x06001677 RID: 5751 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_8()
			{
				base..ctor();
			}

			// Token: 0x06001678 RID: 5752 RVA: 0x0006A580 File Offset: 0x00068780
			public object nmethod_9(T arg_0)
			{
				return this.propertyInfo.GetValue(arg_0, null);
			}

			// Token: 0x04000BC3 RID: 3011
			public PropertyInfo field_9;
		}

		// Token: 0x0200029F RID: 671
		[CompilerGenerated]
		private sealed class NClass_4<T>
		{
			// Token: 0x06001679 RID: 5753 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_10()
			{
				base..ctor();
			}

			// Token: 0x0600167A RID: 5754 RVA: 0x0006A594 File Offset: 0x00068794
			public object nmethod_11(T arg_0)
			{
				return this.fieldInfo.GetValue(arg_0);
			}

			// Token: 0x04000BC4 RID: 3012
			public FieldInfo field_10;
		}

		// Token: 0x020002A0 RID: 672
		[CompilerGenerated]
		private sealed class NClass_5<T>
		{
			// Token: 0x0600167B RID: 5755 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_12()
			{
				base..ctor();
			}

			// Token: 0x0600167C RID: 5756 RVA: 0x0006A5A7 File Offset: 0x000687A7
			public void nmethod_13(T arg_0, object obje_0)
			{
				this.fieldInfo.SetValue(arg_0, obje_0);
			}

			// Token: 0x04000BC5 RID: 3013
			public FieldInfo field_11;
		}

		// Token: 0x020002A1 RID: 673
		[CompilerGenerated]
		private sealed class NClass_6<T>
		{
			// Token: 0x0600167D RID: 5757 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_14()
			{
				base..ctor();
			}

			// Token: 0x0600167E RID: 5758 RVA: 0x0006A5BB File Offset: 0x000687BB
			public void nmethod_15(T arg_0, object obje_0)
			{
				this.propertyInfo.SetValue(arg_0, obje_0, null);
			}

			// Token: 0x04000BC6 RID: 3014
			public PropertyInfo field_12;
		}
	}
}
