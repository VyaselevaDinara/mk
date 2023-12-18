using System.Diagnostics; // Добавляем необходимые пространства имен

internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new(); // Создаем экземпляр HttpClient

        Console.WriteLine("Введите ссылку для скачивания картинки: "); // Получаем ссылку для скачивания картинки от пользователя
        string nameWebsite = Console.ReadLine();

        HttpResponseMessage response = await client.GetAsync(nameWebsite);  // Отправляем GET-запрос и получаем ответ от сервера
        byte[] data = await response.Content.ReadAsByteArrayAsync();  // Читаем содержимое ответа в виде массива байтов

        Console.WriteLine("Введите путь сохранения: ");   // Получаем путь для сохранения файла от пользователя
        string link = Console.ReadLine();
        await File.WriteAllBytesAsync(link, data);  // Сохраняем данные в файл

        Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });  // Открываем файл с помощью ассоциированной программы

        HttpClient client1 = new HttpClient();  // Создаем новый экземпляр HttpClient

        Console.WriteLine("Введите ссылку для скачивания песни: ");  // Получаем ссылку для скачивания песни от пользователя
        string nameWebsite1 = Console.ReadLine();


        HttpResponseMessage response1 = await client1.GetAsync(nameWebsite1);  // Отправляем GET-запрос и получаем ответ от сервера
        byte[] data1 = response1.Content.ReadAsByteArrayAsync().Result;  // Читаем содержимое ответа в виде массива байтов

        Console.WriteLine("Введите путь сохранения: "); // Получаем путь для сохранения файла от пользователя
        string link1 = Console.ReadLine();
        File.WriteAllBytes(link1, data1); // Сохраняем данные в файл

        Process.Start(new ProcessStartInfo { FileName = link1, UseShellExecute = true });    // Открываем файл с помощью ассоциированной программы
    }
}
