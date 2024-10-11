using Ninject;
using Hepta.PraticalEvaluation.Application.DI.Modules;
using System;

namespace Hepta.PraticalEvaluation.Application.DI.Configuration
{
    public class Ioc: IDisposable
    {
        private IKernel _kernel;
        public Ioc()
        {
            _kernel = new StandardKernel(new RepositoryModule(), new ServiceModule());
        }
        public IKernel Kernel
        {
            get
            {
                return _kernel;
            }
        }
        public void Dispose()
        {
            if (_kernel != null)
            {
                _kernel.Dispose();
            }
        }
    }
}
