using Core.Common;
using System;

namespace ACM.BL.Customers
{
    public class Customer
    {
        #region "Properties"

        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region "Functionality"

        public decimal CalculateStepGoalReach(string stepsGoal, string actualSteps)
        {
            #region "Break Fast Validations"
            if (string.IsNullOrWhiteSpace(stepsGoal) || string.IsNullOrEmpty(stepsGoal)) throw new ArgumentException("Goal must be entered", "Goal Steps");
            if (string.IsNullOrWhiteSpace(actualSteps) || string.IsNullOrEmpty(actualSteps)) throw new ArgumentException("The number of steps you made during the day must be entered", "Number Steps Goal");

            if (!decimal.TryParse(stepsGoal, out decimal goalStepCount)) throw new ArgumentException("Goal must be a numeric number", "Goal Steps");
            if (!decimal.TryParse(actualSteps, out decimal actualStepsCount)) throw new ArgumentException("The number of steps you made during the day must be a numeric number", "Number Steps Goal");
            #endregion

            return CalculateStepGoalReach(goalStepCount, actualStepsCount);

        }

        public decimal CalculateStepGoalReach(decimal stepsGoal, decimal actualSteps)
        {
            decimal result = 0;

            #region "Break Fast Validations"
            if (stepsGoal <= 0) throw new ArgumentException("Goal must be a numeric value greater than zero", "Goal Steps");
            if (actualSteps < 0) throw new ArgumentException("The number of steps you made during the day must be a numeric value greater or equal to zero", "Number Steps Goal");
            #endregion

            if (stepsGoal > 0 && actualSteps >= 0)
            {
                result = (actualSteps / stepsGoal) * 100;
            }

            return result;
        }

        //example using tuples, not recommended but it is good to have an example of how to use it
        public Tuple<bool, string> ValidateEmail()
        {
            Tuple<bool, string> result = Tuple.Create(true, "");

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
                result = Tuple.Create(false, "Email address is null");

            if (result.Item1 == true)
            {
                var isValidFormat = true;

                if (!isValidFormat)
                {
                    result = Tuple.Create(false, "Email address is not in a correct format");
                }
            }

            if (result.Item1 == true)
            {
                var isRealDomain = true;

                if (!isRealDomain)
                {
                    result = Tuple.Create(false, "Email address does not include a valid domain");
                }
            }

            return result;

        }

        public OperationResult ValidateEmailObject()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                var isValidFormat = true;

                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email address is not in a correct format");
                }
            }

            if (op.Success)
            {
                var isRealDomain = true;

                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email address does not include a valid domain");
                }
            }

            return op;

        }

        #endregion

    }
}
