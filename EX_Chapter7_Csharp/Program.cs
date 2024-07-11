using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Tạo một từ điển với kiểu khóa là string và kiểu giá trị là int
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Thêm một số giá trị cặp khóa cho từ điển
        myDictionary.Add("Apple", 5);
        myDictionary.Add("Banana", 10);
        myDictionary.Add("Cherry", 15);
        myDictionary.Add("Grapes", 20);
        myDictionary.Add("Orange", 25);
        myDictionary.Add("Pineapple", 30);
        myDictionary.Add("Mango", 35);
        myDictionary.Add("Peach", 40);
        myDictionary.Add("Watermelon", 45);

        // Nhập từ khóa cần kiểm tra từ người dùng
        Console.Write("Nhập từ khóa cần kiểm tra: ");
        string keyToCheck = Console.ReadLine();

        // Kiểm tra xem khóa có tồn tại trong từ điển hay không
        if (myDictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Khóa '{keyToCheck}' tồn tại trong từ điển.");
        }
        else
        {
            Console.WriteLine($"Khóa '{keyToCheck}' không tồn tại trong từ điển.");
        }

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn
        int value;
        if (myDictionary.TryGetValue(keyToCheck, out value))
        {
            Console.WriteLine($"Giá trị liên kết với khóa '{keyToCheck}' là {value}.");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy khóa '{keyToCheck}' trong từ điển.");
        }

        // In ra các cặp khóa-giá trị trong từ điển
        Console.WriteLine("Các cặp khóa-giá trị trong từ điển:");
        foreach (KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine($"Khóa: {kvp.Key}, Giá trị: {kvp.Value}");
        }
    }
}
