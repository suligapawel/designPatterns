using designPatterns.Creational.Builder.Abstracts;

namespace designPatterns.Creational.Builder
{
    public class Director
    {
        private IContractBuilder _builder;
        public Director(IContractBuilder builder)
        {
            _builder = builder;
        }

        public void SetNewBuilder(IContractBuilder builder){
            _builder = builder;
        }

        public Contract GenerateContract()
        {
            return _builder
                .SetCar()
                .SetHouse()
                .GetContract();
        }
    }
}