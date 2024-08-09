using nsp1;
using nsp1.nsp2;
namespace nsp1
{
    namespace nsp2
    {
        class c3
        { 
        }
    }
    class c1
    {
    }
}

namespace Class_object_july_090824
{
    class String
    {
        public String(char[] cc)
        {

        }
    }
   
    class c2
    {
        public void show()//signature  method_name+ parameters
        {
        }
        public void show(int x)
        {
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            c2 obj = new c2();
            obj.show();
            obj.show(100);
            char[] ch=null;
            System.String s1 = new System.String(ch);
            Class_object_july_090824.String ss = new Class_object_july_090824.String(ch);
            nsp1.c1 obj1 = new nsp1.c1();
            c1 cc = new c1();
            nsp1.nsp2.c3 obj2 = new nsp1.nsp2.c3();
            c3 ccc = new c3();


        }
    }
}
