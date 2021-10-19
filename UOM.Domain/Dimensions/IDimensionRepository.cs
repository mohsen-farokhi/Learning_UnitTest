namespace UOM.Domain.Dimensions
{
    public interface IDimensionRepository
    {
        long Add(Dimension dimension);
        Dimension GetById(long id);
    }
}
