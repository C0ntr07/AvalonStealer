using System;
using System.Runtime.InteropServices;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000086 RID: 134
	internal class Class_105
	{
		// Token: 0x060002C2 RID: 706
		[DllImport("vaultcli.dll", EntryPoint = "VaultOpenVault")]
		public static extern int vmethod_375(ref Guid arg_0, uint arg_1, ref IntPtr arg_2);

		// Token: 0x060002C3 RID: 707
		[DllImport("vaultcli.dll", EntryPoint = "VaultCloseVault")]
		public static extern int dmethod_376(ref IntPtr arg_0);

		// Token: 0x060002C4 RID: 708
		[DllImport("vaultcli.dll", EntryPoint = "VaultFree")]
		public static extern int kmethod_377(ref IntPtr arg_0);

		// Token: 0x060002C5 RID: 709
		[DllImport("vaultcli.dll", EntryPoint = "VaultEnumerateVaults")]
		public static extern int lmethod_378(int sayıInt_0, ref int arg_0, ref IntPtr arg_1);

		// Token: 0x060002C6 RID: 710
		[DllImport("vaultcli.dll", EntryPoint = "VaultEnumerateItems")]
		public static extern int pmethod_379(IntPtr arg_0, int sayıInt_0, ref int arg_1, ref IntPtr arg_2);

		// Token: 0x060002C7 RID: 711
		[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
		public static extern int smethod_380(IntPtr arg_0, ref Guid arg_1, IntPtr arg_2, IntPtr arg_3, IntPtr arg_4, IntPtr arg_5, int sayıInt_0, ref IntPtr arg_6);

		// Token: 0x060002C8 RID: 712
		[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
		public static extern int xmethod_381(IntPtr arg_0, ref Guid arg_1, IntPtr arg_2, IntPtr arg_3, IntPtr arg_4, int sayıInt_0, ref IntPtr arg_5);

		// Token: 0x02000087 RID: 135
		public enum NClass_0
		{
			// Token: 0x0400019A RID: 410
			field_2 = -1,
			// Token: 0x0400019B RID: 411
			field_3,
			// Token: 0x0400019C RID: 412
			field_4,
			// Token: 0x0400019D RID: 413
			field_5,
			// Token: 0x0400019E RID: 414
			field_6,
			// Token: 0x0400019F RID: 415
			field_7,
			// Token: 0x040001A0 RID: 416
			field_8,
			// Token: 0x040001A1 RID: 417
			field_9,
			// Token: 0x040001A2 RID: 418
			field_10,
			// Token: 0x040001A3 RID: 419
			field_11,
			// Token: 0x040001A4 RID: 420
			field_12,
			// Token: 0x040001A5 RID: 421
			field_13,
			// Token: 0x040001A6 RID: 422
			field_14,
			// Token: 0x040001A7 RID: 423
			field_15,
			// Token: 0x040001A8 RID: 424
			field_16
		}

		// Token: 0x02000088 RID: 136
		public enum NClass_1
		{
			// Token: 0x040001AA RID: 426
			field_18,
			// Token: 0x040001AB RID: 427
			field_19,
			// Token: 0x040001AC RID: 428
			field_20,
			// Token: 0x040001AD RID: 429
			field_21,
			// Token: 0x040001AE RID: 430
			field_22,
			// Token: 0x040001AF RID: 431
			field_23,
			// Token: 0x040001B0 RID: 432
			field_24 = 100,
			// Token: 0x040001B1 RID: 433
			field_25 = 10000
		}

		// Token: 0x02000089 RID: 137
		public struct NClass_2
		{
			// Token: 0x040001B2 RID: 434
			public Guid field_26;

			// Token: 0x040001B3 RID: 435
			public IntPtr field_27;

			// Token: 0x040001B4 RID: 436
			public IntPtr field_28;

			// Token: 0x040001B5 RID: 437
			public IntPtr field_29;

			// Token: 0x040001B6 RID: 438
			public IntPtr field_30;

			// Token: 0x040001B7 RID: 439
			public IntPtr field_31;

			// Token: 0x040001B8 RID: 440
			public ulong field_32;

			// Token: 0x040001B9 RID: 441
			public uint field_33;

			// Token: 0x040001BA RID: 442
			public uint field_34;

			// Token: 0x040001BB RID: 443
			public IntPtr field_35;
		}

		// Token: 0x0200008A RID: 138
		public struct NClass_3
		{
			// Token: 0x040001BC RID: 444
			public Guid field_36;

			// Token: 0x040001BD RID: 445
			public IntPtr field_37;

			// Token: 0x040001BE RID: 446
			public IntPtr field_38;

			// Token: 0x040001BF RID: 447
			public IntPtr field_39;

			// Token: 0x040001C0 RID: 448
			public IntPtr field_40;

			// Token: 0x040001C1 RID: 449
			public ulong field_41;

			// Token: 0x040001C2 RID: 450
			public uint field_42;

			// Token: 0x040001C3 RID: 451
			public uint field_43;

			// Token: 0x040001C4 RID: 452
			public IntPtr field_44;
		}

		// Token: 0x0200008B RID: 139
		[StructLayout(LayoutKind.Explicit)]
		public struct NClass_4
		{
			// Token: 0x040001C5 RID: 453
			[FieldOffset(0)]
			public Class_105.NClass_1 field_45;

			// Token: 0x040001C6 RID: 454
			[FieldOffset(8)]
			public Class_105.NClass_0 field_46;
		}
	}
}
