namespace PiedTeam_NET1_2.Buoi2;

    class Program
    {
        static void Main(string[] args)
        {   
            // có 2 kiểu dữ liệu trong lập trình đó là
            // primitive và object 
            // value type và (primitive type và reference type (object) 

            // int a = 3;
            // int b = 4;
            // int c = a + b;
            // Console.WriteLine(c);
            
            // khi mà một cái biến được khớit tạo nó sẽ được đè cập đến hai vùng nhớ stack hoặc là heap 
            // sẽ giản kĩ hơn ở bên dưới 
                
            //References type 
                // string 
                // mảng 
                // class 
                // interface
                
            
            // class và object khác nhau chỗ nào
                // object là một thể hiện của một class (intances) ví dụ khi nhắc tới class học sinh, 
                // thì chúng ta sẽ có các THỂ HIỆN như là học sinh Tân học sinh Bình học sinh Khoa
                // class có thể coi như là một cái khuôn cái khuôn này bên trong có thuộc tính phương thức 
                // 
                
            //khi ValueType thì có mấy vùng nhớ được sử dụng 
            //int d = 3; biến d là biến cục bộ được lưu trên STACK
            // theo mng lưu theo kiểu value type có được lưu trong heap không
            // --> có  vì khi kbai báo 1 filed có kiểu là value nằm trong class
            
            // Class Student
            // {
            //     name
            //     age
            //         
            // }
            // student tan = new Student();
            //
            // student p1 = new Student();
            // student p1 = p2;
            
            // p1 và p2 sẽ nằm trong stack và sẽ cùng trỏ tới cùng object năm trên heap 
            
            // mọi người hiểu như thế nào về static
                // static là một vùng nhớ đặc biệt nằm riêmg biệt so với stack và heap và là một
                // vùng nhớ xài chung đc cấp phát và tồn tại suốt vòng đời 


                int a = 10;
                int b = 20;
                
                // Traditional style 
                Console.WriteLine("Number a = " + a);
                Console.WriteLine("Number b = " + b);
                
                //Modern Style - Place hoder 
                
                Console.WriteLine($"Number a = {a}");
                Console.WriteLine($"Number b = {b}");
                Console.WriteLine($"Number a + b = {a + b}");
                
                Console.WriteLine($"Number a = {0}", a);
                Console.WriteLine($"Number b = {0}", b);
                
                // Function method 
                // có 4 kiểu hàm 
                
                // Pass by value 
                // a chỉ mượn giá trị của x thôi a là biến cục bộ
                static void PassByValue(int a)
                {
                    a = 100;
                    Console.WriteLine(a);
                }

                int x = 1;
                PassByValue(x);
                // pass by references
                // C# nó cung cấp thêm 2 món lạ cung cấp đén tham số của hàm 
                // tham số truyền vào là một con trỏ
                // out: trả ra giá trị thông qua biến out | trong 1 hàm có thể có nhiều out nhưng chỉ có thể có 1 return
                
                // ref: truyền vào một biến có sẵn, hàm có thể thay đổi giá trị của biến đó
                // 2 thằng này giúp mở rộng ciệc của 1 cái hàm 
                // define Ref:
                    // nó giống con trỏ trong C
                    // Thay đổi ở ngoài thì trong hàm cũng thay đổi và ngược lại 
                    // khi chơi với giá trị ref thì bắt buộc:
                        // phải có cái biến đó trước khi truyền (phải khai báo giá trị)s

                        static void PassByRef(ref int a)
                        {
                            a = 100;
                        }

                        int p = 10;
                        Console.WriteLine("Before PassByValue, a = " + a);
                        PassByOut(out p);
                        Console.WriteLine("After PassByValue, p = " + p);
                        
                        

            // out 
            
            // khi choiw với out bắt buọc bên trong phải sửa lại tham số
                // sửa lại giá trị biến out 
            // tui sẽ guiatrar ra cho bạn một con số 
            static void PassByOut(out int a)
            {
                a = 100;
            }

            int n = 10;
            PassByOut(out n);
            Console.WriteLine("After PassByOut, a = " + n);
            
            // viết một hàm tính tổng cáo số chẵn là số lượng các số chẵn từ 1 đến n và cấm dùng return nhưng vẫn lấy đc 2 kq
                static void TotalCount(int n, out int sum, out  int totalNumber)
                {
                    totalNumber = 0;
                    sum = 0;
                    for (int i = 2; i <= n; i+=2)
                    {   
                        totalNumber += 1;
                        sum += i;
                    }
                }

                int sum = 0;
                int totalNumber = 0;
                TotalCount(n:10,out sum, out totalNumber);
                Console.WriteLine("TotalCount = " + totalNumber + "; Sum = " + sum);
                
                
               
                    
        }
    }