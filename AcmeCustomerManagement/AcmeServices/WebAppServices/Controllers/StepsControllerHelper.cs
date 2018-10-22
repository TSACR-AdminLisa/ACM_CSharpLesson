using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppServices.Controllers
{
    public class StepsControllerHelper
    {
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

            if (stepsGoal <= 0) throw new ArgumentException("Goal must be a numeric value greater than zero", "Goal Steps");
            if (actualSteps < 0) throw new ArgumentException("The number of steps you made during the day must be a numeric value greater or equal to zero", "Number Steps Goal");

            if (stepsGoal > 0 && actualSteps >= 0)
            {
                result = (actualSteps / stepsGoal) * 100;
            }

            return result;
        }

    }
}
