namespace Day5Exe4
{
    internal class Program
    {
        static async Task Main()
        {
            List<string> urls = new List<string>
        {
            "https://example.com",
            "https://google.com",
            "https://github.com"
        };

            await FetchAndDisplayContentLengthsAsync(urls);
        }

        static async Task FetchAndDisplayContentLengthsAsync(List<string> urls)
        {
            List<Task> tasks = new List<Task>();

            foreach (string url in urls)
            {
                tasks.Add(Task.Run(async () =>
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string content = await FetchDataAsync(client, url);
                        Console.WriteLine($"URL: {url} - Content Length: {content.Length} characters");
                    }
                }));
            }

            await Task.WhenAll(tasks);
        }

        static async Task<string> FetchDataAsync(HttpClient client, string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}