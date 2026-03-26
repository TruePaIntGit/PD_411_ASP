namespace Blazor.Components.Pages
{
    public partial class Dec2Bin
    {
        int number;
        string data="0";
        void Calculate()
        {
            data = Convert.ToString(number,2);
        }
    }
}
