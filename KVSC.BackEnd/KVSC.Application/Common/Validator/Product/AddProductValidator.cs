using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Product.AddProduct;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.Product
{
    public class AddProductValidator : ProductValidator<AddProductRequest>
    {
        public AddProductValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddProductNameRules(request => request.Name, checkExists:true);
            AddProductPriceRules(priceExpression => priceExpression.Price);
            AddProductDescriptionRules(descriptionExpression => descriptionExpression.Description);
        }
    }
}
