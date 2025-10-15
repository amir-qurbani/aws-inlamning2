var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Appen lyssnar på port 8080 i containern
app.Urls.Add("http://0.0.0.0:8080");

// Health check (för ALB)
app.MapGet("/health", () => Results.Ok("OK"));

// Startsida
app.MapGet("/", () => Results.Text("Hello from Swarm", "text/plain"));

app.Run();
