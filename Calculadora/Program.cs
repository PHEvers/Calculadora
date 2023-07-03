using Calculadora;

Console.WriteLine("Hello, World!");
int menu = 1;
int menu2 = 1;
Funcoes funcoes = new Funcoes();
do
{
    menu = funcoes.MenuPrincipal();
    switch (menu)
    {
        case 1:
            funcoes.Soma();
            break;
        case 2:
            funcoes.Multiplicacao();
            break;
        case 3:
            funcoes.Divisao();
            break;
        default: break;
    }
} while (menu > 0);
