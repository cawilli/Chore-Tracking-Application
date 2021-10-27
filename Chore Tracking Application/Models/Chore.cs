using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chore_Tracking_Application.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
