using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curdtask.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string? Adress { get; set; }
        public DateTime createdAt { get; set; }= DateTime.Now;
    }
}
