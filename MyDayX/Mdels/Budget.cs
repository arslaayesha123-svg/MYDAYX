using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    
        namespace MyDayX.Mdels
    {
        internal class Budget
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public decimal LimitAmount { get; set; }
        }
    
}
