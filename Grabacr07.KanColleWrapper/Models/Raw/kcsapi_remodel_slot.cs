﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grabacr07.KanColleWrapper.Models.Raw
{
	// ReSharper disable InconsistentNaming
	public class kcsapi_remodel_slot
	{
		public int api_remodel_flag { get; set; }
		public int[] api_remodel_id { get; set; }
		public int api_voice_id { get; set; }
		public int[] api_after_material { get; set; }
		public Api_After_Slot api_after_slot { get; set; }		
		public int[] api_use_slot_id { get; set; }
	}

	public class Api_After_Slot
	{
		public int api_id { get; set; }
		public int api_level { get; set; }
		public int api_locked { get; set; }
		public int api_slotitem_id { get; set; }
	}
	// ReSharper restore InconsistentNaming
}
