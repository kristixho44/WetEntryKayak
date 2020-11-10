﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class OrderDetales
    {
        public int DetailID { get; set; }
        public int KayakID { get; set; }
        public int OrderID { get; set; }
        public int KayakInvID { get; set; }
        public int CustomerID { get; set; }
        public int DetailName { get; set; }
        public int DetailPrice { get; set; }
        public int DetailQTY { get; set; }
    }
}
