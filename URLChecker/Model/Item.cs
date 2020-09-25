using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLChecker.Model
{
	class Item
	{
		public string Title { get; set; }
		public bool InStock { get; set; }
		public string Price { get; set; }
		public string Link { get; set; }
		public string NeweggId { get; set; }
	}
}
