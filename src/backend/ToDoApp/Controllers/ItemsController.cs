using Entities.UseCases.AddItemUseCase;
using Entities.UseCases.DeleteItemUseCase;
using Entities.UseCases.GetAllItems;
using Entities.UseCases.GetByIdItemUseCase;
using Entities.UseCases.Items;
using Entities.UseCases.IUpdateItemUseCase;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private readonly ILogger<ItemsController> _logger;
    private readonly IAddItemUseCase _addItemUseCase;
    private readonly IGetAllItemsUseCase _getAllItemsUseCase;
    private readonly IGetItemByIdUseCase _getByIdItemUseCase;
    private readonly IDeleteItemUseCase _deleteItemUseCase;
    private readonly IUpdateItemUseCase _updateItemUseCase;

    public ItemsController(ILogger<ItemsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_getAllItemsUseCase.Handle());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var itemFound = _getByIdItemUseCase.Handle(id);

        if (itemFound == null)
        {
            return NotFound();
        }

        return Ok(itemFound);
    }

    [HttpPost]
    public IActionResult Add(Item item)
    {
        _addItemUseCase.Handle(item);
        return Ok(item.Id);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Item updatedItem)
    {
        var itemToUpdate = _getByIdItemUseCase.Handle(id);

        if (itemToUpdate == null)
        {
            return NotFound();
        }

        _updateItemUseCase.Handle(updatedItem);

        return Ok(id);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var itemToUpdate = _getByIdItemUseCase.Handle(id);

        if (itemToUpdate == null)
        {
            return NotFound();
        }

        _deleteItemUseCase.Handle(id);

        return Ok(id);
    }
}