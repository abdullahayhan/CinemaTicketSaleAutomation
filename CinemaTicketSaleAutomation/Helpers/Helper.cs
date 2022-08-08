using CinemaTicketSaleAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSaleAutomation.Helpers
{
    class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/NB/Desktop/C#/CinemaTicketSaleAutomation/CinemaTicketSaleAutomation/Pictures/";

            //List<Movie> liste = new List<Movie>();
            //Movie movie = new Movie();
            return new List<Movie>()
            {
                new Movie
                {
                    movieName ="Boynuzlar",
                    minute = "1 saat 39 dakika",
                    category = Enum.Category.gerilim,
                    price = 50,
                    picturePath = basePath + "boynuzlar.jpg"
                },
                new Movie
                {
                    movieName ="Free Guy",
                    minute = "1 saat 31 dakika",
                    category = Enum.Category.komedi,
                    price = 50,
                    picturePath = basePath + "freeguy.jpg"
                },
                new Movie
                {
                    movieName ="İstanbul Muhafızları",
                    minute = "1 saat",
                    category = Enum.Category.fantastik,
                    price = 50,
                    picturePath = basePath + "istanbulhafızları.jpg"
                },
                new Movie
                {
                    movieName ="No Time To Die",
                    minute = "2 saat 35 dakika",
                    category = Enum.Category.macera,
                    price = 50,
                    picturePath = basePath + "notimetodie.jpg"
                },
                new Movie
                {
                    movieName ="Venom",
                    minute = "1 saat 37 dakika",
                    category = Enum.Category.bilim_kurgu,
                    price = 50,
                    picturePath = basePath + "venom.jpg"
                },
                new Movie
                {
                    movieName ="Zoraki Misafir",
                    minute = "2 saat 5 dakika",
                    category = Enum.Category.komedi,
                    price = 50,
                    picturePath = basePath + "zorakimisafir.jpg"
                }
            };
        }
    }
}
