namespace WebApp2._1.Models
{
    public class CalculatorViewModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Add { get; set; }
        public string Sub { get; set; }
        public string Mult { get; set; }
        public string Div { get; set; }
        public CalculatorViewModel(int x, int y, string add, string sub, string mult, string div)
        {
            X = x;
            Y = y;
            Add = add;
            Sub = sub;
            Mult = mult;
            Div = div;
        }
    }
}
