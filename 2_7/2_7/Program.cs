namespace _2_7
{
    class Dog
    {
        private string mName = "";    // 名前

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public void ShowProfile()
        {
            Console.WriteLine(mName);
        }



        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = mName;

            string a = ShowProfile();
        }
    }
}
