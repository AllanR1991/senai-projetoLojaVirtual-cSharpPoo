using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Atributos públicos:
// Bandeira: string;
// NumeroCartao: string
// Titular: string
// Cvv: string

// Métodos:
// Pagar(): void;
// SalvarCartao(): string;

namespace NucleoPagamento.classes
{
    public abstract class ClassCartao
    {
         static string PerguntaString(string pergunta)
{
    Console.WriteLine(pergunta);
    return Console.ReadLine();
}

static char PerguntaChar(string pergunta)
{
    Console.WriteLine(pergunta);
    return char.Parse(Console.ReadLine());
}

static int PerguntaInt(string pergunta)
{
    Console.WriteLine(pergunta);
    return int.Parse(Console.ReadLine());
}

static float PerguntaFloat(string pergunta)
{
    Console.WriteLine(pergunta);
    return float.Parse(Console.ReadLine());
}

static void ExibeMensagemPulandoLinha(string texto)
{
    Console.WriteLine(texto);
}

static void ExibeMensagem(string texto)
{
    Console.Write(texto);
}
        public string bandeira {get;set;}
        public string NumeroCarta {get;set;}
        public string Titular {get;set;}
        public string Cvv {get;set;}

public void Pagar()
{

}

public string SalvarCartao()
{
    return "";
}


    }
}