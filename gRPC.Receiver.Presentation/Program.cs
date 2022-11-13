Console.WriteLine(value: "Input first number.");

int number = Convert.ToInt32(value: Console.ReadLine());

Console.WriteLine(value: "Input second number.");

int number2 = Convert.ToInt32(value: Console.ReadLine());

using var channel = GrpcChannel.ForAddress(address: "https://localhost:7243");

var client = new Calculator.CalculatorClient(channel);

var reply = await client.SumAsync(request: new()
{
   Number = number,
   Number2 = number2
});

Console.WriteLine(value: $"Sum is {reply.Result}.");

Console.ReadLine();