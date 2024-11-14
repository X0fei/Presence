using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public class GroupsSubjects
    {
        [Key] public int ID { get; set; }
        public virtual Groups? Group { get; set; }
        public virtual Subjects? Subject { get; set; }
        public int Semester { get; set; }
    }
}
