using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class AddPage : SomePage
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public void Add()
        {
            MakePageTitle();

            Console.WriteLine("Type Title.");
            Title = Console.ReadLine();

            Console.WriteLine("Type Body.");
            Body = Console.ReadLine();
        }
    }
}
