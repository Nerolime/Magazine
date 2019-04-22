using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public class PublisingHouse : Entity
    {
        Customer customer = new Customer();
        public string Name = "Nomad.com";
        public string Password = "Superadmin";
        public int CountOfMagazines { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public IReporter Reporter { get; private set; }

        public PublisingHouse()
        {

        }
        public PublisingHouse(IReporter reporter)
        {
            Reporter = reporter;
        }

        public void Print()
        {
            if (Reporter != null)
                Reporter.SendMessage($"Журнал отправлен на печать");
        }

        public void Send()
        {
            if (Reporter != null)
                Reporter.SendMessage($"Журнал отправлен клиенту");
        }

        public void Confirm()
        {
            if (Reporter != null)
                Reporter.SendMessage($"Клиент получил журнал");
        }

    }
}
