using FubuMVC.Core;
using FubuMVC.Spark;

namespace FubuMVC.TestRunner
{
    public class TestRunnerRegistry : FubuPackageRegistry
    {
        public TestRunnerRegistry()
            : base("testing")
        {
            ApplyHandlerConventions<TestRunnerRegistry>();
            this.UseSpark();
            Views.TryToAttachWithDefaultConventions();
        }
    }
}