using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Models
{

    public class Dept
    {
        public int Id { get; set; }
        public string Name { set; get; }

        public Dept(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
