namespace ATV2_CJ3022528
{
  
    
        internal class Program
        {
            static void Main(string[] args)
            {
                float investimento;
            float porcentagem; 
            float valor;  
            float porcentagem2;

                Console.WriteLine("Quanto era o investimento?");
                investimento = float.Parse(Console.ReadLine());

                porcentagem = investimento / 100;
                porcentagem2 = porcentagem * 3.4f;
                valor = investimento - porcentagem2;
            Console.WriteLine( "O valor com o desconto é : {0}", valor);
            porcentagem = valor / 100;
                porcentagem2 = porcentagem * 2.8f;
                valor = valor + porcentagem2;

            Console.WriteLine( "O valor com o aumento é : {0}",valor);
                porcentagem = valor / 100;
                porcentagem2 = porcentagem2 * 14;
                valor = valor + porcentagem2;
            Console.WriteLine("O valor com o aumjento é: {0}",valor );
            porcentagem = valor / 100;
                porcentagem2 = porcentagem * 8.5f;
                valor = valor - porcentagem2;
                
                Console.WriteLine("O valor total é {0}", valor);

                float salario; float porcentagem1; float aumento; float salariofinal; float aumento2;

                Console.WriteLine("Qual é o salário?");
                salario = float.Parse(Console.ReadLine());
                porcentagem1 = salario / 100;
                Console.WriteLine("Qual a porcentagem de aumento?");
                aumento = float.Parse(Console.ReadLine());
                aumento2 = porcentagem1 * aumento;
                salariofinal = salario + aumento2;
                Console.WriteLine(salariofinal);


                float valor1; float triplo; float dobro; float sus1; float sus2; float total;

                Console.WriteLine("Escreva um valor");
                valor1 = float.Parse(Console.ReadLine());
                triplo = valor * 3;
                dobro = valor * 2;
                sus1 = triplo + 1;
                sus2 = dobro - 1;
                total = sus1 + sus2;
                Console.WriteLine(total);


            }
        }
    }
