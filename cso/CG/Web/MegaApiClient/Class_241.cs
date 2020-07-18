using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using CG.Web.MegaApiClient.Serialization;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000146 RID: 326
	[DebuggerDisplay("Node - Type: {Type} - Name: {Name} - Id: {Id}")]
	internal class Class_241 : Class_240, IEquatable<Class_232>, Class_232, Class_233, Class_234
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x0003B8F6 File Offset: 0x00039AF6
		public Class_241(byte[] byteDizi_0, ref List<Class_277> arg_0)
		{
			this.field_0 = byteDizi_0;
			this.field_1 = arg_0;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0003B90D File Offset: 0x00039B0D
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0003B915 File Offset: 0x00039B15
		[Class_410("p")]
		public new string prop_0 { get; private set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0003B91E File Offset: 0x00039B1E
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0003B926 File Offset: 0x00039B26
		[Class_410("u")]
		public new string prop_1 { get; private set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0003B92F File Offset: 0x00039B2F
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0003B937 File Offset: 0x00039B37
		[Class_410("su")]
		public new string prop_2 { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0003B940 File Offset: 0x00039B40
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0003B948 File Offset: 0x00039B48
		[Class_410("sk")]
		public new string prop_3 { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0003B951 File Offset: 0x00039B51
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0003B959 File Offset: 0x00039B59
		[Class_411]
		public new DateTime prop_4 { get; private set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0003B962 File Offset: 0x00039B62
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0003B96A File Offset: 0x00039B6A
		[Class_411]
		public new byte[] prop_5 { get; private set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0003B973 File Offset: 0x00039B73
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0003B97B File Offset: 0x00039B7B
		[Class_411]
		public new byte[] prop_6 { get; private set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0003B984 File Offset: 0x00039B84
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0003B98C File Offset: 0x00039B8C
		[Class_411]
		public byte[] prop_7 { get; private set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0003B995 File Offset: 0x00039B95
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0003B99D File Offset: 0x00039B9D
		[Class_411]
		public byte[] prop_8 { get; private set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0003B9A6 File Offset: 0x00039BA6
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0003B9AE File Offset: 0x00039BAE
		[Class_411]
		public byte[] prop_9 { get; private set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0003B9B7 File Offset: 0x00039BB7
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0003B9BF File Offset: 0x00039BBF
		[Class_411]
		public bool prop_10 { get; private set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0003B9C8 File Offset: 0x00039BC8
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0003B9D0 File Offset: 0x00039BD0
		[Class_410("ts")]
		private long prop_11 { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0003B9D9 File Offset: 0x00039BD9
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0003B9E1 File Offset: 0x00039BE1
		[Class_410("a")]
		private string prop_12 { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0003B9EA File Offset: 0x00039BEA
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0003B9F2 File Offset: 0x00039BF2
		[Class_410("k")]
		private string prop_13 { get; set; }

		// Token: 0x0600094F RID: 2383 RVA: 0x0003B9FC File Offset: 0x00039BFC
		[OnDeserialized]
		public void xmethod_1631(StreamingContext arg_0)
		{
			if (this.prop_3 != null && !this.field_1.Any(new Func<Class_277, bool>(this.gmethod_1633)))
			{
				this.field_1.Add(new Class_277(base.prop_3, this.prop_3));
			}
			this.prop_4 = this.prop_11.ToDateTime();
			if (base.prop_2 == Class_235.File || base.prop_2 == Class_235.Directory)
			{
				if (string.IsNullOrEmpty(this.prop_13))
				{
					this.prop_10 = true;
					return;
				}
				string text = this.prop_13.Split(new char[]
				{
					'/'
				})[0];
				int num = text.IndexOf(":", StringComparison.Ordinal);
				byte[] byteDizi_ = text.Substring(num + 1).FromBase64();
				if (this.field_1 != null)
				{
					Class_241.NClass_0 nclass_ = new Class_241.NClass_0();
					nclass_.field_4 = text.Substring(0, num);
					Class_277 class_ = this.field_1.FirstOrDefault(new Func<Class_277, bool>(nclass_.nmethod_1));
					if (class_ != null)
					{
						this.field_0 = Class_223.pmethod_1469(class_.prop_1.FromBase64(), this.field_0);
						if (base.prop_2 == Class_235.Directory)
						{
							this.prop_7 = this.field_0;
						}
						else
						{
							this.prop_7 = Class_223.pmethod_1469(byteDizi_, this.field_0);
						}
					}
				}
				this.prop_6 = Class_223.pmethod_1469(byteDizi_, this.field_0);
				if (base.prop_2 == Class_235.File)
				{
					byte[] byteDizi_2;
					byte[] byteDizi_3;
					byte[] byteDizi_4;
					Class_223.xmethod_1471(this.prop_6, out byteDizi_2, out byteDizi_3, out byteDizi_4);
					this.prop_8 = byteDizi_2;
					this.prop_9 = byteDizi_3;
					this.prop_5 = byteDizi_4;
				}
				else
				{
					this.prop_5 = this.prop_6;
				}
				base.prop_6 = Class_223.lmethod_1478(this.prop_12.FromBase64(), this.prop_5);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0003BBC4 File Offset: 0x00039DC4
		public bool prop_14
		{
			get
			{
				string text = this.prop_13.Split(new char[]
				{
					'/'
				})[0];
				int length = text.IndexOf(":", StringComparison.Ordinal);
				return text.Substring(0, length) == base.prop_3;
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003BC0C File Offset: 0x00039E0C
		[CompilerGenerated]
		private bool gmethod_1633(Class_277 arg_0)
		{
			return arg_0.prop_0 == base.prop_3;
		}

		// Token: 0x04000661 RID: 1633
		private byte[] field_0;

		// Token: 0x04000662 RID: 1634
		private List<Class_277> field_1;

		// Token: 0x04000663 RID: 1635
		[CompilerGenerated]
		private string field_2;

		// Token: 0x04000664 RID: 1636
		[CompilerGenerated]
		private string field_3;

		// Token: 0x04000665 RID: 1637
		[CompilerGenerated]
		private string field_4;

		// Token: 0x04000666 RID: 1638
		[CompilerGenerated]
		private string field_5;

		// Token: 0x04000667 RID: 1639
		[CompilerGenerated]
		private DateTime field_6;

		// Token: 0x04000668 RID: 1640
		[CompilerGenerated]
		private byte[] field_7;

		// Token: 0x04000669 RID: 1641
		[CompilerGenerated]
		private byte[] field_8;

		// Token: 0x0400066A RID: 1642
		[CompilerGenerated]
		private byte[] field_9;

		// Token: 0x0400066B RID: 1643
		[CompilerGenerated]
		private byte[] field_10;

		// Token: 0x0400066C RID: 1644
		[CompilerGenerated]
		private byte[] field_11;

		// Token: 0x0400066D RID: 1645
		[CompilerGenerated]
		private bool field_12;

		// Token: 0x0400066E RID: 1646
		[CompilerGenerated]
		private long field_13;

		// Token: 0x0400066F RID: 1647
		[CompilerGenerated]
		private string field_14;

		// Token: 0x04000670 RID: 1648
		[CompilerGenerated]
		private string field_15;

		// Token: 0x02000147 RID: 327
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000952 RID: 2386 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06000953 RID: 2387 RVA: 0x0003BC1F File Offset: 0x00039E1F
			internal bool nmethod_1(Class_277 arg_0)
			{
				return arg_0.prop_0 == this.field_4;
			}

			// Token: 0x04000671 RID: 1649
			public string field_4;
		}
	}
}
