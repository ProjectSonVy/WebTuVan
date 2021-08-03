using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class KH_PTDL
    {
        public float diemCauTrucDLLT { get; set; }
        public float diemCauTrucDLTH { get; set; }
        public float diemCoSoDLLT { get; set; }
        public float diemCoSoDLTH { get; set; }
        public float diemTriTueNT { get; set; }
        //
        public KH_PTDL()
        {
            diemCauTrucDLLT = (float)5.3361;
            diemCauTrucDLTH = (float)5.3608;
            diemCoSoDLLT = (float)5.3474;
            diemCoSoDLTH = (float)5.6948;
            diemTriTueNT = (float)5.733;
        }
        //
        public KH_PTDL(float dCTDL_LT, float dCTDL_TH, float dCSDL_LT, float dCSDL_TH, float dTTNT)
        {
            this.diemCauTrucDLLT = dCTDL_LT;
            this.diemCauTrucDLTH = dCTDL_TH;
            this.diemCoSoDLLT = dCSDL_LT;
            this.diemCoSoDLTH = dCSDL_TH;
            this.diemTriTueNT = dTTNT;
        }
        public float distEuclid(KH_PTDL khptdl)
        {
            return (float)Math.Sqrt(Math.Pow(khptdl.diemCauTrucDLLT - this.diemCauTrucDLLT,2) + Math.Pow(khptdl.diemCauTrucDLTH - this.diemCauTrucDLTH,2) + Math.Pow(khptdl.diemCoSoDLLT - this.diemCoSoDLLT,2) + Math.Pow(khptdl.diemCoSoDLTH - this.diemCoSoDLTH,2) + Math.Pow(khptdl.diemTriTueNT - this.diemTriTueNT,2));
        }
    }
}