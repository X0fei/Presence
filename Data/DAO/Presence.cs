using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public class Presence
    {
        public DateOnly Date { get; set; }
        public virtual GroupsSubjects? GroupSubject { get; set; }
        public int GroupSubjectID { get; set; }
        public required int LessonNumber { get; set; }
        public virtual Students? Student { get; set; }
        public int StudentID { get; set; }
        public virtual Statuses? Status { get; set; }
        public int StatusID { get; set; }
    }
}
