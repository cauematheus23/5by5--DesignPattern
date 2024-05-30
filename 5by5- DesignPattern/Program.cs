// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;
using Services;

Console.WriteLine("inicio do processamento");

Car car = new Car
{
    
    Name = "Carro MUITO legal",
    Color = "Vermelho",
    Year = 2005
};

/*for (int i  = 1; i < 10000; i++)
{
    car.Name = "Teste - " + i.ToString();
    Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" + car.Name : "Erro ao inserir Registro");
}*/

foreach(var item in new CarController().GetAll().Where(x => x.Id > 990).ToList().Take(10))
{
    Console.WriteLine(item);
}
new CarController().GetAll().Where(x=>x.Id > 990).ToList().ForEach(c => Console.WriteLine(c));
//Console.WriteLine(car);
//if ternario
//Console.WriteLine("Exemplo INSERT");
//Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir Registro");
//Console.WriteLine("Validação");
//foreach (var item in new CarController().GetAll())

//    Console.WriteLine(item);
//Console.WriteLine("EXEMPLO UPDATE");
//Console.WriteLine(new CarController().Update(car) ? "Registro Atualizado" : "Erro ao atualizar Registro");
//Console.WriteLine("VALIDACAO");
//foreach (var item in new CarController().GetAll())

//    Console.WriteLine(item);
//Console.WriteLine("EXEMPLO DELETE");
//Console.WriteLine(new CarController().Delete(1) ? "Registro Deletado" : "Erro ao deletar Registro");
//Console.WriteLine("VALIDACAO");
//foreach ( var item in new CarController().GetAll())

//    Console.WriteLine(item);

//Console.WriteLine("EXEMPLO GET");
//Console.WriteLine(new CarController().Get(1));

//Menu m = new Menu();
//m.CrudMenu();
//int opc = 0;
//switch (opc)
//{
//    case 1:
//        Console.WriteLine("Exemplo INSERT");
//        Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir Registro");
//        break;
//    case 2:
//        Console.WriteLine("EXEMPLO DELETE");
//        Console.WriteLine(new CarController().Delete(1) ? "Registro Deletado" : "Erro ao deletar Registro");
//        break;
//}