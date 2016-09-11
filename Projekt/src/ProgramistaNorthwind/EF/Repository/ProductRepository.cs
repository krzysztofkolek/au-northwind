namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;
    using System;

    public partial class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(NorthwindContext context) : base(context)
        {
        }

        public override bool GetPredicate(Product item, string id)
        {
            int idInt = Convert.ToInt32(id);

            if (item.ProductID.Equals(idInt))
            {
                return true;
            }

            return false;
        }
    }
}
