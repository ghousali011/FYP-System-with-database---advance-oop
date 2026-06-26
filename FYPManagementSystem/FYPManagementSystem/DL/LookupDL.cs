using FYPManagementSystem.Model;
using System;
using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal class LookupDL
    {
        public static string path = @"D:\New folder (2)\UET\Smester 2\OOP\Final Project\Business Application\FYP System with files\FYPManagementSystem\FYPManagementSystem\DL\Files\";

        public static int Code(string str, string category)
        {
            return DLFactory.LookupRepository.Code(str, category);
        }

        public static string Decode(int id)
        {
            return DLFactory.LookupRepository.Decode(id);
        }

        public static List<string> allValuesForCategory(string category)
        {
            return DLFactory.LookupRepository.AllValuesForCategory(category);
        }
    }
}
