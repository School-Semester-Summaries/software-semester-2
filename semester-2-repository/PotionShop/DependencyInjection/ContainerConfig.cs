using Autofac;
using PotionShop.DAL;
using PotionShop.Logic;
using PotionShop.Logic.DalInterfaces;

namespace PotionShop.Presentation
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Potion>().As<IPotion>();
            builder.RegisterType<PotionDAL>().As<IPotionDAL>();
            return builder.Build();
        }
    }
}
