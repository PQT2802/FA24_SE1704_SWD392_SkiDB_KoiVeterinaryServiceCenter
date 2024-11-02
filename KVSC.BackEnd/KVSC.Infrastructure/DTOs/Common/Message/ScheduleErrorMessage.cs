using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using System;

namespace KVSC.Infrastructure.DTOs.Common.Message
{
    public static class ScheduleErrorMessage
    {
        public static Error FieldIsEmpty(string nameField)
            => Error.Validation("Schedule.Empty", $"The '{nameField}' is required.");

        public static Error ScheduleNotExist()
            => Error.NotFound("Schedule.NotExist", $"Schedule does not exist.");

        public static Error ScheduleNotCreated()
            => Error.Conflict("Schedule.Create", $"Schedule is not created.");

        public static Error InvalidTimeRange()
            => Error.Validation("Schedule.TimeRange.Invalid", $"Start time must be earlier than end time.");

        public static Error DescriptionInvalidLength()
            => Error.Validation("Schedule.Description.Length", $"Description must not exceed 200 characters.");

        public static Error ScheduleConflict()
            => Error.Conflict("Schedule.Conflict", $"This schedule conflicts with an existing one.");

        public static Error ScheduleNotFound()
            => Error.NotFound("Schedule.NotFound", $"The schedule with the given ID was not found.");

        public static Error ScheduleUpdateFailed()
            => Error.Conflict("Schedule.Update.Failed", $"Failed to update the schedule.");

        public static Error ScheduleDeletionFailed()
            => Error.Conflict("Schedule.Delete.Failed", $"Failed to delete the schedule.");
        public static Error MaxRegistrationsExceeded()
        => Error.Validation("Shift.MaxRegistrationsExceeded", "This shift already has the maximum number of registered veterinarians.");
        public static Error VeterinarianAlreadyScheduled()
    => Error.Validation("Schedule.VeterinarianAlreadyScheduled", "This veterinarian is already scheduled for the selected shift.");
    }
}
