namespace FirstDotnetCoreMVC.Services.Math
{
    public class MinusService:IMathService
    {
        public float Math(int a, int b)
        {
            return a - b;
        }
    }
}