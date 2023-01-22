using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerDB.Models
{
	public class ServerModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string OS { get; set; }
		public string IPAddress { get; set; }
		public string Location { get; set; }
		public string MainAdmin { get; set; }
		public string Description { get; set; }

	}
}
