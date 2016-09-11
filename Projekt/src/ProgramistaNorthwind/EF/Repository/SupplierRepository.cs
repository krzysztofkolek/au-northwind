namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class SupplierRepository : BaseRepository<Supplier>
    {
        public SupplierRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
