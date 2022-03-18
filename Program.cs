// See https://aka.ms/new-console-template for more information
bool testing = false;
while (!testing)
{
    Console.Write("Masukan No Soal:");
    int no = Convert.ToInt32(Console.ReadLine());
    switch (no)
    {
        case 1:
            Quiz03.Solution.Soal1();
            break;
        case 2:
            Quiz03.Solution.Soal2();
            break;
        case 3:
            Quiz03.Solution.Soal3();
            break;
        case 4:
            Quiz03.Solution.Soal4();
            break;
        case 5:
            Quiz03.Solution.Soal5();
            break;
        case 6:
            Quiz03.Solution.Soal6();
            break;
        case 7:
            Quiz03.Solution.Soal7();
            break;
        case 8:
            Quiz03.Solution.Soal8();
            break;
        default:
            Console.WriteLine($"Tidak ada nomor soal {no}");
            break;
    }
    option:
    Console.Write("Lanjut?(y/n)");
    string opt = Console.ReadLine();
    if (opt == "n")
    {
        Console.WriteLine("Terima Kasih");
        testing = true;
    }
    else if (opt == "y")
    {
        Console.Clear();
        
    }
    else
    {
        Console.Clear();
        goto option;
    }
}

/*Quiz03.Solution.Soal1();
Quiz03.Solution.Soal2();
Quiz03.Solution.Soal3();
Quiz03.Solution.Soal4();
Quiz03.Solution.Soal5();
Quiz03.Solution.Soal6();
Quiz03.Solution.Soal7();
Quiz03.Solution.Soal8();*/
Console.ReadLine();
