using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_16_Worker_Contract.Entities
{
    internal class Department
    {
        //PROPRIEDADES
        public string DeptName { get; set; }

        //CONSTRUTORES
        public Department() 
        {
        }

        //este construtor recebe o parâmetro um argumento 'name'
        public Department(string deptName)
        {
            DeptName = deptName;
        }

    }
}
