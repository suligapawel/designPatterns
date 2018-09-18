using designPatterns.Creational.Builder.Abstracts;

namespace designPatterns.Creational.Builder.ConcreteBuilders
{
    public class AmatorContractBuilder : IContractBuilder
    {
        private const decimal SALARY = 5M;
        private Contract _contract;

        public AmatorContractBuilder()
        {
            _contract = new Contract(SALARY);
        }

        public Contract GetContract() => _contract;

        public IContractBuilder SetCar()
        {
            _contract.SetCar(CarEnum.None);
            return this;
        }

        public IContractBuilder SetHouse()
        {
            _contract.SetHouse(HouseEnum.UnderBrigde);
            return this;
        }
    }
}