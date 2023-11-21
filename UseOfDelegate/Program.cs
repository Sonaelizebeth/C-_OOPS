// using System;
// namespace Use{
//     class UseOfDelegate{
//         static void Main(string[] args){
//             var c = new Customer(){
//                 Name="Krishna",
//                 Salary=14000,
//                 LastThreeMonthsTransaction=45000
//             };
//             Customer.IsEligibleForLoan(c);
//         }
        
//     }
//     public class Customer{
//         public string Name;
//         public int Salary;
//         public int LastThreeMonthsTransaction;
//         public static void IsEligibleForLoan(Customer c){
//             if(c.Salary>10000 && c.LastThreeMonthsTransaction>30000){
//                 Console.WriteLine("Loan approved");
//                 return;
//             }
//             Console.WriteLine("Loan not approved");
//         }
//     }
// }


//-----------------------Delegate---------------------------------
using System;
namespace Use{
    public delegate bool CustomerDelegate(Customer customer);
    class UseOfDelegate{
        static void Main(string[] args){
            var c = new Customer(){
                Name="Krishna",
                Salary=14000,
                LastThreeMonthsTransaction=45000
            };
            //Customer.IsEligibleForLoan(c);
            // var cd = new CustomerDelegate(Approve);
            // Customer.IsEligibleForLoan(c,cd);
            //or
            Customer.IsEligibleForLoan(c,customer =>customer.Salary>10000 && customer.LastThreeMonthsTransaction>30000);
        }
        // public static bool Approve(Customer customer){
        //     if(customer.Salary>10000 && customer.LastThreeMonthsTransaction>30000){
        //         return true;
        //     }
        //     return false;
        // }
        
    }
    public class Customer{
        public string Name;
        public int Salary;
        public int LastThreeMonthsTransaction;
        public static void IsEligibleForLoan(Customer c, CustomerDelegate cd){
            if(cd(c)){
                Console.WriteLine("Loan approved");
                return;
            }
            Console.WriteLine("Loan not approved");
        }
    }
}