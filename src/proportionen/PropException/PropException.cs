using System;
using Proportionen.Constants;


namespace Proportionen.PropException
{
    public class PropException : Exception
    {

        public ErrorCodes Error;

        private PropException()
        {
        }

        public PropException(ErrorCodes code)
        {
            this.Error = code;
        }


    }
}
