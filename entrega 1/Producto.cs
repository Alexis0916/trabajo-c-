using entrega_1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_1
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double costo;
        private double precioDeVenta;
        private int stock;
        private int idUsuario;



        public Producto() { 
        

            id = 0;
            descripcion = "";
            costo= 0;
            precioDeVenta = 0;
            stock = 0;
            idUsuario = 0;
        
        }
    }

}

