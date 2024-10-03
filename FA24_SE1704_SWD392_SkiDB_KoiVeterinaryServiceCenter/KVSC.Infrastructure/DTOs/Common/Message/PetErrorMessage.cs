﻿using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class PetErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
            => Error.Validation("Pet.Empty", $"The '{nameField}' is required.");

        public static Error FieldMustBePositive(string nameField)
           => Error.Validation("Pet.Positive", $"The '{nameField}' must be a positive value.");

        public static Error FieldLength(string nameField, int minLength, int maxLength)
            => Error.Validation("Pet.Length", $"The '{nameField}' must be between {minLength} and {maxLength} characters long.");

        public static Error InvalidAge(string age)
           => Error.Validation("Pet.InvalidAge", $"The age '{age}' is not valid.");

        public static Error PetCreateFailed()
            => Error.Validation("Pet.CreateFailed", "Failed to create pet.");

        public static Error PetUpdateFailed()
            => Error.Validation("Pet.UpdateFailed", "Failed to update pet.");

        public static Error PetDeleteFailed()
           => Error.Validation("Pet.DeleteFailed", "Failed to delete pet.");

        public static Error PetNotFound()
            => Error.NotFound("Pet.NotFound", "The specified pet was not found.");
    }
}
