using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zlib;
using Microsoft.CSharp;

namespace Ionic.Zip
{
	// Token: 0x020000D5 RID: 213
	[DefaultMember("Item")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	public class Class_168 : IEnumerable, IDisposable, IEnumerable<Class_163>
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0002058B File Offset: 0x0001E78B
		public Class_163 dmethod_746(string str_0)
		{
			return this.kmethod_747(str_0, null);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00020595 File Offset: 0x0001E795
		public Class_163 kmethod_747(string str_0, string str_1)
		{
			if (File.Exists(str_0))
			{
				return this.pmethod_749(str_0, str_1);
			}
			if (Directory.Exists(str_0))
			{
				return this.lmethod_778(str_0, str_1);
			}
			throw new FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", str_0));
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000205CF File Offset: 0x0001E7CF
		public Class_163 lmethod_748(string str_0)
		{
			return this.pmethod_749(str_0, null);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000205DC File Offset: 0x0001E7DC
		public Class_163 pmethod_749(string str_0, string str_1)
		{
			string str_2 = Class_163.tmethod_652(str_0, str_1);
			Class_163 arg_ = Class_163.cmethod_654(str_0, str_2);
			if (this.prop_14)
			{
				this.prop_25.WriteLine("adding {0}...", str_0);
			}
			return this.lmethod_768(arg_);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002061C File Offset: 0x0001E81C
		public void smethod_750(ICollection<Class_163> arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("entriesToRemove");
			}
			foreach (Class_163 arg_ in arg_0)
			{
				this.lmethod_868(arg_);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00020680 File Offset: 0x0001E880
		public void xmethod_751(ICollection<string> arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("entriesToRemove");
			}
			foreach (string str_ in arg_0)
			{
				this.pmethod_869(str_);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000206E4 File Offset: 0x0001E8E4
		public void tmethod_752(IEnumerable<string> arg_0)
		{
			this.cmethod_754(arg_0, null);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000206EE File Offset: 0x0001E8EE
		public void gmethod_753(IEnumerable<string> arg_0)
		{
			this.dmethod_756(arg_0, null);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000206F8 File Offset: 0x0001E8F8
		public void cmethod_754(IEnumerable<string> arg_0, string str_0)
		{
			this.vmethod_755(arg_0, false, str_0);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00020704 File Offset: 0x0001E904
		public void vmethod_755(IEnumerable<string> arg_0, bool bool_0, string str_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("fileNames");
			}
			this.field_30 = false;
			this.smethod_900();
			if (bool_0)
			{
				using (IEnumerator<string> enumerator = arg_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (this.field_30)
						{
							break;
						}
						if (str_0 != null)
						{
							string fullPath = Path.GetFullPath(Path.Combine(str_0, Path.GetDirectoryName(text)));
							this.pmethod_749(text, fullPath);
						}
						else
						{
							this.pmethod_749(text, null);
						}
					}
					goto IL_CE;
				}
			}
			foreach (string str_ in arg_0)
			{
				if (this.field_30)
				{
					break;
				}
				this.pmethod_749(str_, str_0);
			}
			IL_CE:
			if (!this.field_30)
			{
				this.xmethod_901();
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0002080C File Offset: 0x0001EA0C
		public void dmethod_756(IEnumerable<string> arg_0, string str_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("fileNames");
			}
			this.smethod_900();
			foreach (string str_ in arg_0)
			{
				this.lmethod_758(str_, str_0);
			}
			this.xmethod_901();
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0002087C File Offset: 0x0001EA7C
		public Class_163 kmethod_757(string str_0)
		{
			return this.lmethod_758(str_0, null);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00020888 File Offset: 0x0001EA88
		public Class_163 lmethod_758(string str_0, string str_1)
		{
			string str_2 = Class_163.tmethod_652(str_0, str_1);
			if (this.gmethod_863(str_2) != null)
			{
				this.pmethod_869(str_2);
			}
			return this.pmethod_749(str_0, str_1);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000208B8 File Offset: 0x0001EAB8
		public Class_163 pmethod_759(string str_0)
		{
			return this.smethod_760(str_0, null);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000208C2 File Offset: 0x0001EAC2
		public Class_163 smethod_760(string str_0, string str_1)
		{
			return this.smethod_780(str_0, str_1, Class_171.AddOrUpdate);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000208CD File Offset: 0x0001EACD
		public void xmethod_761(string str_0)
		{
			this.tmethod_762(str_0, null);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000208D7 File Offset: 0x0001EAD7
		public void tmethod_762(string str_0, string str_1)
		{
			if (File.Exists(str_0))
			{
				this.lmethod_758(str_0, str_1);
				return;
			}
			if (Directory.Exists(str_0))
			{
				this.smethod_760(str_0, str_1);
				return;
			}
			throw new FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", str_0));
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00020913 File Offset: 0x0001EB13
		public Class_163 gmethod_763(string str_0, string str_1)
		{
			return this.cmethod_764(str_0, str_1, Encoding.Default);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00020924 File Offset: 0x0001EB24
		public Class_163 cmethod_764(string str_0, string str_1, Encoding arg_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(memoryStream, arg_0);
			streamWriter.Write(str_1);
			streamWriter.Flush();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return this.vmethod_765(str_0, memoryStream);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00020960 File Offset: 0x0001EB60
		public Class_163 vmethod_765(string str_0, Stream stream_)
		{
			Class_163 class_ = Class_163.vmethod_655(str_0, stream_);
			class_.xmethod_601(DateTime.Now, DateTime.Now, DateTime.Now);
			if (this.prop_14)
			{
				this.prop_25.WriteLine("adding {0}...", str_0);
			}
			return this.lmethod_768(class_);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000209B0 File Offset: 0x0001EBB0
		public Class_163 dmethod_766(string str_0, Class_124 arg_0)
		{
			Class_163 arg_ = Class_163.dmethod_656(str_0, arg_0);
			if (this.prop_14)
			{
				this.prop_25.WriteLine("adding {0}...", str_0);
			}
			return this.lmethod_768(arg_);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000209E8 File Offset: 0x0001EBE8
		public Class_163 kmethod_767(string str_0, Class_125 arg_0, Class_126 arg_1)
		{
			Class_163 class_ = Class_163.kmethod_657(str_0, arg_0, arg_1);
			class_.xmethod_601(DateTime.Now, DateTime.Now, DateTime.Now);
			if (this.prop_14)
			{
				this.prop_25.WriteLine("adding {0}...", str_0);
			}
			return this.lmethod_768(class_);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00020A38 File Offset: 0x0001EC38
		private Class_163 lmethod_768(Class_163 arg_0)
		{
			arg_0.field_43 = new Class_178(this);
			arg_0.prop_21 = this.prop_10;
			arg_0.prop_22 = this.prop_9;
			arg_0.prop_32 = this.prop_28;
			arg_0.prop_33 = this.prop_29;
			arg_0.prop_35 = this.prop_31;
			arg_0.prop_38 = this.prop_22;
			arg_0.prop_39 = this.prop_23;
			arg_0.prop_30 = this.field_16;
			arg_0.prop_29 = this.prop_30;
			arg_0.prop_7 = this.field_17;
			arg_0.prop_8 = this.field_18;
			this.xmethod_781(arg_0.prop_12, arg_0);
			this.tmethod_902(arg_0);
			return arg_0;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00020AEA File Offset: 0x0001ECEA
		public Class_163 pmethod_769(string str_0, string str_1)
		{
			return this.smethod_770(str_0, str_1, Encoding.Default);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public Class_163 smethod_770(string str_0, string str_1, Encoding arg_0)
		{
			this.cmethod_774(str_0);
			return this.cmethod_764(str_0, str_1, arg_0);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00020B0B File Offset: 0x0001ED0B
		public Class_163 xmethod_771(string str_0, Class_124 arg_0)
		{
			this.cmethod_774(str_0);
			return this.dmethod_766(str_0, arg_0);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00020B1C File Offset: 0x0001ED1C
		public Class_163 tmethod_772(string str_0, Class_125 arg_0, Class_126 arg_1)
		{
			this.cmethod_774(str_0);
			return this.kmethod_767(str_0, arg_0, arg_1);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00020B2E File Offset: 0x0001ED2E
		public Class_163 gmethod_773(string str_0, Stream stream_)
		{
			this.cmethod_774(str_0);
			return this.vmethod_765(str_0, stream_);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00020B40 File Offset: 0x0001ED40
		private void cmethod_774(string str_0)
		{
			if (string.IsNullOrEmpty(str_0))
			{
				throw new ArgumentNullException("entryName");
			}
			string str_ = null;
			if (str_0.IndexOf('\\') != -1)
			{
				str_ = Path.GetDirectoryName(str_0);
				str_0 = Path.GetFileName(str_0);
			}
			string str_2 = Class_163.tmethod_652(str_0, str_);
			if (this.gmethod_863(str_2) != null)
			{
				this.pmethod_869(str_2);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		public Class_163 vmethod_775(string str_0, byte[] byteDizi_0)
		{
			if (byteDizi_0 == null)
			{
				throw new ArgumentException("bad argument", "byteContent");
			}
			MemoryStream stream_ = new MemoryStream(byteDizi_0);
			return this.vmethod_765(str_0, stream_);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00020BD2 File Offset: 0x0001EDD2
		public Class_163 dmethod_776(string str_0, byte[] byteDizi_0)
		{
			this.cmethod_774(str_0);
			return this.vmethod_775(str_0, byteDizi_0);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00020BE3 File Offset: 0x0001EDE3
		public Class_163 kmethod_777(string str_0)
		{
			return this.lmethod_778(str_0, null);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00020BED File Offset: 0x0001EDED
		public Class_163 lmethod_778(string str_0, string str_1)
		{
			return this.smethod_780(str_0, str_1, Class_171.AddOnly);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		public Class_163 pmethod_779(string str_0)
		{
			Class_163 class_ = Class_163.gmethod_653(str_0);
			class_.field_43 = new Class_178(this);
			class_.smethod_660();
			class_.prop_38 = this.prop_22;
			class_.prop_39 = this.prop_23;
			class_.xmethod_601(DateTime.Now, DateTime.Now, DateTime.Now);
			class_.prop_7 = this.field_17;
			class_.prop_8 = this.field_18;
			class_.field_54 = Class_166.Stream;
			this.xmethod_781(class_.prop_12, class_);
			this.tmethod_902(class_);
			return class_;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00020C7F File Offset: 0x0001EE7F
		private Class_163 smethod_780(string str_0, string str_1, Class_171 arg_0)
		{
			if (str_1 == null)
			{
				str_1 = "";
			}
			return this.tmethod_782(str_0, str_1, arg_0, true, 0);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00020C99 File Offset: 0x0001EE99
		internal void xmethod_781(string str_0, Class_163 arg_0)
		{
			this.field_11.Add(str_0, arg_0);
			this.field_12 = null;
			this.field_23 = true;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		private Class_163 tmethod_782(string str_0, string str_1, Class_171 arg_0, bool bool_0, int sayıInt_0)
		{
			if (this.prop_14)
			{
				this.prop_25.WriteLine("{0} {1}...", (arg_0 == Class_171.AddOnly) ? "adding" : "Adding or updating", str_0);
			}
			if (sayıInt_0 == 0)
			{
				this.field_30 = false;
				this.smethod_900();
			}
			if (this.field_30)
			{
				return null;
			}
			string text = str_1;
			Class_163 class_ = null;
			if (sayıInt_0 > 0)
			{
				int num = str_0.Length;
				for (int i = sayıInt_0; i > 0; i--)
				{
					num = str_0.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
				}
				text = str_0.Substring(num + 1);
				text = Path.Combine(str_1, text);
			}
			if (sayıInt_0 > 0 || str_1 != "")
			{
				class_ = Class_163.cmethod_654(str_0, text);
				class_.field_43 = new Class_178(this);
				class_.prop_38 = this.prop_22;
				class_.prop_39 = this.prop_23;
				class_.smethod_660();
				class_.prop_7 = this.field_17;
				class_.prop_8 = this.field_18;
				if (!this.field_11.ContainsKey(class_.prop_12))
				{
					this.xmethod_781(class_.prop_12, class_);
					this.tmethod_902(class_);
				}
				text = class_.prop_12;
			}
			if (!this.field_30)
			{
				string[] files = Directory.GetFiles(str_0);
				if (bool_0)
				{
					foreach (string str_2 in files)
					{
						if (this.field_30)
						{
							break;
						}
						if (arg_0 == Class_171.AddOnly)
						{
							this.pmethod_749(str_2, text);
						}
						else
						{
							this.lmethod_758(str_2, text);
						}
					}
					if (!this.field_30)
					{
						string[] directories = Directory.GetDirectories(str_0);
						foreach (string text2 in directories)
						{
							FileAttributes attributes = File.GetAttributes(text2);
							if (this.prop_3 || (attributes & FileAttributes.ReparsePoint) == (FileAttributes)0)
							{
								this.tmethod_782(text2, str_1, arg_0, bool_0, sayıInt_0 + 1);
							}
						}
					}
				}
			}
			if (sayıInt_0 == 0)
			{
				this.xmethod_901();
			}
			return class_;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00020ED7 File Offset: 0x0001F0D7
		public static bool gmethod_783(string str_0)
		{
			return Class_168.cmethod_784(str_0, false, null);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00020EE4 File Offset: 0x0001F0E4
		public static bool cmethod_784(string str_0, bool bool_0, TextWriter arg_0)
		{
			Class_168 class_ = null;
			Class_168 class_2 = null;
			bool flag = true;
			try
			{
				class_ = new Class_168();
				class_.prop_1 = true;
				class_.lmethod_858(str_0);
				class_2 = Class_168.pmethod_909(str_0);
				using (IEnumerator<Class_163> enumerator = class_.dmethod_956())
				{
					while (enumerator.MoveNext())
					{
						Class_163 class_3 = enumerator.Current;
						using (IEnumerator<Class_163> enumerator2 = class_2.dmethod_956())
						{
							while (enumerator2.MoveNext())
							{
								Class_163 class_4 = enumerator2.Current;
								if (class_3.prop_12 == class_4.prop_12)
								{
									if (class_3.field_46 != class_4.field_46)
									{
										flag = false;
										if (arg_0 != null)
										{
											arg_0.WriteLine("{0}: mismatch in RelativeOffsetOfLocalHeader  (0x{1:X16} != 0x{2:X16})", class_3.prop_12, class_3.field_46, class_4.field_46);
										}
									}
									if (class_3.field_29 != class_4.field_29)
									{
										flag = false;
										if (arg_0 != null)
										{
											arg_0.WriteLine("{0}: mismatch in CompressedSize  (0x{1:X16} != 0x{2:X16})", class_3.prop_12, class_3.field_29, class_4.field_29);
										}
									}
									if (class_3.field_31 != class_4.field_31)
									{
										flag = false;
										if (arg_0 != null)
										{
											arg_0.WriteLine("{0}: mismatch in UncompressedSize  (0x{1:X16} != 0x{2:X16})", class_3.prop_12, class_3.field_31, class_4.field_31);
										}
									}
									if (class_3.prop_21 != class_4.prop_21)
									{
										flag = false;
										if (arg_0 != null)
										{
											arg_0.WriteLine("{0}: mismatch in CompressionMethod  (0x{1:X4} != 0x{2:X4})", class_3.prop_12, class_3.prop_21, class_4.prop_21);
										}
									}
									if (class_3.prop_26 == class_4.prop_26)
									{
										break;
									}
									flag = false;
									if (arg_0 != null)
									{
										arg_0.WriteLine("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})", class_3.prop_12, class_3.prop_26, class_4.prop_26);
										break;
									}
									break;
								}
							}
						}
					}
				}
				class_2.smethod_870();
				class_2 = null;
				if (!flag && bool_0)
				{
					string text = Path.GetFileNameWithoutExtension(str_0);
					text = string.Format("{0}_fixed.zip", text);
					class_.smethod_930(text);
				}
			}
			finally
			{
				if (class_ != null)
				{
					class_.smethod_870();
				}
				if (class_2 != null)
				{
					class_2.smethod_870();
				}
			}
			return flag;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002118C File Offset: 0x0001F38C
		public static void vmethod_785(string str_0)
		{
			using (Class_168 class_ = new Class_168())
			{
				class_.prop_1 = true;
				class_.lmethod_858(str_0);
				class_.smethod_930(str_0);
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000211D8 File Offset: 0x0001F3D8
		public static bool dmethod_786(string str_0, string str_1)
		{
			bool result = false;
			try
			{
				using (Class_168 class_ = Class_168.pmethod_909(str_0))
				{
					using (IEnumerator<Class_163> enumerator = class_.dmethod_956())
					{
						while (enumerator.MoveNext())
						{
							Class_163 class_2 = enumerator.Current;
							if (!class_2.prop_27 && class_2.prop_28)
							{
								class_2.pmethod_679(Stream.Null, str_1);
							}
						}
					}
				}
				result = true;
			}
			catch (Class_136)
			{
			}
			return result;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00021288 File Offset: 0x0001F488
		public string prop_0
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(string.Format("          ZipFile: {0}\n", this.prop_8));
				if (!string.IsNullOrEmpty(this.field_15))
				{
					stringBuilder.Append(string.Format("          Comment: {0}\n", this.field_15));
				}
				if (this.field_4 != 0)
				{
					stringBuilder.Append(string.Format("  version made by: 0x{0:X4}\n", this.field_4));
				}
				if (this.field_5 != 0)
				{
					stringBuilder.Append(string.Format("needed to extract: 0x{0:X4}\n", this.field_5));
				}
				stringBuilder.Append(string.Format("       uses ZIP64: {0}\n", this.prop_20));
				stringBuilder.Append(string.Format("     disk with CD: {0}\n", this.field_6));
				if (this.field_34 == 4294967295U)
				{
					stringBuilder.Append(string.Format("      CD64 offset: 0x{0:X16}\n", this.field_35));
				}
				else
				{
					stringBuilder.Append(string.Format("        CD offset: 0x{0:X8}\n", this.field_34));
				}
				stringBuilder.Append("\n");
				foreach (Class_163 class_ in this.field_11.Values)
				{
					stringBuilder.Append(class_.prop_1);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00021414 File Offset: 0x0001F614
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0002141C File Offset: 0x0001F61C
		public bool prop_1 { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00021425 File Offset: 0x0001F625
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0002142D File Offset: 0x0001F62D
		public bool prop_2 { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00021436 File Offset: 0x0001F636
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x0002143E File Offset: 0x0001F63E
		public bool prop_3 { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00021447 File Offset: 0x0001F647
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x0002144F File Offset: 0x0001F64F
		public int prop_4
		{
			get
			{
				return this.field_41;
			}
			set
			{
				this.field_41 = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00021458 File Offset: 0x0001F658
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00021460 File Offset: 0x0001F660
		public int prop_5 { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00021469 File Offset: 0x0001F669
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00021471 File Offset: 0x0001F671
		public bool prop_6 { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0002147A File Offset: 0x0001F67A
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00021482 File Offset: 0x0001F682
		public Class_203 prop_7
		{
			get
			{
				return this.field_19;
			}
			set
			{
				this.field_19 = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0002148B File Offset: 0x0001F68B
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00021493 File Offset: 0x0001F693
		public string prop_8
		{
			get
			{
				return this.field_13;
			}
			set
			{
				this.field_13 = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0002149C File Offset: 0x0001F69C
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x000214A4 File Offset: 0x0001F6A4
		public Class_202 prop_9 { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000214AD File Offset: 0x0001F6AD
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x000214B5 File Offset: 0x0001F6B5
		public Class_165 prop_10
		{
			get
			{
				return this.field_20;
			}
			set
			{
				this.field_20 = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000214BE File Offset: 0x0001F6BE
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x000214C6 File Offset: 0x0001F6C6
		public string prop_11
		{
			get
			{
				return this.field_15;
			}
			set
			{
				this.field_15 = value;
				this.field_23 = true;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000214D6 File Offset: 0x0001F6D6
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x000214DE File Offset: 0x0001F6DE
		public bool prop_12
		{
			get
			{
				return this.field_17;
			}
			set
			{
				this.field_17 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000214E7 File Offset: 0x0001F6E7
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x000214EF File Offset: 0x0001F6EF
		public bool prop_13
		{
			get
			{
				return this.field_18;
			}
			set
			{
				this.field_18 = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000214F8 File Offset: 0x0001F6F8
		internal bool prop_14
		{
			get
			{
				return this.field_0 != null;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00021506 File Offset: 0x0001F706
		public bool vmethod_815(string str_0)
		{
			return this.field_11.ContainsKey(Class_155.NormalizePathForUseInZipFile(str_0));
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00021519 File Offset: 0x0001F719
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00021521 File Offset: 0x0001F721
		public bool prop_15
		{
			get
			{
				return this.field_1;
			}
			set
			{
				if (value != this.field_1)
				{
					this.field_1 = value;
					this.pmethod_859();
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0002153C File Offset: 0x0001F73C
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0002155E File Offset: 0x0001F75E
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool prop_16
		{
			get
			{
				return this.field_38 == Encoding.GetEncoding("UTF-8") && this.field_39 == Class_170.AsNecessary;
			}
			set
			{
				if (value)
				{
					this.field_38 = Encoding.GetEncoding("UTF-8");
					this.field_39 = Class_170.AsNecessary;
					return;
				}
				this.field_38 = Class_168.prop_24;
				this.field_39 = Class_170.Default;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00021590 File Offset: 0x0001F790
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00021598 File Offset: 0x0001F798
		public Class_169 prop_17
		{
			get
			{
				return this.field_45;
			}
			set
			{
				this.field_45 = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000215A4 File Offset: 0x0001F7A4
		public bool? prop_18
		{
			get
			{
				if (this.field_11.Count > 65534)
				{
					return new bool?(true);
				}
				if (!this.field_24 || this.field_23)
				{
					return null;
				}
				foreach (Class_163 class_ in this.field_11.Values)
				{
					if (class_.prop_18.Value)
					{
						return new bool?(true);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00021660 File Offset: 0x0001F860
		public bool? prop_19
		{
			get
			{
				return this.field_36;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00021668 File Offset: 0x0001F868
		public bool? prop_20
		{
			get
			{
				if (this.field_11.Count > 65534)
				{
					return new bool?(true);
				}
				using (IEnumerator<Class_163> enumerator = this.dmethod_956())
				{
					while (enumerator.MoveNext())
					{
						Class_163 class_ = enumerator.Current;
						if (class_.prop_15 != Class_166.ZipFile)
						{
							return null;
						}
						if (class_.field_51)
						{
							return new bool?(true);
						}
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00021708 File Offset: 0x0001F908
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0002171E File Offset: 0x0001F91E
		[Obsolete("use AlternateEncoding instead.")]
		public Encoding prop_21
		{
			get
			{
				if (this.field_39 == Class_170.AsNecessary)
				{
					return this.field_38;
				}
				return null;
			}
			set
			{
				this.field_38 = value;
				this.field_39 = Class_170.AsNecessary;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0002172E File Offset: 0x0001F92E
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00021736 File Offset: 0x0001F936
		public Encoding prop_22
		{
			get
			{
				return this.field_38;
			}
			set
			{
				this.field_38 = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0002173F File Offset: 0x0001F93F
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00021747 File Offset: 0x0001F947
		public Class_170 prop_23
		{
			get
			{
				return this.field_39;
			}
			set
			{
				this.field_39 = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00021750 File Offset: 0x0001F950
		public static Encoding prop_24
		{
			get
			{
				return Class_168.field_40;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00021757 File Offset: 0x0001F957
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0002175F File Offset: 0x0001F95F
		public TextWriter prop_25
		{
			get
			{
				return this.field_0;
			}
			set
			{
				this.field_0 = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00021768 File Offset: 0x0001F968
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00021770 File Offset: 0x0001F970
		public string prop_26
		{
			get
			{
				return this.field_25;
			}
			set
			{
				this.field_25 = value;
				if (value == null)
				{
					return;
				}
				if (!Directory.Exists(value))
				{
					throw new FileNotFoundException(string.Format("That directory ({0}) does not exist.", value));
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000217CA File Offset: 0x0001F9CA
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0002179C File Offset: 0x0001F99C
		public string prop_27
		{
			private get
			{
				return this.field_16;
			}
			set
			{
				this.field_16 = value;
				if (this.field_16 == null)
				{
					this.prop_30 = Class_123.None;
					return;
				}
				if (this.prop_30 == Class_123.None)
				{
					this.prop_30 = Class_123.PkzipWeak;
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000217D2 File Offset: 0x0001F9D2
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x000217DA File Offset: 0x0001F9DA
		public Class_141 prop_28 { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000217E3 File Offset: 0x0001F9E3
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x000217FD File Offset: 0x0001F9FD
		public Class_167 prop_29
		{
			get
			{
				if (this.field_53 != null)
				{
					this.field_9 = Class_167.InvokeErrorEvent;
				}
				return this.field_9;
			}
			set
			{
				this.field_9 = value;
				if (this.field_9 != Class_167.InvokeErrorEvent && this.field_53 != null)
				{
					this.field_53 = null;
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00021824 File Offset: 0x0001FA24
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0002182C File Offset: 0x0001FA2C
		public Class_123 prop_30
		{
			get
			{
				return this.field_31;
			}
			set
			{
				if (value == Class_123.Unsupported)
				{
					throw new InvalidOperationException("You may not set Encryption to that value.");
				}
				this.field_31 = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00021847 File Offset: 0x0001FA47
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x0002184F File Offset: 0x0001FA4F
		public Class_127 prop_31 { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00021858 File Offset: 0x0001FA58
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00021860 File Offset: 0x0001FA60
		public int prop_32
		{
			get
			{
				return this.field_7;
			}
			set
			{
				if (value < 65536 && value != 0)
				{
					throw new Class_135("The minimum acceptable segment size is 65536.");
				}
				this.field_7 = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00021885 File Offset: 0x0001FA85
		public int prop_33
		{
			get
			{
				return (int)(this.field_8 + 1U);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000218BF File Offset: 0x0001FABF
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0002188F File Offset: 0x0001FA8F
		public long prop_34
		{
			get
			{
				return this.field_43;
			}
			set
			{
				if (value != 0L && value != -1L && value < 65536L)
				{
					throw new ArgumentOutOfRangeException("ParallelDeflateThreshold should be -1, 0, or > 65536");
				}
				this.field_43 = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000218C7 File Offset: 0x0001FAC7
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000218CF File Offset: 0x0001FACF
		public int prop_35
		{
			get
			{
				return this.field_44;
			}
			set
			{
				if (value < 4)
				{
					throw new ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
				}
				this.field_44 = value;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000218EF File Offset: 0x0001FAEF
		public virtual string gmethod_853()
		{
			return string.Format("ZipFile::{0}", this.prop_8);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00021901 File Offset: 0x0001FB01
		public static Version prop_36
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00021912 File Offset: 0x0001FB12
		internal void vmethod_855()
		{
			this.field_23 = true;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002191C File Offset: 0x0001FB1C
		internal Stream dmethod_856(uint arg_0)
		{
			if (arg_0 + 1U == this.field_6 || (arg_0 == 0U && this.field_6 == 0U))
			{
				return this.prop_44;
			}
			return Class_179.dmethod_1086(this.field_14 ?? this.field_13, arg_0, this.field_6);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00021970 File Offset: 0x0001FB70
		internal void kmethod_857(bool bool_0)
		{
			if (this.field_32)
			{
				using (Class_168 class_ = new Class_168())
				{
					class_.field_14 = (class_.field_13 = (bool_0 ? (this.field_14 ?? this.field_13) : this.field_13));
					class_.prop_22 = this.prop_22;
					class_.prop_23 = this.prop_23;
					Class_168.vmethod_915(class_);
					using (IEnumerator<Class_163> enumerator = class_.dmethod_956())
					{
						while (enumerator.MoveNext())
						{
							Class_163 class_2 = enumerator.Current;
							using (IEnumerator<Class_163> enumerator2 = this.dmethod_956())
							{
								while (enumerator2.MoveNext())
								{
									Class_163 class_3 = enumerator2.Current;
									if (class_2.prop_12 == class_3.prop_12)
									{
										class_3.kmethod_727(class_2);
										break;
									}
								}
							}
						}
					}
				}
				this.field_32 = false;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public Class_168(string str_0)
		{
			try
			{
				this.smethod_860(str_0, null);
			}
			catch (Exception arg_)
			{
				throw new Class_135(string.Format("Could not read {0} as a zip file", str_0), arg_);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00021B3C File Offset: 0x0001FD3C
		public Class_168(string str_0, Encoding arg_0)
		{
			try
			{
				this.prop_22 = arg_0;
				this.prop_23 = Class_170.Always;
				this.smethod_860(str_0, null);
			}
			catch (Exception arg_)
			{
				throw new Class_135(string.Format("{0} is not a valid zip file", str_0), arg_);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		public Class_168()
		{
			this.smethod_860(null, null);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00021C54 File Offset: 0x0001FE54
		public Class_168(Encoding arg_0)
		{
			this.prop_22 = arg_0;
			this.prop_23 = Class_170.Always;
			this.smethod_860(null, null);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00021CD4 File Offset: 0x0001FED4
		public Class_168(string str_0, TextWriter arg_0)
		{
			try
			{
				this.smethod_860(str_0, arg_0);
			}
			catch (Exception arg_)
			{
				throw new Class_135(string.Format("{0} is not a valid zip file", str_0), arg_);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00021D6C File Offset: 0x0001FF6C
		public Class_168(string str_0, TextWriter arg_0, Encoding arg_1)
		{
			try
			{
				this.prop_22 = arg_1;
				this.prop_23 = Class_170.Always;
				this.smethod_860(str_0, arg_0);
			}
			catch (Exception arg_2)
			{
				throw new Class_135(string.Format("{0} is not a valid zip file", str_0), arg_2);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00021E14 File Offset: 0x00020014
		public void lmethod_858(string str_0)
		{
			try
			{
				this.smethod_860(str_0, null);
			}
			catch (Exception arg_)
			{
				throw new Class_135(string.Format("{0} is not a valid zip file", str_0), arg_);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00021E54 File Offset: 0x00020054
		private void pmethod_859()
		{
			StringComparer comparer = this.prop_15 ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase;
			this.field_11 = ((this.field_11 == null) ? new Dictionary<string, Class_163>(comparer) : new Dictionary<string, Class_163>(this.field_11, comparer));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00021EA4 File Offset: 0x000200A4
		private void smethod_860(string str_0, TextWriter arg_0)
		{
			this.field_13 = str_0;
			this.field_0 = arg_0;
			this.field_23 = true;
			this.prop_3 = true;
			this.prop_9 = Class_202.Default;
			this.prop_34 = 524288L;
			this.pmethod_859();
			if (File.Exists(this.field_13))
			{
				if (this.prop_1)
				{
					Class_168.pmethod_919(this);
				}
				else
				{
					Class_168.vmethod_915(this);
				}
				this.field_21 = true;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00021F19 File Offset: 0x00020119
		private List<Class_163> prop_37
		{
			get
			{
				if (this.field_12 == null)
				{
					this.field_12 = new List<Class_163>(this.field_11.Values);
				}
				return this.field_12;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00021F42 File Offset: 0x00020142
		public Class_163 prop_38
		{
			get
			{
				return this.prop_37[sayıInt_0];
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00021F50 File Offset: 0x00020150
		public Class_163 prop_39
		{
			get
			{
				string text = Class_155.NormalizePathForUseInZipFile(str_0);
				if (this.field_11.ContainsKey(text))
				{
					return this.field_11[text];
				}
				text = text.Replace("/", "\\");
				if (this.field_11.ContainsKey(text))
				{
					return this.field_11[text];
				}
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00021FB2 File Offset: 0x000201B2
		public ICollection<string> prop_40
		{
			get
			{
				return this.field_11.Keys;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00021FBF File Offset: 0x000201BF
		public ICollection<Class_163> prop_41
		{
			get
			{
				return this.field_11.Values;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00021FCC File Offset: 0x000201CC
		public ICollection<Class_163> prop_42
		{
			get
			{
				Class_168.NClass_1 nclass_ = new Class_168.NClass_1();
				List<Class_163> list = new List<Class_163>();
				foreach (Class_163 item in this.prop_41)
				{
					list.Add(item);
				}
				nclass_.field_87 = (this.prop_15 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase);
				list.Sort(new Comparison<Class_163>(nclass_.nmethod_2));
				return list.AsReadOnly();
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00022060 File Offset: 0x00020260
		public int prop_43
		{
			get
			{
				return this.field_11.Count;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002206D File Offset: 0x0002026D
		public void lmethod_868(Class_163 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("entry");
			}
			this.field_11.Remove(Class_155.NormalizePathForUseInZipFile(arg_0.prop_12));
			this.field_12 = null;
			this.field_23 = true;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000220A8 File Offset: 0x000202A8
		public void pmethod_869(string str_0)
		{
			string str_ = Class_163.tmethod_652(str_0, null);
			Class_163 class_ = this.gmethod_863(str_);
			if (class_ == null)
			{
				throw new ArgumentException("The entry you specified was not found in the zip archive.");
			}
			this.lmethod_868(class_);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000220DD File Offset: 0x000202DD
		public void smethod_870()
		{
			this.xmethod_871(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000220EC File Offset: 0x000202EC
		protected virtual void xmethod_871(bool bool_0)
		{
			if (!this.field_10)
			{
				if (bool_0)
				{
					if (this.field_26 && this.field_2 != null)
					{
						this.field_2.Dispose();
						this.field_2 = null;
					}
					if (this.field_22 != null && this.field_13 != null && this.field_3 != null)
					{
						this.field_3.Dispose();
						this.field_3 = null;
					}
					if (this.field_42 != null)
					{
						this.field_42.kmethod_1297();
						this.field_42 = null;
					}
				}
				this.field_10 = true;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0002218C File Offset: 0x0002038C
		internal Stream prop_44
		{
			get
			{
				if (this.field_2 == null && (this.field_14 != null || this.field_13 != null))
				{
					this.field_2 = File.Open(this.field_14 ?? this.field_13, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					this.field_26 = true;
				}
				return this.field_2;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000221E8 File Offset: 0x000203E8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00022271 File Offset: 0x00020471
		private Stream prop_45
		{
			get
			{
				if (this.field_3 != null)
				{
					return this.field_3;
				}
				if (this.field_13 == null)
				{
					return this.field_3;
				}
				if (this.field_7 != 0)
				{
					this.field_3 = Class_179.kmethod_1087(this.field_13, this.field_7);
					return this.field_3;
				}
				Class_155.CreateAndOpenUniqueTempFile(this.prop_26 ?? Path.GetDirectoryName(this.field_13), out this.field_3, out this.field_22);
				return this.field_3;
			}
			set
			{
				if (value != null)
				{
					throw new Class_135("Cannot set the stream to a non-null value.");
				}
				this.field_3 = null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0002228B File Offset: 0x0002048B
		private string prop_46
		{
			get
			{
				if (this.field_13 == null)
				{
					return "(stream)";
				}
				return this.field_13;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000532 RID: 1330 RVA: 0x000222A4 File Offset: 0x000204A4
		// (remove) Token: 0x06000533 RID: 1331 RVA: 0x000222DC File Offset: 0x000204DC
		public event EventHandler<Class_132> SaveProgress
		{
			add
			{
				EventHandler<Class_132> eventHandler = this.field_48;
				EventHandler<Class_132> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_132> value2 = (EventHandler<Class_132>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_132>>(ref this.field_48, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_132> eventHandler = this.field_48;
				EventHandler<Class_132> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_132> value2 = (EventHandler<Class_132>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_132>>(ref this.field_48, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00022314 File Offset: 0x00020514
		internal bool lmethod_878(Class_163 arg_0, long sayıUınt_0, long sayıUınt_1)
		{
			EventHandler<Class_132> eventHandler = this.field_48;
			if (eventHandler != null)
			{
				Class_132 class_ = Class_132.cmethod_444(this.prop_46, arg_0, sayıUınt_0, sayıUınt_1);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_28 = true;
				}
			}
			return this.field_28;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00022360 File Offset: 0x00020560
		private void pmethod_879(int sayıInt_0, Class_163 arg_0, bool bool_0)
		{
			EventHandler<Class_132> eventHandler = this.field_48;
			if (eventHandler != null)
			{
				Class_132 class_ = new Class_132(this.prop_46, bool_0, this.field_11.Count, sayıInt_0, arg_0);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_28 = true;
				}
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000223B0 File Offset: 0x000205B0
		private void smethod_880(Class_128 arg_0)
		{
			EventHandler<Class_132> eventHandler = this.field_48;
			if (eventHandler != null)
			{
				Class_132 class_ = new Class_132(this.prop_46, arg_0);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_28 = true;
				}
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000223F4 File Offset: 0x000205F4
		private void xmethod_881()
		{
			EventHandler<Class_132> eventHandler = this.field_48;
			if (eventHandler != null)
			{
				Class_132 class_ = Class_132.vmethod_445(this.prop_46);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_28 = true;
				}
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00022434 File Offset: 0x00020634
		private void tmethod_882()
		{
			EventHandler<Class_132> eventHandler = this.field_48;
			if (eventHandler != null)
			{
				Class_132 e = Class_132.dmethod_446(this.prop_46);
				eventHandler(this, e);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000539 RID: 1337 RVA: 0x00022464 File Offset: 0x00020664
		// (remove) Token: 0x0600053A RID: 1338 RVA: 0x0002249C File Offset: 0x0002069C
		public event EventHandler<Class_130> ReadProgress
		{
			add
			{
				EventHandler<Class_130> eventHandler = this.field_49;
				EventHandler<Class_130> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_130> value2 = (EventHandler<Class_130>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_130>>(ref this.field_49, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_130> eventHandler = this.field_49;
				EventHandler<Class_130> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_130> value2 = (EventHandler<Class_130>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_130>>(ref this.field_49, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000224D4 File Offset: 0x000206D4
		private void vmethod_885()
		{
			EventHandler<Class_130> eventHandler = this.field_49;
			if (eventHandler != null)
			{
				Class_130 e = Class_130.lmethod_438(this.prop_46);
				eventHandler(this, e);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00022504 File Offset: 0x00020704
		private void dmethod_886()
		{
			EventHandler<Class_130> eventHandler = this.field_49;
			if (eventHandler != null)
			{
				Class_130 e = Class_130.smethod_440(this.prop_46);
				eventHandler(this, e);
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00022534 File Offset: 0x00020734
		internal void kmethod_887(Class_163 arg_0)
		{
			EventHandler<Class_130> eventHandler = this.field_49;
			if (eventHandler != null)
			{
				Class_130 e = Class_130.pmethod_439(this.prop_46, arg_0, this.prop_44.Position, this.prop_47);
				eventHandler(this, e);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00022574 File Offset: 0x00020774
		internal void lmethod_888(bool bool_0, Class_163 arg_0)
		{
			EventHandler<Class_130> eventHandler = this.field_49;
			if (eventHandler != null)
			{
				Class_130 e = bool_0 ? Class_130.dmethod_436(this.prop_46, this.field_11.Count) : Class_130.kmethod_437(this.prop_46, arg_0, this.field_11.Count);
				eventHandler(this, e);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000225CF File Offset: 0x000207CF
		private long prop_47
		{
			get
			{
				if (this.field_50 == -99L)
				{
					this.field_50 = (this.field_26 ? Class_155.GetFileLength(this.field_13) : -1L);
				}
				return this.field_50;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000540 RID: 1344 RVA: 0x00022608 File Offset: 0x00020808
		// (remove) Token: 0x06000541 RID: 1345 RVA: 0x00022640 File Offset: 0x00020840
		public event EventHandler<Class_133> ExtractProgress
		{
			add
			{
				EventHandler<Class_133> eventHandler = this.field_51;
				EventHandler<Class_133> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_133> value2 = (EventHandler<Class_133>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_133>>(ref this.field_51, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_133> eventHandler = this.field_51;
				EventHandler<Class_133> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_133> value2 = (EventHandler<Class_133>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_133>>(ref this.field_51, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00022678 File Offset: 0x00020878
		private void tmethod_892(int sayıInt_0, bool bool_0, Class_163 arg_0, string str_0)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 class_ = new Class_133(this.prop_46, bool_0, this.field_11.Count, sayıInt_0, arg_0, str_0);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_29 = true;
				}
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000226C8 File Offset: 0x000208C8
		internal bool gmethod_893(Class_163 arg_0, long sayıUınt_0, long sayıUınt_1)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 class_ = Class_133.gmethod_453(this.prop_46, arg_0, sayıUınt_0, sayıUınt_1);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_29 = true;
				}
			}
			return this.field_29;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00022714 File Offset: 0x00020914
		internal bool cmethod_894(Class_163 arg_0, string str_0, bool bool_0)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 class_ = bool_0 ? Class_133.lmethod_448(this.prop_46, arg_0, str_0) : Class_133.smethod_450(this.prop_46, arg_0, str_0);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_29 = true;
				}
			}
			return this.field_29;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00022774 File Offset: 0x00020974
		internal bool vmethod_895(Class_163 arg_0, string str_0)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 class_ = Class_133.pmethod_449(this.prop_46, arg_0, str_0);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_29 = true;
				}
			}
			return this.field_29;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x000227BC File Offset: 0x000209BC
		private void dmethod_896(string str_0)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 e = Class_133.tmethod_452(this.prop_46, str_0);
				eventHandler(this, e);
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000227EC File Offset: 0x000209EC
		private void kmethod_897(string str_0)
		{
			EventHandler<Class_133> eventHandler = this.field_51;
			if (eventHandler != null)
			{
				Class_133 e = Class_133.xmethod_451(this.prop_46, str_0);
				eventHandler(this, e);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000548 RID: 1352 RVA: 0x0002281C File Offset: 0x00020A1C
		// (remove) Token: 0x06000549 RID: 1353 RVA: 0x00022854 File Offset: 0x00020A54
		public event EventHandler<Class_131> AddProgress
		{
			add
			{
				EventHandler<Class_131> eventHandler = this.field_52;
				EventHandler<Class_131> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_131> value2 = (EventHandler<Class_131>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_131>>(ref this.field_52, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_131> eventHandler = this.field_52;
				EventHandler<Class_131> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_131> value2 = (EventHandler<Class_131>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_131>>(ref this.field_52, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002288C File Offset: 0x00020A8C
		private void smethod_900()
		{
			EventHandler<Class_131> eventHandler = this.field_52;
			if (eventHandler != null)
			{
				Class_131 class_ = Class_131.tmethod_442(this.prop_46);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_30 = true;
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000228CC File Offset: 0x00020ACC
		private void xmethod_901()
		{
			EventHandler<Class_131> eventHandler = this.field_52;
			if (eventHandler != null)
			{
				Class_131 e = Class_131.gmethod_443(this.prop_46);
				eventHandler(this, e);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000228FC File Offset: 0x00020AFC
		internal void tmethod_902(Class_163 arg_0)
		{
			EventHandler<Class_131> eventHandler = this.field_52;
			if (eventHandler != null)
			{
				Class_131 class_ = Class_131.xmethod_441(this.prop_46, arg_0, this.field_11.Count);
				eventHandler(this, class_);
				if (class_.prop_2)
				{
					this.field_30 = true;
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600054D RID: 1357 RVA: 0x00022948 File Offset: 0x00020B48
		// (remove) Token: 0x0600054E RID: 1358 RVA: 0x00022980 File Offset: 0x00020B80
		public event EventHandler<Class_134> ZipError
		{
			add
			{
				EventHandler<Class_134> eventHandler = this.field_53;
				EventHandler<Class_134> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_134> value2 = (EventHandler<Class_134>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_134>>(ref this.field_53, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<Class_134> eventHandler = this.field_53;
				EventHandler<Class_134> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<Class_134> value2 = (EventHandler<Class_134>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<Class_134>>(ref this.field_53, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000229B8 File Offset: 0x00020BB8
		internal bool vmethod_905(Class_163 arg_0, Exception arg_1)
		{
			if (this.field_53 != null)
			{
				lock (this.field_27)
				{
					Class_134 class_ = Class_134.dmethod_456(this.prop_8, arg_0, arg_1);
					this.field_53(this, class_);
					if (class_.prop_2)
					{
						this.field_28 = true;
					}
				}
			}
			return this.field_28;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00022A2C File Offset: 0x00020C2C
		public void dmethod_906(string str_0)
		{
			this.lmethod_908(str_0, true);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00022A36 File Offset: 0x00020C36
		public void kmethod_907(string str_0, Class_141 arg_0)
		{
			this.prop_28 = arg_0;
			this.lmethod_908(str_0, true);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00022A48 File Offset: 0x00020C48
		private void lmethod_908(string str_0, bool bool_0)
		{
			bool flag = this.prop_14;
			this.field_37 = true;
			try
			{
				this.kmethod_897(str_0);
				int num = 0;
				foreach (Class_163 class_ in this.field_11.Values)
				{
					if (flag)
					{
						this.prop_25.WriteLine("\n{1,-22} {2,-8} {3,4}   {4,-8}  {0}", new object[]
						{
							"Name",
							"Modified",
							"Size",
							"Ratio",
							"Packed"
						});
						this.prop_25.WriteLine(new string('-', 72));
						flag = false;
					}
					if (this.prop_14)
					{
						this.prop_25.WriteLine("{1,-22} {2,-8} {3,4:F0}%   {4,-8} {0}", new object[]
						{
							class_.prop_12,
							class_.prop_2.ToString("yyyy-MM-dd HH:mm:ss"),
							class_.prop_24,
							class_.prop_25,
							class_.prop_23
						});
						if (!string.IsNullOrEmpty(class_.prop_17))
						{
							this.prop_25.WriteLine("  Comment: {0}", class_.prop_17);
						}
					}
					class_.prop_30 = this.field_16;
					this.tmethod_892(num, true, class_, str_0);
					if (bool_0)
					{
						class_.prop_32 = this.prop_28;
					}
					class_.gmethod_673(str_0);
					num++;
					this.tmethod_892(num, false, class_, str_0);
					if (this.field_29)
					{
						break;
					}
				}
				if (!this.field_29)
				{
					foreach (Class_163 class_2 in this.field_11.Values)
					{
						if (class_2.prop_27 || class_2.prop_12.EndsWith("/"))
						{
							string str_ = class_2.prop_12.StartsWith("/") ? Path.Combine(str_0, class_2.prop_12.Substring(1)) : Path.Combine(str_0, class_2.prop_12);
							class_2.dmethod_696(str_, false);
						}
					}
					this.dmethod_896(str_0);
				}
			}
			finally
			{
				this.field_37 = false;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00022D00 File Offset: 0x00020F00
		public static Class_168 pmethod_909(string str_0)
		{
			return Class_168.xmethod_911(str_0, null, null, null);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00022D0B File Offset: 0x00020F0B
		public static Class_168 smethod_910(string str_0, Class_172 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("options");
			}
			return Class_168.xmethod_911(str_0, arg_0.prop_1, arg_0.prop_2, arg_0.prop_0);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00022D38 File Offset: 0x00020F38
		private static Class_168 xmethod_911(string str_0, TextWriter arg_0, Encoding arg_1, EventHandler<Class_130> arg_2)
		{
			Class_168 class_ = new Class_168();
			class_.prop_22 = (arg_1 ?? Class_168.prop_24);
			class_.prop_23 = Class_170.Always;
			class_.field_0 = arg_0;
			class_.field_13 = str_0;
			if (arg_2 != null)
			{
				class_.field_49 = arg_2;
			}
			if (class_.prop_14)
			{
				class_.field_0.WriteLine("reading from {0}...", str_0);
			}
			Class_168.vmethod_915(class_);
			class_.field_21 = true;
			return class_;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00022DAA File Offset: 0x00020FAA
		public static Class_168 tmethod_912(Stream stream_)
		{
			return Class_168.cmethod_914(stream_, null, null, null);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00022DB5 File Offset: 0x00020FB5
		public static Class_168 gmethod_913(Stream stream_, Class_172 arg_0)
		{
			if (arg_0 == null)
			{
				throw new ArgumentNullException("options");
			}
			return Class_168.cmethod_914(stream_, arg_0.prop_1, arg_0.prop_2, arg_0.prop_0);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00022DE0 File Offset: 0x00020FE0
		private static Class_168 cmethod_914(Stream stream_, TextWriter arg_0, Encoding arg_1, EventHandler<Class_130> arg_2)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("zipStream");
			}
			Class_168 class_ = new Class_168();
			class_.field_0 = arg_0;
			class_.field_38 = (arg_1 ?? Class_168.prop_24);
			class_.field_39 = Class_170.Always;
			if (arg_2 != null)
			{
				class_.ReadProgress += arg_2;
			}
			class_.field_2 = ((stream_.Position == 0L) ? stream_ : new Class_154(stream_));
			class_.field_26 = false;
			if (class_.prop_14)
			{
				class_.field_0.WriteLine("reading from stream...");
			}
			Class_168.vmethod_915(class_);
			return class_;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00022E7C File Offset: 0x0002107C
		private static void vmethod_915(Class_168 arg_0)
		{
			Stream stream = arg_0.prop_44;
			try
			{
				arg_0.field_14 = arg_0.field_13;
				if (!stream.CanSeek)
				{
					Class_168.pmethod_919(arg_0);
					return;
				}
				arg_0.vmethod_885();
				uint num = Class_168.kmethod_917(stream);
				if (num == 101010256U)
				{
					return;
				}
				int num2 = 0;
				bool flag = false;
				long num3 = stream.Length - 64L;
				long num4 = Math.Max(stream.Length - 16384L, 10L);
				do
				{
					if (num3 < 0L)
					{
						num3 = 0L;
					}
					stream.Seek(num3, SeekOrigin.Begin);
					long num5 = Class_155.FindSignature(stream, 101010256);
					if (num5 != -1L)
					{
						flag = true;
					}
					else
					{
						if (num3 == 0L)
						{
							break;
						}
						num2++;
						num3 -= (long)(32 * (num2 + 1) * num2);
					}
				}
				while (!flag && num3 > num4);
				if (flag)
				{
					arg_0.field_33 = stream.Position - 4L;
					byte[] array = new byte[16];
					stream.Read(array, 0, array.Length);
					arg_0.field_6 = (uint)BitConverter.ToUInt16(array, 2);
					if (arg_0.field_6 == 65535U)
					{
						throw new Class_135("Spanned archives with more than 65534 segments are not supported at this time.");
					}
					arg_0.field_6 += 1U;
					int startIndex = 12;
					uint num6 = BitConverter.ToUInt32(array, startIndex);
					if (num6 == 4294967295U)
					{
						Class_168.dmethod_916(arg_0);
					}
					else
					{
						arg_0.field_34 = num6;
						stream.Seek((long)((ulong)num6), SeekOrigin.Begin);
					}
					Class_168.lmethod_918(arg_0);
				}
				else
				{
					stream.Seek(0L, SeekOrigin.Begin);
					Class_168.pmethod_919(arg_0);
				}
			}
			catch (Exception arg_)
			{
				if (arg_0.field_26 && arg_0.field_2 != null)
				{
					arg_0.field_2.Dispose();
					arg_0.field_2 = null;
				}
				throw new Class_135("Cannot read that as a ZipFile", arg_);
			}
			arg_0.field_23 = false;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00023064 File Offset: 0x00021264
		private static void dmethod_916(Class_168 arg_0)
		{
			Stream stream = arg_0.prop_44;
			byte[] array = new byte[16];
			stream.Seek(-40L, SeekOrigin.Current);
			stream.Read(array, 0, 16);
			long offset = BitConverter.ToInt64(array, 8);
			arg_0.field_34 = uint.MaxValue;
			arg_0.field_35 = offset;
			stream.Seek(offset, SeekOrigin.Begin);
			uint num = (uint)Class_155.ReadInt(stream);
			if (num != 101075792U)
			{
				throw new Class_137(string.Format("  Bad signature (0x{0:X8}) looking for ZIP64 EoCD Record at position 0x{1:X8}", num, stream.Position));
			}
			stream.Read(array, 0, 8);
			long num2 = BitConverter.ToInt64(array, 0);
			array = new byte[num2];
			stream.Read(array, 0, array.Length);
			offset = BitConverter.ToInt64(array, 36);
			stream.Seek(offset, SeekOrigin.Begin);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00023124 File Offset: 0x00021324
		private static uint kmethod_917(Stream stream_)
		{
			return (uint)Class_155.ReadInt(stream_);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002313C File Offset: 0x0002133C
		private static void lmethod_918(Class_168 arg_0)
		{
			bool flag = false;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			Class_163 class_;
			while ((class_ = Class_163.smethod_590(arg_0, dictionary)) != null)
			{
				class_.lmethod_588();
				arg_0.lmethod_888(true, null);
				if (arg_0.prop_14)
				{
					arg_0.prop_25.WriteLine("entry {0}", class_.prop_12);
				}
				arg_0.field_11.Add(class_.prop_12, class_);
				if (class_.field_51)
				{
					flag = true;
				}
				dictionary.Add(class_.prop_12, null);
			}
			if (flag)
			{
				arg_0.prop_17 = Class_169.Always;
			}
			if (arg_0.field_33 > 0L)
			{
				arg_0.prop_44.Seek(arg_0.field_33, SeekOrigin.Begin);
			}
			Class_168.smethod_920(arg_0);
			if (arg_0.prop_14 && !string.IsNullOrEmpty(arg_0.prop_11))
			{
				arg_0.prop_25.WriteLine("Zip file Comment: {0}", arg_0.prop_11);
			}
			if (arg_0.prop_14)
			{
				arg_0.prop_25.WriteLine("read in {0} entries.", arg_0.field_11.Count);
			}
			arg_0.dmethod_886();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00023254 File Offset: 0x00021454
		private static void pmethod_919(Class_168 arg_0)
		{
			arg_0.vmethod_885();
			arg_0.field_11 = new Dictionary<string, Class_163>();
			if (arg_0.prop_14)
			{
				if (arg_0.prop_8 == null)
				{
					arg_0.prop_25.WriteLine("Reading zip from stream...");
				}
				else
				{
					arg_0.prop_25.WriteLine("Reading zip {0}...", arg_0.prop_8);
				}
			}
			bool bool_ = true;
			Class_178 arg_ = new Class_178(arg_0);
			Class_163 class_;
			while ((class_ = Class_163.kmethod_707(arg_, bool_)) != null)
			{
				if (arg_0.prop_14)
				{
					arg_0.prop_25.WriteLine("  {0}", class_.prop_12);
				}
				arg_0.field_11.Add(class_.prop_12, class_);
				bool_ = false;
			}
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				Class_163 class_2;
				while ((class_2 = Class_163.smethod_590(arg_0, dictionary)) != null)
				{
					Class_163 class_3 = arg_0.field_11[class_2.prop_12];
					if (class_3 != null)
					{
						class_3.field_26 = class_2.prop_17;
						if (class_2.prop_27)
						{
							class_3.smethod_660();
						}
					}
					dictionary.Add(class_2.prop_12, null);
				}
				if (arg_0.field_33 > 0L)
				{
					arg_0.prop_44.Seek(arg_0.field_33, SeekOrigin.Begin);
				}
				Class_168.smethod_920(arg_0);
				if (arg_0.prop_14 && !string.IsNullOrEmpty(arg_0.prop_11))
				{
					arg_0.prop_25.WriteLine("Zip file Comment: {0}", arg_0.prop_11);
				}
			}
			catch (Class_135)
			{
			}
			catch (IOException)
			{
			}
			arg_0.dmethod_886();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000233EC File Offset: 0x000215EC
		private static void smethod_920(Class_168 arg_0)
		{
			Stream stream = arg_0.prop_44;
			int num = Class_155.ReadSignature(stream);
			int num2 = 0;
			byte[] array;
			if ((long)num == 101075792L)
			{
				array = new byte[52];
				stream.Read(array, 0, array.Length);
				long num3 = BitConverter.ToInt64(array, 0);
				if (num3 < 44L)
				{
					throw new Class_135("Bad size in the ZIP64 Central Directory.");
				}
				arg_0.field_4 = BitConverter.ToUInt16(array, num2);
				num2 += 2;
				arg_0.field_5 = BitConverter.ToUInt16(array, num2);
				num2 += 2;
				arg_0.field_6 = BitConverter.ToUInt32(array, num2);
				num2 += 2;
				array = new byte[num3 - 44L];
				stream.Read(array, 0, array.Length);
				num = Class_155.ReadSignature(stream);
				if ((long)num != 117853008L)
				{
					throw new Class_135("Inconsistent metadata in the ZIP64 Central Directory.");
				}
				array = new byte[16];
				stream.Read(array, 0, array.Length);
				num = Class_155.ReadSignature(stream);
			}
			if ((long)num != 101010256L)
			{
				stream.Seek(-4L, SeekOrigin.Current);
				throw new Class_137(string.Format("Bad signature ({0:X8}) at position 0x{1:X8}", num, stream.Position));
			}
			array = new byte[16];
			arg_0.prop_44.Read(array, 0, array.Length);
			if (arg_0.field_6 == 0U)
			{
				arg_0.field_6 = (uint)BitConverter.ToUInt16(array, 2);
			}
			Class_168.xmethod_921(arg_0);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00023540 File Offset: 0x00021740
		private static void xmethod_921(Class_168 arg_0)
		{
			byte[] array = new byte[2];
			arg_0.prop_44.Read(array, 0, array.Length);
			short num = (short)((int)array[0] + (int)array[1] * 256);
			if (num > 0)
			{
				array = new byte[(int)num];
				arg_0.prop_44.Read(array, 0, array.Length);
				string @string = arg_0.prop_22.GetString(array, 0, array.Length);
				arg_0.prop_11 = @string;
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000235AB File Offset: 0x000217AB
		public static bool tmethod_922(string str_0)
		{
			return Class_168.gmethod_923(str_0, false);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000235B4 File Offset: 0x000217B4
		public static bool gmethod_923(string str_0, bool bool_0)
		{
			bool result = false;
			try
			{
				if (!File.Exists(str_0))
				{
					return false;
				}
				using (FileStream fileStream = File.Open(str_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					result = Class_168.cmethod_924(fileStream, bool_0);
				}
			}
			catch (IOException)
			{
			}
			catch (Class_135)
			{
			}
			return result;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00023638 File Offset: 0x00021838
		public static bool cmethod_924(Stream stream_, bool bool_0)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("stream");
			}
			bool result = false;
			try
			{
				if (!stream_.CanRead)
				{
					return false;
				}
				Stream @null = Stream.Null;
				using (Class_168 class_ = Class_168.cmethod_914(stream_, null, null, null))
				{
					if (bool_0)
					{
						using (IEnumerator<Class_163> enumerator = class_.dmethod_956())
						{
							while (enumerator.MoveNext())
							{
								Class_163 class_2 = enumerator.Current;
								if (!class_2.prop_27)
								{
									class_2.tmethod_672(@null);
								}
							}
						}
					}
				}
				result = true;
			}
			catch (IOException)
			{
			}
			catch (Class_135)
			{
			}
			return result;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00023724 File Offset: 0x00021924
		private void vmethod_925(string str_0)
		{
			bool flag = false;
			int num = 3;
			int num2 = 0;
			while (num2 < num && !flag)
			{
				try
				{
					File.Delete(str_0);
					flag = true;
				}
				catch (UnauthorizedAccessException)
				{
					Console.WriteLine("************************************************** Retry delete.");
					Thread.Sleep(200 + num2 * 200);
				}
				num2++;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002378C File Offset: 0x0002198C
		public void dmethod_926()
		{
			try
			{
				bool flag = false;
				this.field_28 = false;
				this.field_8 = 0U;
				this.xmethod_881();
				if (this.prop_45 == null)
				{
					throw new Class_140("You haven't specified where to save the zip.");
				}
				if (this.field_13 != null && this.field_13.EndsWith(".exe") && !this.field_46)
				{
					throw new Class_140("You specified an EXE for a plain zip file.");
				}
				if (!this.field_23)
				{
					this.tmethod_882();
					if (this.prop_14)
					{
						this.prop_25.WriteLine("No save is necessary....");
					}
				}
				else
				{
					this.kmethod_857(true);
					if (this.prop_14)
					{
						this.prop_25.WriteLine("saving....");
					}
					if (this.field_11.Count >= 65535 && this.field_45 == Class_169.Default)
					{
						throw new Class_135("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
					}
					int num = 0;
					ICollection<Class_163> collection = this.prop_2 ? this.prop_42 : this.prop_41;
					foreach (Class_163 class_ in collection)
					{
						this.pmethod_879(num, class_, true);
						class_.lmethod_738(this.prop_45);
						if (this.field_28)
						{
							break;
						}
						num++;
						this.pmethod_879(num, class_, false);
						if (this.field_28)
						{
							break;
						}
						if (class_.prop_34)
						{
							flag |= class_.prop_19.Value;
						}
					}
					if (!this.field_28)
					{
						Class_179 class_2 = this.prop_45 as Class_179;
						this.field_8 = ((class_2 != null) ? class_2.prop_1 : 1U);
						bool flag2 = Class_173.WriteCentralDirectoryStructure(this.prop_45, collection, this.field_8, this.field_45, this.prop_11, new Class_178(this));
						this.smethod_880(Class_128.Saving_AfterSaveTempArchive);
						this.field_24 = true;
						this.field_23 = false;
						flag = (flag || flag2);
						this.field_36 = new bool?(flag);
						if (this.field_13 != null && (this.field_22 != null || class_2 != null))
						{
							this.prop_45.Dispose();
							if (this.field_28)
							{
								return;
							}
							if (this.field_21 && this.field_2 != null)
							{
								this.field_2.Close();
								this.field_2 = null;
								foreach (Class_163 class_3 in collection)
								{
									Class_179 class_4 = class_3.field_58 as Class_179;
									if (class_4 != null)
									{
										class_4.Dispose();
									}
									class_3.field_58 = null;
								}
							}
							string text = null;
							if (File.Exists(this.field_13))
							{
								text = this.field_13 + "." + Path.GetRandomFileName();
								if (File.Exists(text))
								{
									this.vmethod_925(text);
								}
								File.Move(this.field_13, text);
							}
							this.smethod_880(Class_128.Saving_BeforeRenameTempArchive);
							File.Move((class_2 != null) ? class_2.prop_3 : this.field_22, this.field_13);
							this.smethod_880(Class_128.Saving_AfterRenameTempArchive);
							if (text != null)
							{
								try
								{
									if (File.Exists(text))
									{
										File.Delete(text);
									}
								}
								catch
								{
								}
							}
							this.field_21 = true;
						}
						Class_168.kmethod_927(collection);
						this.tmethod_882();
						this.field_32 = true;
					}
				}
			}
			finally
			{
				this.pmethod_929();
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00023B8C File Offset: 0x00021D8C
		private static void kmethod_927(ICollection<Class_163> arg_0)
		{
			foreach (Class_163 class_ in arg_0)
			{
				class_.smethod_740();
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00023BDC File Offset: 0x00021DDC
		private void lmethod_928()
		{
			try
			{
				if (File.Exists(this.field_22))
				{
					File.Delete(this.field_22);
				}
			}
			catch (IOException ex)
			{
				if (this.prop_14)
				{
					this.prop_25.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
				}
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00023C40 File Offset: 0x00021E40
		private void pmethod_929()
		{
			if (this.field_13 != null)
			{
				if (this.field_3 != null)
				{
					try
					{
						this.field_3.Dispose();
					}
					catch (IOException)
					{
					}
				}
				this.field_3 = null;
				if (this.field_22 != null)
				{
					this.lmethod_928();
					this.field_22 = null;
				}
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00023CA8 File Offset: 0x00021EA8
		public void smethod_930(string str_0)
		{
			if (this.field_13 == null)
			{
				this.field_3 = null;
			}
			else
			{
				this.field_14 = this.field_13;
			}
			this.field_13 = str_0;
			if (Directory.Exists(this.field_13))
			{
				throw new Class_135("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
			}
			this.field_23 = true;
			this.field_21 = File.Exists(this.field_13);
			this.dmethod_926();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00023D28 File Offset: 0x00021F28
		public void xmethod_931(Stream stream_)
		{
			if (stream_ == null)
			{
				throw new ArgumentNullException("outputStream");
			}
			if (!stream_.CanWrite)
			{
				throw new ArgumentException("Must be a writable stream.", "outputStream");
			}
			this.field_13 = null;
			this.field_3 = new Class_156(stream_);
			this.field_23 = true;
			this.field_21 = false;
			this.dmethod_926();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00023D88 File Offset: 0x00021F88
		public void tmethod_932(string str_0, Class_174 arg_0)
		{
			this.gmethod_933(str_0, new Class_175
			{
				prop_0 = arg_0
			});
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00023DAC File Offset: 0x00021FAC
		public void gmethod_933(string str_0, Class_175 arg_0)
		{
			if (this.field_13 == null)
			{
				this.field_3 = null;
			}
			this.field_46 = true;
			this.field_13 = str_0;
			if (Directory.Exists(this.field_13))
			{
				throw new Class_135("Bad Directory", new ArgumentException("That name specifies an existing directory. Please specify a filename.", "exeToGenerate"));
			}
			this.field_23 = true;
			this.field_21 = File.Exists(this.field_13);
			this.vmethod_935(str_0, arg_0);
			this.dmethod_926();
			this.field_46 = false;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00023E30 File Offset: 0x00022030
		private static void cmethod_934(Assembly arg_0, string str_0, string str_1)
		{
			byte[] array = new byte[1024];
			using (Stream manifestResourceStream = arg_0.GetManifestResourceStream(str_0))
			{
				if (manifestResourceStream == null)
				{
					throw new Class_135(string.Format("missing resource '{0}'", str_0));
				}
				using (FileStream fileStream = File.OpenWrite(str_1))
				{
					int num;
					do
					{
						num = manifestResourceStream.Read(array, 0, array.Length);
						fileStream.Write(array, 0, num);
					}
					while (num > 0);
				}
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00023ECC File Offset: 0x000220CC
		private void vmethod_935(string str_0, Class_175 arg_0)
		{
			string text = null;
			string text2 = null;
			string str_ = null;
			try
			{
				if (File.Exists(str_0) && this.prop_14)
				{
					this.prop_25.WriteLine("The existing file ({0}) will be overwritten.", str_0);
				}
				if (!str_0.EndsWith(".exe") && this.prop_14)
				{
					this.prop_25.WriteLine("Warning: The generated self-extracting file will not have an .exe extension.");
				}
				str_ = (this.prop_26 ?? Path.GetDirectoryName(str_0));
				text = Class_168.dmethod_936(str_, "exe");
				Assembly assembly = typeof(Class_168).Assembly;
				using (CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider())
				{
					Class_168.NClass_0 nclass_ = null;
					foreach (Class_168.NClass_0 nclass_2 in Class_168.field_54)
					{
						if (nclass_2.field_83 == arg_0.prop_0)
						{
							nclass_ = nclass_2;
							break;
						}
					}
					if (nclass_ == null)
					{
						throw new Class_140(string.Format("While saving a Self-Extracting Zip, Cannot find that flavor ({0})?", arg_0.prop_0));
					}
					CompilerParameters compilerParameters = new CompilerParameters();
					compilerParameters.ReferencedAssemblies.Add(assembly.Location);
					if (nclass_.field_84 != null)
					{
						foreach (string value in nclass_.field_84)
						{
							compilerParameters.ReferencedAssemblies.Add(value);
						}
					}
					compilerParameters.GenerateInMemory = false;
					compilerParameters.GenerateExecutable = true;
					compilerParameters.IncludeDebugInformation = false;
					compilerParameters.CompilerOptions = "";
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					StringBuilder stringBuilder = new StringBuilder();
					string text3 = Class_168.dmethod_936(str_, "cs");
					using (Class_168 class_ = Class_168.tmethod_912(executingAssembly.GetManifestResourceStream("Ionic.Zip.Resources.ZippedResources.zip")))
					{
						text2 = Class_168.dmethod_936(str_, "tmp");
						if (string.IsNullOrEmpty(arg_0.prop_3))
						{
							Directory.CreateDirectory(text2);
							Class_163 class_2 = class_.gmethod_863("zippedFile.ico");
							if ((class_2.prop_10 & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
							{
								Class_163 class_3 = class_2;
								class_3.prop_10 = class_3.prop_10;
							}
							class_2.gmethod_673(text2);
							string arg = Path.Combine(text2, "zippedFile.ico");
							CompilerParameters compilerParameters2 = compilerParameters;
							compilerParameters2.CompilerOptions += string.Format("/win32icon:\"{0}\"", arg);
						}
						else
						{
							CompilerParameters compilerParameters3 = compilerParameters;
							compilerParameters3.CompilerOptions += string.Format("/win32icon:\"{0}\"", arg_0.prop_3);
						}
						compilerParameters.OutputAssembly = text;
						if (arg_0.prop_0 == Class_174.WinFormsApplication)
						{
							CompilerParameters compilerParameters4 = compilerParameters;
							compilerParameters4.CompilerOptions += " /target:winexe";
						}
						if (!string.IsNullOrEmpty(arg_0.prop_13))
						{
							CompilerParameters compilerParameters5 = compilerParameters;
							compilerParameters5.CompilerOptions = compilerParameters5.CompilerOptions + " " + arg_0.prop_13;
						}
						if (string.IsNullOrEmpty(compilerParameters.CompilerOptions))
						{
							compilerParameters.CompilerOptions = null;
						}
						if (nclass_.field_85 != null && nclass_.field_85.Count != 0)
						{
							if (!Directory.Exists(text2))
							{
								Directory.CreateDirectory(text2);
							}
							foreach (string text4 in nclass_.field_85)
							{
								string text5 = Path.Combine(text2, text4);
								Class_168.cmethod_934(executingAssembly, text4, text5);
								compilerParameters.EmbeddedResources.Add(text5);
							}
						}
						compilerParameters.EmbeddedResources.Add(assembly.Location);
						stringBuilder.Append("// " + Path.GetFileName(text3) + "\n").Append("// --------------------------------------------\n//\n").Append("// This SFX source file was generated by DotNetZip ").Append(Class_168.prop_36.ToString()).Append("\n//         at ").Append(DateTime.Now.ToString("yyyy MMMM dd  HH:mm:ss")).Append("\n//\n// --------------------------------------------\n\n\n");
						if (!string.IsNullOrEmpty(arg_0.prop_10))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"" + arg_0.prop_10.Replace("\"", "") + "\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"DotNetZip SFX Archive\")]\n");
						}
						if (!string.IsNullOrEmpty(arg_0.prop_8))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyInformationalVersion(\"" + arg_0.prop_8.Replace("\"", "") + "\")]\n");
						}
						string str = string.IsNullOrEmpty(arg_0.prop_9) ? "Extractor: Copyright © Dino Chiesa 2008-2011" : arg_0.prop_9.Replace("\"", "");
						if (!string.IsNullOrEmpty(arg_0.prop_11))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"").Append(arg_0.prop_11.Replace("\"", "")).Append("\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"DotNetZip\")]\n");
						}
						stringBuilder.Append("[assembly: System.Reflection.AssemblyCopyright(\"" + str + "\")]\n").Append(string.Format("[assembly: System.Reflection.AssemblyVersion(\"{0}\")]\n", Class_168.prop_36.ToString()));
						if (arg_0.prop_7 != null)
						{
							stringBuilder.Append(string.Format("[assembly: System.Reflection.AssemblyFileVersion(\"{0}\")]\n", arg_0.prop_7.ToString()));
						}
						stringBuilder.Append("\n\n\n");
						string text6 = arg_0.prop_2;
						if (text6 != null)
						{
							text6 = text6.Replace("\"", "").Replace("\\", "\\\\");
						}
						string text7 = arg_0.prop_1;
						if (text7 != null)
						{
							text7 = text7.Replace("\\", "\\\\");
							text7 = text7.Replace("\"", "\\\"");
						}
						foreach (string text8 in nclass_.field_86)
						{
							using (Stream stream = class_.gmethod_863(text8).smethod_680())
							{
								if (stream == null)
								{
									throw new Class_135(string.Format("missing resource '{0}'", text8));
								}
								using (StreamReader streamReader = new StreamReader(stream))
								{
									while (streamReader.Peek() >= 0)
									{
										string text9 = streamReader.ReadLine();
										if (text6 != null)
										{
											text9 = text9.Replace("@@EXTRACTLOCATION", text6);
										}
										text9 = text9.Replace("@@REMOVE_AFTER_EXECUTE", arg_0.prop_6.ToString());
										text9 = text9.Replace("@@QUIET", arg_0.prop_4.ToString());
										if (!string.IsNullOrEmpty(arg_0.prop_12))
										{
											text9 = text9.Replace("@@SFX_EXE_WINDOW_TITLE", arg_0.prop_12);
										}
										text9 = text9.Replace("@@EXTRACT_EXISTING_FILE", ((int)arg_0.prop_5).ToString());
										if (text7 != null)
										{
											text9 = text9.Replace("@@POST_UNPACK_CMD_LINE", text7);
										}
										stringBuilder.Append(text9).Append("\n");
									}
								}
								stringBuilder.Append("\n\n");
							}
						}
					}
					string text10 = stringBuilder.ToString();
					CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
					{
						text10
					});
					if (compilerResults == null)
					{
						throw new Class_139("Cannot compile the extraction logic!");
					}
					if (this.prop_14)
					{
						foreach (string value2 in compilerResults.Output)
						{
							this.prop_25.WriteLine(value2);
						}
					}
					if (compilerResults.Errors.Count != 0)
					{
						using (TextWriter textWriter = new StreamWriter(text3))
						{
							textWriter.Write(text10);
							textWriter.Write("\n\n\n// ------------------------------------------------------------------\n");
							textWriter.Write("// Errors during compilation: \n//\n");
							string fileName = Path.GetFileName(text3);
							foreach (object obj in compilerResults.Errors)
							{
								CompilerError compilerError = (CompilerError)obj;
								textWriter.Write(string.Format("//   {0}({1},{2}): {3} {4}: {5}\n//\n", new object[]
								{
									fileName,
									compilerError.Line,
									compilerError.Column,
									compilerError.IsWarning ? "Warning" : "error",
									compilerError.ErrorNumber,
									compilerError.ErrorText
								}));
							}
						}
						throw new Class_139(string.Format("Errors compiling the extraction logic!  {0}", text3));
					}
					this.smethod_880(Class_128.Saving_AfterCompileSelfExtractor);
					using (Stream stream2 = File.OpenRead(text))
					{
						byte[] array2 = new byte[4000];
						int num = 1;
						while (num != 0)
						{
							num = stream2.Read(array2, 0, array2.Length);
							if (num != 0)
							{
								this.prop_45.Write(array2, 0, num);
							}
						}
					}
				}
				this.smethod_880(Class_128.Saving_AfterSaveTempArchive);
			}
			finally
			{
				try
				{
					if (Directory.Exists(text2))
					{
						try
						{
							Directory.Delete(text2, true);
						}
						catch (IOException arg2)
						{
							this.prop_25.WriteLine("Warning: Exception: {0}", arg2);
						}
					}
					if (File.Exists(text))
					{
						try
						{
							File.Delete(text);
						}
						catch (IOException arg3)
						{
							this.prop_25.WriteLine("Warning: Exception: {0}", arg3);
						}
					}
				}
				catch (IOException)
				{
				}
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00024A40 File Offset: 0x00022C40
		internal static string dmethod_936(string str_0, string str_1)
		{
			string name = Assembly.GetExecutingAssembly().GetName().Name;
			string text2;
			do
			{
				string text = Guid.NewGuid().ToString();
				string path = string.Format("{0}-{1}-{2}.{3}", new object[]
				{
					name,
					DateTime.Now.ToString("yyyyMMMdd-HHmmss"),
					text,
					str_1
				});
				text2 = Path.Combine(str_0, path);
			}
			while (File.Exists(text2) || Directory.Exists(text2));
			return text2;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00024AC9 File Offset: 0x00022CC9
		public void kmethod_937(string str_0)
		{
			this.tmethod_942(str_0, ".", null, false);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00024AD9 File Offset: 0x00022CD9
		public void lmethod_938(string str_0, bool bool_0)
		{
			this.tmethod_942(str_0, ".", null, bool_0);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00024AE9 File Offset: 0x00022CE9
		public void pmethod_939(string str_0, string str_1)
		{
			this.tmethod_942(str_0, str_1, null, false);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00024AF5 File Offset: 0x00022CF5
		public void smethod_940(string str_0, string str_1, bool bool_0)
		{
			this.tmethod_942(str_0, str_1, null, bool_0);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00024B01 File Offset: 0x00022D01
		public void xmethod_941(string str_0, string str_1, string str_2)
		{
			this.tmethod_942(str_0, str_1, str_2, false);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00024B0D File Offset: 0x00022D0D
		public void tmethod_942(string str_0, string str_1, string str_2, bool bool_0)
		{
			this.vmethod_945(str_0, str_1, str_2, bool_0, false);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00024B1B File Offset: 0x00022D1B
		public void gmethod_943(string str_0, string str_1, string str_2, bool bool_0)
		{
			this.vmethod_945(str_0, str_1, str_2, bool_0, true);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00024B29 File Offset: 0x00022D29
		private string cmethod_944(string str_0)
		{
			if (str_0.EndsWith("\\"))
			{
				return str_0;
			}
			return str_0 + "\\";
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00024B48 File Offset: 0x00022D48
		private void vmethod_945(string str_0, string str_1, string str_2, bool bool_0, bool bool_1)
		{
			if (str_1 == null && Directory.Exists(str_0))
			{
				str_1 = str_0;
				str_0 = "*.*";
			}
			else if (string.IsNullOrEmpty(str_1))
			{
				str_1 = ".";
			}
			while (str_1.EndsWith("\\"))
			{
				str_1 = str_1.Substring(0, str_1.Length - 1);
			}
			if (this.prop_14)
			{
				this.prop_25.WriteLine("adding selection '{0}' from dir '{1}'...", str_0, str_1);
			}
			Class_152 class_ = new Class_152(str_0, this.prop_3);
			ReadOnlyCollection<string> readOnlyCollection = class_.cmethod_504(str_1, bool_0);
			if (this.prop_14)
			{
				this.prop_25.WriteLine("found {0} files...", readOnlyCollection.Count);
			}
			this.smethod_900();
			Class_171 arg_ = bool_1 ? Class_171.AddOrUpdate : Class_171.AddOnly;
			foreach (string text in readOnlyCollection)
			{
				string str_3 = (str_2 == null) ? null : Class_168.dmethod_946(Path.GetDirectoryName(text), str_1, str_2);
				if (File.Exists(text))
				{
					if (bool_1)
					{
						this.lmethod_758(text, str_3);
					}
					else
					{
						this.pmethod_749(text, str_3);
					}
				}
				else
				{
					this.tmethod_782(text, str_3, arg_, false, 0);
				}
			}
			this.xmethod_901();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00024CBC File Offset: 0x00022EBC
		private static string dmethod_946(string str_0, string str_1, string str_2)
		{
			string text = str_0.ToUpper();
			string text2 = str_1.ToUpper();
			int num = text.IndexOf(text2);
			if (num != 0)
			{
				return str_0;
			}
			return str_2 + str_0.Substring(text2.Length);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00024CFC File Offset: 0x00022EFC
		public ICollection<Class_163> kmethod_947(string str_0)
		{
			Class_152 class_ = new Class_152(str_0, this.prop_3);
			return class_.dmethod_506(this);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00024D20 File Offset: 0x00022F20
		public ICollection<Class_163> lmethod_948(string str_0, string str_1)
		{
			Class_152 class_ = new Class_152(str_0, this.prop_3);
			return class_.kmethod_507(this, str_1);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00024D44 File Offset: 0x00022F44
		public int pmethod_949(string str_0)
		{
			ICollection<Class_163> collection = this.kmethod_947(str_0);
			this.smethod_750(collection);
			return collection.Count;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00024D68 File Offset: 0x00022F68
		public int smethod_950(string str_0, string str_1)
		{
			ICollection<Class_163> collection = this.lmethod_948(str_0, str_1);
			this.smethod_750(collection);
			return collection.Count;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00024D8C File Offset: 0x00022F8C
		public void xmethod_951(string str_0)
		{
			foreach (Class_163 class_ in this.kmethod_947(str_0))
			{
				class_.prop_30 = this.field_16;
				class_.smethod_670();
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00024DF0 File Offset: 0x00022FF0
		public void tmethod_952(string str_0, Class_141 arg_0)
		{
			foreach (Class_163 class_ in this.kmethod_947(str_0))
			{
				class_.prop_30 = this.field_16;
				class_.xmethod_671(arg_0);
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00024E54 File Offset: 0x00023054
		public void gmethod_953(string str_0, string str_1)
		{
			foreach (Class_163 class_ in this.lmethod_948(str_0, str_1))
			{
				class_.prop_30 = this.field_16;
				class_.smethod_670();
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00024EB8 File Offset: 0x000230B8
		public void cmethod_954(string str_0, string str_1, string str_2)
		{
			foreach (Class_163 class_ in this.lmethod_948(str_0, str_1))
			{
				class_.prop_30 = this.field_16;
				class_.gmethod_673(str_2);
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00024F1C File Offset: 0x0002311C
		public void vmethod_955(string str_0, string str_1, string str_2, Class_141 arg_0)
		{
			foreach (Class_163 class_ in this.lmethod_948(str_0, str_1))
			{
				class_.prop_30 = this.field_16;
				class_.cmethod_674(str_2, arg_0);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00024F84 File Offset: 0x00023184
		public IEnumerator<Class_163> dmethod_956()
		{
			foreach (Class_163 class_ in this.field_11.Values)
			{
				yield return class_;
			}
			yield break;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00024FA0 File Offset: 0x000231A0
		IEnumerator IEnumerable.kmethod_957()
		{
			return this.dmethod_956();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00024FA0 File Offset: 0x000231A0
		[DispId(-4)]
		public IEnumerator lmethod_958()
		{
			return this.dmethod_956();
		}

		// Token: 0x040002FC RID: 764
		private TextWriter field_0;

		// Token: 0x040002FD RID: 765
		private bool field_1;

		// Token: 0x040002FE RID: 766
		private Stream field_2;

		// Token: 0x040002FF RID: 767
		private Stream field_3;

		// Token: 0x04000300 RID: 768
		private ushort field_4;

		// Token: 0x04000301 RID: 769
		private ushort field_5;

		// Token: 0x04000302 RID: 770
		private uint field_6;

		// Token: 0x04000303 RID: 771
		private int field_7;

		// Token: 0x04000304 RID: 772
		private uint field_8;

		// Token: 0x04000305 RID: 773
		private Class_167 field_9;

		// Token: 0x04000306 RID: 774
		private bool field_10;

		// Token: 0x04000307 RID: 775
		private Dictionary<string, Class_163> field_11;

		// Token: 0x04000308 RID: 776
		private List<Class_163> field_12;

		// Token: 0x04000309 RID: 777
		private string field_13;

		// Token: 0x0400030A RID: 778
		private string field_14;

		// Token: 0x0400030B RID: 779
		private string field_15;

		// Token: 0x0400030C RID: 780
		internal string field_16;

		// Token: 0x0400030D RID: 781
		private bool field_17 = true;

		// Token: 0x0400030E RID: 782
		private bool field_18;

		// Token: 0x0400030F RID: 783
		private Class_203 field_19;

		// Token: 0x04000310 RID: 784
		private Class_165 field_20 = Class_165.Deflate;

		// Token: 0x04000311 RID: 785
		private bool field_21;

		// Token: 0x04000312 RID: 786
		private string field_22;

		// Token: 0x04000313 RID: 787
		private bool field_23;

		// Token: 0x04000314 RID: 788
		private bool field_24;

		// Token: 0x04000315 RID: 789
		private string field_25;

		// Token: 0x04000316 RID: 790
		private bool field_26 = true;

		// Token: 0x04000317 RID: 791
		private object field_27 = new object();

		// Token: 0x04000318 RID: 792
		private bool field_28;

		// Token: 0x04000319 RID: 793
		private bool field_29;

		// Token: 0x0400031A RID: 794
		private bool field_30;

		// Token: 0x0400031B RID: 795
		private Class_123 field_31;

		// Token: 0x0400031C RID: 796
		private bool field_32;

		// Token: 0x0400031D RID: 797
		private long field_33 = -1L;

		// Token: 0x0400031E RID: 798
		private uint field_34;

		// Token: 0x0400031F RID: 799
		private long field_35;

		// Token: 0x04000320 RID: 800
		private bool? field_36;

		// Token: 0x04000321 RID: 801
		internal bool field_37;

		// Token: 0x04000322 RID: 802
		private Encoding field_38 = Encoding.GetEncoding("IBM437");

		// Token: 0x04000323 RID: 803
		private Class_170 field_39;

		// Token: 0x04000324 RID: 804
		private static Encoding field_40 = Encoding.GetEncoding("IBM437");

		// Token: 0x04000325 RID: 805
		private int field_41 = Class_168.field_47;

		// Token: 0x04000326 RID: 806
		internal Class_199 field_42;

		// Token: 0x04000327 RID: 807
		private long field_43;

		// Token: 0x04000328 RID: 808
		private int field_44 = 16;

		// Token: 0x04000329 RID: 809
		internal Class_169 field_45;

		// Token: 0x0400032A RID: 810
		private bool field_46;

		// Token: 0x0400032B RID: 811
		public static readonly int field_47 = 32768;

		// Token: 0x0400032C RID: 812
		private EventHandler<Class_132> field_48;

		// Token: 0x0400032D RID: 813
		private EventHandler<Class_130> field_49;

		// Token: 0x0400032E RID: 814
		private long field_50 = -99L;

		// Token: 0x0400032F RID: 815
		private EventHandler<Class_133> field_51;

		// Token: 0x04000330 RID: 816
		private EventHandler<Class_131> field_52;

		// Token: 0x04000331 RID: 817
		private EventHandler<Class_134> field_53;

		// Token: 0x04000332 RID: 818
		private static Class_168.NClass_0[] field_54 = new Class_168.NClass_0[]
		{
			new Class_168.NClass_0
			{
				field_83 = Class_174.WinFormsApplication,
				field_84 = new List<string>
				{
					"System.dll",
					"System.Windows.Forms.dll",
					"System.Drawing.dll"
				},
				field_85 = new List<string>
				{
					"Ionic.Zip.WinFormsSelfExtractorStub.resources",
					"Ionic.Zip.Forms.PasswordDialog.resources",
					"Ionic.Zip.Forms.ZipContentsDialog.resources"
				},
				field_86 = new List<string>
				{
					"WinFormsSelfExtractorStub.cs",
					"WinFormsSelfExtractorStub.Designer.cs",
					"PasswordDialog.cs",
					"PasswordDialog.Designer.cs",
					"ZipContentsDialog.cs",
					"ZipContentsDialog.Designer.cs",
					"FolderBrowserDialogEx.cs"
				}
			},
			new Class_168.NClass_0
			{
				field_83 = Class_174.ConsoleApplication,
				field_84 = new List<string>
				{
					"System.dll"
				},
				field_85 = null,
				field_86 = new List<string>
				{
					"CommandLineSelfExtractorStub.cs"
				}
			}
		};

		// Token: 0x04000333 RID: 819
		[CompilerGenerated]
		private bool field_55;

		// Token: 0x04000334 RID: 820
		[CompilerGenerated]
		private bool field_56;

		// Token: 0x04000335 RID: 821
		[CompilerGenerated]
		private bool field_57;

		// Token: 0x04000336 RID: 822
		[CompilerGenerated]
		private int field_58;

		// Token: 0x04000337 RID: 823
		[CompilerGenerated]
		private bool field_59;

		// Token: 0x04000338 RID: 824
		[CompilerGenerated]
		private Class_202 field_60;

		// Token: 0x04000339 RID: 825
		[CompilerGenerated]
		private Class_141 field_61;

		// Token: 0x0400033A RID: 826
		[CompilerGenerated]
		private Class_127 field_62;

		// Token: 0x020000D6 RID: 214
		private class NClass_0
		{
			// Token: 0x06000586 RID: 1414 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_0()
			{
				base..ctor();
			}

			// Token: 0x0400033B RID: 827
			public Class_174 field_83;

			// Token: 0x0400033C RID: 828
			public List<string> field_84;

			// Token: 0x0400033D RID: 829
			public List<string> field_85;

			// Token: 0x0400033E RID: 830
			public List<string> field_86;
		}

		// Token: 0x020000D7 RID: 215
		[CompilerGenerated]
		private sealed class NClass_1
		{
			// Token: 0x06000587 RID: 1415 RVA: 0x0000237C File Offset: 0x0000057C
			public void nmethod_1()
			{
				base..ctor();
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x000250FF File Offset: 0x000232FF
			public int nmethod_2(Class_163 arg_0, Class_163 arg_1)
			{
				return string.Compare(arg_0.prop_12, arg_1.prop_12, this.field_87);
			}

			// Token: 0x0400033F RID: 831
			public StringComparison field_87;
		}
	}
}
