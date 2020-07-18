using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200025D RID: 605
	public class Class_454
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x0005EDF3 File Offset: 0x0005CFF3
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x0005EDFB File Offset: 0x0005CFFB
		internal Class_349 prop_0 { get; set; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0005EE04 File Offset: 0x0005D004
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x0005EE0C File Offset: 0x0005D00C
		public string prop_1
		{
			get
			{
				return this.field_4;
			}
			set
			{
				this.field_4 = value;
				this.field_5 = !Class_507.ShouldEscapeJavaScriptString(this.field_4, Class_507.HtmlCharEscapeFlags);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0005EE2E File Offset: 0x0005D02E
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x0005EE36 File Offset: 0x0005D036
		public Type prop_2 { get; set; }

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0005EE3F File Offset: 0x0005D03F
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x0005EE47 File Offset: 0x0005D047
		public int? prop_3 { get; set; }

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x0005EE50 File Offset: 0x0005D050
		// (set) Token: 0x0600142E RID: 5166 RVA: 0x0005EE58 File Offset: 0x0005D058
		public string prop_4 { get; set; }

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x0005EE61 File Offset: 0x0005D061
		// (set) Token: 0x06001430 RID: 5168 RVA: 0x0005EE69 File Offset: 0x0005D069
		public Class_346 prop_5 { get; set; }

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x0005EE72 File Offset: 0x0005D072
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x0005EE7A File Offset: 0x0005D07A
		public Class_348 prop_6 { get; set; }

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0005EE83 File Offset: 0x0005D083
		// (set) Token: 0x06001434 RID: 5172 RVA: 0x0005EE8B File Offset: 0x0005D08B
		public Type prop_7
		{
			get
			{
				return this.field_6;
			}
			set
			{
				if (this.field_6 != value)
				{
					this.field_6 = value;
					this.field_3 = false;
				}
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0005EEAC File Offset: 0x0005D0AC
		// (set) Token: 0x06001436 RID: 5174 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
		public Class_299 prop_8 { get; set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x0005EEBD File Offset: 0x0005D0BD
		// (set) Token: 0x06001438 RID: 5176 RVA: 0x0005EEC5 File Offset: 0x0005D0C5
		public Class_299 prop_9 { get; set; }

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x0005EECE File Offset: 0x0005D0CE
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x0005EED6 File Offset: 0x0005D0D6
		public bool prop_10 { get; set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0005EEDF File Offset: 0x0005D0DF
		// (set) Token: 0x0600143C RID: 5180 RVA: 0x0005EEE7 File Offset: 0x0005D0E7
		public bool prop_11 { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0005EEF8 File Offset: 0x0005D0F8
		public bool prop_12 { get; set; }

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x0005EF01 File Offset: 0x0005D101
		// (set) Token: 0x06001440 RID: 5184 RVA: 0x0005EF09 File Offset: 0x0005D109
		public bool prop_13 { get; set; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x0005EF12 File Offset: 0x0005D112
		// (set) Token: 0x06001442 RID: 5186 RVA: 0x0005EF27 File Offset: 0x0005D127
		public object prop_14
		{
			get
			{
				if (!this.field_1)
				{
					return null;
				}
				return this.field_2;
			}
			set
			{
				this.field_1 = true;
				this.field_2 = value;
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005EF38 File Offset: 0x0005D138
		internal object xmethod_3671()
		{
			if (this.field_6 == null)
			{
				return null;
			}
			if (!this.field_1 && !this.field_3)
			{
				this.field_2 = Class_514.GetDefaultValue(this.prop_7);
				this.field_3 = true;
			}
			return this.field_2;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0005EF8C File Offset: 0x0005D18C
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0005EFB5 File Offset: 0x0005D1B5
		public Class_364 prop_15
		{
			get
			{
				Class_364? class_ = this.field_0;
				if (class_ == null)
				{
					return Class_364.Default;
				}
				return class_.GetValueOrDefault();
			}
			set
			{
				this.field_0 = new Class_364?(value);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005EFC3 File Offset: 0x0005D1C3
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0005EFCB File Offset: 0x0005D1CB
		public bool? prop_16 { get; set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0005EFD4 File Offset: 0x0005D1D4
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0005EFDC File Offset: 0x0005D1DC
		public Class_457? prop_17 { get; set; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0005EFE5 File Offset: 0x0005D1E5
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0005EFED File Offset: 0x0005D1ED
		public Class_377? prop_18 { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0005EFF6 File Offset: 0x0005D1F6
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0005EFFE File Offset: 0x0005D1FE
		public Class_458? prop_19 { get; set; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005F007 File Offset: 0x0005D207
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0005F00F File Offset: 0x0005D20F
		public Class_384? prop_20 { get; set; }

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0005F018 File Offset: 0x0005D218
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0005F020 File Offset: 0x0005D220
		public Class_494? prop_21 { get; set; }

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0005F029 File Offset: 0x0005D229
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x0005F031 File Offset: 0x0005D231
		public Predicate<object> prop_22 { get; set; }

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0005F03A File Offset: 0x0005D23A
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x0005F042 File Offset: 0x0005D242
		public Predicate<object> prop_23 { get; set; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0005F04B File Offset: 0x0005D24B
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x0005F053 File Offset: 0x0005D253
		public Action<object, object> prop_24 { get; set; }

		// Token: 0x06001458 RID: 5208 RVA: 0x0005F05C File Offset: 0x0005D25C
		public virtual string tmethod_3692()
		{
			return this.prop_1;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0005F064 File Offset: 0x0005D264
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0005F06C File Offset: 0x0005D26C
		public Class_299 prop_25 { get; set; }

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005F075 File Offset: 0x0005D275
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0005F07D File Offset: 0x0005D27D
		public bool? prop_26 { get; set; }

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005F086 File Offset: 0x0005D286
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0005F08E File Offset: 0x0005D28E
		public Class_494? prop_27 { get; set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0005F097 File Offset: 0x0005D297
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0005F09F File Offset: 0x0005D29F
		public Class_458? prop_28 { get; set; }

		// Token: 0x06001461 RID: 5217 RVA: 0x0005F0A8 File Offset: 0x0005D2A8
		internal void xmethod_3701(Class_296 arg_0)
		{
			if (this.field_5)
			{
				arg_0.cmethod_2014(this.prop_1, false);
				return;
			}
			arg_0.gmethod_2013(this.prop_1);
		}

		// Token: 0x04000AA8 RID: 2728
		internal Class_364? field_0;

		// Token: 0x04000AA9 RID: 2729
		internal bool field_1;

		// Token: 0x04000AAA RID: 2730
		private object field_2;

		// Token: 0x04000AAB RID: 2731
		private bool field_3;

		// Token: 0x04000AAC RID: 2732
		private string field_4;

		// Token: 0x04000AAD RID: 2733
		internal bool field_5;

		// Token: 0x04000AAE RID: 2734
		private Type field_6;

		// Token: 0x04000AAF RID: 2735
		[CompilerGenerated]
		private Class_349 field_7;

		// Token: 0x04000AB0 RID: 2736
		[CompilerGenerated]
		private Type field_8;

		// Token: 0x04000AB1 RID: 2737
		[CompilerGenerated]
		private int? field_9;

		// Token: 0x04000AB2 RID: 2738
		[CompilerGenerated]
		private string field_10;

		// Token: 0x04000AB3 RID: 2739
		[CompilerGenerated]
		private Class_346 field_11;

		// Token: 0x04000AB4 RID: 2740
		[CompilerGenerated]
		private Class_348 field_12;

		// Token: 0x04000AB5 RID: 2741
		[CompilerGenerated]
		private Class_299 field_13;

		// Token: 0x04000AB6 RID: 2742
		[CompilerGenerated]
		private Class_299 field_14;

		// Token: 0x04000AB7 RID: 2743
		[CompilerGenerated]
		private bool field_15;

		// Token: 0x04000AB8 RID: 2744
		[CompilerGenerated]
		private bool field_16;

		// Token: 0x04000AB9 RID: 2745
		[CompilerGenerated]
		private bool field_17;

		// Token: 0x04000ABA RID: 2746
		[CompilerGenerated]
		private bool field_18;

		// Token: 0x04000ABB RID: 2747
		[CompilerGenerated]
		private bool? field_19;

		// Token: 0x04000ABC RID: 2748
		[CompilerGenerated]
		private Class_457? field_20;

		// Token: 0x04000ABD RID: 2749
		[CompilerGenerated]
		private Class_377? field_21;

		// Token: 0x04000ABE RID: 2750
		[CompilerGenerated]
		private Class_458? field_22;

		// Token: 0x04000ABF RID: 2751
		[CompilerGenerated]
		private Class_384? field_23;

		// Token: 0x04000AC0 RID: 2752
		[CompilerGenerated]
		private Class_494? field_24;

		// Token: 0x04000AC1 RID: 2753
		[CompilerGenerated]
		private Predicate<object> field_25;

		// Token: 0x04000AC2 RID: 2754
		[CompilerGenerated]
		private Predicate<object> field_26;

		// Token: 0x04000AC3 RID: 2755
		[CompilerGenerated]
		private Action<object, object> field_27;

		// Token: 0x04000AC4 RID: 2756
		[CompilerGenerated]
		private Class_299 field_28;

		// Token: 0x04000AC5 RID: 2757
		[CompilerGenerated]
		private bool? field_29;

		// Token: 0x04000AC6 RID: 2758
		[CompilerGenerated]
		private Class_494? field_30;

		// Token: 0x04000AC7 RID: 2759
		[CompilerGenerated]
		private Class_458? field_31;
	}
}
