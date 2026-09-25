// using System;
// using System.Collections.Generic;

// public abstract class NhanVien
// {
//     // các fields
//     public string sHoTen;
//     public int iCMND;
//     public int iNamSinh;
//     public double dLuongCoBan;
//     public double dLuong;

//     // các properties
//     public string HoTen
//     {
//         get { return this.sHoTen; }
//         set { this.sHoTen = value; }
//     }
//     public int CMND
//     {
//         get { return this.iCMND; }
//         set { this.iCMND = value; }
//     }
//     public int NamSinh
//     {
//         get { return this.iNamSinh; }
//         set { this.iNamSinh = value; }
//     }
//     public double LuongCoBan
//     {
//         get { return this.dLuongCoBan; }
//         set { this.dLuongCoBan = value; }
//     }
//     public double Luong
//     {
//         get { return this.dLuong; }
//         set { this.dLuong = value; }
//     }

//     // các constructors
//     public NhanVien(string hoTen, int cMND, int namSinh, double luongCoBan, double luong)
//     {
//         this.HoTen = hoTen;
//         this.CMND = cMND;
//         this.NamSinh = namSinh;
//         this.LuongCoBan = luongCoBan;
//         this.Luong = luong;
//     }
//     public NhanVien() { }

//     // destructors
//     ~NhanVien() { }

//     // Các method
//     // Hàm nhập
//     public virtual void Nhap()
//     {
//         Console.WriteLine("Nhap ho ten: ");
//         this.HoTen = Console.ReadLine();
//         Console.WriteLine("Chung minh nhan dan: ");
//         this.CMND = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap nam sinh: ");
//         this.NamSinh = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap luong co ban: ");
//         this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
//     }
//     public virtual void Nhap(string hoTen, int cMND, int namSinh, double luongCoBan)
//     {
//         this.HoTen = hoTen;
//         this.CMND = cMND;
//         this.NamSinh = namSinh;
//         this.LuongCoBan = luongCoBan;
//     }
//     // Hàm xuất 
//     public virtual void Xuat()
//     {
//         Console.WriteLine("Ho ten: " + this.sHoTen);
//         Console.WriteLine("CMND: " + this.iCMND);
//         Console.WriteLine("Nam sinh: " + this.iNamSinh);
//         Console.WriteLine("Luong co ban: " + this.dLuongCoBan);
//     }
//     // Hàm tính toán
//     public abstract void TinhLuong();
// }

// public class NVKeToan : NhanVien
// {
//     public double dPhuCap;
//     public double PhuCap
//     {
//         get { return this.dPhuCap; }
//         set { this.dPhuCap = value; }
//     }
//     public NVKeToan(double phuCap)
//     {
//         this.PhuCap = phuCap;
//     }
//     public NVKeToan() { }
//     ~NVKeToan() { }

//     public override void Nhap()
//     {
//         Console.WriteLine("Nhap ho ten: ");
//         this.HoTen = Console.ReadLine();
//         Console.WriteLine("Chung minh nhan dan: ");
//         this.CMND = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap nam sinh: ");
//         this.NamSinh = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap luong co ban: ");
//         this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhap Phu cap: ");
//         this.PhuCap = Convert.ToDouble(Console.ReadLine());
//     }
//     public virtual void Nhap(string hoTen, int cMND, int namSinh, double luongCoBan, double phuCap)
//     {
//         this.HoTen = hoTen;
//         this.CMND = cMND;
//         this.NamSinh = namSinh;
//         this.LuongCoBan = luongCoBan;
//         this.PhuCap = phuCap;
//     }
//     public override void Xuat()
//     {
//         Console.WriteLine("Ho ten: " + this.sHoTen);
//         Console.WriteLine("CMND: " + this.iCMND);
//         Console.WriteLine("Nam sinh: " + this.iNamSinh);
//         Console.WriteLine("Luong co ban: " + this.dLuongCoBan);
//         Console.WriteLine("Phu cap: " + this.dPhuCap);
//         Console.WriteLine("Luong: " + this.dLuong);
//     }

//     public override void TinhLuong()
//     {
//         this.dLuong = this.dLuongCoBan + this.dPhuCap;
//     }
// }


// public class NVKinhDoanh : NhanVien
// {
//     public double dPhuCap;
//     public int iSoHopDong;
//     public double PhuCap
//     {
//         get { return this.dPhuCap; }
//         set { this.dPhuCap = value; }
//     }
//     public int SoHopDong
//     {
//         get { return this.iSoHopDong; }
//         set { this.iSoHopDong = value; }
//     }
//     public NVKinhDoanh(double phuCap, int soHopDong)
//     {
//         this.PhuCap = phuCap;
//         this.SoHopDong = soHopDong;
//     }
//     public NVKinhDoanh() { }
//     ~NVKinhDoanh() { }

//     public override void Nhap()
//     {
//         Console.WriteLine("Nhap ho ten: ");
//         this.HoTen = Console.ReadLine();
//         Console.WriteLine("Chung minh nhan dan: ");
//         this.CMND = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap nam sinh: ");
//         this.NamSinh = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap luong co ban: ");
//         this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhap Phu cap: ");
//         this.PhuCap = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhap So hop dong: ");
//         this.SoHopDong = Convert.ToInt32(Console.ReadLine());
//     }

