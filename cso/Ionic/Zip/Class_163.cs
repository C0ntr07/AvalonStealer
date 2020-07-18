using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Ionic.BZip2;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x020000CC RID: 204
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	public class Class_163
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00019E0D File Offset: 0x0001800D
		internal bool prop_0
		{
			get
			{
				return this.field_1 == 0 && (this.field_2 & 16) == 16;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00019E29 File Offset: 0x00018029
		internal void lmethod_588()
		{
			this.field_44 = -1L;
			this.field_49 = 0;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00019E3C File Offset: 0x0001803C
		public string prop_1
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(string.Format("          ZipEntry: {0}\n", this.prop_12)).Append(string.Format("   Version Made By: {0}\n", this.field_0)).Append(string.Format(" Needed to extract: {0}\n", this.prop_16));
				if (this.field_27)
				{
					stringBuilder.Append("        Entry type: directory\n");
				}
				else
				{
					stringBuilder.Append(string.Format("         File type: {0}\n", this.field_66 ? "text" : "binary")).Append(string.Format("       Compression: {0}\n", this.prop_21)).Append(string.Format("        Compressed: 0x{0:X}\n", this.prop_23)).Append(string.Format("      Uncompressed: 0x{0:X}\n", this.prop_24)).Append(string.Format("             CRC32: 0x{0:X8}\n", this.field_34));
				}
				stringBuilder.Append(string.Format("       Disk Number: {0}\n", this.field_40));
				if (this.field_46 > (long)((ulong)-1))
				{
					stringBuilder.Append(string.Format("   Relative Offset: 0x{0:X16}\n", this.field_46));
				}
				else
				{
					stringBuilder.Append(string.Format("   Relative Offset: 0x{0:X8}\n", this.field_46));
				}
				stringBuilder.Append(string.Format("         Bit Field: 0x{0:X4}\n", this.field_22)).Append(string.Format("        Encrypted?: {0}\n", this.field_38)).Append(string.Format("          Timeblob: 0x{0:X8}\n", this.field_32)).Append(string.Format("              Time: {0}\n", Class_155.PackedToDateTime(this.field_32)));
				stringBuilder.Append(string.Format("         Is Zip64?: {0}\n", this.field_51));
				if (!string.IsNullOrEmpty(this.field_26))
				{
					stringBuilder.Append(string.Format("           Comment: {0}\n", this.field_26));
				}
				stringBuilder.Append("\n");
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001A074 File Offset: 0x00018274
		internal static Class_163 smethod_590(Class_168 arg_0, Dictionary<string, object> arg_1)
		{
			Stream stream = arg_0.prop_44;
			Encoding encoding = (arg_0.prop_23 == Class_170.Always) ? arg_0.prop_22 : Class_168.prop_24;
			int num = Class_155.ReadSignature(stream);
			if (Class_163.xmethod_591(num))
			{
				stream.Seek(-4L, SeekOrigin.Current);
				if ((long)num != 101010256L && (long)num != 101075792L && num != 67324752)
				{
					throw new Class_137(string.Format("  Bad signature (0x{0:X8}) at position 0x{1:X8}", num, stream.Position));
				}
				return null;
			}
			else
			{
				int num2 = 46;
				byte[] array = new byte[42];
				int num3 = stream.Read(array, 0, array.Length);
				if (num3 != array.Length)
				{
					return null;
				}
				int num4 = 0;
				Class_163 class_ = new Class_163();
				class_.prop_38 = encoding;
				class_.field_54 = Class_166.ZipFile;
				class_.field_43 = new Class_178(arg_0);
				class_.field_0 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_21 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_22 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_23 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				class_.field_11 = Class_155.PackedToDateTime(class_.field_32);
				class_.field_67 |= Class_164.DOS;
				class_.field_34 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				class_.field_29 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				class_.field_31 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				class_.field_24 = class_.field_23;
				class_.field_3 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_4 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_5 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_40 = (uint)array[num4++] + (uint)array[num4++] * 256U;
				class_.field_1 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				class_.field_2 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				class_.field_46 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				class_.prop_40 = ((class_.field_1 & 1) == 1);
				array = new byte[(int)class_.field_3];
				num3 = stream.Read(array, 0, array.Length);
				num2 += num3;
				if ((class_.field_22 & 2048) == 2048)
				{
					class_.field_20 = Class_155.Utf8StringFromBuffer(array);
				}
				else
				{
					class_.field_20 = Class_155.StringFromBuffer(array, encoding);
				}
				while (arg_1.ContainsKey(class_.field_20))
				{
					class_.field_20 = Class_163.NClass_0.nmethod_0(class_.field_20);
					class_.field_36 = true;
				}
				if (class_.prop_0)
				{
					class_.smethod_660();
				}
				else if (class_.field_20.EndsWith("/"))
				{
					class_.smethod_660();
				}
				class_.field_30 = class_.field_29;
				if ((class_.field_22 & 1) == 1)
				{
					class_.field_56 = (class_.field_55 = Class_123.PkzipWeak);
					class_.field_38 = true;
				}
				if (class_.field_4 > 0)
				{
					class_.field_51 = (class_.field_29 == (long)((ulong)-1) || class_.field_31 == (long)((ulong)-1) || class_.field_46 == (long)((ulong)-1));
					num2 += class_.xmethod_711(stream, class_.field_4);
					class_.field_30 = class_.field_29;
				}
				if (class_.field_55 == Class_123.PkzipWeak)
				{
					class_.field_30 -= 12L;
				}
				else if (class_.prop_29 == Class_123.WinZipAes128 || class_.prop_29 == Class_123.WinZipAes256)
				{
					class_.field_30 = class_.prop_23 - (long)(Class_163.kmethod_667(class_.prop_29) + 10);
					class_.field_50 = 10;
				}
				if ((class_.field_22 & 8) == 8)
				{
					if (class_.field_51)
					{
						class_.field_50 += 24;
					}
					else
					{
						class_.field_50 += 16;
					}
				}
				class_.prop_38 = (((class_.field_22 & 2048) == 2048) ? Encoding.UTF8 : encoding);
				class_.prop_39 = Class_170.Always;
				if (class_.field_5 > 0)
				{
					array = new byte[(int)class_.field_5];
					num3 = stream.Read(array, 0, array.Length);
					num2 += num3;
					if ((class_.field_22 & 2048) == 2048)
					{
						class_.field_26 = Class_155.Utf8StringFromBuffer(array);
					}
					else
					{
						class_.field_26 = Class_155.StringFromBuffer(array, encoding);
					}
				}
				return class_;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001A776 File Offset: 0x00018976
		internal static bool xmethod_591(int sayıInt_0)
		{
			return sayıInt_0 != 33639248;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001A784 File Offset: 0x00018984
		public Class_163()
		{
			this.field_23 = 8;
			this.field_25 = Class_202.Default;
			this.field_55 = Class_123.None;
			this.field_54 = Class_166.None;
			this.prop_38 = Encoding.GetEncoding("IBM437");
			this.prop_39 = Class_170.Default;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001A7EB File Offset: 0x000189EB
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0001A7F8 File Offset: 0x000189F8
		public DateTime prop_2
		{
			get
			{
				return this.field_11.ToLocalTime();
			}
			set
			{
				this.field_11 = ((value.Kind == DateTimeKind.Unspecified) ? DateTime.SpecifyKind(value, DateTimeKind.Local) : value.ToLocalTime());
				this.field_12 = Class_155.AdjustTime_Reverse(this.field_11).ToUniversalTime();
				this.field_36 = true;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001A84A File Offset: 0x00018A4A
		private int prop_3
		{
			get
			{
				return this.field_43.prop_5;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001A857 File Offset: 0x00018A57
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0001A85F File Offset: 0x00018A5F
		public DateTime prop_4
		{
			get
			{
				return this.field_12;
			}
			set
			{
				this.xmethod_601(this.field_14, this.field_13, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001A874 File Offset: 0x00018A74
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0001A87C File Offset: 0x00018A7C
		public DateTime prop_5
		{
			get
			{
				return this.field_13;
			}
			set
			{
				this.xmethod_601(this.field_14, value, this.field_12);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001A891 File Offset: 0x00018A91
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x0001A899 File Offset: 0x00018A99
		public DateTime prop_6
		{
			get
			{
				return this.field_14;
			}
			set
			{
				this.xmethod_601(value, this.field_13, this.field_12);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		public void xmethod_601(DateTime arg_0, DateTime arg_1, DateTime arg_2)
		{
			this.field_15 = true;
			if (arg_0 == Class_163.field_70 && arg_0.Kind == Class_163.field_70.Kind)
			{
				arg_0 = Class_163.field_69;
			}
			if (arg_1 == Class_163.field_70 && arg_1.Kind == Class_163.field_70.Kind)
			{
				arg_1 = Class_163.field_69;
			}
			if (arg_2 == Class_163.field_70 && arg_2.Kind == Class_163.field_70.Kind)
			{
				arg_2 = Class_163.field_69;
			}
			this.field_14 = arg_0.ToUniversalTime();
			this.field_13 = arg_1.ToUniversalTime();
			this.field_12 = arg_2.ToUniversalTime();
			this.field_11 = this.field_12;
			if (!this.field_17 && !this.field_16)
			{
				this.field_16 = true;
			}
			this.field_36 = true;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001A9A2 File Offset: 0x00018BA2
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0001A9AA File Offset: 0x00018BAA
		public bool prop_7
		{
			get
			{
				return this.field_16;
			}
			set
			{
				this.field_16 = value;
				this.field_36 = true;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001A9BA File Offset: 0x00018BBA
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0001A9C2 File Offset: 0x00018BC2
		public bool prop_8
		{
			get
			{
				return this.field_17;
			}
			set
			{
				this.field_17 = value;
				this.field_36 = true;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001A9D2 File Offset: 0x00018BD2
		public Class_164 prop_9
		{
			get
			{
				return this.field_67;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001A9DA File Offset: 0x00018BDA
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0001A9E2 File Offset: 0x00018BE2
		public FileAttributes prop_10
		{
			get
			{
				return (FileAttributes)this.field_2;
			}
			set
			{
				this.field_2 = (int)value;
				this.field_0 = 45;
				this.field_36 = true;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001A9FA File Offset: 0x00018BFA
		internal string prop_11
		{
			get
			{
				return this.field_19;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001AA02 File Offset: 0x00018C02
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0001AA0C File Offset: 0x00018C0C
		public string prop_12
		{
			get
			{
				return this.field_20;
			}
			set
			{
				if (this.field_43.prop_0 == null)
				{
					throw new Class_135("Cannot rename; this is not supported in ZipOutputStream/ZipInputStream.");
				}
				if (string.IsNullOrEmpty(value))
				{
					throw new Class_135("The FileName must be non empty and non-null.");
				}
				string text = Class_163.tmethod_652(value, null);
				if (this.field_20 == text)
				{
					return;
				}
				this.field_43.prop_0.lmethod_868(this);
				this.field_43.prop_0.xmethod_781(text, this);
				this.field_20 = text;
				this.field_43.prop_0.vmethod_855();
				this.field_36 = true;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001AAA5 File Offset: 0x00018CA5
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x0001AAAD File Offset: 0x00018CAD
		public Stream prop_13
		{
			get
			{
				return this.field_59;
			}
			set
			{
				if (this.field_54 != Class_166.Stream)
				{
					throw new Class_135("You must not set the input stream for this entry.");
				}
				this.field_61 = true;
				this.field_59 = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001AAD4 File Offset: 0x00018CD4
		public bool prop_14
		{
			get
			{
				return this.field_61;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001AADC File Offset: 0x00018CDC
		public Class_166 prop_15
		{
			get
			{
				return this.field_54;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		public short prop_16
		{
			get
			{
				return this.field_21;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0001AAEC File Offset: 0x00018CEC
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0001AAF4 File Offset: 0x00018CF4
		public string prop_17
		{
			get
			{
				return this.field_26;
			}
			set
			{
				this.field_26 = value;
				this.field_36 = true;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0001AB04 File Offset: 0x00018D04
		public bool? prop_18
		{
			get
			{
				return this.field_64;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001AB0C File Offset: 0x00018D0C
		public bool? prop_19
		{
			get
			{
				return this.field_65;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001AB14 File Offset: 0x00018D14
		public short prop_20
		{
			get
			{
				return this.field_22;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001AB1C File Offset: 0x00018D1C
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x0001AB24 File Offset: 0x00018D24
		public Class_165 prop_21
		{
			get
			{
				return (Class_165)this.field_23;
			}
			set
			{
				if (value == (Class_165)this.field_23)
				{
					return;
				}
				if (value != Class_165.None && value != Class_165.Deflate && value != Class_165.BZip2)
				{
					throw new InvalidOperationException("Unsupported compression method.");
				}
				this.field_23 = (short)value;
				if (this.field_23 == 0)
				{
					this.field_25 = Class_202.None;
				}
				else if (this.prop_22 == Class_202.None)
				{
					this.field_25 = Class_202.Default;
				}
				if (this.field_43.prop_0 != null)
				{
					this.field_43.prop_0.vmethod_855();
				}
				this.field_37 = true;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001ABB6 File Offset: 0x00018DB6
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		public Class_202 prop_22
		{
			get
			{
				return this.field_25;
			}
			set
			{
				if (this.field_23 != 8 && this.field_23 != 0)
				{
					return;
				}
				if (value == Class_202.Default && this.field_23 == 8)
				{
					return;
				}
				this.field_25 = value;
				if (value == Class_202.None && this.field_23 == 0)
				{
					return;
				}
				if (this.field_25 == Class_202.None)
				{
					this.field_23 = 0;
				}
				else
				{
					this.field_23 = 8;
				}
				if (this.field_43.prop_0 != null)
				{
					this.field_43.prop_0.vmethod_855();
				}
				this.field_37 = true;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001AC57 File Offset: 0x00018E57
		public long prop_23
		{
			get
			{
				return this.field_29;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001AC5F File Offset: 0x00018E5F
		public long prop_24
		{
			get
			{
				return this.field_31;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001AC68 File Offset: 0x00018E68
		public double prop_25
		{
			get
			{
				if (this.prop_24 == 0L)
				{
					return 0.0;
				}
				return 100.0 * (1.0 - 1.0 * (double)this.prop_23 / (1.0 * (double)this.prop_24));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0001ACC3 File Offset: 0x00018EC3
		public int prop_26
		{
			get
			{
				return this.field_34;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001ACCB File Offset: 0x00018ECB
		public bool prop_27
		{
			get
			{
				return this.field_27;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001ACD3 File Offset: 0x00018ED3
		public bool prop_28
		{
			get
			{
				return this.field_56 != Class_123.None;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001ACE1 File Offset: 0x00018EE1
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0001ACEC File Offset: 0x00018EEC
		public Class_123 prop_29
		{
			get
			{
				return this.field_55;
			}
			set
			{
				if (value == this.field_55)
				{
					return;
				}
				if (value == Class_123.Unsupported)
				{
					throw new InvalidOperationException("You may not set Encryption to that value.");
				}
				this.field_55 = value;
				this.field_37 = true;
				if (this.field_43.prop_0 != null)
				{
					this.field_43.prop_0.vmethod_855();
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001AD9F File Offset: 0x00018F9F
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0001AD48 File Offset: 0x00018F48
		public string prop_30
		{
			private get
			{
				return this.field_53;
			}
			set
			{
				this.field_53 = value;
				if (this.field_53 == null)
				{
					this.field_55 = Class_123.None;
					return;
				}
				if (this.field_54 == Class_166.ZipFile && !this.field_38)
				{
					this.field_37 = true;
				}
				if (this.prop_29 == Class_123.None)
				{
					this.field_55 = Class_123.PkzipWeak;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001ADA7 File Offset: 0x00018FA7
		internal bool prop_31
		{
			get
			{
				return this.field_37 | this.field_36;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001ADB6 File Offset: 0x00018FB6
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0001ADBE File Offset: 0x00018FBE
		public Class_141 prop_32 { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001ADC7 File Offset: 0x00018FC7
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0001ADCF File Offset: 0x00018FCF
		public Class_167 prop_33 { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		public bool prop_34
		{
			get
			{
				return !this.field_39;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001ADE3 File Offset: 0x00018FE3
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0001ADEB File Offset: 0x00018FEB
		public Class_127 prop_35 { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0001AE16 File Offset: 0x00019016
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool prop_36
		{
			get
			{
				return this.prop_38 == Encoding.GetEncoding("UTF-8") && this.prop_39 == Class_170.AsNecessary;
			}
			set
			{
				if (value)
				{
					this.prop_38 = Encoding.GetEncoding("UTF-8");
					this.prop_39 = Class_170.AsNecessary;
					return;
				}
				this.prop_38 = Class_168.prop_24;
				this.prop_39 = Class_170.Default;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001AE48 File Offset: 0x00019048
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0001AE50 File Offset: 0x00019050
		[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public Encoding prop_37 { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001AE59 File Offset: 0x00019059
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0001AE61 File Offset: 0x00019061
		public Encoding prop_38 { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001AE6A File Offset: 0x0001906A
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0001AE72 File Offset: 0x00019072
		public Class_170 prop_39 { get; set; }

		// Token: 0x06000440 RID: 1088 RVA: 0x0001AE7C File Offset: 0x0001907C
		internal static string tmethod_652(string str_0, string str_1)
		{
			string pathName;
			if (str_1 == null)
			{
				pathName = str_0;
			}
			else if (string.IsNullOrEmpty(str_1))
			{
				pathName = Path.GetFileName(str_0);
			}
			else
			{
				pathName = Path.Combine(str_1, Path.GetFileName(str_0));
			}
			return Class_155.NormalizePathForUseInZipFile(pathName);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001AEC4 File Offset: 0x000190C4
		internal static Class_163 gmethod_653(string str_0)
		{
			return Class_163.pmethod_659(str_0, Class_166.None, null, null);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001AECF File Offset: 0x000190CF
		internal static Class_163 cmethod_654(string str_0, string str_1)
		{
			return Class_163.pmethod_659(str_1, Class_166.FileSystem, str_0, null);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001AEDA File Offset: 0x000190DA
		internal static Class_163 vmethod_655(string str_0, Stream stream_)
		{
			return Class_163.pmethod_659(str_0, Class_166.Stream, stream_, null);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001AEE5 File Offset: 0x000190E5
		internal static Class_163 dmethod_656(string str_0, Class_124 arg_0)
		{
			return Class_163.pmethod_659(str_0, Class_166.WriteDelegate, arg_0, null);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001AEF0 File Offset: 0x000190F0
		internal static Class_163 kmethod_657(string str_0, Class_125 arg_0, Class_126 arg_1)
		{
			return Class_163.pmethod_659(str_0, Class_166.JitStream, arg_0, arg_1);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001AEFB File Offset: 0x000190FB
		internal static Class_163 lmethod_658(string str_0)
		{
			return Class_163.pmethod_659(str_0, Class_166.ZipOutputStream, null, null);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001AF08 File Offset: 0x00019108
		private static Class_163 pmethod_659(string str_0, Class_166 arg_0, object obje_0, object obje_1)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new Class_135("The entry name must be non-null and non-empty.");
			}
			Class_163 class_ = new Class_163();
			class_.field_0 = 45;
			class_.field_54 = arg_0;
			class_.field_12 = (class_.field_13 = (class_.field_14 = DateTime.UtcNow));
			if (arg_0 == Class_166.Stream)
			{
				class_.field_59 = (obje_0 as Stream);
			}
			else if (arg_0 == Class_166.WriteDelegate)
			{
				class_.field_71 = (obje_0 as Class_124);
			}
			else if (arg_0 == Class_166.JitStream)
			{
				class_.field_72 = (obje_0 as Class_125);
				class_.field_73 = (obje_1 as Class_126);
			}
			else if (arg_0 != Class_166.ZipOutputStream)
			{
				if (arg_0 == Class_166.None)
				{
					class_.field_54 = Class_166.FileSystem;
				}
				else
				{
					string text = obje_0 as string;
					if (string.IsNullOrEmpty(text))
					{
						throw new Class_135("The filename must be non-null and non-empty.");
					}
					try
					{
						class_.field_12 = File.GetLastWriteTime(text).ToUniversalTime();
						class_.field_14 = File.GetCreationTime(text).ToUniversalTime();
						class_.field_13 = File.GetLastAccessTime(text).ToUniversalTime();
						if (File.Exists(text) || Directory.Exists(text))
						{
							class_.field_2 = (int)File.GetAttributes(text);
						}
						class_.field_15 = true;
						class_.field_19 = Path.GetFullPath(text);
					}
					catch (PathTooLongException arg_)
					{
						string str_ = string.Format("The path is too long, filename={0}", text);
						throw new Class_135(str_, arg_);
					}
				}
			}
			class_.field_11 = class_.field_12;
			class_.field_20 = Class_155.NormalizePathForUseInZipFile(str_0);
			return class_;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001B0A4 File Offset: 0x000192A4
		internal void smethod_660()
		{
			this.field_27 = true;
			if (!this.field_20.EndsWith("/"))
			{
				this.field_20 += "/";
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001B0D8 File Offset: 0x000192D8
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0001B0E0 File Offset: 0x000192E0
		public bool prop_40
		{
			get
			{
				return this.field_66;
			}
			set
			{
				this.field_66 = value;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001B0E9 File Offset: 0x000192E9
		public virtual string gmethod_663()
		{
			return string.Format("ZipEntry::{0}", this.prop_12);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001B0FC File Offset: 0x000192FC
		internal Stream prop_41
		{
			get
			{
				if (this.field_58 == null)
				{
					if (this.field_43.prop_0 != null)
					{
						Class_168 class_ = this.field_43.prop_0;
						class_.kmethod_857(false);
						this.field_58 = class_.dmethod_856(this.field_40);
					}
					else
					{
						this.field_58 = this.field_43.prop_1.prop_18;
					}
				}
				return this.field_58;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001B16C File Offset: 0x0001936C
		private void vmethod_665()
		{
			long position = this.prop_41.Position;
			try
			{
				this.prop_41.Seek(this.field_46, SeekOrigin.Begin);
			}
			catch (IOException arg_)
			{
				string str_ = string.Format("Exception seeking  entry({0}) offset(0x{1:X8}) len(0x{2:X8})", this.prop_12, this.field_46, this.prop_41.Length);
				throw new Class_140(str_, arg_);
			}
			byte[] array = new byte[30];
			this.prop_41.Read(array, 0, array.Length);
			short num = (short)((int)array[26] + (int)array[27] * 256);
			short num2 = (short)((int)array[28] + (int)array[29] * 256);
			this.prop_41.Seek((long)(num + num2), SeekOrigin.Current);
			this.field_49 = (int)(30 + num2 + num) + Class_163.kmethod_667(this.field_56);
			this.field_44 = this.field_46 + (long)this.field_49;
			this.prop_41.Seek(position, SeekOrigin.Begin);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001B270 File Offset: 0x00019470
		private static int dmethod_666(Class_123 arg_0)
		{
			if (arg_0 == Class_123.WinZipAes256)
			{
				return 256;
			}
			if (arg_0 == Class_123.WinZipAes128)
			{
				return 128;
			}
			return -1;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001B290 File Offset: 0x00019490
		internal static int kmethod_667(Class_123 arg_0)
		{
			if (arg_0 == Class_123.None)
			{
				return 0;
			}
			if (arg_0 == Class_123.WinZipAes128 || arg_0 == Class_123.WinZipAes256)
			{
				int num = Class_163.dmethod_666(arg_0);
				return num / 8 / 2 + 2;
			}
			if (arg_0 == Class_123.PkzipWeak)
			{
				return 12;
			}
			throw new Class_135("internal error");
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001B2D8 File Offset: 0x000194D8
		internal long prop_42
		{
			get
			{
				if (this.field_44 == -1L)
				{
					this.vmethod_665();
				}
				return this.field_44;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001B2F3 File Offset: 0x000194F3
		private int prop_43
		{
			get
			{
				if (this.field_49 == 0)
				{
					this.vmethod_665();
				}
				return this.field_49;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001B30C File Offset: 0x0001950C
		public void smethod_670()
		{
			this.pmethod_689(".", null, null);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0001B31B File Offset: 0x0001951B
		public void xmethod_671(Class_141 arg_0)
		{
			this.prop_32 = arg_0;
			this.pmethod_689(".", null, null);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001B331 File Offset: 0x00019531
		public void tmethod_672(Stream stream_)
		{
			this.pmethod_689(null, stream_, null);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001B33C File Offset: 0x0001953C
		public void gmethod_673(string str_0)
		{
			this.pmethod_689(str_0, null, null);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001B347 File Offset: 0x00019547
		public void cmethod_674(string str_0, Class_141 arg_0)
		{
			this.prop_32 = arg_0;
			this.pmethod_689(str_0, null, null);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001B359 File Offset: 0x00019559
		public void vmethod_675(string str_0)
		{
			this.pmethod_689(".", null, str_0);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001B368 File Offset: 0x00019568
		public void dmethod_676(string str_0, string str_1)
		{
			this.pmethod_689(str_0, null, str_1);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001B373 File Offset: 0x00019573
		public void kmethod_677(Class_141 arg_0, string str_0)
		{
			this.prop_32 = arg_0;
			this.pmethod_689(".", null, str_0);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001B389 File Offset: 0x00019589
		public void lmethod_678(string str_0, Class_141 arg_0, string str_1)
		{
			this.prop_32 = arg_0;
			this.pmethod_689(str_0, null, str_1);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001B39B File Offset: 0x0001959B
		public void pmethod_679(Stream stream_, string str_0)
		{
			this.pmethod_689(null, stream_, str_0);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001B3A6 File Offset: 0x000195A6
		public Class_216 smethod_680()
		{
			if (this.field_43.prop_0 == null)
			{
				throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.tmethod_682(this.field_53 ?? this.field_43.prop_3);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001B3E1 File Offset: 0x000195E1
		public Class_216 xmethod_681(string str_0)
		{
			if (this.field_43.prop_0 == null)
			{
				throw new InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.tmethod_682(str_0);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001B408 File Offset: 0x00019608
		internal Class_216 tmethod_682(string str_0)
		{
			this.smethod_700();
			this.pmethod_699();
			this.xmethod_701(str_0);
			if (this.field_54 != Class_166.ZipFile)
			{
				throw new Class_140("You must call ZipFile.Save before calling OpenReader");
			}
			long sayıUınt_ = (this.field_24 == 0) ? this.field_30 : this.prop_24;
			Stream stream_ = this.prop_41;
			this.prop_41.Seek(this.prop_42, SeekOrigin.Begin);
			this.field_74 = this.vmethod_695(stream_);
			Stream stream_2 = this.cmethod_694(this.field_74);
			return new Class_216(stream_2, sayıUınt_);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001B497 File Offset: 0x00019697
		private void gmethod_683(long sayıUınt_0, long sayıUınt_1)
		{
			if (this.field_43.prop_0 != null)
			{
				this.field_62 = this.field_43.prop_0.gmethod_893(this, sayıUınt_0, sayıUınt_1);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001B4C2 File Offset: 0x000196C2
		private void cmethod_684(string str_0)
		{
			if (this.field_43.prop_0 != null && !this.field_43.prop_0.field_37)
			{
				this.field_62 = this.field_43.prop_0.cmethod_894(this, str_0, true);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001B502 File Offset: 0x00019702
		private void vmethod_685(string str_0)
		{
			if (this.field_43.prop_0 != null && !this.field_43.prop_0.field_37)
			{
				this.field_43.prop_0.cmethod_894(this, str_0, false);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001B53D File Offset: 0x0001973D
		private void dmethod_686(string str_0)
		{
			if (this.field_43.prop_0 != null)
			{
				this.field_62 = this.field_43.prop_0.vmethod_895(this, str_0);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001B567 File Offset: 0x00019767
		private static void kmethod_687(string str_0)
		{
			if ((File.GetAttributes(str_0) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				File.SetAttributes(str_0, FileAttributes.Normal);
			}
			File.Delete(str_0);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001B588 File Offset: 0x00019788
		private void lmethod_688(string str_0, params object[] arg_0)
		{
			if (this.field_43.prop_0 != null && this.field_43.prop_0.prop_14)
			{
				this.field_43.prop_0.prop_25.WriteLine(str_0, arg_0);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001B5C8 File Offset: 0x000197C8
		private void pmethod_689(string str_0, Stream stream_, string str_1)
		{
			if (this.field_43 == null)
			{
				throw new Class_140("This entry is an orphan");
			}
			if (this.field_43.prop_0 == null)
			{
				throw new InvalidOperationException("Use Extract() only with ZipFile.");
			}
			this.field_43.prop_0.kmethod_857(false);
			if (this.field_54 != Class_166.ZipFile)
			{
				throw new Class_140("You must call ZipFile.Save before calling any Extract method");
			}
			this.cmethod_684(str_0);
			this.field_62 = false;
			string text = null;
			Stream stream = null;
			bool flag = false;
			bool flag2 = false;
			try
			{
				this.smethod_700();
				this.pmethod_699();
				if (this.tmethod_702(str_0, stream_, out text))
				{
					this.lmethod_688("extract dir {0}...", new object[]
					{
						text
					});
					this.vmethod_685(str_0);
				}
				else
				{
					if (text != null && File.Exists(text))
					{
						flag = true;
						int num = this.xmethod_691(str_0, text);
						if (num == 2)
						{
							goto IL_2D6;
						}
						if (num == 1)
						{
							return;
						}
					}
					string text2 = str_1 ?? (this.field_53 ?? this.field_43.prop_3);
					if (this.field_56 != Class_123.None)
					{
						if (text2 == null)
						{
							throw new Class_136();
						}
						this.xmethod_701(text2);
					}
					if (text != null)
					{
						this.lmethod_688("extract file {0}...", new object[]
						{
							text
						});
						text += ".tmp";
						string directoryName = Path.GetDirectoryName(text);
						if (!Directory.Exists(directoryName))
						{
							Directory.CreateDirectory(directoryName);
						}
						else if (this.field_43.prop_0 != null)
						{
							flag2 = this.field_43.prop_0.field_37;
						}
						stream = new FileStream(text, FileMode.CreateNew);
					}
					else
					{
						this.lmethod_688("extract entry {0} to stream...", new object[]
						{
							this.prop_12
						});
						stream = stream_;
					}
					if (!this.field_62)
					{
						int sayıInt_ = this.gmethod_693(stream);
						if (!this.field_62)
						{
							this.smethod_690(sayıInt_);
							if (text != null)
							{
								stream.Close();
								stream = null;
								string text3 = text;
								string text4 = null;
								text = text3.Substring(0, text3.Length - 4);
								if (flag)
								{
									text4 = text + ".PendingOverwrite";
									File.Move(text, text4);
								}
								File.Move(text3, text);
								this.dmethod_696(text, true);
								if (text4 != null && File.Exists(text4))
								{
									Class_163.kmethod_687(text4);
								}
								if (flag2 && this.prop_12.IndexOf('/') != -1)
								{
									string directoryName2 = Path.GetDirectoryName(this.prop_12);
									if (this.field_43.prop_0.gmethod_863(directoryName2) == null)
									{
										this.dmethod_696(Path.GetDirectoryName(text), false);
									}
								}
								if (((int)this.field_0 & 65280) == 2560 || ((int)this.field_0 & 65280) == 0)
								{
									File.SetAttributes(text, (FileAttributes)this.field_2);
								}
							}
							this.vmethod_685(str_0);
						}
					}
					IL_2D6:;
				}
			}
			catch (Exception)
			{
				this.field_62 = true;
				throw;
			}
			finally
			{
				if (this.field_62 && text != null)
				{
					if (stream != null)
					{
						stream.Close();
					}
					if (File.Exists(text) && !flag)
					{
						File.Delete(text);
					}
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001B928 File Offset: 0x00019B28
		internal void smethod_690(int sayıInt_0)
		{
			if (sayıInt_0 != this.field_34 && ((this.prop_29 != Class_123.WinZipAes128 && this.prop_29 != Class_123.WinZipAes256) || this.field_10 != 2))
			{
				throw new Class_138("CRC error: the file being extracted appears to be corrupted. " + string.Format("Expected 0x{0:X8}, Actual 0x{1:X8}", this.field_34, sayıInt_0));
			}
			if (this.prop_24 == 0L)
			{
				return;
			}
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				Class_158 class_ = this.field_74 as Class_158;
				this.field_8.field_12 = class_.prop_0;
				this.field_8.lmethod_548(this.prop_41);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		private int xmethod_691(string str_0, string str_1)
		{
			int num = 0;
			for (;;)
			{
				switch (this.prop_32)
				{
				case Class_141.OverwriteSilently:
					goto IL_24;
				case Class_141.DoNotOverwrite:
					goto IL_3D;
				case Class_141.InvokeExtractProgressEvent:
					if (num > 0)
					{
						goto Block_2;
					}
					this.dmethod_686(str_0);
					if (this.field_62)
					{
						return 2;
					}
					num++;
					continue;
				}
				break;
			}
			goto IL_8E;
			IL_24:
			this.lmethod_688("the file {0} exists; will overwrite it...", new object[]
			{
				str_1
			});
			return 0;
			IL_3D:
			this.lmethod_688("the file {0} exists; not extracting entry...", new object[]
			{
				this.prop_12
			});
			this.vmethod_685(str_0);
			return 1;
			Block_2:
			throw new Class_135(string.Format("The file {0} already exists.", str_1));
			IL_8E:
			throw new Class_135(string.Format("The file {0} already exists.", str_1));
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001BA98 File Offset: 0x00019C98
		private void tmethod_692(int sayıInt_0)
		{
			if (sayıInt_0 == 0)
			{
				throw new Class_137(string.Format("bad read of entry {0} from compressed archive.", this.prop_12));
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private int gmethod_693(Stream stream_)
		{
			int result = 0;
			Stream stream = this.prop_41;
			try
			{
				stream.Seek(this.prop_42, SeekOrigin.Begin);
				byte[] array = new byte[this.prop_3];
				long num = (this.field_24 != 0) ? this.prop_24 : this.field_30;
				this.field_74 = this.vmethod_695(stream);
				Stream stream_2 = this.cmethod_694(this.field_74);
				long num2 = 0L;
				using (Class_216 class_ = new Class_216(stream_2))
				{
					while (num > 0L)
					{
						int count = (num > (long)array.Length) ? array.Length : ((int)num);
						int num3 = class_.Read(array, 0, count);
						this.tmethod_692(num3);
						stream_.Write(array, 0, num3);
						num -= (long)num3;
						num2 += (long)num3;
						this.gmethod_683(num2, this.prop_24);
						if (this.field_62)
						{
							break;
						}
					}
					result = class_.prop_1;
				}
			}
			finally
			{
				Class_179 class_2 = stream as Class_179;
				if (class_2 != null)
				{
					class_2.Dispose();
					this.field_58 = null;
				}
			}
			return result;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		internal Stream cmethod_694(Stream stream_)
		{
			short num = this.field_24;
			if (num == 0)
			{
				return stream_;
			}
			if (num == 8)
			{
				return new Class_191(stream_, Class_204.Decompress, true);
			}
			if (num != 12)
			{
				return null;
			}
			return new Class_182(stream_, true);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001BC34 File Offset: 0x00019E34
		internal Stream vmethod_695(Stream stream_)
		{
			Stream result;
			if (this.field_56 == Class_123.PkzipWeak)
			{
				result = new Class_162(stream_, this.field_6, Class_161.Decrypt);
			}
			else if (this.field_56 == Class_123.WinZipAes128 || this.field_56 == Class_123.WinZipAes256)
			{
				result = new Class_158(stream_, this.field_8, this.field_30, Class_161.Decrypt);
			}
			else
			{
				result = stream_;
			}
			return result;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001BC98 File Offset: 0x00019E98
		internal void dmethod_696(string str_0, bool bool_0)
		{
			try
			{
				if (this.field_15)
				{
					if (bool_0)
					{
						if (File.Exists(str_0))
						{
							File.SetCreationTimeUtc(str_0, this.field_14);
							File.SetLastAccessTimeUtc(str_0, this.field_13);
							File.SetLastWriteTimeUtc(str_0, this.field_12);
						}
					}
					else if (Directory.Exists(str_0))
					{
						Directory.SetCreationTimeUtc(str_0, this.field_14);
						Directory.SetLastAccessTimeUtc(str_0, this.field_13);
						Directory.SetLastWriteTimeUtc(str_0, this.field_12);
					}
				}
				else
				{
					DateTime lastWriteTime = Class_155.AdjustTime_Reverse(this.prop_2);
					if (bool_0)
					{
						File.SetLastWriteTime(str_0, lastWriteTime);
					}
					else
					{
						Directory.SetLastWriteTime(str_0, lastWriteTime);
					}
				}
			}
			catch (IOException ex)
			{
				this.lmethod_688("failed to set time on {0}: {1}", new object[]
				{
					str_0,
					ex.Message
				});
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0001BD80 File Offset: 0x00019F80
		private string prop_44
		{
			get
			{
				string empty = string.Empty;
				uint num = this.field_52;
				if (num <= 26128U)
				{
					if (num <= 26115U)
					{
						if (num == 0U)
						{
							return "--";
						}
						switch (num)
						{
						case 26113U:
							return "DES";
						case 26114U:
							return "RC2";
						case 26115U:
							return "3DES-168";
						}
					}
					else
					{
						if (num == 26121U)
						{
							return "3DES-112";
						}
						switch (num)
						{
						case 26126U:
							return "PKWare AES128";
						case 26127U:
							return "PKWare AES192";
						case 26128U:
							return "PKWare AES256";
						}
					}
				}
				else if (num <= 26401U)
				{
					if (num == 26370U)
					{
						return "RC2";
					}
					switch (num)
					{
					case 26400U:
						return "Blowfish";
					case 26401U:
						return "Twofish";
					}
				}
				else
				{
					if (num == 26625U)
					{
						return "RC4";
					}
					if (num != 65535U)
					{
					}
				}
				return string.Format("Unknown (0x{0:X4})", this.field_52);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		private string prop_45
		{
			get
			{
				string empty = string.Empty;
				int num = (int)this.field_23;
				if (num <= 14)
				{
					switch (num)
					{
					case 0:
						return "Store";
					case 1:
						return "Shrink";
					default:
						switch (num)
						{
						case 8:
							return "DEFLATE";
						case 9:
							return "Deflate64";
						case 12:
							return "BZIP2";
						case 14:
							return "LZMA";
						}
						break;
					}
				}
				else
				{
					if (num == 19)
					{
						return "LZ77";
					}
					if (num == 98)
					{
						return "PPMd";
					}
				}
				return string.Format("Unknown (0x{0:X4})", this.field_23);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001BFC4 File Offset: 0x0001A1C4
		internal void pmethod_699()
		{
			if (this.prop_29 == Class_123.PkzipWeak || this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256 || this.prop_29 == Class_123.None)
			{
				return;
			}
			if (this.field_52 != 0U)
			{
				throw new Class_135(string.Format("Cannot extract: Entry {0} is encrypted with an algorithm not supported by DotNetZip: {1}", this.prop_12, this.prop_44));
			}
			throw new Class_135(string.Format("Cannot extract: Entry {0} uses an unsupported encryption algorithm ({1:X2})", this.prop_12, (int)this.prop_29));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001C048 File Offset: 0x0001A248
		private void smethod_700()
		{
			if (this.field_24 != 0 && this.field_24 != 8 && this.field_24 != 12)
			{
				throw new Class_135(string.Format("Entry {0} uses an unsupported compression method (0x{1:X2}, {2})", this.prop_12, this.field_24, this.prop_45));
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001C0A0 File Offset: 0x0001A2A0
		private void xmethod_701(string str_0)
		{
			if (this.field_56 == Class_123.None)
			{
				return;
			}
			if (this.field_56 != Class_123.PkzipWeak)
			{
				if (this.field_56 == Class_123.WinZipAes128 || this.field_56 == Class_123.WinZipAes256)
				{
					if (str_0 == null)
					{
						throw new Class_135("Missing password.");
					}
					if (this.field_8 != null)
					{
						this.field_8.prop_4 = str_0;
						return;
					}
					int num = Class_163.kmethod_667(this.field_56);
					this.prop_41.Seek(this.prop_42 - (long)num, SeekOrigin.Begin);
					int sayıInt_ = Class_163.dmethod_666(this.field_56);
					this.field_8 = Class_157.lmethod_538(str_0, sayıInt_, this.prop_41);
				}
				return;
			}
			if (str_0 == null)
			{
				throw new Class_135("Missing password.");
			}
			this.prop_41.Seek(this.prop_42 - 12L, SeekOrigin.Begin);
			this.field_6 = Class_160.smethod_570(str_0, this);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001C180 File Offset: 0x0001A380
		private bool tmethod_702(string str_0, Stream stream_, out string arg_0)
		{
			if (str_0 != null)
			{
				string text = this.prop_12.Replace("\\", "/");
				if (text.IndexOf(':') == 1)
				{
					text = text.Substring(2);
				}
				if (text.StartsWith("/"))
				{
					text = text.Substring(1);
				}
				if (this.field_43.prop_0.prop_6)
				{
					arg_0 = Path.Combine(str_0, (text.IndexOf('/') != -1) ? Path.GetFileName(text) : text);
				}
				else
				{
					arg_0 = Path.Combine(str_0, text);
				}
				arg_0 = arg_0.Replace("/", "\\");
				if (this.prop_27 || this.prop_12.EndsWith("/"))
				{
					if (!Directory.Exists(arg_0))
					{
						Directory.CreateDirectory(arg_0);
						this.dmethod_696(arg_0, false);
					}
					else if (this.prop_32 == Class_141.OverwriteSilently)
					{
						this.dmethod_696(arg_0, false);
					}
					return true;
				}
				return false;
			}
			else
			{
				if (stream_ != null)
				{
					arg_0 = null;
					return this.prop_27 || this.prop_12.EndsWith("/");
				}
				throw new ArgumentNullException("outstream");
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001C2C4 File Offset: 0x0001A4C4
		private void gmethod_703()
		{
			this.field_75++;
			long position = this.prop_41.Position;
			this.prop_41.Seek(this.field_46, SeekOrigin.Begin);
			byte[] array = new byte[30];
			this.prop_41.Read(array, 0, array.Length);
			int num = 26;
			short num2 = (short)((int)array[num++] + (int)array[num++] * 256);
			short sayıShort_ = (short)((int)array[num++] + (int)array[num++] * 256);
			this.prop_41.Seek((long)num2, SeekOrigin.Current);
			this.xmethod_711(this.prop_41, sayıShort_);
			this.prop_41.Seek(position, SeekOrigin.Begin);
			this.field_75--;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001C384 File Offset: 0x0001A584
		private static bool cmethod_704(Class_163 arg_0, Encoding arg_1)
		{
			int num = 0;
			arg_0.field_46 = arg_0.prop_41.Position;
			int num2 = Class_155.ReadEntrySignature(arg_0.prop_41);
			num += 4;
			if (Class_163.dmethod_706(num2))
			{
				arg_0.prop_41.Seek(-4L, SeekOrigin.Current);
				if (Class_163.xmethod_591(num2) && (long)num2 != 101010256L)
				{
					throw new Class_137(string.Format("  Bad signature (0x{0:X8}) at position  0x{1:X8}", num2, arg_0.prop_41.Position));
				}
				return false;
			}
			else
			{
				byte[] array = new byte[26];
				int num3 = arg_0.prop_41.Read(array, 0, array.Length);
				if (num3 != array.Length)
				{
					return false;
				}
				num += num3;
				int num4 = 0;
				arg_0.field_21 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				arg_0.field_22 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				arg_0.field_24 = (arg_0.field_23 = (short)((int)array[num4++] + (int)array[num4++] * 256));
				arg_0.field_32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				arg_0.field_11 = Class_155.PackedToDateTime(arg_0.field_32);
				arg_0.field_67 |= Class_164.DOS;
				if ((arg_0.field_22 & 1) == 1)
				{
					arg_0.field_56 = (arg_0.field_55 = Class_123.PkzipWeak);
					arg_0.field_38 = true;
				}
				arg_0.field_34 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				arg_0.field_29 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				arg_0.field_31 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				if ((uint)arg_0.field_29 == 4294967295U || (uint)arg_0.field_31 == 4294967295U)
				{
					arg_0.field_51 = true;
				}
				short num5 = (short)((int)array[num4++] + (int)array[num4++] * 256);
				short sayıShort_ = (short)((int)array[num4++] + (int)array[num4++] * 256);
				array = new byte[(int)num5];
				num3 = arg_0.prop_41.Read(array, 0, array.Length);
				num += num3;
				if ((arg_0.field_22 & 2048) == 2048)
				{
					arg_0.prop_38 = Encoding.UTF8;
					arg_0.prop_39 = Class_170.Always;
				}
				arg_0.field_20 = arg_0.prop_38.GetString(array, 0, array.Length);
				if (arg_0.field_20.EndsWith("/"))
				{
					arg_0.smethod_660();
				}
				num += arg_0.xmethod_711(arg_0.prop_41, sayıShort_);
				arg_0.field_50 = 0;
				if (!arg_0.field_20.EndsWith("/") && (arg_0.field_22 & 8) == 8)
				{
					long position = arg_0.prop_41.Position;
					bool flag = true;
					long num6 = 0L;
					int num7 = 0;
					while (flag)
					{
						num7++;
						if (arg_0.field_43.prop_0 != null)
						{
							arg_0.field_43.prop_0.kmethod_887(arg_0);
						}
						long num8 = Class_155.FindSignature(arg_0.prop_41, 134695760);
						if (num8 == -1L)
						{
							return false;
						}
						num6 += num8;
						if (arg_0.field_51)
						{
							array = new byte[20];
							num3 = arg_0.prop_41.Read(array, 0, array.Length);
							if (num3 != 20)
							{
								return false;
							}
							num4 = 0;
							arg_0.field_34 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
							arg_0.field_29 = BitConverter.ToInt64(array, num4);
							num4 += 8;
							arg_0.field_31 = BitConverter.ToInt64(array, num4);
							num4 += 8;
							arg_0.field_50 += 24;
						}
						else
						{
							array = new byte[12];
							num3 = arg_0.prop_41.Read(array, 0, array.Length);
							if (num3 != 12)
							{
								return false;
							}
							num4 = 0;
							arg_0.field_34 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
							arg_0.field_29 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
							arg_0.field_31 = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
							arg_0.field_50 += 16;
						}
						flag = (num6 != arg_0.field_29);
						if (flag)
						{
							arg_0.prop_41.Seek(-12L, SeekOrigin.Current);
							num6 += 4L;
						}
					}
					arg_0.prop_41.Seek(position, SeekOrigin.Begin);
				}
				arg_0.field_30 = arg_0.field_29;
				if ((arg_0.field_22 & 1) == 1)
				{
					if (arg_0.prop_29 == Class_123.WinZipAes128 || arg_0.prop_29 == Class_123.WinZipAes256)
					{
						int sayıInt_ = Class_163.dmethod_666(arg_0.field_56);
						arg_0.field_8 = Class_157.lmethod_538(null, sayıInt_, arg_0.prop_41);
						num += arg_0.field_8.prop_3 - 10;
						arg_0.field_30 -= (long)arg_0.field_8.prop_3;
						arg_0.field_50 += 10;
					}
					else
					{
						arg_0.field_57 = new byte[12];
						num += Class_163.vmethod_705(arg_0.field_58, arg_0.field_57);
						arg_0.field_30 -= 12L;
					}
				}
				arg_0.field_49 = num;
				arg_0.field_48 = (long)arg_0.field_49 + arg_0.field_30 + (long)arg_0.field_50;
				return true;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		internal static int vmethod_705(Stream stream_, byte[] byteDizi_0)
		{
			int num = stream_.Read(byteDizi_0, 0, 12);
			if (num != 12)
			{
				throw new Class_135(string.Format("Unexpected end of data at position 0x{0:X8}", stream_.Position));
			}
			return num;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		private static bool dmethod_706(int sayıInt_0)
		{
			return sayıInt_0 != 67324752;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001CB00 File Offset: 0x0001AD00
		internal static Class_163 kmethod_707(Class_178 arg_0, bool bool_0)
		{
			Class_168 class_ = arg_0.prop_0;
			Stream stream = arg_0.prop_15;
			Encoding arg_ = arg_0.prop_12;
			Class_163 class_2 = new Class_163();
			class_2.field_54 = Class_166.ZipFile;
			class_2.field_43 = arg_0;
			class_2.field_58 = stream;
			if (class_ != null)
			{
				class_.lmethod_888(true, null);
			}
			if (bool_0)
			{
				Class_163.lmethod_708(stream);
			}
			if (!Class_163.cmethod_704(class_2, arg_))
			{
				return null;
			}
			class_2.field_44 = class_2.prop_41.Position;
			stream.Seek(class_2.field_30 + (long)class_2.field_50, SeekOrigin.Current);
			Class_163.pmethod_709(class_2);
			if (class_ != null)
			{
				class_.kmethod_887(class_2);
				class_.lmethod_888(false, class_2);
			}
			return class_2;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001CBA8 File Offset: 0x0001ADA8
		internal static void lmethod_708(Stream stream_)
		{
			uint num = (uint)Class_155.ReadInt(stream_);
			if (num != 808471376U)
			{
				stream_.Seek(-4L, SeekOrigin.Current);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		private static void pmethod_709(Class_163 arg_0)
		{
			Stream stream = arg_0.prop_41;
			uint num = (uint)Class_155.ReadInt(stream);
			if ((ulong)num != (ulong)((long)arg_0.field_34))
			{
				stream.Seek(-4L, SeekOrigin.Current);
				return;
			}
			int num2 = Class_155.ReadInt(stream);
			if ((long)num2 != arg_0.field_29)
			{
				stream.Seek(-8L, SeekOrigin.Current);
				return;
			}
			num2 = Class_155.ReadInt(stream);
			if ((long)num2 == arg_0.field_31)
			{
				return;
			}
			stream.Seek(-12L, SeekOrigin.Current);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001CC4C File Offset: 0x0001AE4C
		internal static int smethod_710(byte[] byteDizi_0, int sayıInt_0, ushort arg_0)
		{
			int num = sayıInt_0;
			while (num + 3 < byteDizi_0.Length)
			{
				ushort num2 = (ushort)((int)byteDizi_0[num++] + (int)byteDizi_0[num++] * 256);
				if (num2 == arg_0)
				{
					return num - 2;
				}
				short num3 = (short)((int)byteDizi_0[num++] + (int)byteDizi_0[num++] * 256);
				num += (int)num3;
			}
			return -1;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001CCA8 File Offset: 0x0001AEA8
		internal int xmethod_711(Stream stream_, short sayıShort_0)
		{
			int num = 0;
			if (sayıShort_0 > 0)
			{
				byte[] array = this.field_35 = new byte[(int)sayıShort_0];
				num = stream_.Read(array, 0, array.Length);
				long sayıUınt_ = stream_.Position - (long)num;
				int num2 = 0;
				while (num2 + 3 < array.Length)
				{
					int num3 = num2;
					ushort num4 = (ushort)((int)array[num2++] + (int)array[num2++] * 256);
					short num5 = (short)((int)array[num2++] + (int)array[num2++] * 256);
					ushort num6 = num4;
					if (num6 <= 21589)
					{
						if (num6 <= 10)
						{
							if (num6 != 1)
							{
								if (num6 == 10)
								{
									num2 = this.kmethod_717(array, num2, num5, sayıUınt_);
								}
							}
							else
							{
								num2 = this.cmethod_714(array, num2, num5, sayıUınt_);
							}
						}
						else if (num6 != 23)
						{
							if (num6 == 21589)
							{
								num2 = this.dmethod_716(array, num2, num5, sayıUınt_);
							}
						}
						else
						{
							num2 = this.tmethod_712(array, num2);
						}
					}
					else if (num6 <= 30805)
					{
						if (num6 != 22613)
						{
							if (num6 != 30805)
							{
							}
						}
						else
						{
							num2 = this.vmethod_715(array, num2, num5, sayıUınt_);
						}
					}
					else if (num6 != 30837)
					{
						if (num6 == 39169)
						{
							num2 = this.gmethod_713(array, num2, num5, sayıUınt_);
						}
					}
					num2 = num3 + (int)num5 + 4;
				}
			}
			return num;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001CE38 File Offset: 0x0001B038
		private int tmethod_712(byte[] byteDizi_0, int sayıInt_0)
		{
			sayıInt_0 += 2;
			this.field_52 = (uint)((ushort)((int)byteDizi_0[sayıInt_0++] + (int)byteDizi_0[sayıInt_0++] * 256));
			this.field_56 = (this.field_55 = Class_123.Unsupported);
			return sayıInt_0;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001CE7C File Offset: 0x0001B07C
		private int gmethod_713(byte[] byteDizi_0, int sayıInt_0, short sayıShort_0, long sayıUınt_0)
		{
			if (this.field_23 == 99)
			{
				if ((this.field_22 & 1) != 1)
				{
					throw new Class_137(string.Format("  Inconsistent metadata at position 0x{0:X16}", sayıUınt_0));
				}
				this.field_38 = true;
				if (sayıShort_0 != 7)
				{
					throw new Class_137(string.Format("  Inconsistent size (0x{0:X4}) in WinZip AES field at position 0x{1:X16}", sayıShort_0, sayıUınt_0));
				}
				this.field_10 = BitConverter.ToInt16(byteDizi_0, sayıInt_0);
				sayıInt_0 += 2;
				if (this.field_10 != 1 && this.field_10 != 2)
				{
					throw new Class_137(string.Format("  Unexpected vendor version number (0x{0:X4}) for WinZip AES metadata at position 0x{1:X16}", this.field_10, sayıUınt_0));
				}
				short num = BitConverter.ToInt16(byteDizi_0, sayıInt_0);
				sayıInt_0 += 2;
				if (num != 17729)
				{
					throw new Class_137(string.Format("  Unexpected vendor ID (0x{0:X4}) for WinZip AES metadata at position 0x{1:X16}", num, sayıUınt_0));
				}
				int num2 = (byteDizi_0[sayıInt_0] == 1) ? 128 : ((byteDizi_0[sayıInt_0] == 3) ? 256 : -1);
				if (num2 < 0)
				{
					throw new Class_137(string.Format("Invalid key strength ({0})", num2));
				}
				this.field_56 = (this.field_55 = ((num2 == 128) ? Class_123.WinZipAes128 : Class_123.WinZipAes256));
				sayıInt_0++;
				this.field_24 = (this.field_23 = BitConverter.ToInt16(byteDizi_0, sayıInt_0));
				sayıInt_0 += 2;
			}
			return sayıInt_0;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
		private int cmethod_714(byte[] byteDizi_0, int sayıInt_0, short sayıShort_0, long sayıUınt_0)
		{
			Class_163.NClass_2 nclass_ = new Class_163.NClass_2();
			nclass_.field_6 = byteDizi_0;
			nclass_.field_7 = sayıInt_0;
			nclass_.field_8 = sayıUınt_0;
			this.field_51 = true;
			if (sayıShort_0 > 28)
			{
				throw new Class_137(string.Format("  Inconsistent size (0x{0:X4}) for ZIP64 extra field at position 0x{1:X16}", sayıShort_0, nclass_.field_8));
			}
			nclass_.field_5 = (int)sayıShort_0;
			Class_163<long>.NClass_1 nclass_2 = new Class_163<long>.NClass_1(nclass_.nmethod_8);
			if (this.field_31 == (long)((ulong)-1))
			{
				this.field_31 = nclass_2.Invoke();
			}
			if (this.field_29 == (long)((ulong)-1))
			{
				this.field_29 = nclass_2.Invoke();
			}
			if (this.field_46 == (long)((ulong)-1))
			{
				this.field_46 = nclass_2.Invoke();
			}
			return nclass_.field_7;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		private int vmethod_715(byte[] byteDizi_0, int sayıInt_0, short sayıShort_0, long sayıUınt_0)
		{
			if (sayıShort_0 != 12 && sayıShort_0 != 8)
			{
				throw new Class_137(string.Format("  Unexpected size (0x{0:X4}) for InfoZip v1 extra field at position 0x{1:X16}", sayıShort_0, sayıUınt_0));
			}
			int num = BitConverter.ToInt32(byteDizi_0, sayıInt_0);
			this.field_12 = Class_163.field_68.AddSeconds((double)num);
			sayıInt_0 += 4;
			num = BitConverter.ToInt32(byteDizi_0, sayıInt_0);
			this.field_13 = Class_163.field_68.AddSeconds((double)num);
			sayıInt_0 += 4;
			this.field_14 = DateTime.UtcNow;
			this.field_15 = true;
			this.field_67 |= Class_164.InfoZip1;
			return sayıInt_0;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001D148 File Offset: 0x0001B348
		private int dmethod_716(byte[] byteDizi_0, int sayıInt_0, short sayıShort_0, long sayıUınt_0)
		{
			Class_163.NClass_3 nclass_ = new Class_163.NClass_3();
			nclass_.field_11 = byteDizi_0;
			nclass_.field_12 = sayıInt_0;
			nclass_.field_10 = this;
			if (sayıShort_0 != 13 && sayıShort_0 != 9 && sayıShort_0 != 5)
			{
				throw new Class_137(string.Format("  Unexpected size (0x{0:X4}) for Extended Timestamp extra field at position 0x{1:X16}", sayıShort_0, sayıUınt_0));
			}
			nclass_.field_9 = (int)sayıShort_0;
			Class_163<DateTime>.NClass_1 nclass_2 = new Class_163<DateTime>.NClass_1(nclass_.nmethod_10);
			if (sayıShort_0 == 13 || this.field_75 > 0)
			{
				byte b = nclass_.field_11[nclass_.field_12++];
				nclass_.field_9--;
				if ((b & 1) != 0 && nclass_.field_9 >= 4)
				{
					this.field_12 = nclass_2.Invoke();
				}
				this.field_13 = (((b & 2) != 0 && nclass_.field_9 >= 4) ? nclass_2.Invoke() : DateTime.UtcNow);
				this.field_14 = (((b & 4) != 0 && nclass_.field_9 >= 4) ? nclass_2.Invoke() : DateTime.UtcNow);
				this.field_67 |= Class_164.Unix;
				this.field_15 = true;
				this.field_17 = true;
			}
			else
			{
				this.gmethod_703();
			}
			return nclass_.field_12;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001D294 File Offset: 0x0001B494
		private int kmethod_717(byte[] byteDizi_0, int sayıInt_0, short sayıShort_0, long sayıUınt_0)
		{
			if (sayıShort_0 != 32)
			{
				throw new Class_137(string.Format("  Unexpected size (0x{0:X4}) for NTFS times extra field at position 0x{1:X16}", sayıShort_0, sayıUınt_0));
			}
			sayıInt_0 += 4;
			short num = (short)((int)byteDizi_0[sayıInt_0] + (int)byteDizi_0[sayıInt_0 + 1] * 256);
			short num2 = (short)((int)byteDizi_0[sayıInt_0 + 2] + (int)byteDizi_0[sayıInt_0 + 3] * 256);
			sayıInt_0 += 4;
			if (num == 1 && num2 == 24)
			{
				long fileTime = BitConverter.ToInt64(byteDizi_0, sayıInt_0);
				this.field_12 = DateTime.FromFileTimeUtc(fileTime);
				sayıInt_0 += 8;
				fileTime = BitConverter.ToInt64(byteDizi_0, sayıInt_0);
				this.field_13 = DateTime.FromFileTimeUtc(fileTime);
				sayıInt_0 += 8;
				fileTime = BitConverter.ToInt64(byteDizi_0, sayıInt_0);
				this.field_14 = DateTime.FromFileTimeUtc(fileTime);
				sayıInt_0 += 8;
				this.field_15 = true;
				this.field_67 |= Class_164.Windows;
				this.field_16 = true;
			}
			return sayıInt_0;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001D36C File Offset: 0x0001B56C
		internal void lmethod_718(Stream stream_)
		{
			byte[] array = new byte[4096];
			int num = 0;
			array[num++] = 80;
			array[num++] = 75;
			array[num++] = 1;
			array[num++] = 2;
			array[num++] = (byte)(this.field_0 & 255);
			array[num++] = (byte)(((int)this.field_0 & 65280) >> 8);
			short num2 = (this.prop_16 != 0) ? this.prop_16 : 20;
			if (this.field_65 == null)
			{
				this.field_65 = new bool?(this.field_43.prop_4 == Class_169.Always);
			}
			short num3 = this.field_65.Value ? 45 : num2;
			if (this.prop_21 == Class_165.BZip2)
			{
				num3 = 46;
			}
			array[num++] = (byte)(num3 & 255);
			array[num++] = (byte)(((int)num3 & 65280) >> 8);
			array[num++] = (byte)(this.field_22 & 255);
			array[num++] = (byte)(((int)this.field_22 & 65280) >> 8);
			array[num++] = (byte)(this.field_23 & 255);
			array[num++] = (byte)(((int)this.field_23 & 65280) >> 8);
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				num -= 2;
				array[num++] = 99;
				array[num++] = 0;
			}
			array[num++] = (byte)(this.field_32 & 255);
			array[num++] = (byte)((this.field_32 & 65280) >> 8);
			array[num++] = (byte)((this.field_32 & 16711680) >> 16);
			array[num++] = (byte)(((long)this.field_32 & (long)((ulong)-16777216)) >> 24);
			array[num++] = (byte)(this.field_34 & 255);
			array[num++] = (byte)((this.field_34 & 65280) >> 8);
			array[num++] = (byte)((this.field_34 & 16711680) >> 16);
			array[num++] = (byte)(((long)this.field_34 & (long)((ulong)-16777216)) >> 24);
			if (this.field_65.Value)
			{
				for (int i = 0; i < 8; i++)
				{
					array[num++] = byte.MaxValue;
				}
			}
			else
			{
				array[num++] = (byte)(this.field_29 & 255L);
				array[num++] = (byte)((this.field_29 & 65280L) >> 8);
				array[num++] = (byte)((this.field_29 & 16711680L) >> 16);
				array[num++] = (byte)((this.field_29 & (long)((ulong)-16777216)) >> 24);
				array[num++] = (byte)(this.field_31 & 255L);
				array[num++] = (byte)((this.field_31 & 65280L) >> 8);
				array[num++] = (byte)((this.field_31 & 16711680L) >> 16);
				array[num++] = (byte)((this.field_31 & (long)((ulong)-16777216)) >> 24);
			}
			byte[] array2 = this.xmethod_721();
			short num4 = (short)array2.Length;
			array[num++] = (byte)(num4 & 255);
			array[num++] = (byte)(((int)num4 & 65280) >> 8);
			this.field_63 = this.field_65.Value;
			this.field_35 = this.pmethod_719(true);
			short num5 = (short)((this.field_35 == null) ? 0 : this.field_35.Length);
			array[num++] = (byte)(num5 & 255);
			array[num++] = (byte)(((int)num5 & 65280) >> 8);
			int num6 = (this.field_28 == null) ? 0 : this.field_28.Length;
			if (num6 + num > array.Length)
			{
				num6 = array.Length - num;
			}
			array[num++] = (byte)(num6 & 255);
			array[num++] = (byte)((num6 & 65280) >> 8);
			bool flag = this.field_43.prop_0 != null && this.field_43.prop_0.prop_32 != 0;
			if (flag)
			{
				array[num++] = (byte)(this.field_40 & 255U);
				array[num++] = (byte)((this.field_40 & 65280U) >> 8);
			}
			else
			{
				array[num++] = 0;
				array[num++] = 0;
			}
			array[num++] = (this.field_66 ? 1 : 0);
			array[num++] = 0;
			array[num++] = (byte)(this.field_2 & 255);
			array[num++] = (byte)((this.field_2 & 65280) >> 8);
			array[num++] = (byte)((this.field_2 & 16711680) >> 16);
			array[num++] = (byte)(((long)this.field_2 & (long)((ulong)-16777216)) >> 24);
			if (this.field_46 > (long)((ulong)-1))
			{
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
			}
			else
			{
				array[num++] = (byte)(this.field_46 & 255L);
				array[num++] = (byte)((this.field_46 & 65280L) >> 8);
				array[num++] = (byte)((this.field_46 & 16711680L) >> 16);
				array[num++] = (byte)((this.field_46 & (long)((ulong)-16777216)) >> 24);
			}
			Buffer.BlockCopy(array2, 0, array, num, (int)num4);
			num += (int)num4;
			if (this.field_35 != null)
			{
				byte[] src = this.field_35;
				int srcOffset = 0;
				Buffer.BlockCopy(src, srcOffset, array, num, (int)num5);
				num += (int)num5;
			}
			if (num6 != 0)
			{
				Buffer.BlockCopy(this.field_28, 0, array, num, num6);
				num += num6;
			}
			stream_.Write(array, 0, num);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001D94C File Offset: 0x0001BB4C
		private byte[] pmethod_719(bool bool_0)
		{
			List<byte[]> list = new List<byte[]>();
			if (this.field_43.prop_4 == Class_169.Always || (this.field_43.prop_4 == Class_169.AsNecessary && (!bool_0 || this.field_64.Value)))
			{
				int num = 4 + (bool_0 ? 28 : 16);
				byte[] array = new byte[num];
				int num2 = 0;
				if (this.field_63 || bool_0)
				{
					array[num2++] = 1;
					array[num2++] = 0;
				}
				else
				{
					array[num2++] = 153;
					array[num2++] = 153;
				}
				array[num2++] = (byte)(num - 4);
				array[num2++] = 0;
				Array.Copy(BitConverter.GetBytes(this.field_31), 0, array, num2, 8);
				num2 += 8;
				Array.Copy(BitConverter.GetBytes(this.field_29), 0, array, num2, 8);
				num2 += 8;
				if (bool_0)
				{
					Array.Copy(BitConverter.GetBytes(this.field_46), 0, array, num2, 8);
					num2 += 8;
					Array.Copy(BitConverter.GetBytes(0), 0, array, num2, 4);
				}
				list.Add(array);
			}
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				byte[] array = new byte[11];
				int num3 = 0;
				array[num3++] = 1;
				array[num3++] = 153;
				array[num3++] = 7;
				array[num3++] = 0;
				array[num3++] = 1;
				array[num3++] = 0;
				array[num3++] = 65;
				array[num3++] = 69;
				int num4 = Class_163.dmethod_666(this.prop_29);
				if (num4 == 128)
				{
					array[num3] = 1;
				}
				else if (num4 == 256)
				{
					array[num3] = 3;
				}
				else
				{
					array[num3] = byte.MaxValue;
				}
				num3++;
				array[num3++] = (byte)(this.field_23 & 255);
				array[num3++] = (byte)((int)this.field_23 & 65280);
				list.Add(array);
			}
			if (this.field_15 && this.field_16)
			{
				byte[] array = new byte[36];
				int num5 = 0;
				array[num5++] = 10;
				array[num5++] = 0;
				array[num5++] = 32;
				array[num5++] = 0;
				num5 += 4;
				array[num5++] = 1;
				array[num5++] = 0;
				array[num5++] = 24;
				array[num5++] = 0;
				long value = this.field_12.ToFileTime();
				Array.Copy(BitConverter.GetBytes(value), 0, array, num5, 8);
				num5 += 8;
				value = this.field_13.ToFileTime();
				Array.Copy(BitConverter.GetBytes(value), 0, array, num5, 8);
				num5 += 8;
				value = this.field_14.ToFileTime();
				Array.Copy(BitConverter.GetBytes(value), 0, array, num5, 8);
				num5 += 8;
				list.Add(array);
			}
			if (this.field_15 && this.field_17)
			{
				int num6 = 9;
				if (!bool_0)
				{
					num6 += 8;
				}
				byte[] array = new byte[num6];
				int num7 = 0;
				array[num7++] = 85;
				array[num7++] = 84;
				array[num7++] = (byte)(num6 - 4);
				array[num7++] = 0;
				array[num7++] = 7;
				int value2 = (int)(this.field_12 - Class_163.field_68).TotalSeconds;
				Array.Copy(BitConverter.GetBytes(value2), 0, array, num7, 4);
				num7 += 4;
				if (!bool_0)
				{
					value2 = (int)(this.field_13 - Class_163.field_68).TotalSeconds;
					Array.Copy(BitConverter.GetBytes(value2), 0, array, num7, 4);
					num7 += 4;
					value2 = (int)(this.field_14 - Class_163.field_68).TotalSeconds;
					Array.Copy(BitConverter.GetBytes(value2), 0, array, num7, 4);
					num7 += 4;
				}
				list.Add(array);
			}
			byte[] array2 = null;
			if (list.Count > 0)
			{
				int num8 = 0;
				int num9 = 0;
				for (int i = 0; i < list.Count; i++)
				{
					num8 += list[i].Length;
				}
				array2 = new byte[num8];
				for (int i = 0; i < list.Count; i++)
				{
					Array.Copy(list[i], 0, array2, num9, list[i].Length);
					num9 += list[i].Length;
				}
			}
			return array2;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
		private string smethod_720()
		{
			string text = this.prop_12.Replace("\\", "/");
			string result;
			if (this.field_18 && this.prop_12.Length >= 3 && this.prop_12[1] == ':' && text[2] == '/')
			{
				result = text.Substring(3);
			}
			else if (this.prop_12.Length >= 4 && text[0] == '/' && text[1] == '/')
			{
				int num = text.IndexOf('/', 2);
				if (num == -1)
				{
					throw new ArgumentException("The path for that entry appears to be badly formatted");
				}
				result = text.Substring(num + 1);
			}
			else if (this.prop_12.Length >= 3 && text[0] == '.' && text[1] == '/')
			{
				result = text.Substring(2);
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		private byte[] xmethod_721()
		{
			string text = this.smethod_720();
			switch (this.prop_39)
			{
			case Class_170.Default:
				if (this.field_26 != null && this.field_26.Length != 0)
				{
					this.field_28 = Class_163.field_41.GetBytes(this.field_26);
				}
				this.field_42 = Class_163.field_41;
				return Class_163.field_41.GetBytes(text);
			case Class_170.Always:
				if (this.field_26 != null && this.field_26.Length != 0)
				{
					this.field_28 = this.prop_38.GetBytes(this.field_26);
				}
				this.field_42 = this.prop_38;
				return this.prop_38.GetBytes(text);
			}
			byte[] bytes = Class_163.field_41.GetBytes(text);
			string @string = Class_163.field_41.GetString(bytes, 0, bytes.Length);
			this.field_28 = null;
			if (@string != text)
			{
				bytes = this.prop_38.GetBytes(text);
				if (this.field_26 != null && this.field_26.Length != 0)
				{
					this.field_28 = this.prop_38.GetBytes(this.field_26);
				}
				this.field_42 = this.prop_38;
				return bytes;
			}
			this.field_42 = Class_163.field_41;
			if (this.field_26 == null || this.field_26.Length == 0)
			{
				return bytes;
			}
			byte[] bytes2 = Class_163.field_41.GetBytes(this.field_26);
			string string2 = Class_163.field_41.GetString(bytes2, 0, bytes2.Length);
			if (string2 != this.prop_17)
			{
				bytes = this.prop_38.GetBytes(text);
				this.field_28 = this.prop_38.GetBytes(this.field_26);
				this.field_42 = this.prop_38;
				return bytes;
			}
			this.field_28 = bytes2;
			return bytes;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		private bool tmethod_722()
		{
			return this.field_31 >= 16L && this.field_23 != 0 && this.prop_22 != Class_202.None && this.field_29 >= this.field_31 && (this.field_54 != Class_166.Stream || this.field_59.CanSeek) && (this.field_9 == null || this.prop_23 - (long)this.field_9.prop_3 > this.prop_24 + 16L) && (this.field_7 == null || this.prop_23 - 12L > this.prop_24);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001E180 File Offset: 0x0001C380
		private void gmethod_723(int sayıInt_0)
		{
			if (sayıInt_0 > 1)
			{
				this.field_23 = 0;
				return;
			}
			if (this.prop_27)
			{
				this.field_23 = 0;
				return;
			}
			if (this.field_54 == Class_166.ZipFile)
			{
				return;
			}
			if (this.field_54 == Class_166.Stream)
			{
				if (this.field_59 != null && this.field_59.CanSeek)
				{
					long length = this.field_59.Length;
					if (length == 0L)
					{
						this.field_23 = 0;
						return;
					}
				}
			}
			else if (this.field_54 == Class_166.FileSystem && Class_155.GetFileLength(this.prop_11) == 0L)
			{
				this.field_23 = 0;
				return;
			}
			if (this.prop_35 != null)
			{
				this.prop_22 = this.prop_35(this.prop_11, this.field_20);
			}
			if (this.prop_22 == Class_202.None && this.prop_21 == Class_165.Deflate)
			{
				this.field_23 = 0;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001E26C File Offset: 0x0001C46C
		internal void cmethod_724(Stream stream_, int sayıInt_0)
		{
			Class_156 class_ = stream_ as Class_156;
			this.field_47 = ((class_ != null) ? class_.prop_7 : stream_.Position);
			int num = 0;
			byte[] array = new byte[30];
			array[num++] = 80;
			array[num++] = 75;
			array[num++] = 3;
			array[num++] = 4;
			this.field_63 = (this.field_43.prop_4 == Class_169.Always || (this.field_43.prop_4 == Class_169.AsNecessary && !stream_.CanSeek));
			short num2 = this.field_63 ? 45 : 20;
			if (this.prop_21 == Class_165.BZip2)
			{
				num2 = 46;
			}
			array[num++] = (byte)(num2 & 255);
			array[num++] = (byte)(((int)num2 & 65280) >> 8);
			byte[] array2 = this.xmethod_721();
			short num3 = (short)array2.Length;
			if (this.field_55 == Class_123.None)
			{
				this.field_22 &= -2;
			}
			else
			{
				this.field_22 |= 1;
			}
			if (this.field_42.CodePage == Encoding.UTF8.CodePage)
			{
				this.field_22 |= 2048;
			}
			if (this.prop_27 || sayıInt_0 == 99)
			{
				this.field_22 &= -9;
				this.field_22 &= -2;
				this.prop_29 = Class_123.None;
				this.prop_30 = null;
			}
			else if (!stream_.CanSeek)
			{
				this.field_22 |= 8;
			}
			array[num++] = (byte)(this.field_22 & 255);
			array[num++] = (byte)(((int)this.field_22 & 65280) >> 8);
			if (this.field_44 == -1L)
			{
				this.field_29 = 0L;
				this.field_33 = false;
			}
			this.gmethod_723(sayıInt_0);
			array[num++] = (byte)(this.field_23 & 255);
			array[num++] = (byte)(((int)this.field_23 & 65280) >> 8);
			if (sayıInt_0 == 99)
			{
				this.gmethod_733();
			}
			else if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				num -= 2;
				array[num++] = 99;
				array[num++] = 0;
			}
			this.field_32 = Class_155.DateTimeToPacked(this.prop_2);
			array[num++] = (byte)(this.field_32 & 255);
			array[num++] = (byte)((this.field_32 & 65280) >> 8);
			array[num++] = (byte)((this.field_32 & 16711680) >> 16);
			array[num++] = (byte)(((long)this.field_32 & (long)((ulong)-16777216)) >> 24);
			array[num++] = (byte)(this.field_34 & 255);
			array[num++] = (byte)((this.field_34 & 65280) >> 8);
			array[num++] = (byte)((this.field_34 & 16711680) >> 16);
			array[num++] = (byte)(((long)this.field_34 & (long)((ulong)-16777216)) >> 24);
			if (this.field_63)
			{
				for (int i = 0; i < 8; i++)
				{
					array[num++] = byte.MaxValue;
				}
			}
			else
			{
				array[num++] = (byte)(this.field_29 & 255L);
				array[num++] = (byte)((this.field_29 & 65280L) >> 8);
				array[num++] = (byte)((this.field_29 & 16711680L) >> 16);
				array[num++] = (byte)((this.field_29 & (long)((ulong)-16777216)) >> 24);
				array[num++] = (byte)(this.field_31 & 255L);
				array[num++] = (byte)((this.field_31 & 65280L) >> 8);
				array[num++] = (byte)((this.field_31 & 16711680L) >> 16);
				array[num++] = (byte)((this.field_31 & (long)((ulong)-16777216)) >> 24);
			}
			array[num++] = (byte)(num3 & 255);
			array[num++] = (byte)(((int)num3 & 65280) >> 8);
			this.field_35 = this.pmethod_719(false);
			short num4 = (short)((this.field_35 == null) ? 0 : this.field_35.Length);
			array[num++] = (byte)(num4 & 255);
			array[num++] = (byte)(((int)num4 & 65280) >> 8);
			byte[] array3 = new byte[num + (int)num3 + (int)num4];
			Buffer.BlockCopy(array, 0, array3, 0, num);
			Buffer.BlockCopy(array2, 0, array3, num, array2.Length);
			num += array2.Length;
			if (this.field_35 != null)
			{
				Buffer.BlockCopy(this.field_35, 0, array3, num, this.field_35.Length);
				num += this.field_35.Length;
			}
			this.field_49 = num;
			Class_179 class_2 = stream_ as Class_179;
			if (class_2 != null)
			{
				class_2.prop_0 = true;
				uint num5 = class_2.dmethod_1096(num);
				if (num5 != class_2.prop_1)
				{
					this.field_47 = 0L;
				}
				else
				{
					this.field_47 = class_2.Position;
				}
				this.field_40 = num5;
			}
			if (this.field_43.prop_4 == Class_169.Default && (uint)this.field_46 >= 4294967295U)
			{
				throw new Class_135("Offset within the zip archive exceeds 0xFFFFFFFF. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			stream_.Write(array3, 0, num);
			if (class_2 != null)
			{
				class_2.prop_0 = false;
			}
			this.field_45 = array3;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		private int vmethod_725()
		{
			if (!this.field_33)
			{
				Stream stream = null;
				if (this.field_54 == Class_166.WriteDelegate)
				{
					Class_216 class_ = new Class_216(Stream.Null);
					this.field_71(this.prop_12, class_);
					this.field_34 = class_.prop_1;
				}
				else if (this.field_54 != Class_166.ZipFile)
				{
					if (this.field_54 == Class_166.Stream)
					{
						this.dmethod_726();
						stream = this.field_59;
					}
					else if (this.field_54 == Class_166.JitStream)
					{
						if (this.field_59 == null)
						{
							this.field_59 = this.field_72(this.prop_12);
						}
						this.dmethod_726();
						stream = this.field_59;
					}
					else if (this.field_54 != Class_166.ZipOutputStream)
					{
						stream = File.Open(this.prop_11, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					}
					Class_215 class_2 = new Class_215();
					this.field_34 = class_2.vmethod_1365(stream);
					if (this.field_59 == null)
					{
						stream.Dispose();
					}
				}
				this.field_33 = true;
			}
			return this.field_34;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001E8F4 File Offset: 0x0001CAF4
		private void dmethod_726()
		{
			if (this.field_59 == null)
			{
				throw new Class_135(string.Format("The input stream is null for entry '{0}'.", this.prop_12));
			}
			if (this.field_60 != null)
			{
				this.field_59.Position = this.field_60.Value;
				return;
			}
			if (this.field_59.CanSeek)
			{
				this.field_60 = new long?(this.field_59.Position);
				return;
			}
			if (this.prop_29 == Class_123.PkzipWeak && this.field_54 != Class_166.ZipFile && (this.field_22 & 8) != 8)
			{
				throw new Class_135("It is not possible to use PKZIP encryption on a non-seekable input stream");
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001E9A4 File Offset: 0x0001CBA4
		internal void kmethod_727(Class_163 arg_0)
		{
			this.field_44 = arg_0.field_44;
			this.prop_21 = arg_0.prop_21;
			this.field_24 = arg_0.field_24;
			this.field_30 = arg_0.field_30;
			this.field_31 = arg_0.field_31;
			this.field_22 = arg_0.field_22;
			this.field_54 = arg_0.field_54;
			this.field_11 = arg_0.field_11;
			this.field_12 = arg_0.field_12;
			this.field_13 = arg_0.field_13;
			this.field_14 = arg_0.field_14;
			this.field_15 = arg_0.field_15;
			this.field_17 = arg_0.field_17;
			this.field_16 = arg_0.field_16;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001EA59 File Offset: 0x0001CC59
		private void lmethod_728(long sayıUınt_0, long sayıUınt_1)
		{
			if (this.field_43.prop_0 != null)
			{
				this.field_62 = this.field_43.prop_0.lmethod_878(this, sayıUınt_0, sayıUınt_1);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001EA84 File Offset: 0x0001CC84
		private void pmethod_729(Stream stream_)
		{
			Stream stream = null;
			long num = -1L;
			try
			{
				num = stream_.Position;
			}
			catch (Exception)
			{
			}
			try
			{
				long num2 = this.smethod_730(ref stream);
				Class_156 class_ = new Class_156(stream_);
				Stream stream_2;
				Stream stream_3;
				if (num2 != 0L)
				{
					stream_2 = this.dmethod_736(class_);
					stream_3 = this.vmethod_735(stream_2, num2);
				}
				else
				{
					stream_3 = (stream_2 = class_);
				}
				Class_216 class_2 = new Class_216(stream_3, true);
				if (this.field_54 == Class_166.WriteDelegate)
				{
					this.field_71(this.prop_12, class_2);
				}
				else
				{
					byte[] array = new byte[this.prop_3];
					int count;
					while ((count = Class_155.ReadWithRetry(stream, array, 0, array.Length, this.prop_12)) != 0)
					{
						class_2.Write(array, 0, count);
						this.lmethod_728(class_2.prop_0, num2);
						if (this.field_62)
						{
							break;
						}
					}
				}
				this.xmethod_731(stream_, class_, stream_2, stream_3, class_2);
			}
			finally
			{
				if (this.field_54 == Class_166.JitStream)
				{
					if (this.field_73 != null)
					{
						this.field_73(this.prop_12, stream);
					}
				}
				else if (stream is FileStream)
				{
					stream.Dispose();
				}
			}
			if (this.field_62)
			{
				return;
			}
			this.field_44 = num;
			this.tmethod_732(stream_);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		private long smethod_730(ref Stream arg_0)
		{
			long result = -1L;
			if (this.field_54 == Class_166.Stream)
			{
				this.dmethod_726();
				arg_0 = this.field_59;
				try
				{
					return this.field_59.Length;
				}
				catch (NotSupportedException)
				{
					return result;
				}
			}
			if (this.field_54 == Class_166.ZipFile)
			{
				string str_ = (this.field_56 == Class_123.None) ? null : (this.field_53 ?? this.field_43.prop_3);
				this.field_59 = this.tmethod_682(str_);
				this.dmethod_726();
				arg_0 = this.field_59;
				result = this.field_59.Length;
			}
			else
			{
				if (this.field_54 == Class_166.JitStream)
				{
					if (this.field_59 == null)
					{
						this.field_59 = this.field_72(this.prop_12);
					}
					this.dmethod_726();
					arg_0 = this.field_59;
					try
					{
						return this.field_59.Length;
					}
					catch (NotSupportedException)
					{
						return result;
					}
				}
				if (this.field_54 == Class_166.FileSystem)
				{
					FileShare fileShare = FileShare.ReadWrite;
					fileShare |= FileShare.Delete;
					arg_0 = File.Open(this.prop_11, FileMode.Open, FileAccess.Read, fileShare);
					result = arg_0.Length;
				}
			}
			return result;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001ED28 File Offset: 0x0001CF28
		internal void xmethod_731(Stream stream_, Class_156 arg_0, Stream stream_, Stream stream_, Class_216 arg_1)
		{
			if (arg_1 == null)
			{
				return;
			}
			arg_1.Close();
			if (stream_ is Class_191)
			{
				stream_.Close();
			}
			else if (stream_ is Class_184)
			{
				stream_.Close();
			}
			else if (stream_ is Class_186)
			{
				stream_.Close();
			}
			else if (stream_ is Class_199)
			{
				stream_.Close();
			}
			stream_.Flush();
			stream_.Close();
			this.field_50 = 0;
			this.field_31 = arg_1.prop_0;
			Class_158 class_ = stream_ as Class_158;
			if (class_ != null && this.field_31 > 0L)
			{
				stream_.Write(class_.prop_0, 0, 10);
				this.field_50 += 10;
			}
			this.field_30 = arg_0.prop_1;
			this.field_29 = this.field_30;
			this.field_34 = arg_1.prop_1;
			this.pmethod_739();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001EE24 File Offset: 0x0001D024
		internal void tmethod_732(Stream stream_)
		{
			Class_156 class_ = stream_ as Class_156;
			if (this.field_31 == 0L && this.field_29 == 0L)
			{
				if (this.field_54 == Class_166.ZipOutputStream)
				{
					return;
				}
				if (this.field_53 != null)
				{
					int num = 0;
					if (this.prop_29 == Class_123.PkzipWeak)
					{
						num = 12;
					}
					else if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
					{
						num = this.field_9.field_0.Length + this.field_9.prop_0.Length;
					}
					if (this.field_54 == Class_166.ZipOutputStream && !stream_.CanSeek)
					{
						throw new Class_135("Zero bytes written, encryption in use, and non-seekable output.");
					}
					if (this.prop_29 != Class_123.None)
					{
						stream_.Seek((long)(-1 * num), SeekOrigin.Current);
						stream_.SetLength(stream_.Position);
						if (class_ != null)
						{
							class_.cmethod_524((long)num);
						}
						this.field_49 -= num;
						this.field_44 -= (long)num;
					}
					this.field_53 = null;
					this.field_22 &= -2;
					int num2 = 6;
					this.field_45[num2++] = (byte)(this.field_22 & 255);
					this.field_45[num2++] = (byte)(((int)this.field_22 & 65280) >> 8);
					if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
					{
						short num3 = (short)((int)this.field_45[26] + (int)this.field_45[27] * 256);
						int sayıInt_ = (int)(30 + num3);
						int num4 = Class_163.smethod_710(this.field_45, sayıInt_, 39169);
						if (num4 >= 0)
						{
							this.field_45[num4++] = 153;
							this.field_45[num4++] = 153;
						}
					}
				}
				this.prop_21 = Class_165.None;
				this.prop_29 = Class_123.None;
			}
			else if (this.field_7 != null || this.field_9 != null)
			{
				if (this.prop_29 == Class_123.PkzipWeak)
				{
					this.field_29 += 12L;
				}
				else if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
				{
					this.field_29 += (long)this.field_9.prop_3;
				}
			}
			int num5 = 8;
			this.field_45[num5++] = (byte)(this.field_23 & 255);
			this.field_45[num5++] = (byte)(((int)this.field_23 & 65280) >> 8);
			num5 = 14;
			this.field_45[num5++] = (byte)(this.field_34 & 255);
			this.field_45[num5++] = (byte)((this.field_34 & 65280) >> 8);
			this.field_45[num5++] = (byte)((this.field_34 & 16711680) >> 16);
			this.field_45[num5++] = (byte)(((long)this.field_34 & (long)((ulong)-16777216)) >> 24);
			this.gmethod_733();
			short num6 = (short)((int)this.field_45[26] + (int)this.field_45[27] * 256);
			short num7 = (short)((int)this.field_45[28] + (int)this.field_45[29] * 256);
			if (this.field_65.Value)
			{
				this.field_45[4] = 45;
				this.field_45[5] = 0;
				for (int i = 0; i < 8; i++)
				{
					this.field_45[num5++] = byte.MaxValue;
				}
				num5 = (int)(30 + num6);
				this.field_45[num5++] = 1;
				this.field_45[num5++] = 0;
				num5 += 2;
				Array.Copy(BitConverter.GetBytes(this.field_31), 0, this.field_45, num5, 8);
				num5 += 8;
				Array.Copy(BitConverter.GetBytes(this.field_29), 0, this.field_45, num5, 8);
			}
			else
			{
				this.field_45[4] = 20;
				this.field_45[5] = 0;
				num5 = 18;
				this.field_45[num5++] = (byte)(this.field_29 & 255L);
				this.field_45[num5++] = (byte)((this.field_29 & 65280L) >> 8);
				this.field_45[num5++] = (byte)((this.field_29 & 16711680L) >> 16);
				this.field_45[num5++] = (byte)((this.field_29 & (long)((ulong)-16777216)) >> 24);
				this.field_45[num5++] = (byte)(this.field_31 & 255L);
				this.field_45[num5++] = (byte)((this.field_31 & 65280L) >> 8);
				this.field_45[num5++] = (byte)((this.field_31 & 16711680L) >> 16);
				this.field_45[num5++] = (byte)((this.field_31 & (long)((ulong)-16777216)) >> 24);
				if (num7 != 0)
				{
					num5 = (int)(30 + num6);
					short num8 = (short)((int)this.field_45[num5 + 2] + (int)this.field_45[num5 + 3] * 256);
					if (num8 == 16)
					{
						this.field_45[num5++] = 153;
						this.field_45[num5++] = 153;
					}
				}
			}
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				num5 = 8;
				this.field_45[num5++] = 99;
				this.field_45[num5++] = 0;
				num5 = (int)(30 + num6);
				do
				{
					ushort num9 = (ushort)((int)this.field_45[num5] + (int)this.field_45[num5 + 1] * 256);
					short num10 = (short)((int)this.field_45[num5 + 2] + (int)this.field_45[num5 + 3] * 256);
					if (num9 != 39169)
					{
						num5 += (int)(num10 + 4);
					}
					else
					{
						num5 += 9;
						this.field_45[num5++] = (byte)(this.field_23 & 255);
						this.field_45[num5++] = (byte)((int)this.field_23 & 65280);
					}
				}
				while (num5 < (int)(num7 - 30 - num6));
			}
			if ((this.field_22 & 8) != 8 || (this.field_54 == Class_166.ZipOutputStream && stream_.CanSeek))
			{
				Class_179 class_2 = stream_ as Class_179;
				if (class_2 != null && this.field_40 != class_2.prop_1)
				{
					using (Stream stream = Class_179.lmethod_1088(this.field_43.prop_0.prop_8, this.field_40))
					{
						stream.Seek(this.field_46, SeekOrigin.Begin);
						stream.Write(this.field_45, 0, this.field_45.Length);
						goto IL_707;
					}
				}
				stream_.Seek(this.field_46, SeekOrigin.Begin);
				stream_.Write(this.field_45, 0, this.field_45.Length);
				if (class_ != null)
				{
					class_.cmethod_524((long)this.field_45.Length);
				}
				stream_.Seek(this.field_29, SeekOrigin.Current);
			}
			IL_707:
			if ((this.field_22 & 8) == 8 && !this.prop_27)
			{
				byte[] array = new byte[16 + (this.field_65.Value ? 8 : 0)];
				num5 = 0;
				Array.Copy(BitConverter.GetBytes(134695760), 0, array, num5, 4);
				num5 += 4;
				Array.Copy(BitConverter.GetBytes(this.field_34), 0, array, num5, 4);
				num5 += 4;
				if (this.field_65.Value)
				{
					Array.Copy(BitConverter.GetBytes(this.field_29), 0, array, num5, 8);
					num5 += 8;
					Array.Copy(BitConverter.GetBytes(this.field_31), 0, array, num5, 8);
					num5 += 8;
				}
				else
				{
					array[num5++] = (byte)(this.field_29 & 255L);
					array[num5++] = (byte)((this.field_29 & 65280L) >> 8);
					array[num5++] = (byte)((this.field_29 & 16711680L) >> 16);
					array[num5++] = (byte)((this.field_29 & (long)((ulong)-16777216)) >> 24);
					array[num5++] = (byte)(this.field_31 & 255L);
					array[num5++] = (byte)((this.field_31 & 65280L) >> 8);
					array[num5++] = (byte)((this.field_31 & 16711680L) >> 16);
					array[num5++] = (byte)((this.field_31 & (long)((ulong)-16777216)) >> 24);
				}
				stream_.Write(array, 0, array.Length);
				this.field_50 += array.Length;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		private void gmethod_733()
		{
			this.field_64 = new bool?(this.field_29 >= (long)((ulong)-1) || this.field_31 >= (long)((ulong)-1) || this.field_46 >= (long)((ulong)-1));
			if (this.field_43.prop_4 == Class_169.Default && this.field_64.Value)
			{
				throw new Class_135("Compressed or Uncompressed size, or offset exceeds the maximum value. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			this.field_65 = new bool?(this.field_43.prop_4 == Class_169.Always || this.field_64.Value);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001F798 File Offset: 0x0001D998
		internal void cmethod_734(Stream stream_, long sayıUınt_0, out Class_156 arg_0, out Stream arg_1, out Stream arg_2, out Class_216 arg_3)
		{
			arg_0 = new Class_156(stream_);
			if (sayıUınt_0 != 0L)
			{
				arg_1 = this.dmethod_736(arg_0);
				arg_2 = this.vmethod_735(arg_1, sayıUınt_0);
			}
			else
			{
				Stream stream;
				arg_2 = (stream = arg_0);
				arg_1 = stream;
			}
			arg_3 = new Class_216(arg_2, true);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001F7EC File Offset: 0x0001D9EC
		private Stream vmethod_735(Stream stream_, long sayıUınt_0)
		{
			if (this.field_23 == 8 && this.prop_22 != Class_202.None)
			{
				if (this.field_43.prop_7 == 0L || (sayıUınt_0 > this.field_43.prop_7 && this.field_43.prop_7 > 0L))
				{
					if (this.field_43.prop_6 == null)
					{
						this.field_43.prop_6 = new Class_199(stream_, this.prop_22, this.field_43.prop_10, true);
						if (this.field_43.prop_9 > 0)
						{
							this.field_43.prop_6.prop_2 = this.field_43.prop_9;
						}
						if (this.field_43.prop_8 > 0)
						{
							this.field_43.prop_6.prop_1 = this.field_43.prop_8;
						}
					}
					Class_199 class_ = this.field_43.prop_6;
					class_.pmethod_1299(stream_);
					return class_;
				}
				Class_191 class_2 = new Class_191(stream_, Class_204.Compress, this.prop_22, true);
				if (this.field_43.prop_9 > 0)
				{
					class_2.prop_1 = this.field_43.prop_9;
				}
				class_2.prop_2 = this.field_43.prop_10;
				return class_2;
			}
			else
			{
				if (this.field_23 != 12)
				{
					return stream_;
				}
				if (this.field_43.prop_7 == 0L || (sayıUınt_0 > this.field_43.prop_7 && this.field_43.prop_7 > 0L))
				{
					return new Class_186(stream_, true);
				}
				return new Class_184(stream_, true);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001F980 File Offset: 0x0001DB80
		private Stream dmethod_736(Stream stream_)
		{
			if (this.prop_29 == Class_123.PkzipWeak)
			{
				return new Class_162(stream_, this.field_7, Class_161.Encrypt);
			}
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				return new Class_158(stream_, this.field_9, Class_161.Encrypt);
			}
			return stream_;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001F9CE File Offset: 0x0001DBCE
		private void kmethod_737(Exception arg_0)
		{
			if (this.field_43.prop_0 != null)
			{
				this.field_62 = this.field_43.prop_0.vmethod_905(this, arg_0);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		internal void lmethod_738(Stream stream_)
		{
			Class_156 class_ = stream_ as Class_156;
			Class_179 class_2 = stream_ as Class_179;
			bool flag = false;
			do
			{
				try
				{
					if (this.field_54 == Class_166.ZipFile && !this.field_37)
					{
						this.tmethod_742(stream_);
						break;
					}
					if (this.prop_27)
					{
						this.cmethod_724(stream_, 1);
						this.pmethod_739();
						this.field_64 = new bool?(this.field_46 >= (long)((ulong)-1));
						this.field_65 = new bool?(this.field_43.prop_4 == Class_169.Always || this.field_64.Value);
						if (class_2 != null)
						{
							this.field_40 = class_2.prop_1;
						}
						break;
					}
					int num = 0;
					bool flag2;
					do
					{
						num++;
						this.cmethod_724(stream_, num);
						this.xmethod_741(stream_);
						this.pmethod_729(stream_);
						this.field_48 = (long)this.field_49 + this.field_30 + (long)this.field_50;
						flag2 = (num <= 1 && stream_.CanSeek && this.tmethod_722());
						if (flag2)
						{
							if (class_2 != null)
							{
								class_2.tmethod_1102(this.field_40, this.field_46);
							}
							else
							{
								stream_.Seek(this.field_46, SeekOrigin.Begin);
							}
							stream_.SetLength(stream_.Position);
							if (class_ != null)
							{
								class_.cmethod_524(this.field_48);
							}
						}
					}
					while (flag2);
					this.field_39 = false;
					flag = true;
				}
				catch (Exception ex)
				{
					Class_167 arg_ = this.prop_33;
					int num2 = 0;
					while (this.prop_33 != Class_167.Throw)
					{
						if (this.prop_33 == Class_167.Skip || this.prop_33 == Class_167.Retry)
						{
							long num3 = (class_ != null) ? class_.prop_7 : stream_.Position;
							long num4 = num3 - this.field_47;
							if (num4 > 0L)
							{
								stream_.Seek(num4, SeekOrigin.Current);
								long position = stream_.Position;
								stream_.SetLength(stream_.Position);
								if (class_ != null)
								{
									class_.cmethod_524(num3 - position);
								}
							}
							if (this.prop_33 == Class_167.Skip)
							{
								this.lmethod_688("Skipping file {0} (exception: {1})", new object[]
								{
									this.prop_11,
									ex.ToString()
								});
								this.field_39 = true;
								flag = true;
							}
							else
							{
								this.prop_33 = arg_;
							}
						}
						else
						{
							if (num2 > 0)
							{
								throw;
							}
							if (this.prop_33 == Class_167.InvokeErrorEvent)
							{
								this.kmethod_737(ex);
								if (this.field_62)
								{
									flag = true;
									goto IL_28C;
								}
							}
							num2++;
							continue;
						}
						IL_28C:
						goto IL_291;
					}
					throw;
				}
				IL_291:;
			}
			while (!flag);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
		internal void pmethod_739()
		{
			this.field_46 = this.field_47;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001FCC6 File Offset: 0x0001DEC6
		internal void smethod_740()
		{
			this.field_56 = this.field_55;
			this.field_24 = this.field_23;
			this.field_37 = false;
			this.field_36 = false;
			this.field_54 = Class_166.ZipFile;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		internal void xmethod_741(Stream stream_)
		{
			if (this.prop_29 == Class_123.None)
			{
				return;
			}
			string text = this.field_53;
			if (this.field_54 == Class_166.ZipFile && text == null)
			{
				text = this.field_43.prop_3;
			}
			if (text == null)
			{
				this.field_7 = null;
				this.field_9 = null;
				return;
			}
			if (this.prop_29 == Class_123.PkzipWeak)
			{
				this.field_7 = Class_160.pmethod_569(text);
				Random random = new Random();
				byte[] array = new byte[12];
				random.NextBytes(array);
				if ((this.field_22 & 8) == 8)
				{
					this.field_32 = Class_155.DateTimeToPacked(this.prop_2);
					array[11] = (byte)(this.field_32 >> 8 & 255);
				}
				else
				{
					this.vmethod_725();
					array[11] = (byte)(this.field_34 >> 24 & 255);
				}
				byte[] array2 = this.field_7.gmethod_573(array, array.Length);
				stream_.Write(array2, 0, array2.Length);
				this.field_49 += array2.Length;
				return;
			}
			if (this.prop_29 == Class_123.WinZipAes128 || this.prop_29 == Class_123.WinZipAes256)
			{
				int sayıInt_ = Class_163.dmethod_666(this.prop_29);
				this.field_9 = Class_157.kmethod_537(text, sayıInt_);
				stream_.Write(this.field_9.prop_1, 0, this.field_9.field_0.Length);
				stream_.Write(this.field_9.prop_0, 0, this.field_9.prop_0.Length);
				this.field_49 += this.field_9.field_0.Length + this.field_9.prop_0.Length;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001FE90 File Offset: 0x0001E090
		private void tmethod_742(Stream stream_)
		{
			if (this.prop_43 == 0)
			{
				throw new Class_140("Bad header length.");
			}
			bool flag = this.field_36 || this.prop_41 is Class_179 || stream_ is Class_179 || (this.field_51 && this.field_43.prop_11 == Class_169.Default) || (!this.field_51 && this.field_43.prop_11 == Class_169.Always);
			if (flag)
			{
				this.gmethod_743(stream_);
			}
			else
			{
				this.cmethod_744(stream_);
			}
			this.field_64 = new bool?(this.field_29 >= (long)((ulong)-1) || this.field_31 >= (long)((ulong)-1) || this.field_46 >= (long)((ulong)-1));
			this.field_65 = new bool?(this.field_43.prop_4 == Class_169.Always || this.field_64.Value);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001FF98 File Offset: 0x0001E198
		private void gmethod_743(Stream stream_)
		{
			byte[] array = new byte[this.prop_3];
			Class_156 class_ = new Class_156(this.prop_41);
			long num = this.field_46;
			int num2 = this.prop_43;
			this.cmethod_724(stream_, 0);
			this.pmethod_739();
			if (!this.prop_12.EndsWith("/"))
			{
				long num3 = num + (long)num2;
				int num4 = Class_163.kmethod_667(this.field_56);
				num3 -= (long)num4;
				this.field_49 += num4;
				class_.Seek(num3, SeekOrigin.Begin);
				long num5 = this.field_29;
				while (num5 > 0L)
				{
					num4 = ((num5 > (long)array.Length) ? array.Length : ((int)num5));
					int num6 = class_.Read(array, 0, num4);
					stream_.Write(array, 0, num6);
					num5 -= (long)num6;
					this.lmethod_728(class_.prop_2, this.field_29);
					if (this.field_62)
					{
						break;
					}
				}
				if ((this.field_22 & 8) == 8)
				{
					int num7 = 16;
					if (this.field_51)
					{
						num7 += 8;
					}
					byte[] buffer = new byte[num7];
					class_.Read(buffer, 0, num7);
					if (this.field_51 && this.field_43.prop_11 == Class_169.Default)
					{
						stream_.Write(buffer, 0, 8);
						if (this.field_29 > (long)((ulong)-1))
						{
							throw new InvalidOperationException("ZIP64 is required");
						}
						stream_.Write(buffer, 8, 4);
						if (this.field_31 > (long)((ulong)-1))
						{
							throw new InvalidOperationException("ZIP64 is required");
						}
						stream_.Write(buffer, 16, 4);
						this.field_50 -= 8;
					}
					else if (!this.field_51 && this.field_43.prop_11 == Class_169.Always)
					{
						byte[] buffer2 = new byte[4];
						stream_.Write(buffer, 0, 8);
						stream_.Write(buffer, 8, 4);
						stream_.Write(buffer2, 0, 4);
						stream_.Write(buffer, 12, 4);
						stream_.Write(buffer2, 0, 4);
						this.field_50 += 8;
					}
					else
					{
						stream_.Write(buffer, 0, num7);
					}
				}
			}
			this.field_48 = (long)this.field_49 + this.field_30 + (long)this.field_50;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000201D0 File Offset: 0x0001E3D0
		private void cmethod_744(Stream stream_)
		{
			byte[] array = new byte[this.prop_3];
			Class_156 class_ = new Class_156(this.prop_41);
			class_.Seek(this.field_46, SeekOrigin.Begin);
			if (this.field_48 == 0L)
			{
				this.field_48 = (long)this.field_49 + this.field_30 + (long)this.field_50;
			}
			Class_156 class_2 = stream_ as Class_156;
			this.field_46 = ((class_2 != null) ? class_2.prop_7 : stream_.Position);
			long num = this.field_48;
			while (num > 0L)
			{
				int count = (num > (long)array.Length) ? array.Length : ((int)num);
				int num2 = class_.Read(array, 0, count);
				stream_.Write(array, 0, num2);
				num -= (long)num2;
				this.lmethod_728(class_.prop_2, this.field_48);
				if (this.field_62)
				{
					return;
				}
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000202B4 File Offset: 0x0001E4B4
		[Conditional("Trace")]
		private void vmethod_745(string str_0, params object[] arg_0)
		{
			lock (this.field_76)
			{
				int hashCode = Thread.CurrentThread.GetHashCode();
				Console.ForegroundColor = hashCode % 8 + ConsoleColor.DarkGray;
				Console.Write("{0:000} ZipEntry.Write ", hashCode);
				Console.WriteLine(str_0, arg_0);
				Console.ResetColor();
			}
		}

		// Token: 0x04000288 RID: 648
		private short field_0;

		// Token: 0x04000289 RID: 649
		private short field_1;

		// Token: 0x0400028A RID: 650
		private int field_2;

		// Token: 0x0400028B RID: 651
		private short field_3;

		// Token: 0x0400028C RID: 652
		private short field_4;

		// Token: 0x0400028D RID: 653
		private short field_5;

		// Token: 0x0400028E RID: 654
		private Class_160 field_6;

		// Token: 0x0400028F RID: 655
		private Class_160 field_7;

		// Token: 0x04000290 RID: 656
		private Class_157 field_8;

		// Token: 0x04000291 RID: 657
		private Class_157 field_9;

		// Token: 0x04000292 RID: 658
		private short field_10;

		// Token: 0x04000293 RID: 659
		internal DateTime field_11;

		// Token: 0x04000294 RID: 660
		private DateTime field_12;

		// Token: 0x04000295 RID: 661
		private DateTime field_13;

		// Token: 0x04000296 RID: 662
		private DateTime field_14;

		// Token: 0x04000297 RID: 663
		private bool field_15;

		// Token: 0x04000298 RID: 664
		private bool field_16 = true;

		// Token: 0x04000299 RID: 665
		private bool field_17;

		// Token: 0x0400029A RID: 666
		private bool field_18 = true;

		// Token: 0x0400029B RID: 667
		internal string field_19;

		// Token: 0x0400029C RID: 668
		private string field_20;

		// Token: 0x0400029D RID: 669
		internal short field_21;

		// Token: 0x0400029E RID: 670
		internal short field_22;

		// Token: 0x0400029F RID: 671
		internal short field_23;

		// Token: 0x040002A0 RID: 672
		private short field_24;

		// Token: 0x040002A1 RID: 673
		private Class_202 field_25;

		// Token: 0x040002A2 RID: 674
		internal string field_26;

		// Token: 0x040002A3 RID: 675
		private bool field_27;

		// Token: 0x040002A4 RID: 676
		private byte[] field_28;

		// Token: 0x040002A5 RID: 677
		internal long field_29;

		// Token: 0x040002A6 RID: 678
		internal long field_30;

		// Token: 0x040002A7 RID: 679
		internal long field_31;

		// Token: 0x040002A8 RID: 680
		internal int field_32;

		// Token: 0x040002A9 RID: 681
		private bool field_33;

		// Token: 0x040002AA RID: 682
		internal int field_34;

		// Token: 0x040002AB RID: 683
		internal byte[] field_35;

		// Token: 0x040002AC RID: 684
		private bool field_36;

		// Token: 0x040002AD RID: 685
		private bool field_37;

		// Token: 0x040002AE RID: 686
		private bool field_38;

		// Token: 0x040002AF RID: 687
		private bool field_39;

		// Token: 0x040002B0 RID: 688
		private uint field_40;

		// Token: 0x040002B1 RID: 689
		private static Encoding field_41 = Encoding.GetEncoding("IBM437");

		// Token: 0x040002B2 RID: 690
		private Encoding field_42;

		// Token: 0x040002B3 RID: 691
		internal Class_178 field_43;

		// Token: 0x040002B4 RID: 692
		private long field_44 = -1L;

		// Token: 0x040002B5 RID: 693
		private byte[] field_45;

		// Token: 0x040002B6 RID: 694
		internal long field_46;

		// Token: 0x040002B7 RID: 695
		private long field_47;

		// Token: 0x040002B8 RID: 696
		private long field_48;

		// Token: 0x040002B9 RID: 697
		private int field_49;

		// Token: 0x040002BA RID: 698
		private int field_50;

		// Token: 0x040002BB RID: 699
		internal bool field_51;

		// Token: 0x040002BC RID: 700
		private uint field_52;

		// Token: 0x040002BD RID: 701
		internal string field_53;

		// Token: 0x040002BE RID: 702
		internal Class_166 field_54;

		// Token: 0x040002BF RID: 703
		internal Class_123 field_55;

		// Token: 0x040002C0 RID: 704
		internal Class_123 field_56;

		// Token: 0x040002C1 RID: 705
		internal byte[] field_57;

		// Token: 0x040002C2 RID: 706
		internal Stream field_58;

		// Token: 0x040002C3 RID: 707
		private Stream field_59;

		// Token: 0x040002C4 RID: 708
		private long? field_60;

		// Token: 0x040002C5 RID: 709
		private bool field_61;

		// Token: 0x040002C6 RID: 710
		private bool field_62;

		// Token: 0x040002C7 RID: 711
		private bool field_63;

		// Token: 0x040002C8 RID: 712
		private bool? field_64;

		// Token: 0x040002C9 RID: 713
		private bool? field_65;

		// Token: 0x040002CA RID: 714
		private bool field_66;

		// Token: 0x040002CB RID: 715
		private Class_164 field_67;

		// Token: 0x040002CC RID: 716
		private static DateTime field_68 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x040002CD RID: 717
		private static DateTime field_69 = DateTime.FromFileTimeUtc(0L);

		// Token: 0x040002CE RID: 718
		private static DateTime field_70 = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		// Token: 0x040002CF RID: 719
		private Class_124 field_71;

		// Token: 0x040002D0 RID: 720
		private Class_125 field_72;

		// Token: 0x040002D1 RID: 721
		private Class_126 field_73;

		// Token: 0x040002D2 RID: 722
		private Stream field_74;

		// Token: 0x040002D3 RID: 723
		private int field_75;

		// Token: 0x040002D4 RID: 724
		private object field_76 = new object();

		// Token: 0x040002D5 RID: 725
		[CompilerGenerated]
		private Class_141 field_77;

		// Token: 0x040002D6 RID: 726
		[CompilerGenerated]
		private Class_167 field_78;

		// Token: 0x040002D7 RID: 727
		[CompilerGenerated]
		private Class_127 field_79;

		// Token: 0x040002D8 RID: 728
		[CompilerGenerated]
		private Encoding field_80;

		// Token: 0x040002D9 RID: 729
		[CompilerGenerated]
		private Encoding field_81;

		// Token: 0x040002DA RID: 730
		[CompilerGenerated]
		private Class_170 field_82;

		// Token: 0x020000CD RID: 205
		private class NClass_0
		{
			// Token: 0x0600049F RID: 1183 RVA: 0x0002036C File Offset: 0x0001E56C
			internal static string nmethod_0(string str_0)
			{
				Class_163.NClass_0.field_4++;
				if (Class_163.NClass_0.field_4 > 25)
				{
					throw new OverflowException("overflow while creating filename");
				}
				int num = 1;
				int num2 = str_0.LastIndexOf(".");
				if (num2 == -1)
				{
					Match match = Class_163.NClass_0.field_3.Match(str_0);
					if (match.Success)
					{
						num = int.Parse(match.Groups[1].Value) + 1;
						string str = string.Format(" (copy {0})", num);
						str_0 = str_0.Substring(0, match.Index) + str;
					}
					else
					{
						string str2 = string.Format(" (copy {0})", num);
						str_0 += str2;
					}
				}
				else
				{
					Match match2 = Class_163.NClass_0.field_3.Match(str_0.Substring(0, num2));
					if (match2.Success)
					{
						num = int.Parse(match2.Groups[1].Value) + 1;
						string str3 = string.Format(" (copy {0})", num);
						str_0 = str_0.Substring(0, match2.Index) + str3 + str_0.Substring(num2);
					}
					else
					{
						string str4 = string.Format(" (copy {0})", num);
						str_0 = str_0.Substring(0, num2) + str4 + str_0.Substring(num2);
					}
				}
				return str_0;
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x000204C7 File Offset: 0x0001E6C7
			private static void nmethod_2()
			{
				Class_163.NClass_0.field_3 = new Regex(" \\(copy (\\d+)\\)$");
				Class_163.NClass_0.field_4 = 0;
			}

			// Token: 0x040002DB RID: 731
			private static Regex field_3;

			// Token: 0x040002DC RID: 732
			private static int field_4;
		}

		// Token: 0x020000CE RID: 206
		private delegate NClass_1<T>();

		// Token: 0x020000CF RID: 207
		[CompilerGenerated]
		private sealed class NClass_2
		{
			// Token: 0x060004A6 RID: 1190 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_7()
			{
				base..ctor();
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x000204E0 File Offset: 0x0001E6E0
			public long nmethod_8()
			{
				if (this.field_5 < 8)
				{
					throw new Class_137(string.Format("  Missing data for ZIP64 extra field, position 0x{0:X16}", this.field_8));
				}
				long result = BitConverter.ToInt64(this.field_6, this.field_7);
				this.field_7 += 8;
				this.field_5 -= 8;
				return result;
			}

			// Token: 0x040002DD RID: 733
			public int field_5;

			// Token: 0x040002DE RID: 734
			public byte[] field_6;

			// Token: 0x040002DF RID: 735
			public int field_7;

			// Token: 0x040002E0 RID: 736
			public long field_8;
		}

		// Token: 0x020000D0 RID: 208
		[CompilerGenerated]
		private sealed class NClass_3
		{
			// Token: 0x060004A8 RID: 1192 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_9()
			{
				base..ctor();
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x00020544 File Offset: 0x0001E744
			public DateTime nmethod_10()
			{
				int num = BitConverter.ToInt32(this.field_11, this.field_12);
				this.field_12 += 4;
				this.field_9 -= 4;
				return Class_163.field_68.AddSeconds((double)num);
			}

			// Token: 0x040002E1 RID: 737
			public int field_9;

			// Token: 0x040002E2 RID: 738
			public Class_163 field_10;

			// Token: 0x040002E3 RID: 739
			public byte[] field_11;

			// Token: 0x040002E4 RID: 740
			public int field_12;
		}
	}
}
