using Microsoft.OpenApi.Models;
using MoviesAPI.Context;
using MoviesAPI.Interfaces;
using MoviesAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddSqlServer<MovieAPIContext>(builder.Configuration.GetConnectionString("AppConnection"));
builder.Services.AddScoped<IMovie, MovieService>();

builder.Services.AddCors(options =>
	options.AddPolicy("AllowAPIFrontend", policy =>
		policy.AllowAnyOrigin()
			.AllowAnyMethod()
			.AllowAnyHeader()));
builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "Movie API", Version = "v1" }));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
	app.UseSwagger();
	app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie API v1"));
}


app.UseCors("AllowAPIFrontend");
app.UseAuthorization();
app.MapControllers();
app.Run();