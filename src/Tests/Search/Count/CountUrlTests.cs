﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Tests.Framework;
using Tests.Framework.MockData;
using static Tests.Framework.UrlTester;

namespace Tests.Count.Count
{
	public class CountUrlTests
	{
		[U] public async Task Urls()
		{
			var hardcoded = "hardcoded";
			await POST("/project/commits/_count")
				.Fluent(c=>c.Count<CommitActivity>())
				.Request(c=>c.Count<Project>(new CountRequest<CommitActivity>()))
				.FluentAsync(c=>c.CountAsync<CommitActivity>())
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<CommitActivity>()))
				;

			await GET("/project/commits/_count?q=querystring")
				.Fluent(c=>c.Count<CommitActivity>(s=>s.Q("querystring")))
				.Request(c=>c.Count<Project>(new CountRequest<CommitActivity>() { Q = "querystring" }))
				.FluentAsync(c=>c.CountAsync<CommitActivity>(s=>s.Q("querystring")))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<CommitActivity>() { Q = "querystring" }))
				;
			await POST("/project/hardcoded/_count")
				.Fluent(c=>c.Count<CommitActivity>(s=>s.Type(hardcoded)))
				.Request(c=>c.Count<Project>(new CountRequest<CommitActivity>(typeof(Project), hardcoded)))
				.FluentAsync(c=>c.CountAsync<CommitActivity>(s=>s.Type(hardcoded)))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<CommitActivity>(typeof(Project), hardcoded)))
				;

			await POST("/project/_count")
				.Fluent(c=>c.Count<Project>(s=>s.Type(Types.All)))
				.Fluent(c=>c.Count<Project>(s=>s.AllTypes()))
				.Request(c=>c.Count<Project>(new CountRequest("project")))
				.Request(c=>c.Count<Project>(new CountRequest<Project>("project", Types.All)))
				.FluentAsync(c=>c.CountAsync<Project>(s=>s.Type(Types.All)))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<Project>(typeof(Project), Types.All)))
				.FluentAsync(c=>c.CountAsync<Project>(s=>s.AllTypes()))
				;

			await POST("/hardcoded/_count")
				.Fluent(c=>c.Count<Project>(s=>s.Index(hardcoded).Type(Types.All)))
				.Fluent(c=>c.Count<Project>(s=>s.Index(hardcoded).AllTypes()))
				.Request(c=>c.Count<Project>(new CountRequest(hardcoded)))
				.Request(c=>c.Count<Project>(new CountRequest<Project>(hardcoded, Types.All)))
				.FluentAsync(c=>c.CountAsync<Project>(s=>s.Index(hardcoded).Type(Types.All)))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<Project>(hardcoded, Types.All)))
				.FluentAsync(c=>c.CountAsync<Project>(s=>s.Index(hardcoded).AllTypes()))
				;

			await POST("/_count")
				.Fluent(c=>c.Count<Project>(s=>s.AllTypes().AllIndices()))
				.Request(c=>c.Count<Project>(new CountRequest()))
				.Request(c=>c.Count<Project>(new CountRequest<Project>(Nest.Indices.All, Types.All)))
				.FluentAsync(c=>c.CountAsync<Project>(s=>s.AllIndices().Type(Types.All)))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest<Project>(Nest.Indices.All, Types.All)))
				.RequestAsync(c=>c.CountAsync<Project>(new CountRequest()))
				;
		}
	}
}
