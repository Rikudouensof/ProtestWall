﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProtestWall.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProtestWall.Data
{
  public class ApplicationDbContext : IdentityDbContext<User>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
  }
}
