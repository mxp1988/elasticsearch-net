// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.NodesApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.NodesApi
{
	///<summary>
	/// Logically groups all <c>Nodes</c> API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Nodes"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class NodesNamespace : NamespacedClientProxy
	{
		internal NodesNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>GET</c> request to the <c>nodes.hot_threads</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</a>
		/// </summary>
		public NodesHotThreadsResponse HotThreads(Func<NodesHotThreadsDescriptor, INodesHotThreadsRequest> selector = null) => HotThreads(selector.InvokeOrDefault(new NodesHotThreadsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.hot_threads</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</a>
		/// </summary>
		public Task<NodesHotThreadsResponse> HotThreadsAsync(Func<NodesHotThreadsDescriptor, INodesHotThreadsRequest> selector = null, CancellationToken ct = default) => HotThreadsAsync(selector.InvokeOrDefault(new NodesHotThreadsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.hot_threads</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</a>
		/// </summary>
		public NodesHotThreadsResponse HotThreads(INodesHotThreadsRequest request) => DoNodesHotThreads(request);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.hot_threads</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-hot-threads.html</a>
		/// </summary>
		public Task<NodesHotThreadsResponse> HotThreadsAsync(INodesHotThreadsRequest request, CancellationToken ct = default) => DoNodesHotThreadsAsync(request, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.info</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</a>
		/// </summary>
		public NodesInfoResponse Info(Func<NodesInfoDescriptor, INodesInfoRequest> selector = null) => Info(selector.InvokeOrDefault(new NodesInfoDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.info</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</a>
		/// </summary>
		public Task<NodesInfoResponse> InfoAsync(Func<NodesInfoDescriptor, INodesInfoRequest> selector = null, CancellationToken ct = default) => InfoAsync(selector.InvokeOrDefault(new NodesInfoDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.info</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</a>
		/// </summary>
		public NodesInfoResponse Info(INodesInfoRequest request) => DoRequest<INodesInfoRequest, NodesInfoResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.info</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-info.html</a>
		/// </summary>
		public Task<NodesInfoResponse> InfoAsync(INodesInfoRequest request, CancellationToken ct = default) => DoRequestAsync<INodesInfoRequest, NodesInfoResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>nodes.reload_secure_settings</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings">https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings</a>
		/// </summary>
		public ReloadSecureSettingsResponse ReloadSecureSettings(Func<ReloadSecureSettingsDescriptor, IReloadSecureSettingsRequest> selector = null) => ReloadSecureSettings(selector.InvokeOrDefault(new ReloadSecureSettingsDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>nodes.reload_secure_settings</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings">https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings</a>
		/// </summary>
		public Task<ReloadSecureSettingsResponse> ReloadSecureSettingsAsync(Func<ReloadSecureSettingsDescriptor, IReloadSecureSettingsRequest> selector = null, CancellationToken ct = default) => ReloadSecureSettingsAsync(selector.InvokeOrDefault(new ReloadSecureSettingsDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>nodes.reload_secure_settings</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings">https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings</a>
		/// </summary>
		public ReloadSecureSettingsResponse ReloadSecureSettings(IReloadSecureSettingsRequest request) => DoRequest<IReloadSecureSettingsRequest, ReloadSecureSettingsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>nodes.reload_secure_settings</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings">https://www.elastic.co/guide/en/elasticsearch/reference/master/secure-settings.html#reloadable-secure-settings</a>
		/// </summary>
		public Task<ReloadSecureSettingsResponse> ReloadSecureSettingsAsync(IReloadSecureSettingsRequest request, CancellationToken ct = default) => DoRequestAsync<IReloadSecureSettingsRequest, ReloadSecureSettingsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.stats</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</a>
		/// </summary>
		public NodesStatsResponse Stats(Func<NodesStatsDescriptor, INodesStatsRequest> selector = null) => Stats(selector.InvokeOrDefault(new NodesStatsDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.stats</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</a>
		/// </summary>
		public Task<NodesStatsResponse> StatsAsync(Func<NodesStatsDescriptor, INodesStatsRequest> selector = null, CancellationToken ct = default) => StatsAsync(selector.InvokeOrDefault(new NodesStatsDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.stats</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</a>
		/// </summary>
		public NodesStatsResponse Stats(INodesStatsRequest request) => DoRequest<INodesStatsRequest, NodesStatsResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.stats</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-stats.html</a>
		/// </summary>
		public Task<NodesStatsResponse> StatsAsync(INodesStatsRequest request, CancellationToken ct = default) => DoRequestAsync<INodesStatsRequest, NodesStatsResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.usage</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html</a>
		/// </summary>
		public NodesUsageResponse Usage(Func<NodesUsageDescriptor, INodesUsageRequest> selector = null) => Usage(selector.InvokeOrDefault(new NodesUsageDescriptor()));
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.usage</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html</a>
		/// </summary>
		public Task<NodesUsageResponse> UsageAsync(Func<NodesUsageDescriptor, INodesUsageRequest> selector = null, CancellationToken ct = default) => UsageAsync(selector.InvokeOrDefault(new NodesUsageDescriptor()), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.usage</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html</a>
		/// </summary>
		public NodesUsageResponse Usage(INodesUsageRequest request) => DoRequest<INodesUsageRequest, NodesUsageResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>nodes.usage</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html">http://www.elastic.co/guide/en/elasticsearch/reference/master/cluster-nodes-usage.html</a>
		/// </summary>
		public Task<NodesUsageResponse> UsageAsync(INodesUsageRequest request, CancellationToken ct = default) => DoRequestAsync<INodesUsageRequest, NodesUsageResponse>(request, request.RequestParameters, ct);
	}
}