using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class User
    {
        [Required(ErrorMessage="Vui lòng nhập đầy đủ họ và tên.")]
        public string Name { get; set; }
        //NGÀNH CÔNG NGHỆ PHẦN MỀM
        //--Điểm nhập môn lập trình bao gồm lt và thực hành.
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemNhapMonLT { get; set; }
        //
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemNhapMonTH { get; set; }
        //--Điểm Lập trình hdt bao gồm lt và thực hành.
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemLapTrinhHDTLT { get; set; }
        //
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemLapTrinhHDTTH { get; set; }

        //--Điểm cấu trúc dữ liệu & GT bao gồm lt và thực hành.
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemCauTrucDLLT { get; set; }
        //
        [Required(ErrorMessage="Vui lòng nhập điểm")]
        [Range(minimum:0,maximum:10,ErrorMessage="Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemCauTrucDLTH { get; set; }


        //NGÀNH HỆ THỐNG THÔNG TIN: 
        //--Điểm nhập môn lập trình bao gồm lt và thực hành.
        //--Điểm Cơ sở DL bao gồm lt và thực hành.
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemCoSoDLLT { get; set; }
        //
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemCoSoDLTH { get; set; }
        //--Điểm Hệ QTCSDL
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemHeQuanTCSDL { get; set; }

        //NGÀNH MẠNG MÁY TÍNH
        //--Điểm nhập môn lập trình bao gồm lt và thực hành.
        //--Điểm kiến trúc máy tính.
        //[Required(ErrorMessage = "Vui lòng nhập điểm")]
        //[Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        //public float diemKienTrucMT { get; set; }
        //--Điểm hệ điều hành.
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemHeDieuH { get; set; }
        //--Điểm mạng máy tính bao gồm lý thuyết và thực hành.
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemMangMayTinhLT { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemMangMayTinhTH { get; set; }

        //NGÀNH PHÂN TÍCH DỮ LIỆU
        //--Điểm cấu trúc dữ liệu & GT bao gồm lt và thực hành.
        //--Điểm Cơ sở DL bao gồm lt và thực hành.
        //--Điểm Trí tuệ nhân tạo
        [Required(ErrorMessage = "Vui lòng nhập điểm")]
        [Range(minimum: 0, maximum: 10, ErrorMessage = "Vui lòng nhập điểm trong khoảng 0-10")]
        public float diemTriTueNT { get; set; }

    }
}