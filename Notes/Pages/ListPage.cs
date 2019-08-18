using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class ListPage: SomePage
    {
        public void ListNotes(Notes notes)
        {
            MakePageTitle();
            foreach (Note note in notes)
            {
                Console.WriteLine(note.ShowNote());
            }
        }
    }
}
