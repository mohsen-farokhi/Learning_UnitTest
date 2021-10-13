using System;
using System.Collections.Generic;

namespace TestDoubleSample.Test.Testdoubles
{
    public class HandMockEmployeeRepository : IEmployeeRepository
    {
        Dictionary<string, MethodCall> _methodCalls =
            new Dictionary<string, MethodCall>();

        public void Create(Employee employee)
        {
            if (_methodCalls.ContainsKey(nameof(Create)))
            {
                _methodCalls[nameof(Create)].IncreaseCalledTimes();
            }
            else
            {
                _methodCalls.Add(nameof(Create), new MethodCall(employee,1));
            }
        }

        public MethodCall GetCalled(string methodName)
        {
            return _methodCalls[methodName];
        }
    }
}
