using Microsoft.VisualBasic;
using System.IO;

namespace Z961
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Exception exception = new Exception("Произошло исключение");//Создаем экземпляр класса исключения Exception
                exception.Data.Add("Дата создания исключения : ", DateTime.Now);//добавляем в свойство Data - дату создания исключения
                exception.HelpLink = "www.google.ru";//Добавляем ссылку на внешний ресурс - где находятся сведения на ошибки

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Запись данных в файл который не существует: " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка ввода-вывода: " + ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Метод или операция не поддерживается: " + ex.Message);
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("Срок действия интервала времени, выделенного для операции, истек: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Индекс находится за пределами границ массива или коллекции: " + ex.Message);
            }
        }
    }
}