using Application.UseCases.AddItemUseCase;
using Application.UseCases.DeleteItemUseCase;
using Application.UseCases.GetAllItemsUseCase;
using Application.UseCases.GetItemByIdUseCase;
using Application.UseCases.UpdateItemUseCase;
using Infrastructure.Repositories.AddItemRepositories;
using Infrastructure.Repositories.DeleteItemRepositories;
using Infrastructure.Repositories.GetAllItemsRepositories;
using Infrastructure.Repositories.GetItemByIdRepositories;
using Infrastructure.Repositories.UpdateItemRepositories;
using InputPort.UseCases.AddItemUseCase;
using InputPort.UseCases.DeleteItemUseCase;
using InputPort.UseCases.GetAllItemsUseCase;
using InputPort.UseCases.GetItemByIdUseCase;
using InputPort.UseCases.UpdateItemUseCase;
using OutputPort.Repositories.IAddItemRepositories;
using OutputPort.Repositories.IDeleteItemRepositories;
using OutputPort.Repositories.IGetAllItemsRepositories;
using OutputPort.Repositories.IGetItemByIdRepositories;
using OutputPort.Repositories.IUpdateItemRepositories;
using System.Data;
using System.Data.SqlClient;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DI use cases
builder.Services.AddScoped<IAddItemUseCase, AddItemUseCase>();
builder.Services.AddScoped<IDeleteItemUseCase, DeleteItemUseCase>();
builder.Services.AddScoped<IGetAllItemsUseCase, GetAllItemsUseCase>();
builder.Services.AddScoped<IGetItemByIdUseCase, GetItemByIdUseCase>();
builder.Services.AddScoped<IUpdateItemUseCase, UpdateItemUseCase>();

//DI repositories
builder.Services.AddScoped<IAddItemRepository, AddItemRepository>();
builder.Services.AddScoped<IDeleteItemRepository, DeleteItemRepository>();
builder.Services.AddScoped<IGetAllItemsRepository, GetAllItemsRepository>();
builder.Services.AddScoped<IGetItemByIdRepository, GetItemByIdRepository>();
builder.Services.AddScoped<IUpdateItemRepository, UpdateItemRepository>();

//DI SQL connection
builder.Services.AddScoped<IDbConnection>(db => new SqlConnection(builder.Configuration.GetConnectionString("ToDoAppConnectionString")));

//allow cors
builder.Services.AddCors(p => p.AddPolicy("ToDoApp", builder =>
{
    _ = builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

WebApplication app = builder.Build();

app.UseExceptionHandler("/error");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

//use cors configuration
app.UseCors("ToDoApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
