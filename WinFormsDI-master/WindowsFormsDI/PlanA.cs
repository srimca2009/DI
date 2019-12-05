using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDI
{
    public interface IPlan
    {
        string GetPlanDetails();
    }

    public class PlanA : IPlan
    {
        public string GetPlanDetails()
        {
            return "Test Plan A";
        }
    }


    public class PlanB : IPlan
    {
        public string GetPlanDetails()
        {
            return "Test Plan B";
        }
    }


    public interface ITest
    {
        string GetName();
    }

    public class Test : ITest
    {
        public string GetName()
        {
            return "Test Name";
        }
    }
}
