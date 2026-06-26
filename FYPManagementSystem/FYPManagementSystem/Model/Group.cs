using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem.Model
{
    internal class Group
    {
        public int? Id { get; set; }
        public DateTime? Created_On { get; set; }
        public Group()
        {
            Created_On = DateTime.Now;
        }
        public Group (int? id = null, DateTime? Created_On = null)
        {
            this.Id = id;
            this.Created_On = Created_On;
        }
    }
}
