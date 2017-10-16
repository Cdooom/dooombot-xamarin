using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomBot.Models
{
    public class Sale
    {
        public int userID { get; set; }
        public int qty { get; set; }
        public decimal total_cost { get; set; }
        public string status { get; set; }

    }
}
