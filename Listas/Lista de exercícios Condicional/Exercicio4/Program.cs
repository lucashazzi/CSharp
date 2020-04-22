using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicialJogo = 256, horaFinalJogo = 256, tempoTotaldeJogo;
            string[] recebeHoras = Console.ReadLine().Split(' ');

            horaInicialJogo = int.Parse(recebeHoras[0]);
            horaFinalJogo = int.Parse(recebeHoras[1]);

            if (horaInicialJogo < horaFinalJogo)
            {
                tempoTotaldeJogo = horaFinalJogo - horaInicialJogo;
            }
            else
            {
                tempoTotaldeJogo = (24 - horaInicialJogo) + horaFinalJogo;
            }
            
            Console.WriteLine($"O jogo durou {tempoTotaldeJogo} horas.");
        }
    }
}
