

internal class Program {

  public static void Main(string[] args){
    string[,] tablero = new string[8,8];
    string [] abecedario = {"a","b","c","d","e","f","g","h"};
    string fila = "";
    int positivo = 2, negativo = -2;



    void imprimirTablero(){ 
      //Ciclo para imprimir tabla ajedrez
      for(int i = 0; i < 8; i++){

        for(int j = 0; j < 8; j ++){    
            fila =fila+ " "+ tablero[j,i];
        }
        foreach(char letra in fila){
          if(letra.ToString() == "+" || letra.ToString() == "Y" || letra.ToString() == "O"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(letra);
            Console.ResetColor();
          }else{
            Console.Write(letra);
          }
        }
        
        fila = "";
        Console.WriteLine("");
      }
    
    }    
      
    //Ciclos para llenar tabla ajedrez
      for(int i = 0; i < 8; i++){
        for(int j = 0; j < 8; j ++){
          tablero[i,j] = $"{j+1}{abecedario[i]}";
        }
      }

    imprimirTablero();
    Console.Write("Ingrese la posición del caballo: ");
    string ? input = Console.ReadLine().ToLower();

    //Para encontrar posibles movimientos
    for(int i = 0; i < 8; i++){
      for(int j = 0; j < 8; j ++){
         //Encuentra la posicion escogida
        if(input == $"{j+1}{abecedario[i]}"){
            tablero[i,j] = $"YO";
            try{
              if(i+positivo < 8 && i+positivo >= 0 && j+1 < 8 && j+1 >= 0){
                tablero[i+positivo,j+1]= "++"; 

              }
              if(i+positivo < 8 && i+positivo >= 0 && j-1 < 8 && j-1 >= 0){
                tablero[i+positivo,j-1]= "++"; 

              }
              if(i+negativo < 8 && i+negativo >= 0 && j+1 < 8 && j+1 >= 0){
                tablero[i+negativo,j+1]= "++"; 

              }
              if(i+negativo < 8 && i+negativo >= 0 && j-1 < 8 && j-1 >= 0){
                tablero[i+negativo,j-1]= "++"; 

              }

              if(i+1 < 8 && i+1 >= 0 && j+positivo < 8 && j+positivo >= 0){
                  tablero[i+1,j+positivo]= "++"; 

              }
              if(i+1 < 8 && i+1 >= 0 && j+negativo < 8 && j+negativo >= 0){
                  tablero[i+1,j+negativo]= "++"; 

              }
              
              if(i-1 < 8 && i-1 >= 0 && j+positivo < 8 && j+positivo >= 0){
                  tablero[i-1,j+positivo]= "++"; 

              }
              
              if(i-1 < 8 && i-1 >= 0 && j+negativo < 8 && j+negativo >= 0){
                  tablero[i-1,j+negativo]= "++"; 

              }
         

            }catch(Exception e){
               Console.WriteLine(e.Message);           
          }
        
        }


      }
    }

    imprimirTablero();
    Console.WriteLine(input);
  }



}