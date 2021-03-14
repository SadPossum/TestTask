using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Services
{
    public class SomeDataService
    {
        public IEnumerable<string> GetData()
        {
            string[] lines =
            {
            "Lorem ipsum dolor sit amet.",
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Pariatur, similique?",
            "Lorem ipsum dolor sit amet consectetur."
            };

            return lines;
        }
    }
}
