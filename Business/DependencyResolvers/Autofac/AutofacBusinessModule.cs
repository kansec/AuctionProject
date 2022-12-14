using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuctionManager>().As<IAuctionService>();
            builder.RegisterType<EfAuctionDal>().As<IAuctionDal>();

            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<BidManager>().As<IBidService>();
            builder.RegisterType<EfBidDal>().As<IBidDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }


    }
}
