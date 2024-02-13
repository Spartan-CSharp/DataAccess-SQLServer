using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
	public class EmployerAddressBaseModel
	{
		public int Id { get; set; }
		public int EmployerId { get; set; }
		public int AddressId { get; set; }
	}
}
