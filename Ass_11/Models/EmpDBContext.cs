﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC4.Models;
//using Microsoft.EntityFrameworkCore;

namespace MVC4.Models
{
    public class EmpDBContext:DbContext
    {
        public EmpDBContext() : base("DbConnectionString")
        {

        }
        public DbSet<EmpModel> Employee { get; set; }
        
    }
   
}