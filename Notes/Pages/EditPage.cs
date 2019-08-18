using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class EditPage : SomePage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public void Edit()
        {

            MakePageTitle();

            EditId();

            Console.WriteLine("Do you want to edit the title? y/n");

            var command = (Console.ReadLine()).ToLower();

            if (Confirm(command))
            {
                EditTitle();
            }

            Console.WriteLine("Do you want to edit the body? y/n");

            command = (Console.ReadLine()).ToLower();
            if (Confirm(command))
            {
                EditBody();
            }
        }

        private void EditId()
        {
            Console.WriteLine("Type ID Note for edit");
            string strId = (Console.ReadLine());

            if (int.TryParse(strId, out int intId))
            {
                
                Id = intId;
            }
            else
            {
                Console.WriteLine("ID it's a number, try again");
                EditId();
            }
        }
        private void EditTitle()
        {
            Console.WriteLine("Type new Title");
            Title = Console.ReadLine();
        }
        private void EditBody()
        {
            Console.WriteLine("Type new Body");
            Body = Console.ReadLine();
        }
        
    }
}
    
