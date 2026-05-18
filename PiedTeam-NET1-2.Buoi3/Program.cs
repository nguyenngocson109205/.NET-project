namespace PiedTeam_NET1_2.Buoi3;

class Program
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        
        // Instance Variable - BÊISN MÀ DÙNG ĐỂ LƯU INFO CỦA 1 OBJECT
        
        // BACK-FIELD, DAGTA FIELD - BIẾN MÀ DÙNG ĐỂ LƯU TRỮ INFO CỦA 1 OBJECT (tên gọi của C#)
        
        // nếu không ghi public, private, (không khai báo access modifier) thì mặc định là private
        
        // private string _id = "123"
        
        // DEFAULT VALUE 
        // khi mà mình khởi tạo 1 fiedld không khởi tạo gì cả thì field sẽ có giá trị mặc định
        // string: ""
        // int: 0
        // bool: false
        // object: null
        // array: null 
        
        // CONSTRUCTOR - KHỞI TẠO DỮ LIỆU
        // khi có nhiều contrustor thì sẽ tùy vào bao nhiêu tham số truyền vào thì sẽ gọi là overloading 
        // public Student(string id, string name, int yob)
        // {
        //     _id = id;
        //     _name = name;
        //     _yob = yob;
        // }
        //empty construcotr là sẽ tự động đc tạo 
        
        // GET A DATA FIELD
        // Traditional Style
        public string GetName()
        {
            // mặc dù _name private nhưng vì ở trong phạm vi class, thì chúng ta vẫn lấy đ
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }
        
        
        
        // .NET cũng cung cấp 1 cái để có thể viết hàm tiện hơn - Expression Body
            // khi body của một hàm chỉ có một câu lệnh duy nhất có thẻ viết gọn như sau
            
            public static string Id { set; get; }
            public string Name { set; get; }
            public int Yob { set; get; }
            public Student(string Id, string Name, int Yob)
            {
                Id = Id;
                Name = Name;
                Yob = Yob;
            }
        public string GetNameV2() => _name;
        public void SetNameV2(string name) => _name = name;
        public void ShowProfile() =>  Console.WriteLine($"{_id} - {_name}");
        
        
        
        // khi mà viết private string _ID { set; get; } sẽ làm gì 
        // private string _ID;
        // nó sẽ viết 2 hàm get set ở bên dưới 
        // public void ShowProfile() => Console.WriteLine($"{_id} - {_name}");
        
        // Định nghĩa về Static
        // "Static giống như 1 thằng ngồi ở trên xemc ác thằng kahcs đánh nhau
        // thằng static ra vùng khác rồi (cấp phát vùng nhớ riêng )
        // nhuư v ID ngồi đây, Main ngồi đyaa
        // cái nào mà ăn theo Object thì không sử dụng Static (Đã demo case s1 và s2)
            // ví dụ 
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        // 4 tính chất cơ bản của oop
            // 1. Encapsulation (tính đóng gói)
                // đóng gói những thuốc tính, method và 1 class hoàn chỉnh, 1 cái 
                // cung cấp khả năng modularity (model hóa, chia nhỏ ra, dễ quản lí )
                // bảo vệ tính toàn diện của dữ liệu chỉ có thể truy cập thôgn qua access modifier(public, private, protected)
            // 2. Inheritances(kế thừa )
                // đề cập đến khả năng kế thừa, tài sử dụng code cũ
                // khi class B kế thừa class A, thì class B sẽ chứa code riêng của nó
                    // chúa cả code của class A. Code ở đay là Property và medthod
            // 3.Polymorphism (đa hình)
                // đề cập đến khả năng thể hiện của các calss và action theo nhiều khác nhau
                // ví dụ các Interface, Abstract Class, Class thông q   ua việc Implement các Interface
                // mỗi class sẽ thể hiện bản sắc riêng (implment method) của nso khi mà kế từa hoắc implement
                // tính đa hình này là một tính chất CỰC KÌ CỰC KÌ quan trọng tronng việc hình thành 
                // 1 công nghệ lỗi của .NET(Dependency Injection)
            // 3.Abstraction (trừ tượng)
                // biến những thứ phức tạp thành những thứ cơ bản mà không mất chất
                // viis dụ: 1 học sinh thì có những tính chất mơ hồ như: tên tưởi, năm sinh, các loại hành động
                    // như là học. việc chơi như thế nào, học như thế nào, thì từ từ. Thì những thứ phức tạp
                    // tạo ở đây là những hành động cụ thể như là chơi thế nào, rõ ràng cụ thể hơn
                    // chung quy lại học sinh chỉ có những hành động cơ bản như là chơi với học (Abstract method)

        Student s1 = new Student(Id: "123", Name: "An", Yob: 2005);
        s1.ShowProile();
        
        
    }
}