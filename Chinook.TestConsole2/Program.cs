using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.TestConsole2
{
    class Program
    {
        private const string Path = "sumi.json";
        static void Main(string[] args)
        {
            List<String> tracks = DataRepository.Track.Select(x => x.Name, x => x.Name.Contains("blue"));

            Console.WriteLine(tracks);
        }

        private static void Serialize()
        {
            DataRepository.Track.Select(x => x.Name.Contains("blue"));
        }
    }
}
