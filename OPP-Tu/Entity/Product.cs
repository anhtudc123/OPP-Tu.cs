using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entity;

namespace b4product
{
    public class Product:BaseIdAndName
    {
        public int categoryId { get; set; }
    }
}