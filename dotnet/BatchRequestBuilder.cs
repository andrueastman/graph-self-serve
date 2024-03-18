﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.Core.Requests
{
    using Microsoft.Kiota.Abstractions;
    using Microsoft.Kiota.Abstractions.Serialization;
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// The type BatchRequestBuilder
    /// </summary>
    public class BatchRequestBuilderCustom
    {
        /// <summary>
        /// Constructs a new BatchRequestBuilder.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BatchRequestBuilderCustom(IRequestAdapter requestAdapter)
        {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/$batch";
            RequestAdapter = requestAdapter;
        }

        /// <summary>
        /// Url template to use to build the URL for the current request builder
        /// </summary>
        internal string UrlTemplate { get; set; }

        /// <summary>
        /// The request adapter to use to execute the requests.
        /// </summary>
        internal IRequestAdapter RequestAdapter { get; set; }

        /// <summary>
        /// Sends out the <see cref="BatchRequestContent"/> using the POST method
        /// </summary>
        /// <param name="batchRequestContent">The <see cref="BatchRequestContent"/> for the request</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to use for cancelling requests</param>
        /// <param name="errorMappings">The error mappings to use for handling error responses</param>
        /// <returns></returns>
        public async Task<BatchResponseContent> PostAsync(BatchRequestContentCustom batchRequestContent, CancellationToken cancellationToken = default, Dictionary<string, ParsableFactory<IParsable>> errorMappings = null)
        {
            _ = batchRequestContent ?? throw new ArgumentNullException(nameof(batchRequestContent));
            var requestInfo = await ToPostRequestInformationAsync(batchRequestContent,cancellationToken);
            var nativeResponseHandler = new NativeResponseHandler();
            requestInfo.SetResponseHandler(nativeResponseHandler);
            await this.RequestAdapter.SendNoContentAsync(requestInfo, cancellationToken:cancellationToken);
            return new BatchResponseContent(nativeResponseHandler.Value as HttpResponseMessage, errorMappings);
        }

        /// <summary>
        /// Sends out the <see cref="BatchRequestContentCollection"/> using the POST method
        /// </summary>
        /// <param name="batchRequestContentCollection">The <see cref="BatchRequestContentCollection"/> for the request</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to use for cancelling requests</param>
        /// <param name="errorMappings">The error mappings to use for handling error responses</param>
        /// <returns></returns>
        public async Task<BatchResponseContentCollectionCustom> PostAsync(BatchRequestContentCollectionCustom batchRequestContentCollection, CancellationToken cancellationToken = default, Dictionary<string, ParsableFactory<IParsable>> errorMappings = null)
        {
            var collection = new BatchResponseContentCollectionCustom();

            var requests = batchRequestContentCollection.GetBatchRequestsForExecution();
            foreach (var request in requests)
            {
                var response = await PostAsync(request, cancellationToken, errorMappings);
                collection.AddResponse(request.BatchRequestSteps.Keys, response);
            }

            return collection;
        }

        /// <summary>
        /// Create <see cref="RequestInformation"/> instance to post to batch endpoint
        /// <param name="batchRequestContent">The <see cref="BatchRequestContent"/> for the request</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to use for cancelling requests</param>
        /// </summary>
        public async Task<RequestInformation> ToPostRequestInformationAsync(BatchRequestContentCustom batchRequestContent, CancellationToken cancellationToken = default)
        {
            _ = batchRequestContent ?? throw new ArgumentNullException(nameof(batchRequestContent));
            var requestInfo = new RequestInformation
            {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
            };
            requestInfo.Content = await batchRequestContent.GetBatchRequestContentAsync(cancellationToken).ConfigureAwait(false);
            requestInfo.Headers.Add("Content-Type", CoreConstants.MimeTypeNames.Application.Json);
            return requestInfo;
        }
    }
}