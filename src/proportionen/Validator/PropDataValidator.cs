using System;
using Proportionen.Constants;
using Proportionen.Model;

namespace Proportionen.Validator
{
    public class PropDataValidator
    {
        public PropDataValidator()
        {
        }

        public ErrorCodes ValidateData(PropData data)
        {
            if (data == null) return ErrorCodes.NO_DATA_GIVEN;

            if (data.IsDirectProp)
            { 
                if (data.TopLeft.Equals(0)) return ErrorCodes.CALC_INF_RESULT;
            }
            else
            {
                if (data.BottomLeft.Equals(0)) return ErrorCodes.CALC_INF_RESULT;
            }


            return ErrorCodes.OK;
        }
    }
}
