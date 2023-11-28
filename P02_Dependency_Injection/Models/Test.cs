namespace P02_Dependency_Injection.Models
{
    public class Test : ITest
    {
        public Data Data { get; set; }

        public Test()
        {
            Data = new();
            GenerateData();
        }

        public Data GenerateData()
        {
            // GetHashCode คือได้ตัวเลขมั่ว ๆ 
            Data.Id = GetHashCode();
            Data.Message = "Test";

            return Data;

        }

    }
}
