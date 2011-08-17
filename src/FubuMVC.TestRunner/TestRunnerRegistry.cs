using FubuMVC.Conventions;
using FubuMVC.Core;
using FubuMVC.Spark;

namespace FubuMVC.TestRunner
{
    public class TestRunnerRegistry : FubuPackageRegistry
    {
        public TestRunnerRegistry()
            : base("testing")
        {
            this.ApplyHandlerConventions<TestRunnerRegistry>();
            this.UseSpark();
            Views.TryToAttachWithDefaultConventions();
        }
    }
}