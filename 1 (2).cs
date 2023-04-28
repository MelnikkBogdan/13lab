using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Plane : IEquatable<Plane>
{

    public virtual int Place { get; set; }

    public Plane() { Place = 0; }


    public Plane(int place)
    {

        Place = place;

    }

    public override string ToString()
    {

        return string.Format("place: {0}", Place);

    }

    public int Salary()
    {

        return Place;

    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Plane);
    }

    public bool Equals(Plane other)
    {
        return other != null &&
               Place == other.Place;
    }

  public override int GetHashCode()
    {
        return HashCode.Combine(Place);
   }

}

public class AH : Plane
{

    public AH(int place)
    : base(0)
    {

        Place = place;
    }

    public override string ToString()
    {

        return string.Format(" {0} {1} ", "AH", base.ToString()); ;

    }





}

public class Boeing : Plane
{

    public Boeing(int place)
    : base(0)
    {

        Place = place;
    }

    public override string ToString()
    {

        return string.Format(" {0} {1} ", "Boeing", base.ToString()); ;

    }

}

public class AirBus : Plane
{

    public AirBus(int place)
    : base(0)
    {

        Place = place;
    }

    public override string ToString()
    {

        return string.Format(" {0} {1} ", "AirBus", base.ToString()); ;

    }

}








class Program
{
    static void Main()
    {

        AH a1 = new AH(225);
        AH a2 = new AH(225);

        Console.WriteLine(a1.Equals(a2)); // true
        Console.WriteLine(a1 == a2); // false

        Plane[] Planes = new Plane[5]
               {
                new AH(120),
                new Boeing(100),
                new AH(90),
                new AH(150),
                new AirBus(125)
               };



        int sum = 0;
        Console.WriteLine("***** Кількість місць  *****\n");
        foreach (Plane p in Planes)
        {
            Console.WriteLine(p.ToString());

            sum += p.Salary();

        }

        Console.Write($"\nКількість місць: {sum} ");



    }
}