using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020002A8 RID: 680
	internal struct Class_492
	{
		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0006A95A File Offset: 0x00068B5A
		public char[] Chars
		{
			get
			{
				return this._chars;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0006A962 File Offset: 0x00068B62
		public int StartIndex
		{
			get
			{
				return this._startIndex;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0006A96A File Offset: 0x00068B6A
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0006A972 File Offset: 0x00068B72
		public Class_492(char[] chars, int startIndex, int length)
		{
			this._chars = chars;
			this._startIndex = startIndex;
			this._length = length;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0006A989 File Offset: 0x00068B89
		public override string ToString()
		{
			return new string(this._chars, this._startIndex, this._length);
		}

		// Token: 0x04000BCF RID: 3023
		private readonly char[] _chars;

		// Token: 0x04000BD0 RID: 3024
		private readonly int _startIndex;

		// Token: 0x04000BD1 RID: 3025
		private readonly int _length;
	}
}
