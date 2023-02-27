using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloJo.Services.LocalServices.IndexedDb.Models
{
	public class WeightMeasurement
	{
		public string Id { get; set; } = default!;
        public DateTime RecordedDateTime { get; set; }
		[Required]
		public decimal Weight { get; set; }
		public int UnitofMeasurementId { get; set; } = default!;
        public string UnitOfMeasurementName { get; set; } = default!;

		public WeightMeasurement()
		{

		}

	}
}
