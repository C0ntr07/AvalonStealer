using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace \u030E\u0360\u0313\u034E\u0315\u0E47\u0020\u0305\u035C\u0351\u0E47\u0351\u0320\u0301\u036B\u0300zcryfxllszuahcty\u0347\u0334\u0342\u0E47\u0310\u032C\u0358\u0340\u036B\u0331\u0329\u036B\u0340\u032F\u0308\u0E47cexuwlosbhsreyjl
{
	// Token: 0x02000055 RID: 85
	public class Class_62
	{
		// Token: 0x06000171 RID: 369 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		public Class_62()
		{
			this.prop_3 = new List<Class_62>();
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000E406 File Offset: 0x0000C606
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0000E415 File Offset: 0x0000C615
		public Class_63 prop_0 { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000E425 File Offset: 0x0000C625
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000E434 File Offset: 0x0000C634
		public byte[] prop_1 { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000E444 File Offset: 0x0000C644
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000E453 File Offset: 0x0000C653
		public int prop_2 { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000E463 File Offset: 0x0000C663
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000E472 File Offset: 0x0000C672
		public List<Class_62> prop_3 { get; set; }

		// Token: 0x0600017A RID: 378 RVA: 0x0000E484 File Offset: 0x0000C684
		public virtual string cmethod_174()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			Class_63 class_ = this.prop_0;
			switch (class_)
			{
			case Class_63.\u0347\u0363\u0323\u036B\u0308\u031B\u0020\u035A\u0331\u0308\u0308\u033B\u0353\u0331\u032C\u0020jacdwkizwuxzvbzl\u0316\u031F\u032F\u0360\u032F\u0020\u033A\u0353\u0317\u033C\u0E47\u035C\u0E47\u0339\u0338\u030Doduqrdjpffeqgyol:
				foreach (byte b in this.prop_1)
				{
					stringBuilder2.AppendFormat("{0:X2}", b);
				}
				stringBuilder.Append("\tINTEGER ").Append(stringBuilder2).AppendLine();
				break;
			case (Class_63)3:
			case (Class_63)5:
				break;
			case Class_63.\u0355\u0332\u0303\u0020\u0348\u0489\u036A\u033B\u0329\u0347\u0348\u0337\u0E47\u0020\u0360\u031Bgfaaxbgpapcutiyw\u034B\u0359\u0339\u032C\u0332\u0356\u0324\u0349\u0313\u036B\u0347\u0338n\u0330\u0303\u035Ebohqkbweqzdegofe:
				foreach (byte b2 in this.prop_1)
				{
					stringBuilder2.AppendFormat("{0:X2}", b2);
				}
				stringBuilder.Append("\tOCTETSTRING ").AppendLine(stringBuilder2.ToString());
				break;
			case Class_63.\u032C\u0333\u0E47\u033C\u0363\u0364\u0339\u036F\u035Ch\u0E47\u0320\u033D\u0301\u0E47\u0020hppcqdarxlrwzovm\u0E47\u032E\u033B\u0316\u032C\u0303\u0331\u034E\u0339\u032D\u0E47\u0E47\u0E47\u035A\u036B\u0359jffomvukpppnngvu:
				foreach (byte b3 in this.prop_1)
				{
					stringBuilder2.AppendFormat("{0:X2}", b3);
				}
				stringBuilder.Append("\tOBJECTIDENTIFIER ").AppendLine(stringBuilder2.ToString());
				break;
			default:
				if (class_ == Class_63.\u033C\u0315\u0312\u0369\u0365\u0309\u0367\u0349\u0E47\u0E47\u0332\u032F\u0020\u031F\u0020\u035Bxaguklmpkkhzvsdf\u035F\u0346\u0313\u0020\u036D\u0329\u034F\u034E\u0333ส\u033D\u0020\u033C\u0324\u034D\u0342zgtftxzqbxmhquxc)
				{
					stringBuilder.AppendLine("SEQUENCE {");
				}
				break;
			}
			foreach (Class_62 value in this.prop_3)
			{
				stringBuilder.Append(value);
			}
			if (this.prop_0 == Class_63.\u033C\u0315\u0312\u0369\u0365\u0309\u0367\u0349\u0E47\u0E47\u0332\u032F\u0020\u031F\u0020\u035Bxaguklmpkkhzvsdf\u035F\u0346\u0313\u0020\u036D\u0329\u034F\u034E\u0333ส\u033D\u0020\u033C\u0324\u034D\u0342zgtftxzqbxmhquxc)
			{
				stringBuilder.AppendLine("}");
			}
			stringBuilder2.Remove(0, stringBuilder2.Length - 1);
			return stringBuilder.ToString();
		}

		// Token: 0x040000F9 RID: 249
		[CompilerGenerated]
		private Class_63 field_0;

		// Token: 0x040000FA RID: 250
		[CompilerGenerated]
		private byte[] field_1;

		// Token: 0x040000FB RID: 251
		[CompilerGenerated]
		private int field_2;

		// Token: 0x040000FC RID: 252
		[CompilerGenerated]
		private List<Class_62> field_3;
	}
}
