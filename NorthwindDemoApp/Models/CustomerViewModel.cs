using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindDemoApp.Models
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<int> Paging { get; set; }
    }
}