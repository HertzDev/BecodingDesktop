using BecodingDesktop.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BecodingDesktop.Helpers
{
    class ValidatorManager
    {
        public static bool IsValid(TypeValidation type, object value)
        {
            bool isValid = false;
            switch (type)
            {
                case TypeValidation.DIGIT:
                    {
                        isValid = (int)value > 0;
                       break;
                    }
                case TypeValidation.WORD:
                    {
                        isValid = (!string.IsNullOrEmpty(value.ToString())) && (!string.IsNullOrWhiteSpace(value.ToString()));
                        break;
                    }
            }
            return isValid;
        }
    }
}
