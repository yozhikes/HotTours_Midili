using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTours_Midili
{
    public class Tour
    {
        public string Direction { get; set; }
        public DateTime Date { get; set; }
        public int Nights { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public bool Wifi { get; set; }
        public int Dop { get; set; }
        public int Sum { get; set; }
    }
}
