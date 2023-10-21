using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            // Singleton sınıfının yapıcı metodu özel olarak işaretlendi,
            // böylece sınıf dışında yeni örnekler oluşturulamaz.
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                            Console.WriteLine("Singleton örneği oluşturuldu.");
                        }
                    }
                }
                return instance;
            }
        }

        public void SomeMethod()
        {
            Console.WriteLine("Singleton sınıfı metodu çağrıldı.");
        }
    }
}
