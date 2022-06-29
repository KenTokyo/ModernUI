using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernFlatUI
{
    public class StockModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Qty { get; set; }
        public string Price { get; set; }
    }
}
