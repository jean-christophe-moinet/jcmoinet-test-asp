namespace TestApplication.Lib
{
    public class User
    {
        public string Name { get; set; }

        public string SayHello(string name)
        {
            return string.Format("Hello, {0}", name);
        }

        public string SayHelloJC()
        {
            return SayHello("JC");
        }


    }
}
