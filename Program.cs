using System;

class Program {
  public static void Main (string[] args) {
  
double salário;
  double salárioreajustado;
    
Console.Write("Informe o seu salário: ");
  salário = double.Parse(Console.ReadLine());

    if(salário > 1700){
      salárioreajustado = (salário * 0.20) + salário;
    }

    else{
      salárioreajustado = (salário * 0.30) + salário;
    }

    Console.WriteLine(" O salário reajustado é de R$: {0:n2}", salárioreajustado);
  
  } 
}
