using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Complex
    {
        int real;
        int img;

        public void SetReal(int _real) { real = _real; }
        public void SetImg(int _img) { img = _img; }
        public int GetReal() { return real; }
        public int GetImg() { return img; }
        public string Print()
        {
            if (img == 0)
            {
                return $"{real}";
            }
            else if (real == 0)
            {
                if (img == 1)
                    return $"i";
                else if (img == -1)
                    return $"-i";
                return $"{img}i";
            }
            else
            {
                if (img < 0)
                {
                    if (img == -1)
                        return $"{real}-i";
                    return $"{real}{img}i";
                }
                else if (img == 1)
                    return $"{real}+i";

                return $"{real}+{img}i";

            }
        }
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = real + right.real;
            result.img = img + right.img;
            return result;
        }
    }
}
