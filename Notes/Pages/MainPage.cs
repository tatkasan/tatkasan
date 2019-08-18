using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Pages
{
    class MainPage : SomePage
    {
        private Notes notes = new Notes();

        public void Main()
        {
            MakePageTitle();

            Console.WriteLine("Type help if you need help.");
            Console.WriteLine("");
            Console.Write(">");
            Console.Write(notes.Show().ToString());

            while (true)
            {
                var usercommand = Console.ReadLine().ToLower();

                CommandParse(usercommand);

                Console.Write(">");
            }
        }
        private void CommandParse(string usercommand)
        {

            if (usercommand == "help")
            {
                Help();
                return;
            }

            else if (usercommand == "add")
            {
                Add();
                return;
            }

            else if (usercommand == "list")
            {
                ListNotes(notes);
                return;
            }

            //if (usercommand == "del")
            //{
            //    DelNote(mynotedata);
            //    return;
            //}

            //if (usercommand == "edit")
            //{
            //    EditNote(mynotedata);
            //    return;
            //}
            else
            {
                Console.WriteLine("There is no such command");
                return;
            }
        }
        private void Add()
        {
            AddPage addPage = new AddPage();
            addPage.Add();

            Note note = new Note(addPage.Title, addPage.Body);
            notes.Add(note);

            Console.WriteLine("Do you want to add one more note? y/n");
            var usercommand = Console.ReadLine();
            if (Confirm(usercommand))
            {
                Add();
                return;
            }
            else
            {
                Main();
                return;
            } 
        }
        private void Help()
        {
            HelpPage helpPage = new HelpPage();
            helpPage.Help();
            return;
        }
        private void ListNotes(Notes notes)
        {
            ListPage listPage = new ListPage();
            listPage.ListNotes(notes);
            Console.WriteLine("Do you want to  come back? y/n");
            var usercommand = Console.ReadLine();
            if (Confirm(usercommand))
            {
                Main();
                return;
            }
            else
            {
                ListNotes(notes);
                return;
            }

        }

    }
}
