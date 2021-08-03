using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CNPMs
    {
        public float diemNhapMonLT { get; set; }
        public float diemNhapMonTH { get; set; }
        public float diemLapTrinhHDTLT { get; set; }
        public float diemLapTrinhHDTTH { get; set; }
        public float diemCauTrucDLLT { get; set; }
        public float diemCauTrucDLTH { get; set; }
        public CNPMs() //Khởi tạo phương thức k tham số gán cứng giá trị đc tính ở weka.
        {
            this.diemNhapMonLT = (float)8.0364;
            this.diemNhapMonTH = (float)8.1091;
            this.diemLapTrinhHDTLT = (float)8.0932;
            this.diemLapTrinhHDTTH = (float)7.8295;
            this.diemCauTrucDLLT = (float)6.6989;
            this.diemCauTrucDLTH = (float)7.6432;
        }
        public CNPMs(float dNM_LT,float dNM_TH,float dHDT_LT,float dHDT_TH,float dCTDL_LT,float dCTDL_TH) //Khởi tạo CNPM có tham số là tham số mà User nhập vào.
        {
            this.diemNhapMonLT = dNM_LT;
            this.diemNhapMonTH = dNM_TH;
            this.diemLapTrinhHDTLT = dHDT_LT;
            this.diemLapTrinhHDTTH = dHDT_TH;
            this.diemCauTrucDLLT = dCTDL_LT;
            this.diemCauTrucDLTH = dCTDL_TH;
        }
        public float distEuclid(CNPMs cnpm)
        {
            return (float) Math.Sqrt(Math.Pow(cnpm.diemNhapMonLT - this.diemNhapMonLT,2) + Math.Pow(cnpm.diemNhapMonTH - this.diemNhapMonTH,2) + Math.Pow(cnpm.diemLapTrinhHDTLT - this.diemLapTrinhHDTLT,2) + Math.Pow(cnpm.diemLapTrinhHDTTH - this.diemLapTrinhHDTTH,2) + Math.Pow(cnpm.diemCauTrucDLLT - this.diemCauTrucDLLT,2) + Math.Pow(cnpm.diemCauTrucDLTH - this.diemCauTrucDLTH,2));
        }
    }
}