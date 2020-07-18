using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000262 RID: 610
	public class Class_459
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0005F29C File Offset: 0x0005D49C
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x0005F2A4 File Offset: 0x0005D4A4
		public string prop_0 { get; set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0005F2AD File Offset: 0x0005D4AD
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x0005F2B5 File Offset: 0x0005D4B5
		public string prop_1 { get; set; }

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0005F2BE File Offset: 0x0005D4BE
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x0005F2C6 File Offset: 0x0005D4C6
		public bool? prop_2 { get; set; }

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005F2CF File Offset: 0x0005D4CF
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0005F2D7 File Offset: 0x0005D4D7
		public bool? prop_3 { get; set; }

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005F2E0 File Offset: 0x0005D4E0
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0005F2E8 File Offset: 0x0005D4E8
		public bool? prop_4 { get; set; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0005F2F1 File Offset: 0x0005D4F1
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0005F2F9 File Offset: 0x0005D4F9
		public bool? prop_5 { get; set; }

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0005F302 File Offset: 0x0005D502
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0005F30A File Offset: 0x0005D50A
		public string prop_6 { get; set; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0005F313 File Offset: 0x0005D513
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0005F31B File Offset: 0x0005D51B
		public Class_463? prop_7 { get; set; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0005F324 File Offset: 0x0005D524
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0005F32C File Offset: 0x0005D52C
		public string prop_8 { get; set; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0005F335 File Offset: 0x0005D535
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x0005F33D File Offset: 0x0005D53D
		public int? prop_9 { get; set; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0005F346 File Offset: 0x0005D546
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x0005F34E File Offset: 0x0005D54E
		public int? prop_10 { get; set; }

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0005F357 File Offset: 0x0005D557
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x0005F35F File Offset: 0x0005D55F
		public double? prop_11 { get; set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005F368 File Offset: 0x0005D568
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0005F370 File Offset: 0x0005D570
		public double? prop_12 { get; set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005F379 File Offset: 0x0005D579
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0005F381 File Offset: 0x0005D581
		public double? prop_13 { get; set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005F38A File Offset: 0x0005D58A
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0005F392 File Offset: 0x0005D592
		public bool? prop_14 { get; set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0005F39B File Offset: 0x0005D59B
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0005F3A3 File Offset: 0x0005D5A3
		public bool? prop_15 { get; set; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0005F3AC File Offset: 0x0005D5AC
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
		public int? prop_16 { get; set; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0005F3BD File Offset: 0x0005D5BD
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0005F3C5 File Offset: 0x0005D5C5
		public int? prop_17 { get; set; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005F3CE File Offset: 0x0005D5CE
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0005F3D6 File Offset: 0x0005D5D6
		public IList<Class_459> prop_18 { get; set; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0005F3DF File Offset: 0x0005D5DF
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0005F3E7 File Offset: 0x0005D5E7
		public bool prop_19 { get; set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0005F3F8 File Offset: 0x0005D5F8
		public Class_459 prop_20 { get; set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0005F401 File Offset: 0x0005D601
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0005F409 File Offset: 0x0005D609
		public bool prop_21 { get; set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005F412 File Offset: 0x0005D612
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0005F41A File Offset: 0x0005D61A
		public bool prop_22 { get; set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0005F423 File Offset: 0x0005D623
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0005F42B File Offset: 0x0005D62B
		public IDictionary<string, Class_459> prop_23 { get; set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0005F434 File Offset: 0x0005D634
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0005F43C File Offset: 0x0005D63C
		public Class_459 prop_24 { get; set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0005F445 File Offset: 0x0005D645
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0005F44D File Offset: 0x0005D64D
		public IDictionary<string, Class_459> prop_25 { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0005F456 File Offset: 0x0005D656
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0005F45E File Offset: 0x0005D65E
		public bool prop_26 { get; set; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005F467 File Offset: 0x0005D667
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0005F46F File Offset: 0x0005D66F
		public string prop_27 { get; set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005F478 File Offset: 0x0005D678
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0005F480 File Offset: 0x0005D680
		public IList<Class_361> prop_28 { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0005F489 File Offset: 0x0005D689
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0005F491 File Offset: 0x0005D691
		public Class_463? prop_29 { get; set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0005F49A File Offset: 0x0005D69A
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0005F4A2 File Offset: 0x0005D6A2
		public Class_361 prop_30 { get; set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0005F4AB File Offset: 0x0005D6AB
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0005F4B3 File Offset: 0x0005D6B3
		public IList<Class_459> prop_31 { get; set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0005F4BC File Offset: 0x0005D6BC
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0005F4C4 File Offset: 0x0005D6C4
		public string prop_32 { get; set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0005F4CD File Offset: 0x0005D6CD
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0005F4D5 File Offset: 0x0005D6D5
		internal string prop_33 { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0005F4DE File Offset: 0x0005D6DE
		internal string prop_34
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0005F4E6 File Offset: 0x0005D6E6
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0005F4EE File Offset: 0x0005D6EE
		internal string prop_35 { get; set; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0005F4F7 File Offset: 0x0005D6F7
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0005F4FF File Offset: 0x0005D6FF
		internal bool prop_36 { get; set; }

		// Token: 0x060014B2 RID: 5298 RVA: 0x0005F508 File Offset: 0x0005D708
		public Class_459()
		{
			this.prop_26 = true;
			this.prop_21 = true;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0005F541 File Offset: 0x0005D741
		public static Class_459 smethod_3780(Class_285 arg_0)
		{
			return Class_459.xmethod_3781(arg_0, new Class_435());
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0005F550 File Offset: 0x0005D750
		public static Class_459 xmethod_3781(Class_285 arg_0, Class_435 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "reader");
			Class_517.ArgumentNotNull(arg_1, "resolver");
			Class_460 class_ = new Class_460(arg_1);
			return class_.smethod_3790(arg_0);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0005F581 File Offset: 0x0005D781
		public static Class_459 tmethod_3782(string str_0)
		{
			return Class_459.gmethod_3783(str_0, new Class_435());
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0005F590 File Offset: 0x0005D790
		public static Class_459 gmethod_3783(string str_0, Class_435 arg_0)
		{
			Class_517.ArgumentNotNull(str_0, "json");
			Class_459 result;
			using (Class_285 class_ = new Class_409(new StringReader(str_0)))
			{
				result = Class_459.xmethod_3781(class_, arg_0);
			}
			return result;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0005F5E0 File Offset: 0x0005D7E0
		public void cmethod_3784(Class_296 arg_0)
		{
			this.vmethod_3785(arg_0, new Class_435());
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
		public void vmethod_3785(Class_296 arg_0, Class_435 arg_1)
		{
			Class_517.ArgumentNotNull(arg_0, "writer");
			Class_517.ArgumentNotNull(arg_1, "resolver");
			Class_436 class_ = new Class_436(arg_0, arg_1);
			class_.gmethod_3533(this);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0005F624 File Offset: 0x0005D824
		public virtual string dmethod_3786()
		{
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			this.cmethod_3784(new Class_412(stringWriter)
			{
				prop_5 = Class_322.Indented
			});
			return stringWriter.ToString();
		}

		// Token: 0x04000AD3 RID: 2771
		private readonly string field_0 = Guid.NewGuid().ToString("N");

		// Token: 0x04000AD4 RID: 2772
		[CompilerGenerated]
		private string field_1;

		// Token: 0x04000AD5 RID: 2773
		[CompilerGenerated]
		private string field_2;

		// Token: 0x04000AD6 RID: 2774
		[CompilerGenerated]
		private bool? field_3;

		// Token: 0x04000AD7 RID: 2775
		[CompilerGenerated]
		private bool? field_4;

		// Token: 0x04000AD8 RID: 2776
		[CompilerGenerated]
		private bool? field_5;

		// Token: 0x04000AD9 RID: 2777
		[CompilerGenerated]
		private bool? field_6;

		// Token: 0x04000ADA RID: 2778
		[CompilerGenerated]
		private string field_7;

		// Token: 0x04000ADB RID: 2779
		[CompilerGenerated]
		private Class_463? field_8;

		// Token: 0x04000ADC RID: 2780
		[CompilerGenerated]
		private string field_9;

		// Token: 0x04000ADD RID: 2781
		[CompilerGenerated]
		private int? field_10;

		// Token: 0x04000ADE RID: 2782
		[CompilerGenerated]
		private int? field_11;

		// Token: 0x04000ADF RID: 2783
		[CompilerGenerated]
		private double? field_12;

		// Token: 0x04000AE0 RID: 2784
		[CompilerGenerated]
		private double? field_13;

		// Token: 0x04000AE1 RID: 2785
		[CompilerGenerated]
		private double? field_14;

		// Token: 0x04000AE2 RID: 2786
		[CompilerGenerated]
		private bool? field_15;

		// Token: 0x04000AE3 RID: 2787
		[CompilerGenerated]
		private bool? field_16;

		// Token: 0x04000AE4 RID: 2788
		[CompilerGenerated]
		private int? field_17;

		// Token: 0x04000AE5 RID: 2789
		[CompilerGenerated]
		private int? field_18;

		// Token: 0x04000AE6 RID: 2790
		[CompilerGenerated]
		private IList<Class_459> field_19;

		// Token: 0x04000AE7 RID: 2791
		[CompilerGenerated]
		private bool field_20;

		// Token: 0x04000AE8 RID: 2792
		[CompilerGenerated]
		private Class_459 field_21;

		// Token: 0x04000AE9 RID: 2793
		[CompilerGenerated]
		private bool field_22;

		// Token: 0x04000AEA RID: 2794
		[CompilerGenerated]
		private bool field_23;

		// Token: 0x04000AEB RID: 2795
		[CompilerGenerated]
		private IDictionary<string, Class_459> field_24;

		// Token: 0x04000AEC RID: 2796
		[CompilerGenerated]
		private Class_459 field_25;

		// Token: 0x04000AED RID: 2797
		[CompilerGenerated]
		private IDictionary<string, Class_459> field_26;

		// Token: 0x04000AEE RID: 2798
		[CompilerGenerated]
		private bool field_27;

		// Token: 0x04000AEF RID: 2799
		[CompilerGenerated]
		private string field_28;

		// Token: 0x04000AF0 RID: 2800
		[CompilerGenerated]
		private IList<Class_361> field_29;

		// Token: 0x04000AF1 RID: 2801
		[CompilerGenerated]
		private Class_463? field_30;

		// Token: 0x04000AF2 RID: 2802
		[CompilerGenerated]
		private Class_361 field_31;

		// Token: 0x04000AF3 RID: 2803
		[CompilerGenerated]
		private IList<Class_459> field_32;

		// Token: 0x04000AF4 RID: 2804
		[CompilerGenerated]
		private string field_33;

		// Token: 0x04000AF5 RID: 2805
		[CompilerGenerated]
		private string field_34;

		// Token: 0x04000AF6 RID: 2806
		[CompilerGenerated]
		private string field_35;

		// Token: 0x04000AF7 RID: 2807
		[CompilerGenerated]
		private bool field_36;
	}
}
