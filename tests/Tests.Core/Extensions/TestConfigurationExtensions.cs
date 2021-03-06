﻿using Elastic.Managed.Configuration;
using Elastic.Stack.Artifacts;
using Elasticsearch.Net;
using Tests.Configuration;

namespace Tests.Core.Extensions
{
	public static class TestConfigurationExtensions
	{
		public static IConnection CreateConnection(this TestConfigurationBase configuration, bool forceInMemory = false, byte[] response = null) =>
			forceInMemory
				? new InMemoryConnection(response)
				: configuration.RunIntegrationTests
					? (IConnection)new HttpConnection()
					: new InMemoryConnection(response);

		public static bool InRange(this TestConfigurationBase configuration, string range) =>
			configuration.ElasticsearchVersion.InRange(range);
	}
}
