using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsitivePets.Models
{
    public class Category
    {
        //in .net, for fields, use the name (Model)Id or just Id
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
