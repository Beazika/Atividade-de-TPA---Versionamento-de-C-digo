using System;
namespace Atividade_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, menu=0, menu2=0;
            bool sair1 = false;
            string[] chamada;
            chamada = new string[10];
            string[] presenca;
            presenca = new string[10];
            string[] nomes;
            
            do{
                nomes = new string[10] {"[ 01 ] Antony S.", "[ 02 ] Bruce B.", "[ 03 ] Clint B.", "[ 04 ] Gamora Z.", "[ 05 ] Michele J.", "[ 06 ] Natasha R.", "[ 07 ] Nebulosa Z.", "[ 08 ] Peter P.", "[ 09 ] Stephen S.", "[ 10 ] Wanda M."};
                Console.WriteLine("\nMenu de registro");
                Console.WriteLine("[ 1 ] Registrar presença\n[ 2 ] Consultar presença\n[ 3 ] Lista de alunos\n[ 0 ] Sair");
                Console.Write("Escolha a opção desejada: ");
                menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(menu){
                    case 1:
                        while(x < 10){
                        Console.WriteLine(nomes[x]+" está presente [SN]");
                        chamada[x] = Console.ReadLine();
                            if(chamada[x] == "S" || chamada[x] == "s"){
                            chamada[x] = "presente";
                            }else{
                            chamada[x] = "ausente";
                        
                            }
                            x++;
                            Console.Clear();
                        }
                    break;
                    
                    case 2:
                        Console.Write("Digite o número do aluno: \n");

                        menu2 = int.Parse(Console.ReadLine());
                        switch(menu2){
                            case 1:
                                Console.WriteLine($"O aluno {nomes[0]} está {chamada[0]}\n");
                            break;
                                
                            case 2:
                                Console.WriteLine($"O aluno {nomes[1]} está {chamada[1]}\n");
                            break;

                            case 3:
                                Console.WriteLine($"O aluno {nomes[2]} está {chamada[2]}\n");
                            break;

                            case 4:
                                Console.WriteLine($"O aluno {nomes[3]} está {chamada[3]}\n");
                            break;

                            case 5:
                                Console.WriteLine($"O aluno {nomes[4]} está {chamada[4]}\n");
                            break;

                            case 6:
                                Console.WriteLine($"O aluno {nomes[5]} está {chamada[5]}\n");
                            break;

                            case 7:
                                Console.WriteLine($"O aluno {nomes[6]} está {chamada[6]}\n");
                            break;

                            case 8:
                                Console.WriteLine($"O aluno {nomes[7]} está {chamada[7]}\n");
                            break;

                            case 9:
                                Console.WriteLine($"O aluno {nomes[8]} está {chamada[8]}\n");
                            break;
                            
                            case 10:
                                Console.WriteLine($"O aluno {nomes[9]} está {chamada[9]}\n");
                            break;

                        }
                    break;

                    case 3:
                     for(int c = 0; c < 10; c++){
                         Console.WriteLine(nomes[c]);
                     }

                    break;

                    case 0:
                        sair1 = true;
                    break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                    break;
                }
            }while(sair1 != true);
            
        }
    }
}

