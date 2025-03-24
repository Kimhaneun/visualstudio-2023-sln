using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Wintr0116
{
    class Squar : Shap
    {
        float width, hight;

        public Squar(float width, float hight)
        {
            this.width = width;
            this.hight = hight;
        }

        public override float GtAra()
        {
            return width * hight;
        }
    }
}
