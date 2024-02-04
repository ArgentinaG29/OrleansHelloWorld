namespace HelloWorld;

public interface IOperationGrain : IGrainWithStringKey
{
    ValueTask<string> Suma(int n1, int n2);
    ValueTask<string> Resta(int n1, int n2);
    ValueTask<string> Multiplicacion(int n1, int n2);
    ValueTask<string> Division(int n1, int n2);
}
