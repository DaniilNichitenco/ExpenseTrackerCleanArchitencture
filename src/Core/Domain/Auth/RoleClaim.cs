﻿using System;
using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.Core.Domain.Auth
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
    }
}
