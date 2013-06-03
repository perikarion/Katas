using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Finder
    {
        private readonly List<Person> _person;

        public Finder(List<Person> person)
        {
            _person = person;
        }

        public Pair Find(FindType findType)
        {
            var results = GetPairs();

            if(results.Count() < 1)
                return new Pair();
            
            if (findType == FindType.ClosestAge)
                return results.OrderBy(x => x.Delta).First();
            return results.OrderByDescending(x => x.Delta).First();

        }

        private IEnumerable<Pair> GetPairs()
        {
            for (var i = 0; i < _person.Count - 1; i++)
                for (var j = i + 1; j < _person.Count; j++)
                    yield return new Pair(_person[i], _person[j]);                 
        }
    }
}