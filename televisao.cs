// UNIVERSIDADE NOVE DE JULHO - Uninove
// Curso de Sistemas de Informação  
// Aluno(a): Rayssa Geyziele Leite Pires 
// RA: 924113527
// Professor: JOSE ROMUALDO DA COSTA FILHO
// Disciplina: PROGRAMACAO AVANCADA EM ORIENTACAO A OBJETOS

using System;

public class Program
{
    public static void Main()
    {
        var tv = new Televisao(55);

        tv.Ligar();
        tv.AumentarVolume();
        tv.AtivarMudo();
        tv.DesativarMudo();
        tv.IrParaCanal(100);
        tv.ProximoCanal();
        tv.CanalAnterior();
        tv.Desligar();
    }
}

public class Televisao
{
    private const int VOLUME_MAX = 100, VOLUME_MIN = 0, CANAL_MAX = 520, CANAL_MIN = 1;
    private int ultimoCanal;
    private bool mutada;

    public Televisao(float tamanho) => (Tamanho, Volume, Canal, Estado, ultimoCanal) = (tamanho, 0, CANAL_MIN, false, CANAL_MIN);

    public float Tamanho { get; }
    public int Volume { get; private set; }
    public int Canal { get; private set; }
    public bool Estado { get; private set; }

    public void Ligar() => (Estado, Canal) = (true, ultimoCanal);
    public void Desligar() => ultimoCanal = Canal; Estado = false;

    public void AumentarVolume() => Volume = (!mutada && Volume < VOLUME_MAX) ? Volume + 1 : Volume;
    public void DiminuirVolume() => Volume = (!mutada && Volume > VOLUME_MIN) ? Volume - 1 : Volume;
    public void AtivarMudo() => mutada = true;
    public void DesativarMudo() => mutada = false;

    public void ProximoCanal() => Canal = (Canal < CANAL_MAX) ? Canal + 1 : Canal;
    public void CanalAnterior() => Canal = (Canal > CANAL_MIN) ? Canal - 1 : Canal;
    public void IrParaCanal(int numero) => Canal = (numero >= CANAL_MIN && numero <= CANAL_MAX) ? numero : Canal;
}
