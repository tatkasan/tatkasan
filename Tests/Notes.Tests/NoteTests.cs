using System;
using Xunit;

namespace Notes.Tests
{
 
    public class NoteTests
    {
        [Fact]
        public void NoteTest()
        {
            var note = new Note("lorem ipsum", "����� �� ��� ���� ������ ����������� �����, �� ����� ���");
            
        }

        [Fact]
        public void NoteShowNoteTest()
        {
            var note = new Note("lorem ipsum", "����� �� ��� ���� ������ ����������� �����, �� ����� ���");
            string mynote = note.ShowNote();
        }
    }
}
