using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Models
{
    [Table("Inventory", Schema = "dbo")]
    public class Inventory
    {
        public int inInventoryId { get; set; }
        public Guid? unInventoryID { get; set; }
        public string stInventoryName { get; set; }
        public string stDescription { get; set; }

        public decimal? dcPrice { get; set; }
    }
}
