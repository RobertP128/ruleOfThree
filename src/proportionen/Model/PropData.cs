using System;
using Proportionen.Constants;

namespace Proportionen.Model
{
    public class PropData
    {
        public bool IsDirectProp;
        public double TopLeft;
        public double TopRight;
        public double BottomLeft;
        // this is the result what we search for
        public double BottomRight;

        public ErrorCodes ValidationResult;
        public PropData()
        {
        }

    }
}
