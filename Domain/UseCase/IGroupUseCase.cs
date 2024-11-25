﻿using Domain.Entity;
using Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCase
{
    public interface IGroupUseCase
    {
        public void GetGroupsWithStudents();
        public void AddGroup(AddGroupRequest addGroupRequest);
        public void AddGroupWithStudents(AddGroupWithStudentsRequest addGroupWithStudents);
    }
}
