using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public class Presence
    {
        public virtual GroupsSubjects? GroupSubject { get; set; }
        public DateOnly Date { get; set; }
        public required int LessonNumber { get; set; }
        public virtual Students? Studend { get; set; }
        public virtual Statuses? Status { get; set; }
    }
}