//     public virtual void Nhap(string hoTen, int cMND, int namSinh, double luongCoBan, double phuCap, int soHopDong)
//     {
//         this.HoTen = hoTen;
//         this.CMND = cMND;
//         this.NamSinh = namSinh;
//         this.LuongCoBan = luongCoBan;
//         this.PhuCap = phuCap;
//         this.SoHopDong = soHopDong;
//     }

//     public override void Xuat()
//     {
//         Console.WriteLine("Ho ten: " + this.sHoTen);
//         Console.WriteLine("CMND: " + this.iCMND);
//         Console.WriteLine("Nam sinh: " + this.iNamSinh);
//         Console.WriteLine("Luong co ban: " + this.dLuongCoBan);
//         Console.WriteLine("Phu cap: " + this.dPhuCap);
//         Console.WriteLine("So hop dong: " + this.iSoHopDong);
//         Console.WriteLine("Luong: " + this.dLuong);
//     }

//     public override void TinhLuong()
//     {
//         this.dLuong = this.dLuongCoBan + (this.dPhuCap * this.iSoHopDong);
//     }
// }


// public class NVBaoVe : NhanVien
// {
//     public double dPhuCap;
//     public int iSoHopDong;
//     public int iCaDangKyViecLam;
//     public double PhuCap
//     {
//         get { return this.dPhuCap; }
//         set { this.dPhuCap = value; }
//     }
//     public int SoHopDong
//     {
//         get { return this.iSoHopDong; }
//         set { this.iSoHopDong = value; }
//     }
//     public int CaDangKyLamViec
//     {
//         get { return this.iCaDangKyViecLam; }
//         set { this.iCaDangKyViecLam = value; }
//     }
//     public NVBaoVe(double phuCap, int soHopDong, int soCaDangKyLamViec)
//     {
//         this.PhuCap = phuCap;
//         this.SoHopDong = soHopDong;
//         this.CaDangKyLamViec = soCaDangKyLamViec;
//     }
//     public NVBaoVe() { }
//     ~NVBaoVe() { }

//     public override void Nhap()
//     {
//         Console.WriteLine("Nhap ho ten: ");
//         this.HoTen = Console.ReadLine();
//         Console.WriteLine("Chung minh nhan dan: ");
//         this.CMND = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap nam sinh: ");
//         this.NamSinh = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap luong co ban: ");
//         this.LuongCoBan = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhap Phu cap: ");
//         this.PhuCap = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Nhap So hop dong: ");
//         this.SoHopDong = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Nhap so ca dang ky lam viec: ");
//         this.CaDangKyLamViec = Convert.ToInt32(Console.ReadLine());
//     }

//     public virtual void Nhap(string hoTen, int cMND, int namSinh, double luongCoBan, double phuCap, int soHopDong, int soCaDangKyLamViec)

//     {
//         this.HoTen = hoTen;
//         this.CMND = cMND;
//         this.NamSinh = namSinh;
//         this.LuongCoBan = luongCoBan;
//         this.PhuCap = phuCap;
//         this.SoHopDong = soHopDong;
//         this.CaDangKyLamViec = soCaDangKyLamViec;
//     }

//     public override void Xuat()
//     {
//         Console.WriteLine("Ho ten: " + this.sHoTen);
//         Console.WriteLine("CMND: " + this.iCMND);
//         Console.WriteLine("Nam sinh: " + this.iNamSinh);
//         Console.WriteLine("Luong co ban: " + this.dLuongCoBan);
//         Console.WriteLine("Phu cap: " + this.dPhuCap);
//         Console.WriteLine("So hop dong: " + this.iSoHopDong);
//         Console.WriteLine("Luong: " + this.dLuongCoBan);
//     }

//     public override void TinhLuong()
//     {
//         this.dLuong = this.dLuongCoBan;
//     }
// }

// class CongTy
// {
//     public string sTenCongTy;
//     public List<NhanVien> lNV;

//     public string TenCongTy
//     {
//         get { return this.sTenCongTy; }
//         set { this.sTenCongTy = value; }
//     }

//     // Constructor
//     public CongTy()
//     {
//         this.lNV = new List<NhanVien>();
//     }

//     public CongTy(string tenCongTy)
//     {
//         this.TenCongTy = tenCongTy;
//         this.lNV = new List<NhanVien>();
//     }

//     ~CongTy() { }

//     public void Nhap()
//     {
//         Console.WriteLine("Nhap ten cong ty: ");
//         this.TenCongTy = Console.ReadLine();
//     }

//     public void Xuat()
//     {
//         Console.WriteLine("Ten Cong Ty: " + this.TenCongTy);
//     }

//     // Thêm nhân viên vào công ty
//     public void ThemNhanVien(NhanVien nv)
//     {
//         this.lNV.Add(nv);
//     }

//     // Nhập toàn bộ nhân viên
//     public void NhapNhanVien()
//     {
//         foreach (NhanVien nv in this.lNV)
//         {
//             nv.Nhap();
//             nv.TinhLuong();
//         }
//     }

//     // Xuất toàn bộ nhân viên
//     public void XuatNhanVien()
//     {
//         foreach (NhanVien nv in this.lNV)
//         {
//             nv.Xuat();
//         }
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         CongTy ct = new CongTy();
//         ct.Nhap();

//         NhanVien a = new NVKeToan();
//         NhanVien b = new NVKinhDoanh();
//         NhanVien c = new NVBaoVe();

//         ct.ThemNhanVien(a);
//         ct.ThemNhanVien(b);
//         ct.ThemNhanVien(c);

//         ct.NhapNhanVien();

//         ct.Xuat();
//         ct.XuatNhanVien();

//     }
// }

