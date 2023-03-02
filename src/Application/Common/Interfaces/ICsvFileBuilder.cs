using css2.Application.TodoLists.Queries.ExportTodos;

namespace css2.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
