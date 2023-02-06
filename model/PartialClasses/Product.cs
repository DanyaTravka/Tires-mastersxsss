using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tires.model
{
    public partial class Product
    {
        public string ImagePath
        {
            get
            {
                if (Image == null)
                {
                    return "..\\..\\Resources\\picture.png";
                }
                else
                {

                    return "..\\..\\Resources\\" + Image;
                }

            }
        }
        public string MaterialList
        {
            get
            {
                string materials = "";
                return materials;
            }
        }
    }
}
