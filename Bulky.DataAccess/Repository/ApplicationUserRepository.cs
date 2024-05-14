﻿using Electronics.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using Electronics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Electronics.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ApplicationUser applicationUser) {
            _db.ApplicationUsers.Update(applicationUser);
        }
    }
}
