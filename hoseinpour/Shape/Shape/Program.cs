using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Classes
namespace Shape
{
     abstract class Shape
     {
          #region Properties
          protected internal abstract string Name
          {
               get;
          }
          #endregion
          #region Methods
          protected internal abstract double Area();
          protected internal abstract double Volume();
          #endregion
     }
     abstract class TwoD : Shape
     {
          #region Methods
          protected internal abstract override double Area();
          #endregion
     }
     abstract class ThreeD : TwoD
     {
          #region Methods
           protected internal abstract override double Volume();
          #endregion
     }
     class Point : ThreeD
     {
          #region Fields
          protected double _X , _Y;
          #endregion
          #region Properties
          protected internal override string Name
          {
               get
               {
                    return "Point";
               }
          }
          #endregion
          #region Constructors
          protected internal Point()
          {

          }
          protected internal Point(double X , double y)
          {
               this._X = X;
               this._Y = y;
          }
          ~Point()
          {

          }
          #endregion
          #region Methods
          protected internal override double Area()
          {
               return 0;
          }
          protected internal override double Volume()
          {
               return 0;
          }
          public override string ToString()
          {
               return "[X:" + _X + ",Y:" + _Y + "]";
          }
          #endregion
     }
     class Circle : Point
     {
          #region Fields
          protected double _Radius;
          #endregion
          #region Properties
          protected internal override string Name
          {
               get
               {
                    return "Circle";
               }
          }
          #endregion
          #region Constructors
          protected internal Circle()
          {

          }
          protected internal Circle(double Radius)
          {
               this._Radius = Radius;
          }
          protected internal Circle(double X , double Y, double Radius) : base(X , Y)
          {
               this._Radius = Radius;
          }
          
          ~Circle()
          {

          }
          #endregion
          #region Methods
          private double Diameter()
          {
               return _Radius * 2;
          }
          internal double Circumference()
          {
               return Diameter() * Math.PI;
          }
          protected internal  override double Area()
          {
               return Math.Pow(_Radius , 2) * Math.PI;
          }
          protected internal override double Volume()
          {
               return 0;
          }
          public override string ToString()
          {
               return "Radius:" + _Radius + " Center:" + base.ToString();
          }
          #endregion
     }
     sealed class Cylinder : Circle
     {
          #region Fields
          private double _Height;
          #endregion
          #region Properties
          protected internal  override string Name
          {
               get
               {
                    return "Cylinder";
               }
          }
          #endregion
          #region Constructors
          internal Cylinder()
          {

          }
          internal Cylinder(double Radius , double Height) : base(Radius)
          {
               this._Height = Height;
          }
          internal Cylinder (double X , double Y , double Radius , double Height) : base (X , Y , Radius)
          {
               this._Height = Height;
          }
          ~Cylinder()
          {

          }
          #endregion
          #region Methods
          protected internal override  double Volume()
          {
               return _Height * base.Area();
          }
          protected internal override double Area()
          {
               return 2 * base.Area() + base.Circumference() * _Height;
          }
          public override string ToString()
          {
               return "Height:" + _Height +" " + base.ToString();
          }
          #endregion
     }
     #endregion
     class Program
     {
          static void Main(string[] args)
          {
               Shape[] Shapes = new Shape[3];
               Shapes[0] = new Point(10, 12);
               Shapes[1] = new Circle(12, 13, 15);
               Shapes[2] = new Cylinder(2, 3, 4, 5);
               foreach (Shape shape in Shapes)
               {
                    Console.WriteLine(shape.ToString());
                    Console.WriteLine("Area:" + shape.Area());
                    Console.WriteLine("Volume:" + shape.Volume()+"\n\n");
               }
               Console.ReadKey();
          }
     }
}
