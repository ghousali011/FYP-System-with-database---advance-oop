using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FYPManagementSystem.DL;

namespace FYPManagementSystem.BL
{
    internal class GroupBL
    {
        public static int TotalNumberOfGroups()
        {
            return GroupDL.viewAllGroups().Count;
        }
    }
}
