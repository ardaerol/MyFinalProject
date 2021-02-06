using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccsess.Abstract
{
  public  interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
