using Retail_backend.DTOs.Product;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class ProductService : IProductService
    {
        public Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            throw new NotImplementedException();
        }


        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Common.PagedResult<ProductDto>> GetAllAsync(ProductFilterDto filter)
        {
            throw new NotImplementedException();
        }


        public Task<ProductDto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto?> UpdateAsync(int id, CreateProductDto dto)
        {
            throw new NotImplementedException();
        }


    }
}
