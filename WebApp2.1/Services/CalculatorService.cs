using WebApp2._1.Models;

namespace WebApp2._1.Services
{
    public class CalculatorService
    {
        private readonly Random _random = new();

        public CalculatorViewModel GetCalcModel()
        {
            var x = _random.Next() % 11;
            var y = _random.Next() % 11;
            return new CalculatorViewModel(
                x,
                y,
                add: $"{x} + {y} = {x + y}",
                sub: $"{x} - {y} = {x - y}",
                mult: $"{x} * {y} = {x * y}",
                div: y == 0 ? "Error: division by zero" :  $"{x} /  {y} = {x / y}"
            );
        }
    }
}

