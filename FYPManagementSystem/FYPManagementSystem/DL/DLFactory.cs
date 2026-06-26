using System;
using System.Configuration;

namespace FYPManagementSystem.DL
{
    internal static class DLFactory
    {
        public static IPersonRepository PersonRepository { get; private set; }
        public static IStudentRepository StudentRepository { get; private set; }
        public static IAdvisorRepository AdvisorRepository { get; private set; }
        public static IEvaluationRepository EvaluationRepository { get; private set; }
        public static IGroupRepository GroupRepository { get; private set; }
        public static IGroupEvaluationRepository GroupEvaluationRepository { get; private set; }
        public static IGroupProjectRepository GroupProjectRepository { get; private set; }
        public static IGroupStudentRepository GroupStudentRepository { get; private set; }
        public static ILookupRepository LookupRepository { get; private set; }
        public static IProjectAdvisorRepository ProjectAdvisorRepository { get; private set; }
        public static IProjectRepository ProjectRepository { get; private set; }
        public static IReportRepository ReportRepository { get; private set; }

        public static void Initialize()
        {
            string storageType = ConfigurationManager.AppSettings["StorageType"];
            if (string.IsNullOrEmpty(storageType))
            {
                storageType = "file";
            }

            if (storageType.ToLower() == "file")
            {
                LookupRepository = new FileLookupRepository();
                PersonRepository = new FilePersonRepository();
                StudentRepository = new FileStudentRepository();
                AdvisorRepository = new FileAdvisorRepository();
                EvaluationRepository = new FileEvaluationRepository();
                GroupRepository = new FileGroupRepository();
                GroupEvaluationRepository = new FileGroupEvaluationRepository();
                GroupProjectRepository = new FileGroupProjectRepository();
                GroupStudentRepository = new FileGroupStudentRepository();
                ProjectAdvisorRepository = new FileProjectAdvisorRepository();
                ProjectRepository = new FileProjectRepository();
                ReportRepository = new FileReportRepository();
            }
            else
            {
                LookupRepository = new SqlLookupRepository();
                PersonRepository = new SqlPersonRepository();
                StudentRepository = new SqlStudentRepository();
                AdvisorRepository = new SqlAdvisorRepository();
                EvaluationRepository = new SqlEvaluationRepository();
                GroupRepository = new SqlGroupRepository();
                GroupEvaluationRepository = new SqlGroupEvaluationRepository();
                GroupProjectRepository = new SqlGroupProjectRepository();
                GroupStudentRepository = new SqlGroupStudentRepository();
                ProjectAdvisorRepository = new SqlProjectAdvisorRepository();
                ProjectRepository = new SqlProjectRepository();
                ReportRepository = new SqlReportRepository();
            }
        }
    }
}
