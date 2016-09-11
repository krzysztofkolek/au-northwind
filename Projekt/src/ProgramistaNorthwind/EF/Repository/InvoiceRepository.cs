namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class InvoiceRepository : BaseRepository<Invoice>
    {
        public InvoiceRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
