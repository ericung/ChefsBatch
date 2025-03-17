var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ChefsBatch>("chefsbatch");

builder.Build().Run();
