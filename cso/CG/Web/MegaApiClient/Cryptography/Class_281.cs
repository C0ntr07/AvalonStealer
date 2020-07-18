using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CG.Web.MegaApiClient.Cryptography
{
	// Token: 0x0200017E RID: 382
	internal class Class_281 : IDisposable, ICryptoTransform
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x0003DF33 File Offset: 0x0003C133
		public Class_281(Func<ICryptoTransform> arg_0, bool bool_0)
		{
			this.field_0 = arg_0;
			this.field_1 = bool_0;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0003DF49 File Offset: 0x0003C149
		public void lmethod_1838()
		{
			ICryptoTransform cryptoTransform = this.field_2;
			if (cryptoTransform == null)
			{
				return;
			}
			cryptoTransform.Dispose();
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0003DF60 File Offset: 0x0003C160
		public int pmethod_1839(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1, byte[] byteDizi_1, int sayıInt_2)
		{
			Class_281.NClass_0 nclass_ = new Class_281.NClass_0();
			nclass_.field_1 = byteDizi_0;
			nclass_.field_2 = sayıInt_0;
			nclass_.field_3 = sayıInt_1;
			nclass_.field_4 = byteDizi_1;
			nclass_.field_5 = sayıInt_2;
			return this.vmethod_1845<int>(new Func<ICryptoTransform, int>(nclass_.nmethod_1));
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003DFAC File Offset: 0x0003C1AC
		public byte[] smethod_1840(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			Class_281.NClass_1 nclass_ = new Class_281.NClass_1();
			nclass_.field_6 = byteDizi_0;
			nclass_.field_7 = sayıInt_0;
			nclass_.field_8 = sayıInt_1;
			if (this.field_1 && this.field_2 != null)
			{
				return this.field_2.TransformFinalBlock(nclass_.field_6, nclass_.field_7, nclass_.field_8);
			}
			return this.vmethod_1845<byte[]>(new Func<ICryptoTransform, byte[]>(nclass_.nmethod_3));
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0003E01A File Offset: 0x0003C21A
		public int prop_0
		{
			get
			{
				return this.vmethod_1845<int>(new Func<ICryptoTransform, int>(Class_281.NClass_2.field_9.nmethod_6));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0003E044 File Offset: 0x0003C244
		public int prop_1
		{
			get
			{
				return this.vmethod_1845<int>(new Func<ICryptoTransform, int>(Class_281.NClass_2.field_9.nmethod_7));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0003E06E File Offset: 0x0003C26E
		public bool prop_2
		{
			get
			{
				return this.vmethod_1845<bool>(new Func<ICryptoTransform, bool>(Class_281.NClass_2.field_9.nmethod_8));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0003E098 File Offset: 0x0003C298
		public bool prop_3
		{
			get
			{
				return this.vmethod_1845<bool>(new Func<ICryptoTransform, bool>(Class_281.NClass_2.field_9.nmethod_9));
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
		private T vmethod_1845<T>(Func<ICryptoTransform, T> arg_0)
		{
			ICryptoTransform cryptoTransform = this.field_2 ?? this.field_0();
			T result;
			try
			{
				result = arg_0(cryptoTransform);
			}
			finally
			{
				if (!this.field_1 && !cryptoTransform.CanReuseTransform)
				{
					cryptoTransform.Dispose();
				}
				else
				{
					this.field_2 = cryptoTransform;
				}
			}
			return result;
		}

		// Token: 0x04000706 RID: 1798
		private readonly Func<ICryptoTransform> field_0;

		// Token: 0x04000707 RID: 1799
		private readonly bool field_1;

		// Token: 0x04000708 RID: 1800
		private ICryptoTransform field_2;

		// Token: 0x0200017F RID: 383
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000AA3 RID: 2723 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x0003E134 File Offset: 0x0003C334
			internal int nmethod_1(ICryptoTransform arg_0)
			{
				return arg_0.TransformBlock(this.field_1, this.field_2, this.field_3, this.field_4, this.field_5);
			}

			// Token: 0x04000709 RID: 1801
			public byte[] field_1;

			// Token: 0x0400070A RID: 1802
			public int field_2;

			// Token: 0x0400070B RID: 1803
			public int field_3;

			// Token: 0x0400070C RID: 1804
			public byte[] field_4;

			// Token: 0x0400070D RID: 1805
			public int field_5;
		}

		// Token: 0x02000180 RID: 384
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06000AA5 RID: 2725 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_2()
			{
				base..ctor();
			}

			// Token: 0x06000AA6 RID: 2726 RVA: 0x0003E15A File Offset: 0x0003C35A
			internal byte[] nmethod_3(ICryptoTransform arg_0)
			{
				return arg_0.TransformFinalBlock(this.field_6, this.field_7, this.field_8);
			}

			// Token: 0x0400070E RID: 1806
			public byte[] field_6;

			// Token: 0x0400070F RID: 1807
			public int field_7;

			// Token: 0x04000710 RID: 1808
			public int field_8;
		}

		// Token: 0x02000181 RID: 385
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_2
		{
			// Token: 0x06000AA7 RID: 2727 RVA: 0x0003E174 File Offset: 0x0003C374
			private static void nmethod_4()
			{
				Class_281.NClass_2.field_9 = new Class_281.NClass_2();
			}

			// Token: 0x06000AA8 RID: 2728 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_5()
			{
				base..ctor();
			}

			// Token: 0x06000AA9 RID: 2729 RVA: 0x0003E180 File Offset: 0x0003C380
			internal int nmethod_6(ICryptoTransform arg_0)
			{
				return arg_0.InputBlockSize;
			}

			// Token: 0x06000AAA RID: 2730 RVA: 0x0003E188 File Offset: 0x0003C388
			internal int nmethod_7(ICryptoTransform arg_0)
			{
				return arg_0.OutputBlockSize;
			}

			// Token: 0x06000AAB RID: 2731 RVA: 0x0003E190 File Offset: 0x0003C390
			internal bool nmethod_8(ICryptoTransform arg_0)
			{
				return arg_0.CanTransformMultipleBlocks;
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x0003E198 File Offset: 0x0003C398
			internal bool nmethod_9(ICryptoTransform arg_0)
			{
				return arg_0.CanReuseTransform;
			}

			// Token: 0x04000711 RID: 1809
			public static readonly Class_281.NClass_2 field_9;

			// Token: 0x04000712 RID: 1810
			public static Func<ICryptoTransform, int> field_10;

			// Token: 0x04000713 RID: 1811
			public static Func<ICryptoTransform, int> field_11;

			// Token: 0x04000714 RID: 1812
			public static Func<ICryptoTransform, bool> field_12;

			// Token: 0x04000715 RID: 1813
			public static Func<ICryptoTransform, bool> field_13;
		}
	}
}
