using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloJo.Services.LocalServices.IndexedDb.Models
{
	public class UnitOfMeasurement
	{
		public int Id { get; set; }
		public required string Name { get; set; }
	}
}
