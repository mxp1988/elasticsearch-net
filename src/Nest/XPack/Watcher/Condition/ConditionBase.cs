﻿using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	public interface ICondition { }

	public abstract class ConditionBase : ICondition
	{
		internal abstract void WrapInContainer(IConditionContainer container);
	}
}
