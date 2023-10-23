using IntegrationTest.Services.Interface;

namespace IntegrationTest.Services;

public class CalcMath : IMath
{
    public int Add(int a, int b)
    {
        return a+b;
    }
}