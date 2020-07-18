using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000256 RID: 598
	public class Class_447 : Class_350
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0005E508 File Offset: 0x0005C708
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0005E510 File Offset: 0x0005C710
		public new Type prop_0 { get; private set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0005E519 File Offset: 0x0005C719
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0005E521 File Offset: 0x0005C721
		public new bool prop_1 { get; private set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0005E52A File Offset: 0x0005C72A
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0005E532 File Offset: 0x0005C732
		internal new bool prop_2 { get; private set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0005E53B File Offset: 0x0005C73B
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0005E543 File Offset: 0x0005C743
		internal new bool prop_3 { get; private set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0005E54C File Offset: 0x0005C74C
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0005E554 File Offset: 0x0005C754
		internal new bool prop_4 { get; private set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0005E55D File Offset: 0x0005C75D
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0005E586 File Offset: 0x0005C786
		internal new bool prop_6
		{
			get
			{
				return this.field_5 != null || this.field_4 != null;
			}
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0005E5A4 File Offset: 0x0005C7A4
		public Class_447(Type arg_0) : base(arg_0)
		{
			this.field_5 = Class_448.Array;
			this.prop_2 = base.prop_1.IsArray;
			bool bool_;
			Type type;
			if (this.prop_2)
			{
				this.prop_0 = Class_514.GetCollectionItemType(base.prop_0);
				this.field_6 = true;
				this.field_0 = typeof(List<>).MakeGenericType(new Type[]
				{
					this.prop_0
				});
				bool_ = true;
				this.prop_1 = (this.prop_2 && base.prop_0.GetArrayRank() > 1);
			}
			else if (typeof(IList).IsAssignableFrom(arg_0))
			{
				if (Class_514.ImplementsGenericDefinition(arg_0, typeof(ICollection<>), out this.field_0))
				{
					this.prop_0 = this.field_0.GetGenericArguments()[0];
				}
				else
				{
					this.prop_0 = Class_514.GetCollectionItemType(arg_0);
				}
				if (arg_0 == typeof(IList))
				{
					base.prop_1 = typeof(List<object>);
				}
				if (this.prop_0 != null)
				{
					this.field_4 = Class_510.ResolveEnumerableCollectionConstructor(arg_0, this.prop_0);
				}
				this.field_6 = Class_514.InheritsGenericDefinition(arg_0, typeof(ReadOnlyCollection<>));
				bool_ = true;
			}
			else if (Class_514.ImplementsGenericDefinition(arg_0, typeof(ICollection<>), out this.field_0))
			{
				this.prop_0 = this.field_0.GetGenericArguments()[0];
				if (Class_514.IsGenericDefinition(arg_0, typeof(ICollection<>)) || Class_514.IsGenericDefinition(arg_0, typeof(IList<>)))
				{
					base.prop_1 = typeof(List<>).MakeGenericType(new Type[]
					{
						this.prop_0
					});
				}
				if (Class_514.IsGenericDefinition(arg_0, typeof(ISet<>)))
				{
					base.prop_1 = typeof(HashSet<>).MakeGenericType(new Type[]
					{
						this.prop_0
					});
				}
				this.field_4 = Class_510.ResolveEnumerableCollectionConstructor(arg_0, this.prop_0);
				bool_ = true;
				this.prop_3 = true;
			}
			else if (Class_514.ImplementsGenericDefinition(arg_0, typeof(IEnumerable<>), out type))
			{
				this.prop_0 = type.GetGenericArguments()[0];
				if (Class_514.IsGenericDefinition(base.prop_0, typeof(IEnumerable<>)))
				{
					base.prop_1 = typeof(List<>).MakeGenericType(new Type[]
					{
						this.prop_0
					});
				}
				this.field_4 = Class_510.ResolveEnumerableCollectionConstructor(arg_0, this.prop_0);
				if (!this.prop_6 && arg_0.Name == "FSharpList`1")
				{
					Class_484.EnsureInitialized(arg_0.Assembly);
					this.field_5 = Class_484.CreateSeq(this.prop_0);
				}
				if (arg_0.IsGenericType && arg_0.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					this.field_0 = type;
					this.field_6 = false;
					this.prop_3 = false;
					bool_ = true;
				}
				else
				{
					this.field_0 = typeof(List<>).MakeGenericType(new Type[]
					{
						this.prop_0
					});
					this.field_6 = true;
					this.prop_3 = true;
					bool_ = this.prop_6;
				}
			}
			else
			{
				bool_ = false;
				this.prop_3 = true;
			}
			this.prop_4 = bool_;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0005E944 File Offset: 0x0005CB44
		internal Class_500 vmethod_3625(object obje_0)
		{
			if (this.field_2 == null)
			{
				this.field_1 = typeof(Class_501<>).MakeGenericType(new Type[]
				{
					this.prop_0
				});
				Type type;
				if (Class_514.InheritsGenericDefinition(this.field_0, typeof(List<>)) || this.field_0.GetGenericTypeDefinition() == typeof(IEnumerable<>))
				{
					type = typeof(ICollection<>).MakeGenericType(new Type[]
					{
						this.prop_0
					});
				}
				else
				{
					type = this.field_0;
				}
				ConstructorInfo constructor = this.field_1.GetConstructor(new Type[]
				{
					type
				});
				this.field_2 = Class_470.ReflectionDelegateFactory.pmethod_4009(constructor);
			}
			return (Class_500)this.field_2(new object[]
			{
				obje_0
			});
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0005EA40 File Offset: 0x0005CC40
		internal IList dmethod_3626()
		{
			if (this.field_3 == null)
			{
				Type type = this.prop_1 ? typeof(object) : this.prop_0;
				Type arg_ = typeof(List<>).MakeGenericType(new Type[]
				{
					type
				});
				this.field_3 = Class_470.ReflectionDelegateFactory.smethod_4010<object>(arg_);
			}
			return (IList)this.field_3();
		}

		// Token: 0x04000A88 RID: 2696
		private new readonly Type field_0;

		// Token: 0x04000A89 RID: 2697
		private new Type field_1;

		// Token: 0x04000A8A RID: 2698
		private new Class_482<object> field_2;

		// Token: 0x04000A8B RID: 2699
		private new Func<object> field_3;

		// Token: 0x04000A8C RID: 2700
		private new readonly ConstructorInfo field_4;

		// Token: 0x04000A8D RID: 2701
		private new Class_482<object> field_5;

		// Token: 0x04000A8E RID: 2702
		[CompilerGenerated]
		private new Type field_6;

		// Token: 0x04000A8F RID: 2703
		[CompilerGenerated]
		private new bool field_7;

		// Token: 0x04000A90 RID: 2704
		[CompilerGenerated]
		private new bool field_8;

		// Token: 0x04000A91 RID: 2705
		[CompilerGenerated]
		private bool field_9;

		// Token: 0x04000A92 RID: 2706
		[CompilerGenerated]
		private bool field_10;
	}
}
