namespace CoreEntities.Items;

public readonly record struct Item
(
    int Id,
    string Name,
    DateTime Date,
    string Description,
    bool State
);

