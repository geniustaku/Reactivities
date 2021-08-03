using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
       
        public DataContext Context { get; }
        public ActivitiesController(DataContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Context.Activities.FindAsync(id);
        }
    }
}