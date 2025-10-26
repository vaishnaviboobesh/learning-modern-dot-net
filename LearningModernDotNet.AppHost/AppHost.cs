var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.LearningModernDotNet_ApiService>("apiservice")
		.WithHttpHealthCheck("/health");

builder.AddProject<Projects.LearningModernDotNet_Web>("webfrontend")
		.WithExternalHttpEndpoints()
		.WithHttpHealthCheck("/health")
		.WithReference(apiService)
		.WaitFor(apiService);

builder.Build().Run();
