using System;

namespace Atividade_2___Marlão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um valor para a conversão: ");
            double Medida = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Qual é a unidade de conversão requisitada: \n [1] Quilometro \n [2] Metro \n [3] Centimetro \n [4] Milimetro [5] Micrometro \n [6] Nanometro \n [7] Milha \n [8] Jarda \n [9] Pe \n [10] Polegada \n [11] Milhanautica \n Digite aqui: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Conversão_de_medidas RVV = new Conversão_de_medidas(Medida);
            if (R == 1)
            {
                double RV = RVV.Km;
                Console.Write(RV);
            }
            else if (R == 2)
            {
                double RV = RVV.M;
                Console.Write(RV);
            }
            else if (R == 3)
            {
                double RV = RVV.Cm;
                Console.Write(RV);
            }
            else if (R == 4)
            {
                double RV = RVV.Mm;
                Console.Write(RV);
            }
            else if (R == 5)
            {
                double RV = RVV.Mc;
                Console.Write(RV);
            }
            else if (R == 6)
            {
                double RV = RVV.Nm;
                Console.Write(RV);
            }
            else if (R == 7)
            {
                double RV = RVV.Ml;
                Console.Write(RV);
            }
            else if (R == 8)
            {
                double RV = RVV.J;
                Console.Write(RV);
            }
            else if (R == 9)
            {
                double RV = RVV.P;
                Console.Write(RV);
            }
            else if (R == 10)
            {
                double RV = RVV.Pl;
                Console.Write(RV);
            }
            else if (R == 11)
            {
                double RV = RVV.Mn;
                Console.Write(RV);
            }
            Console.ReadKey();
        }
    }
}
