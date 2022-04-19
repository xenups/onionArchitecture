using BookApp.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;
using BookApp.Core.Contracts.Books;
using System.Reflection;
using MediatR;
using BookApp.Core.ApplicationServices.Books;
using BookApp.Core.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BookDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IBookRepository, BookRepository>();
builder.Services.AddMediatR(typeof(AddBookService).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(RetrieveBookService).GetTypeInfo().Assembly);
builder.Services.AddAutoMapper(typeof(BookMapperProfile).GetTypeInfo().Assembly);
builder.Services.AddAutoMapper(typeof(Program));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
