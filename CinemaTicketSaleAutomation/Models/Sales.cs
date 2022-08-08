using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSaleAutomation.Models
{
    public class Sales : BaseClass
    {
        public Sales()
        {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public int count { get; set; }
        public decimal totalPrice { get; set; }
        public string sessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} adlı filmin {sessionTime} seanslı {count} adet bilet kesilmiştir. Toplam tutar = {totalPrice} TL | Satın alma tarihi : {creationDate}";
        }
    }
}
