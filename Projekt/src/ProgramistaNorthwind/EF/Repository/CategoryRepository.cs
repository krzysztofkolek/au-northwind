namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;

    public partial class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(NorthwindContext context) : base(context)
        {
        }
    }
}
