using System;

namespace QuickMark
{
    public class QuickMarks
    {
        
        public static QuickMarks LastTransaction = null;
        public static bool HasLastTransaction = false;

        
        private string invoiceNo = string.Empty;
        private string customerName = string.Empty;
        private string itemName = string.Empty;
        private int quantity;
        private decimal purchaseAmount;
        private decimal sellingAmount;

        private string profitOrLossStatus = string.Empty;
        private decimal profitOrLossAmount;
        private decimal profitMarginPercent;

        #region Properties

        public string InvoiceNo
        {
            get {
                 return invoiceNo;
                }
            set
            {
                if (value != null)
                    invoiceNo = value;
                else
                    Console.WriteLine("Invoice No cannot be null");
            }
        }

        public string CustomerName
        {
            get {
                 return customerName;
                }
            set
            {
                if (value != null)
                    customerName = value;
                else
                    Console.WriteLine("Customer Name cannot be null");
            }
        }

        public string ItemName
        {
            get {
                 return itemName;
                }
            set
            {
                if (value != null)
                    itemName = value;
                else
                    Console.WriteLine("Item Name cannot be null");
            }
        }

        public int Quantity
        {
            get {
                 return quantity; 
                }
            set
            {
                if (value > 0)
                    quantity = value;
                else
                    Console.WriteLine("Quantity must be greater than zero");
            }
        }

        public decimal PurchaseAmount
        {
            get {
                 return purchaseAmount; 
                }
            set
            {
                if (value > 0)
                    purchaseAmount = value;
                else
                    Console.WriteLine("Purchase Amount must be greater than zero");
            }
        }

        public decimal SellingAmount
        {
            get {
                 return sellingAmount;
                }
            set
            {
                if (value >= 0)
                    sellingAmount = value;
                else
                    Console.WriteLine("Selling Amount cannot be negative");
            }
        }

        #endregion

        
        public void CreateTransaction()
        {
            QuickMarks tax = new QuickMarks();

            Console.WriteLine("Enter Invoice No:");
            tax.InvoiceNo = Console.ReadLine();

            Console.WriteLine("Enter Customer Name:");
            tax.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Item Name:");
            tax.ItemName = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            tax.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Purchase Amount (total):");
            tax.PurchaseAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Selling Amount (total):");
            tax.SellingAmount = decimal.Parse(Console.ReadLine());

            
            if (tax.sellingAmount > tax.purchaseAmount)
            {
                tax.profitOrLossStatus = "PROFIT";
                tax.profitOrLossAmount = tax.sellingAmount - tax.purchaseAmount;
            }
            else if (tax.sellingAmount < tax.purchaseAmount)
            {
                tax.profitOrLossStatus = "LOSS";
                tax.profitOrLossAmount = tax.purchaseAmount - tax.sellingAmount;
            }
            else
            {
                tax.profitOrLossStatus = "BREAK-EVEN";
                tax.profitOrLossAmount = 0;
            }

            tax.profitMarginPercent =(tax.profitOrLossAmount / tax.purchaseAmount) * 100;
                

            LastTransaction = tax;
            HasLastTransaction = true;

            Console.WriteLine("\nTransaction saved successfully.");
            Console.WriteLine("Status: " + tax.profitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + tax.profitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + tax.profitMarginPercent.ToString("F2"));
            Console.WriteLine("------------------------------------------------------");
        }

        // ---------- View Transaction ----------
        public void ViewTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("\n-------------- Last Transaction --------------");
            Console.WriteLine("InvoiceNo: " + LastTransaction.invoiceNo);
            Console.WriteLine("Customer: " + LastTransaction.customerName);
            Console.WriteLine("Item: " + LastTransaction.itemName);
            Console.WriteLine("Quantity: " + LastTransaction.quantity);
            Console.WriteLine("Purchase Amount: " + LastTransaction.purchaseAmount);
            Console.WriteLine("Selling Amount: " + LastTransaction.sellingAmount);
            Console.WriteLine("Status: " + LastTransaction.profitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + LastTransaction.profitOrLossAmount);
            Console.WriteLine("Profit Margin (%): " + LastTransaction.profitMarginPercent);

        }

        
        public void CalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            QuickMarks tax = LastTransaction;

            if (tax.sellingAmount > tax.purchaseAmount)
            {
                tax.profitOrLossStatus = "PROFIT";
                tax.profitOrLossAmount = tax.sellingAmount - tax.purchaseAmount;
            }
            else if (tax.sellingAmount < tax.purchaseAmount)
            {
                tax.profitOrLossStatus = "LOSS";
                tax.profitOrLossAmount = tax.purchaseAmount - tax.sellingAmount;
            }
            else
            {
                tax.profitOrLossStatus = "BREAK-EVEN";
                tax.profitOrLossAmount = 0;
            }

            tax.profitMarginPercent =(tax.profitOrLossAmount / tax.purchaseAmount) * 100;
                

            Console.WriteLine("\nRecalculated Profit/Loss");
            Console.WriteLine("Status: " + tax.profitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + tax.profitOrLossAmount.ToString("F2"));
            Console.WriteLine("Profit Margin (%): " + tax.profitMarginPercent.ToString("F2"));
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
