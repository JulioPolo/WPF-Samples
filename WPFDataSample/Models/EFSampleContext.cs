using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WPFDataSample.Models.Mapping;

namespace WPFDataSample.Models
{
    public partial class EFSampleContext : DbContext
    {
        static EFSampleContext()
        {
            Database.SetInitializer<EFSampleContext>(null);
        }

        public EFSampleContext()
            : base("Name=EFSampleContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<vOfficeAddress> vOfficeAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new vOfficeAddressMap());
        }
    }
}
