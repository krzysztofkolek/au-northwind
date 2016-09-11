namespace ProgramistaNorthwind.EF.Repository
{
    using ProgramistaNorthwind.EF.Model;
    using System;

    public partial class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(NorthwindContext context) : base(context)
        {
        }

        public override bool GetPredicate(Employee item, string id)
        {

            int idInt = Convert.ToInt32(id);

            if (item.EmployeeID.Equals(idInt))
            {
                return true;
            }

            return false;
        }
    }
}
