// See https://aka.ms/new-console-template for more information
using System.Text;
// Pattern Matching

// bool Or(bool a, bool b) =>
// (a, b) switch
// {
//     (false, false) => false,
//     (_, _) => true
// };

// if(Or(1>5, 2>5)){
//     Console.WriteLine("Here");
// }
// else{
//     Console.WriteLine("There");
// }

// Collections

// int[] a = [1,2,3,4,5,6,7,8];
// int b = a[1];
// int c = a[^1];
// int[] k = a[2..5];
// Console.WriteLine(b);
// Console.WriteLine(c);


//Structure of a C# program.
namespace dotnetTraining
{
    class Zcl_c4u_dbf_baseline_forecast{
        private int quotation_id;
        public int get_quotation_id(){
            return this.quotation_id;
        }
        public void setId(int id){
            this.quotation_id = id;
        }
        
    };

    class Run{
        public static void Main(string[] args){
            Console.WriteLine("Hello World");
            var baseline_object = new Zcl_c4u_dbf_baseline_forecast();
            baseline_object.setId(103000193);
            int baseline_id = baseline_object.get_quotation_id();
            Console.WriteLine(baseline_id);
        }
    }
    
}


