using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaWindowsChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartKafkaConsumer();
        }

        private async void btnSend_Click_1(object sender, EventArgs e)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                var message = txtMessage.Text.Trim();

                if (!string.IsNullOrEmpty(message))
                {
                    await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                    lstChat.Items.Add("You: " + message);
                    txtMessage.Clear();
                }
            }
        }

        private void StartKafkaConsumer()
        {
            Task.Run(() =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = "localhost:9092",
                    GroupId = "winform-chat-group",
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
                {
                    consumer.Subscribe("chat-topic");

                    try
                    {
                        while (true)
                        {
                            var msg = consumer.Consume();

                            if (!string.IsNullOrWhiteSpace(msg.Message.Value))
                            {
                                Invoke(new Action(() =>
                                {
                                    lstChat.Items.Add("Friend: " + msg.Message.Value);
                                }));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("Kafka Error: " + ex.Message);
                        }));
                    }
                }
            });
        }

        // Optional: remove if not needed
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
