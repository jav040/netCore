using TodoApi.StartupConfig;

var builder = WebApplication.CreateBuilder(args);
builder.AddStandardServices();
builder.AddAuthServices();  
builder.AddHealthCheckServices();
builder.AddCustomServices();
// Add services to the container.
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();    
app.UseAuthorization();
app.MapControllers();
app.MapHealthChecks(pattern: "/health").AllowAnonymous();
app.Run();