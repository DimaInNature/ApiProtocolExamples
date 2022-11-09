var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet(
    pattern: "Receiver/SayMessage/{message}",
    handler: (string message) => Results.Json(data: $"From receiver: {message}"))
    .WithOpenApi()
    .WithTags(tags: "Demo tag")
    .WithDescription(description: "Demo description")
    .WithSummary(summary: "Demo summary");

await app.RunAsync();