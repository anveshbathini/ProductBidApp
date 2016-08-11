using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BidAndAuction.Models
{
    public class Bidding
    {
        public int ProdID { get; set; }
        public string ProdTitle { get; set; }
        public string ProdDesc { get; set; }
        public int InitPrice { get; set; }
        public int BidIncr { get; set; }
        public string CreatedBy { get; set; }
    }
}