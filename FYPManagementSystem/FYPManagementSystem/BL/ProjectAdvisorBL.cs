using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    internal class ProjectAdvisorBL
    {
        public static int TotalAdivisorsAssigned()
        {
            return ProjectAdvisorDL.viewAllProjectAdvisors().Select(pa => pa.advisorId).Distinct().Count();
        }
    }
}
