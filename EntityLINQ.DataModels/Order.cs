using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLINQ.DataModels
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderTotal { get; set; }


        //foreign key
        public int CustomerId { get; set; }

    }
}
