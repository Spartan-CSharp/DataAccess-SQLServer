﻿using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DataAccessLibrary.Models
{
	public class AddressModel
	{
		public int Id { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
	}
}
