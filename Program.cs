using WebApplication1.Interfaces;
using WebApplication1.Models;

//using Core.Models;
using WebApplication1.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register CustomerService with HttpClient and default credentials.
builder.Services.AddHttpClient<InstructorService>()
	.ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
	{
		UseDefaultCredentials = true,
	});
builder.Services.AddScoped<IInstructor, InstructorService>();
builder.Services.AddSingleton<Credentials>();
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