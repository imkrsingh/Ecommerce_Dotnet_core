﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Commands.Base;
using Service.RequestModel;

namespace Service.Commands.User
{
    public record DeleteUserCommand(string id) : ICommand<bool>;
}
