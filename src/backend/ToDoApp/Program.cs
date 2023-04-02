using Application.UseCases.AddItemUseCase;
using Application.UseCases.DeleteItemUseCase;
using Application.UseCases.GetAllItemsUseCase;
using Application.UseCases.GetItemByIdUseCase;
using Application.UseCases.UpdateItemUseCase;
using Entities.UseCases.AddItemUseCase;
using Entities.UseCases.DeleteItemUseCase;
using Entities.UseCases.GetAllItems;
using Entities.UseCases.GetByIdItemUseCase;
using Entities.UseCases.IUpdateItemUseCase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

NewMethod(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void NewMethod(WebApplicationBuilder builder)
{
    builder.Services.AddTransient<IAddItemUseCase, AddItemUseCase>();
    builder.Services.AddTransient<IDeleteItemUseCase, DeleteItemUseCase>();
    builder.Services.AddTransient<IGetAllItemsUseCase, GetAllItemsUseCase>();
    builder.Services.AddTransient<IGetItemByIdUseCase, GetItemByIdUseCase>();
    builder.Services.AddTransient<IUpdateItemUseCase, UpdateItemUseCase>();
}