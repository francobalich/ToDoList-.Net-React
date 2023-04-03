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
using Infrastructure.Repositories.AddItemRepositories;
using Infrastructure.Repositories.DeleteItemRepositories;
using Infrastructure.Repositories.GetAllItemsRepositories;
using Infrastructure.Repositories.GetItemByIdRepositories;
using Infrastructure.Repositories.UpdateItemRepositories;
using System.Data;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//use cases
builder.Services.AddScoped<IAddItemUseCase, AddItemUseCase>();
builder.Services.AddScoped<IDeleteItemUseCase, DeleteItemUseCase>();
builder.Services.AddScoped<IGetAllItemsUseCase, GetAllItemsUseCase>();
builder.Services.AddScoped<IGetItemByIdUseCase, GetItemByIdUseCase>();
builder.Services.AddScoped<IUpdateItemUseCase, UpdateItemUseCase>();

//repos
builder.Services.AddScoped<IAddItemRepository, AddItemRepository>();
builder.Services.AddScoped<IDeleteItemRepository, DeleteItemRepository>();
builder.Services.AddScoped<IGetAllItemsRepository, GetAllItemsRepository>();
builder.Services.AddScoped<IGetItemByIdRepository, GetItemByIdRepository>();
builder.Services.AddScoped<IUpdateItemRepository, UpdateItemRepository>();

//sql connection
builder.Services.AddScoped<IDbConnection>(db => new SqlConnection(builder.Configuration.GetConnectionString("ToDoAppConnectionString")));

//allow cors
builder.Services.AddCors(p => p.AddPolicy("ToDoApp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseExceptionHandler("/error");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//use cors configuration
app.UseCors("ToDoApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
