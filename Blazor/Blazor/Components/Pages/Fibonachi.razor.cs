using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Fibonachi
    {
        int number;
        BigInteger fibonachi = 1;
        List<BigInteger> results = new List<BigInteger>();
        void setNumber(int number)
        {
            this.number = number;
        }
        void Calculate()
        {
            results = new List<BigInteger>();
            fibonachi = 0;
            results.Add(fibonachi);
            fibonachi = 1;
            results.Add(fibonachi);
            for (int i = 1; i < number; i++)
            {
                fibonachi = results[i-1]+fibonachi;
                //fibonachi = results[i-1]+fibonachi;
                results.Add(fibonachi);
            }
        }
    }
}
