using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notes
{
    public class Notes : List<Note>
    {
        private int lastID=0;

        public int Show()
        {
            return lastID;
        }

        public Note Find(int id)
        {
            return Find(x => x.Id == id);
        }

        public bool Exists(int id)
        {
            return Exists(x => x.Id == id);
        }

        public new Note Add (Note note)
        {
            if(Exists(note.Id))
            {
                lastID++;
                note.Id = lastID;
            }
            base.Add(note);
            return note;

        }
       
        public new Note Remove(Note note)
        {
            base.Remove(note);
            return note;
        }

        public Note UpdateNote(Note note)
        {
            Remove(Find(note.Id));
            Add(note);
            return note;
        }


    }
   
    
}
