using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_Part1
{
    class DanhSach
    {
        private int n,i;
        private SinhVien[] DS;
        public void nhapDS()
        {

            Console.WriteLine("nhap so luong sinh vien:");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap sinh vien thu: {0}", i + 1);
                DS[i] = new SinhVien();
                DS[i].nhap();
            }

        }
        public void XuatDS()
        {
            if (DS != null && n != 0)
            {



                for (int i = 0; i < n; i++)
                {
                    DS[i].InThongTin();
                }
            }
        }
        public void SapXep()
        {
            for (int i = 0; i < n-1; i++) 
                for(int j=i+1;j<n;j++)
                {
                    if (string.Compare(DS[i].MaSV, DS[j].MaSV, true) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }

                }    
        }
        public void DSSV()
        {
           
            for (i = 0; i < n; i++)
            {
                if( DS[i].CheckDiem())
                {
                    Console.WriteLine("sinh vien co diem tong ket tren 8.0 la:");
                    DS[i].InThongTin();
                }
            }    
        }
        
    }

}

//Nhập danh sách sinh viên

//In thông tin các sinh viên có trong danh sách

//Liệt kê những sinh viên có điểm TB>8.0

//Sắp xếp danh sách theo Mã sinh viên