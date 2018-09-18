namespace designPatterns.Creational.Builder.Abstracts
{
    public interface IContractBuilder
    {
        IContractBuilder SetHouse();
        IContractBuilder SetCar();
        Contract GetContract();
    }
}