using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200025C RID: 604
	public class Class_453 : Class_350
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0005EABA File Offset: 0x0005CCBA
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0005EAC2 File Offset: 0x0005CCC2
		public new Func<string, string> prop_0 { get; set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0005EACB File Offset: 0x0005CCCB
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0005EAD3 File Offset: 0x0005CCD3
		public new Type prop_1 { get; private set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0005EADC File Offset: 0x0005CCDC
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0005EAE4 File Offset: 0x0005CCE4
		public new Type prop_2 { get; private set; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0005EAED File Offset: 0x0005CCED
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0005EAF5 File Offset: 0x0005CCF5
		internal new Class_349 prop_3 { get; set; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0005EAFE File Offset: 0x0005CCFE
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0005EB06 File Offset: 0x0005CD06
		internal new bool prop_4 { get; private set; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0005EB0F File Offset: 0x0005CD0F
		internal new Class_482<object> prop_5
		{
			get
			{
				if (this.field_5 == null)
				{
					this.field_5 = Class_470.ReflectionDelegateFactory.pmethod_4009(this.field_4);
				}
				return this.field_5;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0005EB38 File Offset: 0x0005CD38
		internal new bool prop_6
		{
			get
			{
				return this.field_5 != null || this.field_4 != null;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0005EB54 File Offset: 0x0005CD54
		public Class_453(Type arg_0) : base(arg_0)
		{
			this.field_5 = Class_448.Dictionary;
			Type type;
			Type type2;
			if (Class_514.ImplementsGenericDefinition(arg_0, typeof(IDictionary<, >), out this.field_0))
			{
				type = this.field_0.GetGenericArguments()[0];
				type2 = this.field_0.GetGenericArguments()[1];
				if (Class_514.IsGenericDefinition(base.prop_0, typeof(IDictionary<, >)))
				{
					base.prop_1 = typeof(Dictionary<, >).MakeGenericType(new Type[]
					{
						type,
						type2
					});
				}
			}
			else
			{
				Class_514.GetDictionaryKeyValueTypes(base.prop_0, out type, out type2);
				if (base.prop_0 == typeof(IDictionary))
				{
					base.prop_1 = typeof(Dictionary<object, object>);
				}
			}
			if (type != null && type2 != null)
			{
				this.field_4 = Class_510.ResolveEnumerableCollectionConstructor(base.prop_1, typeof(KeyValuePair<, >).MakeGenericType(new Type[]
				{
					type,
					type2
				}));
				if (!this.prop_6 && arg_0.Name == "FSharpMap`2")
				{
					Class_484.EnsureInitialized(arg_0.Assembly);
					this.field_5 = Class_484.CreateMap(type, type2);
				}
			}
			this.prop_4 = !typeof(IDictionary).IsAssignableFrom(base.prop_1);
			this.prop_1 = type;
			this.prop_2 = type2;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0005ECE8 File Offset: 0x0005CEE8
		internal Class_503 pmethod_3639(object obje_0)
		{
			if (this.field_2 == null)
			{
				this.field_1 = typeof(Class_504<, >).MakeGenericType(new Type[]
				{
					this.prop_1,
					this.prop_2
				});
				ConstructorInfo constructor = this.field_1.GetConstructor(new Type[]
				{
					this.field_0
				});
				this.field_2 = Class_470.ReflectionDelegateFactory.pmethod_4009(constructor);
			}
			return (Class_503)this.field_2(new object[]
			{
				obje_0
			});
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0005ED88 File Offset: 0x0005CF88
		internal IDictionary smethod_3640()
		{
			if (this.field_3 == null)
			{
				Type arg_ = typeof(Dictionary<, >).MakeGenericType(new Type[]
				{
					this.prop_1,
					this.prop_2
				});
				this.field_3 = Class_470.ReflectionDelegateFactory.smethod_4010<object>(arg_);
			}
			return (IDictionary)this.field_3();
		}

		// Token: 0x04000A9D RID: 2717
		private new readonly Type field_0;

		// Token: 0x04000A9E RID: 2718
		private new Type field_1;

		// Token: 0x04000A9F RID: 2719
		private new Class_482<object> field_2;

		// Token: 0x04000AA0 RID: 2720
		private new Func<object> field_3;

		// Token: 0x04000AA1 RID: 2721
		private new readonly ConstructorInfo field_4;

		// Token: 0x04000AA2 RID: 2722
		private new Class_482<object> field_5;

		// Token: 0x04000AA3 RID: 2723
		[CompilerGenerated]
		private new Func<string, string> field_6;

		// Token: 0x04000AA4 RID: 2724
		[CompilerGenerated]
		private new Type field_7;

		// Token: 0x04000AA5 RID: 2725
		[CompilerGenerated]
		private new Type field_8;

		// Token: 0x04000AA6 RID: 2726
		[CompilerGenerated]
		private Class_349 field_9;

		// Token: 0x04000AA7 RID: 2727
		[CompilerGenerated]
		private bool field_10;
	}
}
