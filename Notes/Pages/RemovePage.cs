using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class RemovePage : SomePage
    {
        public int id { get; set; }

        public void Remove()
        {
            MakePageTitle();

            RemoveId();
        }

        private void RemoveId()
        {
            Console.WriteLine("Type ID Note for delete");

            string strId = (Console.ReadLine());

            if (int.TryParse(strId, out int intId))
            {
                id = intId;
            }
            else
            {
                Console.WriteLine("ID it's a number, try again");
                RemoveId();
            }

        }
    }
}
