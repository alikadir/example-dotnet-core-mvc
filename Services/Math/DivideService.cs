namespace FirstDotnetCoreMVC.Services.Math
{
    public class DivideService:IMathService
    {
        public float Math(int a, int b)
        {
            return a / b;
        }
    }
}