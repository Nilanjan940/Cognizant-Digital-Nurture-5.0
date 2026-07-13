using System;
using System.Threading;
using Confluent.Kafka;

namespace ChatConsumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            Console.WriteLine("Kafka Chat Consumer Started. Waiting for messages...");

            try
            {
                while (true)
                {
                    var cr = consumer.Consume(CancellationToken.None);
                    Console.WriteLine($"[Received] {cr.Message.Value}");
                }
            }
            catch (OperationCanceledException)
            {
                consumer.Close();
            }
        }
    }
}
