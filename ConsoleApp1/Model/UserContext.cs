using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
	public class UserContext : DbContext
	{
		public DbSet<User> Users { get; set; }
	}
}
