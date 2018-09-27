using designPatterns.Creational.Builder.Abstracts;

namespace designPatterns.Creational.Builder.ConcreteBuilders
{
    public class StarContractBuilder : IContractBuilder
    {
        private const decimal SALARY = 100000000M;
        private readonly int _age;

        private Contract _contract;

        public StarContractBuilder(int age)
        {
            _age = age;
            _contract = new Contract(SALARY);
        }

        public Contract GetContract() => _contract;

        public IContractBuilder SetCar()
        {            
            if (IsTooYoungForVeyron())
            {
                _contract.SetCar(CarEnum.Mulitpla);
            }
            else
            {
                _contract.SetCar(CarEnum.Veyron);
            }

            return this;
        }

        public IContractBuilder SetHouse()
        {
            _contract.SetHouse(HouseEnum.House);

            return this;
        }

        private bool IsTooYoungForVeyron() => _age < 21;
    }
}