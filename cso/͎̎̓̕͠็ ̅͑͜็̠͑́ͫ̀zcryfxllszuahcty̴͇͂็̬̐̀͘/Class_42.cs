using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000038 RID: 56
	internal class Class_42
	{
		// Token: 0x060000DB RID: 219 RVA: 0x0000737C File Offset: 0x0000557C
		public Class_42(string str_0)
		{
			this.field_1 = File.ReadAllBytes(str_0);
			this.field_2 = this.gmethod_123(16, 2);
			this.field_0 = this.gmethod_123(56, 4);
			this.xmethod_121(100L);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000073E6 File Offset: 0x000055E6
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000073FA File Offset: 0x000055FA
		public string[] prop_0 { get; set; }

		// Token: 0x060000DE RID: 222 RVA: 0x00007410 File Offset: 0x00005610
		public string kmethod_117(int sayıInt_0, string str_0)
		{
			int num = -1;
			int num2 = this.prop_0.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (string.Compare(this.prop_0[i].ToLower().Trim(), str_0.ToLower().Trim(), StringComparison.Ordinal) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return null;
			}
			return this.lmethod_118(sayıInt_0, num);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000748C File Offset: 0x0000568C
		public string lmethod_118(int sayıInt_0, int sayıInt_1)
		{
			string result;
			try
			{
				if (sayıInt_0 >= this.field_6.Length)
				{
					result = null;
				}
				else
				{
					result = ((sayıInt_1 >= this.field_6[sayıInt_0].field_4.Length) ? null : this.field_6[sayıInt_0].field_4[sayıInt_1]);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00007510 File Offset: 0x00005710
		public int pmethod_119()
		{
			return this.field_6.Length;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00007528 File Offset: 0x00005728
		private bool smethod_120(ulong arg_0)
		{
			bool result;
			try
			{
				if (this.field_1[(int)(checked((IntPtr)arg_0))] == 13)
				{
					uint num = (uint)(this.gmethod_123((int)arg_0 + 3, 2) - 1UL);
					int num2 = 0;
					if (this.field_6 != null)
					{
						num2 = this.field_6.Length;
						Array.Resize<Class_42.NClass_1>(ref this.field_6, this.field_6.Length + (int)num + 1);
					}
					else
					{
						this.field_6 = new Class_42.NClass_1[num + 1U];
					}
					for (uint num3 = 0U; num3 <= num; num3 += 1U)
					{
						ulong num4 = this.gmethod_123((int)arg_0 + 8 + (int)(num3 * 2U), 2);
						if (arg_0 != 100UL)
						{
							num4 += arg_0;
						}
						int num5 = this.cmethod_124((int)num4);
						this.vmethod_125((int)num4, num5);
						int num6 = this.cmethod_124((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
						this.vmethod_125((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
						ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
						int num8 = this.cmethod_124((int)num7);
						int num9 = num8;
						long num10 = this.vmethod_125((int)num7, num8);
						Class_42.NClass_0[] array = null;
						long num11 = (long)(num7 - (ulong)((long)num8) + 1UL);
						int num12 = 0;
						while (num11 < num10)
						{
							Array.Resize<Class_42.NClass_0>(ref array, num12 + 1);
							int num13 = num9 + 1;
							num9 = this.cmethod_124(num13);
							array[num12].field_3 = this.vmethod_125(num13, num9);
							array[num12].field_2 = (long)((array[num12].field_3 <= 9L) ? ((ulong)this.field_3[(int)(checked((IntPtr)array[num12].field_3))]) : ((ulong)((!Class_42.dmethod_126(array[num12].field_3)) ? ((array[num12].field_3 - 12L) / 2L) : ((array[num12].field_3 - 13L) / 2L))));
							num11 = num11 + (long)(num9 - num13) + 1L;
							num12++;
						}
						if (array != null)
						{
							this.field_6[num2 + (int)num3].field_4 = new string[array.Length];
							int num14 = 0;
							for (int i = 0; i <= array.Length - 1; i++)
							{
								if (array[i].field_3 > 9L)
								{
									if (!Class_42.dmethod_126(array[i].field_3))
									{
										if (this.field_0 == 1UL)
										{
											this.field_6[num2 + (int)num3].field_4[i] = Encoding.Default.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].field_2);
										}
										else if (this.field_0 == 2UL)
										{
											this.field_6[num2 + (int)num3].field_4[i] = Encoding.Unicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].field_2);
										}
										else if (this.field_0 == 3UL)
										{
											this.field_6[num2 + (int)num3].field_4[i] = Encoding.BigEndianUnicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].field_2);
										}
									}
									else
									{
										this.field_6[num2 + (int)num3].field_4[i] = Encoding.Default.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].field_2);
									}
								}
								else
								{
									this.field_6[num2 + (int)num3].field_4[i] = Convert.ToString(this.gmethod_123((int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].field_2));
								}
								num14 += (int)array[i].field_2;
							}
						}
					}
				}
				else if (this.field_1[(int)(checked((IntPtr)arg_0))] == 5)
				{
					uint num15 = (uint)(this.gmethod_123((int)(arg_0 + 3UL), 2) - 1UL);
					for (uint num16 = 0U; num16 <= num15; num16 += 1U)
					{
						uint num17 = (uint)this.gmethod_123((int)arg_0 + 12 + (int)(num16 * 2U), 2);
						this.smethod_120((this.gmethod_123((int)(arg_0 + (ulong)num17), 4) - 1UL) * this.field_2);
					}
					this.smethod_120((this.gmethod_123((int)(arg_0 + 8UL), 4) - 1UL) * this.field_2);
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000079E4 File Offset: 0x00005BE4
		private void xmethod_121(long sayıUınt_0)
		{
			try
			{
				byte b = this.field_1[(int)(checked((IntPtr)sayıUınt_0))];
				if (b != 5)
				{
					if (b == 13)
					{
						ulong num = this.gmethod_123((int)sayıUınt_0 + 3, 2) - 1UL;
						int num2 = 0;
						if (this.field_5 != null)
						{
							num2 = this.field_5.Length;
							Array.Resize<Class_42.NClass_2>(ref this.field_5, this.field_5.Length + (int)num + 1);
						}
						else
						{
							this.field_5 = new Class_42.NClass_2[num + 1UL];
						}
						for (ulong num3 = 0UL; num3 <= num; num3 += 1UL)
						{
							ulong num4 = this.gmethod_123((int)sayıUınt_0 + 8 + (int)num3 * 2, 2);
							if (sayıUınt_0 != 100L)
							{
								num4 += (ulong)sayıUınt_0;
							}
							int num5 = this.cmethod_124((int)num4);
							this.vmethod_125((int)num4, num5);
							int num6 = this.cmethod_124((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
							this.vmethod_125((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
							ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
							int num8 = this.cmethod_124((int)num7);
							int num9 = num8;
							long num10 = this.vmethod_125((int)num7, num8);
							long[] array = new long[5];
							for (int i = 0; i <= 4; i++)
							{
								int sayıInt_ = num9 + 1;
								num9 = this.cmethod_124(sayıInt_);
								array[i] = this.vmethod_125(sayıInt_, num9);
								array[i] = (long)((array[i] <= 9L) ? ((ulong)this.field_3[(int)(checked((IntPtr)array[i]))]) : ((ulong)((!Class_42.dmethod_126(array[i])) ? ((array[i] - 12L) / 2L) : ((array[i] - 13L) / 2L))));
							}
							if (this.field_0 == 1UL || this.field_0 == 2UL)
							{
								if (this.field_0 == 1UL)
								{
									this.field_5[num2 + (int)num3].field_5 = Encoding.Default.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
								else if (this.field_0 == 2UL)
								{
									this.field_5[num2 + (int)num3].field_5 = Encoding.Unicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
								else if (this.field_0 == 3UL)
								{
									this.field_5[num2 + (int)num3].field_5 = Encoding.BigEndianUnicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
								}
							}
							this.field_5[num2 + (int)num3].field_6 = (long)this.gmethod_123((int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2]), (int)array[3]);
							if (this.field_0 == 1UL)
							{
								this.field_5[num2 + (int)num3].field_7 = Encoding.Default.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.field_0 == 2UL)
							{
								this.field_5[num2 + (int)num3].field_7 = Encoding.Unicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.field_0 == 3UL)
							{
								this.field_5[num2 + (int)num3].field_7 = Encoding.BigEndianUnicode.GetString(this.field_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
						}
					}
				}
				else
				{
					uint num11 = (uint)(this.gmethod_123((int)sayıUınt_0 + 3, 2) - 1UL);
					for (int j = 0; j <= (int)num11; j++)
					{
						uint num12 = (uint)this.gmethod_123((int)sayıUınt_0 + 12 + j * 2, 2);
						if (sayıUınt_0 == 100L)
						{
							this.xmethod_121((long)((this.gmethod_123((int)num12, 4) - 1UL) * this.field_2));
						}
						else
						{
							this.xmethod_121((long)((this.gmethod_123((int)(sayıUınt_0 + (long)((ulong)num12)), 4) - 1UL) * this.field_2));
						}
					}
					this.xmethod_121((long)((this.gmethod_123((int)sayıUınt_0 + 8, 4) - 1UL) * this.field_2));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007E84 File Offset: 0x00006084
		public void tmethod_122(string str_0)
		{
			try
			{
				int num = -1;
				for (int i = 0; i <= this.field_5.Length; i++)
				{
					if (string.Compare(this.field_5[i].field_5.ToLower(), str_0.ToLower(), StringComparison.Ordinal) == 0)
					{
						num = i;
						break;
					}
				}
				if (num != -1)
				{
					string[] array = this.field_5[num].field_7.Substring(this.field_5[num].field_7.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[]
					{
						','
					});
					for (int j = 0; j <= array.Length - 1; j++)
					{
						array[j] = array[j].TrimStart(Array.Empty<char>());
						int num2 = array[j].IndexOf(' ');
						if (num2 > 0)
						{
							array[j] = array[j].Substring(0, num2);
						}
						if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
						{
							Array.Resize<string>(ref this.field_4, j + 1);
							this.field_4[j] = array[j];
						}
					}
					this.smethod_120((ulong)((this.field_5[num].field_6 - 1L) * (long)this.field_2));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008014 File Offset: 0x00006214
		private ulong gmethod_123(int sayıInt_0, int sayıInt_1)
		{
			ulong result;
			try
			{
				if (sayıInt_1 > 8 | sayıInt_1 == 0)
				{
					result = 0UL;
				}
				else
				{
					ulong num = 0UL;
					for (int i = 0; i <= sayıInt_1 - 1; i++)
					{
						num = (num << 8 | (ulong)this.field_1[sayıInt_0 + i]);
					}
					result = num;
				}
			}
			catch
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008088 File Offset: 0x00006288
		private int cmethod_124(int sayıInt_0)
		{
			int result;
			try
			{
				if (sayıInt_0 > this.field_1.Length)
				{
					result = 0;
				}
				else
				{
					for (int i = sayıInt_0; i <= sayıInt_0 + 8; i++)
					{
						if (i > this.field_1.Length - 1)
						{
							return 0;
						}
						if ((this.field_1[i] & 128) != 128)
						{
							return i;
						}
					}
					result = sayıInt_0 + 8;
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008120 File Offset: 0x00006320
		private long vmethod_125(int sayıInt_0, int sayıInt_1)
		{
			long result;
			try
			{
				sayıInt_1++;
				byte[] array = new byte[8];
				int num = sayıInt_1 - sayıInt_0;
				bool flag = false;
				if (num == 0 | num > 9)
				{
					result = 0L;
				}
				else if (num == 1)
				{
					array[0] = (this.field_1[sayıInt_0] & 127);
					result = BitConverter.ToInt64(array, 0);
				}
				else
				{
					if (num == 9)
					{
						flag = true;
					}
					int num2 = 1;
					int num3 = 7;
					int num4 = 0;
					if (flag)
					{
						array[0] = this.field_1[sayıInt_1 - 1];
						sayıInt_1--;
						num4 = 1;
					}
					for (int i = sayıInt_1 - 1; i >= sayıInt_0; i += -1)
					{
						if (i - 1 >= sayıInt_0)
						{
							array[num4] = (byte)((this.field_1[i] >> num2 - 1 & 255 >> num2) | (int)this.field_1[i - 1] << num3);
							num2++;
							num4++;
							num3--;
						}
						else if (!flag)
						{
							array[num4] = (byte)(this.field_1[i] >> num2 - 1 & 255 >> num2);
						}
					}
					result = BitConverter.ToInt64(array, 0);
				}
			}
			catch
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000827C File Offset: 0x0000647C
		private static bool dmethod_126(long sayıUınt_0)
		{
			return (sayıUınt_0 & 1L) == 1L;
		}

		// Token: 0x0400008C RID: 140
		private readonly ulong field_0;

		// Token: 0x0400008D RID: 141
		private readonly byte[] field_1;

		// Token: 0x0400008E RID: 142
		private readonly ulong field_2;

		// Token: 0x0400008F RID: 143
		private readonly byte[] field_3 = new byte[]
		{
			0,
			1,
			2,
			3,
			4,
			6,
			8,
			8,
			0,
			0
		};

		// Token: 0x04000090 RID: 144
		private string[] field_4;

		// Token: 0x04000091 RID: 145
		private Class_42.NClass_2[] field_5;

		// Token: 0x04000092 RID: 146
		private Class_42.NClass_1[] field_6;

		// Token: 0x04000093 RID: 147
		[CompilerGenerated]
		private string[] field_7;

		// Token: 0x02000039 RID: 57
		private struct NClass_0
		{
			// Token: 0x04000094 RID: 148
			public long field_2;

			// Token: 0x04000095 RID: 149
			public long field_3;
		}

		// Token: 0x0200003A RID: 58
		private struct NClass_1
		{
			// Token: 0x04000096 RID: 150
			public string[] field_4;
		}

		// Token: 0x0200003B RID: 59
		private struct NClass_2
		{
			// Token: 0x04000097 RID: 151
			public string field_5;

			// Token: 0x04000098 RID: 152
			public long field_6;

			// Token: 0x04000099 RID: 153
			public string field_7;
		}
	}
}
