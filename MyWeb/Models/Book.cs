using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class Book
    {
        private static string[] titles = { "Tree Without A Home", "Priestess With Determination", "Giants Of The Gods", "Pilots Of Wood", "Girls And Lions", "Dwarf Of Freedom", "Boy Of The Eclipse", "Horses Of Greatness", "Enemies Of The Stars" };
        private static string[] authors = { "Driscoll D. Goff", "Jacob O. Cochran", "Phoebe N. Dixon", "Myles Y. Vazquez", "Margaret J. Harvey", "Inga W. Battle", "Shaine D. Britt", "Lavinia C. Webb", "Michelle C. Christensen", "Caryn G. Compton" };
        private static int counter = 1;

        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }

        public Book()
        {
            Random rand = new Random();

            Id = counter++;
            Title = titles[rand.Next(titles.Length)];
            Author = authors[rand.Next(authors.Length)];
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.".Substring(0, 100 + rand.Next(300));
            ReleaseDate = DateTime.Today.AddDays(rand.Next(30)).AddMonths(rand.Next(12)).AddYears(-1 - rand.Next(5));
            Pages = rand.Next(500) + 30;
            Price = 20 + rand.Next(36) * 5 + ((rand.Next(2) > 0) ? ((rand.Next(2) > 0) ? 0 : .5m) : .99m);
        }


    }
}
