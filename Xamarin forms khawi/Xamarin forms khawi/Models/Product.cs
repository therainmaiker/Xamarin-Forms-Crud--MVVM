using System;
using SQLite;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Xamarin_forms_khawi.Models
{
    class Product
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }



    }
}
