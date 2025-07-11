using APILista.Context;
using APILista.Interface;
using APILista.Services;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddSqlServer<ListContext>(builder.Configuration.GetConnectionString("AppConnection"));
builder.Services.AddScoped<IPeople, PeopleService>();
builder.Services.AddScoped<IAnimal, AnimalService>();

builder.Services.AddCors(options => 
	options.AddPolicy("AllowMyFrontend", policy => 
		policy.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader()));
builder.Services.AddSwaggerGen( c 
	=> c.SwaggerDoc("v1", new OpenApiInfo {Title = "ListApi", Version = "v1"} ) );

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.MapOpenApi(); 
	app.UseSwagger();
	app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ListApi V1"));
}

app.UseAuthorization();
app.UseCors("AllowMyFrontend");
app.MapControllers();
app.Run();