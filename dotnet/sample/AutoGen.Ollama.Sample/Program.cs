// Copyright (c) Microsoft Corporation. All rights reserved.
// Program.cs

using AutoGen.Ollama.Sample;

//await Chat_With_LLaMA.RunAsync("http://quorra.homelan.binaryward.com:11434", "llama3:8b-instruct-fp16");
await Chat_With_LLaMA_Streaming.RunAsync("http://quorra.homelan.binaryward.com:11434", "llama3:70b-instruct-q8_0");
//await Chat_With_LLaVA.RunAsync("http://quorra.homelan.binaryward.com:11434", "llava:latest");
