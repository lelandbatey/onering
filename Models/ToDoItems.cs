namespace onering.Models
{
	public class ToDoItem
	{
		public string Title { get; set; }
		public string Link { get; set; }
		public bool IsComplete { get; set; }
		public string DueDate { get; set; }
		public string Source {get; set;}
		public int ID {get; set;}
	}
}