using System;


public class PublisherSubscriber
{
    public class Publisher
    {
        public delegate void ReceiveNotification(int notifNumber);

        public event ReceiveNotification receiveNotif;

        public void CreateNews()
        {
            for (int notifNumber = 0; notifNumber < 10; notifNumber++)
            {
                System.Console.WriteLine($"Notification numbet {notifNumber} was sent");
                receiveNotif(notifNumber);
            }
        }
    }

    public class Subscriber1
    {
        public void SubscribeTheAction(int actionNumber)
        {
            System.Console.WriteLine($"Action {actionNumber} has been received in subscriber 1");
        }
    }

    public class Subscriber2
    {
        public void SubscribeTheAction(int actionNumber)
        {
            System.Console.WriteLine($"Action {actionNumber} has been received in subscriber 2");
        }
    }

    public class Subscriber3
    {
        public void SubscribeTheAction(int actionNumber)
        {
            System.Console.WriteLine($"Action {actionNumber} has been received in subscriber 3");
        }
    }

    public void Run()
    {
        var publisher = new Publisher();

        var subscr1 = new Subscriber1();
        var subscr2 = new Subscriber2();
        var subscr3 = new Subscriber3();

        publisher.receiveNotif += subscr1.SubscribeTheAction;
        publisher.receiveNotif += subscr2.SubscribeTheAction;
        publisher.receiveNotif += subscr3.SubscribeTheAction;

        publisher.CreateNews();
    }
}