﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelLibrary.DataModels.IndexedDBDataModels
{
	public class User
	{
		public int Id { get; set; }
		public string? Email { get; set; }
		public string?  UserName { get; set; }
		public int WeightTrackerId { get; set; }
	}
}
