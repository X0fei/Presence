using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Request
{
    public class AddGroupWithStudentsRequest
    {
        public AddGroupRequest AddGroupRequest { get; set; }
        public IEnumerable<AddStudentRequest> AddStudentRequests { get; set; }
    }
}
