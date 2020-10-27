using System;
using SQLite;

namespace NotesApp.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime Date { get; set; }
    }
}
