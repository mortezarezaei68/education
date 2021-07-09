using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(a);
        }
    }
    public abstract class Test
    {
        public abstract void Create();
        public virtual void Update(int a)
        {
            Console.Write(a);
        }
    }
    public class SubTestSecond : Test
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }
        public override void Update(int a)
        {
            Console.Write("sub test");
            int b = Sum(a);
            base.Update(b);
        }
        protected int Sum(int a)
        {
            a = a + 3;
            return a;
        }
        public void Delete()
        {
            
        }
        public void Delete(int a)
        {

        }
    }
    public class SubTestSecondDerived : SubTestSecond
    {
        public void Set()
        {

        }
    }
    public class SubTest : Test
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Update(int a)
        {
            Console.Write("sub test");
            a = a + 2;
            base.Update(a);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    public interface ITest
    {
        void Create();
        void Update();
    }
}
