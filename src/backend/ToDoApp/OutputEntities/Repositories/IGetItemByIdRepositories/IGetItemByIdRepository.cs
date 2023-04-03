﻿using CoreEntities.Items;

namespace Infrastructure.Repositories.GetItemByIdRepositories;

public interface IGetItemByIdRepository
{
    Task<Item> Execute(int id);
}
