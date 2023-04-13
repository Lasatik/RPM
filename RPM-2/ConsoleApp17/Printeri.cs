using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal static class Printeri
{
    public static void Print(Zaniatie zaniatie) // 1
    {
        Console.WriteLine($"\nПолученные данные: ");
        Print(zaniatie.Discyplina);
        Print(zaniatie.Sotrydnik);
        Print(zaniatie.Ayditoria);
        Print(zaniatie.Gryppa);
        Print(zaniatie.VidZanyatiya);
    }
    public static void Print(Ayditoria ayditoria) // 2
    {
        Console.WriteLine(ayditoria.Nazvanie);
        Print(ayditoria.Otvetstvenni);
        Console.WriteLine(ayditoria.PosadMesta);
        Console.WriteLine(ayditoria.KolvoOkon);
    }
    public static void Print(Discyplina discyplina) // 3
    {
        Console.WriteLine(discyplina.Name);
        Console.WriteLine(discyplina.Shortname);
    }
    public static void Print(Gryppa gryppa) // 4
    {
        Console.WriteLine(gryppa.Name);
        Console.WriteLine(gryppa.Shortname);
        Console.WriteLine(gryppa.Chislennost);
        Console.WriteLine(gryppa.YearPostyp);
        Print(gryppa.Specialnost);
        Print(gryppa.ClassLeader);
    }
    public static void Print(Student student) // 5
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Familia);
        Console.WriteLine(student.Otchestvo);
        Print(student.Gryppa);
        Console.WriteLine(student.Data);
    }
    public static void Print(Specialnost specialnost) // 6
    {
        Console.WriteLine(specialnost.Name);
        Console.WriteLine(specialnost.Reduction);
    }
    public static void Print(Sotrydnik sotrydnik)
    {
        Console.WriteLine(sotrydnik.Surname);
        Console.WriteLine(sotrydnik.Name);
        Console.WriteLine(sotrydnik.Otchestvo);
    }
    public static void Print() 
    {
    }
    public static void Print(VidZanyatiya vidZanyatiya) 
    {
        Console.WriteLine(vidZanyatiya.Name);
    }


}

