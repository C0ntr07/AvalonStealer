using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x0200008F RID: 143
	internal class Class_109
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x00015992 File Offset: 0x00013B92
		public static int kmethod_407()
		{
			if (Class_109.lmethod_408() == 1)
			{
				return 1;
			}
			if (Class_109.smethod_410())
			{
				return 1;
			}
			if (Class_109.pmethod_409())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000159C8 File Offset: 0x00013BC8
		private static int lmethod_408()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			if (Class_22.smethod_60(Process.GetCurrentProcess().Handle, Class_115.\u035B\u0341\u0E47\u0020r\u032D\u0327\u030C\u0315r\u035F\u0309\u0316\u0366\u0020\u0322gjatbovqyqahipsn\u030E\u0330\u0020\u0347\u0E47\u034A\u0316\u0020\u032F\u0020s\u031Dส\u0326\u0342\u0359gldskxmiddqykbnu, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl && intPtr == new IntPtr(-1))
			{
				Console.WriteLine("DebugPort : {0:X}", intPtr);
				return 1;
			}
			return 0;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00015A2C File Offset: 0x00013C2C
		private unsafe static bool pmethod_409()
		{
			IntPtr intPtr = Class_109.field_0;
			uint structure = 0U;
			int num;
			int num2;
			return Class_22.smethod_60(Process.GetCurrentProcess().Handle, Class_115.\u030A\u0323\u0323\u0301\u0364\u0367\u0347\u0367\u031A\u0347\u0329\u0328\u0342\u0331\u035B\u0363kwphvtsdycfmbwtc\u036D\u032E\u0359\u035F\u035E\u030E\u0308\u0349\u0E47\u0314\u0314\u0020\u036D\u0313\u0344\u035Cxlghfppznilkxgyo, out intPtr, IntPtr.Size, out num) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl && Class_22.gmethod_63(intPtr, Class_116.\u0E47\u034E\u0342\u0342\u0338\u032F\u0368\u035F\u0318\u0020\u032F\u0305\u0315\u0303\u0331\u0330gysbjpqeulupsjhy\u0320\u036F\u035C\u0358\u0355\u0E47\u0355\u031A\u0349\u0307\u035B\u035A\u034D\u0349\u0363\u0354aoriakoifkhffevn, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl && Class_22.tmethod_62(Process.GetCurrentProcess().Handle, intPtr) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl && Class_22.xmethod_61(intPtr) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00015AB0 File Offset: 0x00013CB0
		private unsafe static bool smethod_410()
		{
			Class_120 class_;
			int num;
			return Class_22.cmethod_64(Class_117.\u0324\u0317\u032D\u0335\u034C\u0356\u0324\u035A\u030C\u031B\u0020\u0355\u036D\u036D\u035A\u0341phmprwptazjowavu\u036F\u0356\u032B\u035A\u0020\u0357\u035Bs\u0E47\u034C\u036F\u036B\u0020\u035D\u0310\u035Fjfovkakobwnmdqrx, new IntPtr((void*)(&class_)), Marshal.SizeOf<Class_120>(class_), out num) == Class_59.\u034F\u035A\u034E\u0315\u032F\u0020\u0324\u0353\u032F\u0348\u032B\u0324\u0333\u0489\u035C\u034Efjlwkwurmhpntorm\u0E47\u0339\u034E\u0343\u0324\u0313\u0320\u0360\u034A\u032D\u0314\u0020\u036B\u0020l\u033Bblkcdzvgqoscjsxl && class_.\u0369\u0316\u0331\u0358\u0020\u0020\u0311\u033D\u0350\u0020\u0313\u0300\u0309\u0E47\u0348\u0342kosygpeegpcmakbn\u0317\u036C\u035A\u035B\u036B\u035A\u0020\u0333\u0320a\u036B\u0348\u0339\u030D\u0315tfgsxzqfdlngzojxv && !class_.\u0325\u0317\u0317\u0351\u032F\u034B\u0020\u0342\u0343\u0356\u030B\u0331\u033F\u0020\u0310\u0346erdmyiprjnjugich\u0020\u0020\u0363\u0356\u0353\u0020\u036B\u0350\u031F\u0364\u0301\u0E47\u0349\u0E47\u032F\u0306bajddnxbbxmrphat;
		}

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr field_0 = new IntPtr(-1);
	}
}
