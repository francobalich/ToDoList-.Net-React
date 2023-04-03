using CoreEntities.Items;
using InputPort.UseCases.AddItemUseCase;
using InputPort.UseCases.DeleteItemUseCase;
using InputPort.UseCases.GetAllItemsUseCase;
using InputPort.UseCases.GetItemByIdUseCase;
using InputPort.UseCases.UpdateItemUseCase;
using Microsoft.AspNetCore.Mvc;

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

    //GET Items
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _getAllItemsUseCase.Handle());
    }

    //GET Items/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok(await _getByIdItemUseCase.Handle(id));
    }

    //POST Items
    [HttpPost]
    public async Task<IActionResult> Add(Item item)
    {
        await _addItemUseCase.Handle(item);
        return Ok();
    }

    //PUT Items/{id}
    [HttpPut]
    public async Task<IActionResult> Update(Item updatedItem)
    {
        await _updateItemUseCase.Handle(updatedItem);
        return Ok();
    }

    //DELETE Items/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _deleteItemUseCase.Handle(id);
        return Ok();
    }
}