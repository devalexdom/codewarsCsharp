using System;

namespace Who_likes_it
{
    class MainClass
    {
        public static string Likes(string[] name)
        {
            string output="Unknow error";

            switch (name.Length)
            {   
                case 0:
                    output = "no one likes this";
                    break;
                case 1:
                    output = name[0] + " likes this";
                    break;
                case 2:
                    output = name[0] + " and " + name[1] + " like this";
                    break;
                case 3:
                    output = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                    break;
                default:
                    if (name.Length > 3)
                    {
                        output = name[0] + ", " + name[1] + " and " + (name.Length-2) + " others like this";
                    }
                    break;
            };
            return output;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(MainClass.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
