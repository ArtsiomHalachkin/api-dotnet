using Microsoft.EntityFrameworkCore;
using WebApplication.Data;

var builder = global::Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddOpenApi();  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//Redirects HTTP requests to HTTPS automatically for securit
app.UseHttpsRedirection();

//Enables authorization middleware, we haven’t added authentication yet, so this does nothing now
app.UseAuthorization();

//Connects your controller routes to the app, so HTTP requests reach your API endpoints.
app.MapControllers();

//Begin listening for HTTP requests.
app.Run();
