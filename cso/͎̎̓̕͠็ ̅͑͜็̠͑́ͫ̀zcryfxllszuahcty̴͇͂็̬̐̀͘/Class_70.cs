using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200005D RID: 93
	public class Class_70
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0000EC20 File Offset: 0x0000CE20
		public Class_70(string str_0)
		{
			List<byte> list = new List<byte>();
			this.field_1 = new List<KeyValuePair<string, string>>();
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(str_0)))
			{
				int i = 0;
				int num = (int)binaryReader.BaseStream.Length;
				while (i < num)
				{
					list.Add(binaryReader.ReadByte());
					i++;
				}
			}
			string value = BitConverter.ToString(this.tmethod_222(list.ToArray(), 0, 4, false)).Replace("-", "");
			string text = BitConverter.ToString(this.tmethod_222(list.ToArray(), 4, 4, false)).Replace("-", "");
			int num2 = BitConverter.ToInt32(this.tmethod_222(list.ToArray(), 12, 4, true), 0);
			if (!string.IsNullOrEmpty(value))
			{
				this.prop_0 = "Berkelet DB";
				if (text.Equals("00000002"))
				{
					this.prop_0 += " 1.85 (Hash, version 2, native byte-order)";
				}
				int num3 = int.Parse(BitConverter.ToString(this.tmethod_222(list.ToArray(), 56, 4, false)).Replace("-", ""));
				int num4 = 1;
				while (this.prop_1.Count < num3)
				{
					string[] array = new string[(num3 - this.prop_1.Count) * 2];
					for (int j = 0; j < (num3 - this.prop_1.Count) * 2; j++)
					{
						array[j] = BitConverter.ToString(this.tmethod_222(list.ToArray(), num2 * num4 + 2 + j * 2, 2, true)).Replace("-", "");
					}
					Array.Sort<string>(array);
					for (int k = 0; k < array.Length; k += 2)
					{
						int num5 = Convert.ToInt32(array[k], 16) + num2 * num4;
						int num6 = Convert.ToInt32(array[k + 1], 16) + num2 * num4;
						int num7 = (k + 2 >= array.Length) ? (num2 + num2 * num4) : (Convert.ToInt32(array[k + 2], 16) + num2 * num4);
						string @string = Encoding.ASCII.GetString(this.tmethod_222(list.ToArray(), num6, num7 - num6, false));
						string value2 = BitConverter.ToString(this.tmethod_222(list.ToArray(), num5, num6 - num5, false));
						if (!string.IsNullOrEmpty(@string))
						{
							this.prop_1.Add(new KeyValuePair<string, string>(@string, value2));
						}
					}
					num4++;
				}
				return;
			}
			this.prop_0 = "Unknow database format";
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000EF00 File Offset: 0x0000D100
		public string prop_0 { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000EF15 File Offset: 0x0000D115
		public List<KeyValuePair<string, string>> prop_1 { get; }

		// Token: 0x060001B6 RID: 438 RVA: 0x0000EF2C File Offset: 0x0000D12C
		private byte[] tmethod_222(byte[] byteDizi_0, int sayıInt_0, int sayıInt_1, bool bool_0)
		{
			byte[] array = new byte[sayıInt_1];
			int num = 0;
			for (int i = sayıInt_0; i < sayıInt_0 + sayıInt_1; i++)
			{
				array[num] = byteDizi_0[i];
				num++;
			}
			if (bool_0)
			{
				Array.Reverse(array);
			}
			return array;
		}

		// Token: 0x04000118 RID: 280
		[CompilerGenerated]
		private string field_0;

		// Token: 0x04000119 RID: 281
		[CompilerGenerated]
		private readonly List<KeyValuePair<string, string>> field_1;
	}
}
