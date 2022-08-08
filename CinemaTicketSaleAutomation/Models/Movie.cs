using CinemaTicketSaleAutomation.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSaleAutomation.Models
{
    public class Movie : BaseClass
    {
        public Movie()
        {
            SetDefaultSession();
        }
        public string picturePath { get; set; }
        public string minute { get; set; }
        public decimal price { get; set; }
        public Category category { get; set; }
        public List<Session> sessions { get; set; }
        private void SetDefaultSession()
        {
            sessions = new List<Session>();
            DateTime dateTime = DateTime.Now;
            TimeSpan ts = new TimeSpan(10, 30, 0);
            for (int i = 0; i < 3; i++)
            {
                dateTime = dateTime.Date + ts;
                for (int k = 0; k < 3; k++)
                {
                    Session session = new Session();
                    session.date = dateTime.ToShortDateString();
                    session.time = dateTime.ToShortTimeString();
                    sessions.Add(session);
                    dateTime = dateTime.AddHours(3);
                }
                dateTime = dateTime.AddDays(1);
            }
        }

    }
}
