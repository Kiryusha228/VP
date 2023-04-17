using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Microsoft.VisualBasic;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace TGBot
{
    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("5829248467:AAGJ4D0NcqwyK7J27poabw0tyA61TAmnH0s");

        public static async Task HandlerUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken) 
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message && update!.Message!.Type == Telegram.Bot.Types.Enums.MessageType.Photo)
                {
                    var fileId = message!.Photo![message.Photo.Count() - 1].FileId;
                    var file = await botClient.GetFileAsync(fileId);
                    using var stream = new MemoryStream();
                    await botClient.DownloadFileAsync(file!.FilePath!, stream);
                    stream.Seek(0, SeekOrigin.Begin); // необходимо переместить курсор в начало потока
                    
                    using (var streamSend = System.IO.File.Open(RotatePicture(stream), FileMode.Open))
                    {
                        await botClient.SendPhotoAsync(message.Chat, streamSend!);
                    }
                    return;
                }



                if (message?.Text?.ToLower() == "/start") 
                {
                    await botClient.SendTextMessageAsync(message.Chat, 
                        "Hello\n" +
                        "Use command /haha to geе anecdote\n" +
                        "Send picture to rotate\n" +
                        "Send mathematical example to calc");
                    return;
                }

                if (message?.Text?.ToLower() == "/haha")
                {
                    using (var stream = System.IO.File.Open(GetRandomPicture(), FileMode.Open))
                    {
                        await botClient.SendPhotoAsync(message.Chat, stream!);
                    }
                    return;
                }
                if (Regex.IsMatch(message!.Text!, @"\b\d+\s*[+*-]\s*\d+\b"))
                {
                    await botClient.SendTextMessageAsync(message.Chat, Calc(message!.Text!));
                    return;
                }

                if (message?.Text?.ToLower() == "/picture")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Enter your picture");
                    
                    return;
                }

                if (message?.Text?.ToLower() == "/bye")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Poka");
                    return;
                }


                await botClient.SendTextMessageAsync(message!.Chat, "IDK this command");
            }
        }
        
        static string RotatePicture(MemoryStream stream)
        {
            var path = @"C:\Users\Kirill\source\repos\TGBot\TGBot\Downloaded\image.bmp";
            using (Image image = Image.FromStream(stream))
            {
                // Повернуть и отразить изображение
                image.RotateFlip(RotateFlipType.Rotate180FlipX);

                image.Save(path);
            }
            return path;
        }
        
        static string GetRandomPicture()
        {
            string path = @"C:\Users\Kirill\source\repos\TGBot\TGBot\Pictures";
            var pictures = Directory.GetFiles(path);
            Random random = new Random();
            int index = random.Next(pictures.Length);
            return pictures[index];
        }
        static string Calc(string str)
        {
            char[] operat = { '-', '+', '*' };
            string result;
            var data = str.Split(operat, StringSplitOptions.None);
            int arg1 = int.Parse(data[0]);
            int arg2 = int.Parse(data[1]);
            if (str.Contains("-"))
            {
                result = (arg1 - arg2).ToString();
            }
            else if (str.Contains("+"))
            {
                result = (arg1 + arg2).ToString();
            }
            else
            {
                result = (arg1 * arg2).ToString();
            }
            return result;
        }


        public static async Task HandlerErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Started bot " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };
            bot.StartReceiving(
                HandlerUpdateAsync,
                HandlerErrorAsync,
                receiverOptions,
                cancellationToken
                );

            Console.ReadLine();
        }
    }
}