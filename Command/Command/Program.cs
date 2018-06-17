namespace Command
{
    /*
    * Command paterni, belirli bir operasyonu gerçekleştirmek isteyen nesne ile bu operasyonu gerçekleştirecek
    olan nesneyi birbirinden ayırabilmek için standard bir çözüm önerir.

    Bu paternin uygulanmasında 5 temel kısım vardır.
    - Command => Komutları temsil eden sınıfların taban sınıfı.
    - ConcreteCommand => Bir komutu temsil eden sınıf.
    - Receiver => Tüm komutların işlemlerinin(kodlarının) yazıldığı sınıf.
    Asıl işlemler bu sınıfta gerçekleşir, fakat kullanıcının bu sınıftan haberi yoktur.
    - Invoker => Tüm komutların listesini barındıran ve client ile receiver nesnelerini birbirinden
    soyutlayan sınıftır.
    - Client => İstemci
    
    Bu örnekte temel kısımlara karşılık gelen sınıflar;
    Command => Commands.Command
    ConcreteCommand => DelCommand, ListCommand, MakeDirCommand, QuitCommand
    Receiver => Kernel
    Invoker => Shell
    Client => main fonksiyonu
    */

    class Program
    {
        static void Main(string[] args)
        {
            Shell shell = new Shell();
            while (true)
                shell.CommandText();
        }
    }
}
