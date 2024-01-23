using System;

// Lớp cha SanPham
class SanPham
{
    protected string _ten;
    protected double _giaMua;

    public string Ten => _ten;
    public double GiaMua
    {
        get => _giaMua;
        set
        {
            if (value >= 0)
                _giaMua = value;
            else
                Console.WriteLine("Gia tri gia mua phai lon hon hoac bang 0.");
        }
    }

    public SanPham()
    {
    }

    public SanPham(string ten, double giaMua)
    {
        _ten = ten;
        GiaMua = giaMua;
    }

    public virtual double TinhGiaBan()
    {
        return 0;
    }

    public virtual string InChiTiet()
    {
        return _ten;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ten san pham: ");
        _ten = Console.ReadLine();
        Console.Write("Nhap gia mua: ");
        GiaMua = Convert.ToDouble(Console.ReadLine());
    }
}

// Lớp con Socola kế thừa từ SanPham
class Socola : SanPham
{
    private double _loiNhuan;

    public Socola() : base()
    {
        _loiNhuan = GiaMua * 0.2;
    }

    public Socola(string ten, double giaMua) : base(ten, giaMua)
    {
        _loiNhuan = GiaMua * 0.2;
    }

    public override double TinhGiaBan()
    {
        return GiaMua + _loiNhuan;
    }

    public override string InChiTiet()
    {
        return $"{_ten} - Gia ban: {TinhGiaBan()}";
    }

    public override void Nhap()
    {
        base.Nhap();
    }
}

// Lớp con NuocUong kế thừa từ SanPham
class NuocUong : SanPham
{
    private double _loiNhuan;
    private double _chiPhiGiuLanh;

    public NuocUong() : base()
    {
        _loiNhuan = GiaMua * 0.15;
        _chiPhiGiuLanh = GiaMua * 0.1;
    }

    public NuocUong(string ten, double giaMua) : base(ten, giaMua)
    {
        _loiNhuan = GiaMua * 0.15;
        _chiPhiGiuLanh = GiaMua * 0.1;
    }

    public override double TinhGiaBan()
    {
        return GiaMua + _loiNhuan + _chiPhiGiuLanh;
    }

    public override string InChiTiet()
    {
        return $"{_ten} - Gia ban: {TinhGiaBan()}";
    }

    public override void Nhap()
    {
        base.Nhap();
    }
}

// Lớp QuanLySanPham
class QuanLySanPham
{
    private string _ten;
    private SanPham[] _danhSachSP;

    public QuanLySanPham()
    {
        _ten = "Cua Hang Ban Le";
    }

    public void Nhap()
    {
        Console.Write("Nhap so luong san pham: ");
        int n = Convert.ToInt32(Console.ReadLine());

        _danhSachSP = new SanPham[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap loai san pham (Socola/NuocUong) #{i + 1}: ");
            string loaiSP = Console.ReadLine();

            if (loaiSP.ToLower() == "socola")
            {
                _danhSachSP[i] = new Socola();
            }
            else if (loaiSP.ToLower() == "nuocuong")
            {
                _danhSachSP[i] = new NuocUong();
            }

            _danhSachSP[i].Nhap();
        }
    }

    public void InDanhSachSP()
    {
        Console.WriteLine($"Danh sach san pham tai {_ten}:");
        foreach (var sp in _danhSachSP)
        {
            Console.WriteLine(sp.InChiTiet());
        }
    }
}

// Lớp Program
class Program
{
    static void Main()
    {
        QuanLySanPham quanLySP = new QuanLySanPham();
        quanLySP.Nhap();
        quanLySP.InDanhSachSP();
        Console.ReadLine();
    }
}
