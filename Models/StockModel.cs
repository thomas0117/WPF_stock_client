using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_stock_client.Models
{
    public class StockModel
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string CurrentPrice { get; set; }
        public string ChangeRate { get; set; }
    }
}
