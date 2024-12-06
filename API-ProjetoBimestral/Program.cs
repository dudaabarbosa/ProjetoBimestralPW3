var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:8080", "http://localhost:3000") // Dom�nios permitidos
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    // Loga informa��es b�sicas da requisi��o
    Console.WriteLine($"M�todo: {context.Request.Method}, Rota: {context.Request.Path} {context.Request.Body}");

    // Continua para o pr�ximo middleware
    await next.Invoke();
});


app.UseCors("AllowSpecificOrigins");
app.MapControllers();

app.Run();
