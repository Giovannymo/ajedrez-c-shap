

internal class Program {

  public static void Main(string[] args){
    string[,] tablero = new string[8,8];
    string [] abecedario = {"a","b","c","d","e","f","g","h"};
    string fila = "";
    string ? input = Console.ReadLine().ToLower();
    

    //Ciclos para llenar tabla ajedrez
    for(int i = 0; i < 8; i++){
      for(int j = 0; j < 8; j ++){
        //Encuentra la posicion escogida
        if(input == $"{j+1}{abecedario[i]}"){
            tablero[i,j] = $"YO";
          }else{
            tablero[i,j] = $"{j+1}{abecedario[i]}";
        }


      }
    }

    //Ciclo para imprimir tabla ajedrez
    for(int i = 0; i < 8; i++){

      for(int j = 0; j < 8; j ++){
        fila =fila+ " "+ tablero[i,j];
      }
      Console.WriteLine(fila);
      fila = "";
    }
    Console.WriteLine(input);
  }



}