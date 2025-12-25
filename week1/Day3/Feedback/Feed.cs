using System;

namespace FeedBack
{
    public class Feed
    {
        //  Private backing fields
        private string customerName;
        private string mobileNumber;
        private double feedbackRating;

        //  Properties
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set
            {
                if (value.Length == 10)
                {
                    mobileNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid mobile number");
                }
            }
        }

        public double FeedbackRating
        {
            get { return feedbackRating; }
            set
            {
                if (value > 0 && value <= 5)
                {
                    feedbackRating = value;
                }
                else
                {
                    Console.WriteLine("Invalid feedback rating");
                }
            }
        }

        //  Display method
        public void Display()
        {
            Console.WriteLine($"Customer Name   : {CustomerName}");
            Console.WriteLine($"Mobile Number   : {MobileNumber}");
            Console.WriteLine($"Feedback Rating : {FeedbackRating} / 5");
            Console.WriteLine("-----------------------------");
        }
    }
}
