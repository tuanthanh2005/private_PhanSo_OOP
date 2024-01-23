using System;

class Vehicle
{
    private string brand;
    private double vehicleValue;
    private double engineCapacity;

    public Vehicle(string brand, double vehicleValue, double engineCapacity)
    {
        this.brand = brand;
        this.vehicleValue = vehicleValue;
        this.engineCapacity = engineCapacity;
    }

    public string Brand
    {
        get { return brand; }
    }

    public double VehicleValue
    {
        get { return vehicleValue; }
    }

    public double EngineCapacity
    {
        get { return engineCapacity; }
    }

    public double CalculateTax()
    {
        if (engineCapacity < 100)
        {
            return 0.01 * vehicleValue;
        }
        else if (engineCapacity >= 100 && engineCapacity <= 200)
        {
            return 0.03 * vehicleValue;
        }
        else
        {
            return 0.05 * vehicleValue;
        }
    }
}

class Program
{
    static void Main()
    {
        Vehicle xe1 = new Vehicle("Xe A", 50000, 80);
        Vehicle xe2 = new Vehicle("Xe B", 80000, 150);
        Vehicle xe3 = new Vehicle("Xe C", 120000, 250);

        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Nhập thông tin và tạo các đối tượng xe1, xe2, xe3");
            Console.WriteLine("2. Xuất bảng kê khai tiền thuế trước bạ của các xe");
            Console.WriteLine("3. Thoát");
            Console.Write("Chọn công việc (1-3): ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Bạn có thể thêm logic để nhập thông tin xe ở đây.
                        Console.WriteLine("Nhập thông tin xe1:");
                        Console.Write("Nhãn hiệu: ");
                        string brand1 = Console.ReadLine();
                        Console.Write("Trị giá xe: ");
                        double value1 = double.Parse(Console.ReadLine());
                        Console.Write("Dung tích xylanh: ");
                        double capacity1 = double.Parse(Console.ReadLine());
                        xe1 = new Vehicle(brand1, value1, capacity1);

                        Console.WriteLine("Nhập thông tin xe2:");
                        Console.Write("Nhãn hiệu: ");
                        string brand2 = Console.ReadLine();
                        Console.Write("Trị giá xe: ");
                        double value2 = double.Parse(Console.ReadLine());
                        Console.Write("Dung tích xylanh: ");
                        double capacity2 = double.Parse(Console.ReadLine());
                        xe2 = new Vehicle(brand2, value2, capacity2);

                        Console.WriteLine("Nhập thông tin xe3:");
                        Console.Write("Nhãn hiệu: ");
                        string brand3 = Console.ReadLine();
                        Console.Write("Trị giá xe: ");
                        double value3 = double.Parse(Console.ReadLine());
                        Console.Write("Dung tích xylanh: ");
                        double capacity3 = double.Parse(Console.ReadLine());
                        xe3 = new Vehicle(brand3, value3, capacity3);

                       
                        break;
                    case 2:
                        Console.WriteLine("Bảng kê khai tiền thuế trước bạ của các xe:");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("|    Xe    |  Trị Giá Xe  |  Dung Tích Xylanh  |  Thuế Trước Bạ  |");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine($"|  {xe1.Brand,-6}  |  {xe1.VehicleValue,-14:C}  |  {xe1.EngineCapacity,-10}  |  {xe1.CalculateTax(),-12:C}  |");
                        Console.WriteLine($"|  {xe2.Brand,-6}  |  {xe2.VehicleValue,-14:C}  |  {xe2.EngineCapacity,-10}  |  {xe2.CalculateTax(),-12:C}  |");
                        Console.WriteLine($"|  {xe3.Brand,-6}  |  {xe3.VehicleValue,-14:C}  |  {xe3.EngineCapacity,-10}  |  {xe3.CalculateTax(),-12:C}  |");
                        Console.WriteLine("-------------------------------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
            }

        } while (choice != 3);
    }
}
