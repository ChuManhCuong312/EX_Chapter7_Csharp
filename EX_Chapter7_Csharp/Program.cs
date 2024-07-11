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

        // Kiểm tra xem một khóa có tồn tại trong từ điển hay không
        string keyToCheck = "Banana";
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
        if (myDictionary.TryGetValue("Cherry", out value))
        {
            Console.WriteLine($"Giá trị liên kết với khóa 'Cherry' là {value}.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy khóa 'Cherry' trong từ điển.");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong từ điển và in chúng
        Console.WriteLine("Các cặp khóa-giá trị trong từ điển:");
        foreach (KeyValuePair<string, int> kvp in myDictionary)
        {
            Console.WriteLine($"Khóa: {kvp.Key}, Giá trị: {kvp.Value}");
        }
    }
}
