using System;
using System.Diagnostics.CodeAnalysis;

public class tenth
{
    static int m;
    static int eng;
    static int cse;
    static int phy;
    static int chem;
    static int tam;

    public tenth()
    {
        Console.Write("Enter Maths marks:");
        m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter Social marks");
        eng = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter Science marks");
        cse = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter Tamil marks");
        tam = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter English marks");
        phy = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter English marks");
        chem = Convert.ToInt16(Console.ReadLine());
        ;
        //Console.WriteLine("Total marks:" + tot);
        float per = (float)(m +float)(phy/2)+(chem/2)) / (float)(200);
        Console.WriteLine("Percentage:" +per );
    }
    
    static void main(string[] args)
    {
        new tenth();
        

    }

}