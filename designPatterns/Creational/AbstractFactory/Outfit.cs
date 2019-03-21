using designPatterns.Creational.AbstractFactory.Abstracts;
using System.Text;

namespace designPatterns.Creational.AbstractFactory
{
    public class Outfit
    {
        private readonly IShirtProduct _shirt;
        private readonly IShortProduct _short;
        private readonly ISocksProduct _socks;

        public Outfit(IOutfitFactory factory)
        {
            _shirt = factory.ProduceShirt();
            _short = factory.ProduceShort();
            _socks = factory.ProduceSocks();
        }

        public decimal CalculateCoast()
        {
            return _shirt.Price + _short.Price + _socks.Price;
        }

        public string GetOutfitInfo() {
            var result = new StringBuilder();

            result.AppendLine($"Materiał koszulki: {_shirt.Textile}");
            result.AppendLine($"Długi rękaw: {_shirt.IsShortSleeve}");
            result.AppendLine($"Materiał spodenek: {_short.Textile}");
            result.AppendLine($"Kolor spodenek: {_short.Color}");
            result.AppendLine($"Rozmiar getr: {_socks.Size}");

            return result.ToString();
        }
    }
}
