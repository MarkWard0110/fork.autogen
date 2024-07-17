// Copyright (c) Microsoft Corporation. All rights reserved.
// MistralAgentExtension.cs

using AutoGen.Core;

namespace AutoGen.Mistral.Extension;

public static class MistralAgentExtension
{
    /// <summary>
    /// Register a <see cref="MistralChatMessageConnector"/> to support more AutoGen message types.
    /// </summary>
    public static MiddlewareAgent<MistralClientAgent> RegisterMessageConnector(
        this MistralClientAgent agent, MistralChatMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new MistralChatMessageConnector();
        }

        return agent.RegisterMiddleware(connector);
    }

    /// <summary>
    /// Register a <see cref="MistralChatMessageConnector"/> to support more AutoGen message types.
    /// </summary>
    public static MiddlewareAgent<MistralClientAgent> RegisterMessageConnector(
        this MiddlewareAgent<MistralClientAgent> agent, MistralChatMessageConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new MistralChatMessageConnector();
        }

        return agent.RegisterMiddleware(connector);
    }
}
