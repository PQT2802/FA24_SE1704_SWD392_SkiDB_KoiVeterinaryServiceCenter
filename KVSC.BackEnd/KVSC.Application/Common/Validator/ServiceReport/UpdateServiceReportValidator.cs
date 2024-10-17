using FluentValidation;
using KVSC.Application.Common.Validator.Abstract;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common.Validator.ServiceReport
{
    public class UpdateServiceReportValidator : ServiceReportValidator<UpdateServiceReportRequest>
    {
        public UpdateServiceReportValidator(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            // Validate that the ServiceReportId is not empty
            RuleFor(request => request.ServiceReportId)
                .NotEmpty().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("ServiceReportId"));

            // Validate ReportContent
            AddReportContentRules(request => request.ReportContent, isRequired: true);

            // Validate ReportDate
            AddReportDateRules(request => request.ReportDate);

            // Validate Recommendations (optional)
            AddRecommendationsRules(request => request.Recommendations, isRequired: false);

            // Validate HasPrescription and PrescriptionId
            When(request => request.HasPrescription, () =>
            {
                RuleFor(request => request.PrescriptionId)
                    .NotNull().WithState(_ => ServiceReportErrorMessage.PrescriptionIdRequired());
            });

            // Ensure IsCompleted is a valid boolean
            RuleFor(request => request.IsCompleted)
                .NotNull().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("IsCompleted"));
        }
    }
}
