using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x020000BF RID: 191
	[ComVisible(true)]
	public class Class_152
	{
		// Token: 0x0600037F RID: 895 RVA: 0x0001739E File Offset: 0x0001559E
		public Class_152(string str_0) : this(str_0, true)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000173A8 File Offset: 0x000155A8
		public Class_152(string str_0, bool bool_0)
		{
			if (!string.IsNullOrEmpty(str_0))
			{
				this.field_0 = Class_152.pmethod_499(str_0);
			}
			this.prop_1 = bool_0;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000173CE File Offset: 0x000155CE
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000173E8 File Offset: 0x000155E8
		public string prop_0
		{
			get
			{
				if (this.field_0 == null)
				{
					return null;
				}
				return this.field_0.ToString();
			}
			set
			{
				if (value == null)
				{
					this.field_0 = null;
					return;
				}
				if (value.Trim() == "")
				{
					this.field_0 = null;
					return;
				}
				this.field_0 = Class_152.pmethod_499(value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00017421 File Offset: 0x00015621
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00017429 File Offset: 0x00015629
		public bool prop_1 { get; set; }

		// Token: 0x06000385 RID: 901 RVA: 0x00017434 File Offset: 0x00015634
		private static string lmethod_498(string str_0)
		{
			string[][] array = new string[][]
			{
				new string[]
				{
					"([^']*)\\(\\(([^']+)",
					"$1( ($2"
				},
				new string[]
				{
					"(.)\\)\\)",
					"$1) )"
				},
				new string[]
				{
					"\\((\\S)",
					"( $1"
				},
				new string[]
				{
					"(\\S)\\)",
					"$1 )"
				},
				new string[]
				{
					"^\\)",
					" )"
				},
				new string[]
				{
					"(\\S)\\(",
					"$1 ("
				},
				new string[]
				{
					"\\)(\\S)",
					") $1"
				},
				new string[]
				{
					"(=)('[^']*')",
					"$1 $2"
				},
				new string[]
				{
					"([^ !><])(>|<|!=|=)",
					"$1 $2"
				},
				new string[]
				{
					"(>|<|!=|=)([^ =])",
					"$1 $2"
				},
				new string[]
				{
					"/",
					"\\"
				}
			};
			string input = str_0;
			for (int i = 0; i < array.Length; i++)
			{
				string pattern = Class_152.NClass_1.field_11 + array[i][0] + Class_152.NClass_1.field_12;
				input = Regex.Replace(input, pattern, array[i][1]);
			}
			string pattern2 = "/" + Class_152.NClass_1.field_10;
			input = Regex.Replace(input, pattern2, "\\");
			pattern2 = " " + Class_152.NClass_1.field_10;
			return Regex.Replace(input, pattern2, "\u0006");
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00017684 File Offset: 0x00015884
		private static Class_145 pmethod_499(string str_0)
		{
			if (str_0 == null)
			{
				return null;
			}
			str_0 = Class_152.lmethod_498(str_0);
			if (str_0.IndexOf(" ") == -1)
			{
				str_0 = "name = " + str_0;
			}
			string[] array = str_0.Trim().Split(new char[]
			{
				' ',
				'\t'
			});
			if (array.Length < 3)
			{
				throw new ArgumentException(str_0);
			}
			Class_145 class_ = null;
			Stack<Class_152.NClass_0> stack = new Stack<Class_152.NClass_0>();
			Stack<Class_145> stack2 = new Stack<Class_145>();
			stack.Push(Class_152.NClass_0.field_4);
			int i = 0;
			while (i < array.Length)
			{
				string text = array[i].ToLower();
				string key;
				if ((key = text) != null)
				{
					if (Class_217.field_0 == null)
					{
						Class_217.field_0 = new Dictionary<string, int>(16)
						{
							{
								"and",
								0
							},
							{
								"xor",
								1
							},
							{
								"or",
								2
							},
							{
								"(",
								3
							},
							{
								")",
								4
							},
							{
								"atime",
								5
							},
							{
								"ctime",
								6
							},
							{
								"mtime",
								7
							},
							{
								"length",
								8
							},
							{
								"size",
								9
							},
							{
								"filename",
								10
							},
							{
								"name",
								11
							},
							{
								"attrs",
								12
							},
							{
								"attributes",
								13
							},
							{
								"type",
								14
							},
							{
								"",
								15
							}
						};
					}
					int num;
					if (Class_217.field_0.TryGetValue(key, out num))
					{
						Class_152.NClass_0 nclass_;
						switch (num)
						{
						case 0:
						case 1:
						case 2:
						{
							nclass_ = stack.Peek();
							if (nclass_ != Class_152.NClass_0.field_6)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							if (array.Length <= i + 3)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							Class_142 class_2 = (Class_142)Enum.Parse(typeof(Class_142), array[i].ToUpper(), true);
							class_ = new Class_151
							{
								field_1 = class_,
								prop_0 = null,
								field_0 = class_2
							};
							stack.Push(nclass_);
							stack.Push(Class_152.NClass_0.field_7);
							stack2.Push(class_);
							break;
						}
						case 3:
							nclass_ = stack.Peek();
							if (nclass_ != Class_152.NClass_0.field_4 && nclass_ != Class_152.NClass_0.field_7 && nclass_ != Class_152.NClass_0.field_5)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							if (array.Length <= i + 4)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Push(Class_152.NClass_0.field_5);
							break;
						case 4:
							nclass_ = stack.Pop();
							if (stack.Peek() != Class_152.NClass_0.field_5)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Pop();
							stack.Push(Class_152.NClass_0.field_6);
							break;
						case 5:
						case 6:
						case 7:
						{
							if (array.Length <= i + 2)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							DateTime dateTime;
							try
							{
								dateTime = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd-HH:mm:ss", null);
							}
							catch (FormatException)
							{
								try
								{
									dateTime = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd-HH:mm:ss", null);
								}
								catch (FormatException)
								{
									try
									{
										dateTime = DateTime.ParseExact(array[i + 2], "yyyy/MM/dd", null);
									}
									catch (FormatException)
									{
										try
										{
											dateTime = DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
										}
										catch (FormatException)
										{
											dateTime = DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
										}
									}
								}
							}
							dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local).ToUniversalTime();
							class_ = new Class_147
							{
								field_1 = (Class_143)Enum.Parse(typeof(Class_143), array[i], true),
								field_0 = (Class_144)Class_153.Parse(typeof(Class_144), array[i + 1]),
								field_2 = dateTime
							};
							i += 2;
							stack.Push(Class_152.NClass_0.field_6);
							break;
						}
						case 8:
						case 9:
						{
							if (array.Length <= i + 2)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							string text2 = array[i + 2];
							long num2;
							if (text2.ToUpper().EndsWith("K"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L;
							}
							else if (text2.ToUpper().EndsWith("KB"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L;
							}
							else if (text2.ToUpper().EndsWith("M"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L;
							}
							else if (text2.ToUpper().EndsWith("MB"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L;
							}
							else if (text2.ToUpper().EndsWith("G"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L * 1024L;
							}
							else if (text2.ToUpper().EndsWith("GB"))
							{
								num2 = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L * 1024L;
							}
							else
							{
								num2 = long.Parse(array[i + 2]);
							}
							class_ = new Class_146
							{
								field_1 = num2,
								field_0 = (Class_144)Class_153.Parse(typeof(Class_144), array[i + 1])
							};
							i += 2;
							stack.Push(Class_152.NClass_0.field_6);
							break;
						}
						case 10:
						case 11:
						{
							if (array.Length <= i + 2)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							Class_144 class_3 = (Class_144)Class_153.Parse(typeof(Class_144), array[i + 1]);
							if (class_3 != Class_144.NotEqualTo && class_3 != Class_144.EqualTo)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							string text3 = array[i + 2];
							if (text3.StartsWith("'") && text3.EndsWith("'"))
							{
								text3 = text3.Substring(1, text3.Length - 2).Replace("\u0006", " ");
							}
							class_ = new Class_148
							{
								prop_0 = text3,
								field_2 = class_3
							};
							i += 2;
							stack.Push(Class_152.NClass_0.field_6);
							break;
						}
						case 12:
						case 13:
						case 14:
						{
							if (array.Length <= i + 2)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							Class_144 class_4 = (Class_144)Class_153.Parse(typeof(Class_144), array[i + 1]);
							if (class_4 != Class_144.NotEqualTo && class_4 != Class_144.EqualTo)
							{
								throw new ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							class_ = ((text == "type") ? new Class_149
							{
								prop_0 = array[i + 2],
								field_1 = class_4
							} : new Class_150
							{
								prop_0 = array[i + 2],
								field_1 = class_4
							});
							i += 2;
							stack.Push(Class_152.NClass_0.field_6);
							break;
						}
						case 15:
							stack.Push(Class_152.NClass_0.field_8);
							break;
						default:
							goto IL_86F;
						}
						nclass_ = stack.Peek();
						if (nclass_ == Class_152.NClass_0.field_6)
						{
							stack.Pop();
							if (stack.Peek() == Class_152.NClass_0.field_7)
							{
								while (stack.Peek() == Class_152.NClass_0.field_7)
								{
									Class_151 class_5 = stack2.Pop() as Class_151;
									class_5.prop_0 = class_;
									class_ = class_5;
									stack.Pop();
									nclass_ = stack.Pop();
									if (nclass_ != Class_152.NClass_0.field_6)
									{
										throw new ArgumentException("??");
									}
								}
							}
							else
							{
								stack.Push(Class_152.NClass_0.field_6);
							}
						}
						if (nclass_ == Class_152.NClass_0.field_8)
						{
							stack.Pop();
						}
						i++;
						continue;
					}
				}
				IL_86F:
				throw new ArgumentException("'" + array[i] + "'");
			}
			return class_;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00017FF4 File Offset: 0x000161F4
		public virtual string smethod_500()
		{
			return "FileSelector(" + this.field_0.ToString() + ")";
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00018010 File Offset: 0x00016210
		private bool xmethod_501(string str_0)
		{
			return this.field_0.xmethod_461(str_0);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001802B File Offset: 0x0001622B
		[Conditional("SelectorTrace")]
		private void tmethod_502(string str_0, params object[] arg_0)
		{
			if (this.field_0 != null && this.field_0.prop_0)
			{
				Console.WriteLine(str_0, arg_0);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0001804F File Offset: 0x0001624F
		public ICollection<string> gmethod_503(string str_0)
		{
			return this.cmethod_504(str_0, false);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001805C File Offset: 0x0001625C
		public ReadOnlyCollection<string> cmethod_504(string str_0, bool bool_0)
		{
			if (this.field_0 == null)
			{
				throw new ArgumentException("SelectionCriteria has not been set");
			}
			List<string> list = new List<string>();
			try
			{
				if (Directory.Exists(str_0))
				{
					string[] files = Directory.GetFiles(str_0);
					foreach (string text in files)
					{
						if (this.xmethod_501(text))
						{
							list.Add(text);
						}
					}
					if (bool_0)
					{
						string[] directories = Directory.GetDirectories(str_0);
						foreach (string text2 in directories)
						{
							if (this.prop_1 || (File.GetAttributes(text2) & FileAttributes.ReparsePoint) == (FileAttributes)0)
							{
								if (this.xmethod_501(text2))
								{
									list.Add(text2);
								}
								list.AddRange(this.cmethod_504(text2, bool_0));
							}
						}
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (IOException)
			{
			}
			return list.AsReadOnly();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00018170 File Offset: 0x00016370
		private bool vmethod_505(Class_163 arg_0)
		{
			return this.field_0.gmethod_463(arg_0);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001818C File Offset: 0x0001638C
		public ICollection<Class_163> dmethod_506(Class_168 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("zip");
			}
			List<Class_163> list = new List<Class_163>();
			using (IEnumerator<Class_163> enumerator = arg_0.dmethod_956())
			{
				while (enumerator.MoveNext())
				{
					Class_163 class_ = enumerator.Current;
					if (this.vmethod_505(class_))
					{
						list.Add(class_);
					}
				}
			}
			return list;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00018204 File Offset: 0x00016404
		public ICollection<Class_163> kmethod_507(Class_168 arg_0, string str_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("zip");
			}
			List<Class_163> list = new List<Class_163>();
			string text = (str_0 == null) ? null : str_0.Replace("/", "\\");
			if (text != null)
			{
				while (text.EndsWith("\\"))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			using (IEnumerator<Class_163> enumerator = arg_0.dmethod_956())
			{
				while (enumerator.MoveNext())
				{
					Class_163 class_ = enumerator.Current;
					if ((str_0 == null || Path.GetDirectoryName(class_.prop_12) == str_0 || Path.GetDirectoryName(class_.prop_12) == text) && this.vmethod_505(class_))
					{
						list.Add(class_);
					}
				}
			}
			return list;
		}

		// Token: 0x04000240 RID: 576
		internal Class_145 field_0;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private bool field_1;

		// Token: 0x020000C0 RID: 192
		private enum NClass_0
		{
			// Token: 0x04000243 RID: 579
			field_4,
			// Token: 0x04000244 RID: 580
			field_5,
			// Token: 0x04000245 RID: 581
			field_6,
			// Token: 0x04000246 RID: 582
			field_7,
			// Token: 0x04000247 RID: 583
			field_8
		}

		// Token: 0x020000C1 RID: 193
		private static class NClass_1
		{
			// Token: 0x0600038F RID: 911 RVA: 0x000182F0 File Offset: 0x000164F0
			private static void nmethod_0()
			{
				Class_152.NClass_1.field_9 = "(?<=(?:[^']*'[^']*')*'[^']*)";
				Class_152.NClass_1.field_10 = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";
				Class_152.NClass_1.field_11 = "(?<=(?:[^']*'[^']*')*[^']*)";
				Class_152.NClass_1.field_12 = "(?=(?:[^']*'[^']*')*[^']*$)";
			}

			// Token: 0x04000248 RID: 584
			public static readonly string field_9;

			// Token: 0x04000249 RID: 585
			public static readonly string field_10;

			// Token: 0x0400024A RID: 586
			public static readonly string field_11;

			// Token: 0x0400024B RID: 587
			public static readonly string field_12;
		}
	}
}
