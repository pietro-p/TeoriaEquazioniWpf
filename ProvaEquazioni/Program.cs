using System;
using EquazioniLibrary;
namespace ProvaEquazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //ho chiesto all'utente di scegliere un operazione dopo di che tramite uno switch case a seconda 
            //dell'operazione che sceglieva venive eseguito un apposito metodo
            Console.WriteLine("che operazione vuoi eseguire:\n1-IsDetermined \n2-IsInconsisted \n3-IsDegree \n4-Delta \n5-result \n6-EqationDegree");
            Console.WriteLine("seleziona un operazione");
            string scelta = Console.ReadLine();
            Console.WriteLine();

            switch (scelta)
            {
                case "1":
                case "IsDetermined":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a = double.Parse(Console.ReadLine());
                    bool risposta = Equazioni.IsDetermined(a);
                    if(risposta == true)
                    {
                        Console.WriteLine("Determinata");
                    }
                    else
                    {
                        Console.WriteLine("Non è determinata");
                    }
                    break;
                case "2":
                case "IsInconsisted":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del secondo membro");
                    double b = double.Parse(Console.ReadLine());
                    bool risposta1 = Equazioni.IsInconsisted(a1,b);
                    if (risposta1 == true)
                    {
                        Console.WriteLine("Impossibile");
                    }
                    else
                    {
                        Console.WriteLine("Non è impossibile");
                    }
                    break;
                case "3":
                case "IsDegree":
                    Console.WriteLine($"Inserire il grado dell'equazione");
                    double x = double.Parse(Console.ReadLine());                   
                    bool risposta2 = Equazioni.IsDegree2(x);
                    if (risposta2 == true)
                    {
                        Console.WriteLine("Equazione di secondo grado");
                    }
                    else
                    {
                        Console.WriteLine("l'equazione non è di secondo grado");
                    }
                    break;
                case "4":
                case "Delta":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del secondo membro");
                    double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del terzo membro");
                    double c2 = double.Parse(Console.ReadLine());
                    double delta = Equazioni.Delta(a2,b2,c2);
                    Console.WriteLine($"Il delta è: {delta}");
                    break;
                case "5":
                case "result":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del secondo membro");
                    double b3 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del terzo membro");
                    double c3 = double.Parse(Console.ReadLine());
                    string risultato = Equazioni.Result(a3, b3, c3);
                    Console.WriteLine($"Il risultato dell'equazione è: {risultato}");
                    break;
                case "6":
                case "EqationDegree":
                    Console.WriteLine($"Inserire il coefficente del primo membro");
                    double a4 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del secondo membro");
                    double b4 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Inserire il coefficente del terzo membro");
                    double c4 = double.Parse(Console.ReadLine());
                    string risultato4 = Equazioni.EquationDegree1(a4, b4, c4);
                    Console.WriteLine($"Il risultato dell'equazione è: {risultato4}");
                    break;
            }
        }
    }
}

