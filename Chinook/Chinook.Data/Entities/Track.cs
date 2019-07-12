using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    partial class Track 
    {
        public override string ToString()
        {
            return $"{TrackId} / {Name}";
        }
    }
}
