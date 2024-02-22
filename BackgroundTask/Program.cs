using BackGroundTask;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HostOptions>(x=>{
    x.ServicesStartConcurrently = true;
    x.ServicesStopConcurrently = false;
});
// builder.Services.AddHostedService<ExampleBackgroundService>();
builder.Services.AddHostedService<ExampleService>();

var app = builder.Build();

app.Run();