﻿using Microsoft.EntityFrameworkCore;
using Taskify.DataAccess.Contexts;
using Taskify.DataAccess.IRepository;
using Taskify.DataAccess.Models;


namespace Taskify.DataAccess.Repsitory
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser?> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser?> GetByUserNameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
