namespace ConsoleApp5
    // đinh nguyễn hoàng vũ
    // bắt đầu làn bài tính tiền điện
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float soKwh, tienDien = 0;

            // Nhập số điện
            Console.WriteLine("Nhap so kWh dien tieu thu: ");
            soKwh = float.Parse(Console.ReadLine());

            // Tính tiền 
            if (soKwh <= 50)
            {
                tienDien = soKwh * 1500;
            }
            else if (soKwh <= 100)
            {
                tienDien = 50 * 1500 + (soKwh - 50) * 2000;
            }
            else
            {
                tienDien = 50 * 1500 + 50 * 2000 + (soKwh - 100) * 2500;
            }

            // Hiển thị kết quả
            Console.WriteLine("So tien dien phai tra = {0} VND", tienDien);
            Console.ReadKey();
        }
    }
}
