//Fazendo um menu interativo

string? opcao = "";
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

   switch(opcao)
   {

        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;
            
        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrado");
            exibirMenu = false;
            //Environment.Exit(0);
            break;     

            default:
                Console.WriteLine("Opção invalida");
                break;      
   }
}

Console.WriteLine("O programa se encerrou");




































// int soma = 0, numero = 0;



// do
// {
//     Console.WriteLine("Digite um numero (0 para fechar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
    
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");    




















// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} * {contador} = {numero * contador * 1}");
//     contador++;

//     if (contador == 5)
//     {
//         break;   
//     }
// }











// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
// Console.WriteLine($"{numero} * {contador} = {numero * contador * 1}");
// }