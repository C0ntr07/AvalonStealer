using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace CG.Web.MegaApiClient
{
	// Token: 0x02000152 RID: 338
	internal abstract class Class_249 : Stream
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x0003C324 File Offset: 0x0003A524
		protected Class_249(Stream stream_, long sayıUınt_0, Class_249.NClass_0 arg_0, byte[] byteDizi_0, byte[] byteDizi_1)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (byteDizi_0 == null || byteDizi_0.Length != 16)
			{
				throw new ArgumentException("Invalid fileKey");
			}
			if (byteDizi_1 == null || byteDizi_1.Length != 8)
			{
				throw new ArgumentException("Invalid Iv");
			}
			this.field_5 = stream_;
			this.field_2 = sayıUınt_0;
			this.field_6 = arg_0;
			this.field_0 = byteDizi_0;
			this.field_1 = byteDizi_1;
			this.prop_0 = this.cmethod_1704(this.field_2).ToArray<long>();
			this.field_7 = new HashSet<long>(this.prop_0);
			this.field_9 = Class_223.gmethod_1473(this.field_0);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0003C411 File Offset: 0x0003A611
		protected virtual void lmethod_1688(bool bool_0)
		{
			base.Dispose(bool_0);
			this.field_9.Dispose();
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x0003C425 File Offset: 0x0003A625
		public long[] prop_0 { get; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public virtual bool prop_1
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_2
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00018464 File Offset: 0x00016664
		public virtual bool prop_3
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0003C42D File Offset: 0x0003A62D
		public virtual long prop_4
		{
			get
			{
				return this.field_2;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0003C435 File Offset: 0x0003A635
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0003C43D File Offset: 0x0003A63D
		public virtual long prop_5
		{
			get
			{
				return this.field_3;
			}
			set
			{
				if (this.field_3 != value)
				{
					throw new NotSupportedException("Seek is not supported");
				}
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0003C458 File Offset: 0x0003A658
		public virtual int dmethod_1696(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_3 == this.field_2)
			{
				return 0;
			}
			for (long num = this.field_3; num < Math.Min(this.field_3 + (long)sayıInt_1, this.field_2); num += 16L)
			{
				if (this.field_7.Contains(num))
				{
					if (num != 0L)
					{
						this.gmethod_1703(this.field_9);
					}
					for (int i = 0; i < 8; i++)
					{
						this.field_11[i] = this.field_1[i];
						this.field_11[i + 8] = this.field_1[i];
					}
				}
				this.tmethod_1702();
				byte[] array = new byte[16];
				byte[] array2 = new byte[array.Length];
				int num2 = this.field_5.Read(array, 0, array.Length);
				if (num2 != array.Length)
				{
					num2 += this.field_5.Read(array, num2, array.Length - num2);
				}
				byte[] array3 = new byte[16];
				Array.Copy(this.field_1, array3, 8);
				Array.Copy(this.field_8, 0, array3, 8, 8);
				byte[] array4 = Class_223.cmethod_1474(array3, this.field_9);
				for (int j = 0; j < num2; j++)
				{
					array2[j] = (array4[j] ^ array[j]);
					byte[] array5 = this.field_11;
					int num3 = j;
					array5[num3] ^= ((this.field_6 == Class_249.NClass_0.field_2) ? array[j] : array2[j]);
				}
				Array.Copy(array2, 0, byteDizi_0, (int)((long)sayıInt_0 + num - this.field_3), (int)Math.Min((long)array2.Length, this.field_2 - num));
				this.field_11 = Class_223.cmethod_1474(this.field_11, this.field_9);
			}
			long num4 = Math.Min((long)sayıInt_1, this.field_2 - this.field_3);
			this.field_3 += num4;
			if (this.field_3 == this.field_2)
			{
				this.gmethod_1703(this.field_9);
				for (int k = 0; k < 4; k++)
				{
					this.field_4[k] = (this.field_12[k] ^ this.field_12[k + 4]);
					this.field_4[k + 4] = (this.field_12[k + 8] ^ this.field_12[k + 12]);
				}
				this.xmethod_1701();
			}
			return (int)num4;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void kmethod_1697()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual long lmethod_1698(long sayıUınt_0, SeekOrigin arg_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void pmethod_1699(long sayıUınt_0)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001429B File Offset: 0x0001249B
		public virtual void smethod_1700(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual void xmethod_1701()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		private void tmethod_1702()
		{
			if ((this.field_10 & 255L) != 255L && (this.field_10 & 255L) != 0L)
			{
				byte[] array = this.field_8;
				int num = 7;
				array[num] += 1;
			}
			else
			{
				byte[] bytes = BitConverter.GetBytes(this.field_10);
				if (BitConverter.IsLittleEndian)
				{
					Array.Reverse(bytes);
				}
				Array.Copy(bytes, this.field_8, 8);
			}
			this.field_10 += 1L;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0003C730 File Offset: 0x0003A930
		private void gmethod_1703(ICryptoTransform arg_0)
		{
			for (int i = 0; i < 16; i++)
			{
				byte[] array = this.field_12;
				int num = i;
				array[num] ^= this.field_11[i];
			}
			this.field_12 = Class_223.cmethod_1474(this.field_12, arg_0);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0003C778 File Offset: 0x0003A978
		private IEnumerable<long> cmethod_1704(long sayıUınt_0)
		{
			yield return 0L;
			long num = 0L;
			int num2;
			for (int i = 1; i <= 8; i = num2 + 1)
			{
				if (num >= sayıUınt_0 - (long)(i * 131072))
				{
					break;
				}
				num += (long)(i * 131072);
				yield return num;
				num2 = i;
			}
			while (num + 1048576L < sayıUınt_0)
			{
				num += 1048576L;
				yield return num;
			}
			yield break;
		}

		// Token: 0x0400068B RID: 1675
		protected readonly byte[] field_0;

		// Token: 0x0400068C RID: 1676
		protected readonly byte[] field_1;

		// Token: 0x0400068D RID: 1677
		protected readonly long field_2;

		// Token: 0x0400068E RID: 1678
		protected long field_3;

		// Token: 0x0400068F RID: 1679
		protected byte[] field_4 = new byte[8];

		// Token: 0x04000690 RID: 1680
		private readonly Stream field_5;

		// Token: 0x04000691 RID: 1681
		private readonly Class_249.NClass_0 field_6;

		// Token: 0x04000692 RID: 1682
		private readonly HashSet<long> field_7;

		// Token: 0x04000693 RID: 1683
		private readonly byte[] field_8 = new byte[8];

		// Token: 0x04000694 RID: 1684
		private readonly ICryptoTransform field_9;

		// Token: 0x04000695 RID: 1685
		private long field_10;

		// Token: 0x04000696 RID: 1686
		private byte[] field_11 = new byte[16];

		// Token: 0x04000697 RID: 1687
		private byte[] field_12 = new byte[16];

		// Token: 0x04000698 RID: 1688
		[CompilerGenerated]
		private readonly long[] field_13;

		// Token: 0x02000153 RID: 339
		protected enum NClass_0
		{
			// Token: 0x0400069A RID: 1690
			field_2,
			// Token: 0x0400069B RID: 1691
			field_3
		}
	}
}
