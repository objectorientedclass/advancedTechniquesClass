using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
     abstract class Employee
     {
          #region Fields
          private string _FirstName;
          private string _LastName;
          private string _BirthDay;
          private ushort _DepartmentCode;
          #endregion
          #region Constructors
          protected Employee(string FirstName , string LastName , string BirthDay , ushort DepartmentCode)
          {
               this._FirstName = FirstName;
               this._LastName = LastName;
               this._BirthDay = BirthDay;
               this._DepartmentCode = DepartmentCode;
          }
          #endregion
          #region Methods
          protected internal abstract decimal Earnings();
          public override string ToString()
          {
               return _FirstName + " " + _LastName + " BDay:" +_BirthDay + " DCode:" +_DepartmentCode;
          }
          #endregion
     }
     class Boss : Employee
     {
          #region Fields
          private decimal _Salary;
          #endregion
          #region Constructors
          protected internal Boss(string FristName , string LastName , string BirthDay , ushort DepartmentCode , decimal Salary) : base(FristName , LastName , BirthDay ,DepartmentCode)
          {
               this._Salary = Salary;
          }
          #endregion
          #region Methods
          protected internal override decimal Earnings()
          {
               return _Salary;
          }
          public override string ToString()
          {
               return "Boss:" + base.ToString();
          }
          #endregion

     }
     class CommissionWorker : Employee
     {
          #region Fields
          private decimal _Salary;
          private decimal _Commission;
          private ushort _Quantity;
          #endregion
          #region Constructors
          protected internal CommissionWorker(string FirstName , string LastName , string BirthDay , ushort DepartmentCode ,decimal Salary , decimal Commission , ushort Quantity) : base (FirstName , LastName , BirthDay , DepartmentCode)
          {
               this._Salary = Salary;
               this._Commission = Commission;
               this._Quantity = Quantity;
          }
          #endregion
          #region Methods
          protected internal override decimal Earnings()
          {
               return _Salary + _Quantity * _Commission;
          }
          public override string ToString()
          {
               return "CommissionWorker:" + base.ToString();
          }
          #endregion
     }
     class PieceWorker : Employee
     {
          #region Fields
          private decimal _WagePerPiece;
          private ushort _Quantity;
          #endregion
          #region Constructors
          protected internal PieceWorker(string FirstName, string LastName, string BirthDay, ushort DepartmentCode, decimal WagePerPiece , ushort Quantity) : base (FirstName , LastName , BirthDay ,DepartmentCode)
          {
               this._WagePerPiece = WagePerPiece;
               this._Quantity = Quantity;
          }
          #endregion
          #region Methods
          protected internal override decimal Earnings()
          {
               return _WagePerPiece * _Quantity;
          }
          public override string ToString()
          {
               return "PieceWorker:" + base.ToString();
          }
          #endregion
     }
     class HourlyWorker : Employee
     {
          #region Fields
          private decimal _Wage;
          private double _HoursWorked;
          #endregion
          #region Constructors
          protected internal HourlyWorker(string FirstName, string LastName, string BirthDay, ushort DepartmentCode, decimal Wage , double HoursWorked) : base (FirstName , LastName , BirthDay , DepartmentCode)
          {
               this._Wage = Wage;
               this._HoursWorked = HoursWorked;
          }
          #endregion
          #region Methods
          protected internal override decimal Earnings()
          {
               return ((decimal)_HoursWorked) * _Wage;
          }
          public override string ToString()
          {
               return "HourlyWorker:" + base.ToString();
          }
          #endregion
     }
     class Program
     {
          static void Main(string[] args)
          {
               Employee[] Employees = new Employee[4];
               Employees[0] = new Boss("Alireza", "Nemati", @"1370/9/22", 1 , 10000);
               Employees[1] = new CommissionWorker("Sina", "Amrieh", @"1370/09/12", 2, 1000, 100, 20);
               Employees[2] = new PieceWorker("Hooman", "Honarmand", @"1370/05/08", 3, 100, 40);
               Employees[3] = new HourlyWorker("Javad", "Bakhshande", @"1370/03/18", 4, 20, 220);
               foreach (Employee employee in Employees)
               {
                    Console.WriteLine(employee.ToString() + " Earnings:" + employee.Earnings() + "\n");
               }
               Console.ReadKey();

          }
     }
}
