using System;

namespace Total
{
    
    class myComplex{
        public float realPart ;
        public float imaginaryPart ;

        public myComplex(){

        }

        public myComplex(float number){

        }

        public float addition(float number1, float number2){
            float result = number1 + number2 ;
            this.imaginaryPart = result ; // chon adade mokhtaleto nemidunam in karo kardam
            return result ;
        }

        public float subtraction(float number1, float number2){
            float result = number1 - number2 ;
            this.realPart = result ; // chon adade mokhtaleto nemidunam in karo kardam
            return result ;
        }

        public void printNums(){
            Console.WriteLine("imaginary number is : " + this.imaginaryPart );
            Console.WriteLine("real number is : " + this.realPart);
        }

    }

    class complexTest 
    {
        static void Main(string[] args)
        {
            float c1, c2 ;

            //creating instance of Complex class
            myComplex complex = new myComplex();
            Console.WriteLine("addition of c1 and c2 is : "+complex.addition(c1 = 2.4F, c2 = 3.1F));
            Console.WriteLine("subtraction of c1 and c2 is : "+complex.subtraction(c1 = 2.4F, c2 = 3.1F));

            //print real and imaginary numbers
            complex.printNums();

            Console.ReadKey();
        }
    }
}