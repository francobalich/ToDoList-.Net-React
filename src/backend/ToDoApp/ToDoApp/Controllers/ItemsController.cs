using Entities.UseCases.AddItemUseCase;
using Entities.UseCases.DeleteItemUseCase;
using Entities.UseCases.GetAllItems;
using Entities.UseCases.GetByIdItemUseCase;
using Entities.UseCases.Items;
using Entities.UseCases.IUpdateItemUseCase;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Params;

namespace ToDoApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IAddItemUseCase _addItemUseCase;
    private readonly IGetAllItemsUseCase _getAllItemsUseCase;
    private readonly IGetItemByIdUseCase _getByIdItemUseCase;
    private readonly IDeleteItemUseCase _deleteItemUseCase;
    private readonly IUpdateItemUseCase _updateItemUseCase;

    public ItemsController(IAddItemUseCase addItemUseCase, IGetAllItemsUseCase getAllItemsUseCase, IGetItemByIdUseCase getByIdItemUseCase, IDeleteItemUseCase deleteItemUseCase, IUpdateItemUseCase updateItemUseCase, ILogger<ItemsController> logger)
    {
        _addItemUseCase = addItemUseCase;
        _getAllItemsUseCase = getAllItemsUseCase;
        _getByIdItemUseCase = getByIdItemUseCase;
        _deleteItemUseCase = deleteItemUseCase;
        _updateItemUseCase = updateItemUseCase;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _getAllItemsUseCase.Handle());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) => Ok(await _getByIdItemUseCase.Handle(id));

    [HttpPost]
    public async Task<IActionResult> AddAsync(AddQueryItem addQueryItem)
    {
        await _addItemUseCase.Handle(new Item()
        {
            Date = DateTime.Now,
            Description = addQueryItem.Description,
            Name = addQueryItem.Name,
            State = addQueryItem.State,
        });
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(Item updatedItem)
    {
        await _updateItemUseCase.Handle(updatedItem);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _deleteItemUseCase.Handle(id);
        return Ok();
    }
}