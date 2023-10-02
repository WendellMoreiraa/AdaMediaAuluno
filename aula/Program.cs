using System;

public class Aluno
{
    private int matricula;
    public string nome;
    private double notaProva1;
    private double notaProva2;
    private double notaTrabalho;

    public Aluno(int matricula, string nome)
    {
        this.matricula = matricula;
        this.nome = nome;
        notaProva1 = 0.0;
        notaProva2 = 0.0;
        notaTrabalho = 0.0;
    }

    public void RegistrarNotaProva1(double nota)
    {
        notaProva1 = nota;
    }

    public void RegistrarNotaProva2(double nota)
    {
        notaProva2 = nota;
    }

    public void RegistrarNotaTrabalho(double nota)
    {
        notaTrabalho = nota;
    }

    public double CalcularMediaFinal()
    {
        double mediaProvas =(notaProva1 + notaProva2) * 2.5;
        double mediaTrabalho = notaTrabalho * 2;
        double mediaFinal = (mediaProvas + mediaTrabalho) / 7;

        return Math.Round(mediaFinal,2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a matrícula do aluno:");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o nome do aluno:");
        string nome = Console.ReadLine();

        Aluno aluno = new Aluno(matricula, nome);

        Console.WriteLine("Digite a nota da prova 1:");
        double notaProva1 = Convert.ToDouble(Console.ReadLine());
        aluno.RegistrarNotaProva1(notaProva1);

        Console.WriteLine("Digite a nota da prova 2:");
        double notaProva2 = Convert.ToDouble(Console.ReadLine());
        aluno.RegistrarNotaProva2(notaProva2);

        Console.WriteLine("Digite a nota do trabalho:");
        double notaTrabalho = Convert.ToDouble(Console.ReadLine());
        aluno.RegistrarNotaTrabalho(notaTrabalho);

        double mediaFinal = aluno.CalcularMediaFinal();
        Console.WriteLine($"Média final do aluno {aluno.nome}: {mediaFinal}");
    }
}