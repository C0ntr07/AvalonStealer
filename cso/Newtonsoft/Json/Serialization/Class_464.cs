using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026A RID: 618
	public class Class_464 : Class_350
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000611BF File Offset: 0x0005F3BF
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x000611C7 File Offset: 0x0005F3C7
		public new Class_383 prop_0 { get; set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000611D0 File Offset: 0x0005F3D0
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x000611D8 File Offset: 0x0005F3D8
		public new Class_364? prop_1 { get; set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000611E1 File Offset: 0x0005F3E1
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x000611E9 File Offset: 0x0005F3E9
		public new Class_455 prop_2 { get; private set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000611F2 File Offset: 0x0005F3F2
		[Obsolete("ConstructorParameters is obsolete. Use CreatorParameters instead.")]
		public new Class_455 prop_3
		{
			get
			{
				return this.prop_4;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000611FA File Offset: 0x0005F3FA
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x00061202 File Offset: 0x0005F402
		public new Class_455 prop_4 { get; private set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0006120B File Offset: 0x0005F40B
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x00061213 File Offset: 0x0005F413
		[Obsolete("OverrideConstructor is obsolete. Use OverrideCreator instead.")]
		public new ConstructorInfo prop_5
		{
			get
			{
				return this.field_2;
			}
			set
			{
				this.field_2 = value;
				this.field_3 = ((value != null) ? Class_470.ReflectionDelegateFactory.pmethod_4009(value) : null);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0006123F File Offset: 0x0005F43F
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x00061247 File Offset: 0x0005F447
		[Obsolete("ParametrizedConstructor is obsolete. Use OverrideCreator instead.")]
		public new ConstructorInfo prop_6
		{
			get
			{
				return this.field_1;
			}
			set
			{
				this.field_1 = value;
				this.field_4 = ((value != null) ? Class_470.ReflectionDelegateFactory.pmethod_4009(value) : null);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00061273 File Offset: 0x0005F473
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0006127B File Offset: 0x0005F47B
		public new Class_482<object> prop_7
		{
			get
			{
				return this.field_3;
			}
			set
			{
				this.field_3 = value;
				this.field_2 = null;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0006128B File Offset: 0x0005F48B
		internal new Class_482<object> prop_8
		{
			get
			{
				return this.field_4;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00061293 File Offset: 0x0005F493
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x0006129B File Offset: 0x0005F49B
		public new Class_451 prop_9 { get; set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000612A4 File Offset: 0x0005F4A4
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x000612AC File Offset: 0x0005F4AC
		public new Class_452 prop_10 { get; set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000612B8 File Offset: 0x0005F4B8
		internal new bool prop_11
		{
			get
			{
				if (this.field_0 == null)
				{
					this.field_0 = new bool?(false);
					if (this.prop_1.GetValueOrDefault(Class_364.Default) != Class_364.Default)
					{
						this.field_0 = new bool?(true);
					}
					else
					{
						foreach (Class_454 class_ in this.prop_2)
						{
							if (class_.prop_15 != Class_364.Default || ((class_.prop_18 & Class_377.Populate) == Class_377.Populate && class_.prop_12))
							{
								this.field_0 = new bool?(true);
								break;
							}
						}
					}
				}
				return this.field_0.Value;
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x000613D0 File Offset: 0x0005F5D0
		public Class_464(Type arg_0) : base(arg_0)
		{
			this.field_5 = Class_448.Object;
			this.prop_2 = new Class_455(base.prop_0);
			this.prop_4 = new Class_455(base.prop_0);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00061402 File Offset: 0x0005F602
		[SecuritySafeCritical]
		internal object dmethod_3846()
		{
			if (!Class_470.FullyTrusted)
			{
				throw new Class_318("Insufficient permissions. Creating an uninitialized '{0}' type requires full trust.".FormatWith(CultureInfo.InvariantCulture, this.field_3));
			}
			return FormatterServices.GetUninitializedObject(this.field_3);
		}

		// Token: 0x04000B31 RID: 2865
		private new bool? field_0;

		// Token: 0x04000B32 RID: 2866
		private new ConstructorInfo field_1;

		// Token: 0x04000B33 RID: 2867
		private new ConstructorInfo field_2;

		// Token: 0x04000B34 RID: 2868
		private new Class_482<object> field_3;

		// Token: 0x04000B35 RID: 2869
		private new Class_482<object> field_4;

		// Token: 0x04000B36 RID: 2870
		[CompilerGenerated]
		private new Class_383 field_5;

		// Token: 0x04000B37 RID: 2871
		[CompilerGenerated]
		private new Class_364? field_6;

		// Token: 0x04000B38 RID: 2872
		[CompilerGenerated]
		private new Class_455 field_7;

		// Token: 0x04000B39 RID: 2873
		[CompilerGenerated]
		private new Class_455 field_8;

		// Token: 0x04000B3A RID: 2874
		[CompilerGenerated]
		private Class_451 field_9;

		// Token: 0x04000B3B RID: 2875
		[CompilerGenerated]
		private Class_452 field_10;
	}
}
