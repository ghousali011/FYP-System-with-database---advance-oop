using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class ProjectDLForReports
    {
        public static List<ProjectAdvisorReportItem> viewAllProjectsWithDetails()
        {
            return DLFactory.ReportRepository.viewAllProjectsWithDetails();
        }

        public static List<MarksSheetItem> getMarksSheetItems()
        {
            return DLFactory.ReportRepository.getMarksSheetItems();
        }
    }
}
