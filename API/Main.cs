using System;
using CRUD.Domain.Entities;

namespace CRUD.API;

public class Main
{
    class CrudApi
    {
        static void Main(string[] args)
        {
            Cliente[] clientes =
            [
                new Cliente("Joice", "joice@gmail.com", "+55 (19)99821-5589"),
                new Cliente("Kekele", "kekeleyabo@gmail.com", "+55 (19)99238-6419"),
            ];
            clientes[0].DescreverCliente();
        }
    }
  
}