using System;
using Xunit;
using Proportionen.Validator;
using Proportionen.Model;
using Proportionen.Constants;

namespace ProportionenTest.Validator
{
    public class PropDataValidatorTest
    {
        /*
         * @Brief Test when passing null       
        */
        [Fact]
        public void ValidateDataNullData()
        {


            PropDataValidator v = new PropDataValidator();
            ErrorCodes err = v.ValidateData(null);

            Assert.Equal(ErrorCodes.NO_DATA_GIVEN, err);

        }


        /*
         * @Brief Test different values
        */       
        [Theory]
        [InlineData(false,1, 1, ErrorCodes.OK)]
        [InlineData(false,1, 0, ErrorCodes.CALC_INF_RESULT)]
        [InlineData(true,0, 1, ErrorCodes.CALC_INF_RESULT)]
        public void ValidateData(bool isDirectProp, double topleft, double botleft,ErrorCodes expectedResult)
        {
            PropData data = new PropData();
            data.TopLeft = topleft;
            data.BottomLeft = botleft;
            data.IsDirectProp = isDirectProp;

            PropDataValidator v = new PropDataValidator();
            ErrorCodes err = v.ValidateData(data);

            Assert.Equal(expectedResult, err);

        }
    }
}
