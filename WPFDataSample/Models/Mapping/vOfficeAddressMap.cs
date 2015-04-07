using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WPFDataSample.Models.Mapping
{
    public class vOfficeAddressMap : EntityTypeConfiguration<vOfficeAddress>
    {
        public vOfficeAddressMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FirstName, t.LastName, t.addressID, t.AddressType, t.ContactID, t.ModifiedDate });

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.addressID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Street1)
                .HasMaxLength(50);

            this.Property(t => t.Street2)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.StateProvince)
                .HasMaxLength(50);

            this.Property(t => t.CountryRegion)
                .HasMaxLength(50);

            this.Property(t => t.PostalCode)
                .HasMaxLength(50);

            this.Property(t => t.AddressType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ContactID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vOfficeAddresses");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.addressID).HasColumnName("addressID");
            this.Property(t => t.Street1).HasColumnName("Street1");
            this.Property(t => t.Street2).HasColumnName("Street2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.StateProvince).HasColumnName("StateProvince");
            this.Property(t => t.CountryRegion).HasColumnName("CountryRegion");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.AddressType).HasColumnName("AddressType");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
