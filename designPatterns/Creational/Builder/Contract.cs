using System.Globalization;
using System.Text;

namespace designPatterns.Creational.Builder
{
    public class Contract
    {
        public bool HasHouse { get; private set; }
        public HouseEnum House { get; private set; }

        public bool HasCar { get; private set; }
        public CarEnum CarModel { get; private set; }

        private string _salary;

        public Contract(decimal salary)
        {
            _salary = salary.ToString("C", CultureInfo.CreateSpecificCulture("pl"));
        }

        public void SetCar(CarEnum carModel)
        {
            if (carModel != CarEnum.None)
            {
                HasCar = true;
            }

            CarModel = carModel;
        }

        public void SetHouse(HouseEnum house)
        {
            if (house != HouseEnum.UnderBrigde)
            {
                HasHouse = true;
            }

            House = house;
        }

        public string ShowContract()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Footballer has house? {HasHouse} - {House}");
            stringBuilder.AppendLine($"Footballer has house? {HasCar} - {CarModel}");
            stringBuilder.AppendLine($"Footballer salary: {_salary}");

            return stringBuilder.ToString();
        }
    }
}