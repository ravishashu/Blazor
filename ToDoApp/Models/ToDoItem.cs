namespace ToDoApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        //Add commentMore actions
        public string Name { get; set; } = "";

        public bool IsCompleted { get; set; }

        public DateTime DateCompleted { get; set; }
    }
}


