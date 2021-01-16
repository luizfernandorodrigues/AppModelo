using System;

namespace LFRP.UI.AppModelo.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido()
        {
            Id = new Guid();
        }
    }
}
