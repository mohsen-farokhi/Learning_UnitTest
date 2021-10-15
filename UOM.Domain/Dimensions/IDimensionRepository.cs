namespace UOM.Domain.Dimensions
{
    public interface IDimensionRepository
    {
        long NextId();
        void Add(Dimension dimension);
        Dimension GetById(long id);
    }
}
