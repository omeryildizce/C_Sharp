using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.messageSenderBase = new EmailSender();
            customerManager.UpdateCustomer();

        }
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved!");
        }
        public abstract void Send(Body body);

    }
    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
    class SmslSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via SmsSender",body.Title);
        }
    }
    class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via EMailSender",body.Title);
        }
    }
    class CustomerManager
    {
        public MessageSenderBase messageSenderBase { get; set; }
        public void UpdateCustomer ()
        {
            messageSenderBase.Send(new Body { Title = "About the coure!" });
            Console.WriteLine("Customer Updated");
        }
    }
}


