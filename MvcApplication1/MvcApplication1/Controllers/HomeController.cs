using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;


namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Data_KTDLDataContext data = new Data_KTDLDataContext();
        [HttpPost]
        public ActionResult Index(User us)
        {
            if (ModelState.IsValid)
            {
                Session["info"] = new User()
                {
                    Name = us.Name,
                    diemNhapMonLT = us.diemNhapMonLT,
                    diemNhapMonTH = us.diemNhapMonTH,
                    //
                    diemLapTrinhHDTLT = us.diemLapTrinhHDTLT,
                    diemLapTrinhHDTTH = us.diemLapTrinhHDTTH,
                    //
                    diemCauTrucDLLT = us.diemCauTrucDLLT,
                    diemCauTrucDLTH = us.diemCauTrucDLTH,
                    //
                    diemCoSoDLLT = us.diemCoSoDLLT,
                    diemCoSoDLTH = us.diemCoSoDLTH,
                    //
                    diemHeQuanTCSDL = us.diemHeQuanTCSDL,
                    //
                    //diemKienTrucMT = us.diemKienTrucMT,
                    //
                    diemHeDieuH = us.diemHeDieuH,
                    //
                    diemMangMayTinhLT = us.diemMangMayTinhLT,
                    diemMangMayTinhTH = us.diemMangMayTinhTH,
                    //
                    diemTriTueNT = us.diemTriTueNT

                };
                //Công nghệ phần mềm
                //Tính trung tâm cụm CNPM
                float tt_CNPM_NMLT_LT = (float)data.CNPMs.Average(s => s.NMLT_LT);
                float tt_CNPM_NMLT_TH = (float)data.CNPMs.Average(s => s.NMLT_TH);
                float tt_CNPM_HDT_LT = (float)data.CNPMs.Average(s => s.LTHDT_LT);
                float tt_CNPM_HDT_TH = (float)data.CNPMs.Average(s => s.LTHDT_TH);
                float tt_CTDL_LT = (float)data.CNPMs.Average(s => s.CTDL_LT);
                float tt_CTDL_TH = (float)data.CNPMs.Average(s => s.CTDL_TH);
                CNPMs TTCumCNPM = new CNPMs(tt_CNPM_NMLT_LT, tt_CNPM_NMLT_TH, tt_CNPM_HDT_LT, tt_CNPM_HDT_TH, tt_CTDL_LT, tt_CTDL_TH);
                CNPMs CNPM = new CNPMs(us.diemNhapMonLT, us.diemNhapMonTH, us.diemLapTrinhHDTLT, us.diemLapTrinhHDTTH, us.diemCauTrucDLLT, us.diemCauTrucDLTH);
                float Dist_CNPM = TTCumCNPM.distEuclid(CNPM); //Tính kc trung tâm cụm CNPM
                
                //Hệ thống thông tin
                //Tính trung tâm cụm HTTT
                float tt_HTTT_NMLT_LT = (float)data.HTTTs.Average(s => s.NMLT_LT);
                float tt_HTTT_NMLT_TH = (float)data.HTTTs.Average(s => s.NMLT_TH);
                float tt_HTTT_CSDL_LT = (float)data.HTTTs.Average(s => s.CSDL_LT);
                float tt_HTTT_CSDL_TH = (float)data.HTTTs.Average(s => s.CSDL_TH);
                float tt_HTTT_HQT = (float)data.HTTTs.Average(s => s.HQTCSDL);
                HTTTs TTCumHTTT = new HTTTs(tt_HTTT_NMLT_LT, tt_HTTT_NMLT_TH, tt_HTTT_CSDL_LT, tt_HTTT_CSDL_TH, tt_HTTT_HQT);
                HTTTs HTTT = new HTTTs(us.diemNhapMonLT, us.diemNhapMonTH, us.diemCoSoDLLT, us.diemCoSoDLTH, us.diemHeQuanTCSDL);
                float Dist_HTTT = TTCumHTTT.distEuclid(HTTT);
              
                //Mạng máy tính
                //Tính trung tâm cụm MMT
                float tt_MMT_NMLT_LT = (float)data.MMTs.Average(s => s.NMLT_LT);
                float tt_MMT_NMLT_TH = (float)data.MMTs.Average(s => s.NMLT_TH);
                float tt_MMT_HDH = (float)data.MMTs.Average(s => s.HDH);
                float tt_MMT_LT = (float)data.MMTs.Average(s => s.MMT_LT);
                float tt_MMT_TH = (float)data.MMTs.Average(s => s.MMT_TH);
                MMTs TTCumMMT = new MMTs(tt_MMT_NMLT_LT, tt_MMT_NMLT_TH, tt_MMT_HDH, tt_MMT_LT, tt_MMT_TH);
                MMTs MMT = new MMTs(us.diemNhapMonLT, us.diemNhapMonTH, us.diemHeDieuH, us.diemMangMayTinhLT, us.diemMangMayTinhTH);
                float Dist_MMT = TTCumMMT.distEuclid(MMT);
               
                //Khoa học & Phân tích dữ liệu.
                //Tính trung tâm cụm KHPTDL
                float tt_KHPT_CTDL_LT = (float)data.KHPTDLs.Average(s => s.CTDLGT_LT);
                float tt_KHPT_CTDL_TH = (float)data.KHPTDLs.Average(s => s.CTDLGT_TH);
                float tt_KHPT_CSDL_LT = (float)data.KHPTDLs.Average(s => s.CSDL_LT);
                float tt_KHPT_CSDL_TH = (float)data.KHPTDLs.Average(s => s.CSDL_TH);
                float tt_KHPT_TTNT = (float)data.KHPTDLs.Average(s => s.TTNT);
                KH_PTDL TTCumKHPTDL = new KH_PTDL(tt_KHPT_CTDL_LT, tt_KHPT_CTDL_TH, tt_KHPT_CSDL_LT, tt_KHPT_CSDL_TH, tt_KHPT_TTNT);
                KH_PTDL KHPTDL = new KH_PTDL(us.diemCauTrucDLLT, us.diemCauTrucDLTH, us.diemCoSoDLLT, us.diemCoSoDLTH, us.diemTriTueNT);
                float Dist_KHPTDL = TTCumKHPTDL.distEuclid(KHPTDL);
                
                
                //Tạo ra 1 cái List chứa 4 chuyên ngành
                List<float> Distance = new List<float>();
                Distance.Add(Dist_CNPM);
                Distance.Add(Dist_HTTT);
                Distance.Add(Dist_MMT);
                Distance.Add(Dist_KHPTDL);
                float distMin = Distance.Min();
                if (distMin == Dist_CNPM)
                {
                    Session["TB"] = "Công nghệ phần mềm";
                }
                else if (distMin == Dist_HTTT)
                {
                    Session["TB"] = "Hệ thống thông tin";
                }
                else if (distMin == Dist_MMT)
                {
                    Session["TB"] = "Mạng máy tính";
                }
                else
                {
                    Session["TB"] = "Khoa học & Phân tích dữ liệu";
                }
                return RedirectToAction("KetQua", "Home");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KetQua(User us)
        {
            ViewBag.tb = Session["TB"];
            return View(us);
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}
