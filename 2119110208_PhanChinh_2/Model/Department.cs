﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2119110208_PhanChinh_2.Model
{
    public class Department
    {
        public List<Employee> Employees { get; set; }
        public int IdDepartment { set; get; }
        public String Name_Department { set; get; }
    }
}
