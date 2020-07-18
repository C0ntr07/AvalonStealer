using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200021D RID: 541
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class Class_410 : Attribute
	{
		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00054473 File Offset: 0x00052673
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x0005447B File Offset: 0x0005267B
		public Type ItemConverterType { get; set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00054484 File Offset: 0x00052684
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x0005448C File Offset: 0x0005268C
		public object[] ItemConverterParameters { get; set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x00054498 File Offset: 0x00052698
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x000544C1 File Offset: 0x000526C1
		public Class_457 NullValueHandling
		{
			get
			{
				Class_457? nullValueHandling = this._nullValueHandling;
				if (nullValueHandling == null)
				{
					return Class_457.Include;
				}
				return nullValueHandling.GetValueOrDefault();
			}
			set
			{
				this._nullValueHandling = new Class_457?(value);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x000544D0 File Offset: 0x000526D0
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x000544F9 File Offset: 0x000526F9
		public Class_377 DefaultValueHandling
		{
			get
			{
				Class_377? defaultValueHandling = this._defaultValueHandling;
				if (defaultValueHandling == null)
				{
					return Class_377.Include;
				}
				return defaultValueHandling.GetValueOrDefault();
			}
			set
			{
				this._defaultValueHandling = new Class_377?(value);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00054508 File Offset: 0x00052708
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00054531 File Offset: 0x00052731
		public Class_458 ReferenceLoopHandling
		{
			get
			{
				Class_458? referenceLoopHandling = this._referenceLoopHandling;
				if (referenceLoopHandling == null)
				{
					return Class_458.Error;
				}
				return referenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				this._referenceLoopHandling = new Class_458?(value);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00054540 File Offset: 0x00052740
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00054569 File Offset: 0x00052769
		public Class_384 ObjectCreationHandling
		{
			get
			{
				Class_384? objectCreationHandling = this._objectCreationHandling;
				if (objectCreationHandling == null)
				{
					return Class_384.Auto;
				}
				return objectCreationHandling.GetValueOrDefault();
			}
			set
			{
				this._objectCreationHandling = new Class_384?(value);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00054578 File Offset: 0x00052778
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x000545A1 File Offset: 0x000527A1
		public Class_494 TypeNameHandling
		{
			get
			{
				Class_494? typeNameHandling = this._typeNameHandling;
				if (typeNameHandling == null)
				{
					return Class_494.None;
				}
				return typeNameHandling.GetValueOrDefault();
			}
			set
			{
				this._typeNameHandling = new Class_494?(value);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x000545B0 File Offset: 0x000527B0
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x000545D9 File Offset: 0x000527D9
		public bool IsReference
		{
			get
			{
				return this._isReference ?? false;
			}
			set
			{
				this._isReference = new bool?(value);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x000545E8 File Offset: 0x000527E8
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x00054611 File Offset: 0x00052811
		public int Order
		{
			get
			{
				int? order = this._order;
				if (order == null)
				{
					return 0;
				}
				return order.GetValueOrDefault();
			}
			set
			{
				this._order = new int?(value);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00054620 File Offset: 0x00052820
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00054649 File Offset: 0x00052849
		public Class_364 Required
		{
			get
			{
				Class_364? required = this._required;
				if (required == null)
				{
					return Class_364.Default;
				}
				return required.GetValueOrDefault();
			}
			set
			{
				this._required = new Class_364?(value);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00054657 File Offset: 0x00052857
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x0005465F File Offset: 0x0005285F
		public string PropertyName { get; set; }

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00054668 File Offset: 0x00052868
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x00054691 File Offset: 0x00052891
		public Class_458 ItemReferenceLoopHandling
		{
			get
			{
				Class_458? itemReferenceLoopHandling = this._itemReferenceLoopHandling;
				if (itemReferenceLoopHandling == null)
				{
					return Class_458.Error;
				}
				return itemReferenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				this._itemReferenceLoopHandling = new Class_458?(value);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x000546A0 File Offset: 0x000528A0
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x000546C9 File Offset: 0x000528C9
		public Class_494 ItemTypeNameHandling
		{
			get
			{
				Class_494? itemTypeNameHandling = this._itemTypeNameHandling;
				if (itemTypeNameHandling == null)
				{
					return Class_494.None;
				}
				return itemTypeNameHandling.GetValueOrDefault();
			}
			set
			{
				this._itemTypeNameHandling = new Class_494?(value);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x000546D8 File Offset: 0x000528D8
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00054701 File Offset: 0x00052901
		public bool ItemIsReference
		{
			get
			{
				return this._itemIsReference ?? false;
			}
			set
			{
				this._itemIsReference = new bool?(value);
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0004427F File Offset: 0x0004247F
		public Class_410()
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0005470F File Offset: 0x0005290F
		public Class_410(string propertyName)
		{
			this.PropertyName = propertyName;
		}

		// Token: 0x0400098E RID: 2446
		internal Class_457? _nullValueHandling;

		// Token: 0x0400098F RID: 2447
		internal Class_377? _defaultValueHandling;

		// Token: 0x04000990 RID: 2448
		internal Class_458? _referenceLoopHandling;

		// Token: 0x04000991 RID: 2449
		internal Class_384? _objectCreationHandling;

		// Token: 0x04000992 RID: 2450
		internal Class_494? _typeNameHandling;

		// Token: 0x04000993 RID: 2451
		internal bool? _isReference;

		// Token: 0x04000994 RID: 2452
		internal int? _order;

		// Token: 0x04000995 RID: 2453
		internal Class_364? _required;

		// Token: 0x04000996 RID: 2454
		internal bool? _itemIsReference;

		// Token: 0x04000997 RID: 2455
		internal Class_458? _itemReferenceLoopHandling;

		// Token: 0x04000998 RID: 2456
		internal Class_494? _itemTypeNameHandling;
	}
}
