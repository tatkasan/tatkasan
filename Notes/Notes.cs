using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notes
{
    class Notes : List<Note>
    {
        private int lastID;

        public Note FindNote(int _id)
        {
            return Find(x => x.Id == _id);
        }

        public Note AddNote(Note note)
        {
            lastID++;
            note.Id = lastID;
            Add(note);
            return note;
        }
       
        public Note RemoveNote(Note note)
        {
            Remove(note);
            return note;
        }

        public Note UpdateNote(Note note)
        {
            Remove(FindNote(note.Id));
            Add(note);
            return note;
        }

       

    }
   
    
}
