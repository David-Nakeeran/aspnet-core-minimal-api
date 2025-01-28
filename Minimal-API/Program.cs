var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var todos = new List<Todo>();

app.Run();

public record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted)
{

}
