﻿using System;
using System.Collections.Generic;
using System.Linq;
using Elasticsearch.Net;
using Newtonsoft.Json;

namespace Nest
{
	public partial interface ISnapshotStatusRequest { }

	public partial class SnapshotStatusRequest { }

	[DescriptorFor("SnapshotGet")]
	public partial class SnapshotStatusDescriptor { }
}
