using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_Part1
{
    class SinhVien
    {
      //        Xây dựng lớp SinhVien

      //Các thành phần dữ liệu:

          //Mã sinh viên, Họ tên, Năm sinh, Điểm lập trình, Điểm
       //CSDL, Điểm TB(trong đó: Điểm TB = Điểm Lập trình +
       //Điểm CSDL)/2

       //Các hàm tạo
 
      //Hàm tạo không tham số

     //Hàm tạo có 5 tham số(Họ tên, năm sinh, quê quán, Điểm
 
    //Các phương thức

    //Nhập thông tin sinh viên

    //In thông tin sinh viên ra màn hình


        public string MaSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLT;
        private double DiemCSDL;
        public double DiemTB;
       

        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 1990;
            DiemTB = DiemLT = DiemCSDL = 0;
        }
        public SinhVien(string HoTen, int NamSinh, String MaSV, double DiemLT, double DiemCSDL)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.MaSV = MaSV;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (0.5 * (DiemLT + DiemCSDL));
        }

        public void nhap()
        {
            Console.WriteLine("hay nhap ma sinh vien:");
            MaSV = Console.ReadLine();
            Console.WriteLine("hay nhap ho ten sinh vien:");
            HoTen = Console.ReadLine();
            Console.WriteLine(" hay nhap nam sinh cua sinh vien: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hay nhap diem lap trinh cua sinh vien:");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" hay nhap diem co so du lieu  cua sinh vien:");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());

            TinhDiemTB();
        }

        public void TinhDiemTB()
        {
            DiemTB = (0.5 * (DiemCSDL + DiemLT));

        }

        public void InThongTin()
        {
            Console.WriteLine("Thong tin cua sinh vien: \n Ma sinh vien : {0} \t Ten : {1}"
                + " \t Nam sinh : {2} \n diem trung binh : {3}", MaSV, HoTen, NamSinh, DiemTB);
        }

        public bool CheckDiem()
        {

            bool Diem = false;
            if (DiemTB >= 8.0) Diem = true;
            return Diem;

        }
    }
}
