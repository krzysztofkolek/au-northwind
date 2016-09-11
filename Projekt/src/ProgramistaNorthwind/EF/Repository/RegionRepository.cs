namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class RegionRepository : BaseRepository<Region>
    {
        public RegionRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
