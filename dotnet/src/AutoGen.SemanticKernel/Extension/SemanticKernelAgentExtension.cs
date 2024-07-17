// Copyright (c) Microsoft Corporation. All rights reserved.
// SemanticKernelAgentExtension.cs

namespace AutoGen.SemanticKernel.Extension;

public static class SemanticKernelAgentExtension
{
    /// <summary>
    /// Register an <see cref="SemanticKernelChatMessageContentConnector"/> to the <see cref="SemanticKernelAgent"/>
    /// </summary>
    /// <param name="connector">the connector to use. If null, a new instance of <see cref="SemanticKernelChatMessageContentConnector"/> will be created.</param>
    public static MiddlewareAgent<SemanticKernelAgent> RegisterMessageConnector(
        this SemanticKernelAgent agent, SemanticKernelChatMessageContentConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new SemanticKernelChatMessageContentConnector();
        }

        return agent.RegisterMiddleware(connector);
    }

    /// <summary>
    /// Register an <see cref="SemanticKernelChatMessageContentConnector"/> to the <see cref="MiddlewareAgent{T}"/> where T is <see cref="SemanticKernelAgent"/>
    /// </summary>
    /// <param name="connector">the connector to use. If null, a new instance of <see cref="SemanticKernelChatMessageContentConnector"/> will be created.</param>
    public static MiddlewareAgent<SemanticKernelAgent> RegisterMessageConnector(
        this MiddlewareAgent<SemanticKernelAgent> agent, SemanticKernelChatMessageContentConnector? connector = null)
    {
        if (connector == null)
        {
            connector = new SemanticKernelChatMessageContentConnector();
        }

        return agent.RegisterMiddleware(connector);
    }
}
