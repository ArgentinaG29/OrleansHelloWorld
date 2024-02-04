using HelloWorld;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Configure the host
using var host = new HostBuilder()
    .UseOrleans(builder => builder.UseLocalhostClustering())
    .Build();

// Start the host
await host.StartAsync();

// Get the grain factory
var grainFactory = host.Services.GetRequiredService<IGrainFactory>();

// Get a reference to the HelloGrain grain with the key "friend"
var friend = grainFactory.GetGrain<IHelloGrain>("friend");
var suma = grainFactory.GetGrain<IOperationGrain>("suma");

// Call the grain and print the result to the console
var result = await friend.SayHello("Good morning!");
Random random = new Random();
int n1 = random.Next(1, 10);
int n2 = random.Next(1, 10);
var result1 = await suma.Suma(n1, n2);
var result2 = await suma.Resta(n1, n2);
var result3 = await suma.Multiplicacion(n1, n2);
var result4 = await suma.Division(n1, n2);

Console.WriteLine("Numero 1: " + n1);
Console.WriteLine("Numero 2: " + n2);
Console.WriteLine($"""

    {result}

    """);

Console.WriteLine($"""

    { result1}

""");

Console.WriteLine($"""

    { result2}

""");

Console.WriteLine($"""

    { result3}

""");

Console.WriteLine($"""

    { result4}

""");

Console.WriteLine("Orleans is running.\nPress Enter to terminate...");
Console.ReadLine();
Console.WriteLine("Orleans is stopping...");

await host.StopAsync();
