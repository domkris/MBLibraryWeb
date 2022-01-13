﻿using MBLibraryWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IUserInterface : IGenericRepository<User>
    {
        IEnumerable<User> GetTopUsers(int count);
    }
}
