using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MophongFCFS_SJF
{
    public class TienTrinh
    {
        public int ID { get; set; } // ID của tiến trình
        public int ArrivalTime { get; set; } // thời gian đến của tiến trình
        public int BurstTime { get; set; } // Thời gian CPU burst
        public int WaitTime { get; set; } // Thời gian chờ của tiến trình
        public int FinishTime { get; set; } // Thời gian kết thúc của tiến trình
        public int TurnaroundTime { get; set; } // Thời gian hoàn thành của tiến trình ( 1 khoảng thời gian tính từ lúc tiến trình đến cho tới khi tiến trình kết thúc) , được tính bằng FinishTime - ArrivalTime
        public TienTrinh(int id=0, int arrivalTime = 0, int burstTime = 0)  // Phương thức khởi tạo tiến trình
        {
            ID = id;
            ArrivalTime = arrivalTime;
            BurstTime = burstTime;
        }
        public void NhapArrivalTime() // Phương thức Nhập tiến trình
        {
            bool kt = false;
            do
            {   // Xử lý ngoại lệ nếu không nhập giá trị số
                try
                {
                    //Console.Write("Nhap Arrival Time: ");
                    ArrivalTime = int.Parse(Console.ReadLine());
                    kt = true;
                    if (ArrivalTime < 0)
                    {
                        Console.WriteLine("Vui long nhap lai thoi gian den (ArrivalTime>=0)");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui long nhap gia tri so!");
                }
            } while (kt == false || ArrivalTime < 0); // Kiểm tra nếu giá trị nhập vào không phải số hoặc ArrivalTime nhỏ hơn < 0 thì nhập lại
        }
        public void NhapBurstTime() // Phương thức Nhập Burst Time cho tiến trình
        {
            bool kt = false;
            do
            {   // Xử lý ngoại lệ nếu không nhập giá trị số
                try
                {
                    //Console.Write("Nhap Burst Time: ");
                    BurstTime = int.Parse(Console.ReadLine());
                    kt = true;
                    if (BurstTime < 0)
                    {
                        Console.WriteLine("Vui long nhap lai Burst Time (Burst Time>0)");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui long nhap gia tri so!");
                }
            } while (kt == false || BurstTime <= 0);  // Kiểm tra nếu giá trị nhập vào không phải số hoặc ArrivalTime nhỏ hơn < 0 thì nhập lại     
        }
    }  // End of class Tien Trinh
}
