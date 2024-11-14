using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAO
{
    public class Groups
    {
        [Key] public int ID { get; set; }
        public required string Name { get; set; }
    }
}
