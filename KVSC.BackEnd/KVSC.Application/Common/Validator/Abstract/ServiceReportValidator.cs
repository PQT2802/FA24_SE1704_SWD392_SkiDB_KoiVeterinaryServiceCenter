using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using System.Linq.Expressions;


namespace KVSC.Application.Common.Validator.Abstract
{
    public abstract class ServiceReportValidator<T>:AbstractValidator<T>
    {
        private readonly UnitOfWork _unitOfWork;

        public ServiceReportValidator(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected void AddReportContentRules(Expression<Func<T, string>> reportContentExpression, bool isRequired = true)
        {
            var rule = RuleFor(reportContentExpression)
                .MaximumLength(1000).WithState(_ => ServiceReportErrorMessage.ReportContentInvalidLength())
                .When(request => !string.IsNullOrEmpty(reportContentExpression.Compile()(request))); // Only validate if not null

            if (isRequired)
            {
                rule.NotEmpty().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("Report content"));
            }
        }

        protected void AddReportDateRules(Expression<Func<T, DateTime>> reportDateExpression)
        {
            RuleFor(reportDateExpression)
                .NotEmpty().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("Report date"))
                .Must(date => date <= DateTime.UtcNow).WithState(_ => ServiceReportErrorMessage.InvalidReportDate());
        }

        protected void AddRecommendationsRules(Expression<Func<T, string>> recommendationsExpression, bool isRequired = false)
        {
            var rule = RuleFor(recommendationsExpression)
                .MaximumLength(500).WithState(_ => ServiceReportErrorMessage.RecommendationsInvalidLength())
                .When(request => !string.IsNullOrEmpty(recommendationsExpression.Compile()(request))); // Only validate if not null

            if (isRequired)
            {
                rule.NotEmpty().WithState(_ => ServiceReportErrorMessage.FieldIsEmpty("Recommendations"));
            }
        }
    }
}
    