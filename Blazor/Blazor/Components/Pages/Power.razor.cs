using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Power
    {
        int number;
        BigInteger power = 1;
        List<BigInteger> results = new List<BigInteger>();
        void setNumber(int number)
        {
            this.number = number;
        }
        void Calculate()
        {
            results = new List<BigInteger>();
            power = 1;
            for (int i = 1; i < number; i++)
            {
                power = number*number;
                results.Add(power);
            }
        }
    }
}
