using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Entities
{
    public class BProduct
    {
       

        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public int CategoryId { get; set; }

        //retour db
       internal BProduct(int id, string name, string description, double? price, string photo, string video, int categoryId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
            Video = video;
            CategoryId = categoryId;
        

        }
            //insert depuis api
            public BProduct(string name, string description, double? price, string photo, string video, int categoryId)
            {
               
                Name = name;
                Description = description;
                Price = price;
                Photo = photo;
                Video = video;
                CategoryId = categoryId;
            }

        public BProduct(string name, string description, double? price, string photo, string video)
        {
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
            Video = video;
        }
    }



}
