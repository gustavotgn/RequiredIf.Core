using System;
using System.Collections.Generic;
using System.Text;

namespace RequiredIf.Core
{
    internal static class Operators
    {
        internal static Func<object, object, bool> GetByEnum(EOperator function)
        {
            switch (function)
            {
                case EOperator.EqualTo:
                    return EqualTo;
                case EOperator.NotEqualTo:
                    return NotEqualTo;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
        internal static Func<object, object, bool> EqualTo { get => (obj, obj2) => obj.Equals(obj2); }
        internal static Func<object, object, bool> NotEqualTo { get => (obj, obj2) => obj.Equals(obj2); }

        //GreaterThan,
        //LessThan,
        //GreaterThanOrEqualTo,
        //LessThanOrEqualTo,
        //RegExMatch,
        //NotRegExMatch,
        //In,
        //NotIn
    }
}
