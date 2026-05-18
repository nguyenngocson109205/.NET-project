namespace PiedTeam_NET1_2.Buoi3._1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
         public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } = " ";

    }

    public class ProductDto
    {
        public string ProductName { get; set; } = " ";
        public decimal ProductPrice { get; set; }
        public string Category { get; set; } = " ";
    }

    List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "iPhone 15", Price = 25000, Category = "Điện thoại" },
        new Product { Id = 2, Name = "Samsung S24", Price = 22000, Category = "Điện thoại" },
        new Product { Id = 3, Name = "MacBook Air", Price = 32000, Category = "Laptop" },
        new Product { Id = 4, Name = "Dell XPS", Price = 28000, Category = "Laptop" },
        new Product { Id = 5, Name = "AirPods Pro", Price = 6500, Category = "Phụ kiện" },
        new Product { Id = 6, Name = "Galaxy Buds", Price = 4500, Category = "Phụ kiện" }
    };

    // LINQ, 1 trong những công cụ mạnh mẽ nhất của C# để xử lí dữ liệu
    // phần core, cái này không biết thì không làm .NET đc 

    // LINQ (Language Integrated Query) là một phần của .NET Framework.
    // cung cấp một cách tiếp cận mạnh mẽ và
    // linh hoạt đê truy vấn và thao tác dữ liệu từ 
    // nhiều nguồn khác nhau (như collections, databases, XML,...
    // bằng cách sử dụng cú pháp giống SQL nhưng tích hợp  trực tiếp 
    // vào trong chương trình C#

    /*
     * Trước đay khi chưa có LINQ:
     * Muốn query databae -> Viết SQL (Select * from Product)
     * Muốn lọc 1 danh sách -> thì viết dòng for -> sau đó if élse dể lấy ra
     * với mỗi nguồn dữ liệu, phải sử dụng những cách khác nhau
     *
     * Sau khi cí LINQ:
     * viêt truy vấn database bằng ngôn ngữ cú pháp C luôn
     * viết 1 kiểu thôi, nhưng mà kiẻu này có thêt truy vấn từ nhiều nguồn
     * (SQL, Collection)
     */

    List<int> list = [1, 2, 3, 4, 5];

    List<int> ListResult = []; // láy ra mãng số chẵn
    // truơcs khi sử dụng LINQ:
    // foreach ( var item int list)
    // {
    //     if (item % 2 == 0)
    //     {
    //         listResult.add(item)
    //     }
    // }




    // sau khi sửu dụng LINQ:

    ListResult = List.Where(x => x %2 == 0).Tolist();
        foreach (var item in ListReult)
    {
        Console.WriteLine((item));
    }

    // LINQ cos 2 dạng chính: LINQ to Object, LINQ to SQL
    // LINQ to Object:
    // dùng để query các Collection: List, Array, Dictionary, v.vv
    // listResult = list.Where(x => x % 2 == 0). ToList()

    // LINQ to SQL
        // LINQ + Entity Framework kết hợp lại, để query Database
        // Giúp người dùng có thể truy vấn dữ liệu bằng ngôn ngữ C# luôn
        // Khi mình viết code C#, EF sẽ convert code C# sang SQL giúp mình 
        // ví dụ: _dbContext.Users.Where(x => x.FirstName.Contains("abc")
        // viét câu lệnh SQL tìm những User có first name chứa abc
        
    // Benefit: 
        // dẽ đọc dễ hiểu, chỉ cần tập trung vào 1 ngôn ngữ thôi tránh lan man 
        // truy vẫn từ nhiều nguồn 
        // dễ dàng trong việc phát triển không tuy vấn sai 
            // khi mình viết SQL thì nó là String
            // có thể viết sai chinhs ta 
                // sai tên cột tên table 
            // Còn khi mình viết bằng code thì mình chỉ việc . ra sài thôi không cần care tới sai chính tả 
            
            // trong LINQ, muốn truy vấn theo điều kiện nào thì chấm ra xài thôi 
            
            // có 2 trường phái viết LINQ
            
            /*
             * 1. LINQ Query Syntax (cú pháp truy vấn )
             *      kiểu này nó giuống hệt SQL nhưng viết trong C#
             * var result = from p in products where p.Name.Contain("abc")
             * 2. LINQ Method syntax (cú pháp truy vấn)
             * var result = product.Where(p => p.Name.Contain("abc"));
             */
            
            // Deferred Execution (lazy loading) và Immediate Execution (Eager Loading)
            
            /*
             * Deferred Execution (lazy loading)
             * - LINQ sẽ không chạy ngay khi bạn vừa viết xong
             * - Nó chỉ hỗ trợ xây dụng 1 biểu thức (Expression) 1 - Bảng kế hoạch
             * - và chờ đến khi bạn duyệt (Interate) thì nó mới thực thi bảng kế hoạch
             * + Từ duyệt (Interate) này thể hiện chỗ nào. For, ForEach
             * 
             */
            List<int> demoDeferredExecution = [1, 2, 3, 4, 5];
            var filterẸnumericaln = demoDeferredExecution.Where(item => item % 2 == 0);
            
            // foreach (var item in list)
            // {
            //     if (item % 2 == 0)
            //     {
            //         listResult.Add(item) 
            //     }
            // }
            
            // 2. 4
            
            // filters nó là một bảng kế hoạch, chờ đợi để được duyệt và trả ra kế hoạch 
            // còn đối với tương tác database, thì nó đc coi là 1 câu 
                // Query nóng hỏio, vừa đc viết ra, nhưng chưa đc thực thi 
                
            // tại sao mình lại defred vậy víf
            
            /*
             * Deferred Query Operator phổ biến
             * Where // truy vấn điều kiện
             * Select // truy vấn để lấy ra một kiểu dữ liệu khác
             * OrderBy // sắp xếp thứ tự 
             * GroupBy // nhóm dữ liệu
             * Join // kết hợp dữ liệu
             * Skip, SkipWhite // bỏ qua 
             * Take, TakeWhite // láy
             * Distinct
             * 
             *  * -> Mấy thằng trên trả về IEnumerable hoặc IQueryable // Trong tương lai sẽ biết
             */
            
            
            /*
             * Immediate Execution (Eager Loading)
             * - Query trả ra kết quả ngay lập tức khi gọi phương thức
             *
             * Chỉ có ít số ít các phương thức sẽ kích hoạt việc thực thi Query
             * ToList(), ToArray(), ToDictionary(), Count(), ... Trả ra 1 collection hoặc 1 giá trị (Count) ngay lập tức
             * FirstOrDefault(), First(), SingleOrDefault(), Single(), ... Trả ra phần tử đầu tiên
             */
            
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Price = 25000, Category = "Điện thoại" },
                new Product { Id = 2, Name = "Samsung S24", Price = 22000, Category = "Điện thoại" },
                new Product { Id = 3, Name = "MacBook Air", Price = 32000, Category = "Laptop" },
                new Product { Id = 4, Name = "Dell XPS", Price = 28000, Category = "Laptop" },
                new Product { Id = 5, Name = "AirPods Pro", Price = 6500, Category = "Phụ kiện" },
                new Product { Id = 6, Name = "Galaxy Buds", Price = 4500, Category = "Phụ kiện" }
            };
            
            // where, dùng để truy vấn dữ iệu, giống như if vậy đó 
                // lấy ra sản phẩm nào có category là điện thoại 
                var phoneList = products.Where(p => p.Category == "Điện thoại").toList();
            // lấy ra sản phẩm có giá trị lớn 
                var phoneList = products.Where(p => p.Price == 20000).toList();
            // lấy ra sản phẩn có category là đc và Điện Thoại 20000
                var phoneList = products.Where(p => p.Price == 20000 && p.Category == "Điện thoại").toList();
    }       // lấy ra sản phẩn có category hoặc Điện Thoại > 20000
var phoneList = products.Where(p => p.Price == 20000 || p.Category == "Điện thoại").toList();
}
