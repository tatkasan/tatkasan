using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class HelpPage : SomePage
    {
        public void Help()
        {
            MakePageTitle();
            Console.WriteLine("Type Add to add new note.\nType Edit to edit a note.\nType Rem to remove a note.\nType List to see all notes. ");
        }
        

    }
}
