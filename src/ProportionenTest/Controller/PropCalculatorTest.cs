using System;
using Xunit;
using Proportionen.Controller;
using Proportionen.Constants;
using Proportionen.Validator;
using Proportionen.Model;
using Proportionen.PropException;

namespace ProportionenTest.Controller
{
    public class PropCalculatorTest
    {

        [Fact]
        public void CalculateResultNullValidatorTest()
        {
            PropCalculator c = new PropCalculator();
            PropData data = new PropData();

            try
            {
                c.CalculateResult(data, null);
            }
            catch(PropException e)
            {
                Assert.Equal(ErrorCodes.NO_VALIDATOR_GIVEN, e.Error);
                return;
            }
            catch(Exception)
            {
                Assert.True(false, "Wrong Exception was thrown!!");
                return;
            }


            Assert.True(false, "No Exception was thrown!!");
        }

        [Fact]
        public void CalculateResultNullDataTest()
        {
            PropCalculator c = new PropCalculator();
            PropDataValidator vali = new PropDataValidator();

            try
            {
                c.CalculateResult(null, vali);
            }
            catch (PropException e)
            {
                Assert.Equal(ErrorCodes.NO_DATA_GIVEN, e.Error);
                return;
            }
            catch (Exception)
            {
                Assert.True(false, "Wrong Exception was thrown!!");
                return;
            }

            Assert.True(false, "No Exception was thrown!!");


        }


        [Theory]
        [InlineData(1,2,3,true,6)]
        [InlineData(3, 2, 1, false,6)]
        public void CalculateResultDataTest(double topleft,double topRight,double botLeft,bool isDirectProp,double expectedResult)
        {
            PropCalculator c = new PropCalculator();
            PropDataValidator vali = new PropDataValidator();

            PropData data = new PropData();
            data.TopLeft = topleft;
            data.TopRight = topRight;
            data.BottomLeft = botLeft;
            data.IsDirectProp = isDirectProp;

            try
            {
                c.CalculateResult(data, vali);

                // compare the results
                Assert.Equal(expectedResult, data.BottomRight);


            }
            catch (PropException)
            {
                Assert.True(false, "Exception was thrown but must not!!");
                return;
            }
            catch (Exception e)
            {
                Assert.True(false, "Wrong Exception was thrown!!" + e.Message);
                return;
            }



        }



    }
}
