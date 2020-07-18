using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x02000174 RID: 372
	[Class_378(typeof(ShareDataConverter))]
	internal class Class_275
	{
		// Token: 0x06000A65 RID: 2661 RVA: 0x0003D8E3 File Offset: 0x0003BAE3
		public Class_275(string str_0)
		{
			this.prop_0 = str_0;
			this.field_0 = new List<Class_275.NClass_0>();
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0003D8FD File Offset: 0x0003BAFD
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0003D905 File Offset: 0x0003BB05
		public string prop_0 { get; private set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0003D90E File Offset: 0x0003BB0E
		public IEnumerable<Class_275.NClass_0> prop_1
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0003D918 File Offset: 0x0003BB18
		public void vmethod_1815(string str_0, byte[] byteDizi_0, byte[] byteDizi_1)
		{
			Class_275.NClass_0 item = new Class_275.NClass_0
			{
				nprop_0 = str_0,
				nprop_1 = byteDizi_0,
				nprop_2 = byteDizi_1
			};
			this.field_0.Add(item);
		}

		// Token: 0x040006ED RID: 1773
		private IList<Class_275.NClass_0> field_0;

		// Token: 0x040006EE RID: 1774
		[CompilerGenerated]
		private string field_1;

		// Token: 0x02000175 RID: 373
		public class NClass_0
		{
			// Token: 0x17000244 RID: 580
			// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0003D94C File Offset: 0x0003BB4C
			// (set) Token: 0x06000A6B RID: 2667 RVA: 0x0003D954 File Offset: 0x0003BB54
			public string nprop_0 { get; set; }

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0003D95D File Offset: 0x0003BB5D
			// (set) Token: 0x06000A6D RID: 2669 RVA: 0x0003D965 File Offset: 0x0003BB65
			public byte[] nprop_1 { get; set; }

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0003D96E File Offset: 0x0003BB6E
			// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0003D976 File Offset: 0x0003BB76
			public byte[] nprop_2 { get; set; }

			// Token: 0x06000A70 RID: 2672 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_6()
			{
				base..ctor();
			}

			// Token: 0x040006EF RID: 1775
			[CompilerGenerated]
			private string field_0;

			// Token: 0x040006F0 RID: 1776
			[CompilerGenerated]
			private byte[] field_1;

			// Token: 0x040006F1 RID: 1777
			[CompilerGenerated]
			private byte[] field_2;
		}
	}
}
