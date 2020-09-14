using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioManagement
{
    // creating class for the storing the data
    public class Orders
    {
        public string Symbol { get; set; }
        public string Side { get; set; }
        public string Account { get; set; }
        public string Quantity { get; set; }
        public string AvgPrice { get; set; }
        public string RemainingQuantity { get; set; }
        public string OrderStatus { get; set; }
        public string CLOrderID { get; set; }
        public string ParentCLOrderID { get; set; }
        public string StaggedOrderID { get; set; }
        public string OriginalCLOrderID { get; set; }
    }
}
