using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class StudentEntity
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public GroupEntity Group { get; set; }
    }
}
