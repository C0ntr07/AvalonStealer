using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000271 RID: 625
	internal class Class_468 : Class_418
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001567 RID: 5479 RVA: 0x00066D46 File Offset: 0x00064F46
		// (remove) Token: 0x06001568 RID: 5480 RVA: 0x00066D54 File Offset: 0x00064F54
		public virtual event EventHandler<Class_371> Error
		{
			add
			{
				this.field_2.Error += value;
			}
			remove
			{
				this.field_2.Error -= value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00066D62 File Offset: 0x00064F62
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00066D6F File Offset: 0x00064F6F
		public virtual Class_373 prop_0
		{
			get
			{
				return this.field_2.prop_0;
			}
			set
			{
				this.field_2.prop_0 = value;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00066D7D File Offset: 0x00064F7D
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x00066D8A File Offset: 0x00064F8A
		public virtual Class_344 prop_1
		{
			get
			{
				return this.field_2.prop_2;
			}
			set
			{
				this.field_2.prop_2 = value;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00066D98 File Offset: 0x00064F98
		public virtual Class_415 prop_2
		{
			get
			{
				return this.field_2.prop_13;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00066DA5 File Offset: 0x00064FA5
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00066DB2 File Offset: 0x00064FB2
		public virtual Class_377 prop_3
		{
			get
			{
				return this.field_2.prop_9;
			}
			set
			{
				this.field_2.prop_9 = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00066DC0 File Offset: 0x00064FC0
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00066DCD File Offset: 0x00064FCD
		public virtual Class_440 prop_4
		{
			get
			{
				return this.field_2.prop_14;
			}
			set
			{
				this.field_2.prop_14 = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00066DDB File Offset: 0x00064FDB
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00066DE8 File Offset: 0x00064FE8
		public virtual Class_456 prop_5
		{
			get
			{
				return this.field_2.prop_7;
			}
			set
			{
				this.field_2.prop_7 = value;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00066DF6 File Offset: 0x00064FF6
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00066E03 File Offset: 0x00065003
		public virtual Class_457 prop_6
		{
			get
			{
				return this.field_2.prop_8;
			}
			set
			{
				this.field_2.prop_8 = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00066E11 File Offset: 0x00065011
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00066E1E File Offset: 0x0006501E
		public virtual Class_384 prop_7
		{
			get
			{
				return this.field_2.prop_10;
			}
			set
			{
				this.field_2.prop_10 = value;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00066E2C File Offset: 0x0006502C
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x00066E39 File Offset: 0x00065039
		public virtual Class_458 prop_8
		{
			get
			{
				return this.field_2.prop_6;
			}
			set
			{
				this.field_2.prop_6 = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00066E47 File Offset: 0x00065047
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x00066E54 File Offset: 0x00065054
		public virtual Class_375 prop_9
		{
			get
			{
				return this.field_2.prop_5;
			}
			set
			{
				this.field_2.prop_5 = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00066E62 File Offset: 0x00065062
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x00066E6F File Offset: 0x0006506F
		public virtual Class_494 prop_10
		{
			get
			{
				return this.field_2.prop_3;
			}
			set
			{
				this.field_2.prop_3 = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00066E7D File Offset: 0x0006507D
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x00066E8A File Offset: 0x0006508A
		public virtual Class_343 prop_11
		{
			get
			{
				return this.field_2.prop_12;
			}
			set
			{
				this.field_2.prop_12 = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00066E98 File Offset: 0x00065098
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x00066EA5 File Offset: 0x000650A5
		public virtual FormatterAssemblyStyle prop_12
		{
			get
			{
				return this.field_2.prop_4;
			}
			set
			{
				this.field_2.prop_4 = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00066EB3 File Offset: 0x000650B3
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x00066EC0 File Offset: 0x000650C0
		public virtual Class_312 prop_13
		{
			get
			{
				return this.field_2.prop_11;
			}
			set
			{
				this.field_2.prop_11 = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00066ECE File Offset: 0x000650CE
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x00066EDB File Offset: 0x000650DB
		public virtual SerializationBinder prop_14
		{
			get
			{
				return this.field_2.prop_1;
			}
			set
			{
				this.field_2.prop_1 = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00066EE9 File Offset: 0x000650E9
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x00066EF6 File Offset: 0x000650F6
		public virtual StreamingContext prop_15
		{
			get
			{
				return this.field_2.prop_15;
			}
			set
			{
				this.field_2.prop_15 = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00066F04 File Offset: 0x00065104
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x00066F11 File Offset: 0x00065111
		public virtual Class_322 prop_16
		{
			get
			{
				return this.field_2.prop_16;
			}
			set
			{
				this.field_2.prop_16 = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00066F1F File Offset: 0x0006511F
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x00066F2C File Offset: 0x0006512C
		public virtual Class_319 prop_17
		{
			get
			{
				return this.field_2.prop_17;
			}
			set
			{
				this.field_2.prop_17 = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00066F3A File Offset: 0x0006513A
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00066F47 File Offset: 0x00065147
		public virtual Class_321 prop_18
		{
			get
			{
				return this.field_2.prop_18;
			}
			set
			{
				this.field_2.prop_18 = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00066F55 File Offset: 0x00065155
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00066F62 File Offset: 0x00065162
		public virtual Class_320 prop_19
		{
			get
			{
				return this.field_2.prop_19;
			}
			set
			{
				this.field_2.prop_19 = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00066F70 File Offset: 0x00065170
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00066F7D File Offset: 0x0006517D
		public virtual Class_314 prop_20
		{
			get
			{
				return this.field_2.prop_21;
			}
			set
			{
				this.field_2.prop_21 = value;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00066F8B File Offset: 0x0006518B
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x00066F98 File Offset: 0x00065198
		public virtual Class_315 prop_21
		{
			get
			{
				return this.field_2.prop_20;
			}
			set
			{
				this.field_2.prop_20 = value;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00066FA6 File Offset: 0x000651A6
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x00066FB3 File Offset: 0x000651B3
		public virtual Class_356 prop_22
		{
			get
			{
				return this.field_2.prop_22;
			}
			set
			{
				this.field_2.prop_22 = value;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00066FC1 File Offset: 0x000651C1
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x00066FCE File Offset: 0x000651CE
		public virtual string prop_23
		{
			get
			{
				return this.field_2.prop_23;
			}
			set
			{
				this.field_2.prop_23 = value;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00066FDC File Offset: 0x000651DC
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x00066FE9 File Offset: 0x000651E9
		public virtual CultureInfo prop_24
		{
			get
			{
				return this.field_2.prop_24;
			}
			set
			{
				this.field_2.prop_24 = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00066FF7 File Offset: 0x000651F7
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00067004 File Offset: 0x00065204
		public virtual int? prop_25
		{
			get
			{
				return this.field_2.prop_25;
			}
			set
			{
				this.field_2.prop_25 = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00067012 File Offset: 0x00065212
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0006701F File Offset: 0x0006521F
		public virtual bool prop_26
		{
			get
			{
				return this.field_2.prop_26;
			}
			set
			{
				this.field_2.prop_26 = value;
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0006702D File Offset: 0x0006522D
		internal Class_465 cmethod_3994()
		{
			if (this.field_0 != null)
			{
				return this.field_0;
			}
			return this.field_1;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00067047 File Offset: 0x00065247
		public Class_468(Class_466 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "serializerReader");
			this.field_0 = arg_0;
			this.field_2 = arg_0.field_3;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0006706D File Offset: 0x0006526D
		public Class_468(Class_467 arg_0)
		{
			Class_517.ArgumentNotNull(arg_0, "serializerWriter");
			this.field_1 = arg_0;
			this.field_2 = arg_0.field_3;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00067093 File Offset: 0x00065293
		internal virtual object vmethod_3995(Class_285 arg_0, Type arg_1)
		{
			if (this.field_0 != null)
			{
				return this.field_0.gmethod_3853(arg_0, arg_1, false);
			}
			return this.field_2.smethod_3170(arg_0, arg_1);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000670BC File Offset: 0x000652BC
		internal virtual void dmethod_3996(Class_285 arg_0, object obje_0)
		{
			if (this.field_0 != null)
			{
				this.field_0.xmethod_3851(arg_0, obje_0);
				return;
			}
			this.field_2.vmethod_3165(arg_0, obje_0);
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000670E4 File Offset: 0x000652E4
		internal virtual void kmethod_3997(Class_296 arg_0, object obje_0, Type arg_1)
		{
			if (this.field_1 != null)
			{
				this.field_1.tmethod_3902(arg_0, obje_0, arg_1);
				return;
			}
			this.field_2.kmethod_3177(arg_0, obje_0);
		}

		// Token: 0x04000B51 RID: 2897
		private new readonly Class_466 field_0;

		// Token: 0x04000B52 RID: 2898
		private new readonly Class_467 field_1;

		// Token: 0x04000B53 RID: 2899
		private new readonly Class_418 field_2;
	}
}
