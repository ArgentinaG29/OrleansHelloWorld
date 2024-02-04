namespace HelloWorld;

public sealed class OperationGrain : Grain, IOperationGrain
{    
    public ValueTask<string> Suma(int n1, int n2) =>
        ValueTask.FromResult($"Resultado suma: {n1 + n2}");

    public ValueTask<string> Resta(int n1, int n2) =>
        ValueTask.FromResult($"Resultado resta: {n1 - n2}");

    public ValueTask<string> Multiplicacion(int n1, int n2) =>
        ValueTask.FromResult($"Resultado multiplicación: {n1 * n2}");

    public ValueTask<string> Division(int n1, int n2) =>
        ValueTask.FromResult($"Resultado división: {n1 / n2}");
}

