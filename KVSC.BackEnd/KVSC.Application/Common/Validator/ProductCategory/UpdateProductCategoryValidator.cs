using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.ProductCategory.AddProductCategory;
using KVSC.Infrastructure.DTOs.ProductCategory.UpdateProductCategory;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.ProductCategory
{
    public class UpdateProductCategoryValidator : ProductCategoryValidator<UpdateProductCategoryRequest>
    {
        public UpdateProductCategoryValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddCategoryNameRules(request => request.Name, checkExists: true);
            AddCategoryDescriptionRules(descriptionExpression => descriptionExpression.Description);
        }
    }
}
