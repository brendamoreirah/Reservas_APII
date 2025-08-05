using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.Api.Models;

namespace Reservas.Testes.MockData
{
    public class ReservasMockData
    {
        public static List<Reserva> GetReservas()
        {
            return new List<Reserva>()
            {
                new Reserva { ReservaId = 1, Nome = "Brenda", InicioLocacao = "São Paulo", FimLocacao = "Santa Catarina" },
                new Reserva { ReservaId = 2, Nome = "Fernada", InicioLocacao = "São Paulo", FimLocacao = "Rio de Janeiro" },
                new Reserva { ReservaId = 3, Nome = "Isadora", InicioLocacao = "Rio de Janeiro", FimLocacao = "São Paulo" },
            };
        }
    }
}
