using FYPManagementSystem.Model;
using FYPManagementSystem.DL;
using System.Collections.Generic;
using System.Linq;

namespace FYPManagementSystem.BL
{
    internal class ReportsBL
    {
        public static List<ProjectAdvisorReportItem> GetProjectsWithAdvisorsAndStudents()
        {
            var projects = ProjectDLForReports.viewAllProjectsWithDetails();
            return projects;
        }

        public static List<MarksSheetItem> GetMarksSheet()
        {
            return ProjectDLForReports.getMarksSheetItems();
        }
    }
}
