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
        //private List<Note> list = new List<Note>();
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
         
            lastID++;
            note.Id = lastID;
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

        //public List<string> ShowNotes(Notes notes)
        //{
        //    List<string> listString = new List<string>();
        //    foreach (Note note in list)
        //    {
        //        listString.Add(note.ToString());
        //    }
        //    return listString;
        //}



    }
   
    
}
