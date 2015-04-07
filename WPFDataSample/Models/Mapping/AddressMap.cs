using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WPFDataSample.Models.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.addressID);

            // Properties
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

            // Table & Column Mappings
            this.ToTable("Address");
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

            // Relationships
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.ContactID);

        }
    }
}
