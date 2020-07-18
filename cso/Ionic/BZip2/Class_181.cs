using System;
using System.Runtime.CompilerServices;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x020000E6 RID: 230
	internal class Class_181
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x0002721A File Offset: 0x0002541A
		public Class_181(Class_180 arg_0) : this(arg_0, Class_183.MaxBlockSize)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00027228 File Offset: 0x00025428
		public Class_181(Class_180 arg_0, int sayıInt_0)
		{
			this.field_0 = sayıInt_0;
			this.field_7 = arg_0;
			this.field_4 = sayıInt_0 * Class_183.BlockSizeMultiple - 20;
			this.field_5 = new Class_181.NClass_0(sayıInt_0);
			this.tmethod_1122();
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00027280 File Offset: 0x00025480
		private void tmethod_1122()
		{
			this.field_6.lmethod_1378();
			this.field_1 = -1;
			this.field_2 = 0;
			this.field_3 = -1;
			int num = 256;
			while (--num >= 0)
			{
				this.field_5.field_4[num] = false;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000272CE File Offset: 0x000254CE
		public int prop_0
		{
			get
			{
				return this.field_0;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x000272D6 File Offset: 0x000254D6
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x000272DE File Offset: 0x000254DE
		public uint prop_1 { get; private set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000272E7 File Offset: 0x000254E7
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000272EF File Offset: 0x000254EF
		public int prop_2 { get; private set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000272F8 File Offset: 0x000254F8
		public int prop_3
		{
			get
			{
				return this.field_3 + 1;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00027304 File Offset: 0x00025504
		public int pmethod_1129(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (this.field_3 >= this.field_4)
			{
				return 0;
			}
			int num = 0;
			int num2 = sayıInt_0 + sayıInt_1;
			int num3;
			do
			{
				num3 = this.smethod_1130(byteDizi_0[sayıInt_0++]);
				if (num3 > 0)
				{
					num++;
				}
			}
			while (sayıInt_0 < num2 && num3 == 1);
			return num;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00027350 File Offset: 0x00025550
		private int smethod_1130(byte byte_0)
		{
			if (this.field_1 == -1)
			{
				this.field_1 = (int)byte_0;
				this.field_2++;
				return 1;
			}
			if (this.field_1 == (int)byte_0)
			{
				if (++this.field_2 <= 254)
				{
					return 1;
				}
				bool flag = this.xmethod_1131(false);
				this.field_1 = -1;
				this.field_2 = 0;
				if (!flag)
				{
					return 1;
				}
				return 2;
			}
			else
			{
				bool flag = this.xmethod_1131(false);
				if (flag)
				{
					this.field_1 = -1;
					this.field_2 = 0;
					return 0;
				}
				this.field_2 = 1;
				this.field_1 = (int)byte_0;
				return 1;
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000273F8 File Offset: 0x000255F8
		private bool xmethod_1131(bool bool_0)
		{
			this.field_8++;
			int num = this.field_3;
			if (num >= this.field_4 && !bool_0)
			{
				string message = string.Format("block overrun(final={2}): {0} >= threshold ({1})", num, this.field_4, bool_0);
				throw new Exception(message);
			}
			byte b = (byte)this.field_1;
			byte[] field_ = this.field_5.field_27;
			this.field_5.field_4[(int)b] = true;
			int num2 = this.field_2;
			this.field_6.xmethod_1371(b, num2);
			switch (num2)
			{
			case 1:
				field_[num + 2] = b;
				this.field_3 = num + 1;
				break;
			case 2:
				field_[num + 2] = b;
				field_[num + 3] = b;
				this.field_3 = num + 2;
				break;
			case 3:
				field_[num + 2] = b;
				field_[num + 3] = b;
				field_[num + 4] = b;
				this.field_3 = num + 3;
				break;
			default:
				num2 -= 4;
				this.field_5.field_4[num2] = true;
				field_[num + 2] = b;
				field_[num + 3] = b;
				field_[num + 4] = b;
				field_[num + 5] = b;
				field_[num + 6] = (byte)num2;
				this.field_3 = num + 5;
				break;
			}
			return this.field_3 >= this.field_4;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00027548 File Offset: 0x00025748
		public void tmethod_1132()
		{
			if (this.field_2 > 0)
			{
				this.xmethod_1131(true);
			}
			this.field_1 = -1;
			if (this.field_3 == -1)
			{
				return;
			}
			this.vmethod_1135();
			this.field_7.lmethod_1118(49);
			this.field_7.lmethod_1118(65);
			this.field_7.lmethod_1118(89);
			this.field_7.lmethod_1118(38);
			this.field_7.lmethod_1118(83);
			this.field_7.lmethod_1118(89);
			this.prop_1 = (uint)this.field_6.prop_1;
			this.field_7.pmethod_1119(this.prop_1);
			this.field_7.kmethod_1117(1, this.field_12 ? 1U : 0U);
			this.tmethod_1152();
			this.tmethod_1122();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00027620 File Offset: 0x00025820
		private void gmethod_1133()
		{
			bool[] array = this.field_5.field_4;
			byte[] field_ = this.field_5.field_27;
			int num = this.field_3;
			int num2 = 256;
			while (--num2 >= 0)
			{
				array[num2] = false;
			}
			int num3 = 0;
			int num4 = 0;
			int i = 0;
			int num5 = 1;
			while (i <= num)
			{
				if (num3 == 0)
				{
					num3 = (int)((ushort)Class_187.Rnums(num4));
					if (++num4 == 512)
					{
						num4 = 0;
					}
				}
				num3--;
				byte[] array2 = field_;
				int num6 = num5;
				array2[num6] ^= ((num3 == 1) ? 1 : 0);
				array[(int)(field_[num5] & byte.MaxValue)] = true;
				i = num5;
				num5++;
			}
			this.field_12 = true;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000276E0 File Offset: 0x000258E0
		private void cmethod_1134()
		{
			Class_181.NClass_0 nclass_ = this.field_5;
			int[] array = nclass_.field_20;
			int[] array2 = nclass_.field_21;
			bool[] array3 = nclass_.field_22;
			int[] field_ = nclass_.field_26;
			byte[] field_2 = nclass_.field_27;
			int[] field_3 = nclass_.field_28;
			char[] field_4 = nclass_.field_30;
			int num = this.field_3;
			int num2 = this.field_10;
			bool flag = this.field_11;
			int num3 = 65537;
			while (--num3 >= 0)
			{
				field_[num3] = 0;
			}
			for (int i = 0; i < Class_183.NUM_OVERSHOOT_BYTES; i++)
			{
				field_2[num + i + 2] = field_2[i % (num + 1) + 1];
			}
			int num4 = num + Class_183.NUM_OVERSHOOT_BYTES + 1;
			while (--num4 >= 0)
			{
				field_4[num4] = '\0';
			}
			field_2[0] = field_2[num + 1];
			int num5 = (int)(field_2[0] & byte.MaxValue);
			for (int j = 0; j <= num; j++)
			{
				int num6 = (int)(field_2[j + 1] & byte.MaxValue);
				field_[(num5 << 8) + num6]++;
				num5 = num6;
			}
			for (int k = 1; k <= 65536; k++)
			{
				field_[k] += field_[k - 1];
			}
			num5 = (int)(field_2[1] & byte.MaxValue);
			for (int l = 0; l < num; l++)
			{
				int num7 = (int)(field_2[l + 2] & byte.MaxValue);
				field_3[--field_[(num5 << 8) + num7]] = l;
				num5 = num7;
			}
			field_3[--field_[((int)(field_2[num + 1] & byte.MaxValue) << 8) + (int)(field_2[1] & byte.MaxValue)]] = num;
			int num8 = 256;
			while (--num8 >= 0)
			{
				array3[num8] = false;
				array[num8] = num8;
			}
			int num9 = 364;
			while (num9 != 1)
			{
				num9 /= 3;
				for (int m = num9; m <= 255; m++)
				{
					int num10 = array[m];
					int num11 = field_[num10 + 1 << 8] - field_[num10 << 8];
					int num12 = num9 - 1;
					int num13 = m;
					int num14 = array[num13 - num9];
					while (field_[num14 + 1 << 8] - field_[num14 << 8] > num11)
					{
						array[num13] = num14;
						num13 -= num9;
						if (num13 <= num12)
						{
							break;
						}
						num14 = array[num13 - num9];
					}
					array[num13] = num10;
				}
			}
			for (int n = 0; n <= 255; n++)
			{
				int num15 = array[n];
				for (int num16 = 0; num16 <= 255; num16++)
				{
					int num17 = (num15 << 8) + num16;
					int num18 = field_[num17];
					if ((num18 & Class_181.field_16) != Class_181.field_16)
					{
						int num19 = num18 & Class_181.field_17;
						int num20 = (field_[num17 + 1] & Class_181.field_17) - 1;
						if (num20 > num19)
						{
							this.pmethod_1139(nclass_, num19, num20, 2);
							if (flag && this.field_9 > num2)
							{
								return;
							}
						}
						field_[num17] = (num18 | Class_181.field_16);
					}
				}
				for (int num21 = 0; num21 <= 255; num21++)
				{
					array2[num21] = (field_[(num21 << 8) + num15] & Class_181.field_17);
				}
				int num22 = field_[num15 << 8] & Class_181.field_17;
				int num23 = field_[num15 + 1 << 8] & Class_181.field_17;
				while (num22 < num23)
				{
					int num24 = field_3[num22];
					num5 = (int)(field_2[num24] & byte.MaxValue);
					if (!array3[num5])
					{
						field_3[array2[num5]] = ((num24 == 0) ? num : (num24 - 1));
						array2[num5]++;
					}
					num22++;
				}
				int num25 = 256;
				while (--num25 >= 0)
				{
					field_[(num25 << 8) + num15] |= Class_181.field_16;
				}
				array3[num15] = true;
				if (n < 255)
				{
					int num26 = field_[num15 << 8] & Class_181.field_17;
					int num27 = (field_[num15 + 1 << 8] & Class_181.field_17) - num26;
					int num28 = 0;
					while (num27 >> num28 > 65534)
					{
						num28++;
					}
					for (int num29 = 0; num29 < num27; num29++)
					{
						int num30 = field_3[num26 + num29];
						char c = (char)(num29 >> num28);
						field_4[num30] = c;
						if (num30 < Class_183.NUM_OVERSHOOT_BYTES)
						{
							field_4[num30 + num + 1] = c;
						}
					}
				}
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00027B78 File Offset: 0x00025D78
		private void vmethod_1135()
		{
			this.field_10 = Class_181.field_22 * this.field_3;
			this.field_9 = 0;
			this.field_12 = false;
			this.field_11 = true;
			this.cmethod_1134();
			if (this.field_11 && this.field_9 > this.field_10)
			{
				this.gmethod_1133();
				this.field_10 = (this.field_9 = 0);
				this.field_11 = false;
				this.cmethod_1134();
			}
			int[] field_ = this.field_5.field_28;
			this.field_13 = -1;
			int i = 0;
			int num = this.field_3;
			while (i <= num)
			{
				if (field_[i] == 0)
				{
					this.field_13 = i;
					return;
				}
				i++;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00027C2C File Offset: 0x00025E2C
		private bool dmethod_1136(Class_181.NClass_0 arg_0, int sayıInt_0, int sayıInt_1, int sayıInt_2)
		{
			int num = sayıInt_1 - sayıInt_0 + 1;
			if (num < 2)
			{
				return this.field_11 && this.field_9 > this.field_10;
			}
			int num2 = 0;
			while (Class_181.field_23[num2] < num)
			{
				num2++;
			}
			int[] field_ = arg_0.field_28;
			char[] field_2 = arg_0.field_30;
			byte[] field_3 = arg_0.field_27;
			int num3 = this.field_3;
			int num4 = num3 + 1;
			bool flag = this.field_11;
			int num5 = this.field_10;
			int num6 = this.field_9;
			while (--num2 >= 0)
			{
				int num7 = Class_181.field_23[num2];
				int num8 = sayıInt_0 + num7 - 1;
				int i = sayıInt_0 + num7;
				while (i <= sayıInt_1)
				{
					int num9 = 3;
					while (i <= sayıInt_1 && --num9 >= 0)
					{
						int num10 = field_[i];
						int num11 = num10 + sayıInt_2;
						int num12 = i;
						bool flag2 = false;
						int num13 = 0;
						for (;;)
						{
							IL_BA:
							if (flag2)
							{
								field_[num12] = num13;
								if ((num12 -= num7) <= num8)
								{
									break;
								}
							}
							else
							{
								flag2 = true;
							}
							num13 = field_[num12 - num7];
							int num14 = num13 + sayıInt_2;
							int num15 = num11;
							if (field_3[num14 + 1] == field_3[num15 + 1])
							{
								if (field_3[num14 + 2] == field_3[num15 + 2])
								{
									if (field_3[num14 + 3] == field_3[num15 + 3])
									{
										if (field_3[num14 + 4] == field_3[num15 + 4])
										{
											if (field_3[num14 + 5] == field_3[num15 + 5])
											{
												if (field_3[num14 += 6] == field_3[num15 += 6])
												{
													int j = num3;
													while (j > 0)
													{
														j -= 4;
														if (field_3[num14 + 1] == field_3[num15 + 1])
														{
															if (field_2[num14] == field_2[num15])
															{
																if (field_3[num14 + 2] == field_3[num15 + 2])
																{
																	if (field_2[num14 + 1] == field_2[num15 + 1])
																	{
																		if (field_3[num14 + 3] == field_3[num15 + 3])
																		{
																			if (field_2[num14 + 2] == field_2[num15 + 2])
																			{
																				if (field_3[num14 + 4] == field_3[num15 + 4])
																				{
																					if (field_2[num14 + 3] == field_2[num15 + 3])
																					{
																						if ((num14 += 4) >= num4)
																						{
																							num14 -= num4;
																						}
																						if ((num15 += 4) >= num4)
																						{
																							num15 -= num4;
																						}
																						num6++;
																					}
																					else
																					{
																						if (field_2[num14 + 3] > field_2[num15 + 3])
																						{
																							goto IL_BA;
																						}
																						break;
																					}
																				}
																				else
																				{
																					if ((field_3[num14 + 4] & 255) > (field_3[num15 + 4] & 255))
																					{
																						goto IL_BA;
																					}
																					break;
																				}
																			}
																			else
																			{
																				if (field_2[num14 + 2] > field_2[num15 + 2])
																				{
																					goto IL_BA;
																				}
																				break;
																			}
																		}
																		else
																		{
																			if ((field_3[num14 + 3] & 255) > (field_3[num15 + 3] & 255))
																			{
																				goto IL_BA;
																			}
																			break;
																		}
																	}
																	else
																	{
																		if (field_2[num14 + 1] > field_2[num15 + 1])
																		{
																			goto IL_BA;
																		}
																		break;
																	}
																}
																else
																{
																	if ((field_3[num14 + 2] & 255) > (field_3[num15 + 2] & 255))
																	{
																		goto IL_BA;
																	}
																	break;
																}
															}
															else
															{
																if (field_2[num14] > field_2[num15])
																{
																	goto IL_BA;
																}
																break;
															}
														}
														else
														{
															if ((field_3[num14 + 1] & 255) > (field_3[num15 + 1] & 255))
															{
																goto IL_BA;
															}
															break;
														}
													}
													break;
												}
												if ((field_3[num14] & 255) <= (field_3[num15] & 255))
												{
													break;
												}
											}
											else if ((field_3[num14 + 5] & 255) <= (field_3[num15 + 5] & 255))
											{
												break;
											}
										}
										else if ((field_3[num14 + 4] & 255) <= (field_3[num15 + 4] & 255))
										{
											break;
										}
									}
									else if ((field_3[num14 + 3] & 255) <= (field_3[num15 + 3] & 255))
									{
										break;
									}
								}
								else if ((field_3[num14 + 2] & 255) <= (field_3[num15 + 2] & 255))
								{
									break;
								}
							}
							else if ((field_3[num14 + 1] & 255) <= (field_3[num15 + 1] & 255))
							{
								break;
							}
						}
						IL_3FA:
						field_[num12] = num10;
						i++;
						continue;
						goto IL_3FA;
					}
					if (flag && i <= sayıInt_1 && num6 > num5)
					{
						goto IL_446;
					}
				}
			}
			IL_446:
			this.field_9 = num6;
			return flag && num6 > num5;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00028098 File Offset: 0x00026298
		private static void kmethod_1137(int[] ıntSayıDizi_0, int sayıInt_0, int sayıInt_1, int sayıInt_2)
		{
			sayıInt_2 += sayıInt_0;
			while (sayıInt_0 < sayıInt_2)
			{
				int num = ıntSayıDizi_0[sayıInt_0];
				ıntSayıDizi_0[sayıInt_0++] = ıntSayıDizi_0[sayıInt_1];
				ıntSayıDizi_0[sayıInt_1++] = num;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000280CB File Offset: 0x000262CB
		private static byte lmethod_1138(byte byte_0, byte byte_1, byte byte_2)
		{
			if (byte_0 >= byte_1)
			{
				if (byte_1 > byte_2)
				{
					return byte_1;
				}
				if (byte_0 <= byte_2)
				{
					return byte_0;
				}
				return byte_2;
			}
			else
			{
				if (byte_1 < byte_2)
				{
					return byte_1;
				}
				if (byte_0 >= byte_2)
				{
					return byte_0;
				}
				return byte_2;
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000280FC File Offset: 0x000262FC
		private void pmethod_1139(Class_181.NClass_0 arg_0, int sayıInt_0, int sayıInt_1, int sayıInt_2)
		{
			int[] array = arg_0.field_17;
			int[] array2 = arg_0.field_18;
			int[] array3 = arg_0.field_19;
			int[] field_ = arg_0.field_28;
			byte[] field_2 = arg_0.field_27;
			array[0] = sayıInt_0;
			array2[0] = sayıInt_1;
			array3[0] = sayıInt_2;
			int num = 1;
			while (--num >= 0)
			{
				int num2 = array[num];
				int num3 = array2[num];
				int num4 = array3[num];
				if (num3 - num2 < Class_181.field_20 || num4 > Class_181.field_21)
				{
					if (this.dmethod_1136(arg_0, num2, num3, num4))
					{
						return;
					}
				}
				else
				{
					int num5 = num4 + 1;
					int num6 = (int)(Class_181.lmethod_1138(field_2[field_[num2] + num5], field_2[field_[num3] + num5], field_2[field_[num2 + num3 >> 1] + num5]) & byte.MaxValue);
					int i = num2;
					int num7 = num3;
					int num8 = num2;
					int num9 = num3;
					for (;;)
					{
						if (i <= num7)
						{
							int num10 = (int)(field_2[field_[i] + num5] & byte.MaxValue) - num6;
							if (num10 == 0)
							{
								int num11 = field_[i];
								field_[i++] = field_[num8];
								field_[num8++] = num11;
								continue;
							}
							if (num10 < 0)
							{
								i++;
								continue;
							}
						}
						while (i <= num7)
						{
							int num12 = (int)(field_2[field_[num7] + num5] & byte.MaxValue) - num6;
							if (num12 == 0)
							{
								int num13 = field_[num7];
								field_[num7--] = field_[num9];
								field_[num9--] = num13;
							}
							else
							{
								if (num12 <= 0)
								{
									break;
								}
								num7--;
							}
						}
						if (i > num7)
						{
							break;
						}
						int num14 = field_[i];
						field_[i++] = field_[num7];
						field_[num7--] = num14;
					}
					if (num9 < num8)
					{
						array[num] = num2;
						array2[num] = num3;
						array3[num] = num5;
						num++;
					}
					else
					{
						int num15 = (num8 - num2 < i - num8) ? (num8 - num2) : (i - num8);
						Class_181.kmethod_1137(field_, num2, i - num15, num15);
						int num16 = (num3 - num9 < num9 - num7) ? (num3 - num9) : (num9 - num7);
						Class_181.kmethod_1137(field_, i, num3 - num16 + 1, num16);
						num15 = num2 + i - num8 - 1;
						num16 = num3 - (num9 - num7) + 1;
						array[num] = num2;
						array2[num] = num15;
						array3[num] = num4;
						num++;
						array[num] = num15 + 1;
						array2[num] = num16 - 1;
						array3[num] = num5;
						num++;
						array[num] = num16;
						array2[num] = num3;
						array3[num] = num4;
						num++;
					}
				}
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002839C File Offset: 0x0002659C
		private void smethod_1140()
		{
			int num = this.field_3;
			Class_181.NClass_0 nclass_ = this.field_5;
			bool[] array = nclass_.field_4;
			byte[] field_ = nclass_.field_27;
			int[] field_2 = nclass_.field_28;
			char[] field_3 = nclass_.field_29;
			int[] array2 = nclass_.field_6;
			byte[] array3 = nclass_.field_5;
			byte[] array4 = nclass_.field_9;
			int num2 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (array[i])
				{
					array3[i] = (byte)num2;
					num2++;
				}
			}
			this.field_14 = num2;
			int num3 = num2 + 1;
			for (int j = num3; j >= 0; j--)
			{
				array2[j] = 0;
			}
			int num4 = num2;
			while (--num4 >= 0)
			{
				array4[num4] = (byte)num4;
			}
			int num5 = 0;
			int num6 = 0;
			for (int k = 0; k <= num; k++)
			{
				byte b = array3[(int)(field_[field_2[k]] & byte.MaxValue)];
				byte b2 = array4[0];
				int num7 = 0;
				while (b != b2)
				{
					num7++;
					byte b3 = b2;
					b2 = array4[num7];
					array4[num7] = b3;
				}
				array4[0] = b2;
				if (num7 == 0)
				{
					num6++;
				}
				else
				{
					if (num6 > 0)
					{
						num6--;
						for (;;)
						{
							if ((num6 & 1) == 0)
							{
								field_3[num5] = Class_183.RUNA;
								num5++;
								array2[(int)Class_183.RUNA]++;
							}
							else
							{
								field_3[num5] = Class_183.RUNB;
								num5++;
								array2[(int)Class_183.RUNB]++;
							}
							if (num6 < 2)
							{
								break;
							}
							num6 = num6 - 2 >> 1;
						}
						num6 = 0;
					}
					field_3[num5] = (char)(num7 + 1);
					num5++;
					array2[num7 + 1]++;
				}
			}
			if (num6 > 0)
			{
				num6--;
				for (;;)
				{
					if ((num6 & 1) == 0)
					{
						field_3[num5] = Class_183.RUNA;
						num5++;
						array2[(int)Class_183.RUNA]++;
					}
					else
					{
						field_3[num5] = Class_183.RUNB;
						num5++;
						array2[(int)Class_183.RUNB]++;
					}
					if (num6 < 2)
					{
						break;
					}
					num6 = num6 - 2 >> 1;
				}
			}
			field_3[num5] = (char)num3;
			array2[num3]++;
			this.field_15 = num5 + 1;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000285F8 File Offset: 0x000267F8
		private static void xmethod_1141(int[] ıntSayıDizi_0, byte[] byteDizi_0, int sayıInt_0, int sayıInt_1, int sayıInt_2)
		{
			int num = 0;
			for (int i = sayıInt_0; i <= sayıInt_1; i++)
			{
				for (int j = 0; j < sayıInt_2; j++)
				{
					if ((int)(byteDizi_0[j] & 255) == i)
					{
						ıntSayıDizi_0[j] = num;
						num++;
					}
				}
				num <<= 1;
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00028644 File Offset: 0x00026844
		private void tmethod_1142()
		{
			byte[][] array = this.field_5.field_10;
			int num = this.field_14 + 2;
			int num2 = Class_183.NGroups;
			while (--num2 >= 0)
			{
				byte[] array2 = array[num2];
				int num3 = num;
				while (--num3 >= 0)
				{
					array2[num3] = Class_181.field_18;
				}
			}
			int sayıInt_ = (this.field_15 < 200) ? 2 : ((this.field_15 < 600) ? 3 : ((this.field_15 < 1200) ? 4 : ((this.field_15 < 2400) ? 5 : 6)));
			this.gmethod_1143(sayıInt_, num);
			int num4 = this.vmethod_1145(sayıInt_, num);
			this.dmethod_1146(sayıInt_, num4);
			this.kmethod_1147(sayıInt_, num);
			this.lmethod_1148();
			this.pmethod_1149(sayıInt_, num4);
			this.smethod_1150(sayıInt_, num);
			this.xmethod_1151(num4);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00028740 File Offset: 0x00026940
		private void gmethod_1143(int sayıInt_0, int sayıInt_1)
		{
			byte[][] array = this.field_5.field_10;
			int[] array2 = this.field_5.field_6;
			int num = this.field_15;
			int num2 = 0;
			for (int i = sayıInt_0; i > 0; i--)
			{
				int num3 = num / i;
				int num4 = num2 - 1;
				int num5 = 0;
				int num6 = sayıInt_1 - 1;
				while (num5 < num3 && num4 < num6)
				{
					num5 += array2[++num4];
				}
				if (num4 > num2 && i != sayıInt_0 && i != 1 && (sayıInt_0 - i & 1) != 0)
				{
					num5 -= array2[num4--];
				}
				byte[] array3 = array[i - 1];
				int num7 = sayıInt_1;
				while (--num7 >= 0)
				{
					if (num7 >= num2 && num7 <= num4)
					{
						array3[num7] = Class_181.field_19;
					}
					else
					{
						array3[num7] = Class_181.field_18;
					}
				}
				num2 = num4 + 1;
				num -= num5;
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002883C File Offset: 0x00026A3C
		private static void cmethod_1144(byte[] byteDizi_0, int[] ıntSayıDizi_0, Class_181.NClass_0 arg_0, int sayıInt_0, int sayıInt_1)
		{
			int[] array = arg_0.field_23;
			int[] array2 = arg_0.field_24;
			int[] array3 = arg_0.field_25;
			int num = sayıInt_0;
			while (--num >= 0)
			{
				array2[num + 1] = ((ıntSayıDizi_0[num] == 0) ? 1 : ıntSayıDizi_0[num]) << 8;
			}
			bool flag = true;
			while (flag)
			{
				flag = false;
				int num2 = sayıInt_0;
				int i = 0;
				array[0] = 0;
				array2[0] = 0;
				array3[0] = -2;
				for (int j = 1; j <= sayıInt_0; j++)
				{
					array3[j] = -1;
					i++;
					array[i] = j;
					int num3 = i;
					int num4 = array[num3];
					while (array2[num4] < array2[array[num3 >> 1]])
					{
						array[num3] = array[num3 >> 1];
						num3 >>= 1;
					}
					array[num3] = num4;
				}
				while (i > 1)
				{
					int num5 = array[1];
					array[1] = array[i];
					i--;
					int num6 = 1;
					int num7 = array[1];
					for (;;)
					{
						int num8 = num6 << 1;
						if (num8 > i)
						{
							break;
						}
						if (num8 < i && array2[array[num8 + 1]] < array2[array[num8]])
						{
							num8++;
						}
						if (array2[num7] < array2[array[num8]])
						{
							break;
						}
						array[num6] = array[num8];
						num6 = num8;
					}
					array[num6] = num7;
					int num9 = array[1];
					array[1] = array[i];
					i--;
					num6 = 1;
					num7 = array[1];
					for (;;)
					{
						int num8 = num6 << 1;
						if (num8 > i)
						{
							break;
						}
						if (num8 < i && array2[array[num8 + 1]] < array2[array[num8]])
						{
							num8++;
						}
						if (array2[num7] < array2[array[num8]])
						{
							break;
						}
						array[num6] = array[num8];
						num6 = num8;
					}
					array[num6] = num7;
					num2++;
					array3[num5] = (array3[num9] = num2);
					int num10 = array2[num5];
					int num11 = array2[num9];
					array2[num2] = ((num10 & -256) + (num11 & -256) | 1 + (((num10 & 255) > (num11 & 255)) ? (num10 & 255) : (num11 & 255)));
					array3[num2] = -1;
					i++;
					array[i] = num2;
					num6 = i;
					num7 = array[num6];
					int k = array2[num7];
					while (k < array2[array[num6 >> 1]])
					{
						array[num6] = array[num6 >> 1];
						num6 >>= 1;
					}
					array[num6] = num7;
				}
				for (int l = 1; l <= sayıInt_0; l++)
				{
					int num12 = 0;
					int num13 = l;
					int num14;
					while ((num14 = array3[num13]) >= 0)
					{
						num13 = num14;
						num12++;
					}
					byteDizi_0[l - 1] = (byte)num12;
					if (num12 > sayıInt_1)
					{
						flag = true;
					}
				}
				if (flag)
				{
					for (int m = 1; m < sayıInt_0; m++)
					{
						int num15 = array2[m] >> 8;
						num15 = 1 + (num15 >> 1);
						array2[m] = num15 << 8;
					}
				}
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00028B18 File Offset: 0x00026D18
		private int vmethod_1145(int sayıInt_0, int sayıInt_1)
		{
			Class_181.NClass_0 nclass_ = this.field_5;
			int[][] array = nclass_.field_11;
			int[] array2 = nclass_.field_12;
			short[] array3 = nclass_.field_13;
			char[] field_ = nclass_.field_29;
			byte[] array4 = nclass_.field_7;
			byte[][] array5 = nclass_.field_10;
			byte[] array6 = array5[0];
			byte[] array7 = array5[1];
			byte[] array8 = array5[2];
			byte[] array9 = array5[3];
			byte[] array10 = array5[4];
			byte[] array11 = array5[5];
			int num = this.field_15;
			int num2 = 0;
			for (int i = 0; i < Class_183.N_ITERS; i++)
			{
				int num3 = sayıInt_0;
				while (--num3 >= 0)
				{
					array2[num3] = 0;
					int[] array12 = array[num3];
					int num4 = sayıInt_1;
					while (--num4 >= 0)
					{
						array12[num4] = 0;
					}
				}
				num2 = 0;
				int num5;
				for (int j = 0; j < this.field_15; j = num5 + 1)
				{
					num5 = Math.Min(j + Class_183.G_SIZE - 1, num - 1);
					if (sayıInt_0 == Class_183.NGroups)
					{
						int[] array13 = new int[6];
						for (int k = j; k <= num5; k++)
						{
							int num6 = (int)field_[k];
							array13[0] += (int)(array6[num6] & byte.MaxValue);
							array13[1] += (int)(array7[num6] & byte.MaxValue);
							array13[2] += (int)(array8[num6] & byte.MaxValue);
							array13[3] += (int)(array9[num6] & byte.MaxValue);
							array13[4] += (int)(array10[num6] & byte.MaxValue);
							array13[5] += (int)(array11[num6] & byte.MaxValue);
						}
						array3[0] = (short)array13[0];
						array3[1] = (short)array13[1];
						array3[2] = (short)array13[2];
						array3[3] = (short)array13[3];
						array3[4] = (short)array13[4];
						array3[5] = (short)array13[5];
					}
					else
					{
						int num7 = sayıInt_0;
						while (--num7 >= 0)
						{
							array3[num7] = 0;
						}
						for (int l = j; l <= num5; l++)
						{
							int num8 = (int)field_[l];
							int num9 = sayıInt_0;
							while (--num9 >= 0)
							{
								short[] array14 = array3;
								int num10 = num9;
								array14[num10] += (short)(array5[num9][num8] & byte.MaxValue);
							}
						}
					}
					int num11 = -1;
					int num12 = sayıInt_0;
					int num13 = 999999999;
					while (--num12 >= 0)
					{
						int num14 = (int)array3[num12];
						if (num14 < num13)
						{
							num13 = num14;
							num11 = num12;
						}
					}
					array2[num11]++;
					array4[num2] = (byte)num11;
					num2++;
					int[] array15 = array[num11];
					for (int m = j; m <= num5; m++)
					{
						array15[(int)field_[m]]++;
					}
				}
				for (int n = 0; n < sayıInt_0; n++)
				{
					Class_181.cmethod_1144(array5[n], array[n], this.field_5, sayıInt_1, 20);
				}
			}
			return num2;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00028E30 File Offset: 0x00027030
		private void dmethod_1146(int sayıInt_0, int sayıInt_1)
		{
			Class_181.NClass_0 nclass_ = this.field_5;
			byte[] array = nclass_.field_15;
			int num = sayıInt_0;
			while (--num >= 0)
			{
				array[num] = (byte)num;
			}
			for (int i = 0; i < sayıInt_1; i++)
			{
				byte b = nclass_.field_7[i];
				byte b2 = array[0];
				int num2 = 0;
				while (b != b2)
				{
					num2++;
					byte b3 = b2;
					b2 = array[num2];
					array[num2] = b3;
				}
				array[0] = b2;
				nclass_.field_8[i] = (byte)num2;
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00028EB4 File Offset: 0x000270B4
		private void kmethod_1147(int sayıInt_0, int sayıInt_1)
		{
			int[][] array = this.field_5.field_14;
			byte[][] array2 = this.field_5.field_10;
			for (int i = 0; i < sayıInt_0; i++)
			{
				int num = 32;
				int num2 = 0;
				byte[] array3 = array2[i];
				int num3 = sayıInt_1;
				while (--num3 >= 0)
				{
					int num4 = (int)(array3[num3] & byte.MaxValue);
					if (num4 > num2)
					{
						num2 = num4;
					}
					if (num4 < num)
					{
						num = num4;
					}
				}
				Class_181.xmethod_1141(array[i], array2[i], num, num2, sayıInt_1);
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00028F48 File Offset: 0x00027148
		private void lmethod_1148()
		{
			bool[] array = this.field_5.field_4;
			bool[] array2 = this.field_5.field_16;
			int num = 16;
			while (--num >= 0)
			{
				array2[num] = false;
				int num2 = num * 16;
				int num3 = 16;
				while (--num3 >= 0)
				{
					if (array[num2 + num3])
					{
						array2[num] = true;
					}
				}
			}
			uint num4 = 0U;
			for (int i = 0; i < 16; i++)
			{
				if (array2[i])
				{
					num4 |= 1U << 16 - i - 1;
				}
			}
			this.field_7.kmethod_1117(16, num4);
			for (int j = 0; j < 16; j++)
			{
				if (array2[j])
				{
					int num5 = j * 16;
					num4 = 0U;
					for (int k = 0; k < 16; k++)
					{
						if (array[num5 + k])
						{
							num4 |= 1U << 16 - k - 1;
						}
					}
					this.field_7.kmethod_1117(16, num4);
				}
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00029050 File Offset: 0x00027250
		private void pmethod_1149(int sayıInt_0, int sayıInt_1)
		{
			this.field_7.kmethod_1117(3, (uint)sayıInt_0);
			this.field_7.kmethod_1117(15, (uint)sayıInt_1);
			byte[] array = this.field_5.field_8;
			for (int i = 0; i < sayıInt_1; i++)
			{
				int j = 0;
				int num = (int)(array[i] & byte.MaxValue);
				while (j < num)
				{
					this.field_7.kmethod_1117(1, 1U);
					j++;
				}
				this.field_7.kmethod_1117(1, 0U);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000290C8 File Offset: 0x000272C8
		private void smethod_1150(int sayıInt_0, int sayıInt_1)
		{
			byte[][] array = this.field_5.field_10;
			for (int i = 0; i < sayıInt_0; i++)
			{
				byte[] array2 = array[i];
				uint num = (uint)(array2[0] & byte.MaxValue);
				this.field_7.kmethod_1117(5, num);
				for (int j = 0; j < sayıInt_1; j++)
				{
					int num2 = (int)(array2[j] & byte.MaxValue);
					while ((ulong)num < (ulong)((long)num2))
					{
						this.field_7.kmethod_1117(2, 2U);
						num += 1U;
					}
					while ((ulong)num > (ulong)((long)num2))
					{
						this.field_7.kmethod_1117(2, 3U);
						num -= 1U;
					}
					this.field_7.kmethod_1117(1, 0U);
				}
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00029178 File Offset: 0x00027378
		private void xmethod_1151(int sayıInt_0)
		{
			byte[][] array = this.field_5.field_10;
			int[][] array2 = this.field_5.field_14;
			byte[] array3 = this.field_5.field_7;
			char[] field_ = this.field_5.field_29;
			int num = this.field_15;
			int num2 = 0;
			int i = 0;
			while (i < num)
			{
				int num3 = Math.Min(i + Class_183.G_SIZE - 1, num - 1);
				int num4 = (int)(array3[num2] & byte.MaxValue);
				int[] array4 = array2[num4];
				byte[] array5 = array[num4];
				while (i <= num3)
				{
					int num5 = (int)field_[i];
					int sayıInt_ = (int)(array5[num5] & byte.MaxValue);
					this.field_7.kmethod_1117(sayıInt_, (uint)array4[num5]);
					i++;
				}
				i = num3 + 1;
				num2++;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00029245 File Offset: 0x00027445
		private void tmethod_1152()
		{
			this.field_7.kmethod_1117(24, (uint)this.field_13);
			this.smethod_1140();
			this.tmethod_1142();
		}

		// Token: 0x040003AA RID: 938
		private int field_0;

		// Token: 0x040003AB RID: 939
		private int field_1 = -1;

		// Token: 0x040003AC RID: 940
		private int field_2;

		// Token: 0x040003AD RID: 941
		private int field_3;

		// Token: 0x040003AE RID: 942
		private int field_4;

		// Token: 0x040003AF RID: 943
		private Class_181.NClass_0 field_5;

		// Token: 0x040003B0 RID: 944
		private readonly Class_215 field_6 = new Class_215(true);

		// Token: 0x040003B1 RID: 945
		private Class_180 field_7;

		// Token: 0x040003B2 RID: 946
		private int field_8;

		// Token: 0x040003B3 RID: 947
		private int field_9;

		// Token: 0x040003B4 RID: 948
		private int field_10;

		// Token: 0x040003B5 RID: 949
		private bool field_11;

		// Token: 0x040003B6 RID: 950
		private bool field_12;

		// Token: 0x040003B7 RID: 951
		private int field_13;

		// Token: 0x040003B8 RID: 952
		private int field_14;

		// Token: 0x040003B9 RID: 953
		private int field_15;

		// Token: 0x040003BA RID: 954
		private static readonly int field_16 = 2097152;

		// Token: 0x040003BB RID: 955
		private static readonly int field_17 = ~Class_181.field_16;

		// Token: 0x040003BC RID: 956
		private static readonly byte field_18 = 15;

		// Token: 0x040003BD RID: 957
		private static readonly byte field_19 = 0;

		// Token: 0x040003BE RID: 958
		private static readonly int field_20 = 20;

		// Token: 0x040003BF RID: 959
		private static readonly int field_21 = 10;

		// Token: 0x040003C0 RID: 960
		private static readonly int field_22 = 30;

		// Token: 0x040003C1 RID: 961
		private static readonly int[] field_23 = new int[]
		{
			1,
			4,
			13,
			40,
			121,
			364,
			1093,
			3280,
			9841,
			29524,
			88573,
			265720,
			797161,
			2391484
		};

		// Token: 0x040003C2 RID: 962
		[CompilerGenerated]
		private uint field_24;

		// Token: 0x040003C3 RID: 963
		[CompilerGenerated]
		private int field_25;

		// Token: 0x020000E7 RID: 231
		private class NClass_0
		{
			// Token: 0x06000665 RID: 1637 RVA: 0x000292C4 File Offset: 0x000274C4
			public void nmethod_0(int sayıInt_0)
			{
				this.field_4 = new bool[256];
				this.field_5 = new byte[256];
				this.field_6 = new int[Class_183.MaxAlphaSize];
				this.field_7 = new byte[Class_183.MaxSelectors];
				this.field_8 = new byte[Class_183.MaxSelectors];
				this.field_9 = new byte[256];
				this.field_12 = new int[Class_183.NGroups];
				this.field_13 = new short[Class_183.NGroups];
				this.field_15 = new byte[Class_183.NGroups];
				this.field_16 = new bool[16];
				this.field_17 = new int[Class_183.QSORT_STACK_SIZE];
				this.field_18 = new int[Class_183.QSORT_STACK_SIZE];
				this.field_19 = new int[Class_183.QSORT_STACK_SIZE];
				this.field_20 = new int[256];
				this.field_21 = new int[256];
				this.field_22 = new bool[256];
				this.field_23 = new int[Class_183.MaxAlphaSize + 2];
				this.field_24 = new int[Class_183.MaxAlphaSize * 2];
				this.field_25 = new int[Class_183.MaxAlphaSize * 2];
				this.field_26 = new int[65537];
				base..ctor();
				int num = sayıInt_0 * Class_183.BlockSizeMultiple;
				this.field_27 = new byte[num + 1 + Class_183.NUM_OVERSHOOT_BYTES];
				this.field_28 = new int[num];
				this.field_29 = new char[2 * num];
				this.field_30 = this.field_29;
				this.field_10 = Class_183.InitRectangularArray<byte>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_11 = Class_183.InitRectangularArray<int>(Class_183.NGroups, Class_183.MaxAlphaSize);
				this.field_14 = Class_183.InitRectangularArray<int>(Class_183.NGroups, Class_183.MaxAlphaSize);
			}

			// Token: 0x040003C4 RID: 964
			public readonly bool[] field_4;

			// Token: 0x040003C5 RID: 965
			public readonly byte[] field_5;

			// Token: 0x040003C6 RID: 966
			public readonly int[] field_6;

			// Token: 0x040003C7 RID: 967
			public readonly byte[] field_7;

			// Token: 0x040003C8 RID: 968
			public readonly byte[] field_8;

			// Token: 0x040003C9 RID: 969
			public readonly byte[] field_9;

			// Token: 0x040003CA RID: 970
			public byte[][] field_10;

			// Token: 0x040003CB RID: 971
			public int[][] field_11;

			// Token: 0x040003CC RID: 972
			public readonly int[] field_12;

			// Token: 0x040003CD RID: 973
			public readonly short[] field_13;

			// Token: 0x040003CE RID: 974
			public int[][] field_14;

			// Token: 0x040003CF RID: 975
			public readonly byte[] field_15;

			// Token: 0x040003D0 RID: 976
			public readonly bool[] field_16;

			// Token: 0x040003D1 RID: 977
			public readonly int[] field_17;

			// Token: 0x040003D2 RID: 978
			public readonly int[] field_18;

			// Token: 0x040003D3 RID: 979
			public readonly int[] field_19;

			// Token: 0x040003D4 RID: 980
			public readonly int[] field_20;

			// Token: 0x040003D5 RID: 981
			public readonly int[] field_21;

			// Token: 0x040003D6 RID: 982
			public readonly bool[] field_22;

			// Token: 0x040003D7 RID: 983
			public int[] field_23;

			// Token: 0x040003D8 RID: 984
			public int[] field_24;

			// Token: 0x040003D9 RID: 985
			public int[] field_25;

			// Token: 0x040003DA RID: 986
			public readonly int[] field_26;

			// Token: 0x040003DB RID: 987
			public byte[] field_27;

			// Token: 0x040003DC RID: 988
			public int[] field_28;

			// Token: 0x040003DD RID: 989
			public char[] field_29;

			// Token: 0x040003DE RID: 990
			public char[] field_30;
		}
	}
}
