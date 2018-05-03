using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using StructureMap;
using flydubai.Common.Contracts.Business;

namespace flydubai.Model.Attributes.Bases
{
    /// <summary>
    /// Regular Expression Attribute Base
    /// </summary>
    public class RegularExpressionAttributeBase : RegularExpressionAttribute, IClientValidatable
    {
        public RegularExpressionAttributeBase(string pattern)
            : base(pattern)
        {
        }

        /// <summary>
        /// When implemented in a class, returns client validation rules for that class.
        /// </summary>
        /// <param name="metadata">The model metadata.</param>
        /// <param name="context">The controller context.</param>
        /// <returns>
        /// The client validation rules for this validator.
        /// </returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            EnsureErrorMessage();

            yield return new ModelClientValidationRegexRule(this.ErrorMessage, this.Pattern);
        }

        /// <summary>
        /// Checks whether the value entered by the user matches the regular expression pattern.
        /// </summary>
        /// <param name="value">The data field value to validate.</param>
        /// <returns>
        /// true if validation is successful; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.DataAnnotations.ValidationException">The data field value did not match the regular expression pattern.</exception>
        public override bool IsValid(object value)
        {
            EnsureErrorMessage();

            if (!(String.IsNullOrWhiteSpace(this.ErrorMessageResourceName)))
            {
                this.ErrorMessageResourceType = null;
                this.ErrorMessageResourceName = null;
            }

            return base.IsValid(value);
        }

        /// <summary>
        /// Ensures the error message.
        /// </summary>
        private void EnsureErrorMessage()
        {
            var exceptionResourceManager = ObjectFactory.Container.GetInstance<IExceptionResourceManager>();

            if (!(String.IsNullOrWhiteSpace(this.ErrorMessageResourceName)))
                this.ErrorMessage = exceptionResourceManager.GetString(this.ErrorMessageResourceName);
        }
    }

}