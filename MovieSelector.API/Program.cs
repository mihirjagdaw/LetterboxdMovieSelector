using MovieSelector.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddSingleton<MovieService>();
builder.Services.AddHttpClient<YtsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/movie/yts", async (string title, YtsService yts) =>
{
    var result = await yts.searchMovieAsync(title);
    return result is not null ? Results.Ok(result) : Results.NotFound();
});

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

