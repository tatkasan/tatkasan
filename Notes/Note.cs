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


        public Note(int id, string title, string body) { Id = id; Title = title; Body = body; }

        public Note( string title, string body) { Id = 0; Title = title; Body = body; }


        public string ShowNote()
        {
            return (Id.ToString()+ " - "+Title);
            
        }

    }
}
