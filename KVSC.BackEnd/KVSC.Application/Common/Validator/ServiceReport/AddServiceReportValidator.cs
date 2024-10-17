using FluentValidation;
using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.ServiceReport
{
    public class AddServiceReportValidator : ServiceReportValidator<AddServiceReportRequest>
    {
        public AddServiceReportValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            AddReportContentRules(x => x.ReportContent, isRequired: true); // Report content is required
           // AddReportDateRules(x => x.ReportDate);                         // Report date validation
            AddRecommendationsRules(x => x.Recommendations, isRequired: false); // Recommendations not required

            // Optional additional validation logic
            RuleFor(x => x.AppointmentId)
                .NotEmpty().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("Appointment ID"));

            //RuleFor(x => x.HasPrescription)
            //    .Must(ValidatePrescriptionId).WithState(_ => ServiceReportErrorMessage.PrescriptionIdRequired());
        }
        //private bool ValidatePrescriptionId(AddServiceReportRequest request, bool hasPrescription)
        //{
        //    // Ensure PrescriptionId is provided if HasPrescription is true
        //    if (hasPrescription && request.PrescriptionId == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
