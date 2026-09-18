var builder = DistributedApplication.CreateBuilder(args);


var api = builder.AddProject<Projects.Flower_Shop_Api>("api");
var clientFrontend = builder.AddViteApp("client-frontend", "../Flower_Shop.ClientFrontend")
    .WithBun()
    .WithHttpEndpoint(env: "PORT")
    .WithReference(api);

builder.Build().Run();
