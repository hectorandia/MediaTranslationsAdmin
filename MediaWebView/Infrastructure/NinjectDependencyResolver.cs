﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using MediaAdmin.Abstract;
using MediaAdmin.MediaEntity;
using MediaAdmin.Concrete;
using Moq;

namespace MediaWebView.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IEFCustomerRepository>().To<EFECustomerRepository>();
            kernel.Bind<IEFJobRepository>().To<EFJobRepository>();
            kernel.Bind<IEFTranslatorRepository>().To<EFTranslatorRepository>();
        }
    }
}