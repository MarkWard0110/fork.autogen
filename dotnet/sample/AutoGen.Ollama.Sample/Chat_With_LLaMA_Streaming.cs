// Copyright (c) Microsoft Corporation. All rights reserved.
// Chat_With_LLaMA.cs

#region Using
using AutoGen.Core;
using AutoGen.Ollama.Extension;
#endregion Using

namespace AutoGen.Ollama.Sample;

public class Chat_With_LLaMA_Streaming
{
    public static async Task RunAsync(string ollamaHost, string model)
    {
        using var outWriter = System.Console.Out;

        #region Create_Ollama_Agent
        using var httpClient = new HttpClient()
        {
            BaseAddress = new Uri(ollamaHost),
            Timeout = TimeSpan.FromMinutes(10),
        };

        var ollamaAgent = new OllamaAgent(
            httpClient: httpClient,
            name: "ollama",
            modelName: model,
            systemMessage: "You are a helpful AI assistant",
            useStreamingApi: true,
            outputStream: outWriter)
            .RegisterMessageConnector();
        //.RegisterPrintMessage();

        var reply = await ollamaAgent.SendAsync("Can you write a piece of C# code to calculate 100th of fibonacci?");
        #endregion Create_Ollama_Agent

        //using var outWriter = System.Console.Out;
        //outWriter.WriteLine("Response from LLaMA streaming API:");
        //outWriter.WriteLine(reply.GetContent());
    }
}
