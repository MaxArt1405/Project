using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using MobileStore.Domain.Entities;
using MobileStore.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using Moq;
using MobileStore.Domain.Concrete;
using System.Configuration;
using MobileStore.WebUI.Infrastructure.Abstract;
using MobileStore.WebUI.Infrastructure.Concrete;

namespace MobileStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext
            requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IProductRepository>().To<FakeProductRepository>();

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager
                    .AppSettings["Email.WriteAsFile"] ?? "false")
            };

            ninjectKernel.Bind<IOrderProcessor>()
                .To<EmailOrderProcessor>().WithConstructorArgument("settings", emailSettings);

            ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}
