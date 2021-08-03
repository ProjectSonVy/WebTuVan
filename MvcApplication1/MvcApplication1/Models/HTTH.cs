using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class HTTTs
    {
        public float diemNhapMonLT { get; set; }
        public float diemNhapMonTH { get; set; }
        public float diemCoSoDLLT { get; set; }
        public float diemCoSoDLTH { get; set; }
        public float diemHeQuanTCSDL { get; set; }

        public HTTTs()
        {
            this.diemNhapMonLT = (float)4.9292;
            this.diemNhapMonTH = (float)6.3291;
            this.diemCoSoDLLT = (float)5.8291;
            this.diemCoSoDLTH = (float)6.5891;
            this.diemHeQuanTCSDL = (float)5.745;
        }
        public HTTTs(float dNM_LT, float dNM_TH, float dCSDL_LT, float dCSDL_TH, float dHQT)
        {
            this.diemNhapMonLT = dNM_LT;
            this.diemNhapMonTH = dNM_TH;
            this.diemCoSoDLLT = dCSDL_LT;
            this.diemCoSoDLTH = dCSDL_TH;
            this.diemHeQuanTCSDL = dHQT;
        }
        public float distEuclid(HTTTs httt)
        {
            return (float)Math.Sqrt(Math.Pow(httt.diemNhapMonLT - this.diemNhapMonLT, 2) + Math.Pow(httt.diemNhapMonTH - this.diemNhapMonTH, 2) + Math.Pow(httt.diemCoSoDLLT - this.diemCoSoDLLT, 2) + Math.Pow(httt.diemCoSoDLTH - this.diemCoSoDLTH, 2) + Math.Pow(httt.diemHeQuanTCSDL - this.diemHeQuanTCSDL, 2));
        }
    }
}