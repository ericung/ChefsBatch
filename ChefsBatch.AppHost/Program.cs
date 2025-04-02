using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ChefsBatch>("chefsbatch");

// In your AppHost's Program.cs
//builder.Services.AddScoped<IDishRepository, DishRepository>(); // Repository registration
//builder.Services.AddScoped<IDishService, DishService>(); // Service registration

builder.Services.AddHostedService<MyScheduledTask>();

builder.Build().Run();
