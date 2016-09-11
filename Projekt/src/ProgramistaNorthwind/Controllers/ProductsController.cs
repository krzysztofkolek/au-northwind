namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Models.Products;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private ProductRepository _repo { get; set; }

        public ProductsController(NorthwindContext context)
        {
            _repo = new ProductRepository(context);
        }

        // GET api/product
        [HttpGet]
        public IEnumerable<ProductIndex> GetIndex()
        {
            return _repo.GetAll().Select(item => new ProductIndex()
            {
                Id = item.ProductID,
                Name = item.ProductName,
                Category = (item.Category != null) ? item.Category.CategoryName : "",
                IsInStock = (item.UnitsInStock.HasValue && item.UnitsInStock.Value > 0) ? true : false,
                UnitPrice = System.Convert.ToDouble(item.UnitPrice),
            });
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public ProductDetails Get(int id)
        {
            var repoResult = _repo.Get(id); 

            if (repoResult == null)
            {
                return new ProductDetails();
            }


            return new ProductDetails()
            {
                ProductName = (repoResult.ProductName != null) ? repoResult.ProductName : "",
                Discontinued = repoResult.Discontinued,
                QuantityPerUnit = repoResult.QuantityPerUnit,
                ReorderLevel = (repoResult.ReorderLevel.HasValue) ? repoResult.ReorderLevel.Value : (short)0,
                UnitPrice = (repoResult.UnitPrice.HasValue) ? repoResult.UnitPrice.Value : (short)0,
                UnitsInStock = (repoResult.UnitsInStock.HasValue) ? repoResult.UnitsInStock.Value : (short)0,
                UnitsOnOrder = (repoResult.UnitsOnOrder.HasValue) ? repoResult.UnitsOnOrder.Value : (short)0
            };
        }

        // POST api/product
        [HttpPost]
        public void Post([FromBody]ProductDetails value)
        {

        }

        // PUT api/product/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]ProductDetails value)
        {

        }

        // DELETE api/product/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
