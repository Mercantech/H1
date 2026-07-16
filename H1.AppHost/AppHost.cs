var builder = DistributedApplication.CreateBuilder(args);

var postgres = builder.AddPostgres("postgres")
    .WithDataVolume()
    .WithPgAdmin();

var h1db = postgres.AddDatabase("h1db");

builder.AddProject<Projects.H1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(h1db)
    .WaitFor(h1db);

builder.Build().Run();
