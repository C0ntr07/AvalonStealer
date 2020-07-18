using System;

namespace Ionic.Zlib
{
	// Token: 0x020000F4 RID: 244
	internal sealed class Class_190
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x0002BB64 File Offset: 0x00029D64
		internal Class_190()
		{
			this.dyn_ltree = new short[Class_190.HEAP_SIZE * 2];
			this.dyn_dtree = new short[(2 * Class_207.D_CODES + 1) * 2];
			this.bl_tree = new short[(2 * Class_207.BL_CODES + 1) * 2];
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002BC18 File Offset: 0x00029E18
		private void _InitializeLazyMatch()
		{
			this.window_size = 2 * this.w_size;
			Array.Clear(this.head, 0, this.hash_size);
			this.config = Class_190.Config.Lookup(this.compressionLevel);
			this.SetDeflater();
			this.strstart = 0;
			this.block_start = 0;
			this.lookahead = 0;
			this.match_length = (this.prev_length = Class_190.MIN_MATCH - 1);
			this.match_available = 0;
			this.ins_h = 0;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0002BC98 File Offset: 0x00029E98
		private void _InitializeTreeData()
		{
			this.treeLiterals.dyn_tree = this.dyn_ltree;
			this.treeLiterals.staticTree = Class_208.Literals;
			this.treeDistances.dyn_tree = this.dyn_dtree;
			this.treeDistances.staticTree = Class_208.Distances;
			this.treeBitLengths.dyn_tree = this.bl_tree;
			this.treeBitLengths.staticTree = Class_208.BitLengths;
			this.bi_buf = 0;
			this.bi_valid = 0;
			this.last_eob_len = 8;
			this._InitializeBlocks();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0002BD24 File Offset: 0x00029F24
		internal void _InitializeBlocks()
		{
			for (int i = 0; i < Class_207.L_CODES; i++)
			{
				this.dyn_ltree[i * 2] = 0;
			}
			for (int j = 0; j < Class_207.D_CODES; j++)
			{
				this.dyn_dtree[j * 2] = 0;
			}
			for (int k = 0; k < Class_207.BL_CODES; k++)
			{
				this.bl_tree[k * 2] = 0;
			}
			this.dyn_ltree[Class_190.END_BLOCK * 2] = 1;
			this.opt_len = (this.static_len = 0);
			this.last_lit = (this.matches = 0);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002BDBC File Offset: 0x00029FBC
		internal void pqdownheap(short[] tree, int k)
		{
			int num = this.heap[k];
			for (int i = k << 1; i <= this.heap_len; i <<= 1)
			{
				if (i < this.heap_len && Class_190._IsSmaller(tree, this.heap[i + 1], this.heap[i], this.depth))
				{
					i++;
				}
				if (Class_190._IsSmaller(tree, num, this.heap[i], this.depth))
				{
					break;
				}
				this.heap[k] = this.heap[i];
				k = i;
			}
			this.heap[k] = num;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002BE54 File Offset: 0x0002A054
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			short num = tree[n * 2];
			short num2 = tree[m * 2];
			return num < num2 || (num == num2 && depth[n] <= depth[m]);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002BE8C File Offset: 0x0002A08C
		internal void scan_tree(short[] tree, int max_code)
		{
			int num = -1;
			int num2 = (int)tree[1];
			int num3 = 0;
			int num4 = 7;
			int num5 = 4;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			tree[(max_code + 1) * 2 + 1] = short.MaxValue;
			for (int i = 0; i <= max_code; i++)
			{
				int num6 = num2;
				num2 = (int)tree[(i + 1) * 2 + 1];
				if (++num3 >= num4 || num6 != num2)
				{
					if (num3 < num5)
					{
						this.bl_tree[num6 * 2] = (short)((int)this.bl_tree[num6 * 2] + num3);
					}
					else if (num6 != 0)
					{
						if (num6 != num)
						{
							short[] array = this.bl_tree;
							int num7 = num6 * 2;
							array[num7] += 1;
						}
						short[] array2 = this.bl_tree;
						int num8 = Class_207.REP_3_6 * 2;
						array2[num8] += 1;
					}
					else if (num3 <= 10)
					{
						short[] array3 = this.bl_tree;
						int num9 = Class_207.REPZ_3_10 * 2;
						array3[num9] += 1;
					}
					else
					{
						short[] array4 = this.bl_tree;
						int num10 = Class_207.REPZ_11_138 * 2;
						array4[num10] += 1;
					}
					num3 = 0;
					num = num6;
					if (num2 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else if (num6 == num2)
					{
						num4 = 6;
						num5 = 3;
					}
					else
					{
						num4 = 7;
						num5 = 4;
					}
				}
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		internal int build_bl_tree()
		{
			this.scan_tree(this.dyn_ltree, this.treeLiterals.max_code);
			this.scan_tree(this.dyn_dtree, this.treeDistances.max_code);
			this.treeBitLengths.build_tree(this);
			int num = Class_207.BL_CODES - 1;
			while (num >= 3 && this.bl_tree[(int)(Class_200.bl_order[num] * 2 + 1)] == 0)
			{
				num--;
			}
			this.opt_len += 3 * (num + 1) + 5 + 5 + 4;
			return num;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0002C05C File Offset: 0x0002A25C
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
			this.send_bits(lcodes - 257, 5);
			this.send_bits(dcodes - 1, 5);
			this.send_bits(blcodes - 4, 4);
			for (int i = 0; i < blcodes; i++)
			{
				this.send_bits((int)this.bl_tree[(int)(Class_200.bl_order[i] * 2 + 1)], 3);
			}
			this.send_tree(this.dyn_ltree, lcodes - 1);
			this.send_tree(this.dyn_dtree, dcodes - 1);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
		internal void send_tree(short[] tree, int max_code)
		{
			int num = -1;
			int num2 = (int)tree[1];
			int num3 = 0;
			int num4 = 7;
			int num5 = 4;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			for (int i = 0; i <= max_code; i++)
			{
				int num6 = num2;
				num2 = (int)tree[(i + 1) * 2 + 1];
				if (++num3 >= num4 || num6 != num2)
				{
					if (num3 < num5)
					{
						do
						{
							this.send_code(num6, this.bl_tree);
						}
						while (--num3 != 0);
					}
					else if (num6 != 0)
					{
						if (num6 != num)
						{
							this.send_code(num6, this.bl_tree);
							num3--;
						}
						this.send_code(Class_207.REP_3_6, this.bl_tree);
						this.send_bits(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						this.send_code(Class_207.REPZ_3_10, this.bl_tree);
						this.send_bits(num3 - 3, 3);
					}
					else
					{
						this.send_code(Class_207.REPZ_11_138, this.bl_tree);
						this.send_bits(num3 - 11, 7);
					}
					num3 = 0;
					num = num6;
					if (num2 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else if (num6 == num2)
					{
						num4 = 6;
						num5 = 3;
					}
					else
					{
						num4 = 7;
						num5 = 4;
					}
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0002C20B File Offset: 0x0002A40B
		private void put_bytes(byte[] p, int start, int len)
		{
			Array.Copy(p, start, this.pending, this.pendingCount, len);
			this.pendingCount += len;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0002C230 File Offset: 0x0002A430
		internal void send_code(int c, short[] tree)
		{
			int num = c * 2;
			this.send_bits((int)tree[num] & 65535, (int)tree[num + 1] & 65535);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0002C25C File Offset: 0x0002A45C
		internal void send_bits(int value, int length)
		{
			if (this.bi_valid > Class_190.Buf_size - length)
			{
				this.bi_buf |= (short)(value << this.bi_valid & 65535);
				this.pending[this.pendingCount++] = (byte)this.bi_buf;
				this.pending[this.pendingCount++] = (byte)(this.bi_buf >> 8);
				this.bi_buf = (short)((uint)value >> Class_190.Buf_size - this.bi_valid);
				this.bi_valid += length - Class_190.Buf_size;
				return;
			}
			this.bi_buf |= (short)(value << this.bi_valid & 65535);
			this.bi_valid += length;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002C338 File Offset: 0x0002A538
		internal void _tr_align()
		{
			this.send_bits(Class_190.STATIC_TREES << 1, 3);
			this.send_code(Class_190.END_BLOCK, Class_208.lengthAndLiteralsTreeCodes);
			this.bi_flush();
			if (1 + this.last_eob_len + 10 - this.bi_valid < 9)
			{
				this.send_bits(Class_190.STATIC_TREES << 1, 3);
				this.send_code(Class_190.END_BLOCK, Class_208.lengthAndLiteralsTreeCodes);
				this.bi_flush();
			}
			this.last_eob_len = 7;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
		internal bool _tr_tally(int dist, int lc)
		{
			this.pending[this._distanceOffset + this.last_lit * 2] = (byte)((uint)dist >> 8);
			this.pending[this._distanceOffset + this.last_lit * 2 + 1] = (byte)dist;
			this.pending[this._lengthOffset + this.last_lit] = (byte)lc;
			this.last_lit++;
			if (dist == 0)
			{
				short[] array = this.dyn_ltree;
				int num = lc * 2;
				array[num] += 1;
			}
			else
			{
				this.matches++;
				dist--;
				short[] array2 = this.dyn_ltree;
				int num2 = ((int)Class_200.LengthCode[lc] + Class_207.LITERALS + 1) * 2;
				array2[num2] += 1;
				short[] array3 = this.dyn_dtree;
				int num3 = Class_200.DistanceCode(dist) * 2;
				array3[num3] += 1;
			}
			if ((this.last_lit & 8191) == 0 && this.compressionLevel > Class_202.Level2)
			{
				int num4 = this.last_lit << 3;
				int num5 = this.strstart - this.block_start;
				for (int i = 0; i < Class_207.D_CODES; i++)
				{
					num4 = (int)((long)num4 + (long)this.dyn_dtree[i * 2] * (5L + (long)Class_200.ExtraDistanceBits[i]));
				}
				num4 >>= 3;
				if (this.matches < this.last_lit / 2 && num4 < num5 / 2)
				{
					return true;
				}
			}
			return this.last_lit == this.lit_bufsize - 1 || this.last_lit == this.lit_bufsize;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002C52C File Offset: 0x0002A72C
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
			int num = 0;
			if (this.last_lit != 0)
			{
				do
				{
					int num2 = this._distanceOffset + num * 2;
					int num3 = ((int)this.pending[num2] << 8 & 65280) | (int)(this.pending[num2 + 1] & byte.MaxValue);
					int num4 = (int)(this.pending[this._lengthOffset + num] & byte.MaxValue);
					num++;
					if (num3 == 0)
					{
						this.send_code(num4, ltree);
					}
					else
					{
						int num5 = (int)Class_200.LengthCode[num4];
						this.send_code(num5 + Class_207.LITERALS + 1, ltree);
						int num6 = Class_200.ExtraLengthBits[num5];
						if (num6 != 0)
						{
							num4 -= Class_200.LengthBase[num5];
							this.send_bits(num4, num6);
						}
						num3--;
						num5 = Class_200.DistanceCode(num3);
						this.send_code(num5, dtree);
						num6 = Class_200.ExtraDistanceBits[num5];
						if (num6 != 0)
						{
							num3 -= Class_200.DistanceBase[num5];
							this.send_bits(num3, num6);
						}
					}
				}
				while (num < this.last_lit);
			}
			this.send_code(Class_190.END_BLOCK, ltree);
			this.last_eob_len = (int)ltree[Class_190.END_BLOCK * 2 + 1];
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0002C644 File Offset: 0x0002A844
		internal void set_data_type()
		{
			int i = 0;
			int num = 0;
			int num2 = 0;
			while (i < 7)
			{
				num2 += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < 128)
			{
				num += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < Class_207.LITERALS)
			{
				num2 += (int)this.dyn_ltree[i * 2];
				i++;
			}
			this.data_type = (sbyte)((num2 > num >> 2) ? Class_190.Z_BINARY : Class_190.Z_ASCII);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0002C6CC File Offset: 0x0002A8CC
		internal void bi_flush()
		{
			if (this.bi_valid == 16)
			{
				this.pending[this.pendingCount++] = (byte)this.bi_buf;
				this.pending[this.pendingCount++] = (byte)(this.bi_buf >> 8);
				this.bi_buf = 0;
				this.bi_valid = 0;
				return;
			}
			if (this.bi_valid >= 8)
			{
				this.pending[this.pendingCount++] = (byte)this.bi_buf;
				this.bi_buf = (short)(this.bi_buf >> 8);
				this.bi_valid -= 8;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0002C780 File Offset: 0x0002A980
		internal void bi_windup()
		{
			if (this.bi_valid > 8)
			{
				this.pending[this.pendingCount++] = (byte)this.bi_buf;
				this.pending[this.pendingCount++] = (byte)(this.bi_buf >> 8);
			}
			else if (this.bi_valid > 0)
			{
				this.pending[this.pendingCount++] = (byte)this.bi_buf;
			}
			this.bi_buf = 0;
			this.bi_valid = 0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0002C818 File Offset: 0x0002AA18
		internal void copy_block(int buf, int len, bool header)
		{
			this.bi_windup();
			this.last_eob_len = 8;
			if (header)
			{
				this.pending[this.pendingCount++] = (byte)len;
				this.pending[this.pendingCount++] = (byte)(len >> 8);
				this.pending[this.pendingCount++] = (byte)(~(byte)len);
				this.pending[this.pendingCount++] = (byte)(~len >> 8);
			}
			this.put_bytes(this.window, buf, len);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
		internal void flush_block_only(bool eof)
		{
			this._tr_flush_block((this.block_start >= 0) ? this.block_start : -1, this.strstart - this.block_start, eof);
			this.block_start = this.strstart;
			this._codec.flush_pending();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0002C904 File Offset: 0x0002AB04
		internal Class_188 DeflateNone(Class_201 flush)
		{
			int num = 65535;
			if (num > this.pending.Length - 5)
			{
				num = this.pending.Length - 5;
			}
			for (;;)
			{
				if (this.lookahead <= 1)
				{
					this._fillWindow();
					if (this.lookahead == 0 && flush == Class_201.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_F0;
					}
				}
				this.strstart += this.lookahead;
				this.lookahead = 0;
				int num2 = this.block_start + num;
				if (this.strstart == 0 || this.strstart >= num2)
				{
					this.lookahead = this.strstart - num2;
					this.strstart = num2;
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return Class_188.NeedMore;
					}
				}
				if (this.strstart - this.block_start >= this.w_size - Class_190.MIN_LOOKAHEAD)
				{
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return Class_188.NeedMore;
					}
				}
			}
			return Class_188.NeedMore;
			IL_F0:
			this.flush_block_only(flush == Class_201.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush != Class_201.Finish)
				{
					return Class_188.NeedMore;
				}
				return Class_188.FinishStarted;
			}
			else
			{
				if (flush != Class_201.Finish)
				{
					return Class_188.BlockDone;
				}
				return Class_188.FinishDone;
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0002CA30 File Offset: 0x0002AC30
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			this.send_bits((Class_190.STORED_BLOCK << 1) + (eof ? 1 : 0), 3);
			this.copy_block(buf, stored_len, true);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0002CA58 File Offset: 0x0002AC58
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
			int num = 0;
			int num2;
			int num3;
			if (this.compressionLevel > Class_202.None)
			{
				if ((int)this.data_type == Class_190.Z_UNKNOWN)
				{
					this.set_data_type();
				}
				this.treeLiterals.build_tree(this);
				this.treeDistances.build_tree(this);
				num = this.build_bl_tree();
				num2 = this.opt_len + 3 + 7 >> 3;
				num3 = this.static_len + 3 + 7 >> 3;
				if (num3 <= num2)
				{
					num2 = num3;
				}
			}
			else
			{
				num3 = (num2 = stored_len + 5);
			}
			if (stored_len + 4 <= num2 && buf != -1)
			{
				this._tr_stored_block(buf, stored_len, eof);
			}
			else if (num3 == num2)
			{
				this.send_bits((Class_190.STATIC_TREES << 1) + (eof ? 1 : 0), 3);
				this.send_compressed_block(Class_208.lengthAndLiteralsTreeCodes, Class_208.distTreeCodes);
			}
			else
			{
				this.send_bits((Class_190.DYN_TREES << 1) + (eof ? 1 : 0), 3);
				this.send_all_trees(this.treeLiterals.max_code + 1, this.treeDistances.max_code + 1, num + 1);
				this.send_compressed_block(this.dyn_ltree, this.dyn_dtree);
			}
			this._InitializeBlocks();
			if (eof)
			{
				this.bi_windup();
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002CB90 File Offset: 0x0002AD90
		private void _fillWindow()
		{
			for (;;)
			{
				int num = this.window_size - this.lookahead - this.strstart;
				int num2;
				if (num == 0 && this.strstart == 0 && this.lookahead == 0)
				{
					num = this.w_size;
				}
				else if (num == -1)
				{
					num--;
				}
				else if (this.strstart >= this.w_size + this.w_size - Class_190.MIN_LOOKAHEAD)
				{
					Array.Copy(this.window, this.w_size, this.window, 0, this.w_size);
					this.match_start -= this.w_size;
					this.strstart -= this.w_size;
					this.block_start -= this.w_size;
					num2 = this.hash_size;
					int num3 = num2;
					do
					{
						int num4 = (int)this.head[--num3] & 65535;
						this.head[num3] = (short)((num4 >= this.w_size) ? (num4 - this.w_size) : 0);
					}
					while (--num2 != 0);
					num2 = this.w_size;
					num3 = num2;
					do
					{
						int num4 = (int)this.prev[--num3] & 65535;
						this.prev[num3] = (short)((num4 >= this.w_size) ? (num4 - this.w_size) : 0);
					}
					while (--num2 != 0);
					num += this.w_size;
				}
				if (this._codec.AvailableBytesIn == 0)
				{
					break;
				}
				num2 = this._codec.read_buf(this.window, this.strstart + this.lookahead, num);
				this.lookahead += num2;
				if (this.lookahead >= Class_190.MIN_MATCH)
				{
					this.ins_h = (int)(this.window[this.strstart] & byte.MaxValue);
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 1] & byte.MaxValue)) & this.hash_mask);
				}
				if (this.lookahead >= Class_190.MIN_LOOKAHEAD || this._codec.AvailableBytesIn == 0)
				{
					return;
				}
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
		internal Class_188 DeflateFast(Class_201 flush)
		{
			int num = 0;
			for (;;)
			{
				if (this.lookahead < Class_190.MIN_LOOKAHEAD)
				{
					this._fillWindow();
					if (this.lookahead < Class_190.MIN_LOOKAHEAD && flush == Class_201.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_2FF;
					}
				}
				if (this.lookahead >= Class_190.MIN_MATCH)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (Class_190.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
					num = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				if ((long)num != 0L && (this.strstart - num & 65535) <= this.w_size - Class_190.MIN_LOOKAHEAD && this.compressionStrategy != Class_203.HuffmanOnly)
				{
					this.match_length = this.longest_match(num);
				}
				bool flag;
				if (this.match_length >= Class_190.MIN_MATCH)
				{
					flag = this._tr_tally(this.strstart - this.match_start, this.match_length - Class_190.MIN_MATCH);
					this.lookahead -= this.match_length;
					if (this.match_length <= this.config.MaxLazy && this.lookahead >= Class_190.MIN_MATCH)
					{
						this.match_length--;
						do
						{
							this.strstart++;
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (Class_190.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
							num = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
						}
						while (--this.match_length != 0);
						this.strstart++;
					}
					else
					{
						this.strstart += this.match_length;
						this.match_length = 0;
						this.ins_h = (int)(this.window[this.strstart] & byte.MaxValue);
						this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 1] & byte.MaxValue)) & this.hash_mask);
					}
				}
				else
				{
					flag = this._tr_tally(0, (int)(this.window[this.strstart] & byte.MaxValue));
					this.lookahead--;
					this.strstart++;
				}
				if (flag)
				{
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return Class_188.NeedMore;
					}
				}
			}
			return Class_188.NeedMore;
			IL_2FF:
			this.flush_block_only(flush == Class_201.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush == Class_201.Finish)
				{
					return Class_188.FinishStarted;
				}
				return Class_188.NeedMore;
			}
			else
			{
				if (flush != Class_201.Finish)
				{
					return Class_188.BlockDone;
				}
				return Class_188.FinishDone;
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		internal Class_188 DeflateSlow(Class_201 flush)
		{
			int num = 0;
			for (;;)
			{
				if (this.lookahead < Class_190.MIN_LOOKAHEAD)
				{
					this._fillWindow();
					if (this.lookahead < Class_190.MIN_LOOKAHEAD && flush == Class_201.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_389;
					}
				}
				if (this.lookahead >= Class_190.MIN_MATCH)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (Class_190.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
					num = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				this.prev_length = this.match_length;
				this.prev_match = this.match_start;
				this.match_length = Class_190.MIN_MATCH - 1;
				if (num != 0 && this.prev_length < this.config.MaxLazy && (this.strstart - num & 65535) <= this.w_size - Class_190.MIN_LOOKAHEAD)
				{
					if (this.compressionStrategy != Class_203.HuffmanOnly)
					{
						this.match_length = this.longest_match(num);
					}
					if (this.match_length <= 5 && (this.compressionStrategy == Class_203.Filtered || (this.match_length == Class_190.MIN_MATCH && this.strstart - this.match_start > 4096)))
					{
						this.match_length = Class_190.MIN_MATCH - 1;
					}
				}
				if (this.prev_length >= Class_190.MIN_MATCH && this.match_length <= this.prev_length)
				{
					int num2 = this.strstart + this.lookahead - Class_190.MIN_MATCH;
					bool flag = this._tr_tally(this.strstart - 1 - this.prev_match, this.prev_length - Class_190.MIN_MATCH);
					this.lookahead -= this.prev_length - 1;
					this.prev_length -= 2;
					do
					{
						if (++this.strstart <= num2)
						{
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (Class_190.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
							num = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
						}
					}
					while (--this.prev_length != 0);
					this.match_available = 0;
					this.match_length = Class_190.MIN_MATCH - 1;
					this.strstart++;
					if (flag)
					{
						this.flush_block_only(false);
						if (this._codec.AvailableBytesOut == 0)
						{
							return Class_188.NeedMore;
						}
					}
				}
				else if (this.match_available != 0)
				{
					bool flag = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
					if (flag)
					{
						this.flush_block_only(false);
					}
					this.strstart++;
					this.lookahead--;
					if (this._codec.AvailableBytesOut == 0)
					{
						return Class_188.NeedMore;
					}
				}
				else
				{
					this.match_available = 1;
					this.strstart++;
					this.lookahead--;
				}
			}
			return Class_188.NeedMore;
			IL_389:
			if (this.match_available != 0)
			{
				bool flag = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
				this.match_available = 0;
			}
			this.flush_block_only(flush == Class_201.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush == Class_201.Finish)
				{
					return Class_188.FinishStarted;
				}
				return Class_188.NeedMore;
			}
			else
			{
				if (flush != Class_201.Finish)
				{
					return Class_188.BlockDone;
				}
				return Class_188.FinishDone;
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002D4E0 File Offset: 0x0002B6E0
		internal int longest_match(int cur_match)
		{
			int num = this.config.MaxChainLength;
			int num2 = this.strstart;
			int num3 = this.prev_length;
			int num4 = (this.strstart > this.w_size - Class_190.MIN_LOOKAHEAD) ? (this.strstart - (this.w_size - Class_190.MIN_LOOKAHEAD)) : 0;
			int niceLength = this.config.NiceLength;
			int num5 = this.w_mask;
			int num6 = this.strstart + Class_190.MAX_MATCH;
			byte b = this.window[num2 + num3 - 1];
			byte b2 = this.window[num2 + num3];
			if (this.prev_length >= this.config.GoodLength)
			{
				num >>= 2;
			}
			if (niceLength > this.lookahead)
			{
				niceLength = this.lookahead;
			}
			do
			{
				int num7 = cur_match;
				if (this.window[num7 + num3] == b2 && this.window[num7 + num3 - 1] == b && this.window[num7] == this.window[num2] && this.window[++num7] == this.window[num2 + 1])
				{
					num2 += 2;
					num7++;
					while (this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && num2 < num6)
					{
					}
					int num8 = Class_190.MAX_MATCH - (num6 - num2);
					num2 = num6 - Class_190.MAX_MATCH;
					if (num8 > num3)
					{
						this.match_start = cur_match;
						num3 = num8;
						if (num8 >= niceLength)
						{
							break;
						}
						b = this.window[num2 + num3 - 1];
						b2 = this.window[num2 + num3];
					}
				}
			}
			while ((cur_match = ((int)this.prev[cur_match & num5] & 65535)) > num4 && --num != 0);
			if (num3 <= this.lookahead)
			{
				return num3;
			}
			return this.lookahead;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0002D78C File Offset: 0x0002B98C
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0002D794 File Offset: 0x0002B994
		internal bool WantRfc1950HeaderBytes
		{
			get
			{
				return this._WantRfc1950HeaderBytes;
			}
			set
			{
				this._WantRfc1950HeaderBytes = value;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0002D79D File Offset: 0x0002B99D
		internal int Initialize(Class_212 codec, Class_202 level)
		{
			return this.Initialize(codec, level, 15);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002D7A9 File Offset: 0x0002B9A9
		internal int Initialize(Class_212 codec, Class_202 level, int bits)
		{
			return this.Initialize(codec, level, bits, Class_190.MEM_LEVEL_DEFAULT, Class_203.Default);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002D7BA File Offset: 0x0002B9BA
		internal int Initialize(Class_212 codec, Class_202 level, int bits, Class_203 compressionStrategy)
		{
			return this.Initialize(codec, level, bits, Class_190.MEM_LEVEL_DEFAULT, compressionStrategy);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0002D7CC File Offset: 0x0002B9CC
		internal int Initialize(Class_212 codec, Class_202 level, int windowBits, int memLevel, Class_203 strategy)
		{
			this._codec = codec;
			this._codec.Message = null;
			if (windowBits < 9 || windowBits > 15)
			{
				throw new Class_205("windowBits must be in the range 9..15.");
			}
			if (memLevel < 1 || memLevel > Class_190.MEM_LEVEL_MAX)
			{
				throw new Class_205(string.Format("memLevel must be in the range 1.. {0}", Class_190.MEM_LEVEL_MAX));
			}
			this._codec.dstate = this;
			this.w_bits = windowBits;
			this.w_size = 1 << this.w_bits;
			this.w_mask = this.w_size - 1;
			this.hash_bits = memLevel + 7;
			this.hash_size = 1 << this.hash_bits;
			this.hash_mask = this.hash_size - 1;
			this.hash_shift = (this.hash_bits + Class_190.MIN_MATCH - 1) / Class_190.MIN_MATCH;
			this.window = new byte[this.w_size * 2];
			this.prev = new short[this.w_size];
			this.head = new short[this.hash_size];
			this.lit_bufsize = 1 << memLevel + 6;
			this.pending = new byte[this.lit_bufsize * 4];
			this._distanceOffset = this.lit_bufsize;
			this._lengthOffset = 3 * this.lit_bufsize;
			this.compressionLevel = level;
			this.compressionStrategy = strategy;
			this.Reset();
			return 0;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0002D934 File Offset: 0x0002BB34
		internal void Reset()
		{
			this._codec.TotalBytesIn = (this._codec.TotalBytesOut = 0L);
			this._codec.Message = null;
			this.pendingCount = 0;
			this.nextPending = 0;
			this.Rfc1950BytesEmitted = false;
			this.status = (this.WantRfc1950HeaderBytes ? Class_190.INIT_STATE : Class_190.BUSY_STATE);
			this._codec._Adler32 = Class_209.Adler32(0U, null, 0, 0);
			this.last_flush = 0;
			this._InitializeTreeData();
			this._InitializeLazyMatch();
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0002D9C4 File Offset: 0x0002BBC4
		internal int End()
		{
			if (this.status != Class_190.INIT_STATE && this.status != Class_190.BUSY_STATE && this.status != Class_190.FINISH_STATE)
			{
				return -2;
			}
			this.pending = null;
			this.head = null;
			this.prev = null;
			this.window = null;
			if (this.status != Class_190.BUSY_STATE)
			{
				return 0;
			}
			return -3;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0002DA34 File Offset: 0x0002BC34
		private void SetDeflater()
		{
			switch (this.config.Flavor)
			{
			case Class_189.Store:
				this.DeflateFunction = new Class_190.CompressFunc(this.DeflateNone);
				return;
			case Class_189.Fast:
				this.DeflateFunction = new Class_190.CompressFunc(this.DeflateFast);
				return;
			case Class_189.Slow:
				this.DeflateFunction = new Class_190.CompressFunc(this.DeflateSlow);
				return;
			default:
				return;
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0002DA98 File Offset: 0x0002BC98
		internal int SetParams(Class_202 level, Class_203 strategy)
		{
			int result = 0;
			if (this.compressionLevel != level)
			{
				Class_190.Config config = Class_190.Config.Lookup(level);
				if (config.Flavor != this.config.Flavor && this._codec.TotalBytesIn != 0L)
				{
					result = this._codec.Deflate(Class_201.Partial);
				}
				this.compressionLevel = level;
				this.config = config;
				this.SetDeflater();
			}
			this.compressionStrategy = strategy;
			return result;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		internal int SetDictionary(byte[] dictionary)
		{
			int num = dictionary.Length;
			int sourceIndex = 0;
			if (dictionary == null || this.status != Class_190.INIT_STATE)
			{
				throw new Class_205("Stream error.");
			}
			this._codec._Adler32 = Class_209.Adler32(this._codec._Adler32, dictionary, 0, dictionary.Length);
			if (num < Class_190.MIN_MATCH)
			{
				return 0;
			}
			if (num > this.w_size - Class_190.MIN_LOOKAHEAD)
			{
				num = this.w_size - Class_190.MIN_LOOKAHEAD;
				sourceIndex = dictionary.Length - num;
			}
			Array.Copy(dictionary, sourceIndex, this.window, 0, num);
			this.strstart = num;
			this.block_start = num;
			this.ins_h = (int)(this.window[0] & byte.MaxValue);
			this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[1] & byte.MaxValue)) & this.hash_mask);
			for (int i = 0; i <= num - Class_190.MIN_MATCH; i++)
			{
				this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[i + (Class_190.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
				this.prev[i & this.w_mask] = this.head[this.ins_h];
				this.head[this.ins_h] = (short)i;
			}
			return 0;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0002DC64 File Offset: 0x0002BE64
		internal int Deflate(Class_201 flush)
		{
			if (this._codec.OutputBuffer == null || (this._codec.InputBuffer == null && this._codec.AvailableBytesIn != 0) || (this.status == Class_190.FINISH_STATE && flush != Class_201.Finish))
			{
				this._codec.Message = Class_190._ErrorMessage[4];
				throw new Class_205(string.Format("Something is fishy. [{0}]", this._codec.Message));
			}
			if (this._codec.AvailableBytesOut == 0)
			{
				this._codec.Message = Class_190._ErrorMessage[7];
				throw new Class_205("OutputBuffer is full (AvailableBytesOut == 0)");
			}
			int num = this.last_flush;
			this.last_flush = (int)flush;
			if (this.status == Class_190.INIT_STATE)
			{
				int num2 = Class_190.Z_DEFLATED + (this.w_bits - 8 << 4) << 8;
				int num3 = (this.compressionLevel - Class_202.BestSpeed & 255) >> 1;
				if (num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if (this.strstart != 0)
				{
					num2 |= Class_190.PRESET_DICT;
				}
				num2 += 31 - num2 % 31;
				this.status = Class_190.BUSY_STATE;
				this.pending[this.pendingCount++] = (byte)(num2 >> 8);
				this.pending[this.pendingCount++] = (byte)num2;
				if (this.strstart != 0)
				{
					this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 4278190080U) >> 24);
					this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 16711680U) >> 16);
					this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 65280U) >> 8);
					this.pending[this.pendingCount++] = (byte)(this._codec._Adler32 & 255U);
				}
				this._codec._Adler32 = Class_209.Adler32(0U, null, 0, 0);
			}
			if (this.pendingCount != 0)
			{
				this._codec.flush_pending();
				if (this._codec.AvailableBytesOut == 0)
				{
					this.last_flush = -1;
					return 0;
				}
			}
			else if (this._codec.AvailableBytesIn == 0 && flush <= (Class_201)num && flush != Class_201.Finish)
			{
				return 0;
			}
			if (this.status == Class_190.FINISH_STATE && this._codec.AvailableBytesIn != 0)
			{
				this._codec.Message = Class_190._ErrorMessage[7];
				throw new Class_205("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
			}
			if (this._codec.AvailableBytesIn != 0 || this.lookahead != 0 || (flush != Class_201.None && this.status != Class_190.FINISH_STATE))
			{
				Class_188 class_ = this.DeflateFunction(flush);
				if (class_ == Class_188.FinishStarted || class_ == Class_188.FinishDone)
				{
					this.status = Class_190.FINISH_STATE;
				}
				if (class_ == Class_188.NeedMore || class_ == Class_188.FinishStarted)
				{
					if (this._codec.AvailableBytesOut == 0)
					{
						this.last_flush = -1;
					}
					return 0;
				}
				if (class_ == Class_188.BlockDone)
				{
					if (flush == Class_201.Partial)
					{
						this._tr_align();
					}
					else
					{
						this._tr_stored_block(0, 0, false);
						if (flush == Class_201.Full)
						{
							for (int i = 0; i < this.hash_size; i++)
							{
								this.head[i] = 0;
							}
						}
					}
					this._codec.flush_pending();
					if (this._codec.AvailableBytesOut == 0)
					{
						this.last_flush = -1;
						return 0;
					}
				}
			}
			if (flush != Class_201.Finish)
			{
				return 0;
			}
			if (!this.WantRfc1950HeaderBytes || this.Rfc1950BytesEmitted)
			{
				return 1;
			}
			this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 4278190080U) >> 24);
			this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 16711680U) >> 16);
			this.pending[this.pendingCount++] = (byte)((this._codec._Adler32 & 65280U) >> 8);
			this.pending[this.pendingCount++] = (byte)(this._codec._Adler32 & 255U);
			this._codec.flush_pending();
			this.Rfc1950BytesEmitted = true;
			if (this.pendingCount == 0)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0400045A RID: 1114
		private static readonly int MEM_LEVEL_MAX = 9;

		// Token: 0x0400045B RID: 1115
		private static readonly int MEM_LEVEL_DEFAULT = 8;

		// Token: 0x0400045C RID: 1116
		private Class_190.CompressFunc DeflateFunction;

		// Token: 0x0400045D RID: 1117
		private static readonly string[] _ErrorMessage = new string[]
		{
			"need dictionary",
			"stream end",
			"",
			"file error",
			"stream error",
			"data error",
			"insufficient memory",
			"buffer error",
			"incompatible version",
			""
		};

		// Token: 0x0400045E RID: 1118
		private static readonly int PRESET_DICT = 32;

		// Token: 0x0400045F RID: 1119
		private static readonly int INIT_STATE = 42;

		// Token: 0x04000460 RID: 1120
		private static readonly int BUSY_STATE = 113;

		// Token: 0x04000461 RID: 1121
		private static readonly int FINISH_STATE = 666;

		// Token: 0x04000462 RID: 1122
		private static readonly int Z_DEFLATED = 8;

		// Token: 0x04000463 RID: 1123
		private static readonly int STORED_BLOCK = 0;

		// Token: 0x04000464 RID: 1124
		private static readonly int STATIC_TREES = 1;

		// Token: 0x04000465 RID: 1125
		private static readonly int DYN_TREES = 2;

		// Token: 0x04000466 RID: 1126
		private static readonly int Z_BINARY = 0;

		// Token: 0x04000467 RID: 1127
		private static readonly int Z_ASCII = 1;

		// Token: 0x04000468 RID: 1128
		private static readonly int Z_UNKNOWN = 2;

		// Token: 0x04000469 RID: 1129
		private static readonly int Buf_size = 16;

		// Token: 0x0400046A RID: 1130
		private static readonly int MIN_MATCH = 3;

		// Token: 0x0400046B RID: 1131
		private static readonly int MAX_MATCH = 258;

		// Token: 0x0400046C RID: 1132
		private static readonly int MIN_LOOKAHEAD = Class_190.MAX_MATCH + Class_190.MIN_MATCH + 1;

		// Token: 0x0400046D RID: 1133
		private static readonly int HEAP_SIZE = 2 * Class_207.L_CODES + 1;

		// Token: 0x0400046E RID: 1134
		private static readonly int END_BLOCK = 256;

		// Token: 0x0400046F RID: 1135
		internal Class_212 _codec;

		// Token: 0x04000470 RID: 1136
		internal int status;

		// Token: 0x04000471 RID: 1137
		internal byte[] pending;

		// Token: 0x04000472 RID: 1138
		internal int nextPending;

		// Token: 0x04000473 RID: 1139
		internal int pendingCount;

		// Token: 0x04000474 RID: 1140
		internal sbyte data_type;

		// Token: 0x04000475 RID: 1141
		internal int last_flush;

		// Token: 0x04000476 RID: 1142
		internal int w_size;

		// Token: 0x04000477 RID: 1143
		internal int w_bits;

		// Token: 0x04000478 RID: 1144
		internal int w_mask;

		// Token: 0x04000479 RID: 1145
		internal byte[] window;

		// Token: 0x0400047A RID: 1146
		internal int window_size;

		// Token: 0x0400047B RID: 1147
		internal short[] prev;

		// Token: 0x0400047C RID: 1148
		internal short[] head;

		// Token: 0x0400047D RID: 1149
		internal int ins_h;

		// Token: 0x0400047E RID: 1150
		internal int hash_size;

		// Token: 0x0400047F RID: 1151
		internal int hash_bits;

		// Token: 0x04000480 RID: 1152
		internal int hash_mask;

		// Token: 0x04000481 RID: 1153
		internal int hash_shift;

		// Token: 0x04000482 RID: 1154
		internal int block_start;

		// Token: 0x04000483 RID: 1155
		private Class_190.Config config;

		// Token: 0x04000484 RID: 1156
		internal int match_length;

		// Token: 0x04000485 RID: 1157
		internal int prev_match;

		// Token: 0x04000486 RID: 1158
		internal int match_available;

		// Token: 0x04000487 RID: 1159
		internal int strstart;

		// Token: 0x04000488 RID: 1160
		internal int match_start;

		// Token: 0x04000489 RID: 1161
		internal int lookahead;

		// Token: 0x0400048A RID: 1162
		internal int prev_length;

		// Token: 0x0400048B RID: 1163
		internal Class_202 compressionLevel;

		// Token: 0x0400048C RID: 1164
		internal Class_203 compressionStrategy;

		// Token: 0x0400048D RID: 1165
		internal short[] dyn_ltree;

		// Token: 0x0400048E RID: 1166
		internal short[] dyn_dtree;

		// Token: 0x0400048F RID: 1167
		internal short[] bl_tree;

		// Token: 0x04000490 RID: 1168
		internal Class_200 treeLiterals = new Class_200();

		// Token: 0x04000491 RID: 1169
		internal Class_200 treeDistances = new Class_200();

		// Token: 0x04000492 RID: 1170
		internal Class_200 treeBitLengths = new Class_200();

		// Token: 0x04000493 RID: 1171
		internal short[] bl_count = new short[Class_207.MAX_BITS + 1];

		// Token: 0x04000494 RID: 1172
		internal int[] heap = new int[2 * Class_207.L_CODES + 1];

		// Token: 0x04000495 RID: 1173
		internal int heap_len;

		// Token: 0x04000496 RID: 1174
		internal int heap_max;

		// Token: 0x04000497 RID: 1175
		internal sbyte[] depth = new sbyte[2 * Class_207.L_CODES + 1];

		// Token: 0x04000498 RID: 1176
		internal int _lengthOffset;

		// Token: 0x04000499 RID: 1177
		internal int lit_bufsize;

		// Token: 0x0400049A RID: 1178
		internal int last_lit;

		// Token: 0x0400049B RID: 1179
		internal int _distanceOffset;

		// Token: 0x0400049C RID: 1180
		internal int opt_len;

		// Token: 0x0400049D RID: 1181
		internal int static_len;

		// Token: 0x0400049E RID: 1182
		internal int matches;

		// Token: 0x0400049F RID: 1183
		internal int last_eob_len;

		// Token: 0x040004A0 RID: 1184
		internal short bi_buf;

		// Token: 0x040004A1 RID: 1185
		internal int bi_valid;

		// Token: 0x040004A2 RID: 1186
		private bool Rfc1950BytesEmitted;

		// Token: 0x040004A3 RID: 1187
		private bool _WantRfc1950HeaderBytes = true;

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x060006F0 RID: 1776
		internal delegate Class_188 CompressFunc(Class_201 flush);

		// Token: 0x020000F6 RID: 246
		internal class Config
		{
			// Token: 0x060006F3 RID: 1779 RVA: 0x0002E24B File Offset: 0x0002C44B
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, Class_189 flavor)
			{
				this.GoodLength = goodLength;
				this.MaxLazy = maxLazy;
				this.NiceLength = niceLength;
				this.MaxChainLength = maxChainLength;
				this.Flavor = flavor;
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x0002E278 File Offset: 0x0002C478
			public static Class_190.Config Lookup(Class_202 level)
			{
				return Class_190.Config.Table[(int)level];
			}

			// Token: 0x040004A4 RID: 1188
			internal int GoodLength;

			// Token: 0x040004A5 RID: 1189
			internal int MaxLazy;

			// Token: 0x040004A6 RID: 1190
			internal int NiceLength;

			// Token: 0x040004A7 RID: 1191
			internal int MaxChainLength;

			// Token: 0x040004A8 RID: 1192
			internal Class_189 Flavor;

			// Token: 0x040004A9 RID: 1193
			private static readonly Class_190.Config[] Table = new Class_190.Config[]
			{
				new Class_190.Config(0, 0, 0, 0, Class_189.Store),
				new Class_190.Config(4, 4, 8, 4, Class_189.Fast),
				new Class_190.Config(4, 5, 16, 8, Class_189.Fast),
				new Class_190.Config(4, 6, 32, 32, Class_189.Fast),
				new Class_190.Config(4, 4, 16, 16, Class_189.Slow),
				new Class_190.Config(8, 16, 32, 32, Class_189.Slow),
				new Class_190.Config(8, 16, 128, 128, Class_189.Slow),
				new Class_190.Config(8, 32, 128, 256, Class_189.Slow),
				new Class_190.Config(32, 128, 258, 1024, Class_189.Slow),
				new Class_190.Config(32, 258, 258, 4096, Class_189.Slow)
			};
		}
	}
}
