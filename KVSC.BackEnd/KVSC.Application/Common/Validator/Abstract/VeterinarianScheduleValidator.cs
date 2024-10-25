using FluentValidation;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using System;
using System.Linq.Expressions;

namespace KVSC.Application.Common.Validator.Abstract
{
    public abstract class VeterinarianScheduleValidator<T> : AbstractValidator<T>
    {
        protected void AddDateRules(Expression<Func<T, DateTime>> dateExpression)
        {
            RuleFor(dateExpression)
                .NotEmpty().WithState(_ => ScheduleErrorMessage.FieldIsEmpty("Date"));
        }

        protected void AddTimeRangeRules(Expression<Func<T, TimeSpan>> startTimeExpression, Expression<Func<T, TimeSpan>> endTimeExpression)
        {
            RuleFor(startTimeExpression)
                .NotEmpty().WithState(_ => ScheduleErrorMessage.FieldIsEmpty("Start Time"))
                .LessThan(endTimeExpression).WithState(_ => ScheduleErrorMessage.InvalidTimeRange());

            RuleFor(endTimeExpression)
                .NotEmpty().WithState(_ => ScheduleErrorMessage.FieldIsEmpty("End Time"));
        }

        protected void AddDescriptionRules(Expression<Func<T, string>> descriptionExpression, bool isRequired = false)
        {
            var rule = RuleFor(descriptionExpression)
                .MaximumLength(200).WithState(_ => ScheduleErrorMessage.DescriptionInvalidLength())
                .When(request => !string.IsNullOrEmpty(descriptionExpression.Compile()(request)));

            if (isRequired)
            {
                rule.NotEmpty().WithState(_ => ScheduleErrorMessage.FieldIsEmpty("Description"));
            }
        }
    }
}
