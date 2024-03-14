using Pattern_2.Decorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2.Decorator
{
    public class ClientCode
    {
        public void NotificationService(List<IComponent> components, string message)
        {
            foreach (var component in components)
            {
                Console.WriteLine(component.Send(message));
            }
            Console.WriteLine();
        }
        public void Main()
        {
            IComponent mobileNotify = new MobileNotify("Iphone 14 pro");
            IComponent webNotify = new WebNotify("Shafa");
            IComponent serverNotify = new ServerNotify("AWS Linux 45.4");

            var forMobileNotification = new List<IComponent>();
            var forWebNotification = new List<IComponent>();
            var forServerNotification = new List<IComponent>();

            NotificationService(forMobileNotification, "Recall me! - Sasha.");
            NotificationService(forWebNotification, "Hello! I`m Ronnie Callman. Can I call you?");
            NotificationService(forServerNotification, "Task #1234 from Julia moved to Done.");
        }
    }
}
