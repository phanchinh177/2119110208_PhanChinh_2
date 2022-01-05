using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2119110208_PhanChinh_2.DAL;
using _2119110208_PhanChinh_2.Model;

namespace _2119110208_PhanChinh_2.BAL
{
    public class DepartmentBAL
    {
        DepartmentDAL dal = new DepartmentDAL();
        public List<Department> ReadAreaList()
        {
            List<Department> lstDepart = dal.ReadAreaList();
            return lstDepart;
        }
    }
}
