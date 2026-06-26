using System.Collections.Generic;

namespace FYPManagementSystem.DL
{
    internal interface ILookupRepository
    {
        int Code(string str, string category);
        string Decode(int id);
        List<string> AllValuesForCategory(string category);
    }
}
