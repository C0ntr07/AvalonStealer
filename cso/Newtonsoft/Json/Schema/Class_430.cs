using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200023F RID: 575
	[Serializable]
	public class Class_430 : Class_318
	{
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0005ADEC File Offset: 0x00058FEC
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x0005ADF4 File Offset: 0x00058FF4
		public int prop_0 { get; private set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x0005ADFD File Offset: 0x00058FFD
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x0005AE05 File Offset: 0x00059005
		public int prop_1 { get; private set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0005AE0E File Offset: 0x0005900E
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x0005AE16 File Offset: 0x00059016
		public string prop_2 { get; private set; }

		// Token: 0x06001325 RID: 4901 RVA: 0x000550DF File Offset: 0x000532DF
		public Class_430()
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000550E7 File Offset: 0x000532E7
		public Class_430(string str_0) : base(str_0)
		{
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000550F0 File Offset: 0x000532F0
		public Class_430(string str_0, Exception arg_0) : base(str_0, arg_0)
		{
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000550FA File Offset: 0x000532FA
		public Class_430(SerializationInfo arg_0, StreamingContext arg_1) : base(arg_0, arg_1)
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0005AE1F File Offset: 0x0005901F
		internal Class_430(string str_0, Exception arg_0, string str_1, int sayıInt_0, int sayıInt_1) : base(str_0, arg_0)
		{
			this.prop_2 = str_1;
			this.prop_0 = sayıInt_0;
			this.prop_1 = sayıInt_1;
		}

		// Token: 0x04000A31 RID: 2609
		[CompilerGenerated]
		private int field_0;

		// Token: 0x04000A32 RID: 2610
		[CompilerGenerated]
		private int field_1;

		// Token: 0x04000A33 RID: 2611
		[CompilerGenerated]
		private string field_2;
	}
}
