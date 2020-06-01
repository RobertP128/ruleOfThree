using System;
using Proportionen.Model;
using Proportionen.Validator;
using Proportionen.PropException;
using Proportionen.Constants;

namespace Proportionen.Controller
{
    public class PropCalculator
    {
        public PropCalculator()
        {
        }




        public void CalculateResult(PropData data,PropDataValidator validator) 
        {
            if (data == null) throw new PropException.PropException(ErrorCodes.NO_DATA_GIVEN);
            if (validator == null) throw new PropException.PropException(ErrorCodes.NO_VALIDATOR_GIVEN);

            ErrorCodes valid = validator.ValidateData(data);

            if (!valid.Equals(ErrorCodes.OK)) throw new PropException.PropException(valid);

            // Calculate now the result

            if (data.IsDirectProp)
            {
                data.BottomRight = data.TopRight / data.TopLeft * data.BottomLeft;
            }
            else
            {
                data.BottomRight = data.TopRight / data.BottomLeft * data.TopLeft;
            }

        }
    }
}
