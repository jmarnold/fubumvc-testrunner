namespace FubuMVC.TestRunner.Suites
{
    public class get_Suite_handler
    {
        public RunSuiteViewModel Execute(RunSuiteRequest requestModel)
        {
            return new RunSuiteViewModel
                       {
                           Suite = requestModel.Suite
                       };
        }
    }
}