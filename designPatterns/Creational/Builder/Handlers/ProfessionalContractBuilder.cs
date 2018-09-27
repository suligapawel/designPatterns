using designPatterns.Creational.Builder.Abstracts;

namespace designPatterns.Creational.Builder.ConcreteBuilders
{
    public class ProfessionalContractBuilder : IContractBuilder
    {
        private const decimal SALARY = 250000M;
        private Contract _contract;

        public ProfessionalContractBuilder()
        {
            _contract = new Contract(SALARY);
        }

        public Contract GetContract() => _contract;

        public IContractBuilder SetCar()
        {
            _contract.SetCar(CarEnum.Mulitpla);
            return this;
        }

        public IContractBuilder SetHouse()
        {
            _contract.SetHouse(HouseEnum.Flat);
            return this;
        }
    }
}