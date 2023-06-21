    Console.WriteLine("Seja bem vindo ao jogo Número secreto! ");
    Random numAleatorio = new Random();
    int numSorteado = numAleatorio.Next(1, 100);


do  {
    Console.WriteLine("Adivinhe qual será o número sorteado de 1 a 100. Digite o seu palpite: ");
    int numDigitado = int.Parse(Console.ReadLine());
    

    if(numDigitado == numSorteado)
    {
    Console.WriteLine("Parabéns! Você acertou o número.");
    break;
    } else if(numDigitado < numSorteado)
    {
    Console.WriteLine("Ops! O número é menor que o sorteado.");
    } else
    {
    Console.WriteLine("Ops! O número é maior que o sorteado.");
    }
    } while(true);
    
    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");

