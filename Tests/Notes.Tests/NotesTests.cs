using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Notes.Tests
{
    public class NotesTests
    {
        [Fact]
        public void NotesTest()
        {
            Notes notes = new Notes();
        }

        [Fact]
        public void NotesAddTest()
        {
            Notes notes = new Notes();
            Note note = new Note("lorem ipsum", "съешь же ещё этих мягких французских булок, да выпей чаю");
            notes.Add(note);
        }
    }
}
