using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if (a != 0)
                return true;
            return false;
            //se il primo membro (a) è diverso da 0 ritorna true 
            //cioe che l'equazione è determinata, altrimenti false 
            //se non è determinata.
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0)
            {
                if (b != 0)
                    return true;
            }
            return false;
            //sei il primo membro è uguale a 0 controlla se il 
            //secondo è diverso da zero e se è diverso torna true quindi è impossibile, 
            //altrimenti torna false quindi non è impossibile
        }
        public static bool IsDegree2(double x)
        {
            if (x == 2)
                return true;
            return false;
            //se l'esponente del primo membro è uguale a 2 allora torna true quindi 
            //è di secondo grado, altrimenti se è diverso torna false
        }
        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
            //usa la formula per trovare il delta dati i tre membri dell'equazione
        }
        public static string Result(double a, double b, double c)
        {

            double x1, x2;
            double delta = (b * b) - (4 * a * c);
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return ($"x1={x1} x2={x2}");
            //inseriti i membri dell'equazione calcola il delta,una volta 
            //trovato il delta trovo x1 e x2 con la formula
        }
        public static string EquationDegree1(double a, double b, double c)
        {
            string risultato = "";
            if (a == 0)
            {
                if (b != 0)
                {
                    risultato = "Impossibile";
                }
            }
            if (a != 0)
            {
                if (b == 0)
                {
                    risultato = "indeterminata";
                }
                else
                {
                    double x1, x2;
                    double delta = (b * b) - (4 * a * c);
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return ($"x1={x1} x2={x2}");
                }
            }

            return risultato;
            //se il primo membro è uguale a 0 allora controlla se anche il secondo è uguale a 0 ed è indeterminata, 
            //altrimenti controlla se il primo è diverso da zero e se b è uguale a 0 è impossibile altrimenti la svolge 
        }
        public static bool IsIndetermined(double a, double b)
        {
            if (a != 0)
            {
                if (b == 0)
                {
                    return true;
                }
            }
            return false;


        }

    }
}

