using css2.Application.Common.Mappings;
using css2.Domain.Entities;

namespace css2.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
