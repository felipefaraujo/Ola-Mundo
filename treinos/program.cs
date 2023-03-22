using System;
class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Quantos elementos serão lidos?");
        int numeroElementos = int.Parse(Console.ReadLine());
        int[] vet = new int[numeroElementos];
        for (int i = 0; i < numeroElementos; i++) {
            Console.WriteLine("Digite o " + (i + 1) + "º número inteiro: ");
            vet[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Maior diferença entre dois elementos: " + diferenca(vet));
        if (vetorEmOrdemCrescente(vet) == true) {
            Console.WriteLine("O vetor digitado está em ordem CRESCENTE.");
        } else {
            Console.WriteLine("O vetor digitado NÃO está em ordem crescente.");
        }
    }
    public static int diferenca(int[] vet) {
        int maiorNumero = vet[0];
        int menorNumero = vet[0];
        int maiorDiferenca = 0;
        for (int i = 0; i < vet.Length; i++) {
            if (vet[i] > maiorNumero) {
                maiorNumero = vet[i];
            } else if (vet[i] < menorNumero) {
                menorNumero = vet[i];
            }
        }
        maiorDiferenca = maiorNumero - menorNumero;
        return maiorDiferenca;
    }
    public static bool vetorEmOrdemCrescente(int[] vet) {
        bool vetorCrescente = false;
        for (int i = 0, j = 1; i < vet.Length && j < vet.Length; i++, j++) {
            if (vet[i] <= vet[j]) {
                vetorCrescente = true;
            } else {
                vetorCrescente = false;
                break;
            }
        }
        if (vetorCrescente == true) {
            return true;
        } else {
            return false;
        }
    }
}