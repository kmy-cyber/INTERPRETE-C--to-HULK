using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTERPRETE_C__to_HULK
{
    //Definiendo el objeto Node
    public class Node
    {
        public string? Type { get; set; } //tipo de Nodo
        public object? Value { get; set; } // Valor 
        public List<Node> Children { get; set; } // Lista de hijos del nodo

        public Node()
        {
            Children = new List<Node>();
        }
        
    }
}