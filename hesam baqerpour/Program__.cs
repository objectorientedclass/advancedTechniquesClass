using System;

namespace ConsoleApp2
{
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("student Calss start");
            //---------------------------------
            // make new student   
            //--------------------------------
            Students student1 = new Students(new date("27,4,1364", "5,5,1398"));
            student1._id = 1;
            student1.name = "hesam";
            student1.familly = "Bagherpour";
            //---------------------------------
            // make new student   
            //--------------------------------
            Students student2 = new Students(new date("27,8,1368", "5,5,1398"));
            student1._id = 2;
            student1.name = "Ali";
            student1.familly = "Khanbabayi";

            //---------------------------------
            // show student info 
            //--------------------------------
            student1.showStudentInfo();
            student2.showStudentInfo();
            Console.Read();
        }
    }
    //---------------------------------
    //  student class  
    //--------------------------------
    public class Students
    {
        public long _id;
        public string name;
        public string familly;
        private string date_of_birth;
        private string date_of_graduation_date;

        public Students(date studentDate)
        {
            this.date_of_birth = studentDate.date_of_birth;
            this.date_of_graduation_date = studentDate.date_of_graduation_date;

        }
        public void showStudentInfo()
        {
            Console.WriteLine(this._id);
            Console.WriteLine(this.name);
            Console.WriteLine(this.familly);
            Console.WriteLine(this.date_of_birth);
            Console.WriteLine(this.date_of_graduation_date);

        }
    }
    //---------------------------------
    //  date class  
    //--------------------------------
    public class date
    {

        public string date_of_birth;
        public string date_of_graduation_date;
        public date( string my_date_of_birth , string my_date_of_graduation_date )
        {
            this.date_of_birth = my_date_of_birth;
            this.date_of_graduation_date = my_date_of_graduation_date;
        }


    }
}