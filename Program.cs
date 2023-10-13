using System.Collections.Generic;
using INTERPRETE_C_to_HULK;

namespace INTERPRETE_C__to_HULK
{
    public class Program
    {

        public static void Main() 
        {


            // Inicializa el diccionario de variables_globales
            Semantic_Analyzer sa = new Semantic_Analyzer();
//
            List<string> input = new List<string>{
                "print(\"hola\"> \"1\");",
            };

            foreach(string s in input)
            {

                Console.Write("> ");
                //try- catch en caso de que lance una excepcion, que lo imprima y siga funcionando
                try
                {
                    // Lexer recibe el input (s) y crea la lista de tokens
                    Lexer T =  new Lexer(s);
                    // Se obtiene la lista de tokens que hace el Lexer
                    List<Token> TS = T.Tokens_sequency;
                    // Parser recibe la lista de tokens (TS) y crea el arbol de sintaxis
                    Parser P = new Parser(TS);
                    // Se obtiene el arbol (N)
                    Node N = P.Parse();
                    // El metodo Read_Parser del Analizador Semantico y recibe el arbol 
                    sa.Read_Parser(N);
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    // Recibe el arbol, lo analiza y devuelve el resultado
                    sa.Choice (N);   
                }
                catch (System.Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine(ex.Message);
                }

                Console.ForegroundColor = ConsoleColor.White;
            }
//
            //Mientras se reciba una entrada el interprete sigue ejecutandose
            while(true)
            {
                Console.Write("> ");
                // Input (linea) a analizar
                string? s = Console.ReadLine();
                if(s == "")
                {
                    break;
                }
                //try- catch en caso de que lance una excepcion, que lo imprima y siga funcionando
                try
                {
                    // Lexer recibe el input (s) y crea la lista de tokens
                    Lexer T =  new Lexer(s);
                    // Se obtiene la lista de tokens que hace el Lexer
                    List<Token> TS = T.Tokens_sequency;
                    // Parser recibe la lista de tokens (TS) y crea el arbol de sintaxis
                    Parser P = new Parser(TS);
                    // Se obtiene el arbol (N)
                    Node N = P.Parse();
                    // El metodo Read_Parser del Analizador Semantico y recibe el arbol 
                    sa.Read_Parser(N);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    // Recibe el arbol, lo analiza y devuelve el resultado
                    sa.Choice (N);   
                }
                catch (System.Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine(ex.Message);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
    }
}