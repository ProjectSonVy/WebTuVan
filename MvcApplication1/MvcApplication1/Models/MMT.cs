using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class MMTs
    {
        public float diemNhapMonLT { get; set; }
        public float diemNhapMonTH { get; set; }
        public float diemHeDieuH { get; set; }
        public float diemMangMayTinhLT { get; set; }
        public float diemMangMayTinhTH { get; set; }
        //Tạo phương thức ko tham số gán cứng trọng tâm đc tính ở Weka.
        public MMTs()
        {
            diemNhapMonLT = (float)6.3716;
            diemNhapMonTH = (float)6.8077;
            diemHeDieuH = (float)6.3932;
            diemMangMayTinhLT = (float)7.1401;
            diemMangMayTinhTH = (float)7.1234;
        }
        //
        public MMTs(float dNM_LT, float dNM_TH, float dHDH, float dMMT_LT, float dMMT_TH)
        {
            this.diemNhapMonLT = dNM_LT;
            this.diemNhapMonTH = dNM_TH;
            this.diemHeDieuH = dHDH;
            this.diemMangMayTinhLT = dMMT_LT;
            this.diemMangMayTinhTH = dMMT_TH;
        }
        public float distEuclid(MMTs mmt)
        {
            return (float)Math.Sqrt(Math.Pow(mmt.diemNhapMonLT - this.diemNhapMonLT, 2) + Math.Pow(mmt.diemNhapMonTH - this.diemNhapMonTH, 2) + Math.Pow(mmt.diemHeDieuH - this.diemHeDieuH, 2) + Math.Pow(mmt.diemMangMayTinhLT - this.diemMangMayTinhLT, 2) + Math.Pow(mmt.diemMangMayTinhTH - this.diemMangMayTinhTH, 2));
        }
    }
}