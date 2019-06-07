using designPatterns.Behavioral.ChainOfResponsibility;
using designPatterns.Behavioral.Command;
using designPatterns.Behavioral.Memento;
using designPatterns.Behavioral.Observer;
using designPatterns.Behavioral.State;
using designPatterns.Behavioral.Strategy;
using designPatterns.Behavioral.TemplateMethod;
using designPatterns.Behavioral.Visitor;
using designPatterns.Creational.AbstractFactory;
using designPatterns.Creational.Builder;
using designPatterns.Creational.FactoryMethod;
using designPatterns.Creational.Prototype;
using designPatterns.Creational.Singleton;
using designPatterns.Structural.Adapter;
using designPatterns.Structural.Composite;
using designPatterns.Structural.Decorator;
using designPatterns.Structural.Facade;
using designPatterns.Structural.Flyweight;
using designPatterns.Structural.Proxy;

namespace designPatterns.Creational.SimpleFactory
{
    //ANTI-PATTERN [?]
    public class SimpleFactory
    {
        public static IClient GetPatternClient(DesignPattern pattern)
        {
            switch (pattern)
            {
                case DesignPattern.AbstractFactory:
                    return new AbstractFactoryClient();
                case DesignPattern.Builder:
                    return new BuilderClient();
                case DesignPattern.FactoryMethod:
                    return new FactoryMethodClient();
                case DesignPattern.Prototype:
                    return new PrototypeClient();
                case DesignPattern.Singleton:
                    return new SingletonClient();
                case DesignPattern.Adapter:
                    return new AdapterClient();
                case DesignPattern.Bridge:
                    return null;
                case DesignPattern.Composite:
                    return new CompositeClient();
                case DesignPattern.Decorator:
                    return new DecoratorClient();
                case DesignPattern.Facade:
                    return new FacadeClient();
                case DesignPattern.Flyweight:
                    return new FlyweightClient();
                case DesignPattern.Proxy:
                    return new ProxyClient();
                case DesignPattern.ChainOfResponsibility:
                    return new ChainOfResponsibilityClient();
                case DesignPattern.Command:
                    return new CommandClient();
                case DesignPattern.Iterator:
                    return null;
                case DesignPattern.Mediator:
                    return null;
                case DesignPattern.Memento:
                    return new MementoClient();
                case DesignPattern.Observer:
                    return new ObserverClient();
                case DesignPattern.State:
                    return new StateClient();
                case DesignPattern.Strategy:
                    return new StrategyClient();
                case DesignPattern.TemplateMethod:
                    return new TemplateMethodClient();
                case DesignPattern.Visitor:
                    return new VisitorClient();
                default:
                    return null;
            }
        }
    }
}
