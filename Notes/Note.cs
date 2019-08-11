using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        /*
        public Note(int _id, string _title, string _body)
        {
            Id = _id;
            Title = _title;
            Body = _body;

        }
        */
        public void ShowNoteTitle(Note note)
        {
            Console.WriteLine("ID  {0} , TITLE {1}", note.Id, note.Title);
        }

        public void ShowNote(Note note)
        {
            Console.WriteLine("Note number {0}\n{1}\n{2}", note.Id, note.Title, note.Body);
        }
    }
}
