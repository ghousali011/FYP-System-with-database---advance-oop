using FYPManagementSystem.Model;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface IReportRepository
    {
        List<ProjectAdvisorReportItem> viewAllProjectsWithDetails();
        List<MarksSheetItem> getMarksSheetItems();
    }
}
