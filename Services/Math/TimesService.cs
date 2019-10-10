namespace FirstDotnetCoreMVC.Services.Math
{
    public class MultiplyService:IMathService
    {
        public float Math(int a, int b)
        {
            return a * b;
        }
    }
}