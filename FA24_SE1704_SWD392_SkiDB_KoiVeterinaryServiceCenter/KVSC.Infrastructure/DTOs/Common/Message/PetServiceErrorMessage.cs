using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class PetServiceErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
            => Error.Validation("PetService.Empty", $"The '{nameField}' field is required.");

        public static Error PetServiceNotExist()
            => Error.NotFound("PetService.Exist", "The pet service does not exist.");

        public static Error PetServiceNotCreated()
            => Error.Conflict("PetService.Exist", "Pet service could not be created.");

        public static Error PetServiceNotUpdated()
            => Error.Conflict("PetService.Update", "Pet service could not be updated.");

        public static Error PetServiceNotDeleted()
            => Error.Conflict("PetService.Delete", "Pet service could not be deleted.");
    }
}
