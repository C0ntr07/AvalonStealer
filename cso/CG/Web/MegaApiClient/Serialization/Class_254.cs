using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using DamienG.Security.Cryptography;
using Newtonsoft.Json;

namespace CG.Web.MegaApiClient.Serialization
{
	// Token: 0x0200015B RID: 347
	internal class Class_254
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x0000237C File Offset: 0x0000057C
		[Class_323]
		private Class_254()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0003CC62 File Offset: 0x0003AE62
		public Class_254(string str_0)
		{
			this.prop_0 = str_0;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0003CC71 File Offset: 0x0003AE71
		public Class_254(string str_0, Class_254 arg_0)
		{
			this.prop_0 = str_0;
			this.prop_1 = arg_0.prop_1;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0003CC8C File Offset: 0x0003AE8C
		public Class_254(string str_0, Stream stream_, DateTime? arg_0 = null)
		{
			this.prop_0 = str_0;
			if (arg_0 != null)
			{
				byte[] array = new byte[25];
				Buffer.BlockCopy(this.dmethod_1736(stream_), 0, array, 0, 16);
				byte[] array2 = arg_0.Value.ToEpoch().SerializeToBytes();
				Buffer.BlockCopy(array2, 0, array, 16, array2.Length);
				Array.Resize<byte>(ref array, array.Length - 9 + array2.Length);
				this.prop_1 = array.ToBase64();
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0003CD07 File Offset: 0x0003AF07
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0003CD0F File Offset: 0x0003AF0F
		[Class_410("n")]
		public string prop_0 { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0003CD18 File Offset: 0x0003AF18
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x0003CD20 File Offset: 0x0003AF20
		[Class_410("c", DefaultValueHandling = 1)]
		public string prop_1 { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0003CD29 File Offset: 0x0003AF29
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x0003CD31 File Offset: 0x0003AF31
		[Class_411]
		public DateTime? prop_2 { get; private set; }

		// Token: 0x060009E3 RID: 2531 RVA: 0x0003CD3C File Offset: 0x0003AF3C
		[OnDeserialized]
		public void vmethod_1735(StreamingContext arg_0)
		{
			if (this.prop_1 != null)
			{
				byte[] array = this.prop_1.FromBase64();
				this.prop_2 = new DateTime?(array.DeserializeToLong(16, array.Length - 16).ToDateTime());
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0003CD80 File Offset: 0x0003AF80
		private uint[] dmethod_1736(Stream stream_)
		{
			stream_.Seek(0L, SeekOrigin.Begin);
			uint[] array = new uint[4];
			byte[] array2 = new byte[16];
			uint num = 0U;
			if (stream_.Length <= 16L)
			{
				if (stream_.Read(array2, 0, (int)stream_.Length) != 0)
				{
					Buffer.BlockCopy(array2, 0, array, 0, array2.Length);
				}
			}
			else if (stream_.Length <= 8192L)
			{
				byte[] buffer = new byte[stream_.Length];
				int num2 = 0;
				while ((long)(num2 += stream_.Read(buffer, num2, (int)stream_.Length - num2)) < stream_.Length)
				{
				}
				for (int i = 0; i < array.Length; i++)
				{
					int num3 = (int)((long)i * stream_.Length / (long)array.Length);
					int num4 = (int)((long)(i + 1) * stream_.Length / (long)array.Length);
					using (Class_221 class_ = new Class_221(3988292384U, uint.MaxValue))
					{
						num = BitConverter.ToUInt32(class_.ComputeHash(buffer, num3, num4 - num3), 0);
					}
					array[i] = num;
				}
			}
			else
			{
				byte[] array3 = new byte[64];
				uint num5 = (uint)(8192 / (array3.Length * 4));
				long num6 = 0L;
				for (uint num7 = 0U; num7 < 4U; num7 += 1U)
				{
					byte[] array4 = null;
					uint num8 = uint.MaxValue;
					for (uint num9 = 0U; num9 < num5; num9 += 1U)
					{
						long num10 = (stream_.Length - (long)array3.Length) * (long)((ulong)(num7 * num5 + num9)) / (long)((ulong)(4U * num5 - 1U));
						stream_.Seek(num10 - num6, SeekOrigin.Current);
						num6 += num10 - num6;
						int num11 = stream_.Read(array3, 0, array3.Length);
						num6 += (long)num11;
						using (Class_221 class_2 = new Class_221(3988292384U, num8))
						{
							array4 = class_2.ComputeHash(array3, 0, num11);
							byte[] array5 = new byte[array4.Length];
							array4.CopyTo(array5, 0);
							if (BitConverter.IsLittleEndian)
							{
								Array.Reverse(array5);
							}
							num8 = BitConverter.ToUInt32(array5, 0);
							num8 = ~num8;
						}
					}
					num = BitConverter.ToUInt32(array4, 0);
					array[(int)num7] = num;
				}
			}
			return array;
		}

		// Token: 0x040006B3 RID: 1715
		private const int field_0 = 4;

		// Token: 0x040006B4 RID: 1716
		private const int field_1 = 16;

		// Token: 0x040006B5 RID: 1717
		private const int field_2 = 25;

		// Token: 0x040006B6 RID: 1718
		private const int field_3 = 8192;

		// Token: 0x040006B7 RID: 1719
		private const uint field_4 = 3988292384U;

		// Token: 0x040006B8 RID: 1720
		[CompilerGenerated]
		private string field_5;

		// Token: 0x040006B9 RID: 1721
		[CompilerGenerated]
		private string field_6;

		// Token: 0x040006BA RID: 1722
		[CompilerGenerated]
		private DateTime? field_7;
	}
}
