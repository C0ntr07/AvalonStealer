using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib
{
	// Token: 0x02000109 RID: 265
	internal class Class_206
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x00033659 File Offset: 0x00031859
		public static int gmethod_1313(int sayıInt_0, int sayıInt_1)
		{
			return (int)((uint)sayıInt_0 >> sayıInt_1);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00033664 File Offset: 0x00031864
		public static int cmethod_1314(TextReader arg_0, byte[] byteDizi_0, int sayıInt_0, int sayıInt_1)
		{
			if (byteDizi_0.Length == 0)
			{
				return 0;
			}
			char[] array = new char[byteDizi_0.Length];
			int num = arg_0.Read(array, sayıInt_0, sayıInt_1);
			if (num == 0)
			{
				return -1;
			}
			for (int i = sayıInt_0; i < sayıInt_0 + num; i++)
			{
				byteDizi_0[i] = (byte)array[i];
			}
			return num;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000336AF File Offset: 0x000318AF
		internal static byte[] vmethod_1315(string str_0)
		{
			return Encoding.UTF8.GetBytes(str_0);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000336BC File Offset: 0x000318BC
		internal static char[] dmethod_1316(byte[] byteDizi_0)
		{
			return Encoding.UTF8.GetChars(byteDizi_0);
		}
	}
}
