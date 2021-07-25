using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Model
{
    public class Items
    {
        public string Id { get; set; }
        public string Task { get; set; }
        public string Tags { get; set; }
        public DateTime SetTime { get; set; }
        public DateTime FinTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Data { get; set; }
    }
}
