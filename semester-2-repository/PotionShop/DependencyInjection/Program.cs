using Autofac;
using PotionShop.Logic.DalInterfaces;
using System;

namespace PotionShop.Presentation
{
    class Program
    {
        static public IApplication App { get; set; }
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                App = scope.Resolve<IApplication>();
                App.Run();
            }


            
            Console.WriteLine("Potion name: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Potion cost: ");
            int costInput = Convert.ToInt32(Console.ReadLine());
            App.AddPotion(nameInput, costInput);


            //Potion potion = new Potion(new PotionDAL(), nameInput, costInput);
            //potion.AddPotion(potion);
        }
    }
}
