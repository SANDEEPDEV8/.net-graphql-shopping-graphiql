using GraphiQl;
using GraphQL;
using GraphQL.Types;
using ShoppingGraphQL.Data;
using ShoppingGraphQL.Interfaces;
using ShoppingGraphQL.Mutation;
using ShoppingGraphQL.Query;
using ShoppingGraphQL.Schema;
using ShoppingGraphQL.Services;
using ShoppingGraphQL.Type;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.AddTransient<BookType>();
builder.Services.AddTransient<CategoryType>();
builder.Services.AddTransient<OrderType>();

builder.Services.AddTransient<BookQuery>();
builder.Services.AddTransient<CategoryQuery>();
builder.Services.AddTransient<OrderQuery>();
builder.Services.AddTransient<RootQuery>();

builder.Services.AddTransient<BookMutation>();
builder.Services.AddTransient<CategoryMutation>();
builder.Services.AddTransient<OrderMutation>();
builder.Services.AddTransient<RootMutation>();


builder.Services.AddTransient<BookInputType>();
builder.Services.AddTransient<CategoryInputType>();
builder.Services.AddTransient<OrderInputType>();

builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

builder.Services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("GraphQLDbContextConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
