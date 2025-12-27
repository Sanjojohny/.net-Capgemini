using System;

namespace MediCare
{
    public class PatientBill
    {
        
        public static PatientBill LastBill = null;
        public static bool HasLastBill = false;

        #region feilds 
        //---fields--//
            
        
        private string billId = string.Empty;
        private string patientName = string.Empty;
        private bool hasInsurance;
        private decimal consultationFee;
        private decimal labCharges;
        private decimal medicineCharges;
        private decimal grossAmount;
        private decimal discountAmount;
        private decimal finalPayable;

        #endregion

        #region Properties 

        public string BillId
        {
            get 
            {
                 return billId; 
            }
            set
            {
                if (value != null)
                    billId = value;
                else
                    Console.WriteLine("Bill Id cannot be null");
            }
        }

        public string PatientName
        {
            get 
            {
                 return patientName; 
            }
            set
            {
                if (value != null)
                    patientName = value;
                else
                    Console.WriteLine("Patient name cannot be null");
            }
        }

        public bool HasInsurance
        {
            get 
            {
                 return hasInsurance; 
            }
            set
            {
                 hasInsurance = value;
            }
        }

        public decimal ConsultationFee
        {
            get 
            {
                 return consultationFee; 
            }
            set
            {
                if (value > 0){

                    consultationFee = value;
                }
                else{
                    Console.WriteLine("Invalid Consultation Fee");
                }
            }
        }

        public decimal LabCharges
        {
            get 
            {
                 return labCharges; 
            }
            set
            {
                if (value >= 0){

                    labCharges = value;
                }
                else{
                    Console.WriteLine("Invalid Lab Charges");
                }
            }
        }

        public decimal MedicineCharges
        {
            get 
            {
                 return medicineCharges; 
            }
            set
            {
                if (value >= 0)
                {

                    medicineCharges = value;
                }
                else{
                    Console.WriteLine("Invalid Medicine Charges");
                    }
            }
        }

        #endregion

        
        public void Menu()
        {
            Console.WriteLine("1. Create New Bill");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
        }

        
        public void Create()
        {
            PatientBill bill = new PatientBill();

            Console.WriteLine("Enter Bill Id:");
            bill.BillId = Console.ReadLine();

            Console.WriteLine("Enter Patient Name:");
            bill.PatientName = Console.ReadLine();

            Console.WriteLine("Has Insurance? (Y/N):");
            string a = Console.ReadLine();

            if (a == "Y")
            {
                bill.HasInsurance = true;
            }
            else if (a == "N" ){

                bill.HasInsurance = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter Consultation Fee:");
            bill.ConsultationFee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Lab Charges:");
            bill.LabCharges = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Medicine Charges:");
            bill.MedicineCharges = decimal.Parse(Console.ReadLine());

            
            bill.grossAmount = bill.consultationFee + bill.medicineCharges;
              

            if (bill.hasInsurance){
                bill.discountAmount = bill.grossAmount * 0.10m;
            }
            else
                bill.discountAmount = 0;

            bill.finalPayable =bill.grossAmount - bill.discountAmount;
                

            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine("\nBill Created Successfully");
            Console.WriteLine("Gross Amount    : " + bill.grossAmount);
            Console.WriteLine("Discount Amount : " + bill.discountAmount);
            Console.WriteLine("Final Payable   : " + bill.finalPayable);
        }

        
        public void View()
        {
            if (!HasLastBill)
            {
                Console.WriteLine("No bill available.");
                return;
            }

            Console.WriteLine("------------------LastBill---------");
            Console.WriteLine("Bill Id          : " + LastBill.billId);
            Console.WriteLine("Patient Name     : " + LastBill.patientName);
            Console.WriteLine("Insured          : " + (LastBill.hasInsurance ? "Yes" : "No"));
            Console.WriteLine("Consultation Fee : " + LastBill.consultationFee);
            Console.WriteLine("Lab Charges      : " + LastBill.labCharges);
            Console.WriteLine("Medicine Charges : " + LastBill.medicineCharges);
            Console.WriteLine("Gross Amount     : " + LastBill.grossAmount);
            Console.WriteLine("Discount Amount  : " + LastBill.discountAmount);
            Console.WriteLine("Final Payable    : " + LastBill.finalPayable);
            Console.WriteLine("------------------------------");
        }

        
        public void Clear()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
        }
    }
}
