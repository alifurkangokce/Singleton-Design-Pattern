using SingletonDesignPattern;

Singleton singleton1 = Singleton.Instance;

// İkinci bir örnek almaya çalışırsak, aynı örnek kullanılacaktır.
Singleton singleton2 = Singleton.Instance;

Console.WriteLine("singleton1 ve singleton2 aynı örnek mi? " + (singleton1 == singleton2));

// Singleton sınıfının metodu çağrılabilir.
singleton1.SomeMethod();

Console.ReadLine();
