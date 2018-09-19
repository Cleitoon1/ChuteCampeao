using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChuteCampeao.MVC.Helpers.Anotacoes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ValidateDateRangeFormat : ValidationAttribute, IClientValidatable
    {
        private const string DefaultErrorMessage = "Invalid date, your {0} should fall between {1} and {2}";
        public string Format { get; set; }
        public DateTime MinimumDate { get; private set; }
        public DateTime MaximumDate { get; private set; }

        public ValidateDateRangeFormat(string minimum, string maximum, string format) : base(DefaultErrorMessage)
        {
            this.MinimumDate = this.ParseDate(minimum, format);
            this.MaximumDate = this.ParseDate(maximum, format);
            this.Format = format;
        }

        private DateTime ParseDate(string date, string format)
        {
            DateTime d;
            if (date.ToUpper().Equals("NOW"))
                d = DateTime.Now;
            else
            {
                if (DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out d) == false)
                    throw new Exception("Invalid Date");
            }
            return d;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime date;
            if (DateTime.TryParseExact((string)value, this.Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date) == false)
                new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            return (date >= this.MinimumDate && date <= this.MaximumDate) ? ValidationResult.Success : new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule()
            {
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
                ValidationType = "daterangeformat"
            };
            rule.ValidationParameters.Add("minimumdate", MinimumDate.ToShortDateString());
            rule.ValidationParameters.Add("maximumdate", MaximumDate.ToShortDateString());
            rule.ValidationParameters.Add("format", this.Format);
            yield return rule;
        }
    }
}