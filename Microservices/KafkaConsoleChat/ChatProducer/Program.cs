using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace ChatProducer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };
            using var producer = new ProducerBuilder<Null, string>(config).Build();

            Console.WriteLine("Kafka Chat Producer Started. Type messages:");

            while (true)
            {
                var message = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(message)) continue;

                await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                Console.WriteLine($"[Sent] {message}");
            }
        }
    }
}
