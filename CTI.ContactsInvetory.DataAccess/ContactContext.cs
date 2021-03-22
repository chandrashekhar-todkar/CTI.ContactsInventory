using CTI.ContactsInvetory.Dto;
using Microsoft.EntityFrameworkCore;

namespace CTI.ContactsInvetory.DataAccess
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
    }
}
