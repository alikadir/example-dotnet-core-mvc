namespace FirstDotnetCoreMVC.Services.Math
{
    public class SumService:IMathService
    {
        public float Math(int a, int b)
        {
            return a + b;
        }
    }
}