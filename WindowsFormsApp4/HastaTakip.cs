using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class HastaTakip
    {
        public string adi;
        public int ucret;
        public int dogumyili;
        public string cisiyet;

        public int yas;
        public int indirimliucrt;

        public void YasHesapla()
        {
            //hıkjtwıeropsjhkrşts
            yas = DateTime.Now.Year - dogumyili;
        }
        public void IndirimliUcretHesapla()
        {
            if(yas>65)
            {
                indirimliucrt = 0;
            }
            else if (cisiyet=="Kadın")
            {
                indirimliucrt = ucret * 80/100;
            }
            else if (yas<15)
            {
                indirimliucrt = ucret * 50/100;
            }
            else
            {
                indirimliucrt = ucret;
            }
        }
    }
}
