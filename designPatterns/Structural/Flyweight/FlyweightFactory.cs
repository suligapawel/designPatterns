using designPatterns.Structural.Flyweight.Abstracts;
using System.Collections.Generic;

namespace designPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<int, IFlyweightFan> _dbFans = FakeDb.Fans;

        private readonly Dictionary<int, IFlyweightFan> _fansOnStadiumCache;

        public FlyweightFactory()
        {
            _fansOnStadiumCache = new Dictionary<int, IFlyweightFan> {
                {_dbFans[1].Id, _dbFans[1] },
                {_dbFans[3].Id, _dbFans[3] },
                {_dbFans[4].Id, _dbFans[4] },
                {_dbFans[7].Id, _dbFans[7] },
                {_dbFans[8].Id, _dbFans[8] },
            };
        }

        public IFlyweightFan GetFan(int id)
        {
            if (_fansOnStadiumCache.ContainsKey(id))
                return _fansOnStadiumCache[id];

            IFlyweightFan fan = _dbFans.GetValueOrDefault(id);

            if (fan != null)
                _fansOnStadiumCache.Add(fan.Id, fan);

            return fan;
        }

        public IFlyweightFan GetFan(int id, string firstName, string lastName, string team)
        {
            if (_fansOnStadiumCache.ContainsKey(id))
                return _fansOnStadiumCache[id];

            IFlyweightFan fan = _dbFans.GetValueOrDefault(id);

            if (fan == null)
            {
                fan = new Fan(id, firstName, lastName, team);
            }

            _fansOnStadiumCache.Add(fan.Id, fan);

            return fan;
        }
    }
}
