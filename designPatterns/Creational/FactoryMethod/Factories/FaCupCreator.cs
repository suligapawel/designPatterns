using designPatterns.Creational.FactoryMethod.Abstracts;
using designPatterns.Creational.FactoryMethod.Products;

namespace designPatterns.Creational.FactoryMethod.Factories
{
    public class FaCupCreator : BaseCreator
    {
        public override IBall CreateBall()
        {
            return new FaCupBall();
        }
    }
}
