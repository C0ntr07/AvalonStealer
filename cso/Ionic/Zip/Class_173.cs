using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Ionic.Zip
{
	// Token: 0x020000DD RID: 221
	internal static class Class_173
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x00025280 File Offset: 0x00023480
		public static bool WriteCentralDirectoryStructure(Stream s, ICollection<Class_163> entries, uint numSegments, Class_169 zip64, string comment, Class_178 container)
		{
			Class_179 class_ = s as Class_179;
			if (class_ != null)
			{
				class_.prop_0 = true;
			}
			long num = 0L;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				foreach (Class_163 class_2 in entries)
				{
					if (class_2.prop_34)
					{
						class_2.lmethod_718(memoryStream);
					}
				}
				byte[] array = memoryStream.ToArray();
				s.Write(array, 0, array.Length);
				num = (long)array.Length;
			}
			Class_156 class_3 = s as Class_156;
			long num2 = (class_3 != null) ? class_3.prop_7 : s.Position;
			long num3 = num2 - num;
			uint num4 = (class_ != null) ? class_.prop_1 : 0U;
			long num5 = num2 - num3;
			int num6 = Class_173.CountEntries(entries);
			bool flag = zip64 == Class_169.Always || num6 >= 65535 || num5 > (long)((ulong)-1) || num3 > (long)((ulong)-1);
			byte[] array3;
			if (flag)
			{
				if (zip64 == Class_169.Default)
				{
					StackFrame stackFrame = new StackFrame(1);
					if (stackFrame.GetMethod().DeclaringType == typeof(Class_168))
					{
						throw new Class_135("The archive requires a ZIP64 Central Directory. Consider setting the ZipFile.UseZip64WhenSaving property.");
					}
					throw new Class_135("The archive requires a ZIP64 Central Directory. Consider setting the ZipOutputStream.EnableZip64 property.");
				}
				else
				{
					byte[] array2 = Class_173.GenZip64EndOfCentralDirectory(num3, num2, num6, numSegments);
					array3 = Class_173.GenCentralDirectoryFooter(num3, num2, zip64, num6, comment, container);
					if (num4 != 0U)
					{
						uint value = class_.dmethod_1096(array2.Length + array3.Length);
						int num7 = 16;
						Array.Copy(BitConverter.GetBytes(value), 0, array2, num7, 4);
						num7 += 4;
						Array.Copy(BitConverter.GetBytes(value), 0, array2, num7, 4);
						num7 = 60;
						Array.Copy(BitConverter.GetBytes(value), 0, array2, num7, 4);
						num7 += 4;
						num7 += 8;
						Array.Copy(BitConverter.GetBytes(value), 0, array2, num7, 4);
					}
					s.Write(array2, 0, array2.Length);
				}
			}
			else
			{
				array3 = Class_173.GenCentralDirectoryFooter(num3, num2, zip64, num6, comment, container);
			}
			if (num4 != 0U)
			{
				ushort value2 = (ushort)class_.dmethod_1096(array3.Length);
				int num8 = 4;
				Array.Copy(BitConverter.GetBytes(value2), 0, array3, num8, 2);
				num8 += 2;
				Array.Copy(BitConverter.GetBytes(value2), 0, array3, num8, 2);
				num8 += 2;
			}
			s.Write(array3, 0, array3.Length);
			if (class_ != null)
			{
				class_.prop_0 = false;
			}
			return flag;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00025518 File Offset: 0x00023718
		private static Encoding GetEncoding(Class_178 container, string t)
		{
			switch (container.prop_14)
			{
			case Class_170.Default:
				return container.prop_13;
			case Class_170.Always:
				return container.prop_12;
			}
			Encoding encoding = container.prop_13;
			if (t == null)
			{
				return encoding;
			}
			byte[] bytes = encoding.GetBytes(t);
			string @string = encoding.GetString(bytes, 0, bytes.Length);
			if (@string.Equals(t))
			{
				return encoding;
			}
			return container.prop_12;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00025588 File Offset: 0x00023788
		private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Class_169 zip64, int entryCount, string comment, Class_178 container)
		{
			Encoding encoding = Class_173.GetEncoding(container, comment);
			int num = 22;
			byte[] array = null;
			short num2 = 0;
			if (comment != null && comment.Length != 0)
			{
				array = encoding.GetBytes(comment);
				num2 = (short)array.Length;
			}
			num += (int)num2;
			byte[] array2 = new byte[num];
			int num3 = 0;
			byte[] bytes = BitConverter.GetBytes(101010256U);
			Array.Copy(bytes, 0, array2, num3, 4);
			num3 += 4;
			array2[num3++] = 0;
			array2[num3++] = 0;
			array2[num3++] = 0;
			array2[num3++] = 0;
			if (entryCount >= 65535 || zip64 == Class_169.Always)
			{
				for (int i = 0; i < 4; i++)
				{
					array2[num3++] = byte.MaxValue;
				}
			}
			else
			{
				array2[num3++] = (byte)(entryCount & 255);
				array2[num3++] = (byte)((entryCount & 65280) >> 8);
				array2[num3++] = (byte)(entryCount & 255);
				array2[num3++] = (byte)((entryCount & 65280) >> 8);
			}
			long num4 = EndOfCentralDirectory - StartOfCentralDirectory;
			if (num4 >= (long)((ulong)-1) || StartOfCentralDirectory >= (long)((ulong)-1))
			{
				for (int i = 0; i < 8; i++)
				{
					array2[num3++] = byte.MaxValue;
				}
			}
			else
			{
				array2[num3++] = (byte)(num4 & 255L);
				array2[num3++] = (byte)((num4 & 65280L) >> 8);
				array2[num3++] = (byte)((num4 & 16711680L) >> 16);
				array2[num3++] = (byte)((num4 & (long)((ulong)-16777216)) >> 24);
				array2[num3++] = (byte)(StartOfCentralDirectory & 255L);
				array2[num3++] = (byte)((StartOfCentralDirectory & 65280L) >> 8);
				array2[num3++] = (byte)((StartOfCentralDirectory & 16711680L) >> 16);
				array2[num3++] = (byte)((StartOfCentralDirectory & (long)((ulong)-16777216)) >> 24);
			}
			if (comment == null || comment.Length == 0)
			{
				array2[num3++] = 0;
				array2[num3++] = 0;
			}
			else
			{
				if ((int)num2 + num3 + 2 > array2.Length)
				{
					num2 = (short)(array2.Length - num3 - 2);
				}
				array2[num3++] = (byte)(num2 & 255);
				array2[num3++] = (byte)(((int)num2 & 65280) >> 8);
				if (num2 != 0)
				{
					int i = 0;
					while (i < (int)num2 && num3 + i < array2.Length)
					{
						array2[num3 + i] = array[i];
						i++;
					}
					num3 += i;
				}
			}
			return array2;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00025834 File Offset: 0x00023A34
		private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
		{
			byte[] array = new byte[76];
			int num = 0;
			byte[] bytes = BitConverter.GetBytes(101075792U);
			Array.Copy(bytes, 0, array, num, 4);
			num += 4;
			long value = 44L;
			Array.Copy(BitConverter.GetBytes(value), 0, array, num, 8);
			num += 8;
			array[num++] = 45;
			array[num++] = 0;
			array[num++] = 45;
			array[num++] = 0;
			for (int i = 0; i < 8; i++)
			{
				array[num++] = 0;
			}
			long value2 = (long)entryCount;
			Array.Copy(BitConverter.GetBytes(value2), 0, array, num, 8);
			num += 8;
			Array.Copy(BitConverter.GetBytes(value2), 0, array, num, 8);
			num += 8;
			long value3 = EndOfCentralDirectory - StartOfCentralDirectory;
			Array.Copy(BitConverter.GetBytes(value3), 0, array, num, 8);
			num += 8;
			Array.Copy(BitConverter.GetBytes(StartOfCentralDirectory), 0, array, num, 8);
			num += 8;
			bytes = BitConverter.GetBytes(117853008U);
			Array.Copy(bytes, 0, array, num, 4);
			num += 4;
			uint value4 = (numSegments == 0U) ? 0U : (numSegments - 1U);
			Array.Copy(BitConverter.GetBytes(value4), 0, array, num, 4);
			num += 4;
			Array.Copy(BitConverter.GetBytes(EndOfCentralDirectory), 0, array, num, 8);
			num += 8;
			Array.Copy(BitConverter.GetBytes(numSegments), 0, array, num, 4);
			num += 4;
			return array;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00025978 File Offset: 0x00023B78
		private static int CountEntries(ICollection<Class_163> _entries)
		{
			int num = 0;
			foreach (Class_163 class_ in _entries)
			{
				if (class_.prop_34)
				{
					num++;
				}
			}
			return num;
		}
	}
}
