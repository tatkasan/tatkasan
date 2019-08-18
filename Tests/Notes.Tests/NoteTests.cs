using System;
using Xunit;

namespace Notes.Tests
{
 
    public class NoteTests
    {
        [Fact]
        public void NoteTest()
        {
            var note = new Note("lorem ipsum", "съешь же ещЄ этих м€гких французских булок, да выпей чаю");
            
        }

        [Fact]
        public void NoteShowNoteTest()
        {
            var note = new Note("lorem ipsum", "съешь же ещЄ этих м€гких французских булок, да выпей чаю");
            string mynote = note.ShowNote();
        }
    }
}
