using System;

namespace Chuong3_Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            //SinhVien nv = new SinhVien();

            //nv.nhap();
            //nv.TinhDiemTB();
            //nv.InThongTin();
            //Console.ReadLine();

            DanhSach sv = new DanhSach();
            sv.nhapDS();
            Console.WriteLine(" ma sinh vien da duoc sap xep la:");
            sv.SapXep();
            Console.WriteLine("sinh vien co diem tren 8.0 la:");
            sv.DSSV();
            sv.XuatDS();
            
          
            Console.ReadLine();
            
        }
    }
}
