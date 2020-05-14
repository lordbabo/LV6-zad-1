using System;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.AddNote(new Note("Test 1", "First text."));
            notebook1.AddNote(new Note("Test 2", "Second text."));
            notebook1.AddNote(new Note("Test 3", "Third text."));

            Iterator iterator1 = new Iterator(notebook1);
            iterator1.Current.Show();
            iterator1.Next().Show();

            while (iterator1.IsDone != true)
            {
                iterator1.Current.Show();
                iterator1.Next();
            }
        }
    }
}
