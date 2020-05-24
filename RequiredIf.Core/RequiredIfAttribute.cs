using System;
using System.ComponentModel.DataAnnotations;

namespace RequiredIf.Core
{
    public class RequiredIfAttribute : RequiredAttribute
    {
        private String PropertyName { get; set; }
        private Object DesiredValue { get; set; }
        private Func<object, object, bool> Function { get; set; }

        public RequiredIfAttribute(String propertyName, Object desiredvalue, EOperator function = EOperator.EqualTo)
        {
            PropertyName = propertyName;
            DesiredValue = desiredvalue;
            Function = Operators.GetByEnum(function);
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {

            Object instance = context.ObjectInstance;
            Type type = instance.GetType();
            Object proprtyvalue = type.GetProperty(PropertyName).GetValue(instance, null);
            if (Function(proprtyvalue.ToString(), DesiredValue.ToString()))
            {
                ValidationResult result = base.IsValid(value, context);
                return result;
            }
            return ValidationResult.Success;
        }
    }
}
