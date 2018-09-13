using System;

namespace designPatterns.Creational.Prototype
{
    public class Football : IFootball
    {
        public int _id;
        private bool _isInflated;

        public Football(bool isInflated)
        {
            _id = 1;
            _isInflated = isInflated;
        }

        public IFootball Clone()
        {
            Football clone = (Football)this.MemberwiseClone();
            clone._id++;
            Console.WriteLine($"Ball's delivery number {clone._id}. Football {(clone._isInflated ? "is inflated" : "is not inflated")}");

            return clone;
        }

        public void InflateFootball()
        {
            if (!_isInflated)
            {
                Console.WriteLine($"Football number {_id} is now inflated");
                _isInflated = true;
                return;
            }

            Console.WriteLine($"BOOM! Football number {_id} is damaged.");
        }
    }
}