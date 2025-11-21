using TheSampleApi.Startup;
using TheSampleApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.ApplyCorsConfig();

app.AddRootEndpoints();
app.AddCourseEndpoints();

app.Run();
