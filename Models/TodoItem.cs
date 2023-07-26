namespace TodoApi.Models;

public class TodoItem 
{ 
    public long Id { get; set;}
    public string  Name { get; set;}
    public string?  Description { get; set;}
    public bool isComplete { get; set;}
    public DateTime Created { get; set;}
    public DateTime Updated { get; set;}
}
