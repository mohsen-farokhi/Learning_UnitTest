namespace TestDoubleSample.Test.Testdoubles
{
    public class MethodCall
    {
        public object PassedArgument { get; set; }

        public int CalledTimes { get; set; }

        public MethodCall(object argument, int calledTimes)
        {
            PassedArgument = argument;
            CalledTimes = calledTimes;
        }

        public void IncreaseCalledTimes()
        {
            CalledTimes++;
        }
    }
}
