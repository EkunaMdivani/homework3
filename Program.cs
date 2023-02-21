
class homework3
{

    static void Main(String[] args)
    {

        //davaleba #1
        Console.Write("sheikvanet pirveli ricxvi (X): ");
        int X = Int32.Parse(Console.ReadLine());

        Console.Write("sheikvanet meore ricxvi (Y): ");
        int y = Int32.Parse(Console.ReadLine());

        Console.Write("sheikvane mesame ricxvi (Z): ");
        int z = Int32.Parse(Console.ReadLine());

        int sum = X + y * z;
        Console.WriteLine("Shedegi aris " + sum);


        //Davaleba #2
        Console.Write("sheikvane tkveni saxeli: ");
        String saxeli = Console.ReadLine();
        Console.Write("sheukvanet tkveni gvari: ");
        String gvari= Console.ReadLine();
        Console.Write("sheikvanet tkveni asaxi: ");
        int asaki=Int32.Parse(Console.ReadLine());
        Console.Write("gtxovt sheikvanot tkveni simagle (cm):");
        float simagle=float.Parse(Console.ReadLine());
        Console.Write("gtxovt sheukvanot tkveni cona (kg):");
        float cona=float.Parse(Console.ReadLine());

        Console.Write("sheikvanet tkveni monacemebi " );

        Console.WriteLine( saxeli + " " + gvari + "," + asaki + "clis" + "," + simagle + "cm" + "," + cona + "kg");
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #3
        Console.Write("gtxovt sheikvanot tkveni cona (kg): ");
        float weight=float.Parse(Console.ReadLine());
        Console.Write("gtxovt sheukvanot tkveni simagle (m): ");
        float height =float.Parse(Console.ReadLine());
        float BMI = weight/(height*height);
        Console.WriteLine() ;
        Console.WriteLine("tkveni BMI (kg/m2) aris: " + BMI);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #4

        string vertical = "|";
        string horizontal = "---";
        Console.WriteLine();
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
        Console.WriteLine(" " + "1" + " " + vertical + " " + "2" + " " + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + "4" + " " + vertical + " " + "5" + " " + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + "7" + " " + vertical + " " + "8" + " " + vertical + "9");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);








    }

}