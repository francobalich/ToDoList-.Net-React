namespace ToDoApp.Params;

public readonly record struct AddQueryItem
(
    string Name,
    string Description,
    bool State
);