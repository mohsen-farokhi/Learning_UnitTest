using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UOM.Domain.Dimensions;

namespace UOM.Persistence.EF.Mappings
{
    public class DimensionMapping : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
