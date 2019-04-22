using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public class Customer : Entity
    {
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }        
        public int Purse { get; set; }
        public bool Subscription = false;
        public bool Confirmation = false;
        public DateTime DateOfEnd;

        public IReporter Reporter { get; private set; }
        public Customer()
        {

        }
        public Customer(IReporter reporter )
        {
            Reporter = reporter;
        }
        

        public void AddSub(int subtype, int price)
        {
            if (subtype == 1)
            {
                if (Purse >= price)
                {
                    Purse = Purse - price;
                    DateOfEnd = DateTime.Now.AddYears(subtype);
                    Subscription = true;
                    if (Reporter != null)
                        Reporter.SendMessage($"Оформлена подписка на {subtype} год");
                }
                else
                {
                    if (Reporter != null)
                        Reporter.SendMessage($"Недостаточно средств");
                }
            }
            else if (subtype == 2)
            {
                if (Purse >= price)
                {
                    Purse = Purse - price;
                    DateOfEnd = DateTime.Now.AddYears(subtype);
                    Subscription = true;
                    if (Reporter != null)
                        Reporter.SendMessage($"Оформлена подписка на {subtype} годa");
                }
                else
                {
                    if (Reporter != null)
                        Reporter.SendMessage($"Недостаточно средств");
                }
            }
            else if (subtype == 3)
            {
                if (Purse >= price)
                {
                    Purse = Purse - price;
                DateOfEnd = DateTime.Now.AddYears(subtype);
                    Subscription = true;
                    if (Reporter != null)
                    Reporter.SendMessage($"Оформлена подписка на {subtype} годa");
                }
                else
                {
                    if (Reporter != null)
                    Reporter.SendMessage($"Недостаточно средств");
                }
            }

        }
    }
}
