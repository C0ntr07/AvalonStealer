using System;

namespace Ionic.Zlib
{
	// Token: 0x020000FD RID: 253
	internal sealed class Class_196
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00031384 File Offset: 0x0002F584
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0003138C File Offset: 0x0002F58C
		internal bool HandleRfc1950HeaderBytes
		{
			get
			{
				return this._handleRfc1950HeaderBytes;
			}
			set
			{
				this._handleRfc1950HeaderBytes = value;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00031395 File Offset: 0x0002F595
		public Class_196()
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000313A4 File Offset: 0x0002F5A4
		public Class_196(bool expectRfc1950HeaderBytes)
		{
			this._handleRfc1950HeaderBytes = expectRfc1950HeaderBytes;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000313BC File Offset: 0x0002F5BC
		internal int Reset()
		{
			this._codec.TotalBytesIn = (this._codec.TotalBytesOut = 0L);
			this._codec.Message = null;
			this.mode = (this.HandleRfc1950HeaderBytes ? Class_196.InflateManagerMode.METHOD : Class_196.InflateManagerMode.BLOCKS);
			this.blocks.Reset();
			return 0;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00031415 File Offset: 0x0002F615
		internal int End()
		{
			if (this.blocks != null)
			{
				this.blocks.Free();
			}
			this.blocks = null;
			return 0;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00031438 File Offset: 0x0002F638
		internal int Initialize(Class_212 codec, int w)
		{
			this._codec = codec;
			this._codec.Message = null;
			this.blocks = null;
			if (w < 8 || w > 15)
			{
				this.End();
				throw new Class_205("Bad window size.");
			}
			this.wbits = w;
			this.blocks = new Class_193(codec, this.HandleRfc1950HeaderBytes ? this : null, 1 << w);
			this.Reset();
			return 0;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000314B4 File Offset: 0x0002F6B4
		internal int Inflate(Class_201 flush)
		{
			if (this._codec.InputBuffer == null)
			{
				throw new Class_205("InputBuffer is null. ");
			}
			int num = 0;
			int num2 = -5;
			for (;;)
			{
				switch (this.mode)
				{
				case Class_196.InflateManagerMode.METHOD:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					if (((this.method = (int)this._codec.InputBuffer[this._codec.NextIn++]) & 15) != 8)
					{
						this.mode = Class_196.InflateManagerMode.BAD;
						this._codec.Message = string.Format("unknown compression method (0x{0:X2})", this.method);
						this.marker = 5;
						continue;
					}
					if ((this.method >> 4) + 8 > this.wbits)
					{
						this.mode = Class_196.InflateManagerMode.BAD;
						this._codec.Message = string.Format("invalid window size ({0})", (this.method >> 4) + 8);
						this.marker = 5;
						continue;
					}
					this.mode = Class_196.InflateManagerMode.FLAG;
					continue;
				case Class_196.InflateManagerMode.FLAG:
				{
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					int num3 = (int)(this._codec.InputBuffer[this._codec.NextIn++] & byte.MaxValue);
					if (((this.method << 8) + num3) % 31 != 0)
					{
						this.mode = Class_196.InflateManagerMode.BAD;
						this._codec.Message = "incorrect header check";
						this.marker = 5;
						continue;
					}
					this.mode = (((num3 & 32) == 0) ? Class_196.InflateManagerMode.BLOCKS : Class_196.InflateManagerMode.DICT4);
					continue;
				}
				case Class_196.InflateManagerMode.DICT4:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck = (uint)((long)((long)this._codec.InputBuffer[this._codec.NextIn++] << 24) & (long)((ulong)-16777216));
					this.mode = Class_196.InflateManagerMode.DICT3;
					continue;
				case Class_196.InflateManagerMode.DICT3:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck += (uint)((int)this._codec.InputBuffer[this._codec.NextIn++] << 16 & 16711680);
					this.mode = Class_196.InflateManagerMode.DICT2;
					continue;
				case Class_196.InflateManagerMode.DICT2:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck += (uint)((int)this._codec.InputBuffer[this._codec.NextIn++] << 8 & 65280);
					this.mode = Class_196.InflateManagerMode.DICT1;
					continue;
				case Class_196.InflateManagerMode.DICT1:
					goto IL_3A0;
				case Class_196.InflateManagerMode.DICT0:
					goto IL_42C;
				case Class_196.InflateManagerMode.BLOCKS:
					num2 = this.blocks.Process(num2);
					if (num2 == -3)
					{
						this.mode = Class_196.InflateManagerMode.BAD;
						this.marker = 0;
						continue;
					}
					if (num2 == 0)
					{
						num2 = num;
					}
					if (num2 != 1)
					{
						return num2;
					}
					num2 = num;
					this.computedCheck = this.blocks.Reset();
					if (!this.HandleRfc1950HeaderBytes)
					{
						goto Block_16;
					}
					this.mode = Class_196.InflateManagerMode.CHECK4;
					continue;
				case Class_196.InflateManagerMode.CHECK4:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck = (uint)((long)((long)this._codec.InputBuffer[this._codec.NextIn++] << 24) & (long)((ulong)-16777216));
					this.mode = Class_196.InflateManagerMode.CHECK3;
					continue;
				case Class_196.InflateManagerMode.CHECK3:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck += (uint)((int)this._codec.InputBuffer[this._codec.NextIn++] << 16 & 16711680);
					this.mode = Class_196.InflateManagerMode.CHECK2;
					continue;
				case Class_196.InflateManagerMode.CHECK2:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck += (uint)((int)this._codec.InputBuffer[this._codec.NextIn++] << 8 & 65280);
					this.mode = Class_196.InflateManagerMode.CHECK1;
					continue;
				case Class_196.InflateManagerMode.CHECK1:
					if (this._codec.AvailableBytesIn == 0)
					{
						return num2;
					}
					num2 = num;
					this._codec.AvailableBytesIn--;
					this._codec.TotalBytesIn += 1L;
					this.expectedCheck += (uint)(this._codec.InputBuffer[this._codec.NextIn++] & byte.MaxValue);
					if (this.computedCheck != this.expectedCheck)
					{
						this.mode = Class_196.InflateManagerMode.BAD;
						this._codec.Message = "incorrect data check";
						this.marker = 5;
						continue;
					}
					goto IL_6E4;
				case Class_196.InflateManagerMode.DONE:
					return 1;
				case Class_196.InflateManagerMode.BAD:
					goto IL_6F0;
				}
				break;
			}
			throw new Class_205("Stream error.");
			IL_3A0:
			if (this._codec.AvailableBytesIn == 0)
			{
				return num2;
			}
			this._codec.AvailableBytesIn--;
			this._codec.TotalBytesIn += 1L;
			this.expectedCheck += (uint)(this._codec.InputBuffer[this._codec.NextIn++] & byte.MaxValue);
			this._codec._Adler32 = this.expectedCheck;
			this.mode = Class_196.InflateManagerMode.DICT0;
			return 2;
			IL_42C:
			this.mode = Class_196.InflateManagerMode.BAD;
			this._codec.Message = "need dictionary";
			this.marker = 0;
			return -2;
			Block_16:
			this.mode = Class_196.InflateManagerMode.DONE;
			return 1;
			IL_6E4:
			this.mode = Class_196.InflateManagerMode.DONE;
			return 1;
			IL_6F0:
			throw new Class_205(string.Format("Bad state ({0})", this._codec.Message));
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		internal int SetDictionary(byte[] dictionary)
		{
			int start = 0;
			int num = dictionary.Length;
			if (this.mode != Class_196.InflateManagerMode.DICT0)
			{
				throw new Class_205("Stream error.");
			}
			if (Class_209.Adler32(1U, dictionary, 0, dictionary.Length) != this._codec._Adler32)
			{
				return -3;
			}
			this._codec._Adler32 = Class_209.Adler32(0U, null, 0, 0);
			if (num >= 1 << this.wbits)
			{
				num = (1 << this.wbits) - 1;
				start = dictionary.Length - num;
			}
			this.blocks.SetDictionary(dictionary, start, num);
			this.mode = Class_196.InflateManagerMode.BLOCKS;
			return 0;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00031C70 File Offset: 0x0002FE70
		internal int Sync()
		{
			if (this.mode != Class_196.InflateManagerMode.BAD)
			{
				this.mode = Class_196.InflateManagerMode.BAD;
				this.marker = 0;
			}
			int num;
			if ((num = this._codec.AvailableBytesIn) == 0)
			{
				return -5;
			}
			int num2 = this._codec.NextIn;
			int num3 = this.marker;
			while (num != 0 && num3 < 4)
			{
				if (this._codec.InputBuffer[num2] == Class_196.mark[num3])
				{
					num3++;
				}
				else if (this._codec.InputBuffer[num2] != 0)
				{
					num3 = 0;
				}
				else
				{
					num3 = 4 - num3;
				}
				num2++;
				num--;
			}
			this._codec.TotalBytesIn += (long)(num2 - this._codec.NextIn);
			this._codec.NextIn = num2;
			this._codec.AvailableBytesIn = num;
			this.marker = num3;
			if (num3 != 4)
			{
				return -3;
			}
			long totalBytesIn = this._codec.TotalBytesIn;
			long totalBytesOut = this._codec.TotalBytesOut;
			this.Reset();
			this._codec.TotalBytesIn = totalBytesIn;
			this._codec.TotalBytesOut = totalBytesOut;
			this.mode = Class_196.InflateManagerMode.BLOCKS;
			return 0;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00031DA1 File Offset: 0x0002FFA1
		internal int SyncPoint(Class_212 z)
		{
			return this.blocks.SyncPoint();
		}

		// Token: 0x040004F1 RID: 1265
		private const int PRESET_DICT = 32;

		// Token: 0x040004F2 RID: 1266
		private const int Z_DEFLATED = 8;

		// Token: 0x040004F3 RID: 1267
		private Class_196.InflateManagerMode mode;

		// Token: 0x040004F4 RID: 1268
		internal Class_212 _codec;

		// Token: 0x040004F5 RID: 1269
		internal int method;

		// Token: 0x040004F6 RID: 1270
		internal uint computedCheck;

		// Token: 0x040004F7 RID: 1271
		internal uint expectedCheck;

		// Token: 0x040004F8 RID: 1272
		internal int marker;

		// Token: 0x040004F9 RID: 1273
		private bool _handleRfc1950HeaderBytes = true;

		// Token: 0x040004FA RID: 1274
		internal int wbits;

		// Token: 0x040004FB RID: 1275
		internal Class_193 blocks;

		// Token: 0x040004FC RID: 1276
		private static readonly byte[] mark = new byte[]
		{
			0,
			0,
			byte.MaxValue,
			byte.MaxValue
		};

		// Token: 0x020000FE RID: 254
		private enum InflateManagerMode
		{
			// Token: 0x040004FE RID: 1278
			METHOD,
			// Token: 0x040004FF RID: 1279
			FLAG,
			// Token: 0x04000500 RID: 1280
			DICT4,
			// Token: 0x04000501 RID: 1281
			DICT3,
			// Token: 0x04000502 RID: 1282
			DICT2,
			// Token: 0x04000503 RID: 1283
			DICT1,
			// Token: 0x04000504 RID: 1284
			DICT0,
			// Token: 0x04000505 RID: 1285
			BLOCKS,
			// Token: 0x04000506 RID: 1286
			CHECK4,
			// Token: 0x04000507 RID: 1287
			CHECK3,
			// Token: 0x04000508 RID: 1288
			CHECK2,
			// Token: 0x04000509 RID: 1289
			CHECK1,
			// Token: 0x0400050A RID: 1290
			DONE,
			// Token: 0x0400050B RID: 1291
			BAD
		}
	}
}
