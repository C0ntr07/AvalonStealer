using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200008E RID: 142
	public class Class_108
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x000145C8 File Offset: 0x000127C8
		public Class_108(string str_0)
		{
			this.field_6 = new byte[]
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
			if (File.Exists(str_0))
			{
				FileSystem.FileOpen(1, str_0, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[]
				{
					1
				});
				this.field_0 = Encoding.Default.GetBytes(s);
				this.field_3 = (ushort)this.xmethod_401(16, 2);
				this.field_1 = this.xmethod_401(56, 4);
				if (decimal.Compare(new decimal(this.prop_1), 0m) == 0)
				{
					this.field_1 = 1UL;
				}
				this.vmethod_405(100UL);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00014697 File Offset: 0x00012897
		private byte[] prop_0 { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x000146AA File Offset: 0x000128AA
		private ulong prop_1 { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000146BD File Offset: 0x000128BD
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000146D0 File Offset: 0x000128D0
		public string[] prop_2 { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000146E4 File Offset: 0x000128E4
		public int prop_3
		{
			get
			{
				return this.prop_6.Length;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x000146F9 File Offset: 0x000128F9
		private ushort prop_4 { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0001470C File Offset: 0x0001290C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0001471F File Offset: 0x0001291F
		private Class_21[] prop_5 { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00014733 File Offset: 0x00012933
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00014746 File Offset: 0x00012946
		private Class_52[] prop_6 { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001475A File Offset: 0x0001295A
		private byte[] prop_7 { get; }

		// Token: 0x060002DD RID: 733 RVA: 0x00014770 File Offset: 0x00012970
		public string[] kmethod_397()
		{
			string[] array = null;
			int num = 0;
			int num2 = this.prop_5.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this.prop_5[i].Type == "table")
				{
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[num] = this.prop_5[i].Name;
					num++;
				}
			}
			return array;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000147F8 File Offset: 0x000129F8
		public string lmethod_398(int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_0 >= this.prop_6.Length)
			{
				return null;
			}
			if (sayıInt_1 >= this.prop_6[sayıInt_0].RowData.Length)
			{
				return null;
			}
			return this.prop_6[sayıInt_0].RowData[sayıInt_1];
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00014854 File Offset: 0x00012A54
		public string pmethod_399(int sayıInt_0, string str_0)
		{
			int num = -1;
			int num2 = this.prop_2.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this.prop_2[i].ToLower().Trim().CompareTo(str_0.ToLower().Trim()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return null;
			}
			return this.lmethod_398(sayıInt_0, num);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000148CC File Offset: 0x00012ACC
		public bool smethod_400(string str_0)
		{
			int num = -1;
			int num2 = this.prop_5.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this.prop_5[i].Name.ToLower().CompareTo(str_0.ToLower()) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = this.prop_5[num].SqlStatement.Substring(this.prop_5[num].SqlStatement.IndexOf("(") + 1).Split(new char[]
			{
				','
			});
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = array[j].TrimStart(Array.Empty<char>());
				int num4 = array[j].IndexOf(" ");
				if (num4 > 0)
				{
					array[j] = array[j].Substring(0, num4);
				}
				if (array[j].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				this.prop_2 = (string[])Utils.CopyArray(this.prop_2, new string[j + 1]);
				this.prop_2[j] = array[j];
			}
			return this.dmethod_406((ulong)((this.prop_5[num].RootNum - 1L) * (long)((ulong)this.prop_4)));
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00014A54 File Offset: 0x00012C54
		private ulong xmethod_401(int sayıInt_0, int sayıInt_1)
		{
			if (sayıInt_1 > 8 || sayıInt_1 == 0)
			{
				return 0UL;
			}
			ulong num = 0UL;
			for (int i = 0; i <= sayıInt_1 - 1; i++)
			{
				num = (num << 8 | (ulong)this.prop_0[sayıInt_0 + i]);
			}
			return num;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00014AA4 File Offset: 0x00012CA4
		private long tmethod_402(int sayıInt_0, int sayıInt_1)
		{
			sayıInt_1++;
			byte[] array = new byte[8];
			int num = sayıInt_1 - sayıInt_0;
			bool flag = false;
			if (num == 0 || num > 9)
			{
				return 0L;
			}
			if (num != 1)
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
					array[0] = this.prop_0[sayıInt_1 - 1];
					sayıInt_1--;
					num4 = 1;
				}
				for (int i = sayıInt_1 - 1; i >= sayıInt_0; i += -1)
				{
					if (i - 1 >= sayıInt_0)
					{
						array[num4] = (byte)(((int)((byte)(this.prop_0[i] >> (num2 - 1 & 7))) & 255 >> num2) | (int)((byte)(this.prop_0[i - 1] << (num3 & 7))));
						num2++;
						num4++;
						num3--;
					}
					else if (!flag)
					{
						array[num4] = (byte)((int)((byte)(this.prop_0[i] >> (num2 - 1 & 7))) & 255 >> num2);
					}
				}
				return BitConverter.ToInt64(array, 0);
			}
			array[0] = (this.prop_0[sayıInt_0] & 127);
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00014BD0 File Offset: 0x00012DD0
		private int gmethod_403(int sayıInt_0)
		{
			if (sayıInt_0 > this.prop_0.Length)
			{
				return 0;
			}
			int num = sayıInt_0 + 8;
			for (int i = sayıInt_0; i <= num; i++)
			{
				if (i > this.prop_0.Length - 1)
				{
					return 0;
				}
				if ((this.prop_0[i] & 128) != 128)
				{
					return i;
				}
			}
			return sayıInt_0 + 8;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00014C3A File Offset: 0x00012E3A
		public static bool cmethod_404(long sayıUınt_0)
		{
			return (sayıUınt_0 & 1L) == 1L;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00014C50 File Offset: 0x00012E50
		private void vmethod_405(ulong arg_0)
		{
			if (this.prop_0[(int)((uint)arg_0)] == 13)
			{
				ushort num = (this.xmethod_401((arg_0.ForceTo<decimal>() + 3m).ForceTo<int>(), 2).ForceTo<decimal>() - 1m).ForceTo<ushort>();
				int num2 = 0;
				if (this.prop_5 != null)
				{
					num2 = this.prop_5.Length;
					this.prop_5 = (Class_21[])Utils.CopyArray(this.prop_5, new Class_21[this.prop_5.Length + (int)num + 1]);
				}
				else
				{
					this.prop_5 = new Class_21[(int)(num + 1)];
				}
				int num3 = (int)num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = this.xmethod_401((arg_0.ForceTo<decimal>() + 8m + (i * 2).ForceTo<decimal>()).ForceTo<int>(), 2);
					if (decimal.Compare(arg_0.ForceTo<decimal>(), 100m) != 0)
					{
						num4 += arg_0;
					}
					int num5 = this.gmethod_403(num4.ForceTo<int>());
					this.tmethod_402(num4.ForceTo<int>(), num5);
					int num6 = this.gmethod_403((num4.ForceTo<decimal>() + num5.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<int>());
					this.prop_5[num2 + i].ID = this.tmethod_402((num4.ForceTo<decimal>() + num5.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<int>(), num6);
					num4 = (num4.ForceTo<decimal>() + num6.ForceTo<decimal>() - num4.ForceTo<decimal>() + 1m).ForceTo<ulong>();
					num5 = this.gmethod_403(num4.ForceTo<int>());
					num6 = num5;
					long value = this.tmethod_402(num4.ForceTo<int>(), num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = this.gmethod_403(num5);
						array[num7] = this.tmethod_402(num5, num6);
						if (array[num7] > 9L)
						{
							if (Class_108.cmethod_404(array[num7]))
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
							}
							else
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
							}
						}
						else
						{
							array[num7] = (long)((ulong)this.prop_7[(int)array[num7]]);
						}
						num7++;
					}
					while (num7 <= 4);
					Encoding encoding = Encoding.Default;
					decimal value2 = this.prop_1.ForceTo<decimal>();
					if (!1m.Equals(value2))
					{
						if (!2m.Equals(value2))
						{
							if (3m.Equals(value2))
							{
								encoding = Encoding.BigEndianUnicode;
							}
						}
						else
						{
							encoding = Encoding.Unicode;
						}
					}
					else
					{
						encoding = Encoding.Default;
					}
					this.prop_5[num2 + i].Type = encoding.GetString(this.prop_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					this.prop_5[num2 + i].Name = encoding.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					this.prop_5[num2 + i].RootNum = (long)this.xmethod_401(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					this.prop_5[num2 + i].SqlStatement = encoding.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				return;
			}
			if (this.prop_0[(int)((uint)arg_0)] != 5)
			{
				return;
			}
			int num8 = (int)Convert.ToUInt16(decimal.Subtract(new decimal(this.xmethod_401(Convert.ToInt32(decimal.Add(new decimal(arg_0), 3m)), 2)), 1m));
			for (int j = 0; j <= num8; j++)
			{
				ushort num9 = (ushort)this.xmethod_401(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(arg_0), 12m), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(arg_0), 100m) == 0)
				{
					this.vmethod_405(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.xmethod_401((int)num9, 4)), 1m), new decimal((int)this.prop_4))));
				}
				else
				{
					this.vmethod_405(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.xmethod_401((int)(arg_0 + (ulong)num9), 4)), 1m), new decimal((int)this.prop_4))));
				}
			}
			this.vmethod_405(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.xmethod_401(Convert.ToInt32(decimal.Add(new decimal(arg_0), 8m)), 4)), 1m), new decimal((int)this.prop_4))));
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000152A0 File Offset: 0x000134A0
		private bool dmethod_406(ulong arg_0)
		{
			if (this.prop_0[(int)((uint)arg_0)] == 13)
			{
				int num = Convert.ToInt32(decimal.Subtract(new decimal(this.xmethod_401(Convert.ToInt32(decimal.Add(new decimal(arg_0), 3m)), 2)), 1m));
				int num2 = 0;
				if (this.prop_6 != null)
				{
					num2 = this.prop_6.Length;
					this.prop_6 = (Class_52[])Utils.CopyArray(this.prop_6, new Class_52[this.prop_6.Length + num + 1]);
				}
				else
				{
					this.prop_6 = new Class_52[num + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					Class_77[] array = null;
					ulong num4 = this.xmethod_401(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(arg_0), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(arg_0), 100m) != 0)
					{
						num4 += arg_0;
					}
					int num5 = this.gmethod_403((int)num4);
					this.tmethod_402((int)num4, num5);
					int num6 = this.gmethod_403(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					this.prop_6[num2 + i].ID = this.tmethod_402(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = this.gmethod_403((int)num4);
					num6 = num5;
					long num7 = this.tmethod_402((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (Class_77[])Utils.CopyArray(array, new Class_77[num9 + 1]);
						num5 = num6 + 1;
						num6 = this.gmethod_403(num5);
						array[num9].Type = this.tmethod_402(num5, num6);
						if (array[num9].Type > 9L)
						{
							if (Class_108.cmethod_404(array[num9].Type))
							{
								array[num9].Size = (long)Math.Round((double)(array[num9].Type - 13L) / 2.0);
							}
							else
							{
								array[num9].Size = (long)Math.Round((double)(array[num9].Type - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].Size = (long)((ulong)this.prop_7[(int)array[num9].Type]);
						}
						num8 = num8 + (long)(num6 - num5) + 1L;
						num9++;
					}
					this.prop_6[num2 + i].RowData = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].Type > 9L)
						{
							if (!Class_108.cmethod_404(array[j].Type))
							{
								if (decimal.Compare(new decimal(this.prop_1), 1m) == 0)
								{
									this.prop_6[num2 + i].RowData[j] = Encoding.Default.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Size);
								}
								else if (decimal.Compare(new decimal(this.prop_1), 2m) == 0)
								{
									this.prop_6[num2 + i].RowData[j] = Encoding.Unicode.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Size);
								}
								else if (decimal.Compare(new decimal(this.prop_1), 3m) == 0)
								{
									this.prop_6[num2 + i].RowData[j] = Encoding.BigEndianUnicode.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Size);
								}
							}
							else
							{
								this.prop_6[num2 + i].RowData[j] = Encoding.Default.GetString(this.prop_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Size);
							}
						}
						else
						{
							this.prop_6[num2 + i].RowData[j] = Convert.ToString(this.xmethod_401(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Size));
						}
						num10 += (int)array[j].Size;
					}
				}
			}
			else if (this.prop_0[(int)((uint)arg_0)] == 5)
			{
				int num12 = (int)Convert.ToUInt16(decimal.Subtract(new decimal(this.xmethod_401(Convert.ToInt32(decimal.Add(new decimal(arg_0), 3m)), 2)), 1m));
				for (int k = 0; k <= num12; k++)
				{
					ushort num13 = (ushort)this.xmethod_401(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(arg_0), 12m), new decimal(k * 2))), 2);
					this.dmethod_406(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.xmethod_401((int)(arg_0 + (ulong)num13), 4)), 1m), new decimal((int)this.prop_4))));
				}
				this.dmethod_406(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.xmethod_401(Convert.ToInt32(decimal.Add(new decimal(arg_0), 8m)), 4)), 1m), new decimal((int)this.prop_4))));
			}
			return true;
		}

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private readonly byte[] field_0;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private readonly ulong field_1;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private string[] field_2;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private readonly ushort field_3;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private Class_21[] field_4;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private Class_52[] field_5;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private readonly byte[] field_6;
	}
}
