using System;

namespace Calculator
{
  class Program
  {
    /// <summary>
    /// 4080105 - Lập trình .NET 1 + BTL
    /// GV: Trần Trung Chuyên, email: trantrungchuyen@humg.edu.vn
    /// 01. Calculator - Các phép toán với hai số nguyên
    /// Mục tiêu:
    /// - Hiểu cách thực thi ứng dụng với tham số args
    /// - Biết cách chuyển chuỗi thành số có kiểm soát lỗi
    /// - Ôn lại điều kiện rẽ nhánh và điều kiện lặp
    /// - Biết trình bày kết quả ra màn hình
    /// - Biết tách một chuỗi thành các chuỗi con
    /// - Biết sử dụng biến thường và biển mảng
    /// </summary>
    /// <param name="args">Tham số khi chạy chương trình</param>
    static void Main(string[] args)
    {
      // Mã hóa output theo Unicode
      Console.OutputEncoding = System.Text.Encoding.UTF8;

      Console.WriteLine("Các phép toán với hai số nguyên\r");
      Console.WriteLine("-------------------------------\n");

      // Khai báo các biến và khởi tạo giá trị ban đầu là 0.
      int num1 = 0; int num2 = 0;
      bool success = false;

      // Kiểm tra tham số khi chạy chương trình.
      // Thiết lập ở Project Properties > Debug > Application arguments, ví dụ: 3 2
      // hoặc thực thi chương trình Calculator với tham số. Ví dụ: Calculator.exe 3 2
      if (args.Length >= 2)
      {
        // Cố gắng chuyển các chuỗi tham số thành số
        success =
            Int32.TryParse(args[0], out num1) &&
            Int32.TryParse(args[1], out num2);
      }
      if (success)
      {
        Console.WriteLine($"Kết quả: {num1} + {num2} = " + (num1 + num2));
        Console.WriteLine($"Kết quả: {num1} - {num2} = " + (num1 - num2));
        Console.WriteLine($"Kết quả: {num1} * {num2} = " + (num1 * num2));
        if (num2 != 0)
        {
          Console.WriteLine($"Kết quả: {num1} / {num2} = " + (num1 / num2));
        }
        else
        {
          Console.WriteLine($"Kết quả: {num1} / {num2} = Lỗi chia cho 0!");
        }
      }
      else
      {
        // Trường hợp chương trình không có tham số khi chạy
        // thì yêu cầu nhập vào từ bàn phím hai số nguyên.
        while (!success)
        {
          Console.Write("Nhập vào hai số nguyên: ");

          // Đọc một chỗi nhập vào từ bàn phím sau đó tách thành mảng bằng hàm Split
          string[] s = Console.ReadLine().Split(' ');

          if (s.Length >= 2)
          {
            // Cố gắng chuyển các chuỗi tham số thành số
            success =
                Int32.TryParse(s[0], out num1) &&
                Int32.TryParse(s[1], out num2);
            if (success)
            {
              Console.WriteLine($"Kết quả: {num1} + {num2} = " + (num1 + num2));
              Console.WriteLine($"Kết quả: {num1} - {num2} = " + (num1 - num2));
              Console.WriteLine($"Kết quả: {num1} * {num2} = " + (num1 * num2));
              if (num2 != 0)
              {
                Console.WriteLine($"Kết quả: {num1} / {num2} = " + (num1 / num2));
              }
              else
              {
                Console.WriteLine($"Kết quả: {num1} / {num2} = Lỗi chia cho 0!");
              }
            }
            else
            {
              Console.WriteLine("Dữ liệu nhập không phải là số, vui lòng nhập lại");
            }
          }
          else
          {
            Console.WriteLine("Dữ liệu nhập bị thiếu, vui lòng nhập lại");
          }
        }
      }
    }
  }
}