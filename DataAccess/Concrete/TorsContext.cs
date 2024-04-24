using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TorsContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=FATIHMACWIN\SQLEXPRESS;database=TORS;trusted_connection=true;TrustServerCertificate=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<EquipmentMeetingRoom> EquipmentMeetingRooms { get; set; }

    }
}
