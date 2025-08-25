using C_Sharp;

decimal preco_inicial;
decimal preco_hora;

Console.WriteLine("Bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
preco_inicial = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço por hora:");
preco_hora = decimal.Parse(Console.ReadLine());
List<Veiculo> lista_veiculos = new List<Veiculo>();

void MenuInicial()
{
    Console.WriteLine("=======================Menu Inicial=========================");
    Console.WriteLine("1. Cadastrar veículo");
    Console.WriteLine("2. Remover veículo");
    Console.WriteLine("3. Listar veículos");
    Console.WriteLine("4. Sair");
    Console.WriteLine("============================================================");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            CadastrarVeiculo();
            break;
        case 2:
            RemoverVeiculo();
            break;
        case 3:
            ListarVeiculos();
            break;
        case 4:
            Sair();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

}
MenuInicial();

void CadastrarVeiculo()
{
    Console.WriteLine("Digite a placa do veículo:");
    string placa = Console.ReadLine();

    Console.WriteLine("Digite o modelo do veículo:");
    string modelo = Console.ReadLine();

    Console.WriteLine("Digite a cor do veículo:");
    string cor = Console.ReadLine();

    // adiciona o veículo a uma lista
    lista_veiculos.Add(new Veiculo(placa, modelo, cor));
    Console.WriteLine("Veículo cadastrado com sucesso!");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    MenuInicial();
}


void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo a ser removido:");
    string placa = Console.ReadLine();

    Veiculo veiculo_remover = lista_veiculos.Find(veiculo => veiculo.Placa == placa);

    if (veiculo_remover != null)
    {
        Console.WriteLine("Quantas horas o veiculo ficou estacionado?");
        int horas = int.Parse(Console.ReadLine());
        decimal valor_total = preco_inicial + (preco_hora * horas);
        lista_veiculos.Remove(veiculo_remover);
        Console.WriteLine($"Veículo removido com sucesso! Valor total: {valor_total:C}");
    }
    else
    {
        Console.WriteLine("Veículo não encontrado.");
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    MenuInicial();
}

void ListarVeiculos()
{
    if (lista_veiculos.Count == 0)
    {
        Console.WriteLine("Não existe veiculos cadastrados");
    }
    else
    {
        foreach (Veiculo veiculo in lista_veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Cor: {veiculo.Cor}");
        }
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
    MenuInicial();
}
void Sair()
{
    Console.WriteLine("Obrigado por usar o sistema de estacionamento. Até logo!");
    Environment.Exit(0);
}




