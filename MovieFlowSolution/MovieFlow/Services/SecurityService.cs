﻿using MovieFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {

        }

        public bool IsValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
        }
    }
}
