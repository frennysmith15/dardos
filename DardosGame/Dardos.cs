using System;

public class Dardos
{
	private int dado1;
	private int dado2;
	private int dado3;


	public Dardos()
	{
		dado1 = Random.Next(1, 8);
		dado2 = Random.Next(1, 8);
		dado3 = Random.Next(1, 8);
    }

	public void Jugar()
	{
		if (dado1 == dado2 && dado2 == dado3)
		{
			Console.WriteLine("Ganaste, dado1 = " + dado1 + " dado2 = " + dado2 + "dado3 = " + dado3);
		}
		else
		{
            Console.WriteLine("Perdiste, dado1 = " + dado1 + " dado2 = " + dado2 + "dado3 = " + dado3);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dardos dardos = new Dardos();

		dardos.Jugar();

    }
}


