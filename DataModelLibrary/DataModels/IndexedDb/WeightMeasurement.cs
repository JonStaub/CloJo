using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelLibrary.DataModels.IndexedDBDataModels
{
	public class WeightMeasurement
	{
		public int Id { get; set; }
		public DateTime RecordedDateTime { get; set; }
		public decimal Weight { get; set; }
		public int UnitofMeasurementId { get; set; }

	}
}
