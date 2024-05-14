using Business.Abstacts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstacts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager:IBrandService
    {
       private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //mapping
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;
            _brandDal.add(brand);

            
            //mapping
            CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();
            createBrandResponse.Name = createBrandRequest.Name;
            createBrandResponse.Id = 4;
            createBrandResponse.CreatedDate = brand.CreatedDate;

            return createBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
