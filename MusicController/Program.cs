using MusicController.Rep;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigin",
//        builder => builder.WithOrigins("C:/Users/maria/OneDrive/Skrivebord/DR/index.html") // Din frontend URL
//                          .AllowAnyMethod()
//                          .AllowAnyHeader());
//});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<MusicRep>(new MusicRep());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();




var app = builder.Build();
//app.UseCors("AllowSpecificOrigin");

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
