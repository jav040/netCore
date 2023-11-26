using System;

public class TodoProjModel
{
	public int Id { get; set; }	
	public string Task { get; set; }
	public bool IsCompleted { get; set; }	
	public int assignedTo { get; set; }	

	public TodoProjModel()
	{

	}

}
