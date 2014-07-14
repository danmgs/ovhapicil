﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using OVHApi.Tools;

namespace OVHApi
{
	public partial class OvhApiClient{
			/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCdnDedicatedServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task UpdateCdnDedicatedServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cdn/dedicated/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Return quota history
							/// <param name="period">To be written</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.StatsDataType[]> GetCdnDedicatedQuotas(OvhApi.Models.Cdnanycast.StatsPeriodEnum period,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);

			
			return await RawCall<OvhApi.Models.Cdnanycast.StatsDataType[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/quota{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Anycast> GetCdnDedicated(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Anycast>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Domain> GetCdnDedicatedDomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Domain>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task UpdateCdnDedicatedDomains(OvhApi.Models.Cdnanycast.Domain requestBody,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cdn/dedicated/{0}/domains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// Remove a domain from the CDN
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> DeleteCdnDedicatedDomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Delete,String.Format("/cdn/dedicated/{0}/domains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Backend associated to the domain
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetCdnDedicatedDomainsBackends(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/backends",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Add a backend IP
							/// <param name="ip">IP to add to backends list</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Backend> CreateCdnDedicatedDomainsBackends(string ip,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("ip",ip);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ip",ip);

			return await RawCall<OvhApi.Models.Cdnanycast.Backend>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/domains/{1}/backends",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Backend> GetCdnDedicatedDomainsBackends(string serviceName,string domain,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Backend>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/backends/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Remove a backend IP
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress> DeleteCdnDedicatedDomainsBackends(string serviceName,string domain,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<System.Net.IPAddress>(HttpMethod.Delete,String.Format("/cdn/dedicated/{0}/domains/{1}/backends/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Task associated to the domain
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<long[]> GetCdnDedicatedDomainsTaskIds(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> GetCdnDedicatedDomainsTasks(string serviceName,string domain,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/tasks/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Flush all cache
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> CreateCdnDedicatedDomainsFlush(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/domains/{1}/flush",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Return stats about a domain
							/// <param name="period">To be written</param>
							/// <param name="value">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.StatsDataType[]> GetCdnDedicatedDomainsStatistics(OvhApi.Models.Cdnanycast.StatsPeriodEnum period,OvhApi.Models.Cdnanycast.StatsValueEnum value,OvhApi.Models.Cdnanycast.StatsTypeEnum type,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("value",value);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("value",value);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Cdnanycast.StatsDataType[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/statistics{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),queryString));
		}
				/// <summary>
		/// Cache rules associated to the domain
							/// <param name="fileMatch">Filter the value of fileMatch property (like)</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<long[]> GetCdnDedicatedDomainsCacheruleIds(string serviceName,string domain,string fileMatch = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			var queryString = new QueryString();
queryString.Add("fileMatch",fileMatch);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),queryString));
		}
				/// <summary>
		/// Add a cache rule to a domain
							/// <param name="cacheType">Type of cache rule to add to the domain</param>
							/// <param name="ttl">ttl for cache rule to add to the domain</param>
							/// <param name="fileMatch">File match for cache rule to add to the domain</param>
							/// <param name="fileType">File type for cache rule to add to the domain</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.CacheRule> CreateCdnDedicatedDomainsCacherules(OvhApi.Models.Cdnanycast.CacheRuleCacheTypeEnum cacheType,long ttl,string fileMatch,OvhApi.Models.Cdnanycast.CacheRuleFileTypeEnum fileType,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("cacheType",cacheType);
Ensure.IdIsValid("ttl",ttl);
Ensure.NotNullNorEmpty("fileMatch",fileMatch);
Ensure.NotNull("fileType",fileType);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("cacheType",cacheType);
requestBody.Add("ttl",ttl);
requestBody.Add("fileMatch",fileMatch);
requestBody.Add("fileType",fileType);

			return await RawCall<OvhApi.Models.Cdnanycast.CacheRule>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.CacheRule> GetCdnDedicatedDomainsCacherules(string serviceName,string domain,long cacheRuleId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.CacheRule>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// </summary>
						public async Task UpdateCdnDedicatedDomainsCacherules(OvhApi.Models.Cdnanycast.CacheRule requestBody,string serviceName,string domain,long cacheRuleId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString())),requestBody);
		}
				/// <summary>
		/// Remove cache rule
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> DeleteCdnDedicatedDomainsCacherules(string serviceName,string domain,long cacheRuleId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Delete,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString())));
		}
				/// <summary>
		/// Task associated to the cache rule
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// </summary>
						public async Task<long[]> GetCdnDedicatedDomainsCacherulesTaskIds(string serviceName,string domain,long cacheRuleId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> GetCdnDedicatedDomainsCacherulesTasks(string serviceName,string domain,long cacheRuleId,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}/tasks/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Flush the cache
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="domain">Domain of this object</param>
							/// <param name="cacheRuleId">Id for this cache rule</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> CreateCdnDedicatedDomainsCacherulesFlush(string serviceName,string domain,long cacheRuleId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("cacheRuleId",cacheRuleId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/domains/{1}/cacheRules/{2}/flush",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(cacheRuleId.ToString())));
		}
				/// <summary>
		/// Domains associated to this anycast
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<string[]> GetCdnDedicatedDomainNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/domains",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a domain on CDN
							/// <param name="domain">domain name to add on CDN</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Domain> CreateCdnDedicatedDomains(string domain,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);

			return await RawCall<OvhApi.Models.Cdnanycast.Domain>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/domains",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Ssl> GetCdnDedicatedSsl(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Ssl>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/ssl",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a SSL on CDN
							/// <param name="chain">certificate chain</param>
							/// <param name="certificate">certificate</param>
							/// <param name="name">ssl name to add on CDN</param>
							/// <param name="key">certificate key</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Ssl> CreateCdnDedicatedSsl(string certificate,string name,string key,string serviceName,string chain = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("certificate",certificate);
Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("key",key);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("chain",chain);
requestBody.Add("certificate",certificate);
requestBody.Add("name",name);
requestBody.Add("key",key);

			return await RawCall<OvhApi.Models.Cdnanycast.Ssl>(HttpMethod.Post,String.Format("/cdn/dedicated/{0}/ssl",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Remove SSL of the CDN
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> DeleteCdnDedicatedSsl(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Delete,String.Format("/cdn/dedicated/{0}/ssl",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Task associated to the ssl
							/// <param name="function">Filter the value of function property (=)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// </summary>
						public async Task<long[]> GetCdnDedicatedSslTaskIds(string serviceName,OvhApi.Models.Cdnanycast.TaskStateEnum? status = null,OvhApi.Models.Cdnanycast.TaskFunctionEnum? function = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("function",function);
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/ssl/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN offer</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Task> GetCdnDedicatedSslTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Task>(HttpMethod.Get,String.Format("/cdn/dedicated/{0}/ssl/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetCdnDedicatedNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/dedicated"));
		}
				/// <summary>
		/// List of CDN Pops
							/// </summary>
						public async Task<string[]> GetCdnDedicatedPopNames()
		{
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/dedicated/pops"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="name">Name of the pop</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdnanycast.Pop> GetCdnDedicatedPops(string name)
		{
					Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Cdnanycast.Pop>(HttpMethod.Get,String.Format("/cdn/dedicated/pops/{0}",System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCdnWebsiteServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cdn/website/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task UpdateCdnWebsiteServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cdn/website/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Website> GetCdnWebsite(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Website>(HttpMethod.Get,String.Format("/cdn/website/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Zone> GetCdnWebsiteZone(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Zone>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Configure a zone on CDN
							/// <param name="zone">zone DNS name to add on CDN</param>
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Zone> CreateCdnWebsiteZone(string zone,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zone",zone);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("zone",zone);

			return await RawCall<OvhApi.Models.Cdn.Website.Zone>(HttpMethod.Post,String.Format("/cdn/website/{0}/zone",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Remove a zone from the CDN
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> DeleteCdnWebsiteZone(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Delete,String.Format("/cdn/website/{0}/zone",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Domain> GetCdnWebsiteZoneDomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Domain>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/domains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Remove a domain from the CDN
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> DeleteCdnWebsiteZoneDomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Delete,String.Format("/cdn/website/{0}/zone/domains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Task associated to this domain
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// </summary>
						public async Task<long[]> GetCdnWebsiteZoneDomainsTaskIds(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/domains/{1}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> GetCdnWebsiteZoneDomainsTasks(string serviceName,string domain,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/domains/{1}/tasks/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Flush all cache
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> CreateCdnWebsiteZoneDomainsFlush(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Post,String.Format("/cdn/website/{0}/zone/domains/{1}/flush",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Get statistics about request on CDN, bandwidth value in Bytes
							/// <param name="period">To be written</param>
							/// <param name="value">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="domain">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.StatsDataType[]> GetCdnWebsiteZoneDomainsStatistics(OvhApi.Models.Cdn.Website.StatsPeriodEnum period,OvhApi.Models.Cdn.Website.StatsValueEnum value,OvhApi.Models.Cdn.Website.StatsTypeEnum type,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("value",value);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("value",value);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Cdn.Website.StatsDataType[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/domains/{1}/statistics{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString()),queryString));
		}
				/// <summary>
		/// Domain associated to this zone
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<string[]> GetCdnWebsiteZoneDomainNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/domains",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Configure a domain on CDN
							/// <param name="domain">domain to add on CDN</param>
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Domain> CreateCdnWebsiteZoneDomains(string domain,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);

			return await RawCall<OvhApi.Models.Cdn.Website.Domain>(HttpMethod.Post,String.Format("/cdn/website/{0}/zone/domains",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Backend associated to this zone
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetCdnWebsiteZoneBackends(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/backends",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Configure a backend on the zone
							/// <param name="ipv4">ip to configure on the zone</param>
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> CreateCdnWebsiteZoneBackends(System.Net.IPAddress ipv4,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipv4",ipv4);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipv4",ipv4);

			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Post,String.Format("/cdn/website/{0}/zone/backends",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="ipv4">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Backend> GetCdnWebsiteZoneBackends(string serviceName,System.Net.IPAddress ipv4)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipv4",ipv4);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Backend>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/backends/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipv4.ToString())));
		}
				/// <summary>
		/// Remove a backend from the zone
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="ipv4">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> DeleteCdnWebsiteZoneBackends(string serviceName,System.Net.IPAddress ipv4)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipv4",ipv4);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Delete,String.Format("/cdn/website/{0}/zone/backends/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipv4.ToString())));
		}
				/// <summary>
		/// Task associated to this backend
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="ipv4">To be written</param>
							/// </summary>
						public async Task<long[]> GetCdnWebsiteZoneBackendsTaskIds(string serviceName,System.Net.IPAddress ipv4)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipv4",ipv4);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/backends/{1}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipv4.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="ipv4">To be written</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> GetCdnWebsiteZoneBackendsTasks(string serviceName,System.Net.IPAddress ipv4,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipv4",ipv4);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/backends/{1}/tasks/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipv4.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Task associated to this zone
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// </summary>
						public async Task<long[]> GetCdnWebsiteZoneTaskIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Website offer</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Website.Task> GetCdnWebsiteZoneTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Cdn.Website.Task>(HttpMethod.Get,String.Format("/cdn/website/{0}/zone/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetCdnWebsiteNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/website"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Static offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCdnWebstorageServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cdn/webstorage/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your CDN Static offer</param>
							/// </summary>
						public async Task UpdateCdnWebstorageServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cdn/webstorage/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your CDN Static offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Webstorage.Account> GetCdnWebstorage(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Webstorage.Account>(HttpMethod.Get,String.Format("/cdn/webstorage/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Return stats about bandwidth consumption
							/// <param name="period">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your CDN Static offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Webstorage.StatsDataType[]> GetCdnWebstorageStatistics(OvhApi.Models.Cdn.Webstorage.StatsPeriodEnum period,OvhApi.Models.Cdn.Webstorage.StatsTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Cdn.Webstorage.StatsDataType[]>(HttpMethod.Get,String.Format("/cdn/webstorage/{0}/statistics{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Gives for customer credentials to accesss swift account
							/// <param name="serviceName">The internal name of your CDN Static offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cdn.Webstorage.AccountCredentials> GetCdnWebstorageCredentials(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Webstorage.AccountCredentials>(HttpMethod.Get,String.Format("/cdn/webstorage/{0}/credentials",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetCdnWebstorageNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cdn/webstorage"));
		}
				/// <summary>
		/// List available services
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// </summary>
						[Obsolete("Deprecated since 09/16/2013 11:00:00 use '/cdn/webstorage/{serviceName}' instead")]
				public async Task<string[]> GetCloudCdnNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/cdn",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="cdnServiceName">The internal name of your cloud CDN offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCloudCdnServiceinfos(string serviceName,string cdnServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("cdnServiceName",cdnServiceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cloud/{0}/cdn/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(cdnServiceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="cdnServiceName">The internal name of your cloud CDN offer</param>
							/// </summary>
						public async Task UpdateCloudCdnServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName,string cdnServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("cdnServiceName",cdnServiceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cloud/{0}/cdn/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(cdnServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="cdnServiceName">The internal name of your cloud CDN offer</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Cdn.Account> GetCloudCdn(string serviceName,string cdnServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("cdnServiceName",cdnServiceName);

			
			
			return await RawCall<OvhApi.Models.Cdn.Account>(HttpMethod.Get,String.Format("/cloud/{0}/cdn/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(cdnServiceName.ToString())));
		}
				/// <summary>
		/// Gives for customer credentials to accesss swift account
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="cdnServiceName">The internal name of your cloud CDN offer</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Cloud.Cdn.AccountCredentials> GetCloudCdnCredentials(string serviceName,string cdnServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("cdnServiceName",cdnServiceName);

			
			
			return await RawCall<OvhApi.Models.Cloud.Cdn.AccountCredentials>(HttpMethod.Get,String.Format("/cloud/{0}/cdn/{1}/credentials",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(cdnServiceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// </summary>
						public async Task<string[]> GetCloudPcNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pcs",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCloudPcsServiceinfos(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task UpdateCloudPcsServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cloud/{0}/pcs/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// View Account Total Usage (bytes)
							/// <param name="period">The period of statistic</param>
							/// <param name="meterType">The type of statistic to be fetched</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						[Obsolete("Deprecated since 09/26/2013 11:00:00 use '/cloud/{serviceName}/pcs/{pcsServiceName}/billing' instead")]
				public async Task<OvhApi.Models.ComplexType.UnitAndValue<double>> GetCloudPcsUsage(OvhApi.Models.Cloud.Pcs.StatisticPeriodEnum period,OvhApi.Models.Cloud.Pcs.StatisticTypeEnum meterType,string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("meterType",meterType);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("meterType",meterType);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValue<double>>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/usage{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Pcs.Account> GetCloudPcs(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<OvhApi.Models.Pcs.Account>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Tasks associated to this PCS account
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<long[]> GetCloudPcsTaskIds(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Pcs.Task> GetCloudPcsTasks(string serviceName,string pcsServiceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Pcs.Task>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/tasks/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Openstack containers within account
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						[Obsolete("Deprecated since 10/16/2013 20:00:00")]
				public async Task<string[]> GetCloudPcsContainerNames(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/container",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Create a PCS container
							/// <param name="name">PCS container identifier</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						[Obsolete("Deprecated since 10/16/2013 20:00:00")]
				public async Task<OvhApi.Models.Pcs.Container> CreateCloudPcsContainer(string name,string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("name",name);

			return await RawCall<OvhApi.Models.Pcs.Container>(HttpMethod.Post,String.Format("/cloud/{0}/pcs/{1}/container",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// <param name="name">To be written</param>
							/// </summary>
						[Obsolete("Deprecated since 10/16/2013 20:00:00")]
				public async Task<OvhApi.Models.Pcs.Container> GetCloudPcsContainer(string serviceName,string pcsServiceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Pcs.Container>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/container/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Gives for customer credentials to accesss swift account
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Cloud.Pcs.AccountCredentials> GetCloudPcsCredentials(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<OvhApi.Models.Cloud.Pcs.AccountCredentials>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/credentials",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Reset the credentials of the swift account and send them by email
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Pcs.Task> CreateCloudPcsResetcredentials(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<OvhApi.Models.Pcs.Task>(HttpMethod.Post,String.Format("/cloud/{0}/pcs/{1}/resetCredentials",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// View Account Total Usage (bytes)
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValue<double>> GetCloudPcsGlobalusage(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValue<double>>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/globalUsage",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// <param name="billingId">Billing id</param>
							/// </summary>
						public async Task<OvhApi.Models.Pcs.Billing> GetCloudPcsBilling(string serviceName,string pcsServiceName,long billingId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);
Ensure.IdIsValid("billingId",billingId);

			
			
			return await RawCall<OvhApi.Models.Pcs.Billing>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/billing/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString()),System.Net.WebUtility.UrlEncode(billingId.ToString())));
		}
				/// <summary>
		/// cloud storage billing items
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcsServiceName">The internal name of your PCS offer</param>
							/// </summary>
						public async Task<long[]> GetCloudPcsBillingIds(string serviceName,string pcsServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcsServiceName",pcsServiceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cloud/{0}/pcs/{1}/billing",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcsServiceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetCloudPcaServiceinfos(string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task UpdateCloudPcaServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cloud/{0}/pca/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// View account current total sessions usage (bytes)
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<long> GetCloudPcaUsage(string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			
			return await RawCall<long>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/usage",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())));
		}
				/// <summary>
		/// cloud archives sessions for account
							/// <param name="name">Filter the value of name property (like)</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<string[]> GetCloudPcaSessionNames(string serviceName,string pcaServiceName,string name = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			var queryString = new QueryString();
queryString.Add("name",name);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/sessions{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Session> GetCloudPcaSessions(string serviceName,string pcaServiceName,string sessionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);

			
			
			return await RawCall<OvhApi.Models.Pca.Session>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/sessions/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// </summary>
						public async Task UpdateCloudPcaSessions(OvhApi.Models.Pca.Session requestBody,string serviceName,string pcaServiceName,string sessionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cloud/{0}/pca/{1}/sessions/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString())),requestBody);
		}
				/// <summary>
		/// Create a delete task for all files in session
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Task> DeleteCloudPcaSessions(string serviceName,string pcaServiceName,string sessionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);

			
			
			return await RawCall<OvhApi.Models.Pca.Task>(HttpMethod.Delete,String.Format("/cloud/{0}/pca/{1}/sessions/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString())));
		}
				/// <summary>
		/// cloud archives files in session
							/// <param name="name">Filter the value of name property (like)</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// </summary>
						public async Task<string[]> GetCloudPcaSessionsFileNames(string serviceName,string pcaServiceName,string sessionId,string name = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);

			var queryString = new QueryString();
queryString.Add("name",name);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/sessions/{2}/files{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// <param name="fileId">File id</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.File> GetCloudPcaSessionsFiles(string serviceName,string pcaServiceName,string sessionId,string fileId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);
Ensure.NotNullNorEmpty("fileId",fileId);

			
			
			return await RawCall<OvhApi.Models.Pca.File>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/sessions/{2}/files/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString()),System.Net.WebUtility.UrlEncode(fileId.ToString())));
		}
				/// <summary>
		/// Create a restore task for session
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="sessionId">Session ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Task> CreateCloudPcaSessionsRestore(string serviceName,string pcaServiceName,string sessionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("sessionId",sessionId);

			
			
			return await RawCall<OvhApi.Models.Pca.Task>(HttpMethod.Post,String.Format("/cloud/{0}/pca/{1}/sessions/{2}/restore",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(sessionId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Account> GetCloudPca(string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			
			return await RawCall<OvhApi.Models.Pca.Account>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task UpdateCloudPca(OvhApi.Models.Pca.Account requestBody,string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/cloud/{0}/pca/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// cloud archives tasks for account
							/// <param name="todoDate_to">Filter the value of todoDate property (<=)</param>
							/// <param name="function">Filter the value of function property (=)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="todoDate_from">Filter the value of todoDate property (>=)</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<string[]> GetCloudPcaTaskNames(string serviceName,string pcaServiceName,DateTime? todoDate_from = null,OvhApi.Models.Cloud.Pca.TaskStateEnum? status = null,OvhApi.Models.Cloud.Pca.FunctionTypeEnum? function = null,DateTime? todoDate_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			var queryString = new QueryString();
queryString.Add("todoDate.to",todoDate_to);
queryString.Add("function",function);
queryString.Add("status",status);
queryString.Add("todoDate.from",todoDate_from);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/tasks{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),queryString));
		}
				/// <summary>
		/// Create a cloud archives task
							/// <param name="sessionId">cloud archives session identifier</param>
							/// <param name="taskFunction">cloud archives task type</param>
							/// <param name="fileIds">cloud archives file identifiers</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						[Obsolete("Deprecated since 07/03/2013 11:00:00 use '/cloud/{serviceName}/pca/{pcaServiceName}/sessions' instead")]
				public async Task<OvhApi.Models.Pca.Task> CreateCloudPcaTasks(string sessionId,OvhApi.Models.Cloud.Pca.TaskTypeEnum taskFunction,string[] fileIds,string serviceName,string pcaServiceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("sessionId",sessionId);
Ensure.NotNull("taskFunction",taskFunction);
Ensure.NotNull("fileIds",fileIds);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("sessionId",sessionId);
requestBody.Add("taskFunction",taskFunction);
requestBody.Add("fileIds",fileIds);

			return await RawCall<OvhApi.Models.Pca.Task>(HttpMethod.Post,String.Format("/cloud/{0}/pca/{1}/tasks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="taskId">Task ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Task> GetCloudPcaTasks(string serviceName,string pcaServiceName,string taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.NotNullNorEmpty("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Pca.Task>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/tasks/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// <param name="billingId">Billing id</param>
							/// </summary>
						public async Task<OvhApi.Models.Pca.Billing> GetCloudPcaBilling(string serviceName,string pcaServiceName,long billingId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);
Ensure.IdIsValid("billingId",billingId);

			
			
			return await RawCall<OvhApi.Models.Pca.Billing>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/billing/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),System.Net.WebUtility.UrlEncode(billingId.ToString())));
		}
				/// <summary>
		/// cloud Archives billing items
							/// <param name="date_to">Filter the value of date property (<=)</param>
							/// <param name="date_from">Filter the value of date property (>=)</param>
							/// <param name="billed">Filter the value of billed property (=)</param>
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// <param name="pcaServiceName">The internal name of your PCA offer</param>
							/// </summary>
						public async Task<long[]> GetCloudPcaBillingIds(string serviceName,string pcaServiceName,bool? billed = null,DateTime? date_from = null,DateTime? date_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("pcaServiceName",pcaServiceName);

			var queryString = new QueryString();
queryString.Add("date.to",date_to);
queryString.Add("date.from",date_from);
queryString.Add("billed",billed);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/cloud/{0}/pca/{1}/billing{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(pcaServiceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// <param name="serviceName">The internal name of your public cloud passport</param>
							/// </summary>
						public async Task<string[]> GetCloudPcaNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud/{0}/pca",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetCloudNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/cloud"));
		}
				/// <summary>
		/// OVH operating system installation templates
							/// </summary>
						public async Task<string[]> GetDedicatedInstallationtemplateNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/installationTemplate"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.Templates> GetDedicatedInstallationtemplate(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.Templates>(HttpMethod.Get,String.Format("/dedicated/installationTemplate/{0}",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// Partitioning schemes available on this template
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task<string[]> GetDedicatedInstallationtemplatePartitionschemeNames(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/installationTemplate/{0}/partitionScheme",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitioningSchemes> GetDedicatedInstallationtemplatePartitionscheme(string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitioningSchemes>(HttpMethod.Get,String.Format("/dedicated/installationTemplate/{0}/partitionScheme/{1}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())));
		}
				/// <summary>
		/// Partitions defined in this partitioning scheme
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task<string[]> GetDedicatedInstallationtemplatePartitionschemePartitionNames(string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/installationTemplate/{0}/partitionScheme/{1}/partition",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// <param name="mountpoint">partition mount point</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitions> GetDedicatedInstallationtemplatePartitionschemePartition(string templateName,string schemeName,string mountpoint)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);
Ensure.NotNullNorEmpty("mountpoint",mountpoint);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitions>(HttpMethod.Get,String.Format("/dedicated/installationTemplate/{0}/partitionScheme/{1}/partition/{2}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString()),System.Net.WebUtility.UrlEncode(mountpoint.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDedicatedNasServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task UpdateDedicatedNasServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nas/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nas.Nas> GetDedicatedNas(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nas.Nas>(HttpMethod.Get,String.Format("/dedicated/nas/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task UpdateDedicatedNas(OvhApi.Models.Dedicated.Nas.Nas requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nas/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// View task list
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="operation">Filter the value of operation property (=)</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<long[]> GetDedicatedNasTaskIds(string serviceName,OvhApi.Models.Dedicated.Storage.TaskFunctionEnum? operation = null,OvhApi.Models.Dedicated.TaskStatusEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("operation",operation);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/task{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="taskId">id of the task</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> GetDedicatedNasTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Get partition list
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<string[]> GetDedicatedNasPartitionNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/partition",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a  new partition
							/// <param name="protocol"></param>
							/// <param name="partitionName">Partition name</param>
							/// <param name="size">Partition size</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> CreateDedicatedNasPartition(OvhApi.Models.Dedicated.Storage.ProtocolEnum protocol,string partitionName,long size,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.IdIsValid("size",size);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("protocol",protocol);
requestBody.Add("partitionName",partitionName);
requestBody.Add("size",size);

			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Post,String.Format("/dedicated/nas/{0}/partition",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nas.Partition> GetDedicatedNasPartition(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nas.Partition>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task UpdateDedicatedNasPartition(OvhApi.Models.Dedicated.Nas.Partition requestBody,string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nas/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this partition
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> DeleteDedicatedNasPartition(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Delete,String.Format("/dedicated/nas/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Get all IPs that can be used in the ACL
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetDedicatedNasPartitionAuthorizableips(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/partition/{1}/authorizableIps",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// get ACL for this partition
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedNasPartitionAccess(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/partition/{1}/access",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Add an Acl to this  partition
							/// <param name="ip">Ip to add</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> CreateDedicatedNasPartitionAccess(System.Net.IPAddress ip,string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ip",ip);

			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Post,String.Format("/dedicated/nas/{0}/partition/{1}/access",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="ip">the ip in root on storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nas.Access> GetDedicatedNasPartitionAccess(string serviceName,string partitionName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nas.Access>(HttpMethod.Get,String.Format("/dedicated/nas/{0}/partition/{1}/access/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Delete a given snapshot
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="ip">the ip in root on storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> DeleteDedicatedNasPartitionAccess(string serviceName,string partitionName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Delete,String.Format("/dedicated/nas/{0}/partition/{1}/access/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDedicatedNaNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/nas"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDedicatedNashaServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task UpdateDedicatedNashaServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nasha/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nasha.Storage> GetDedicatedNasha(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nasha.Storage>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task UpdateDedicatedNasha(OvhApi.Models.Dedicated.Nasha.Storage requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nasha/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// View task list
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="operation">Filter the value of operation property (=)</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<long[]> GetDedicatedNashaTaskIds(string serviceName,OvhApi.Models.Dedicated.Storage.TaskFunctionEnum? operation = null,OvhApi.Models.Dedicated.TaskStatusEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("operation",operation);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/task{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="taskId">id of the task</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> GetDedicatedNashaTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Get partition list
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<string[]> GetDedicatedNashaPartitionNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new partition
							/// <param name="protocol">NFS|CIFS|NFS_CIFS</param>
							/// <param name="partitionName">Partition name</param>
							/// <param name="size">Partition size</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> CreateDedicatedNashaPartition(OvhApi.Models.Dedicated.Storage.ProtocolEnum protocol,string partitionName,long size,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.IdIsValid("size",size);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("protocol",protocol);
requestBody.Add("partitionName",partitionName);
requestBody.Add("size",size);

			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Post,String.Format("/dedicated/nasha/{0}/partition",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nasha.Partition> GetDedicatedNashaPartition(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nasha.Partition>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task UpdateDedicatedNashaPartition(OvhApi.Models.Dedicated.Nasha.Partition requestBody,string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/nasha/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this partition
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> DeleteDedicatedNashaPartition(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Delete,String.Format("/dedicated/nasha/{0}/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Get all RIPE/ARIN blocks that can be used in the ACL
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedNashaPartitionAuthorizableblocks(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/authorizableBlocks",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Get all IPs that can be used in the ACL
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetDedicatedNashaPartitionAuthorizableips(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/authorizableIps",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// get ACL for this partition
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedNashaPartitionAccess(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/access",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Add a new ACL entry
							/// <param name="ip">Ip or block to add</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> CreateDedicatedNashaPartitionAccess(OVHApi.IPAddressBlock ip,string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ip",ip);

			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Post,String.Format("/dedicated/nasha/{0}/partition/{1}/access",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="ip">the ip in root on storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nasha.Access> GetDedicatedNashaPartitionAccess(string serviceName,string partitionName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nasha.Access>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/access/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Delete an ACL entry
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="ip">the ip in root on storage</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> DeleteDedicatedNashaPartitionAccess(string serviceName,string partitionName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Delete,String.Format("/dedicated/nasha/{0}/partition/{1}/access/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Get scheduled snapshot types for this partition
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Storage.SnapshotEnum[]> GetDedicatedNashaPartitionSnapshots(string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Storage.SnapshotEnum[]>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/snapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())));
		}
				/// <summary>
		/// Schedule a new snapshot type
							/// <param name="snapshotType">Snapshot interval to add</param>
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> CreateDedicatedNashaPartitionSnapshot(OvhApi.Models.Dedicated.Storage.SnapshotEnum snapshotType,string serviceName,string partitionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("snapshotType",snapshotType);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("snapshotType",snapshotType);

			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Post,String.Format("/dedicated/nasha/{0}/partition/{1}/snapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="snapshotType">the interval of snapshot</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Nasha.Snapshot> GetDedicatedNashaPartitionSnapshot(string serviceName,string partitionName,OvhApi.Models.Dedicated.Storage.SnapshotEnum snapshotType)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("snapshotType",snapshotType);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Nasha.Snapshot>(HttpMethod.Get,String.Format("/dedicated/nasha/{0}/partition/{1}/snapshot/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(snapshotType.ToString())));
		}
				/// <summary>
		/// Delete a given snapshot
							/// <param name="serviceName">The internal name of your storage</param>
							/// <param name="partitionName">the given name of partition</param>
							/// <param name="snapshotType">the interval of snapshot</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.NasTask.Task> DeleteDedicatedNashaPartitionSnapshot(string serviceName,string partitionName,OvhApi.Models.Dedicated.Storage.SnapshotEnum snapshotType)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partitionName",partitionName);
Ensure.NotNull("snapshotType",snapshotType);

			
			
			return await RawCall<OvhApi.Models.Dedicated.NasTask.Task>(HttpMethod.Delete,String.Format("/dedicated/nasha/{0}/partition/{1}/snapshot/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partitionName.ToString()),System.Net.WebUtility.UrlEncode(snapshotType.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDedicatedNashaNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/nasha"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDedicatedServerServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/dedicated/server/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task UpdateDedicatedServerServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Move an Ip failover to this server
							/// <param name="ip">The ip to move to this server</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerIpmove(OVHApi.IPAddressBlock ip,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ip",ip);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/ipMove",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Dedicated> GetDedicatedServer(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Dedicated>(HttpMethod.Get,String.Format("/dedicated/server/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task UpdateDedicatedServer(OvhApi.Models.Dedicated.Server.Dedicated requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Merge a splitted block and route it to the choosen server. You cannot undo this operation
							/// <param name="block">The splitted block you want to merge</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerIpblockmerge(OVHApi.IPAddressBlock block,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("block",block);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("block",block);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/ipBlockMerge",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNS> GetDedicatedServerSecondarydnsdomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNS>(HttpMethod.Get,String.Format("/dedicated/server/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task UpdateDedicatedServerSecondarydnsdomains(OvhApi.Models.SecondaryDns.SecondaryDNS requestBody,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// remove this domain
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task DeleteDedicatedServerSecondarydnsdomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/dedicated/server/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// domain name server informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer> GetDedicatedServerSecondarydnsdomainsDnsserver(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer>(HttpMethod.Get,String.Format("/dedicated/server/{0}/secondaryDnsDomains/{1}/dnsServer",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// List of secondary dns domain name
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerSecondarydnsdomainNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/secondaryDnsDomains",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add a domain on secondary dns
							/// <param name="domain">The domain to add</param>
							/// <param name="ip"></param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task CreateDedicatedServerSecondarydnsdomains(string domain,string serviceName,System.Net.IPAddress ip = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);
requestBody.Add("ip",ip);

			await RawCall(HttpMethod.Post,String.Format("/dedicated/server/{0}/secondaryDnsDomains",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Retrieve available country for IP order
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.IpCountryEnum[]> GetDedicatedServerIpcountryavailables(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.IpCountryEnum[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/ipCountryAvailable",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Rtm> GetDedicatedServerStatistics(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Rtm>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get server opened connections
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmConnection[]> GetDedicatedServerStatisticsConnections(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmConnection[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/connection",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retrieve RTM graph values
							/// <param name="period">chart period</param>
							/// <param name="type">RTM chart type</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.ChartReturn> GetDedicatedServerStatisticsChart(OvhApi.Models.Dedicated.Server.RtmChartPeriodEnum period,OvhApi.Models.Dedicated.Server.RtmChartTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.ChartReturn>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/chart{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get server cpu informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmCpu> GetDedicatedServerStatisticsCpu(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmCpu>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/cpu",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get server PCI devices informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmPci[]> GetDedicatedServerStatisticsPcis(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmPci[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/pci",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Server disks
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerStatisticsDiskNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/disk",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="disk">Disk</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmDisk> GetDedicatedServerStatisticsDisk(string serviceName,string disk)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("disk",disk);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmDisk>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/disk/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(disk.ToString())));
		}
				/// <summary>
		/// Get disk smart informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="disk">Disk</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmDiskSmart> GetDedicatedServerStatisticsDiskSmart(string serviceName,string disk)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("disk",disk);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmDiskSmart>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/disk/{1}/smart",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(disk.ToString())));
		}
				/// <summary>
		/// Get server process
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmCommandSize[]> GetDedicatedServerStatisticsProcess(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmCommandSize[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/process",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get server os informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmOs> GetDedicatedServerStatisticsOs(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmOs>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/os",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Server raid informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerStatisticsRaidNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="unit">Raid unit</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmRaid> GetDedicatedServerStatisticsRaid(string serviceName,string unit)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("unit",unit);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmRaid>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(unit.ToString())));
		}
				/// <summary>
		/// Raid unit volumes
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="unit">Raid unit</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerStatisticsRaidVolumeNames(string serviceName,string unit)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("unit",unit);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid/{1}/volume",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(unit.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="unit">Raid unit</param>
							/// <param name="volume">Raid volume name</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmRaidVolume> GetDedicatedServerStatisticsRaidVolume(string serviceName,string unit,string volume)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("unit",unit);
Ensure.NotNullNorEmpty("volume",volume);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmRaidVolume>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid/{1}/volume/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(unit.ToString()),System.Net.WebUtility.UrlEncode(volume.ToString())));
		}
				/// <summary>
		/// Raid unit volume ports
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="unit">Raid unit</param>
							/// <param name="volume">Raid volume name</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerStatisticsRaidVolumePortNames(string serviceName,string unit,string volume)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("unit",unit);
Ensure.NotNullNorEmpty("volume",volume);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid/{1}/volume/{2}/port",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(unit.ToString()),System.Net.WebUtility.UrlEncode(volume.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="unit">Raid unit</param>
							/// <param name="volume">Raid volume name</param>
							/// <param name="port">Raid volume port</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmRaidVolumePort> GetDedicatedServerStatisticsRaidVolumePort(string serviceName,string unit,string volume,string port)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("unit",unit);
Ensure.NotNullNorEmpty("volume",volume);
Ensure.NotNullNorEmpty("port",port);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmRaidVolumePort>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/raid/{1}/volume/{2}/port/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(unit.ToString()),System.Net.WebUtility.UrlEncode(volume.ToString()),System.Net.WebUtility.UrlEncode(port.ToString())));
		}
				/// <summary>
		/// Get server memory informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmMemory[]> GetDedicatedServerStatisticsMemorys(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmMemory[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/memory",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get server load
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmLoad> GetDedicatedServerStatisticsLoad(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmLoad>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/load",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Server partitions
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerStatisticsPartitionNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/partition",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="partition">Partition</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmPartition> GetDedicatedServerStatisticsPartition(string serviceName,string partition)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partition",partition);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmPartition>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/partition/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partition.ToString())));
		}
				/// <summary>
		/// Retrieve partition charts
							/// <param name="period">chart period</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="partition">Partition</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.ChartReturn> GetDedicatedServerStatisticsPartitionChart(OvhApi.Models.Dedicated.Server.RtmChartPeriodEnum period,string serviceName,string partition)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("partition",partition);

			var queryString = new QueryString();
queryString.Add("period",period);

			
			return await RawCall<OvhApi.Models.ComplexType.ChartReturn>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/partition/{1}/chart{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(partition.ToString()),queryString));
		}
				/// <summary>
		/// Get server motherboard hardware informations
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.RtmMotherboardHw> GetDedicatedServerStatisticsMotherboard(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.RtmMotherboardHw>(HttpMethod.Get,String.Format("/dedicated/server/{0}/statistics/motherboard",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// technical intervention history
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<long[]> GetDedicatedServerInterventionIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/intervention",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="interventionId">The intervention id</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Intervention> GetDedicatedServerIntervention(string serviceName,long interventionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("interventionId",interventionId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Intervention>(HttpMethod.Get,String.Format("/dedicated/server/{0}/intervention/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(interventionId.ToString())));
		}
				/// <summary>
		/// List all ip from server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedServerIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/ips",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retrieve traffic graph values
							/// <param name="period">mrtg period</param>
							/// <param name="type">mrtg type</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]> GetDedicatedServerMrtgs(OvhApi.Models.Dedicated.Server.MrtgPeriodEnum period,OvhApi.Models.Dedicated.Server.MrtgTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/mrtg{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Virtual MAC addresses of the server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerVirtualmacNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/virtualMac",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a virtual mac to an IP address
							/// <param name="virtualMachineName">Friendly name of your Virtual Machine behind this IP/MAC</param>
							/// <param name="ipAddress">Ip address to link with this virtualMac</param>
							/// <param name="type">vmac address type</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerVirtualmac(string virtualMachineName,System.Net.IPAddress ipAddress,OvhApi.Models.Dedicated.Server.VmacTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("virtualMachineName",virtualMachineName);
Ensure.NotNull("ipAddress",ipAddress);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("virtualMachineName",virtualMachineName);
requestBody.Add("ipAddress",ipAddress);
requestBody.Add("type",type);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/virtualMac",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="macAddress">Virtual MAC address in 00:00:00:00:00:00 format</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.VirtualMac> GetDedicatedServerVirtualmac(string serviceName,string macAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.VirtualMac>(HttpMethod.Get,String.Format("/dedicated/server/{0}/virtualMac/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString())));
		}
				/// <summary>
		/// List of IPs associated to this Virtual MAC
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="macAddress">Virtual MAC address in 00:00:00:00:00:00 format</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetDedicatedServerVirtualmacVirtualaddress(string serviceName,string macAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/virtualMac/{1}/virtualAddress",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString())));
		}
				/// <summary>
		/// Add an IP to this Virtual MAC
							/// <param name="virtualMachineName">Friendly name of your Virtual Machine behind this IP/MAC</param>
							/// <param name="ipAddress">IP address to link to this virtual MAC</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="macAddress">Virtual MAC address in 00:00:00:00:00:00 format</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerVirtualmacVirtualaddress(string virtualMachineName,System.Net.IPAddress ipAddress,string serviceName,string macAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("virtualMachineName",virtualMachineName);
Ensure.NotNull("ipAddress",ipAddress);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("virtualMachineName",virtualMachineName);
requestBody.Add("ipAddress",ipAddress);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/virtualMac/{1}/virtualAddress",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="macAddress">Virtual MAC address in 00:00:00:00:00:00 format</param>
							/// <param name="ipAddress">IP address</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.VirtualMacManagement> GetDedicatedServerVirtualmacVirtualaddress(string serviceName,string macAddress,System.Net.IPAddress ipAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);
Ensure.NotNull("ipAddress",ipAddress);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.VirtualMacManagement>(HttpMethod.Get,String.Format("/dedicated/server/{0}/virtualMac/{1}/virtualAddress/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString()),System.Net.WebUtility.UrlEncode(ipAddress.ToString())));
		}
				/// <summary>
		/// Remove this ip from virtual mac , if you remove the last linked Ip, virtualmac will be deleted
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="macAddress">Virtual MAC address in 00:00:00:00:00:00 format</param>
							/// <param name="ipAddress">IP address</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> DeleteDedicatedServerVirtualmacVirtualaddress(string serviceName,string macAddress,System.Net.IPAddress ipAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);
Ensure.NotNull("ipAddress",ipAddress);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Delete,String.Format("/dedicated/server/{0}/virtualMac/{1}/virtualAddress/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString()),System.Net.WebUtility.UrlEncode(ipAddress.ToString())));
		}
				/// <summary>
		/// DNS field to temporarily add to your zone so that we can verify you are the owner of this domain
							/// <param name="domain">The domain to check</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNSCheckField> GetDedicatedServerSecondarydnsnamedomaintoken(string domain,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("domain",domain);

			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNSCheckField>(HttpMethod.Get,String.Format("/dedicated/server/{0}/secondaryDnsNameDomainToken{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Check if given IP can be moved to this server
							/// <param name="ip">The ip to move to this server</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task GetDedicatedServerIpcanbemovedto(OVHApi.IPAddressBlock ip,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			await RawCall(HttpMethod.Get,String.Format("/dedicated/server/{0}/ipCanBeMovedTo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Hard reboot this server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerReboot(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/reboot",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Firewall> GetDedicatedServerFeaturesFirewall(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Firewall>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/firewall",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task UpdateDedicatedServerFeaturesFirewall(OvhApi.Models.Dedicated.Server.Firewall requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/features/firewall",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BackupFtp> GetDedicatedServerFeaturesBackupftp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BackupFtp>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/backupFTP",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new Backup FTP space
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesBackupftp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/backupFTP",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Terminate your Backup FTP service, ALL DATA WILL BE PERMANENTLY DELETED
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> DeleteDedicatedServerFeaturesBackupftp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Delete,String.Format("/dedicated/server/{0}/features/backupFTP",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Change your Backup FTP password
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesBackupftpPassword(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/backupFTP/password",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get all IP blocks that can be used in the ACL
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedServerFeaturesBackupftpAuthorizableblocks(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/backupFTP/authorizableBlocks",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of IP blocks (and protocols to allow on these blocks) authorized on your backup FTP
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedServerFeaturesBackupftpAccess(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/backupFTP/access",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new Backup FTP ACL
							/// <param name="ftp">Wether to allow the FTP protocol for this ACL</param>
							/// <param name="ipBlock">The IP Block specific to this ACL. It musts belong to your server.</param>
							/// <param name="nfs">Wether to allow the NFS protocol for this ACL</param>
							/// <param name="cifs">Wether to allow the CIFS (SMB) protocol for this ACL</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesBackupftpAccess(OVHApi.IPAddressBlock ipBlock,bool nfs,bool cifs,string serviceName,bool? ftp = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipBlock",ipBlock);
Ensure.NotNull("nfs",nfs);
Ensure.NotNull("cifs",cifs);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ftp",ftp);
requestBody.Add("ipBlock",ipBlock);
requestBody.Add("nfs",nfs);
requestBody.Add("cifs",cifs);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/backupFTP/access",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BackupFtpAcl> GetDedicatedServerFeaturesBackupftpAccess(string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BackupFtpAcl>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/backupFTP/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task UpdateDedicatedServerFeaturesBackupftpAccess(OvhApi.Models.Dedicated.Server.BackupFtpAcl requestBody,string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/features/backupFTP/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())),requestBody);
		}
				/// <summary>
		/// Revoke this ACL
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> DeleteDedicatedServerFeaturesBackupftpAccess(string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Delete,String.Format("/dedicated/server/{0}/features/backupFTP/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Ipmi> GetDedicatedServerFeaturesIpmi(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Ipmi>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/ipmi",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Launch test on KVM IPMI interface
							/// <param name="ttl">Result time to live in minutes</param>
							/// <param name="type">Test to make on KVM IPMI interface</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesIpmiTest(OvhApi.Models.Dedicated.Server.CacheTTLEnum ttl,OvhApi.Models.Dedicated.Server.IpmiTestTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ttl",ttl);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ttl",ttl);
requestBody.Add("type",type);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/ipmi/test",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Result of http, ping and identification tests on IPMI interface
							/// <param name="type">Test type result on KVM IPMI interface</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.IpmiTestResult> GetDedicatedServerFeaturesIpmiTest(OvhApi.Models.Dedicated.Server.IpmiTestTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Dedicated.Server.IpmiTestResult>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/ipmi/test{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Reset KVM IPMI interface
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesIpmiResetinterface(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/ipmi/resetInterface",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Request an acces on KVM IPMI interface
							/// <param name="ipToAllow">IP to allow connection from for this IPMI session</param>
							/// <param name="sshKey">SSH key name to allow access on KVM/IP interface with (name from /me/sshKey)</param>
							/// <param name="ttl">Session access time to live in minutes</param>
							/// <param name="type">IPMI console access</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesIpmiAccess(OvhApi.Models.Dedicated.Server.CacheTTLEnum ttl,OvhApi.Models.Dedicated.Server.IpmiAccessTypeEnum type,string serviceName,string sshKey = null,System.Net.IPAddress ipToAllow = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ttl",ttl);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipToAllow",ipToAllow);
requestBody.Add("sshKey",sshKey);
requestBody.Add("ttl",ttl);
requestBody.Add("type",type);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/ipmi/access",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// IPMI access method
							/// <param name="type">IPMI console access</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.IpmiAccessValue> GetDedicatedServerFeaturesIpmiAccess(OvhApi.Models.Dedicated.Server.IpmiAccessTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Dedicated.Server.IpmiAccessValue>(HttpMethod.Get,String.Format("/dedicated/server/{0}/features/ipmi/access{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Reset KVM IPMI sessions
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerFeaturesIpmiResetsessions(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/features/ipmi/resetSessions",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retreive compatible  install templates names
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.InstallTemplate> GetDedicatedServerInstallCompatibletemplates(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.InstallTemplate>(HttpMethod.Get,String.Format("/dedicated/server/{0}/install/compatibleTemplates",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get installation status
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.InstallationProgressStatus> GetDedicatedServerInstallStatus(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.InstallationProgressStatus>(HttpMethod.Get,String.Format("/dedicated/server/{0}/install/status",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retreive compatible  install template partitions scheme
							/// <param name="templateName">To be written</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerInstallCompatibletemplatepartitionschemeNames(string templateName,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("templateName",templateName);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/install/compatibleTemplatePartitionSchemes{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Start an install
							/// <param name="templateName">Template name</param>
							/// <param name="partitionSchemeName">Partition scheme name</param>
							/// <param name="details">parameters for default install</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerInstallStart(string templateName,string serviceName,OvhApi.Models.Dedicated.Server.InstallCustom details = null,string partitionSchemeName = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("templateName",templateName);
requestBody.Add("partitionSchemeName",partitionSchemeName);
requestBody.Add("details",details);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/install/start",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.ServerBurst> GetDedicatedServerBurst(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.ServerBurst>(HttpMethod.Get,String.Format("/dedicated/server/{0}/burst",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task UpdateDedicatedServerBurst(OvhApi.Models.Dedicated.Server.ServerBurst requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/burst",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get bandwidth orderable with your server.
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BandwidthOrderable> GetDedicatedServerOrderableBandwidth(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BandwidthOrderable>(HttpMethod.Get,String.Format("/dedicated/server/{0}/orderable/bandwidth",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Is professional use orderable with your server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<bool> GetDedicatedServerOrderableProfessionaluse(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<bool>(HttpMethod.Get,String.Format("/dedicated/server/{0}/orderable/professionalUse",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get IP orderable with your server.
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.IpOrderable> GetDedicatedServerOrderableIp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.IpOrderable>(HttpMethod.Get,String.Format("/dedicated/server/{0}/orderable/ip",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get USB keys orderable with your server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.UsbKeyOrderableDetails> GetDedicatedServerOrderableUsbkey(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.UsbKeyOrderableDetails>(HttpMethod.Get,String.Format("/dedicated/server/{0}/orderable/usbKey",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get the backup storage orderable with your server.
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BackupStorageOrderable> GetDedicatedServerOrderableBackupstorage(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BackupStorageOrderable>(HttpMethod.Get,String.Format("/dedicated/server/{0}/orderable/backupStorage",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Dedicated server todos
							/// <param name="function">Filter the value of function property (=)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<long[]> GetDedicatedServerTaskIds(string serviceName,OvhApi.Models.Dedicated.TaskStatusEnum? status = null,OvhApi.Models.Dedicated.TaskFunctionEnum? function = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("function",function);
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/task{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="taskId">the id of the task</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> GetDedicatedServerTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Get,String.Format("/dedicated/server/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// this action stop the task progression if it's possible
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="taskId">the id of the task</param>
							/// </summary>
						public async Task CreateDedicatedServerTaskCancel(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			await RawCall(HttpMethod.Post,String.Format("/dedicated/server/{0}/task/{1}/cancel",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Add your existing windows license serial to this dedicated server. Will be manageable in /license/windows.
							/// <param name="licenseId">Your license serial number</param>
							/// <param name="version">Your license version</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateDedicatedServerLicenseWindows(string licenseId,OvhApi.Models.License.WindowsOsVersionEnum version,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("licenseId",licenseId);
Ensure.NotNull("version",version);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("licenseId",licenseId);
requestBody.Add("version",version);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/dedicated/server/{0}/license/windows",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get the windows SQL server license compliant with your server.
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.License.WindowsSqlVersionEnum[]> GetDedicatedServerLicenseCompliantwindowssqlservers(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.WindowsSqlVersionEnum[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/license/compliantWindowsSqlServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get the windows license compliant with your server.
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.License.WindowsOsVersionEnum[]> GetDedicatedServerLicenseCompliantwindows(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.WindowsOsVersionEnum[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/license/compliantWindows",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Server Vracks
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<string[]> GetDedicatedServerVrackNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/vrack",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="vrack">vrack (1.5) name</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.DedicatedServer> GetDedicatedServerVrack(string serviceName,string vrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("vrack",vrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.DedicatedServer>(HttpMethod.Get,String.Format("/dedicated/server/{0}/vrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vrack.ToString())));
		}
				/// <summary>
		/// remove this server from this vrack (1.5)
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="vrack">vrack (1.5) name</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteDedicatedServerVrack(string serviceName,string vrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("vrack",vrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/dedicated/server/{0}/vrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vrack.ToString())));
		}
				/// <summary>
		/// Retrieve vrack traffic graph values
							/// <param name="period">mrtg period</param>
							/// <param name="type">mrtg type</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="vrack">vrack (1.5) name</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]> GetDedicatedServerVrackMrtgs(OvhApi.Models.Dedicated.Server.MrtgPeriodEnum period,OvhApi.Models.Dedicated.Server.MrtgTypeEnum type,string serviceName,string vrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("vrack",vrack);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/vrack/{1}/mrtg{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vrack.ToString()),queryString));
		}
				/// <summary>
		/// Your own SPLA licenses attached to this dedicated server
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="type">Filter the value of type property (=)</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<long[]> GetDedicatedServerSplaIds(string serviceName,OvhApi.Models.Dedicated.Server.SplaTypeEnum? type = null,OvhApi.Models.Dedicated.Server.SplaStatusEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("type",type);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/spla{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Add a new SPLA license
							/// <param name="type">License type</param>
							/// <param name="serialNumber">License serial number</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<long> CreateDedicatedServerSpla(OvhApi.Models.Dedicated.Server.SplaTypeEnum type,string serialNumber,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serialNumber",serialNumber);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("type",type);
requestBody.Add("serialNumber",serialNumber);

			return await RawCall<long>(HttpMethod.Post,String.Format("/dedicated/server/{0}/spla",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="id">License id</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Spla> GetDedicatedServerSpla(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Spla>(HttpMethod.Get,String.Format("/dedicated/server/{0}/spla/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="id">License id</param>
							/// </summary>
						public async Task UpdateDedicatedServerSpla(OvhApi.Models.Dedicated.Server.Spla requestBody,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicated/server/{0}/spla/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Revoke an SPLA license
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="id">License id</param>
							/// </summary>
						public async Task CreateDedicatedServerSplaRevoke(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Post,String.Format("/dedicated/server/{0}/spla/{1}/revoke",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Server compatibles netboots
							/// <param name="bootType">Filter the value of bootType property (=)</param>
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<long[]> GetDedicatedServerBootIds(string serviceName,OvhApi.Models.Dedicated.Server.BootTypeEnum? bootType = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("bootType",bootType);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/boot{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="bootId">boot id</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Netboot> GetDedicatedServerBoot(string serviceName,long bootId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("bootId",bootId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Netboot>(HttpMethod.Get,String.Format("/dedicated/server/{0}/boot/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(bootId.ToString())));
		}
				/// <summary>
		/// Option used on this netboot
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="bootId">boot id</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BootOptionEnum[]> GetDedicatedServerBootOptions(string serviceName,long bootId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("bootId",bootId);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BootOptionEnum[]>(HttpMethod.Get,String.Format("/dedicated/server/{0}/boot/{1}/option",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(bootId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// <param name="bootId">boot id</param>
							/// <param name="option">The option of this boot</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.NetbootOption> GetDedicatedServerBootOption(string serviceName,long bootId,OvhApi.Models.Dedicated.Server.BootOptionEnum option)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("bootId",bootId);
Ensure.NotNull("option",option);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.NetbootOption>(HttpMethod.Get,String.Format("/dedicated/server/{0}/boot/{1}/option/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(bootId.ToString()),System.Net.WebUtility.UrlEncode(option.ToString())));
		}
				/// <summary>
		/// Retrieve network informations about this dedicated server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.NetworkSpecifications> GetDedicatedServerSpecificationsNetwork(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.NetworkSpecifications>(HttpMethod.Get,String.Format("/dedicated/server/{0}/specifications/network",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retrieve IP capabilities about this dedicated server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.IpOrderable> GetDedicatedServerSpecificationsIp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.IpOrderable>(HttpMethod.Get,String.Format("/dedicated/server/{0}/specifications/ip",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Retrieve hardware informations about this dedicated server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.HardwareSpecifications> GetDedicatedServerSpecificationsHardware(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.HardwareSpecifications>(HttpMethod.Get,String.Format("/dedicated/server/{0}/specifications/hardware",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Secondary nameServer available for your Server
							/// <param name="serviceName">The internal name of your dedicated server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer> GetDedicatedServerSecondarydnsnameserveravailable(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer>(HttpMethod.Get,String.Format("/dedicated/server/{0}/secondaryDnsNameServerAvailable",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDedicatedServerNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicated/server"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDedicatedcloudServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task UpdateDedicatedcloudServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.DedicatedCloud> GetDedicatedcloud(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.DedicatedCloud>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task UpdateDedicatedcloud(OvhApi.Models.DedicatedCloud.DedicatedCloud requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Datacenters associated with this Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudDatacenterIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a new Datacenter in your Dedicated Cloud
							/// <param name="commercialRangeName">The commercial range of this new datacenter (if not set dedicatedCloud2013v1 is the default value). You can see what commercial ranges are orderable on this API section : /dedicatedCloud/commercialRange/</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudDatacenter(string serviceName,string commercialRangeName = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("commercialRangeName",commercialRangeName);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/datacenter",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Datacenter> GetDedicatedcloudDatacenter(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Datacenter>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task UpdateDedicatedcloudDatacenter(OvhApi.Models.DedicatedCloud.Datacenter requestBody,string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}/datacenter/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())),requestBody);
		}
				/// <summary>
		/// Remove this Datacenter from your Dedicated Cloud. (It has to be empty in order to be removable)
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> DeleteDedicatedcloudDatacenter(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Delete,String.Format("/dedicatedCloud/{0}/datacenter/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Order a new hourly Host in a given Datacenter
							/// <param name="name">Host profile you want to order</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudDatacenterOrdernewhosthourly(string name,string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("name",name);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/datacenter/{1}/orderNewHostHourly",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())),requestBody);
		}
				/// <summary>
		/// Tasks associated with this Datacenter
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudDatacenterTaskIds(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/task",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> GetDedicatedcloudDatacenterTask(string serviceName,long datacenterId,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/task/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// List available filers in a given Dedicated Cloud Datacenter
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Filer.Profile[]> GetDedicatedcloudDatacenterOrderablefilerprofiles(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Filer.Profile[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/orderableFilerProfiles",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Filers associated with this Datacenter
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudDatacenterFilerIds(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/filer",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// <param name="filerId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Filer> GetDedicatedcloudDatacenterFiler(string serviceName,long datacenterId,long filerId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);
Ensure.IdIsValid("filerId",filerId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Filer>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/filer/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString()),System.Net.WebUtility.UrlEncode(filerId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// <param name="hostId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Host> GetDedicatedcloudDatacenterHost(string serviceName,long datacenterId,long hostId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);
Ensure.IdIsValid("hostId",hostId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Host>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/host/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString()),System.Net.WebUtility.UrlEncode(hostId.ToString())));
		}
				/// <summary>
		/// Hosts associated with this Datacenter
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudDatacenterHostIds(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/host",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Order a new hourly Filer in a given Datacenter
							/// <param name="name">Filer profile you want to order</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudDatacenterOrdernewfilerhourly(string name,string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("name",name);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/datacenter/{1}/orderNewFilerHourly",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())),requestBody);
		}
				/// <summary>
		/// List available hosts in a given Dedicated Cloud Datacenter
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Host.Profile[]> GetDedicatedcloudDatacenterOrderablehostprofiles(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Host.Profile[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/orderableHostProfiles",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Backup> GetDedicatedcloudDatacenterBackup(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Backup>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/datacenter/{1}/backup",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Enable a Backup on this dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudDatacenterBackup(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/datacenter/{1}/backup",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Remove this Backup from your Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="datacenterId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> DeleteDedicatedcloudDatacenterBackup(string serviceName,long datacenterId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("datacenterId",datacenterId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Delete,String.Format("/dedicatedCloud/{0}/datacenter/{1}/backup",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(datacenterId.ToString())));
		}
				/// <summary>
		/// Ip Blocks attached to this Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetDedicatedcloudIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/ip",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="network">IP ex: 213.186.33.34/24</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Ip> GetDedicatedcloudIp(string serviceName,OVHApi.IPAddressBlock network)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("network",network);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Ip>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/ip/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(network.ToString())));
		}
				/// <summary>
		/// Tasks associated with this Dedicated Cloud
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudTaskIds(string serviceName,OvhApi.Models.DedicatedCloud.TaskStateEnum? state = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("state",state);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/task{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> GetDedicatedcloudTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Get the name of the commercial ranges compliant with your Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<string[]> GetDedicatedcloudCommercialrangeComplianceNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/commercialRange/compliance",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get the name of the commercial ranges orderable in your Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<string[]> GetDedicatedcloudCommercialrangeOrderableNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/commercialRange/orderable",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Filers mounted on all Datacenters of your Dedicated Cloud Vsphere
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudFilerIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/filer",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="filerId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Filer> GetDedicatedcloudFiler(string serviceName,long filerId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("filerId",filerId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Filer>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/filer/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(filerId.ToString())));
		}
				/// <summary>
		/// Dedicated Cloud vlans
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudVlanIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/vlan",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="vlanId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Vlan> GetDedicatedcloudVlan(string serviceName,long vlanId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("vlanId",vlanId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Vlan>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/vlan/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vlanId.ToString())));
		}
				/// <summary>
		/// Order a new hourly Filer mounted in every Datacenter of a given Dedicated Cloud
							/// <param name="name">Filer profile you want to order</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudOrdernewfilerhourly(string name,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("name",name);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/orderNewFilerHourly",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// This Dedicated Cloud vrack
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<string[]> GetDedicatedcloudVrackNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/vrack",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="vrack">vrack (1.5) name</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.DedicatedCloud> GetDedicatedcloudVrack(string serviceName,string vrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("vrack",vrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.DedicatedCloud>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/vrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vrack.ToString())));
		}
				/// <summary>
		/// remove this a dedicatedCloud from this vrack (1.5)
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="vrack">vrack (1.5) name</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteDedicatedcloudVrack(string serviceName,string vrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("vrack",vrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/dedicatedCloud/{0}/vrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(vrack.ToString())));
		}
				/// <summary>
		/// Networks allowed to access to this Dedicated Cloud management interface
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudAllowednetworkIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/allowedNetwork",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new Allowed network for your dedicatedCloud
							/// <param name="network">Network name, e.g. 123.100.200.0/32</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudAllowednetwork(OVHApi.IPAddressBlock network,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("network",network);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("network",network);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/allowedNetwork",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="networkAccessId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.AllowedNetwork> GetDedicatedcloudAllowednetwork(string serviceName,long networkAccessId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("networkAccessId",networkAccessId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.AllowedNetwork>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/allowedNetwork/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(networkAccessId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="networkAccessId">To be written</param>
							/// </summary>
						public async Task UpdateDedicatedcloudAllowednetwork(OvhApi.Models.DedicatedCloud.AllowedNetwork requestBody,string serviceName,long networkAccessId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("networkAccessId",networkAccessId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}/allowedNetwork/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(networkAccessId.ToString())),requestBody);
		}
				/// <summary>
		/// Remove this network from your Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="networkAccessId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> DeleteDedicatedcloudAllowednetwork(string serviceName,long networkAccessId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("networkAccessId",networkAccessId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Delete,String.Format("/dedicatedCloud/{0}/allowedNetwork/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(networkAccessId.ToString())));
		}
				/// <summary>
		/// Upgrade your hypervisor to the next released version
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudUpgradehypervisor(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/upgradeHypervisor",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Capabilities> GetDedicatedcloudCapabilities(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Capabilities>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/capabilities",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Dedicated Cloud users
							/// <param name="name">Filter the value of name property (like)</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudUserIds(string serviceName,string name = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("name",name);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/user{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Create a new User in your Dedicated Cloud
							/// <param name="canAddRessource">Is this User able to add ressources in the Datacenter he has access ? (default is no right to add ressource)</param>
							/// <param name="email">The user email. If this field is empty, on a call to POST /dedicatedCloud/{serviceName}/user/{userId}/resetPassword, user informations will be sent to the dedicatedCloud administrator contact.</param>
							/// <param name="right">Determine what kind of access the User will have in all Datacenters of your Dedicated Cloud (default is disabled)</param>
							/// <param name="name">The user name</param>
							/// <param name="vmNetworkRole">Determine how this user will be able to act on this Dedicated Cloud VM Nertwork</param>
							/// <param name="networkRole">Determine how this user will be able to act on this Dedicated Cloud v(x)Lans</param>
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudUser(string name,string serviceName,OvhApi.Models.DedicatedCloud.Right.NetworkRoleEnum? networkRole = null,OvhApi.Models.DedicatedCloud.Right.VmNetworkRoleEnum? vmNetworkRole = null,OvhApi.Models.DedicatedCloud.Right.RightEnum? right = null,string email = null,bool? canAddRessource = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("canAddRessource",canAddRessource);
requestBody.Add("email",email);
requestBody.Add("right",right);
requestBody.Add("name",name);
requestBody.Add("vmNetworkRole",vmNetworkRole);
requestBody.Add("networkRole",networkRole);

			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/user",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.User> GetDedicatedcloudUser(string serviceName,long userId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.User>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// </summary>
						public async Task UpdateDedicatedcloudUser(OvhApi.Models.DedicatedCloud.User requestBody,string serviceName,long userId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString())),requestBody);
		}
				/// <summary>
		/// Remove a given user from your Dedicated Cloud
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> DeleteDedicatedcloudUser(string serviceName,long userId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Delete,String.Format("/dedicatedCloud/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString())));
		}
				/// <summary>
		/// User rights in a given Datacenters
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// </summary>
						public async Task<long[]> GetDedicatedcloudUserRightIds(string serviceName,long userId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/user/{1}/right",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// <param name="rightId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Right> GetDedicatedcloudUserRight(string serviceName,long userId,long rightId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);
Ensure.IdIsValid("rightId",rightId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Right>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/user/{1}/right/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString()),System.Net.WebUtility.UrlEncode(rightId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// <param name="rightId">To be written</param>
							/// </summary>
						public async Task UpdateDedicatedcloudUserRight(OvhApi.Models.DedicatedCloud.Right requestBody,string serviceName,long userId,long rightId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);
Ensure.IdIsValid("rightId",rightId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/dedicatedCloud/{0}/user/{1}/right/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString()),System.Net.WebUtility.UrlEncode(rightId.ToString())),requestBody);
		}
				/// <summary>
		/// Reset the password for a given Dedicated Cloud user 
							/// <param name="serviceName">Domain of the service</param>
							/// <param name="userId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.Task> CreateDedicatedcloudUserResetpassword(string serviceName,long userId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("userId",userId);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.Task>(HttpMethod.Post,String.Format("/dedicatedCloud/{0}/user/{1}/resetPassword",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(userId.ToString())));
		}
				/// <summary>
		/// Get the countries you can select in /order/dedicatedCloud/{serviceName}/ip
							/// <param name="serviceName">Domain of the service</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.IpCountriesEnum[]> GetDedicatedcloudOrderableipcountries(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.IpCountriesEnum[]>(HttpMethod.Get,String.Format("/dedicatedCloud/{0}/orderableIpCountries",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDedicatedcloudNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicatedCloud"));
		}
				/// <summary>
		/// List of commercial Ranges available in a Dedicated Cloud
							/// </summary>
						public async Task<string[]> GetDedicatedcloudCommercialrangeNames()
		{
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/dedicatedCloud/commercialRange"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="commercialRangeName">The name of this commercial range</param>
							/// </summary>
						public async Task<OvhApi.Models.DedicatedCloud.CommercialRange> GetDedicatedcloudCommercialrange(string commercialRangeName)
		{
					Ensure.NotNullNorEmpty("commercialRangeName",commercialRangeName);

			
			
			return await RawCall<OvhApi.Models.DedicatedCloud.CommercialRange>(HttpMethod.Get,String.Format("/dedicatedCloud/commercialRange/{0}",System.Net.WebUtility.UrlEncode(commercialRangeName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDomainServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/domain/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task UpdateDomainServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/domain/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Domain> GetDomain(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Domain.Domain>(HttpMethod.Get,String.Format("/domain/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task UpdateDomain(OvhApi.Models.Domain.Domain requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/domain/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Domain pending tasks
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<long[]> GetDomainTaskIds(string serviceName,OvhApi.Models.Domain.OperationStatusEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/domain/{0}/task{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your domain</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Task> GetDomainTask(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Domain.Task>(HttpMethod.Get,String.Format("/domain/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of whois obfuscators
							/// <param name="field">Filter the value of field property (=)</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum[]> GetDomainOwos(string serviceName,OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum? field = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("field",field);

			
			return await RawCall<OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum[]>(HttpMethod.Get,String.Format("/domain/{0}/owo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Add whois obfuscators
							/// <param name="fields">Fields to obfuscate</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum[]> CreateDomainOwos(OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum[] fields,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("fields",fields);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("fields",fields);

			return await RawCall<OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum[]>(HttpMethod.Post,String.Format("/domain/{0}/owo",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your domain</param>
							/// <param name="field">Obfuscated field</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Owo> GetDomainOwo(string serviceName,OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum field)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("field",field);

			
			
			return await RawCall<OvhApi.Models.Domain.Owo>(HttpMethod.Get,String.Format("/domain/{0}/owo/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(field.ToString())));
		}
				/// <summary>
		/// Delete a whois obfuscator
							/// <param name="serviceName">The internal name of your domain</param>
							/// <param name="field">Obfuscated field</param>
							/// </summary>
						public async Task DeleteDomainOwo(string serviceName,OvhApi.Models.Domain.WhoisObfuscatorFieldsEnum field)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("field",field);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/domain/{0}/owo/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(field.ToString())));
		}
				/// <summary>
		/// List of current name servers
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<long[]> GetDomainNameserverIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/domain/{0}/nameServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add new name server
							/// <param name="nameServer">New name server</param>
							/// <param name="serviceName">The internal name of your domain</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Task> CreateDomainNameserver(OvhApi.Models.Domain.DomainNs[] nameServer,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("nameServer",nameServer);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("nameServer",nameServer);

			return await RawCall<OvhApi.Models.Domain.Task>(HttpMethod.Post,String.Format("/domain/{0}/nameServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your domain</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.CurrentNameServer> GetDomainNameserver(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Domain.CurrentNameServer>(HttpMethod.Get,String.Format("/domain/{0}/nameServer/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete a name server
							/// <param name="serviceName">The internal name of your domain</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Task> DeleteDomainNameserver(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Domain.Task>(HttpMethod.Delete,String.Format("/domain/{0}/nameServer/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDomainNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/domain"));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetDomainZoneNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/domain/zone"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetDomainZoneServiceinfos(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/domain/zone/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task UpdateDomainZoneServiceinfos(OvhApi.Models.Services.Service requestBody,string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/domain/zone/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(zoneName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Zone.Zone> GetDomainZone(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			return await RawCall<OvhApi.Models.Domain.Zone.Zone>(HttpMethod.Get,String.Format("/domain/zone/{0}",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Refresh zone
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task CreateDomainZoneRefresh(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			await RawCall(HttpMethod.Post,String.Format("/domain/zone/{0}/refresh",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Records of the zone
							/// <param name="fieldType">Filter the value of fieldType property (like)</param>
							/// <param name="subDomain">Filter the value of subDomain property (like)</param>
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<long[]> GetDomainZoneRecordIds(string zoneName,string subDomain = null,OvhApi.Models.Zone.NamedResolutionFieldTypeEnum? fieldType = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			var queryString = new QueryString();
queryString.Add("fieldType",fieldType);
queryString.Add("subDomain",subDomain);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/domain/zone/{0}/record{1}",System.Net.WebUtility.UrlEncode(zoneName.ToString()),queryString));
		}
				/// <summary>
		/// Create a new resource record
							/// <param name="target">Resource record target</param>
							/// <param name="ttl">Resource record ttl</param>
							/// <param name="fieldType">Resource record Name</param>
							/// <param name="subDomain">Resource record subdomain</param>
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Zone.Record> CreateDomainZoneRecord(string target,OvhApi.Models.Zone.NamedResolutionFieldTypeEnum fieldType,string zoneName,string subDomain = null,long? ttl = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("target",target);
Ensure.NotNull("fieldType",fieldType);
Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("target",target);
requestBody.Add("ttl",ttl);
requestBody.Add("fieldType",fieldType);
requestBody.Add("subDomain",subDomain);

			return await RawCall<OvhApi.Models.Domain.Zone.Record>(HttpMethod.Post,String.Format("/domain/zone/{0}/record",System.Net.WebUtility.UrlEncode(zoneName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="zoneName">The internal name of your zone</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Zone.Record> GetDomainZoneRecord(string zoneName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Domain.Zone.Record>(HttpMethod.Get,String.Format("/domain/zone/{0}/record/{1}",System.Net.WebUtility.UrlEncode(zoneName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="zoneName">The internal name of your zone</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task UpdateDomainZoneRecord(OvhApi.Models.Domain.Zone.Record requestBody,string zoneName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("zoneName",zoneName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/domain/zone/{0}/record/{1}",System.Net.WebUtility.UrlEncode(zoneName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Delete a resource record
							/// <param name="zoneName">The internal name of your zone</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteDomainZoneRecord(string zoneName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/domain/zone/{0}/record/{1}",System.Net.WebUtility.UrlEncode(zoneName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Export zone
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<string> GetDomainZoneExport(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			return await RawCall<string>(HttpMethod.Get,String.Format("/domain/zone/{0}/export",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Zone.Dnssec> GetDomainZoneDnssec(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			return await RawCall<OvhApi.Models.Domain.Zone.Dnssec>(HttpMethod.Get,String.Format("/domain/zone/{0}/dnssec",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Enable Dnssec
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task CreateDomainZoneDnssec(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			await RawCall(HttpMethod.Post,String.Format("/domain/zone/{0}/dnssec",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Disable Dnssec
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task DeleteDomainZoneDnssec(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/domain/zone/{0}/dnssec",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task<OvhApi.Models.Domain.Zone.Soa> GetDomainZoneSoa(string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			return await RawCall<OvhApi.Models.Domain.Zone.Soa>(HttpMethod.Get,String.Format("/domain/zone/{0}/soa",System.Net.WebUtility.UrlEncode(zoneName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="zoneName">The internal name of your zone</param>
							/// </summary>
						public async Task UpdateDomainZoneSoa(OvhApi.Models.Domain.Zone.Soa requestBody,string zoneName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("zoneName",zoneName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/domain/zone/{0}/soa",System.Net.WebUtility.UrlEncode(zoneName.ToString())),requestBody);
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetEmailExchangeNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange"));
		}
				/// <summary>
		/// List available services
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceNames(string organizationName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service",System.Net.WebUtility.UrlEncode(organizationName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetEmailExchangeServiceServiceinfos(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceServiceinfos(OvhApi.Models.Services.Service requestBody,string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/serviceInfos",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeService> GetEmailExchangeService(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeService>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task UpdateEmailExchangeService(OvhApi.Models.Email.Exchange.ExchangeService requestBody,string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Accounts associated to this exchange service
							/// <param name="primaryEmailAddress">Filter the value of primaryEmailAddress property (like)</param>
							/// <param name="accountLicense">Filter the value of accountLicense property (=)</param>
							/// <param name="id">Filter the value of id property (like)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceAccountNames(string organizationName,string exchangeService,long? id = null,OvhApi.Models.Email.Exchange.OvhLicenceEnum? accountLicense = null,string primaryEmailAddress = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("primaryEmailAddress",primaryEmailAddress);
queryString.Add("accountLicense",accountLicense);
queryString.Add("id",id);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// Create new mailbox in exchange server
							/// <param name="initials">Account initials</param>
							/// <param name="firstName">Account first name</param>
							/// <param name="hiddenFromGAL">Hide the account in Global Address List</param>
							/// <param name="license">Exchange license</param>
							/// <param name="login">Account login</param>
							/// <param name="domain">Email domain</param>
							/// <param name="password">Account password</param>
							/// <param name="SAMAccountName">SAM account name (exchange 2010 login)</param>
							/// <param name="mailingFilter">Enable mailing filtrering</param>
							/// <param name="lastName">Account last name</param>
							/// <param name="outlookLicense">Buy outlook license</param>
							/// <param name="displayName">Account display name</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccount(OvhApi.Models.Email.Exchange.OvhLicenceEnum license,string login,string domain,string password,string organizationName,string exchangeService,string displayName = null,bool? outlookLicense = null,string lastName = null,OvhApi.Models.Email.Exchange.MailingFilterEnum[] mailingFilter = null,string SAMAccountName = null,bool? hiddenFromGAL = null,string firstName = null,string initials = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("license",license);
Ensure.NotNullNorEmpty("login",login);
Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("initials",initials);
requestBody.Add("firstName",firstName);
requestBody.Add("hiddenFromGAL",hiddenFromGAL);
requestBody.Add("license",license);
requestBody.Add("login",login);
requestBody.Add("domain",domain);
requestBody.Add("password",password);
requestBody.Add("SAMAccountName",SAMAccountName);
requestBody.Add("mailingFilter",mailingFilter);
requestBody.Add("lastName",lastName);
requestBody.Add("outlookLicense",outlookLicense);
requestBody.Add("displayName",displayName);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Account> GetEmailExchangeServiceAccount(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Account>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceAccount(OvhApi.Models.Email.Exchange.Account requestBody,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/account/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Delete existing mailbox in exchange server
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccount(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Pending task for this mailbox
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceAccountTaskIds(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/tasks",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="id">Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> GetEmailExchangeServiceAccountTasks(string organizationName,string exchangeService,string primaryEmailAddress,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/tasks/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Change mailbox password
							/// <param name="password">new password</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountChangepassword(string password,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("password",password);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/changePassword",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Terminate account at expiration date
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<string> CreateEmailExchangeServiceAccountTerminate(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<string>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/terminate",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExportUrl> GetEmailExchangeServiceAccountExporturl(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExportUrl>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/exportURL",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Generate PST file url
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountExporturl(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/exportURL",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// SendOnBehalfTo granted users for this mailbox
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceAccountSendonbehalftoIds(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendOnBehalfTo",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Allow another user to Send On Behalf To mails from this mailbox
							/// <param name="allowAccountId">Account id to allow to send On Behalf To mails from this mailbox</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountSendonbehalfto(long allowAccountId,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowAccountId",allowAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowAccountId",allowAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendOnBehalfTo",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeAccountSendOnBehalfTo> GetEmailExchangeServiceAccountSendonbehalfto(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeAccountSendOnBehalfTo>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendOnBehalfTo/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Delete allowed user for SendOnBehalfTo
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccountSendonbehalfto(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendOnBehalfTo/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Full access granted users for this mailbox
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceAccountFullaccesIds(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/fullAccess",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Allow full access to a user
							/// <param name="allowedAccountId">User to give full access</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountFullaccess(long allowedAccountId,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowedAccountId",allowedAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowedAccountId",allowedAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/fullAccess",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">account id to give full access</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeAccountFullAccess> GetEmailExchangeServiceAccountFullaccess(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeAccountFullAccess>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/fullAccess/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Revoke full access
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">account id to give full access</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccountFullaccess(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}/fullAccess/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Export> GetEmailExchangeServiceAccountExport(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Export>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/export",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Request PST file for the account
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountExport(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/export",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Remove request of PST file
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccountExport(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}/export",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Aliases associated to this mailbox
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceAccountAliaNames(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/alias",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Create new alias
							/// <param name="alias">Alias</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountAlias(string alias,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("alias",alias);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("alias",alias);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/alias",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="alias">Alias</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeAccountAlias> GetEmailExchangeServiceAccountAlias(string organizationName,string exchangeService,string primaryEmailAddress,string alias)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.NotNullNorEmpty("alias",alias);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeAccountAlias>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/alias/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(alias.ToString())));
		}
				/// <summary>
		/// Delete existing alias
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="alias">Alias</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccountAlias(string organizationName,string exchangeService,string primaryEmailAddress,string alias)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.NotNullNorEmpty("alias",alias);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}/alias/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(alias.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.OutlookUrl> GetEmailExchangeServiceAccountOutlookurl(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.OutlookUrl>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/outlookURL",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Generate outlook url
							/// <param name="language">Language of outlook</param>
							/// <param name="version">Version of outlook</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountOutlookurl(OvhApi.Models.Email.Exchange.LanguageEnum language,OvhApi.Models.Email.Exchange.OutlookVersionEnum version,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("language",language);
Ensure.NotNull("version",version);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("language",language);
requestBody.Add("version",version);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/outlookURL",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Send as granted users for this mailbox
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceAccountSendaIds(string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendAs",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())));
		}
				/// <summary>
		/// Allow another user to send mails from this mailbox
							/// <param name="allowAccountId">Account id to allow to send mails from this mailbox</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceAccountSendas(long allowAccountId,string organizationName,string exchangeService,string primaryEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowAccountId",allowAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowAccountId",allowAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendAs",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">Account id to give send as</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeAccountSendAs> GetEmailExchangeServiceAccountSendas(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeAccountSendAs>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendAs/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Delete allowed user for sendAs
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="primaryEmailAddress">Default email for this mailbox</param>
							/// <param name="allowedAccountId">Account id to give send as</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceAccountSendas(string organizationName,string exchangeService,string primaryEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("primaryEmailAddress",primaryEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/account/{2}/sendAs/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(primaryEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Pending actions
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceTaskIds(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/task",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="id">Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> GetEmailExchangeServiceTask(string organizationName,string exchangeService,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/task/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get active licenses for specific period of time
							/// <param name="license">License type</param>
							/// <param name="toDate">Get active licenses until date</param>
							/// <param name="fromDate">Get active licenses since date </param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.DailyLicense[]> GetEmailExchangeServiceLicenses(string organizationName,string exchangeService,DateTime? fromDate = null,DateTime? toDate = null,OvhApi.Models.Email.Exchange.OvhLicenceEnum? license = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("license",license);
queryString.Add("toDate",toDate);
queryString.Add("fromDate",fromDate);

			
			return await RawCall<OvhApi.Models.Email.Exchange.DailyLicense[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/license{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// Get public folder quota usage in total available space
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.PublicFolderQuota> GetEmailExchangeServicePublicfolderquota(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.PublicFolderQuota>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/publicFolderQuota",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// External contacts for this service
							/// <param name="firstName">Filter the value of firstName property (like)</param>
							/// <param name="id">Filter the value of id property (like)</param>
							/// <param name="lastName">Filter the value of lastName property (like)</param>
							/// <param name="displayName">Filter the value of displayName property (like)</param>
							/// <param name="externalEmailAddress">Filter the value of externalEmailAddress property (like)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceExternalcontactNames(string organizationName,string exchangeService,string externalEmailAddress = null,string displayName = null,string lastName = null,long? id = null,string firstName = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("firstName",firstName);
queryString.Add("id",id);
queryString.Add("lastName",lastName);
queryString.Add("displayName",displayName);
queryString.Add("externalEmailAddress",externalEmailAddress);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/externalContact{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// create new external contact
							/// <param name="initials">Contact initials</param>
							/// <param name="firstName">Contact first name</param>
							/// <param name="hiddenFromGAL">Hide the contact in Global Address List</param>
							/// <param name="organization2010">Indicates to which organization this newly created external contact will belongs (Exchange 2010 only)</param>
							/// <param name="lastName">Contact last name</param>
							/// <param name="displayName">Contact display name</param>
							/// <param name="externalEmailAddress">Contact email address</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceExternalcontact(string externalEmailAddress,string organizationName,string exchangeService,string displayName = null,string lastName = null,string organization2010 = null,bool? hiddenFromGAL = null,string firstName = null,string initials = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("externalEmailAddress",externalEmailAddress);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("initials",initials);
requestBody.Add("firstName",firstName);
requestBody.Add("hiddenFromGAL",hiddenFromGAL);
requestBody.Add("organization2010",organization2010);
requestBody.Add("lastName",lastName);
requestBody.Add("displayName",displayName);
requestBody.Add("externalEmailAddress",externalEmailAddress);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/externalContact",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="externalEmailAddress">Contact email</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeExternalContact> GetEmailExchangeServiceExternalcontact(string organizationName,string exchangeService,string externalEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("externalEmailAddress",externalEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeExternalContact>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/externalContact/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(externalEmailAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="externalEmailAddress">Contact email</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceExternalcontact(OvhApi.Models.Email.Exchange.ExchangeExternalContact requestBody,string organizationName,string exchangeService,string externalEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("externalEmailAddress",externalEmailAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/externalContact/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(externalEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// delete external contact
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="externalEmailAddress">Contact email</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceExternalcontact(string organizationName,string exchangeService,string externalEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("externalEmailAddress",externalEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/externalContact/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(externalEmailAddress.ToString())));
		}
				/// <summary>
		/// Get DCV emails if your ssl will expire in next 30 days
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceDcvemailNames(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/dcvEmails",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Domain> GetEmailExchangeServiceDomain(string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Domain>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/domain/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceDomain(OvhApi.Models.Email.Exchange.Domain requestBody,string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/domain/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())),requestBody);
		}
				/// <summary>
		/// Delete existing domain in exchange services
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceDomain(string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/domain/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())));
		}
				/// <summary>
		/// Get diclaimer attributes to substitute with Active Directory properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.DisclaimerAttributeEnum[]> GetEmailExchangeServiceDomainDisclaimerattributes(string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.DisclaimerAttributeEnum[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/domain/{2}/disclaimerAttribute",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Disclaimer> GetEmailExchangeServiceDomainDisclaimer(string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Disclaimer>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/domain/{2}/disclaimer",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceDomainDisclaimer(OvhApi.Models.Email.Exchange.Disclaimer requestBody,string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/domain/{2}/disclaimer",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())),requestBody);
		}
				/// <summary>
		/// Create organization disclaimer of each email
							/// <param name="outsideOnly">Activate the disclaimer only for external emails</param>
							/// <param name="content">Signature, added at the bottom of your organization emails</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceDomainDisclaimer(string content,string organizationName,string exchangeService,string domainName,bool? outsideOnly = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("content",content);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("outsideOnly",outsideOnly);
requestBody.Add("content",content);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/domain/{2}/disclaimer",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())),requestBody);
		}
				/// <summary>
		/// Delete existing organization disclaimer
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="domainName">Domain name</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceDomainDisclaimer(string organizationName,string exchangeService,string domainName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("domainName",domainName);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/domain/{2}/disclaimer",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(domainName.ToString())));
		}
				/// <summary>
		/// Domains associated to this service
							/// <param name="main">Filter the value of main property (like)</param>
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceDomainNames(string organizationName,string exchangeService,OvhApi.Models.Email.Exchange.ObjectStateEnum? state = null,bool? main = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("main",main);
queryString.Add("state",state);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/domain{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// Create new domain in exchange services
							/// <param name="mxRelay">If specified, emails to not existing address will be redirected to that domain</param>
							/// <param name="configureAutodiscover">If you host domain in OVH we can configure autodiscover record automatically</param>
							/// <param name="organization2010">If specified, indicates which organization this newly created domain will be part of (Exchange 2010 only)</param>
							/// <param name="name">Domain to install on server</param>
							/// <param name="type">Type of domain that You want to install</param>
							/// <param name="configureMx">If you host domain in OVH we can configure mx record automatically</param>
							/// <param name="main">This newly created domain will be an organization (Exchange 2010 only)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceDomain(string name,OvhApi.Models.Email.Exchange.DomainTypeEnum type,string organizationName,string exchangeService,bool? main = null,bool? configureMx = null,string organization2010 = null,bool? configureAutodiscover = null,string mxRelay = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("name",name);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("mxRelay",mxRelay);
requestBody.Add("configureAutodiscover",configureAutodiscover);
requestBody.Add("organization2010",organization2010);
requestBody.Add("name",name);
requestBody.Add("type",type);
requestBody.Add("configureMx",configureMx);
requestBody.Add("main",main);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/domain",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Renew SSL if it will expire in next 30 days
							/// <param name="dcv">DCV email require for order ssl varification process</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceRenewssl(string dcv,string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("dcv",dcv);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("dcv",dcv);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/renewSSL",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Mailing list for this service
							/// <param name="mailingListAddress">Filter the value of mailingListAddress property (like)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceMailinglistNames(string organizationName,string exchangeService,string mailingListAddress = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("mailingListAddress",mailingListAddress);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// Add mailing list
							/// <param name="joinRestriction">Join restriction policy</param>
							/// <param name="departRestriction">Depart restriction policy</param>
							/// <param name="hiddenFromGAL">If true mailing list is hiddend in Global Address List</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="senderAuthentification">If true sender has to authenticate</param>
							/// <param name="maxSendSize">Maximum send email size in MB</param>
							/// <param name="maxReceiveSize">Maximum receive email size in MB</param>
							/// <param name="displayName">Name displayed in Global Access List</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglist(OvhApi.Models.Email.Exchange.MailingListJoinRestrictionEnum joinRestriction,OvhApi.Models.Email.Exchange.MailingListDepartRestrictionEnum departRestriction,string mailingListAddress,string organizationName,string exchangeService,string displayName = null,long? maxReceiveSize = null,long? maxSendSize = null,bool? senderAuthentification = null,bool? hiddenFromGAL = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("joinRestriction",joinRestriction);
Ensure.NotNull("departRestriction",departRestriction);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("joinRestriction",joinRestriction);
requestBody.Add("departRestriction",departRestriction);
requestBody.Add("hiddenFromGAL",hiddenFromGAL);
requestBody.Add("mailingListAddress",mailingListAddress);
requestBody.Add("senderAuthentification",senderAuthentification);
requestBody.Add("maxSendSize",maxSendSize);
requestBody.Add("maxReceiveSize",maxReceiveSize);
requestBody.Add("displayName",displayName);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.MailingList> GetEmailExchangeServiceMailinglist(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.MailingList>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceMailinglist(OvhApi.Models.Email.Exchange.MailingList requestBody,string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Delete mailing list
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglist(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Mailing list account member
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceMailinglistMemberAccountIds(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/account",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Add new mailing list member
							/// <param name="memberContactId">Member contact id</param>
							/// <param name="memberAccountId">Member account id</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistMemberAccount(string organizationName,string exchangeService,string mailingListAddress,long? memberAccountId = null,long? memberContactId = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("memberContactId",memberContactId);
requestBody.Add("memberAccountId",memberAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/account",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="memberAccountId">Member account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupMember> GetEmailExchangeServiceMailinglistMemberAccount(string organizationName,string exchangeService,string mailingListAddress,long memberAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("memberAccountId",memberAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupMember>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/account/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(memberAccountId.ToString())));
		}
				/// <summary>
		/// Delete mailing list member
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="memberAccountId">Member account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistMemberAccount(string organizationName,string exchangeService,string mailingListAddress,long memberAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("memberAccountId",memberAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/account/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(memberAccountId.ToString())));
		}
				/// <summary>
		/// Mailing list contact member
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceMailinglistMemberContactIds(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/contact",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Add new mailing list member
							/// <param name="memberContactId">Member contact id</param>
							/// <param name="memberAccountId">Member account id</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistMemberContact(string organizationName,string exchangeService,string mailingListAddress,long? memberAccountId = null,long? memberContactId = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("memberContactId",memberContactId);
requestBody.Add("memberAccountId",memberAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/contact",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="memberContactId">Member account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupMember> GetEmailExchangeServiceMailinglistMemberContact(string organizationName,string exchangeService,string mailingListAddress,long memberContactId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("memberContactId",memberContactId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupMember>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/contact/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(memberContactId.ToString())));
		}
				/// <summary>
		/// Delete mailing list member
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="memberContactId">Member account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistMemberContact(string organizationName,string exchangeService,string mailingListAddress,long memberContactId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("memberContactId",memberContactId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/member/contact/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(memberContactId.ToString())));
		}
				/// <summary>
		/// sendOnBehalfTo
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceMailinglistSendonbehalftoIds(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendOnBehalfTo",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Allow another user to Send aso mails from this mailing list
							/// <param name="allowAccountId">Account id to allow to send as mails from this mailing list</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistSendonbehalfto(long allowAccountId,string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowAccountId",allowAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowAccountId",allowAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendOnBehalfTo",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupSendOnBehalfTo> GetEmailExchangeServiceMailinglistSendonbehalfto(string organizationName,string exchangeService,string mailingListAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupSendOnBehalfTo>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendOnBehalfTo/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Delete allowed user for SendOnBehalfTo
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistSendonbehalfto(string organizationName,string exchangeService,string mailingListAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendOnBehalfTo/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Aliases associated to this mailingList
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceMailinglistAliaNames(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/alias",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Create new alias
							/// <param name="alias">Alias</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistAlias(string alias,string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("alias",alias);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("alias",alias);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/alias",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="alias">Alias</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeMailingListAlias> GetEmailExchangeServiceMailinglistAlias(string organizationName,string exchangeService,string mailingListAddress,string alias)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.NotNullNorEmpty("alias",alias);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeMailingListAlias>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/alias/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(alias.ToString())));
		}
				/// <summary>
		/// Delete existing alias
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="alias">Alias</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistAlias(string organizationName,string exchangeService,string mailingListAddress,string alias)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.NotNullNorEmpty("alias",alias);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/alias/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(alias.ToString())));
		}
				/// <summary>
		/// Mailing list account manager
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceMailinglistManagerAccountIds(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/manager/account",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Add new mailing list manager
							/// <param name="managerAccountId">Manager account id</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistManagerAccount(long managerAccountId,string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("managerAccountId",managerAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("managerAccountId",managerAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/manager/account",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="managerAccountId">Manager account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupManager> GetEmailExchangeServiceMailinglistManagerAccount(string organizationName,string exchangeService,string mailingListAddress,long managerAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("managerAccountId",managerAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupManager>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/manager/account/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(managerAccountId.ToString())));
		}
				/// <summary>
		/// Delete mailing list manager
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="managerAccountId">Manager account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistManagerAccount(string organizationName,string exchangeService,string mailingListAddress,long managerAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("managerAccountId",managerAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/manager/account/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(managerAccountId.ToString())));
		}
				/// <summary>
		/// sendAs
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceMailinglistSendaIds(string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendAs",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())));
		}
				/// <summary>
		/// Allow another user to Send aso mails from this mailing list
							/// <param name="allowAccountId">Account id to allow to send as mails from this mailing list</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceMailinglistSendas(long allowAccountId,string organizationName,string exchangeService,string mailingListAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowAccountId",allowAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowAccountId",allowAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendAs",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupSendAs> GetEmailExchangeServiceMailinglistSendas(string organizationName,string exchangeService,string mailingListAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeDistributionGroupSendAs>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendAs/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Delete allowed user for SendAs
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="mailingListAddress">The mailing list address</param>
							/// <param name="allowedAccountId">Account id to give send on behalf to</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceMailinglistSendas(string organizationName,string exchangeService,string mailingListAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("mailingListAddress",mailingListAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/mailingList/{2}/sendAs/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(mailingListAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Public folders associated to this service
							/// <param name="path">Filter the value of path property (like)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServicePublicfolderNames(string organizationName,string exchangeService,string path = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("path",path);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/publicFolder{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// Create organization public folder
							/// <param name="quota">Quota for public folder in MB</param>
							/// <param name="anonymousPermission">Access right for the guest users</param>
							/// <param name="type">Type for public folder</param>
							/// <param name="path">Path for public folder</param>
							/// <param name="defaultPermission">Default access right</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServicePublicfolder(long quota,OvhApi.Models.Email.Exchange.PublicFolderTypeEnum type,string path,string organizationName,string exchangeService,OvhApi.Models.Email.Exchange.PublicFolderRightTypeEnum? defaultPermission = null,OvhApi.Models.Email.Exchange.PublicFolderRightTypeEnum? anonymousPermission = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("quota",quota);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("path",path);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("quota",quota);
requestBody.Add("anonymousPermission",anonymousPermission);
requestBody.Add("type",type);
requestBody.Add("path",path);
requestBody.Add("defaultPermission",defaultPermission);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/publicFolder",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.PublicFolder> GetEmailExchangeServicePublicfolder(string organizationName,string exchangeService,string path)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.PublicFolder>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// </summary>
						public async Task UpdateEmailExchangeServicePublicfolder(OvhApi.Models.Email.Exchange.PublicFolder requestBody,string organizationName,string exchangeService,string path)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString())),requestBody);
		}
				/// <summary>
		/// Delete existing organization public folder
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServicePublicfolder(string organizationName,string exchangeService,string path)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString())));
		}
				/// <summary>
		/// Public folder permission
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServicePublicfolderPermissionIds(string organizationName,string exchangeService,string path)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}/permission",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString())));
		}
				/// <summary>
		/// Create public folder permission
							/// <param name="allowedAccountId">Account id to have access to public folder</param>
							/// <param name="accessRights">Access rights to be set for the account</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServicePublicfolderPermission(long allowedAccountId,OvhApi.Models.Email.Exchange.PublicFolderRightTypeEnum accessRights,string organizationName,string exchangeService,string path)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowedAccountId",allowedAccountId);
Ensure.NotNull("accessRights",accessRights);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowedAccountId",allowedAccountId);
requestBody.Add("accessRights",accessRights);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}/permission",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// <param name="allowedAccountId">Account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangePublicFolderPermission> GetEmailExchangeServicePublicfolderPermission(string organizationName,string exchangeService,string path,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangePublicFolderPermission>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}/permission/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// <param name="allowedAccountId">Account id</param>
							/// </summary>
						public async Task UpdateEmailExchangeServicePublicfolderPermission(OvhApi.Models.Email.Exchange.ExchangePublicFolderPermission requestBody,string organizationName,string exchangeService,string path,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}/permission/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())),requestBody);
		}
				/// <summary>
		/// Delete existing permission from public folder
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="path">Path for public folder</param>
							/// <param name="allowedAccountId">Account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServicePublicfolderPermission(string organizationName,string exchangeService,string path,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("path",path);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/publicFolder/{2}/permission/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(path.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Server> GetEmailExchangeServiceServer(string organizationName,string exchangeService)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Server>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/server",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())));
		}
				/// <summary>
		/// Resource account associated to this service
							/// <param name="resourceEmailAddress">Filter the value of resourceEmailAddress property (like)</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<string[]> GetEmailExchangeServiceResourceaccountNames(string organizationName,string exchangeService,string resourceEmailAddress = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			var queryString = new QueryString();
queryString.Add("resourceEmailAddress",resourceEmailAddress);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/resourceAccount{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),queryString));
		}
				/// <summary>
		/// create new resource account in exchange server
							/// <param name="resourceEmailAddress">resource address</param>
							/// <param name="allowConflict">resource can be scheduled by more than one person during the same time period</param>
							/// <param name="type">field of your reservation</param>
							/// <param name="capacity">number of the same equipment or capacity of a room</param>
							/// <param name="displayName">resource account display name</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceResourceaccount(string resourceEmailAddress,OvhApi.Models.Email.Exchange.ResourceTypeEnum type,long capacity,string organizationName,string exchangeService,string displayName = null,bool? allowConflict = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);
Ensure.NotNull("type",type);
Ensure.IdIsValid("capacity",capacity);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("resourceEmailAddress",resourceEmailAddress);
requestBody.Add("allowConflict",allowConflict);
requestBody.Add("type",type);
requestBody.Add("capacity",capacity);
requestBody.Add("displayName",displayName);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/resourceAccount",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ResourceAccount> GetEmailExchangeServiceResourceaccount(string organizationName,string exchangeService,string resourceEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ResourceAccount>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// </summary>
						public async Task UpdateEmailExchangeServiceResourceaccount(OvhApi.Models.Email.Exchange.ResourceAccount requestBody,string organizationName,string exchangeService,string resourceEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// delete existing resource account in exchange server
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceResourceaccount(string organizationName,string exchangeService,string resourceEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString())));
		}
				/// <summary>
		/// Resource account manager
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// </summary>
						public async Task<long[]> GetEmailExchangeServiceResourceaccountDelegateIds(string organizationName,string exchangeService,string resourceEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}/delegate",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString())));
		}
				/// <summary>
		/// add new resource account delegate in exchange server
							/// <param name="allowedAccountId">delegate's account id</param>
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> CreateEmailExchangeServiceResourceaccountDelegate(long allowedAccountId,string organizationName,string exchangeService,string resourceEmailAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("allowedAccountId",allowedAccountId);
Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("allowedAccountId",allowedAccountId);

			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Post,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}/delegate",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// <param name="allowedAccountId">delegate's account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.ExchangeResourceAccountDelegate> GetEmailExchangeServiceResourceaccountDelegate(string organizationName,string exchangeService,string resourceEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.ExchangeResourceAccountDelegate>(HttpMethod.Get,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}/delegate/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// delete existing resource account delegate in exchange server
							/// <param name="organizationName">The internal name of your exchange organization</param>
							/// <param name="exchangeService">The internal name of your exchange service</param>
							/// <param name="resourceEmailAddress">resource as email</param>
							/// <param name="allowedAccountId">delegate's account id</param>
							/// </summary>
						public async Task<OvhApi.Models.Email.Exchange.Task> DeleteEmailExchangeServiceResourceaccountDelegate(string organizationName,string exchangeService,string resourceEmailAddress,long allowedAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organizationName",organizationName);
Ensure.NotNullNorEmpty("exchangeService",exchangeService);
Ensure.NotNullNorEmpty("resourceEmailAddress",resourceEmailAddress);
Ensure.IdIsValid("allowedAccountId",allowedAccountId);

			
			
			return await RawCall<OvhApi.Models.Email.Exchange.Task>(HttpMethod.Delete,String.Format("/email/exchange/{0}/service/{1}/resourceAccount/{2}/delegate/{3}",System.Net.WebUtility.UrlEncode(organizationName.ToString()),System.Net.WebUtility.UrlEncode(exchangeService.ToString()),System.Net.WebUtility.UrlEncode(resourceEmailAddress.ToString()),System.Net.WebUtility.UrlEncode(allowedAccountId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetHostingWebServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/hosting/web/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task UpdateHostingWebServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/hosting/web/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Service> GetHostingWeb(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Service>(HttpMethod.Get,String.Format("/hosting/web/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available database you can install
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Database.CreationDatabaseCapabilities[]> GetHostingWebDatabasecreationcapabilities(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Database.CreationDatabaseCapabilities[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/databaseCreationCapabilities",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Tasks attached to your hosting
							/// <param name="function">Filter the value of function property (like)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<long[]> GetHostingWebTaskIds(string serviceName,OvhApi.Models.Hosting.Web.Task.StatusEnum? status = null,string function = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("function",function);
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">the id of the task</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> GetHostingWebTasks(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Get,String.Format("/hosting/web/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get statistics about this web hosting
							/// <param name="period">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.ChartSerie<complexType.ChartTimestampValue>[]> GetHostingWebStatistics(OvhApi.Models.Hosting.Web.StatisticsPeriodEnum period,OvhApi.Models.Hosting.Web.StatisticsTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.ChartSerie<complexType.ChartTimestampValue>[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/statistics{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Databases linked to your hosting
							/// <param name="mode">Filter the value of mode property (=)</param>
							/// <param name="user">Filter the value of user property (like)</param>
							/// <param name="name">Filter the value of name property (like)</param>
							/// <param name="type">Filter the value of type property (=)</param>
							/// <param name="server">Filter the value of server property (like)</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<string[]> GetHostingWebDatabaseNames(string serviceName,string server = null,OvhApi.Models.Hosting.Web.Database.DatabaseTypeEnum? type = null,string name = null,string user = null,OvhApi.Models.Hosting.Web.Database.ModeEnum? mode = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("mode",mode);
queryString.Add("user",user);
queryString.Add("name",name);
queryString.Add("type",type);
queryString.Add("server",server);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/database{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Install new database
							/// <param name="quota">Quota assign to your database. Only for extraSql</param>
							/// <param name="password">Database password</param>
							/// <param name="capabilitie">Type of your database</param>
							/// <param name="user">Database user name. Must begin with your hosting login</param>
							/// <param name="type">Type you want for your database</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebDatabase(OvhApi.Models.Hosting.Web.Database.DatabaseCapabilitiesTypeEnum capabilitie,string user,OvhApi.Models.Hosting.Web.Database.DatabaseTypeEnum type,string serviceName,string password = null,OvhApi.Models.Hosting.Web.Database.ExtraSqlQuotaEnum? quota = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("capabilitie",capabilitie);
Ensure.NotNullNorEmpty("user",user);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("quota",quota);
requestBody.Add("password",password);
requestBody.Add("capabilitie",capabilitie);
requestBody.Add("user",user);
requestBody.Add("type",type);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/database",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="name">Database name</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Database> GetHostingWebDatabase(string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Database>(HttpMethod.Get,String.Format("/hosting/web/{0}/database/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Delete database
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="name">Database name</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> DeleteHostingWebDatabase(string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Delete,String.Format("/hosting/web/{0}/database/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Request the dump from your database
							/// <param name="date">The date you want to dump</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="name">Database name</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebDatabaseDump(OvhApi.Models.Hosting.Web.Database.DumpDateEnum date,string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("date",date);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("date",date);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/database/{1}/dump",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())),requestBody);
		}
				/// <summary>
		/// Get statistics about this database
							/// <param name="period">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="name">Database name</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.ChartSerie<complexType.ChartTimestampValue>[]> GetHostingWebDatabaseStatistics(OvhApi.Models.Hosting.Web.StatisticsPeriodEnum period,OvhApi.Models.Hosting.Web.Database.StatisticsTypeEnum type,string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.ChartSerie<complexType.ChartTimestampValue>[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/database/{1}/statistics{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString()),queryString));
		}
				/// <summary>
		/// Request a password change
							/// <param name="password">The new database password</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="name">Database name</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebDatabaseChangepassword(string password,string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("password",password);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/database/{1}/changePassword",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())),requestBody);
		}
				/// <summary>
		/// Crons on your hosting
							/// <param name="email">Filter the value of email property (like)</param>
							/// <param name="language">Filter the value of language property (=)</param>
							/// <param name="description">Filter the value of description property (like)</param>
							/// <param name="command">Filter the value of command property (like)</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<long[]> GetHostingWebCronIds(string serviceName,string command = null,string description = null,OvhApi.Models.Hosting.Web.Cron.LanguageEnum? language = null,string email = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("email",email);
queryString.Add("language",language);
queryString.Add("description",description);
queryString.Add("command",command);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/cron{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Create new cron
							/// <param name="frequency">Frequency ( crontab format ) define for the script ( minutes are ignored )</param>
							/// <param name="email">Email use to receive error log ( stderr )</param>
							/// <param name="language">Cron language</param>
							/// <param name="description">Description field for you</param>
							/// <param name="command">Command to execute</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<string> CreateHostingWebCron(string frequency,OvhApi.Models.Hosting.Web.Cron.LanguageEnum language,string command,string serviceName,string description = null,string email = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("frequency",frequency);
Ensure.NotNull("language",language);
Ensure.NotNullNorEmpty("command",command);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("frequency",frequency);
requestBody.Add("email",email);
requestBody.Add("language",language);
requestBody.Add("description",description);
requestBody.Add("command",command);

			return await RawCall<string>(HttpMethod.Post,String.Format("/hosting/web/{0}/cron",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Cron's id</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Cron> GetHostingWebCron(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Cron>(HttpMethod.Get,String.Format("/hosting/web/{0}/cron/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Cron's id</param>
							/// </summary>
						public async Task UpdateHostingWebCron(OvhApi.Models.Hosting.Web.Cron requestBody,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/hosting/web/{0}/cron/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Delete cron
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Cron's id</param>
							/// </summary>
						public async Task<string> DeleteHostingWebCron(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<string>(HttpMethod.Delete,String.Format("/hosting/web/{0}/cron/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="domain">Domain linked (fqdn)</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.AttachedDomain> GetHostingWebAttacheddomain(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.AttachedDomain>(HttpMethod.Get,String.Format("/hosting/web/{0}/attachedDomain/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="domain">Domain linked (fqdn)</param>
							/// </summary>
						public async Task UpdateHostingWebAttacheddomain(OvhApi.Models.Hosting.Web.AttachedDomain requestBody,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Put,String.Format("/hosting/web/{0}/attachedDomain/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// Unlink domain from hosting
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="domain">Domain linked (fqdn)</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> DeleteHostingWebAttacheddomain(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Delete,String.Format("/hosting/web/{0}/attachedDomain/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Domains or subdomains attached to your hosting
							/// <param name="domain">Filter the value of domain property (like)</param>
							/// <param name="path">Filter the value of path property (like)</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<string[]> GetHostingWebAttacheddomainNames(string serviceName,string path = null,string domain = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("domain",domain);
queryString.Add("path",path);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/attachedDomain{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Link a domain to this hosting
							/// <param name="domain">Domain to link</param>
							/// <param name="path">Domain's path, relative to your home directory</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebAttacheddomain(string domain,string path,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("path",path);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);
requestBody.Add("path",path);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/attachedDomain",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// User allowed to connect into your hosting
							/// <param name="home">Filter the value of home property (like)</param>
							/// <param name="login">Filter the value of login property (like)</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<string[]> GetHostingWebUserNames(string serviceName,string login = null,string home = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("home",home);
queryString.Add("login",login);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/user{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Create new ftp/ssh user
							/// <param name="password">Password</param>
							/// <param name="iisRemoteRights">User IIS rights</param>
							/// <param name="home">Home directory</param>
							/// <param name="webDavRights">User WebDav rights</param>
							/// <param name="login">Login use for your new user</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebUser(string password,string home,string login,string serviceName,OvhApi.Models.Hosting.Web.User.WebDavRightsEnum? webDavRights = null,OvhApi.Models.Hosting.Web.User.IisRightsEnum? iisRemoteRights = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("home",home);
Ensure.NotNullNorEmpty("login",login);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("password",password);
requestBody.Add("iisRemoteRights",iisRemoteRights);
requestBody.Add("home",home);
requestBody.Add("webDavRights",webDavRights);
requestBody.Add("login",login);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/user",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="login">Login used to connect on FTP</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.User> GetHostingWebUser(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.User>(HttpMethod.Get,String.Format("/hosting/web/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="login">Login used to connect on FTP</param>
							/// </summary>
						public async Task UpdateHostingWebUser(OvhApi.Models.Hosting.Web.User requestBody,string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			await RawCall(HttpMethod.Put,String.Format("/hosting/web/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())),requestBody);
		}
				/// <summary>
		/// Delete ftp/ssh user
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="login">Login used to connect on FTP</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> DeleteHostingWebUser(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Delete,String.Format("/hosting/web/{0}/user/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Request a password change
							/// <param name="password">The user's new password</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="login">Login used to connect on FTP</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebUserChangepassword(string password,string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("password",password);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/user/{1}/changePassword",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())),requestBody);
		}
				/// <summary>
		/// Use to link an external domain. ( This token has to be insert into a TXT field on your dns zone with ovhcontrol subdomain )
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<string> GetHostingWebToken(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string>(HttpMethod.Get,String.Format("/hosting/web/{0}/token",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Modules installed on your hosting
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<long[]> GetHostingWebModuleIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/hosting/web/{0}/module",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Install a new module
							/// <param name="domain">On which domain the module has to be available (it can be a multidomain or a subdomain) - if not set, the module will be available on your serviceName domain</param>
							/// <param name="language">The language to set to your module</param>
							/// <param name="adminName">The login for the admin account (note that some modules overwite this value with your email)</param>
							/// <param name="adminPassword">The password for the admin account (at least 8 characters)</param>
							/// <param name="dependencies">The dependencies that we have to configure on your module. A dependency can be a standard database (like MySQL or PostgreSQL) or a key-value store (like Redis or Memcached) for example</param>
							/// <param name="path">Where to install the module, relative to your home directory</param>
							/// <param name="moduleId">ID of the module you want to install</param>
							/// <param name="serviceName">The internal name of your hosting</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebModule(OvhApi.Models.Hosting.Web.Module.LanguageEnum language,OvhApi.Models.Hosting.Web.Module.DependencyType[] dependencies,string path,long moduleId,string serviceName,string adminPassword = null,string adminName = null,string domain = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("language",language);
Ensure.NotNull("dependencies",dependencies);
Ensure.NotNullNorEmpty("path",path);
Ensure.IdIsValid("moduleId",moduleId);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);
requestBody.Add("language",language);
requestBody.Add("adminName",adminName);
requestBody.Add("adminPassword",adminPassword);
requestBody.Add("dependencies",dependencies);
requestBody.Add("path",path);
requestBody.Add("moduleId",moduleId);

			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/module",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Installation ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Module> GetHostingWebModule(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Module>(HttpMethod.Get,String.Format("/hosting/web/{0}/module/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete a module installed
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Installation ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> DeleteHostingWebModule(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Delete,String.Format("/hosting/web/{0}/module/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Generate a new admin password for your module
							/// <param name="serviceName">The internal name of your hosting</param>
							/// <param name="id">Installation ID</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Task> CreateHostingWebModuleChangepassword(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.Task>(HttpMethod.Post,String.Format("/hosting/web/{0}/module/{1}/changePassword",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetHostingWebNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/hosting/web"));
		}
				/// <summary>
		/// Get offer capabilities
							/// <param name="offer">Describe offer capabilities</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.Capabilities> GetHostingWebOffercapabilities(OvhApi.Models.Hosting.Web.OfferCapabilitiesEnum offer)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("offer",offer);

			var queryString = new QueryString();
queryString.Add("offer",offer);

			
			return await RawCall<OvhApi.Models.Hosting.Web.Capabilities>(HttpMethod.Get,String.Format("/hosting/web/offerCapabilities{0}",queryString));
		}
				/// <summary>
		/// IDs of all modules available
							/// </summary>
						public async Task<long[]> GetHostingWebModulelistIds()
		{
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/hosting/web/moduleList"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">The ID of the module</param>
							/// </summary>
						public async Task<OvhApi.Models.Hosting.Web.ModuleList> GetHostingWebModulelist(long id)
		{
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Hosting.Web.ModuleList>(HttpMethod.Get,String.Format("/hosting/web/moduleList/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Your OVH IPs
							/// <param name="ip">Filter the value of ip property (contains or equals)</param>
							/// <param name="routedTo_serviceName">Filter the value of routedTo.serviceName property (like)</param>
							/// <param name="type">Filter the value of type property (=)</param>
							/// <param name="description">Filter the value of description property (like)</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetIps(string description = null,OvhApi.Models.Ip.IpTypeEnum? type = null,string routedTo_serviceName = null,OVHApi.IPAddressBlock ip = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("ip",ip);
queryString.Add("routedTo.serviceName",routedTo_serviceName);
queryString.Add("type",type);
queryString.Add("description",description);

			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/ip{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.Ip> GetIp(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Ip.Ip>(HttpMethod.Get,String.Format("/ip/{0}",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task UpdateIp(OvhApi.Models.Ip.Ip requestBody,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNull("ip",ip);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/{0}",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Move this IP to a dedicated server
							/// <param name="to">Dedicated server destination</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpTask> CreateIpMove(string to,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("to",to);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("to",to);

			return await RawCall<OvhApi.Models.Ip.IpTask>(HttpMethod.Post,String.Format("/ip/{0}/move",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Manage mitigation profile on your IPs
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpMitigationprofiles(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/mitigationProfiles",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Create new profile for one of your ip
							/// <param name="ipMitigationProfile">To be written</param>
							/// <param name="autoMitigationTimeOut">Delay to wait before remove ip from auto mitigation after an attack</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationProfile> CreateIpMitigationprofiles(System.Net.IPAddress ipMitigationProfile,OvhApi.Models.Ip.MitigationProfileAutoMitigationTimeOutEnum autoMitigationTimeOut,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipMitigationProfile",ipMitigationProfile);
Ensure.NotNull("autoMitigationTimeOut",autoMitigationTimeOut);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipMitigationProfile",ipMitigationProfile);
requestBody.Add("autoMitigationTimeOut",autoMitigationTimeOut);

			return await RawCall<OvhApi.Models.Ip.MitigationProfile>(HttpMethod.Post,String.Format("/ip/{0}/mitigationProfiles",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipMitigationProfile">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationProfile> GetIpMitigationprofiles(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipMitigationProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipMitigationProfile",ipMitigationProfile);

			
			
			return await RawCall<OvhApi.Models.Ip.MitigationProfile>(HttpMethod.Get,String.Format("/ip/{0}/mitigationProfiles/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipMitigationProfile.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipMitigationProfile">To be written</param>
							/// </summary>
						public async Task UpdateIpMitigationprofiles(OvhApi.Models.Ip.MitigationProfile requestBody,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipMitigationProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipMitigationProfile",ipMitigationProfile);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/{0}/mitigationProfiles/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipMitigationProfile.ToString())),requestBody);
		}
				/// <summary>
		/// Delete mitigation profile
							/// <param name="ip">To be written</param>
							/// <param name="ipMitigationProfile">To be written</param>
							/// </summary>
						public async Task DeleteIpMitigationprofiles(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipMitigationProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipMitigationProfile",ipMitigationProfile);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/ip/{0}/mitigationProfiles/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipMitigationProfile.ToString())));
		}
				/// <summary>
		/// ARP blocked IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpArps(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/arp",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipBlocked">your IP</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.ArpBlockedIp> GetIpArp(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipBlocked)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipBlocked",ipBlocked);

			
			
			return await RawCall<OvhApi.Models.Ip.ArpBlockedIp>(HttpMethod.Get,String.Format("/ip/{0}/arp/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipBlocked.ToString())));
		}
				/// <summary>
		/// Unblock this IP
							/// <param name="ip">To be written</param>
							/// <param name="ipBlocked">your IP</param>
							/// </summary>
						public async Task CreateIpArpUnblock(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipBlocked)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipBlocked",ipBlocked);

			
			
			await RawCall(HttpMethod.Post,String.Format("/ip/{0}/arp/{1}/unblock",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipBlocked.ToString())));
		}
				/// <summary>
		/// Delete a failover IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpTask> CreateIpTerminate(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Ip.IpTask>(HttpMethod.Post,String.Format("/ip/{0}/terminate",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// IP tasks
							/// <param name="function">Filter the value of function property (=)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<long[]> GetIpTaskIds(OVHApi.IPAddressBlock ip,OvhApi.Models.Ip.TaskStatusEnum? status = null,OvhApi.Models.Ip.TaskFunctionEnum? function = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("function",function);
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/ip/{0}/task{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="taskId">the id of the task</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpTask> GetIpTask(OVHApi.IPAddressBlock ip,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Ip.IpTask>(HttpMethod.Get,String.Format("/ip/{0}/task/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Windows licenses associated to this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<string[]> GetIpLicenseWindowNames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/{0}/license/windows",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// DirectAdmin licenses associated to this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<string[]> GetIpLicenseDirectadminNames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/{0}/license/directadmin",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Virtuozzo licenses associated to this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<string[]> GetIpLicenseVirtuozzoNames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/{0}/license/virtuozzo",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Cpanel licenses associated to this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<string[]> GetIpLicenseCpanelNames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/{0}/license/cpanel",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Plesk licenses associated to this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<string[]> GetIpLicensePleskNames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/{0}/license/plesk",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Park this IP
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpTask> CreateIpPark(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Ip.IpTask>(HttpMethod.Post,String.Format("/ip/{0}/park",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Ip under mitigation
							/// <param name="auto">Filter the value of auto property (=)</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpMitigations(OVHApi.IPAddressBlock ip,bool? auto = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("auto",auto);

			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/mitigation{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),queryString));
		}
				/// <summary>
		/// AntiDDOS option. Add new IP on permanent mitigation
							/// <param name="ipOnMitigation">To be written</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationIp> CreateIpMitigation(System.Net.IPAddress ipOnMitigation,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipOnMitigation",ipOnMitigation);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipOnMitigation",ipOnMitigation);

			return await RawCall<OvhApi.Models.Ip.MitigationIp>(HttpMethod.Post,String.Format("/ip/{0}/mitigation",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnMitigation">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationIp> GetIpMitigation(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnMitigation)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnMitigation",ipOnMitigation);

			
			
			return await RawCall<OvhApi.Models.Ip.MitigationIp>(HttpMethod.Get,String.Format("/ip/{0}/mitigation/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnMitigation.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnMitigation">To be written</param>
							/// </summary>
						public async Task UpdateIpMitigation(OvhApi.Models.Ip.MitigationIp requestBody,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnMitigation)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnMitigation",ipOnMitigation);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/{0}/mitigation/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnMitigation.ToString())),requestBody);
		}
				/// <summary>
		/// AntiDDOS option. Delete IP from mitigation
							/// <param name="ip">To be written</param>
							/// <param name="ipOnMitigation">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationIp> DeleteIpMitigation(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnMitigation)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnMitigation",ipOnMitigation);

			
			
			return await RawCall<OvhApi.Models.Ip.MitigationIp>(HttpMethod.Delete,String.Format("/ip/{0}/mitigation/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnMitigation.ToString())));
		}
				/// <summary>
		/// AntiDDOS option. Get statistics about your traffic in and out during this mitigation
							/// <param name="to">End date</param>
							/// <param name="from">Start date</param>
							/// <param name="scale">Scale of aggregation</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnMitigation">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationStats[]> GetIpMitigationStats(DateTime to,DateTime from,OvhApi.Models.Ip.MitigationStatsScaleEnum scale,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnMitigation)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("to",to);
Ensure.NotNull("from",from);
Ensure.NotNull("scale",scale);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnMitigation",ipOnMitigation);

			var queryString = new QueryString();
queryString.Add("to",to);
queryString.Add("from",from);
queryString.Add("scale",scale);

			
			return await RawCall<OvhApi.Models.Ip.MitigationStats[]>(HttpMethod.Get,String.Format("/ip/{0}/mitigation/{1}/stats{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnMitigation.ToString()),queryString));
		}
				/// <summary>
		/// AntiDDOS option. Get top stream on your ip on a specific timestamp
							/// <param name="date">Date to view top traffic</param>
							/// <param name="scale">Scale of aggregation</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnMitigation">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.MitigationDetailedStats[]> GetIpMitigationTopstreams(DateTime date,OvhApi.Models.Ip.MitigationStatsScaleEnum scale,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnMitigation)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("date",date);
Ensure.NotNull("scale",scale);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnMitigation",ipOnMitigation);

			var queryString = new QueryString();
queryString.Add("date",date);
queryString.Add("scale",scale);

			
			return await RawCall<OvhApi.Models.Ip.MitigationDetailedStats[]>(HttpMethod.Get,String.Format("/ip/{0}/mitigation/{1}/topStream{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnMitigation.ToString()),queryString));
		}
				/// <summary>
		/// Reverse on your ip
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpReverses(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/reverse",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Add reverse on an ip
							/// <param name="ipReverse">To be written</param>
							/// <param name="reverse">To be written</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.ReverseIp> CreateIpReverse(System.Net.IPAddress ipReverse,string reverse,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipReverse",ipReverse);
Ensure.NotNullNorEmpty("reverse",reverse);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipReverse",ipReverse);
requestBody.Add("reverse",reverse);

			return await RawCall<OvhApi.Models.Ip.ReverseIp>(HttpMethod.Post,String.Format("/ip/{0}/reverse",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipReverse">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.ReverseIp> GetIpReverse(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipReverse)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipReverse",ipReverse);

			
			
			return await RawCall<OvhApi.Models.Ip.ReverseIp>(HttpMethod.Get,String.Format("/ip/{0}/reverse/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipReverse.ToString())));
		}
				/// <summary>
		/// Delete a reverse on one IP
							/// <param name="ip">To be written</param>
							/// <param name="ipReverse">To be written</param>
							/// </summary>
						public async Task DeleteIpReverse(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipReverse)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipReverse",ipReverse);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/ip/{0}/reverse/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipReverse.ToString())));
		}
				/// <summary>
		/// Ip spamming
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpSpams(OVHApi.IPAddressBlock ip,OvhApi.Models.Ip.SpamStateEnum? state = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("state",state);

			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/spam{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipSpamming">IP address which is sending spam</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.SpamIp> GetIpSpam(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipSpamming)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipSpamming",ipSpamming);

			
			
			return await RawCall<OvhApi.Models.Ip.SpamIp>(HttpMethod.Get,String.Format("/ip/{0}/spam/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipSpamming.ToString())));
		}
				/// <summary>
		/// Release the ip from anti-spam system
							/// <param name="ip">To be written</param>
							/// <param name="ipSpamming">IP address which is sending spam</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.SpamIp> CreateIpSpamUnblock(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipSpamming)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipSpamming",ipSpamming);

			
			
			return await RawCall<OvhApi.Models.Ip.SpamIp>(HttpMethod.Post,String.Format("/ip/{0}/spam/{1}/unblock",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipSpamming.ToString())));
		}
				/// <summary>
		/// Get statistics about the email traffic
							/// <param name="to">End date</param>
							/// <param name="from">Start date</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipSpamming">IP address which is sending spam</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.SpamStats[]> GetIpSpamStats(DateTime to,DateTime from,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipSpamming)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("to",to);
Ensure.NotNull("from",from);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipSpamming",ipSpamming);

			var queryString = new QueryString();
queryString.Add("to",to);
queryString.Add("from",from);

			
			return await RawCall<OvhApi.Models.Ip.SpamStats[]>(HttpMethod.Get,String.Format("/ip/{0}/spam/{1}/stats{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipSpamming.ToString()),queryString));
		}
				/// <summary>
		/// Ip under firewall
							/// <param name="enabled">Filter the value of enabled property (=)</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpFirewalls(OVHApi.IPAddressBlock ip,bool? enabled = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("enabled",enabled);

			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/firewall{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),queryString));
		}
				/// <summary>
		/// AntiDDOS option. Add new IP on firewall
							/// <param name="ipOnFirewall">To be written</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.FirewallIp> CreateIpFirewall(System.Net.IPAddress ipOnFirewall,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipOnFirewall",ipOnFirewall);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipOnFirewall",ipOnFirewall);

			return await RawCall<OvhApi.Models.Ip.FirewallIp>(HttpMethod.Post,String.Format("/ip/{0}/firewall",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.FirewallIp> GetIpFirewall(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			
			
			return await RawCall<OvhApi.Models.Ip.FirewallIp>(HttpMethod.Get,String.Format("/ip/{0}/firewall/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						public async Task UpdateIpFirewall(OvhApi.Models.Ip.FirewallIp requestBody,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/{0}/firewall/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString())),requestBody);
		}
				/// <summary>
		/// AntiDDOS option. Delete IP and rules from firewall
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						public async Task<string> DeleteIpFirewall(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			
			
			return await RawCall<string>(HttpMethod.Delete,String.Format("/ip/{0}/firewall/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString())));
		}
				/// <summary>
		/// Rules for this IP
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						public async Task<long[]> GetIpFirewallRuleIds(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,OvhApi.Models.Ip.FirewallRuleStateEnum? state = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			var queryString = new QueryString();
queryString.Add("state",state);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/ip/{0}/firewall/{1}/rule{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),queryString));
		}
				/// <summary>
		/// AntiDDOS option. Add new rule on your IP
							/// <param name="tcpOption">Option on your rule. Can only be used with TCP protocol</param>
							/// <param name="source">Source ip for your rule. Any if not set</param>
							/// <param name="protocol">Network protocol</param>
							/// <param name="destinationPort">Destination port for your rule. Only with TCP/UDP protocol</param>
							/// <param name="sequence">Sequence number of your rule</param>
							/// <param name="action">Action on this rule</param>
							/// <param name="sourcePort">Source port for your rule. Only with TCP/UDP protocol</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.FirewallNetworkRule> CreateIpFirewallRule(OvhApi.Models.Ip.FirewallProtocolEnum protocol,OvhApi.Models.Ip.FirewallSequenceRangeEnum sequence,OvhApi.Models.Ip.FirewallActionEnum action,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,long? sourcePort = null,long? destinationPort = null,OVHApi.IPAddressBlock source = null,OvhApi.Models.Ip.FirewallOptionTCP tcpOption = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNull("sequence",sequence);
Ensure.NotNull("action",action);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("tcpOption",tcpOption);
requestBody.Add("source",source);
requestBody.Add("protocol",protocol);
requestBody.Add("destinationPort",destinationPort);
requestBody.Add("sequence",sequence);
requestBody.Add("action",action);
requestBody.Add("sourcePort",sourcePort);

			return await RawCall<OvhApi.Models.Ip.FirewallNetworkRule>(HttpMethod.Post,String.Format("/ip/{0}/firewall/{1}/rule",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// <param name="sequence">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.FirewallNetworkRule> GetIpFirewallRule(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,long sequence)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);
Ensure.IdIsValid("sequence",sequence);

			
			
			return await RawCall<OvhApi.Models.Ip.FirewallNetworkRule>(HttpMethod.Get,String.Format("/ip/{0}/firewall/{1}/rule/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),System.Net.WebUtility.UrlEncode(sequence.ToString())));
		}
				/// <summary>
		/// AntiDDOS option. Delete rule
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// <param name="sequence">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.FirewallRule> DeleteIpFirewallRule(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,long sequence)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);
Ensure.IdIsValid("sequence",sequence);

			
			
			return await RawCall<OvhApi.Models.Ip.FirewallRule>(HttpMethod.Delete,String.Format("/ip/{0}/firewall/{1}/rule/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),System.Net.WebUtility.UrlEncode(sequence.ToString())));
		}
				/// <summary>
		/// Rules for this IP
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						[Obsolete("Deprecated since 01/29/2014 10:00:00 use '/ip/{ip}/firewall/{ipOnFirewall}/rule' instead")]
				public async Task<long[]> GetIpFirewallRuleIds(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,OvhApi.Models.Ip.FirewallRuleStateEnum? state = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			var queryString = new QueryString();
queryString.Add("state",state);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/ip/{0}/firewall/{1}/rules{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),queryString));
		}
				/// <summary>
		/// AntiDDOS option. Add new rule on your IP
							/// <param name="source">Source ip for your rule. Any if not set</param>
							/// <param name="protocol">Network protocol</param>
							/// <param name="destinationPort">Destination port range for your rule. Only with TCP/UDP protocol</param>
							/// <param name="sequence">Sequence number of your rule</param>
							/// <param name="udpOption">Option on your rule. Can only be used with UDP protocol</param>
							/// <param name="sourcePort">Source port range for your rule. Only with TCP/UDP protocol</param>
							/// <param name="tcpOption">Option on your rule. Can only be used with TCP protocol</param>
							/// <param name="action">Action on this rule</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// </summary>
						[Obsolete("Deprecated since 01/29/2014 10:00:00 use '/ip/{ip}/firewall/{ipOnFirewall}/rule' instead")]
				public async Task<OvhApi.Models.Ip.FirewallRule> CreateIpFirewallRules(OvhApi.Models.Ip.FirewallProtocolEnum protocol,OvhApi.Models.Ip.FirewallSequenceRangeEnum sequence,OvhApi.Models.Ip.FirewallActionEnum action,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,OvhApi.Models.Ip.FirewallTCPOption tcpOption = null,OvhApi.Models.ComplexType.Range<long> sourcePort = null,OvhApi.Models.Ip.FirewallUDPOption udpOption = null,OvhApi.Models.ComplexType.Range<long> destinationPort = null,OVHApi.IPAddressBlock source = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNull("sequence",sequence);
Ensure.NotNull("action",action);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("source",source);
requestBody.Add("protocol",protocol);
requestBody.Add("destinationPort",destinationPort);
requestBody.Add("sequence",sequence);
requestBody.Add("udpOption",udpOption);
requestBody.Add("sourcePort",sourcePort);
requestBody.Add("tcpOption",tcpOption);
requestBody.Add("action",action);

			return await RawCall<OvhApi.Models.Ip.FirewallRule>(HttpMethod.Post,String.Format("/ip/{0}/firewall/{1}/rules",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// <param name="sequence">To be written</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Ip.FirewallRule> GetIpFirewallRules(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,long sequence)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);
Ensure.IdIsValid("sequence",sequence);

			
			
			return await RawCall<OvhApi.Models.Ip.FirewallRule>(HttpMethod.Get,String.Format("/ip/{0}/firewall/{1}/rules/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),System.Net.WebUtility.UrlEncode(sequence.ToString())));
		}
				/// <summary>
		/// AntiDDOS option. Delete rule
							/// <param name="ip">To be written</param>
							/// <param name="ipOnFirewall">To be written</param>
							/// <param name="sequence">To be written</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Ip.FirewallRule> DeleteIpFirewallRules(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnFirewall,long sequence)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnFirewall",ipOnFirewall);
Ensure.IdIsValid("sequence",sequence);

			
			
			return await RawCall<OvhApi.Models.Ip.FirewallRule>(HttpMethod.Delete,String.Format("/ip/{0}/firewall/{1}/rules/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnFirewall.ToString()),System.Net.WebUtility.UrlEncode(sequence.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.GameMitigation> GetIpGame(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);

			
			
			return await RawCall<OvhApi.Models.Ip.GameMitigation>(HttpMethod.Get,String.Format("/ip/{0}/game/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// </summary>
						public async Task UpdateIpGame(OvhApi.Models.Ip.GameMitigation requestBody,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/{0}/game/{1}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString())),requestBody);
		}
				/// <summary>
		/// IDs of rules configured for this IP
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// </summary>
						public async Task<long[]> GetIpGameRuleIds(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/ip/{0}/game/{1}/rule",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString())));
		}
				/// <summary>
		/// Add new rule on your IP
							/// <param name="protocol">The protocol running behind the given port</param>
							/// <param name="ports">The UDP port range to apply the rule on</param>
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.GameMitigationRule> CreateIpGameRule(OvhApi.Models.Ip.GameMitigationRuleProtocolEnum protocol,OvhApi.Models.ComplexType.Range<long> ports,OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNull("ports",ports);
Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("protocol",protocol);
requestBody.Add("ports",ports);

			return await RawCall<OvhApi.Models.Ip.GameMitigationRule>(HttpMethod.Post,String.Format("/ip/{0}/game/{1}/rule",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// <param name="id">ID of the rule</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.GameMitigationRule> GetIpGameRule(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Ip.GameMitigationRule>(HttpMethod.Get,String.Format("/ip/{0}/game/{1}/rule/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete rule
							/// <param name="ip">To be written</param>
							/// <param name="ipOnGame">To be written</param>
							/// <param name="id">ID of the rule</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.GameMitigationRule> DeleteIpGameRule(OVHApi.IPAddressBlock ip,System.Net.IPAddress ipOnGame,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("ipOnGame",ipOnGame);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Ip.GameMitigationRule>(HttpMethod.Delete,String.Format("/ip/{0}/game/{1}/rule/{2}",System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(ipOnGame.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Ip under game anti-ddos
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpGames(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/{0}/game",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpMigrationToken> GetIpMigrationtoken(OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Ip.IpMigrationToken>(HttpMethod.Get,String.Format("/ip/{0}/migrationToken",System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Generate a migration token
							/// <param name="customerId">destination customer ID</param>
							/// <param name="ip">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.IpMigrationToken> CreateIpMigrationtoken(string customerId,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("customerId",customerId);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("customerId",customerId);

			return await RawCall<OvhApi.Models.Ip.IpMigrationToken>(HttpMethod.Post,String.Format("/ip/{0}/migrationToken",System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetIpLoadbalancingServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task UpdateIpLoadbalancingServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/loadBalancing/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Import your own ssl certificate on your IP load balancing. Ssl option is needed to use this url.
							/// <param name="chain">certificate chain</param>
							/// <param name="certificate">certificate</param>
							/// <param name="key">certificate key</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingImportcustomssl(string certificate,string key,string serviceName,string chain = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("certificate",certificate);
Ensure.NotNullNorEmpty("key",key);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("chain",chain);
requestBody.Add("certificate",certificate);
requestBody.Add("key",key);

			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/importCustomSsl",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingIp> GetIpLoadbalancing(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingIp>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of backends you can attach to your IP
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpLoadbalancingAllowedbackends(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/allowedBackends",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Ip subnet used by OVH to nat requests on your ip lb to your backends. You must ensure that your backends are not part of a network that overlap with this one.
							/// <param name="zone">one of your ip loadbalancing's zone</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock> GetIpLoadbalancingInternalnatip(OvhApi.Models.Ip.LoadBalancingZoneEnum zone,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("zone",zone);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("zone",zone);

			
			return await RawCall<OVHApi.IPAddressBlock>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/internalNatIp{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Backends for this IP load balancing
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetIpLoadbalancingBackends(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/backend",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a new backend on your IP load balancing
							/// <param name="ipBackend">IP of your backend</param>
							/// <param name="probe">The type of probe used</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingBackend(System.Net.IPAddress ipBackend,OvhApi.Models.Ip.LoadBalancingBackendProbeEnum probe,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipBackend",ipBackend);
Ensure.NotNull("probe",probe);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ipBackend",ipBackend);
requestBody.Add("probe",probe);

			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/backend",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="backend">IP of your backend</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingBackendIp> GetIpLoadbalancingBackend(string serviceName,System.Net.IPAddress backend)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("backend",backend);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingBackendIp>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/backend/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(backend.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="backend">IP of your backend</param>
							/// </summary>
						public async Task UpdateIpLoadbalancingBackend(OvhApi.Models.Ip.LoadBalancingBackendIp requestBody,string serviceName,System.Net.IPAddress backend)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("backend",backend);

			
			
			await RawCall(HttpMethod.Put,String.Format("/ip/loadBalancing/{0}/backend/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(backend.ToString())),requestBody);
		}
				/// <summary>
		/// Remove a backend IP
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="backend">IP of your backend</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> DeleteIpLoadbalancingBackend(string serviceName,System.Net.IPAddress backend)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("backend",backend);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Delete,String.Format("/ip/loadBalancing/{0}/backend/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(backend.ToString())));
		}
				/// <summary>
		/// Set or unset the backend as a backup of another backend. Requests will be directed to the backup only if the main backend is in probe fail
							/// <param name="mainBackendIp">Main backend ip, must be in the same zone as the backup</param>
							/// <param name="backupStateSet">Set or unset the backend as backup. mainBackendIp is optional in case of unset</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="backend">IP of your backend</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingBackendBackupstate(bool backupStateSet,string serviceName,System.Net.IPAddress backend,System.Net.IPAddress mainBackendIp = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("backupStateSet",backupStateSet);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("backend",backend);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("mainBackendIp",mainBackendIp);
requestBody.Add("backupStateSet",backupStateSet);

			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/backend/{1}/backupState",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(backend.ToString())),requestBody);
		}
				/// <summary>
		/// Set the weight of a backend. For instance, if backend A has a weight of 8 and backup B was a weight of 16, backend B will receive twice more connections as backend A. Backends must be on the same POP for the weight parameter to take effect between them.
							/// <param name="weight">weight of the backend, must be between 1 and 100, default is 8</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="backend">IP of your backend</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingBackendSetweight(long weight,string serviceName,System.Net.IPAddress backend)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("weight",weight);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("backend",backend);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("weight",weight);

			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/backend/{1}/setWeight",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(backend.ToString())),requestBody);
		}
				/// <summary>
		/// Task list associated with this IP
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<long[]> GetIpLoadbalancingTaskIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/task",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="taskId">Identifier of your task</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> GetIpLoadbalancingTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Restore OVH' ssl certificate on your IP load balancing. Ssl option is needed to use this url. (A DCV mail will be sent to postmaster@your-domain.abc)
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingRestoressl(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/restoreSsl",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Set Stickiness type. 'ipSource' will stick clients to a backend by their source ip, 'cookie' will stick them by inserting a cookie, 'none' is to set no stickiness
							/// <param name="stickiness">The stickiness you want on your IP LoadBalancing</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingStickiness(OvhApi.Models.Ip.LoadBalancingStickinessEnum stickiness,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("stickiness",stickiness);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("stickiness",stickiness);

			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/stickiness",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get all srcPort
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingAdditionalPortEnum[]> GetIpLoadbalancingPortsredirections(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingAdditionalPortEnum[]>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/portsRedirection",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a new port redirection
							/// <param name="requestBody">The port you want to redirect to</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> CreateIpLoadbalancingPortsredirection(OvhApi.Models.Ip.LoadBalancingIp.LoadBalancingPort requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Post,String.Format("/ip/loadBalancing/{0}/portsRedirection",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get the value for the given srcPort
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="srcPort">The port you want to redirect from</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingIp.LoadBalancingPort> GetIpLoadbalancingPortsredirection(string serviceName,OvhApi.Models.Ip.LoadBalancingAdditionalPortEnum srcPort)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("srcPort",srcPort);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingIp.LoadBalancingPort>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/portsRedirection/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(srcPort.ToString())));
		}
				/// <summary>
		/// Delete a port redirection
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// <param name="srcPort">The port you want to redirect from</param>
							/// </summary>
						public async Task<OvhApi.Models.Ip.LoadBalancingTask> DeleteIpLoadbalancingPortsredirection(string serviceName,OvhApi.Models.Ip.LoadBalancingAdditionalPortEnum srcPort)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("srcPort",srcPort);

			
			
			return await RawCall<OvhApi.Models.Ip.LoadBalancingTask>(HttpMethod.Delete,String.Format("/ip/loadBalancing/{0}/portsRedirection/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(srcPort.ToString())));
		}
				/// <summary>
		/// Ip subnet used to send probes to your backends
							/// <param name="zone">one of your ip loadbalancing's zone</param>
							/// <param name="serviceName">The internal name of your IP load balancing</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetIpLoadbalancingProbeips(OvhApi.Models.Ip.LoadBalancingZoneEnum zone,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("zone",zone);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("zone",zone);

			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/ip/loadBalancing/{0}/probeIp{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetIpLoadbalancingNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/ip/loadBalancing"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetLicenseCpanelServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/license/cpanel/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task UpdateLicenseCpanelServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/cpanel/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Move this license to another Ip
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> CreateLicenseCpanelChangeip(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationIp",destinationIp);

			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Post,String.Format("/license/cpanel/{0}/changeIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Cpanel.Cpanel> GetLicenseCpanel(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.Cpanel.Cpanel>(HttpMethod.Get,String.Format("/license/cpanel/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task UpdateLicenseCpanel(OvhApi.Models.License.Cpanel.Cpanel requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/cpanel/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// tasks linked to this license
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="action">Filter the value of action property (=)</param>
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<long[]> GetLicenseCpanelTaskIds(string serviceName,OvhApi.Models.License.ActionType action = null,OvhApi.Models.License.TaskStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("action",action);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/license/cpanel/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// <param name="taskId">This Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> GetLicenseCpanelTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Get,String.Format("/license/cpanel/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Returns an array of ips where the license can be moved to
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetLicenseCpanelAlloweddestinationips(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/license/cpanel/{0}/allowedDestinationIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Will tell if the ip can accept the license
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Cpanel license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.ChangeIpStatus> GetLicenseCpanelCanlicensebemovedto(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("destinationIp",destinationIp);

			
			return await RawCall<OvhApi.Models.License.ChangeIpStatus>(HttpMethod.Get,String.Format("/license/cpanel/{0}/canLicenseBeMovedTo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetLicenseCpanelNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/license/cpanel"));
		}
				/// <summary>
		/// Get the orderable CPanel versions
							/// <param name="ip">Your license Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.License.CpanelOrderConfiguration[]> GetLicenseCpanelOrderableversions(System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			return await RawCall<OvhApi.Models.License.CpanelOrderConfiguration[]>(HttpMethod.Get,String.Format("/license/cpanel/orderableVersions{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetLicenseDirectadminServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/license/directadmin/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task UpdateLicenseDirectadminServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/directadmin/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Move this license to another Ip
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> CreateLicenseDirectadminChangeip(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationIp",destinationIp);

			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Post,String.Format("/license/directadmin/{0}/changeIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Directadmin.DirectAdmin> GetLicenseDirectadmin(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.Directadmin.DirectAdmin>(HttpMethod.Get,String.Format("/license/directadmin/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task UpdateLicenseDirectadmin(OvhApi.Models.License.Directadmin.DirectAdmin requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/directadmin/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// tasks linked to this license
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="action">Filter the value of action property (=)</param>
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<long[]> GetLicenseDirectadminTaskIds(string serviceName,OvhApi.Models.License.ActionType action = null,OvhApi.Models.License.TaskStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("action",action);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/license/directadmin/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// <param name="taskId">This Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> GetLicenseDirectadminTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Get,String.Format("/license/directadmin/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Returns an array of ips where the license can be moved to
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetLicenseDirectadminAlloweddestinationips(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/license/directadmin/{0}/allowedDestinationIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Will tell if the ip can accept the license
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your DirectAdmin license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.ChangeIpStatus> GetLicenseDirectadminCanlicensebemovedto(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("destinationIp",destinationIp);

			
			return await RawCall<OvhApi.Models.License.ChangeIpStatus>(HttpMethod.Get,String.Format("/license/directadmin/{0}/canLicenseBeMovedTo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetLicenseDirectadminNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/license/directadmin"));
		}
				/// <summary>
		/// Get the orderable DirectAdmin versions
							/// <param name="ip">Your license Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.License.DirectAdminOrderConfiguration[]> GetLicenseDirectadminOrderableversions(System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			return await RawCall<OvhApi.Models.License.DirectAdminOrderConfiguration[]>(HttpMethod.Get,String.Format("/license/directadmin/orderableVersions{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetLicensePleskServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/license/plesk/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task UpdateLicensePleskServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/plesk/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Move this license to another Ip
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> CreateLicensePleskChangeip(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationIp",destinationIp);

			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Post,String.Format("/license/plesk/{0}/changeIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Plesk.Plesk> GetLicensePlesk(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.Plesk.Plesk>(HttpMethod.Get,String.Format("/license/plesk/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task UpdateLicensePlesk(OvhApi.Models.License.Plesk.Plesk requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/plesk/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// tasks linked to this license
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="action">Filter the value of action property (=)</param>
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<long[]> GetLicensePleskTaskIds(string serviceName,OvhApi.Models.License.ActionType action = null,OvhApi.Models.License.TaskStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("action",action);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/license/plesk/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Plesk license</param>
							/// <param name="taskId">This Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> GetLicensePleskTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Get,String.Format("/license/plesk/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Returns an array of ips where the license can be moved to
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetLicensePleskAlloweddestinationips(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/license/plesk/{0}/allowedDestinationIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// options attached to this license
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.OptionLabel[]> GetLicensePleskOptions(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.OptionLabel[]>(HttpMethod.Get,String.Format("/license/plesk/{0}/option",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Plesk license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Option> GetLicensePleskOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Option>(HttpMethod.Get,String.Format("/license/plesk/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// release this Option
							/// <param name="serviceName">The name of your Plesk license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> DeleteLicensePleskOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Delete,String.Format("/license/plesk/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// Will tell if the ip can accept the license
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Plesk license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.ChangeIpStatus> GetLicensePleskCanlicensebemovedto(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("destinationIp",destinationIp);

			
			return await RawCall<OvhApi.Models.License.ChangeIpStatus>(HttpMethod.Get,String.Format("/license/plesk/{0}/canLicenseBeMovedTo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetLicensePleskNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/license/plesk"));
		}
				/// <summary>
		/// Get the orderable Plesk versions and their associated compatibilities
							/// <param name="ip">Your license Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.License.PleskOrderConfiguration[]> GetLicensePleskOrderableversions(System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			return await RawCall<OvhApi.Models.License.PleskOrderConfiguration[]>(HttpMethod.Get,String.Format("/license/plesk/orderableVersions{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetLicenseVirtuozzoServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task UpdateLicenseVirtuozzoServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/virtuozzo/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Move this license to another Ip
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> CreateLicenseVirtuozzoChangeip(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationIp",destinationIp);

			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Post,String.Format("/license/virtuozzo/{0}/changeIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Virtuozzo.Virtuozzo> GetLicenseVirtuozzo(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.Virtuozzo.Virtuozzo>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task UpdateLicenseVirtuozzo(OvhApi.Models.License.Virtuozzo.Virtuozzo requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/virtuozzo/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// tasks linked to this license
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="action">Filter the value of action property (=)</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<long[]> GetLicenseVirtuozzoTaskIds(string serviceName,OvhApi.Models.License.ActionType action = null,OvhApi.Models.License.TaskStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("action",action);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// <param name="taskId">This Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> GetLicenseVirtuozzoTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Returns an array of ips where the license can be moved to
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetLicenseVirtuozzoAlloweddestinationips(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/allowedDestinationIp",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Options linked to this license
							/// <param name="label">Filter the value of label property (=)</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.OptionLabel[]> GetLicenseVirtuozzoOptions(string serviceName,OvhApi.Models.License.OptionLabel label = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("label",label);

			
			return await RawCall<OvhApi.Models.License.OptionLabel[]>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/option{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Option> GetLicenseVirtuozzoOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Option>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// release this Option
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> DeleteLicenseVirtuozzoOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Delete,String.Format("/license/virtuozzo/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// Will tell if the ip can accept the license
							/// <param name="destinationIp">The Ip on which you want to move this license</param>
							/// <param name="serviceName">The name of your Virtuozzo license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.ChangeIpStatus> GetLicenseVirtuozzoCanlicensebemovedto(System.Net.IPAddress destinationIp,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("destinationIp",destinationIp);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("destinationIp",destinationIp);

			
			return await RawCall<OvhApi.Models.License.ChangeIpStatus>(HttpMethod.Get,String.Format("/license/virtuozzo/{0}/canLicenseBeMovedTo{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetLicenseVirtuozzoNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/license/virtuozzo"));
		}
				/// <summary>
		/// Get the orderable Virtuozzo versions
							/// <param name="ip">Your license Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.License.VirtuozzoOrderConfiguration[]> GetLicenseVirtuozzoOrderableversions(System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			return await RawCall<OvhApi.Models.License.VirtuozzoOrderConfiguration[]>(HttpMethod.Get,String.Format("/license/virtuozzo/orderableVersions{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetLicenseWindowsServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/license/windows/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task UpdateLicenseWindowsServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/windows/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Windows.Windows> GetLicenseWindows(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.Windows.Windows>(HttpMethod.Get,String.Format("/license/windows/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task UpdateLicenseWindows(OvhApi.Models.License.Windows.Windows requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/license/windows/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// tasks linked to this license
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="action">Filter the value of action property (=)</param>
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task<long[]> GetLicenseWindowsTaskIds(string serviceName,OvhApi.Models.License.ActionType action = null,OvhApi.Models.License.TaskStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("action",action);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/license/windows/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Windows license</param>
							/// <param name="taskId">This Task id</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> GetLicenseWindowsTasks(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Get,String.Format("/license/windows/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Link your own sql server license to this Windows license
							/// <param name="licenseId">Your license serial number</param>
							/// <param name="version">Your license version</param>
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> CreateLicenseWindowsSqlserver(string licenseId,OvhApi.Models.License.WindowsSqlVersionEnum version,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("licenseId",licenseId);
Ensure.NotNull("version",version);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("licenseId",licenseId);
requestBody.Add("version",version);

			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Post,String.Format("/license/windows/{0}/sqlServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// options attached to this license
							/// <param name="serviceName">The name of your Windows license</param>
							/// </summary>
						public async Task<OvhApi.Models.License.OptionLabel[]> GetLicenseWindowsOptions(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.License.OptionLabel[]>(HttpMethod.Get,String.Format("/license/windows/{0}/option",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The name of your Windows license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Option> GetLicenseWindowsOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Option>(HttpMethod.Get,String.Format("/license/windows/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// release this Option
							/// <param name="serviceName">The name of your Windows license</param>
							/// <param name="label">This option designation</param>
							/// </summary>
						public async Task<OvhApi.Models.License.Task> DeleteLicenseWindowsOption(string serviceName,OvhApi.Models.License.OptionLabel label)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("label",label);

			
			
			return await RawCall<OvhApi.Models.License.Task>(HttpMethod.Delete,String.Format("/license/windows/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(label.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetLicenseWindowNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/license/windows"));
		}
				/// <summary>
		/// Get the orderable Windows versions
							/// <param name="ip">Your license Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.License.WindowsOrderConfiguration[]> GetLicenseWindowsOrderableversions(System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);

			var queryString = new QueryString();
queryString.Add("ip",ip);

			
			return await RawCall<OvhApi.Models.License.WindowsOrderConfiguration[]>(HttpMethod.Get,String.Format("/license/windows/orderableVersions{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.Nichandle> GetMe()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<OvhApi.Models.Nichandle.Nichandle>(HttpMethod.Get,String.Format("/me"));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// </summary>
						public async Task UpdateMe(OvhApi.Models.Nichandle.Nichandle requestBody)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me"),requestBody);
		}
				/// <summary>
		/// List of IP restrictions
							/// </summary>
						public async Task<long[]> GetMeAccessrestrictionIpIds()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/accessRestriction/ip"));
		}
				/// <summary>
		/// Add an IP access restriction
							/// <param name="ip">An IP range where we will apply the rule</param>
							/// <param name="warning">Send an email if someone try to access with this IP address</param>
							/// <param name="rule">Accept or deny IP access</param>
							/// </summary>
						public async Task CreateMeAccessrestrictionIp(OVHApi.IPAddressBlock ip,bool warning,OvhApi.Models.Nichandle.AccessRestriction.IpRestrictionRuleEnum rule)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ip",ip);
Ensure.NotNull("warning",warning);
Ensure.NotNull("rule",rule);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ip",ip);
requestBody.Add("warning",warning);
requestBody.Add("rule",rule);

			await RawCall(HttpMethod.Post,String.Format("/me/accessRestriction/ip"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">The Id of the restriction</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.IpRestriction> GetMeAccessrestrictionIp(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Nichandle.IpRestriction>(HttpMethod.Get,String.Format("/me/accessRestriction/ip/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="id">The Id of the restriction</param>
							/// </summary>
						public async Task UpdateMeAccessrestrictionIp(OvhApi.Models.Nichandle.IpRestriction requestBody,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/accessRestriction/ip/{0}",System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this restriction rule
							/// <param name="id">The Id of the restriction</param>
							/// </summary>
						public async Task DeleteMeAccessrestrictionIp(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/accessRestriction/ip/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of your Api Application
							/// </summary>
						public async Task<long[]> GetMeApiApplicationIds()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/api/application"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="applicationId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Api.Application> GetMeApiApplication(long applicationId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("applicationId",applicationId);

			
			
			return await RawCall<OvhApi.Models.Api.Application>(HttpMethod.Get,String.Format("/me/api/application/{0}",System.Net.WebUtility.UrlEncode(applicationId.ToString())));
		}
				/// <summary>
		/// Remove this application. It will revoke all credential belonging to this application.
							/// <param name="applicationId">To be written</param>
							/// </summary>
						public async Task DeleteMeApiApplication(long applicationId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("applicationId",applicationId);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/api/application/{0}",System.Net.WebUtility.UrlEncode(applicationId.ToString())));
		}
				/// <summary>
		/// List of your Api Credentials
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="applicationId">Filter the value of applicationId property (like)</param>
							/// </summary>
						public async Task<long[]> GetMeApiCredentialIds(long? applicationId = null,OvhApi.Models.Auth.CredentialStateEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("status",status);
queryString.Add("applicationId",applicationId);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/api/credential{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="credentialId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Api.Credential> GetMeApiCredential(long credentialId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("credentialId",credentialId);

			
			
			return await RawCall<OvhApi.Models.Api.Credential>(HttpMethod.Get,String.Format("/me/api/credential/{0}",System.Net.WebUtility.UrlEncode(credentialId.ToString())));
		}
				/// <summary>
		/// Remove this credential
							/// <param name="credentialId">To be written</param>
							/// </summary>
						public async Task DeleteMeApiCredential(long credentialId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("credentialId",credentialId);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/api/credential/{0}",System.Net.WebUtility.UrlEncode(credentialId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="credentialId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Api.Application> GetMeApiCredentialApplication(long credentialId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("credentialId",credentialId);

			
			
			return await RawCall<OvhApi.Models.Api.Application>(HttpMethod.Get,String.Format("/me/api/credential/{0}/application",System.Net.WebUtility.UrlEncode(credentialId.ToString())));
		}
				/// <summary>
		/// List of all the orders the logged account has
							/// <param name="date_to">Filter the value of date property (<=)</param>
							/// <param name="date_from">Filter the value of date property (>=)</param>
							/// </summary>
						public async Task<long[]> GetMeOrderIds(DateTime? date_from = null,DateTime? date_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("date.to",date_to);
queryString.Add("date.from",date_from);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/order{0}",queryString));
		}
				/// <summary>
		/// Return main data about the object the processing of the order generated
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Order.PaymentMeans> GetMeOrderPaymentmeans(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Order.PaymentMeans>(HttpMethod.Get,String.Format("/me/order/{0}/paymentMeans",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Order> GetMeOrder(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Order>(HttpMethod.Get,String.Format("/me/order/{0}",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Payment> GetMeOrderPayment(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Payment>(HttpMethod.Get,String.Format("/me/order/{0}/payment",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Refund> GetMeOrderRefund(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Refund>(HttpMethod.Get,String.Format("/me/order/{0}/refund",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Payment> GetMeOrderRefundPayment(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Payment>(HttpMethod.Get,String.Format("/me/order/{0}/refund/payment",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// <param name="refundDetailId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.RefundDetail> GetMeOrderRefundDetails(long orderId,string refundDetailId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);
Ensure.NotNullNorEmpty("refundDetailId",refundDetailId);

			
			
			return await RawCall<OvhApi.Models.Billing.RefundDetail>(HttpMethod.Get,String.Format("/me/order/{0}/refund/details/{1}",System.Net.WebUtility.UrlEncode(orderId.ToString()),System.Net.WebUtility.UrlEncode(refundDetailId.ToString())));
		}
				/// <summary>
		/// Give access to all entries of the refund
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<string[]> GetMeOrderRefundDetailNames(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/order/{0}/refund/details",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Give access to all entries of the order
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<long[]> GetMeOrderDetailIds(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/order/{0}/details",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// <param name="orderDetailId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.OrderDetail> GetMeOrderDetails(long orderId,long orderDetailId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);
Ensure.IdIsValid("orderDetailId",orderDetailId);

			
			
			return await RawCall<OvhApi.Models.Billing.OrderDetail>(HttpMethod.Get,String.Format("/me/order/{0}/details/{1}",System.Net.WebUtility.UrlEncode(orderId.ToString()),System.Net.WebUtility.UrlEncode(orderDetailId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Bill> GetMeOrderBill(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Bill>(HttpMethod.Get,String.Format("/me/order/{0}/bill",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Payment> GetMeOrderBillPayment(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Payment>(HttpMethod.Get,String.Format("/me/order/{0}/bill/payment",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="orderId">To be written</param>
							/// <param name="billDetailId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.BillDetail> GetMeOrderBillDetails(long orderId,string billDetailId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);
Ensure.NotNullNorEmpty("billDetailId",billDetailId);

			
			
			return await RawCall<OvhApi.Models.Billing.BillDetail>(HttpMethod.Get,String.Format("/me/order/{0}/bill/details/{1}",System.Net.WebUtility.UrlEncode(orderId.ToString()),System.Net.WebUtility.UrlEncode(billDetailId.ToString())));
		}
				/// <summary>
		/// Give access to all entries of the bill
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<string[]> GetMeOrderBillDetailNames(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/order/{0}/bill/details",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// Return main data about the object the processing of the order generated
							/// <param name="orderId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Order.AssociatedObject> GetMeOrderAssociatedobject(long orderId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("orderId",orderId);

			
			
			return await RawCall<OvhApi.Models.Billing.Order.AssociatedObject>(HttpMethod.Get,String.Format("/me/order/{0}/associatedObject",System.Net.WebUtility.UrlEncode(orderId.ToString())));
		}
				/// <summary>
		/// List of Paypal accounts usable for payments on this account
							/// </summary>
						public async Task<long[]> GetMePaymentmeanPaypalIds()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/paymentMean/paypal"));
		}
				/// <summary>
		/// Enable payment through a new PayPal account
							/// <param name="returnUrl">Callback URL where the customer will be redirected to after validation</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.PaymentMeanValidation> CreateMePaymentmeanPaypal(string returnUrl = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("returnUrl",returnUrl);

			return await RawCall<OvhApi.Models.Billing.PaymentMeanValidation>(HttpMethod.Post,String.Format("/me/paymentMean/paypal"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Paypal> GetMePaymentmeanPaypal(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Billing.Paypal>(HttpMethod.Get,String.Format("/me/paymentMean/paypal/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Disable payment through this PayPal account
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteMePaymentmeanPaypal(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/paymentMean/paypal/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of credit cards
							/// </summary>
						public async Task<long[]> GetMePaymentmeanCreditcardIds()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/paymentMean/creditCard"));
		}
				/// <summary>
		/// Add a new credit card
							/// <param name="returnUrl">Callback URL where the customer will be redirected to after validation</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.PaymentMeanValidation> CreateMePaymentmeanCreditcard(string returnUrl = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("returnUrl",returnUrl);

			return await RawCall<OvhApi.Models.Billing.PaymentMeanValidation>(HttpMethod.Post,String.Format("/me/paymentMean/creditCard"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.CreditCard> GetMePaymentmeanCreditcard(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Billing.CreditCard>(HttpMethod.Get,String.Format("/me/paymentMean/creditCard/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Disable payment through this credit card
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteMePaymentmeanCreditcard(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/paymentMean/creditCard/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of bank accounts
							/// </summary>
						public async Task<long[]> GetMePaymentmeanBankaccountIds()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/paymentMean/bankAccount"));
		}
				/// <summary>
		/// Enable payment through a new account
							/// <param name="iban">Account's IBAN</param>
							/// <param name="ownerAddress">Account owner's address</param>
							/// <param name="ownerName">Account owner's name</param>
							/// <param name="bic">Account's BIC</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.PaymentMeanValidation> CreateMePaymentmeanBankaccount(string iban,string ownerAddress,string ownerName,string bic)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("iban",iban);
Ensure.NotNullNorEmpty("ownerAddress",ownerAddress);
Ensure.NotNullNorEmpty("ownerName",ownerName);
Ensure.NotNullNorEmpty("bic",bic);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("iban",iban);
requestBody.Add("ownerAddress",ownerAddress);
requestBody.Add("ownerName",ownerName);
requestBody.Add("bic",bic);

			return await RawCall<OvhApi.Models.Billing.PaymentMeanValidation>(HttpMethod.Post,String.Format("/me/paymentMean/bankAccount"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.BankAccount> GetMePaymentmeanBankaccount(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Billing.BankAccount>(HttpMethod.Get,String.Format("/me/paymentMean/bankAccount/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Disable payment through this account
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteMePaymentmeanBankaccount(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/paymentMean/bankAccount/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of all OVH things you can subscribe to
							/// </summary>
						public async Task<string[]> GetMeSubscriptionNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/subscription"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="subscriptionType">The type of subscription</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.Subscription> GetMeSubscription(string subscriptionType)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("subscriptionType",subscriptionType);

			
			
			return await RawCall<OvhApi.Models.Nichandle.Subscription>(HttpMethod.Get,String.Format("/me/subscription/{0}",System.Net.WebUtility.UrlEncode(subscriptionType.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="subscriptionType">The type of subscription</param>
							/// </summary>
						public async Task UpdateMeSubscription(OvhApi.Models.Nichandle.Subscription requestBody,string subscriptionType)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("subscriptionType",subscriptionType);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/subscription/{0}",System.Net.WebUtility.UrlEncode(subscriptionType.ToString())),requestBody);
		}
				/// <summary>
		/// Your customized operating system installation templates
							/// </summary>
						public async Task<string[]> GetMeInstallationtemplateNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/installationTemplate"));
		}
				/// <summary>
		/// Create a template
							/// <param name="defaultLanguage">To be written</param>
							/// <param name="name">Your template name</param>
							/// <param name="baseTemplateName">OVH template name yours will be based on, choose one among the list given by compatibleTemplates function</param>
							/// </summary>
						public async Task CreateMeInstallationtemplate(OvhApi.Models.Dedicated.TemplateOsLanguageEnum defaultLanguage,string name,string baseTemplateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("defaultLanguage",defaultLanguage);
Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("baseTemplateName",baseTemplateName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("defaultLanguage",defaultLanguage);
requestBody.Add("name",name);
requestBody.Add("baseTemplateName",baseTemplateName);

			await RawCall(HttpMethod.Post,String.Format("/me/installationTemplate"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.Templates> GetMeInstallationtemplate(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.Templates>(HttpMethod.Get,String.Format("/me/installationTemplate/{0}",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task UpdateMeInstallationtemplate(OvhApi.Models.Dedicated.InstallationTemplate.Templates requestBody,string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/installationTemplate/{0}",System.Net.WebUtility.UrlEncode(templateName.ToString())),requestBody);
		}
				/// <summary>
		/// remove this template
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task DeleteMeInstallationtemplate(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/installationTemplate/{0}",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// Partitioning schemes available on this template
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task<string[]> GetMeInstallationtemplatePartitionschemeNames(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/installationTemplate/{0}/partitionScheme",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// Add a scheme of partition
							/// <param name="priority">on a reinstall, if a partitioning scheme is not specified, the one with the higher priority will be used by default, among all the compatible partitioning schemes (given the underlying hardware specifications)</param>
							/// <param name="name">name of this partitioning scheme</param>
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task CreateMeInstallationtemplatePartitionscheme(long priority,string name,string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("priority",priority);
Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("templateName",templateName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("priority",priority);
requestBody.Add("name",name);

			await RawCall(HttpMethod.Post,String.Format("/me/installationTemplate/{0}/partitionScheme",System.Net.WebUtility.UrlEncode(templateName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitioningSchemes> GetMeInstallationtemplatePartitionscheme(string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitioningSchemes>(HttpMethod.Get,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task UpdateMeInstallationtemplatePartitionscheme(OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitioningSchemes requestBody,string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())),requestBody);
		}
				/// <summary>
		/// remove this scheme of partition
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task DeleteMeInstallationtemplatePartitionscheme(string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())));
		}
				/// <summary>
		/// Partitions defined in this partitioning scheme
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task<string[]> GetMeInstallationtemplatePartitionschemePartitionNames(string templateName,string schemeName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}/partition",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())));
		}
				/// <summary>
		/// Add a partition in this partitioning scheme
							/// <param name="volumeName">The volume name needed for proxmox distribution</param>
							/// <param name="raid">To be written</param>
							/// <param name="step">To be written</param>
							/// <param name="filesystem">Partition filesytem</param>
							/// <param name="mountpoint">partition mount point</param>
							/// <param name="type">To be written</param>
							/// <param name="size">size of partition in Mb, 0 => rest of the space</param>
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// </summary>
						public async Task CreateMeInstallationtemplatePartitionschemePartition(long step,OvhApi.Models.Dedicated.TemplateOsFileSystemEnum filesystem,string mountpoint,OvhApi.Models.Dedicated.TemplatePartitionTypeEnum type,long size,string templateName,string schemeName,long? raid = null,string volumeName = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("step",step);
Ensure.NotNull("filesystem",filesystem);
Ensure.NotNullNorEmpty("mountpoint",mountpoint);
Ensure.NotNull("type",type);
Ensure.IdIsValid("size",size);
Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("volumeName",volumeName);
requestBody.Add("raid",raid);
requestBody.Add("step",step);
requestBody.Add("filesystem",filesystem);
requestBody.Add("mountpoint",mountpoint);
requestBody.Add("type",type);
requestBody.Add("size",size);

			await RawCall(HttpMethod.Post,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}/partition",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// <param name="mountpoint">partition mount point</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitions> GetMeInstallationtemplatePartitionschemePartition(string templateName,string schemeName,string mountpoint)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);
Ensure.NotNullNorEmpty("mountpoint",mountpoint);

			
			
			return await RawCall<OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitions>(HttpMethod.Get,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}/partition/{2}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString()),System.Net.WebUtility.UrlEncode(mountpoint.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// <param name="mountpoint">partition mount point</param>
							/// </summary>
						public async Task UpdateMeInstallationtemplatePartitionschemePartition(OvhApi.Models.Dedicated.InstallationTemplate.TemplatePartitions requestBody,string templateName,string schemeName,string mountpoint)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);
Ensure.NotNullNorEmpty("mountpoint",mountpoint);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}/partition/{2}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString()),System.Net.WebUtility.UrlEncode(mountpoint.ToString())),requestBody);
		}
				/// <summary>
		/// remove this partition
							/// <param name="templateName">This template name</param>
							/// <param name="schemeName">name of this partitioning scheme</param>
							/// <param name="mountpoint">partition mount point</param>
							/// </summary>
						public async Task DeleteMeInstallationtemplatePartitionschemePartition(string templateName,string schemeName,string mountpoint)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);
Ensure.NotNullNorEmpty("schemeName",schemeName);
Ensure.NotNullNorEmpty("mountpoint",mountpoint);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/installationTemplate/{0}/partitionScheme/{1}/partition/{2}",System.Net.WebUtility.UrlEncode(templateName.ToString()),System.Net.WebUtility.UrlEncode(schemeName.ToString()),System.Net.WebUtility.UrlEncode(mountpoint.ToString())));
		}
				/// <summary>
		/// Check the integrity of this template
							/// <param name="templateName">This template name</param>
							/// </summary>
						public async Task CreateMeInstallationtemplateCheckintegrity(string templateName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("templateName",templateName);

			
			
			await RawCall(HttpMethod.Post,String.Format("/me/installationTemplate/{0}/checkIntegrity",System.Net.WebUtility.UrlEncode(templateName.ToString())));
		}
				/// <summary>
		/// List of all the refunds the logged account has
							/// <param name="date_to">Filter the value of date property (<=)</param>
							/// <param name="date_from">Filter the value of date property (>=)</param>
							/// </summary>
						public async Task<string[]> GetMeRefundNames(DateTime? date_from = null,DateTime? date_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("date.to",date_to);
queryString.Add("date.from",date_from);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/refund{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="refundId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Refund> GetMeRefund(string refundId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("refundId",refundId);

			
			
			return await RawCall<OvhApi.Models.Billing.Refund>(HttpMethod.Get,String.Format("/me/refund/{0}",System.Net.WebUtility.UrlEncode(refundId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="refundId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Payment> GetMeRefundPayment(string refundId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("refundId",refundId);

			
			
			return await RawCall<OvhApi.Models.Billing.Payment>(HttpMethod.Get,String.Format("/me/refund/{0}/payment",System.Net.WebUtility.UrlEncode(refundId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="refundId">To be written</param>
							/// <param name="refundDetailId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.RefundDetail> GetMeRefundDetails(string refundId,string refundDetailId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("refundId",refundId);
Ensure.NotNullNorEmpty("refundDetailId",refundDetailId);

			
			
			return await RawCall<OvhApi.Models.Billing.RefundDetail>(HttpMethod.Get,String.Format("/me/refund/{0}/details/{1}",System.Net.WebUtility.UrlEncode(refundId.ToString()),System.Net.WebUtility.UrlEncode(refundDetailId.ToString())));
		}
				/// <summary>
		/// Give access to all entries of the refund
							/// <param name="refundId">To be written</param>
							/// </summary>
						public async Task<string[]> GetMeRefundDetailNames(string refundId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("refundId",refundId);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/refund/{0}/details",System.Net.WebUtility.UrlEncode(refundId.ToString())));
		}
				/// <summary>
		/// List of OVH accounts the logged account has
							/// </summary>
						public async Task<string[]> GetMeOvhaccountNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/ovhAccount"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ovhAccountId">To be written</param>
							/// <param name="movementId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Movement> GetMeOvhaccountMovements(string ovhAccountId,long movementId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("ovhAccountId",ovhAccountId);
Ensure.IdIsValid("movementId",movementId);

			
			
			return await RawCall<OvhApi.Models.Billing.Movement>(HttpMethod.Get,String.Format("/me/ovhAccount/{0}/movements/{1}",System.Net.WebUtility.UrlEncode(ovhAccountId.ToString()),System.Net.WebUtility.UrlEncode(movementId.ToString())));
		}
				/// <summary>
		/// Details about an entry of the OVH account
							/// <param name="date_to">Filter the value of date property (<=)</param>
							/// <param name="date_from">Filter the value of date property (>=)</param>
							/// <param name="ovhAccountId">To be written</param>
							/// </summary>
						public async Task<long[]> GetMeOvhaccountMovementIds(string ovhAccountId,DateTime? date_from = null,DateTime? date_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("ovhAccountId",ovhAccountId);

			var queryString = new QueryString();
queryString.Add("date.to",date_to);
queryString.Add("date.from",date_from);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/ovhAccount/{0}/movements{1}",System.Net.WebUtility.UrlEncode(ovhAccountId.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="ovhAccountId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.OvhAccount> GetMeOvhaccount(string ovhAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("ovhAccountId",ovhAccountId);

			
			
			return await RawCall<OvhApi.Models.Billing.OvhAccount>(HttpMethod.Get,String.Format("/me/ovhAccount/{0}",System.Net.WebUtility.UrlEncode(ovhAccountId.ToString())));
		}
				/// <summary>
		/// Generate an order that can be paid in order to credit the OVH account
							/// <param name="amount">The amount in cents you want to credit your account of</param>
							/// <param name="ovhAccountId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Order> CreateMeOvhaccountCreditorder(long amount,string ovhAccountId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("amount",amount);
Ensure.NotNullNorEmpty("ovhAccountId",ovhAccountId);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("amount",amount);

			return await RawCall<OvhApi.Models.Billing.Order>(HttpMethod.Post,String.Format("/me/ovhAccount/{0}/creditOrder",System.Net.WebUtility.UrlEncode(ovhAccountId.ToString())),requestBody);
		}
				/// <summary>
		/// Initiate a password change procedure
							/// </summary>
						public async Task CreateMeChangepassword()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			await RawCall(HttpMethod.Post,String.Format("/me/changePassword"));
		}
				/// <summary>
		/// List of organisations
							/// </summary>
						public async Task<string[]> GetMeIporganisationNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/ipOrganisation"));
		}
				/// <summary>
		/// Add an organisation
							/// <param name="country">To be written</param>
							/// <param name="firstname">To be written</param>
							/// <param name="city">To be written</param>
							/// <param name="zip">To be written</param>
							/// <param name="registry">To be written</param>
							/// <param name="address">To be written</param>
							/// <param name="lastname">To be written</param>
							/// <param name="phone">To be written</param>
							/// <param name="abuse_mailbox">To be written</param>
							/// </summary>
						public async Task CreateMeIporganisation(OvhApi.Models.Nichandle.CountryEnum country,string firstname,string city,OvhApi.Models.Nichandle.IpRegistryEnum registry,string address,string lastname,string phone,string abuse_mailbox,string zip = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("country",country);
Ensure.NotNullNorEmpty("firstname",firstname);
Ensure.NotNullNorEmpty("city",city);
Ensure.NotNull("registry",registry);
Ensure.NotNullNorEmpty("address",address);
Ensure.NotNullNorEmpty("lastname",lastname);
Ensure.NotNullNorEmpty("phone",phone);
Ensure.NotNullNorEmpty("abuse_mailbox",abuse_mailbox);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("country",country);
requestBody.Add("firstname",firstname);
requestBody.Add("city",city);
requestBody.Add("zip",zip);
requestBody.Add("registry",registry);
requestBody.Add("address",address);
requestBody.Add("lastname",lastname);
requestBody.Add("phone",phone);
requestBody.Add("abuse_mailbox",abuse_mailbox);

			await RawCall(HttpMethod.Post,String.Format("/me/ipOrganisation"),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="organisationId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.Ipv4Org> GetMeIporganisation(string organisationId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("organisationId",organisationId);

			
			
			return await RawCall<OvhApi.Models.Nichandle.Ipv4Org>(HttpMethod.Get,String.Format("/me/ipOrganisation/{0}",System.Net.WebUtility.UrlEncode(organisationId.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="organisationId">To be written</param>
							/// </summary>
						public async Task UpdateMeIporganisation(OvhApi.Models.Nichandle.Ipv4Org requestBody,string organisationId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("organisationId",organisationId);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/ipOrganisation/{0}",System.Net.WebUtility.UrlEncode(organisationId.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="keyName">Name of this public SSH key</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.SshKey> GetMeSshkey(string keyName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("keyName",keyName);

			
			
			return await RawCall<OvhApi.Models.Nichandle.SshKey>(HttpMethod.Get,String.Format("/me/sshKey/{0}",System.Net.WebUtility.UrlEncode(keyName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="keyName">Name of this public SSH key</param>
							/// </summary>
						public async Task UpdateMeSshkey(OvhApi.Models.Nichandle.SshKey requestBody,string keyName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("keyName",keyName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/me/sshKey/{0}",System.Net.WebUtility.UrlEncode(keyName.ToString())),requestBody);
		}
				/// <summary>
		/// Remove this public SSH key
							/// <param name="keyName">Name of this public SSH key</param>
							/// </summary>
						public async Task DeleteMeSshkey(string keyName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("keyName",keyName);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/me/sshKey/{0}",System.Net.WebUtility.UrlEncode(keyName.ToString())));
		}
				/// <summary>
		/// List of your public SSH keys
							/// </summary>
						public async Task<string[]> GetMeSshkeyNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/sshKey"));
		}
				/// <summary>
		/// Add a new public SSH key
							/// <param name="key">ASCII encoded public SSH key to add</param>
							/// <param name="keyName">name of the new public SSH key</param>
							/// </summary>
						public async Task CreateMeSshkey(string key,string keyName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("key",key);
Ensure.NotNullNorEmpty("keyName",keyName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("key",key);
requestBody.Add("keyName",keyName);

			await RawCall(HttpMethod.Post,String.Format("/me/sshKey"),requestBody);
		}
				/// <summary>
		/// Request a password recover
							/// <param name="ovhId">Your OVH Account Id</param>
							/// <param name="ovhCompany">Company of your OVH Account Id</param>
							/// </summary>
						public async Task CreateMePasswordrecover(string ovhId,OvhApi.Models.Nichandle.OvhCompanyEnum ovhCompany)
		{
					Ensure.NotNullNorEmpty("ovhId",ovhId);
Ensure.NotNull("ovhCompany",ovhCompany);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ovhId",ovhId);
requestBody.Add("ovhCompany",ovhCompany);

			await RawCall(HttpMethod.Post,String.Format("/me/passwordRecover"),requestBody);
		}
				/// <summary>
		/// List of contracts signed between you and OVH
							/// <param name="agreed">Filter the value of agreed property (like)</param>
							/// <param name="contractId">Filter the value of contractId property (like)</param>
							/// </summary>
						public async Task<long[]> GetMeAgreementIds(long? contractId = null,OvhApi.Models.Agreements.AgreementStateEnum? agreed = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("agreed",agreed);
queryString.Add("contractId",contractId);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/me/agreements{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">Id of the contract</param>
							/// </summary>
						public async Task<OvhApi.Models.Agreements.ContractAgreement> GetMeAgreements(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Agreements.ContractAgreement>(HttpMethod.Get,String.Format("/me/agreements/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">Id of the contract</param>
							/// </summary>
						public async Task<OvhApi.Models.Agreements.Contract> GetMeAgreementsContract(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Agreements.Contract>(HttpMethod.Get,String.Format("/me/agreements/{0}/contract",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Accept this contract
							/// <param name="id">Id of the contract</param>
							/// </summary>
						public async Task<string> CreateMeAgreementsAccept(long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<string>(HttpMethod.Post,String.Format("/me/agreements/{0}/accept",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List of all the bills the logged account has
							/// <param name="date_to">Filter the value of date property (<=)</param>
							/// <param name="date_from">Filter the value of date property (>=)</param>
							/// </summary>
						public async Task<string[]> GetMeBillNames(DateTime? date_from = null,DateTime? date_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			var queryString = new QueryString();
queryString.Add("date.to",date_to);
queryString.Add("date.from",date_from);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/bill{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Bill> GetMeBill(string billId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billId",billId);

			
			
			return await RawCall<OvhApi.Models.Billing.Bill>(HttpMethod.Get,String.Format("/me/bill/{0}",System.Net.WebUtility.UrlEncode(billId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.Payment> GetMeBillPayment(string billId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billId",billId);

			
			
			return await RawCall<OvhApi.Models.Billing.Payment>(HttpMethod.Get,String.Format("/me/bill/{0}/payment",System.Net.WebUtility.UrlEncode(billId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billId">To be written</param>
							/// <param name="billDetailId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Billing.BillDetail> GetMeBillDetails(string billId,string billDetailId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billId",billId);
Ensure.NotNullNorEmpty("billDetailId",billDetailId);

			
			
			return await RawCall<OvhApi.Models.Billing.BillDetail>(HttpMethod.Get,String.Format("/me/bill/{0}/details/{1}",System.Net.WebUtility.UrlEncode(billId.ToString()),System.Net.WebUtility.UrlEncode(billDetailId.ToString())));
		}
				/// <summary>
		/// Give access to all entries of the bill
							/// <param name="billId">To be written</param>
							/// </summary>
						public async Task<string[]> GetMeBillDetailNames(string billId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billId",billId);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/me/bill/{0}/details",System.Net.WebUtility.UrlEncode(billId.ToString())));
		}
				/// <summary>
		/// Create a new OVH identifier
							/// <param name="firstname">To be written</param>
							/// <param name="vat">To be written</param>
							/// <param name="spareEmail">To be written</param>
							/// <param name="nationalIdentificationNumber">To be written</param>
							/// <param name="birthDay">To be written</param>
							/// <param name="area">To be written</param>
							/// <param name="ovhSubsidiary">To be written</param>
							/// <param name="ovhCompany">To be written</param>
							/// <param name="email">To be written</param>
							/// <param name="city">To be written</param>
							/// <param name="fax">To be written</param>
							/// <param name="address">To be written</param>
							/// <param name="companyNationalIdentificationNumber">To be written</param>
							/// <param name="country">To be written</param>
							/// <param name="birthCity">To be written</param>
							/// <param name="organisation">To be written</param>
							/// <param name="language">To be written</param>
							/// <param name="name">To be written</param>
							/// <param name="sex">To be written</param>
							/// <param name="phone">To be written</param>
							/// <param name="zip">To be written</param>
							/// <param name="corporationType">To be written</param>
							/// <param name="legalform">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.NewAccountAndToken> CreateNewaccount(OvhApi.Models.Nichandle.OvhSubsidiaryEnum ovhSubsidiary,OvhApi.Models.Nichandle.OvhCompanyEnum ovhCompany,string email,OvhApi.Models.Nichandle.CountryEnum country,OvhApi.Models.Nichandle.LegalFormEnum legalform,string corporationType = null,string zip = null,string phone = null,OvhApi.Models.Nichandle.GenderEnum? sex = null,string name = null,OvhApi.Models.Nichandle.LanguageEnum? language = null,string organisation = null,string birthCity = null,string companyNationalIdentificationNumber = null,string address = null,string fax = null,string city = null,string area = null,string birthDay = null,string nationalIdentificationNumber = null,string spareEmail = null,string vat = null,string firstname = null)
		{
					Ensure.NotNull("ovhSubsidiary",ovhSubsidiary);
Ensure.NotNull("ovhCompany",ovhCompany);
Ensure.NotNullNorEmpty("email",email);
Ensure.NotNull("country",country);
Ensure.NotNull("legalform",legalform);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("firstname",firstname);
requestBody.Add("vat",vat);
requestBody.Add("spareEmail",spareEmail);
requestBody.Add("nationalIdentificationNumber",nationalIdentificationNumber);
requestBody.Add("birthDay",birthDay);
requestBody.Add("area",area);
requestBody.Add("ovhSubsidiary",ovhSubsidiary);
requestBody.Add("ovhCompany",ovhCompany);
requestBody.Add("email",email);
requestBody.Add("city",city);
requestBody.Add("fax",fax);
requestBody.Add("address",address);
requestBody.Add("companyNationalIdentificationNumber",companyNationalIdentificationNumber);
requestBody.Add("country",country);
requestBody.Add("birthCity",birthCity);
requestBody.Add("organisation",organisation);
requestBody.Add("language",language);
requestBody.Add("name",name);
requestBody.Add("sex",sex);
requestBody.Add("phone",phone);
requestBody.Add("zip",zip);
requestBody.Add("corporationType",corporationType);
requestBody.Add("legalform",legalform);

			return await RawCall<OvhApi.Models.Nichandle.NewAccountAndToken>(HttpMethod.Post,String.Format("/newAccount"),requestBody);
		}
				/// <summary>
		/// All available areas for a given country
							/// <param name="country">To be written</param>
							/// </summary>
						public async Task<string[]> GetNewaccountAreaNames(OvhApi.Models.Nichandle.CountryEnum country)
		{
					Ensure.NotNull("country",country);

			var queryString = new QueryString();
queryString.Add("country",country);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/newAccount/area{0}",queryString));
		}
				/// <summary>
		/// All available corporation types for a given country
							/// <param name="country">To be written</param>
							/// </summary>
						public async Task<string[]> GetNewaccountCorporationtypeNames(OvhApi.Models.Nichandle.CountryEnum country)
		{
					Ensure.NotNull("country",country);

			var queryString = new QueryString();
queryString.Add("country",country);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/newAccount/corporationType{0}",queryString));
		}
				/// <summary>
		/// Give all the rules to follow in order to create an OVH identifier
							/// <param name="country">To be written</param>
							/// <param name="ovhSubsidiary">To be written</param>
							/// <param name="ovhCompany">To be written</param>
							/// <param name="legalform">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.CreationRules> GetNewaccountCreationrules(OvhApi.Models.Nichandle.CountryEnum country,OvhApi.Models.Nichandle.OvhSubsidiaryEnum ovhSubsidiary,OvhApi.Models.Nichandle.OvhCompanyEnum ovhCompany,OvhApi.Models.Nichandle.LegalFormEnum legalform)
		{
					Ensure.NotNull("country",country);
Ensure.NotNull("ovhSubsidiary",ovhSubsidiary);
Ensure.NotNull("ovhCompany",ovhCompany);
Ensure.NotNull("legalform",legalform);

			var queryString = new QueryString();
queryString.Add("country",country);
queryString.Add("ovhSubsidiary",ovhSubsidiary);
queryString.Add("ovhCompany",ovhCompany);
queryString.Add("legalform",legalform);

			
			return await RawCall<OvhApi.Models.Nichandle.CreationRules>(HttpMethod.Get,String.Format("/newAccount/creationRules{0}",queryString));
		}
				/// <summary>
		/// All available legal forms for a given country
							/// <param name="country">To be written</param>
							/// </summary>
						public async Task<string[]> GetNewaccountLegalformNames(OvhApi.Models.Nichandle.CountryEnum country)
		{
					Ensure.NotNull("country",country);

			var queryString = new QueryString();
queryString.Add("country",country);

			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/newAccount/legalform{0}",queryString));
		}
				/// <summary>
		/// All available countries for an ovh company and an ovh subsidiary
							/// <param name="ovhSubsidiary">To be written</param>
							/// <param name="ovhCompany">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Nichandle.CountryEnum[]> GetNewaccountCountries(OvhApi.Models.Nichandle.OvhSubsidiaryEnum ovhSubsidiary,OvhApi.Models.Nichandle.OvhCompanyEnum ovhCompany)
		{
					Ensure.NotNull("ovhSubsidiary",ovhSubsidiary);
Ensure.NotNull("ovhCompany",ovhCompany);

			var queryString = new QueryString();
queryString.Add("ovhSubsidiary",ovhSubsidiary);
queryString.Add("ovhCompany",ovhCompany);

			
			return await RawCall<OvhApi.Models.Nichandle.CountryEnum[]>(HttpMethod.Get,String.Format("/newAccount/countries{0}",queryString));
		}
				/// <summary>
		/// Get price of CDN
							/// <param name="modelName">Type of CDN</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceCdnAnycastModel(OvhApi.Models.Price.Cdn.Anycast.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/cdn/anycast/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of CDN Quota
							/// <param name="quotaSize">Quota in TB</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceCdnAnycastOptionQuota(OvhApi.Models.Price.Cdn.Anycast.Option.QuotaEnum quotaSize)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("quotaSize",quotaSize);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/cdn/anycast/option/quota/{0}",System.Net.WebUtility.UrlEncode(quotaSize.ToString())));
		}
				/// <summary>
		/// Get price
							/// <param name="optionName">Option</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceCdnAnycastOption(OvhApi.Models.Price.Cdn.Anycast.OptionEnum optionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("optionName",optionName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/cdn/anycast/option/{0}",System.Net.WebUtility.UrlEncode(optionName.ToString())));
		}
				/// <summary>
		/// Get price of CDN cache rules
							/// <param name="cacheruleNumber">Number of cache rules</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceCdnAnycastOptionCacherules(OvhApi.Models.Price.Cdn.Anycast.Option.CacherulesEnum cacheruleNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("cacheruleNumber",cacheruleNumber);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/cdn/anycast/option/cacherules/{0}",System.Net.WebUtility.UrlEncode(cacheruleNumber.ToString())));
		}
				/// <summary>
		/// Get price of zone options
							/// <param name="optionName">Option</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDomainZoneOption(OvhApi.Models.Price.Domain.Zone.OptionEnum optionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("optionName",optionName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/domain/zone/option/{0}",System.Net.WebUtility.UrlEncode(optionName.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudBhs1aFilerHourly(OvhApi.Models.Price.DedicatedCloud.Bhs1a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/bhs1a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudBhs1aFilerMonthly(OvhApi.Models.Price.DedicatedCloud.Bhs1a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/bhs1a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudBhs1aHostHourly(OvhApi.Models.Price.DedicatedCloud.Bhs1a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/bhs1a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudBhs1aHostMonthly(OvhApi.Models.Price.DedicatedCloud.Bhs1a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/bhs1a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aInfrastructureFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Infrastructure.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/infrastructure/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aInfrastructureFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Infrastructure.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/infrastructure/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aInfrastructureHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Infrastructure.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/infrastructure/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aInfrastructureHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Infrastructure.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/infrastructure/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aEnterpriseFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Enterprise.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/enterprise/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aEnterpriseFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Enterprise.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/enterprise/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aEnterpriseHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Enterprise.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/enterprise/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Bhs1aEnterpriseHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Bhs1a.Enterprise.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/bhs1a/enterprise/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bInfrastructureFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Infrastructure.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/infrastructure/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bInfrastructureFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Infrastructure.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/infrastructure/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bInfrastructureHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Infrastructure.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/infrastructure/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bInfrastructureHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Infrastructure.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/infrastructure/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bEnterpriseFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Enterprise.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/enterprise/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bEnterpriseFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Enterprise.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/enterprise/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bEnterpriseHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Enterprise.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/enterprise/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2bEnterpriseHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2b.Enterprise.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2b/enterprise/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aInfrastructureFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Infrastructure.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/infrastructure/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aInfrastructureFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Infrastructure.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/infrastructure/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aInfrastructureHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Infrastructure.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/infrastructure/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aInfrastructureHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Infrastructure.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/infrastructure/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aEnterpriseFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Enterprise.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/enterprise/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aEnterpriseFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Enterprise.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/enterprise/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aEnterpriseHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Enterprise.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/enterprise/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Sbg1aEnterpriseHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Sbg1a.Enterprise.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/sbg1a/enterprise/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aInfrastructureFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Infrastructure.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/infrastructure/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aInfrastructureFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Infrastructure.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/infrastructure/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aInfrastructureHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Infrastructure.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/infrastructure/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aInfrastructureHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Infrastructure.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/infrastructure/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aEnterpriseFilerHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Enterprise.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/enterprise/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aEnterpriseFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Enterprise.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/enterprise/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aEnterpriseHostHourly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Enterprise.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/enterprise/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2014v1Rbx2aEnterpriseHostMonthly(OvhApi.Models.Price.DedicatedCloud._2014v1.Rbx2a.Enterprise.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2014v1/rbx2a/enterprise/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Bhs1aFilerHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Bhs1a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/bhs1a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Bhs1aFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Bhs1a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/bhs1a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Bhs1aHostHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Bhs1a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/bhs1a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Bhs1aHostMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Bhs1a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/bhs1a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Sbg1aFilerHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Sbg1a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/sbg1a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Sbg1aFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Sbg1a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/sbg1a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Sbg1aHostHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Sbg1a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/sbg1a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Sbg1aHostMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Sbg1a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/sbg1a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Rbx2aFilerHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Rbx2a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/rbx2a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Rbx2aFilerMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Rbx2a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/rbx2a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Rbx2aHostHourly(OvhApi.Models.Price.DedicatedCloud._2013v1.Rbx2a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/rbx2a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloud2013v1Rbx2aHostMonthly(OvhApi.Models.Price.DedicatedCloud._2013v1.Rbx2a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/2013v1/rbx2a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudSbg1aFilerHourly(OvhApi.Models.Price.DedicatedCloud.Sbg1a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/sbg1a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudSbg1aFilerMonthly(OvhApi.Models.Price.DedicatedCloud.Sbg1a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/sbg1a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudSbg1aHostHourly(OvhApi.Models.Price.DedicatedCloud.Sbg1a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/sbg1a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudSbg1aHostMonthly(OvhApi.Models.Price.DedicatedCloud.Sbg1a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/sbg1a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly filer ressources
							/// <param name="filerProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudRbx2aFilerHourly(OvhApi.Models.Price.DedicatedCloud.Rbx2a.Filer.HourlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/rbx2a/filer/hourly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly filer ressources
							/// <param name="filerProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudRbx2aFilerMonthly(OvhApi.Models.Price.DedicatedCloud.Rbx2a.Filer.MonthlyEnum filerProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("filerProfile",filerProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/rbx2a/filer/monthly/{0}",System.Net.WebUtility.UrlEncode(filerProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud hourly host ressources
							/// <param name="hostProfile">type of the hourly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudRbx2aHostHourly(OvhApi.Models.Price.DedicatedCloud.Rbx2a.Host.HourlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/rbx2a/host/hourly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of dedicated Cloud monthly host ressources
							/// <param name="hostProfile">type of the monthly ressources you want to order</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedcloudRbx2aHostMonthly(OvhApi.Models.Price.DedicatedCloud.Rbx2a.Host.MonthlyEnum hostProfile)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("hostProfile",hostProfile);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicatedCloud/rbx2a/host/monthly/{0}",System.Net.WebUtility.UrlEncode(hostProfile.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud
							/// <param name="modelName">Model</param>
							/// </summary>
						[Obsolete("Deprecated since 03/18/2014 10:00:00 use '/price/vps/2013v1/cloud/model/{modelName}' instead")]
				public async Task<OvhApi.Models.Order.Price> GetPriceVpsCloudModel(OvhApi.Models.Price.Vps.Cloud.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/cloud/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud Options
							/// <param name="optionName">Option</param>
							/// </summary>
						[Obsolete("Deprecated since 03/18/2014 10:00:00 use '/price/vps/2013v1/cloud/option/{optionName}' instead")]
				public async Task<OvhApi.Models.Order.Price> GetPriceVpsCloudOption(OvhApi.Models.Price.Vps.Cloud.OptionEnum optionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("optionName",optionName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/cloud/option/{0}",System.Net.WebUtility.UrlEncode(optionName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud 2014
							/// <param name="modelName">Model</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2014v1CloudModel(OvhApi.Models.Price.Vps._2014v1.Cloud.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2014v1/cloud/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud Options 2014
							/// <param name="optionName">Option</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2014v1CloudOption(OvhApi.Models.Price.Vps._2014v1.Cloud.OptionEnum optionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("optionName",optionName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2014v1/cloud/option/{0}",System.Net.WebUtility.UrlEncode(optionName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Classic 2014
							/// <param name="modelName">Model</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2014v1ClassicModel(OvhApi.Models.Price.Vps._2014v1.Classic.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2014v1/classic/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Low Latency
							/// <param name="modelName">Model</param>
							/// </summary>
						[Obsolete("Deprecated since 03/18/2014 10:00:00 use '/price/vps/2013v1/lowlat/model/{modelName}' instead")]
				public async Task<OvhApi.Models.Order.Price> GetPriceVpsLowlatModel(OvhApi.Models.Price.Vps.Lowlat.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/lowlat/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Classic 2013
							/// <param name="modelName">Model</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2013v1CloudModel(OvhApi.Models.Price.Vps._2013v1.Cloud.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2013v1/cloud/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud Options 2013
							/// <param name="optionName">Option</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2013v1CloudOption(OvhApi.Models.Price.Vps._2013v1.Cloud.OptionEnum optionName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("optionName",optionName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2013v1/cloud/option/{0}",System.Net.WebUtility.UrlEncode(optionName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Low Latency 2013
							/// <param name="modelName">Model</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2013v1LowlatModel(OvhApi.Models.Price.Vps._2013v1.Lowlat.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2013v1/lowlat/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Cloud 2013
							/// <param name="modelName">Model</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceVps2013v1ClassicModel(OvhApi.Models.Price.Vps._2013v1.Classic.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/2013v1/classic/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of VPS Classic
							/// <param name="modelName">Model</param>
							/// </summary>
						[Obsolete("Deprecated since 03/18/2014 10:00:00 use '/price/vps/2013v1/classic/model/{modelName}' instead")]
				public async Task<OvhApi.Models.Order.Price> GetPriceVpsClassicModel(OvhApi.Models.Price.Vps.Classic.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/vps/classic/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get the price of IPv4 options
							/// <param name="ipRange">The range of the IPv4</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceXdslOptionsIpv4(OvhApi.Models.Price.Xdsl.Options.Ipv4Enum ipRange)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipRange",ipRange);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/xdsl/options/ipv4/{0}",System.Net.WebUtility.UrlEncode(ipRange.ToString())));
		}
				/// <summary>
		/// Get the price of Nas offers
							/// <param name="modelName">capacity in gigabit of Nas</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedNasModel(OvhApi.Models.Price.Dedicated.Nas.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicated/nas/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get the price of Nas HA offers
							/// <param name="modelName">capacity in gigabit of Nas Ha</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedNashaModel(OvhApi.Models.Price.Dedicated.Nasha.ModelEnum modelName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("modelName",modelName);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicated/nasha/model/{0}",System.Net.WebUtility.UrlEncode(modelName.ToString())));
		}
				/// <summary>
		/// Get price of available firewall models
							/// <param name="firewallModel">Model of firewall</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedServerFirewall(OvhApi.Models.Price.Dedicated.Server.FirewallEnum firewallModel)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("firewallModel",firewallModel);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicated/server/firewall/{0}",System.Net.WebUtility.UrlEncode(firewallModel.ToString())));
		}
				/// <summary>
		/// Get price of IPs
							/// <param name="routedTo">Ip</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedServerIp(OvhApi.Models.Price.Dedicated.Server.IpEnum routedTo)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("routedTo",routedTo);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicated/server/ip/{0}",System.Net.WebUtility.UrlEncode(routedTo.ToString())));
		}
				/// <summary>
		/// Get price of backup storage offer
							/// <param name="capacity">Capacity in gigabytes of backup storage offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Order.Price> GetPriceDedicatedServerBackupstorage(OvhApi.Models.Price.Dedicated.Server.BackupStorageEnum capacity)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("capacity",capacity);

			
			
			return await RawCall<OvhApi.Models.Order.Price>(HttpMethod.Get,String.Format("/price/dedicated/server/backupStorage/{0}",System.Net.WebUtility.UrlEncode(capacity.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetSmsServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/sms/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task UpdateSmsServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/sms/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Sms sent associated to the sms account
							/// <param name="receiver">Filter the value of receiver property (=)</param>
							/// <param name="differedDelivery">Filter the value of differedDelivery property (=)</param>
							/// <param name="deliveryReceipt">Filter the value of deliveryReceipt property (=)</param>
							/// <param name="ptt">Filter the value of ptt property (=)</param>
							/// <param name="sender">Filter the value of sender property (=)</param>
							/// <param name="tag">Filter the value of tag property (=)</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<long[]> GetSmsOutgoingIds(string serviceName,string tag = null,string sender = null,long? ptt = null,long? deliveryReceipt = null,long? differedDelivery = null,string receiver = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("receiver",receiver);
queryString.Add("differedDelivery",differedDelivery);
queryString.Add("deliveryReceipt",deliveryReceipt);
queryString.Add("ptt",ptt);
queryString.Add("sender",sender);
queryString.Add("tag",tag);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/outgoing{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Outgoing> GetSmsOutgoing(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Outgoing>(HttpMethod.Get,String.Format("/sms/{0}/outgoing/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms outgoing history given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsOutgoing(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/outgoing/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Hlr> GetSmsOutgoingHlr(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Hlr>(HttpMethod.Get,String.Format("/sms/{0}/outgoing/{1}/hlr",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Account> GetSms(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Sms.Account>(HttpMethod.Get,String.Format("/sms/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task UpdateSms(OvhApi.Models.Sms.Account requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/sms/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Receivers preloaded from text or csv document file
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<long[]> GetSmsReceiverIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/receivers",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a new document of csv receivers
							/// <param name="csvUrl">Slot number id used to handle the document</param>
							/// <param name="slotId">Slot number id used to handle the document</param>
							/// <param name="description">Description name of the document</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Receiver> CreateSmsReceivers(string csvUrl,long slotId,string description,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("csvUrl",csvUrl);
Ensure.IdIsValid("slotId",slotId);
Ensure.NotNullNorEmpty("description",description);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("csvUrl",csvUrl);
requestBody.Add("slotId",slotId);
requestBody.Add("description",description);

			return await RawCall<OvhApi.Models.Sms.Receiver>(HttpMethod.Post,String.Format("/sms/{0}/receivers",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Receiver> GetSmsReceivers(string serviceName,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("slotId",slotId);

			
			
			return await RawCall<OvhApi.Models.Sms.Receiver>(HttpMethod.Get,String.Format("/sms/{0}/receivers/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Delete the document from the slot
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task DeleteSmsReceivers(string serviceName,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("slotId",slotId);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/receivers/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Get the document data container
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task<string> GetSmsReceiversCsv(string serviceName,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("slotId",slotId);

			
			
			return await RawCall<string>(HttpMethod.Get,String.Format("/sms/{0}/receivers/{1}/csv",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="sender">The sms sender</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Sender> GetSmsSenders(string serviceName,string sender)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("sender",sender);

			
			
			return await RawCall<OvhApi.Models.Sms.Sender>(HttpMethod.Get,String.Format("/sms/{0}/senders/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(sender.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="sender">The sms sender</param>
							/// </summary>
						public async Task UpdateSmsSenders(OvhApi.Models.Sms.Sender requestBody,string serviceName,string sender)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("sender",sender);

			
			
			await RawCall(HttpMethod.Put,String.Format("/sms/{0}/senders/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(sender.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the sms sender given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="sender">The sms sender</param>
							/// </summary>
						public async Task DeleteSmsSenders(string serviceName,string sender)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("sender",sender);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/senders/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(sender.ToString())));
		}
				/// <summary>
		/// Validate a given sender with an activation code.
							/// <param name="code">The validation code</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="sender">The sms sender</param>
							/// </summary>
						public async Task CreateSmsSendersValidate(string code,string serviceName,string sender)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("code",code);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("sender",sender);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("code",code);

			await RawCall(HttpMethod.Post,String.Format("/sms/{0}/senders/{1}/validate",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(sender.ToString())),requestBody);
		}
				/// <summary>
		/// Senders allowed associated to the sms account
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<string[]> GetSmsSenderNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/sms/{0}/senders",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create the sms sender given
							/// <param name="sender">The sender (alpha or phone number)</param>
							/// <param name="reason">Message seen by the moderator</param>
							/// <param name="description">Sender description</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<string> CreateSmsSenders(string sender,string serviceName,string description = null,string reason = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("sender",sender);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("sender",sender);
requestBody.Add("reason",reason);
requestBody.Add("description",description);

			return await RawCall<string>(HttpMethod.Post,String.Format("/sms/{0}/senders",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Users associated to the sms account
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<string[]> GetSmsUserNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/sms/{0}/users",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new user for an sms account
							/// <param name="password">The sms password</param>
							/// <param name="login">The sms login</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task CreateSmsUsers(string password,string login,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("password",password);
Ensure.NotNullNorEmpty("login",login);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("password",password);
requestBody.Add("login",login);

			await RawCall(HttpMethod.Post,String.Format("/sms/{0}/users",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Sms sent associated to the sms user
							/// <param name="receiver">Filter the value of receiver property (=)</param>
							/// <param name="differedDelivery">Filter the value of differedDelivery property (=)</param>
							/// <param name="deliveryReceipt">Filter the value of deliveryReceipt property (=)</param>
							/// <param name="ptt">Filter the value of ptt property (=)</param>
							/// <param name="sender">Filter the value of sender property (=)</param>
							/// <param name="tag">Filter the value of tag property (=)</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<long[]> GetSmsUsersOutgoingIds(string serviceName,string login,string tag = null,string sender = null,long? ptt = null,long? deliveryReceipt = null,long? differedDelivery = null,string receiver = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			var queryString = new QueryString();
queryString.Add("receiver",receiver);
queryString.Add("differedDelivery",differedDelivery);
queryString.Add("deliveryReceipt",deliveryReceipt);
queryString.Add("ptt",ptt);
queryString.Add("sender",sender);
queryString.Add("tag",tag);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/outgoing{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Outgoing> GetSmsUsersOutgoing(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Outgoing>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/outgoing/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms outgoing history given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsUsersOutgoing(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/users/{1}/outgoing/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Hlr> GetSmsUsersOutgoingHlr(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Hlr>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/outgoing/{2}/hlr",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.User> GetSmsUsers(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			return await RawCall<OvhApi.Models.Sms.User>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task UpdateSmsUsers(OvhApi.Models.Sms.User requestBody,string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			await RawCall(HttpMethod.Put,String.Format("/sms/{0}/users/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the sms user given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task DeleteSmsUsers(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/users/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Sms in pending associated to the sms user
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<long[]> GetSmsUsersJobIds(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/jobs",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Add one or several sending jobs
							/// <param name="noStopClause">Do not display STOP clause in the message, this requires that this is not an advertising message</param>
							/// <param name="priority">The priority of the message</param>
							/// <param name="validityPeriod">The maximum time -in minute(s)- before the message is dropped</param>
							/// <param name="senderForResponse">Set the flag to send a special sms which can be reply by the receiver (smsResponse).</param>
							/// <param name="receivers">The receivers list</param>
							/// <param name="charset">The sms coding</param>
							/// <param name="coding">The sms coding</param>
							/// <param name="message">The sms message</param>
							/// <param name="differedPeriod">The time -in minute(s)- to wait before sending the message</param>
							/// <param name="receiversSlotId">The receivers document slot id</param>
							/// <param name="sender">The sender</param>
							/// <param name="tag">The identifier group tag</param>
							/// <param name="receiversDocumentUrl">The receivers document url link in csv format</param>
							/// <param name="class_">The sms class</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.SmsSendingReport> CreateSmsUsersJobs(string message,string serviceName,string login,OvhApi.Models.Sms.ClassEnum? class_ = null,string receiversDocumentUrl = null,string tag = null,string sender = null,string receiversSlotId = null,long? differedPeriod = null,OvhApi.Models.Sms.CodingEnum? coding = null,OvhApi.Models.Sms.CharsetEnum? charset = null,string[] receivers = null,bool? senderForResponse = null,long? validityPeriod = null,OvhApi.Models.Sms.PriorityEnum? priority = null,bool? noStopClause = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("message",message);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("noStopClause",noStopClause);
requestBody.Add("priority",priority);
requestBody.Add("validityPeriod",validityPeriod);
requestBody.Add("senderForResponse",senderForResponse);
requestBody.Add("receivers",receivers);
requestBody.Add("charset",charset);
requestBody.Add("coding",coding);
requestBody.Add("message",message);
requestBody.Add("differedPeriod",differedPeriod);
requestBody.Add("receiversSlotId",receiversSlotId);
requestBody.Add("sender",sender);
requestBody.Add("tag",tag);
requestBody.Add("receiversDocumentUrl",receiversDocumentUrl);
requestBody.Add("class",class_);

			return await RawCall<OvhApi.Models.Sms.SmsSendingReport>(HttpMethod.Post,String.Format("/sms/{0}/users/{1}/jobs",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Job> GetSmsUsersJobs(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Job>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/jobs/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms job given (stop sending)
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsUsersJobs(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/users/{1}/jobs/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Receivers preloaded from text or csv document file
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<long[]> GetSmsUsersReceiverIds(string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/receivers",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())));
		}
				/// <summary>
		/// Add a new document of csv receivers
							/// <param name="csvUrl">Slot number id used to handle the document</param>
							/// <param name="slotId">Slot number id used to handle the document</param>
							/// <param name="description">Description name of the document</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Receiver> CreateSmsUsersReceivers(string csvUrl,long slotId,string description,string serviceName,string login)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("csvUrl",csvUrl);
Ensure.IdIsValid("slotId",slotId);
Ensure.NotNullNorEmpty("description",description);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("csvUrl",csvUrl);
requestBody.Add("slotId",slotId);
requestBody.Add("description",description);

			return await RawCall<OvhApi.Models.Sms.Receiver>(HttpMethod.Post,String.Format("/sms/{0}/users/{1}/receivers",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Receiver> GetSmsUsersReceivers(string serviceName,string login,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("slotId",slotId);

			
			
			return await RawCall<OvhApi.Models.Sms.Receiver>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/receivers/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Delete the document from the slot
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task DeleteSmsUsersReceivers(string serviceName,string login,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("slotId",slotId);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/users/{1}/receivers/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Get the document data container
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="slotId">Slot number id</param>
							/// </summary>
						public async Task<string> GetSmsUsersReceiversCsv(string serviceName,string login,long slotId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("slotId",slotId);

			
			
			return await RawCall<string>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/receivers/{2}/csv",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(slotId.ToString())));
		}
				/// <summary>
		/// Sms received associated to the sms user
							/// <param name="sender">Filter the value of sender property (=)</param>
							/// <param name="tag">Filter the value of tag property (=)</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// </summary>
						public async Task<long[]> GetSmsUsersIncomingIds(string serviceName,string login,string tag = null,string sender = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);

			var queryString = new QueryString();
queryString.Add("sender",sender);
queryString.Add("tag",tag);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/incoming{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Incoming> GetSmsUsersIncoming(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Incoming>(HttpMethod.Get,String.Format("/sms/{0}/users/{1}/incoming/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms incoming history given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="login">The sms user login</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsUsersIncoming(string serviceName,string login,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("login",login);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/users/{1}/incoming/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(login.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Numbers blacklisted associated to the sms account
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<string[]> GetSmsBlacklistNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/sms/{0}/blacklists",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="number">The sms number blacklisted</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Blacklist> GetSmsBlacklists(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			return await RawCall<OvhApi.Models.Sms.Blacklist>(HttpMethod.Get,String.Format("/sms/{0}/blacklists/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// Delete the blacklisted sms number given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="number">The sms number blacklisted</param>
							/// </summary>
						public async Task DeleteSmsBlacklists(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/blacklists/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// Sms in pending associated to the sms account
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<long[]> GetSmsJobIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/jobs",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add one or several sending jobs
							/// <param name="noStopClause">Do not display STOP clause in the message, this requires that this is not an advertising message</param>
							/// <param name="priority">The priority of the message</param>
							/// <param name="validityPeriod">The maximum time -in minute(s)- before the message is dropped</param>
							/// <param name="senderForResponse">Set the flag to send a special sms which can be reply by the receiver (smsResponse).</param>
							/// <param name="receivers">The receivers list</param>
							/// <param name="charset">The sms coding</param>
							/// <param name="coding">The sms coding</param>
							/// <param name="message">The sms message</param>
							/// <param name="differedPeriod">The time -in minute(s)- to wait before sending the message</param>
							/// <param name="receiversSlotId">The receivers document slot id</param>
							/// <param name="sender">The sender</param>
							/// <param name="tag">The identifier group tag</param>
							/// <param name="receiversDocumentUrl">The receivers document url link in csv format</param>
							/// <param name="class_">The sms class</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.SmsSendingReport> CreateSmsJobs(string message,string serviceName,OvhApi.Models.Sms.ClassEnum? class_ = null,string receiversDocumentUrl = null,string tag = null,string sender = null,string receiversSlotId = null,long? differedPeriod = null,OvhApi.Models.Sms.CodingEnum? coding = null,OvhApi.Models.Sms.CharsetEnum? charset = null,string[] receivers = null,bool? senderForResponse = null,long? validityPeriod = null,OvhApi.Models.Sms.PriorityEnum? priority = null,bool? noStopClause = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("message",message);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("noStopClause",noStopClause);
requestBody.Add("priority",priority);
requestBody.Add("validityPeriod",validityPeriod);
requestBody.Add("senderForResponse",senderForResponse);
requestBody.Add("receivers",receivers);
requestBody.Add("charset",charset);
requestBody.Add("coding",coding);
requestBody.Add("message",message);
requestBody.Add("differedPeriod",differedPeriod);
requestBody.Add("receiversSlotId",receiversSlotId);
requestBody.Add("sender",sender);
requestBody.Add("tag",tag);
requestBody.Add("receiversDocumentUrl",receiversDocumentUrl);
requestBody.Add("class",class_);

			return await RawCall<OvhApi.Models.Sms.SmsSendingReport>(HttpMethod.Post,String.Format("/sms/{0}/jobs",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Job> GetSmsJobs(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Job>(HttpMethod.Get,String.Format("/sms/{0}/jobs/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms job given (stop sending)
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsJobs(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/jobs/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Sms received associated to the sms account
							/// <param name="sender">Filter the value of sender property (=)</param>
							/// <param name="tag">Filter the value of tag property (=)</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<long[]> GetSmsIncomingIds(string serviceName,string tag = null,string sender = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("sender",sender);
queryString.Add("tag",tag);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/sms/{0}/incoming{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.Incoming> GetSmsIncoming(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Sms.Incoming>(HttpMethod.Get,String.Format("/sms/{0}/incoming/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Delete the sms incoming history given
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteSmsIncoming(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/sms/{0}/incoming/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Describe SMS offers available.
							/// <param name="countryDestination">Filter to have the country destination</param>
							/// <param name="countryCurrencyPrice">Filter to have the currency country prices</param>
							/// <param name="quantity">Sms pack offer quantity</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Sms.PackOffer[]> GetSmsSeeoffers(OvhApi.Models.Sms.CountryEnum countryDestination,OvhApi.Models.Reference.CountryEnum countryCurrencyPrice,OvhApi.Models.Sms.PackQuantityEnum quantity,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("countryDestination",countryDestination);
Ensure.NotNull("countryCurrencyPrice",countryCurrencyPrice);
Ensure.NotNull("quantity",quantity);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("countryDestination",countryDestination);
queryString.Add("countryCurrencyPrice",countryCurrencyPrice);
queryString.Add("quantity",quantity);

			
			return await RawCall<OvhApi.Models.Sms.PackOffer[]>(HttpMethod.Get,String.Format("/sms/{0}/seeOffers{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Credit transfer between two sms accounts.
							/// <param name="credits">Amount of credits to transfer.</param>
							/// <param name="smsAccountTarget">Sms account destination.</param>
							/// <param name="serviceName">The internal name of your SMS offer</param>
							/// </summary>
						public async Task CreateSmsTransfercredits(double credits,string smsAccountTarget,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("credits",credits);
Ensure.NotNullNorEmpty("smsAccountTarget",smsAccountTarget);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("credits",credits);
requestBody.Add("smsAccountTarget",smsAccountTarget);

			await RawCall(HttpMethod.Post,String.Format("/sms/{0}/transferCredits",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetSmsNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/sms"));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetTelephonyNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetTelephonyServiceinfos(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/telephony/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task UpdateTelephonyServiceinfos(OvhApi.Models.Services.Service requestBody,string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(billingAccount.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.BillingAccount> GetTelephony(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<OvhApi.Models.Telephony.BillingAccount>(HttpMethod.Get,String.Format("/telephony/{0}",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task UpdateTelephony(OvhApi.Models.Telephony.BillingAccount requestBody,string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}",System.Net.WebUtility.UrlEncode(billingAccount.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Number> GetTelephonyNumber(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Number>(HttpMethod.Get,String.Format("/telephony/{0}/number/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyNumber(OvhApi.Models.Telephony.Number requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/number/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Change the feature type of the phone number
							/// <param name="featureType">The new feature of the number</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyNumberChangefeaturetype(OvhApi.Models.Telephony.TypeEnum featureType,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("featureType",featureType);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("featureType",featureType);

			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/number/{1}/changeFeatureType",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Additional numbers associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyNumberNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/number",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Vxml> GetTelephonyVxml(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Vxml>(HttpMethod.Get,String.Format("/telephony/{0}/vxml/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.VxmlProperties> GetTelephonyVxmlSettings(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.VxmlProperties>(HttpMethod.Get,String.Format("/telephony/{0}/vxml/{1}/settings",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyVxmlSettings(OvhApi.Models.Telephony.VxmlProperties requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/vxml/{1}/settings",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Vxml numbers associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyVxmlNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/vxml",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Abbreviated numbers for the billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<long[]> GetTelephonyAbbreviatednumberIds(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/abbreviatedNumber",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Create a new abbreviated number for the billing account
							/// <param name="destinationNumber">The destination of the abbreviated number</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "7" and must have a length of 3 or 4 digits</param>
							/// <param name="name">To be written</param>
							/// <param name="surname">To be written</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.AbbreviatedNumberGroup> CreateTelephonyAbbreviatednumber(string destinationNumber,long abbreviatedNumber,string name,string surname,string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("destinationNumber",destinationNumber);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);
Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("surname",surname);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationNumber",destinationNumber);
requestBody.Add("abbreviatedNumber",abbreviatedNumber);
requestBody.Add("name",name);
requestBody.Add("surname",surname);

			return await RawCall<OvhApi.Models.Telephony.AbbreviatedNumberGroup>(HttpMethod.Post,String.Format("/telephony/{0}/abbreviatedNumber",System.Net.WebUtility.UrlEncode(billingAccount.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "7" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.AbbreviatedNumberGroup> GetTelephonyAbbreviatednumber(string billingAccount,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			return await RawCall<OvhApi.Models.Telephony.AbbreviatedNumberGroup>(HttpMethod.Get,String.Format("/telephony/{0}/abbreviatedNumber/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "7" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task UpdateTelephonyAbbreviatednumber(OvhApi.Models.Telephony.AbbreviatedNumberGroup requestBody,string billingAccount,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/abbreviatedNumber/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the given abbreviated number
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "7" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task DeleteTelephonyAbbreviatednumber(string billingAccount,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/telephony/{0}/abbreviatedNumber/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Redirect> GetTelephonyRedirect(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Redirect>(HttpMethod.Get,String.Format("/telephony/{0}/redirect/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyRedirect(OvhApi.Models.Telephony.Redirect requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/redirect/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Change the destination of the redirect
							/// <param name="destination">The destination</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyRedirectChangedestination(string destination,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("destination",destination);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destination",destination);

			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/redirect/{1}/changeDestination",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Redirects associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyRedirectNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/redirect",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyPabx> GetTelephonyEasypabx(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.EasyPabx>(HttpMethod.Get,String.Format("/telephony/{0}/easyPabx/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyEasypabx(OvhApi.Models.Telephony.EasyPabx requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/easyPabx/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyPabxHunting> GetTelephonyEasypabxHunting(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.EasyPabxHunting>(HttpMethod.Get,String.Format("/telephony/{0}/easyPabx/{1}/hunting",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyEasypabxHunting(OvhApi.Models.Telephony.EasyPabxHunting requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/easyPabx/{1}/hunting",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Hunting agents
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<string[]> GetTelephonyEasypabxHuntingAgents(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/easyPabx/{1}/hunting/agent",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new agent
							/// <param name="agentNumber">The phone number of the agent</param>
							/// <param name="position">The position in the hunting</param>
							/// <param name="logged">True if the agent is logged</param>
							/// <param name="noReplyTimer">The maxium ringing time</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent> CreateTelephonyEasypabxHuntingAgent(string agentNumber,long position,bool logged,long noReplyTimer,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("agentNumber",agentNumber);
Ensure.IdIsValid("position",position);
Ensure.NotNull("logged",logged);
Ensure.IdIsValid("noReplyTimer",noReplyTimer);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("agentNumber",agentNumber);
requestBody.Add("position",position);
requestBody.Add("logged",logged);
requestBody.Add("noReplyTimer",noReplyTimer);

			return await RawCall<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent>(HttpMethod.Post,String.Format("/telephony/{0}/easyPabx/{1}/hunting/agent",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent> GetTelephonyEasypabxHuntingAgent(string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			return await RawCall<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent>(HttpMethod.Get,String.Format("/telephony/{0}/easyPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task UpdateTelephonyEasypabxHuntingAgent(OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent requestBody,string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/easyPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the agent
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task DeleteTelephonyEasypabxHuntingAgent(string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/telephony/{0}/easyPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())));
		}
				/// <summary>
		/// EasyPabx associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyEasypabxNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/easyPabx",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Conference> GetTelephonyConference(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Conference>(HttpMethod.Get,String.Format("/telephony/{0}/conference/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Lock the conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceUnlock(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/unlock",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Current participants of the associate conference
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyConferenceParticipantIds(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/conference/{1}/participants",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Change a participant level of audio transmission
							/// <param name="value">The value of energy level</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsEnergy(long value,string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("value",value);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("value",value);

			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/energy",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.ConferenceParticipants> GetTelephonyConferenceParticipants(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.ConferenceParticipants>(HttpMethod.Get,String.Format("/telephony/{0}/conference/{1}/participants/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Unmute a participant in your conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsUnmute(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/unmute",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Mute a participant in your conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsMute(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/mute",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Eject a participant from your conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsKick(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/kick",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Make a participant deaf in your conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsDeaf(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/deaf",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Make a participant undeaf your conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceParticipantsUndeaf(string billingAccount,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/participants/{2}/undeaf",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Lock the conference room
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyConferenceLock(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/conference/{1}/lock",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.ConferenceProperties> GetTelephonyConferenceSettings(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.ConferenceProperties>(HttpMethod.Get,String.Format("/telephony/{0}/conference/{1}/settings",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Conferences associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyConferenceNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/conference",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.MiniPabx> GetTelephonyMinipabx(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.MiniPabx>(HttpMethod.Get,String.Format("/telephony/{0}/miniPabx/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyMinipabx(OvhApi.Models.Telephony.MiniPabx requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/miniPabx/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.MiniPabxHunting> GetTelephonyMinipabxHunting(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.MiniPabxHunting>(HttpMethod.Get,String.Format("/telephony/{0}/miniPabx/{1}/hunting",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyMinipabxHunting(OvhApi.Models.Telephony.MiniPabxHunting requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/miniPabx/{1}/hunting",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Hunting agents
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<string[]> GetTelephonyMinipabxHuntingAgents(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/miniPabx/{1}/hunting/agent",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new agent
							/// <param name="agentNumber">The phone number of the agent</param>
							/// <param name="position">The position in the hunting</param>
							/// <param name="logged">True if the agent is logged</param>
							/// <param name="noReplyTimer">The maxium ringing time</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent> CreateTelephonyMinipabxHuntingAgent(string agentNumber,long position,bool logged,long noReplyTimer,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("agentNumber",agentNumber);
Ensure.IdIsValid("position",position);
Ensure.NotNull("logged",logged);
Ensure.IdIsValid("noReplyTimer",noReplyTimer);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("agentNumber",agentNumber);
requestBody.Add("position",position);
requestBody.Add("logged",logged);
requestBody.Add("noReplyTimer",noReplyTimer);

			return await RawCall<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent>(HttpMethod.Post,String.Format("/telephony/{0}/miniPabx/{1}/hunting/agent",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent> GetTelephonyMinipabxHuntingAgent(string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			return await RawCall<OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent>(HttpMethod.Get,String.Format("/telephony/{0}/miniPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task UpdateTelephonyMinipabxHuntingAgent(OvhApi.Models.Telephony.EasyMiniPabxHuntingAgent requestBody,string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/miniPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the agent
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="agentNumber">The phone number of the agent</param>
							/// </summary>
						public async Task DeleteTelephonyMinipabxHuntingAgent(string billingAccount,string serviceName,string agentNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("agentNumber",agentNumber);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/telephony/{0}/miniPabx/{1}/hunting/agent/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(agentNumber.ToString())));
		}
				/// <summary>
		/// Miniabx associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyMinipabxNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/miniPabx",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Line> GetTelephonyLine(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Line>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyLine(OvhApi.Models.Telephony.Line requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/line/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Abbreviated numbers for the line
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyLineAbbreviatednumberIds(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/abbreviatedNumber",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new abbreviated number for the line
							/// <param name="destinationNumber">The destination of the abbreviated number</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "2" and must have a length of 3 or 4 digits</param>
							/// <param name="name">To be written</param>
							/// <param name="surname">To be written</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.AbbreviatedNumber> CreateTelephonyLineAbbreviatednumber(string destinationNumber,long abbreviatedNumber,string name,string surname,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("destinationNumber",destinationNumber);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);
Ensure.NotNullNorEmpty("name",name);
Ensure.NotNullNorEmpty("surname",surname);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destinationNumber",destinationNumber);
requestBody.Add("abbreviatedNumber",abbreviatedNumber);
requestBody.Add("name",name);
requestBody.Add("surname",surname);

			return await RawCall<OvhApi.Models.Telephony.AbbreviatedNumber>(HttpMethod.Post,String.Format("/telephony/{0}/line/{1}/abbreviatedNumber",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "2" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.AbbreviatedNumber> GetTelephonyLineAbbreviatednumber(string billingAccount,string serviceName,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			return await RawCall<OvhApi.Models.Telephony.AbbreviatedNumber>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/abbreviatedNumber/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "2" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task UpdateTelephonyLineAbbreviatednumber(OvhApi.Models.Telephony.AbbreviatedNumber requestBody,string billingAccount,string serviceName,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/line/{1}/abbreviatedNumber/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())),requestBody);
		}
				/// <summary>
		/// Delete the given abbreviated number
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="abbreviatedNumber">The abbreviated number which must start with "2" and must have a length of 3 or 4 digits</param>
							/// </summary>
						public async Task DeleteTelephonyLineAbbreviatednumber(string billingAccount,string serviceName,long abbreviatedNumber)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("abbreviatedNumber",abbreviatedNumber);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/telephony/{0}/line/{1}/abbreviatedNumber/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(abbreviatedNumber.ToString())));
		}
				/// <summary>
		/// Make a phone call from the current line
							/// <param name="calledNumber">To be written</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task CreateTelephonyLineClick2call(string calledNumber,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("calledNumber",calledNumber);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("calledNumber",calledNumber);

			await RawCall(HttpMethod.Post,String.Format("/telephony/{0}/line/{1}/click2Call",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.LineOptions> GetTelephonyLineOptions(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.LineOptions>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/options",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyLineOptions(OvhApi.Models.Telephony.LineOptions requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/line/{1}/options",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// List of codecs combinaisons available for this line
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<string[]> GetTelephonyLineOptionsAvailablecodecNames(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/options/availableCodecs",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Phone> GetTelephonyLinePhone(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Phone>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/phone",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a task to reboot the phone
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyLinePhoneReboot(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/line/{1}/phone/reboot",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a task to refresh the screen of the MGCP phone
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyLinePhoneRefreshscreen(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/line/{1}/phone/refreshScreen",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Plug & Phone function keys
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyLinePhoneFunctionkeyIds(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/phone/functionKey",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="keyNum">The number of the function key</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.FunctionKey> GetTelephonyLinePhoneFunctionkey(string billingAccount,string serviceName,long keyNum)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("keyNum",keyNum);

			
			
			return await RawCall<OvhApi.Models.Telephony.FunctionKey>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/phone/functionKey/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(keyNum.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="keyNum">The number of the function key</param>
							/// </summary>
						public async Task UpdateTelephonyLinePhoneFunctionkey(OvhApi.Models.Telephony.FunctionKey requestBody,string billingAccount,string serviceName,long keyNum)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("keyNum",keyNum);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/line/{1}/phone/functionKey/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(keyNum.ToString())),requestBody);
		}
				/// <summary>
		/// List the available functions for the key
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="keyNum">The number of the function key</param>
							/// </summary>
						public async Task<string[]> GetTelephonyLinePhoneFunctionkeyAvailablefunctionNames(string billingAccount,string serviceName,long keyNum)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("keyNum",keyNum);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/line/{1}/phone/functionKey/{2}/availableFunction",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(keyNum.ToString())));
		}
				/// <summary>
		/// Lines associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyLineNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/line",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get the allowed creditThreshold for this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<double[]> GetTelephonyAllowedcreditthresholds(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<double[]>(HttpMethod.Get,String.Format("/telephony/{0}/allowedCreditThreshold",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Previous billed consumptions
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<DateTime[]> GetTelephonyHistoryconsumptions(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<DateTime[]>(HttpMethod.Get,String.Format("/telephony/{0}/historyConsumption",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="date">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.HistoryConsumption> GetTelephonyHistoryconsumption(string billingAccount,DateTime date)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNull("date",date);

			
			
			return await RawCall<OvhApi.Models.Telephony.HistoryConsumption>(HttpMethod.Get,String.Format("/telephony/{0}/historyConsumption/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(date.ToString())));
		}
				/// <summary>
		/// Previous billed consumptions in the given format
							/// <param name="extension">Document extension</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="date">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.PcsFile> GetTelephonyHistoryconsumptionDocument(OvhApi.Models.Telephony.BillDocumentExtension extension,string billingAccount,DateTime date)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("extension",extension);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNull("date",date);

			var queryString = new QueryString();
queryString.Add("extension",extension);

			
			return await RawCall<OvhApi.Models.Telephony.PcsFile>(HttpMethod.Get,String.Format("/telephony/{0}/historyConsumption/{1}/document{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(date.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.TelephonyService> GetTelephonyService(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.TelephonyService>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyService(OvhApi.Models.Telephony.TelephonyService requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/service/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Call delivery records.
							/// <param name="planType">Filter the value of planType property (=)</param>
							/// <param name="destinationType">Filter the value of destinationType property (=)</param>
							/// <param name="creationDatetime_to">Filter the value of creationDatetime property (<=)</param>
							/// <param name="creationDatetime_from">Filter the value of creationDatetime property (>=)</param>
							/// <param name="wayType">Filter the value of wayType property (=)</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyServiceVoiceconsumptionIds(string billingAccount,string serviceName,OvhApi.Models.Telephony.VoiceConsumptionWayTypeEnum? wayType = null,DateTime? creationDatetime_from = null,DateTime? creationDatetime_to = null,OvhApi.Models.Telephony.VoiceConsumptionDestinationTypeEnum? destinationType = null,OvhApi.Models.Telephony.VoiceConsumptionPlanTypeEnum? planType = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("planType",planType);
queryString.Add("destinationType",destinationType);
queryString.Add("creationDatetime.to",creationDatetime_to);
queryString.Add("creationDatetime.from",creationDatetime_from);
queryString.Add("wayType",wayType);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/voiceConsumption{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="consumptionId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.VoiceConsumption> GetTelephonyServiceVoiceconsumption(string billingAccount,string serviceName,long consumptionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("consumptionId",consumptionId);

			
			
			return await RawCall<OvhApi.Models.Telephony.VoiceConsumption>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/voiceConsumption/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(consumptionId.ToString())));
		}
				/// <summary>
		/// Operations on a telephony service
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyServiceTaskIds(string billingAccount,string serviceName,OvhApi.Models.Telephony.TaskStatusEnum? status = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/task{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> GetTelephonyServiceTask(string billingAccount,string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/task/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.DirectoryInfo> GetTelephonyServiceDirectory(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.DirectoryInfo>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/directory",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyServiceDirectory(OvhApi.Models.Telephony.DirectoryInfo requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/service/{1}/directory",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get all the way types availables
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.DirectoryWayType[]> GetTelephonyServiceDirectoryGetwaytypes(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.DirectoryWayType[]>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/directory/getWayTypes",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get directory service code from an APE code ( principal activity of the firm code )
							/// <param name="apeCode">To be written</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.DirectoryHeadingPJ[]> GetTelephonyServiceDirectoryGetdirectoryservicecodes(string apeCode,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("apeCode",apeCode);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("apeCode",apeCode);

			
			return await RawCall<OvhApi.Models.Telephony.DirectoryHeadingPJ[]>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/directory/getDirectoryServiceCode{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Fax delivery records.
							/// <param name="creationDatetime_to">Filter the value of creationDatetime property (<=)</param>
							/// <param name="creationDatetime_from">Filter the value of creationDatetime property (>=)</param>
							/// <param name="wayType">Filter the value of wayType property (=)</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<long[]> GetTelephonyServiceFaxconsumptionIds(string billingAccount,string serviceName,OvhApi.Models.Telephony.FaxConsumptionWayTypeEnum? wayType = null,DateTime? creationDatetime_from = null,DateTime? creationDatetime_to = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("creationDatetime.to",creationDatetime_to);
queryString.Add("creationDatetime.from",creationDatetime_from);
queryString.Add("wayType",wayType);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/faxConsumption{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// <param name="consumptionId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.FaxConsumption> GetTelephonyServiceFaxconsumption(string billingAccount,string serviceName,long consumptionId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("consumptionId",consumptionId);

			
			
			return await RawCall<OvhApi.Models.Telephony.FaxConsumption>(HttpMethod.Get,String.Format("/telephony/{0}/service/{1}/faxConsumption/{2}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(consumptionId.ToString())));
		}
				/// <summary>
		/// Services associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyServiceNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/service",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Ddi> GetTelephonyDdi(string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Telephony.Ddi>(HttpMethod.Get,String.Format("/telephony/{0}/ddi/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task UpdateTelephonyDdi(OvhApi.Models.Telephony.Ddi requestBody,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/telephony/{0}/ddi/{1}",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Change the destination of the DDI
							/// <param name="destination">The destination</param>
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// <param name="serviceName">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Telephony.Task> CreateTelephonyDdiChangedestination(string destination,string billingAccount,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("destination",destination);
Ensure.NotNullNorEmpty("billingAccount",billingAccount);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("destination",destination);

			return await RawCall<OvhApi.Models.Telephony.Task>(HttpMethod.Post,String.Format("/telephony/{0}/ddi/{1}/changeDestination",System.Net.WebUtility.UrlEncode(billingAccount.ToString()),System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// DDIs (direct dial-in) associated with this billing account
							/// <param name="billingAccount">The name of your billingAccount</param>
							/// </summary>
						public async Task<string[]> GetTelephonyDdiNames(string billingAccount)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("billingAccount",billingAccount);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/telephony/{0}/ddi",System.Net.WebUtility.UrlEncode(billingAccount.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Services.Service> GetVpsServiceinfos(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Services.Service>(HttpMethod.Get,String.Format("/vps/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task UpdateVpsServiceinfos(OvhApi.Models.Services.Service requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}/serviceInfos",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Return all active options for the virtual server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						[Obsolete("Deprecated since 10/23/2013 11:00:00 use '/vps/{serviceName}/option' instead")]
				public async Task<OvhApi.Models.Vps.VpsOptionEnum[]> GetVpsActiveoptions(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.VpsOptionEnum[]>(HttpMethod.Get,String.Format("/vps/{0}/activeOptions",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.VPS> GetVps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.VPS>(HttpMethod.Get,String.Format("/vps/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task UpdateVps(OvhApi.Models.Vps.VPS requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Datacenter> GetVpsDatacenter(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Datacenter>(HttpMethod.Get,String.Format("/vps/{0}/datacenter",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNS> GetVpsSecondarydnsdomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNS>(HttpMethod.Get,String.Format("/vps/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task UpdateVpsSecondarydnsdomains(OvhApi.Models.SecondaryDns.SecondaryDNS requestBody,string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())),requestBody);
		}
				/// <summary>
		/// remove this domain
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task DeleteVpsSecondarydnsdomains(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/vps/{0}/secondaryDnsDomains/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// domain name server informations
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="domain">domain on slave server</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer> GetVpsSecondarydnsdomainsDnsserver(string serviceName,string domain)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("domain",domain);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer>(HttpMethod.Get,String.Format("/vps/{0}/secondaryDnsDomains/{1}/dnsServer",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(domain.ToString())));
		}
				/// <summary>
		/// List of secondary dns domain name
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<string[]> GetVpsSecondarydnsdomainNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vps/{0}/secondaryDnsDomains",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add a domain on secondary dns
							/// <param name="domain">The domain to add</param>
							/// <param name="ip"></param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task CreateVpsSecondarydnsdomains(string domain,string serviceName,System.Net.IPAddress ip = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("domain",domain);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("domain",domain);
requestBody.Add("ip",ip);

			await RawCall(HttpMethod.Post,String.Format("/vps/{0}/secondaryDnsDomains",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Give the status of the services of the main IP
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Ip.ServiceStatus> GetVpsStatus(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Ip.ServiceStatus>(HttpMethod.Get,String.Format("/vps/{0}/status",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get the countries you can select for your IPs geolocation
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Ip.GeolocationEnum[]> GetVpsIpcountryavailables(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Ip.GeolocationEnum[]>(HttpMethod.Get,String.Format("/vps/{0}/ipCountryAvailable",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Return all models the virtual server can be upgraded to
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Model[]> GetVpsAvailableupgrades(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Model[]>(HttpMethod.Get,String.Format("/vps/{0}/availableUpgrade",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a snapshot of the Virtual Server if the snapshot option is enabled and if there is no existing snapshot
							/// <param name="description">A textual description for your snapshot</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsCreatesnapshot(string serviceName,string description = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("description",description);

			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/createSnapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Return many statistics about the virtual machine at that time
							/// <param name="type">The type of statistic to be fetched</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValue<double>> GetVpsUse(OvhApi.Models.Vps.VpsStatisticTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValue<double>>(HttpMethod.Get,String.Format("/vps/{0}/use{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Ips associated to this virtual server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetVpsIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/vps/{0}/ips",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipAddress">The effective ip address of the Ip object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Ip> GetVpsIps(string serviceName,System.Net.IPAddress ipAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipAddress",ipAddress);

			
			
			return await RawCall<OvhApi.Models.Vps.Ip>(HttpMethod.Get,String.Format("/vps/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipAddress">The effective ip address of the Ip object</param>
							/// </summary>
						public async Task UpdateVpsIps(OvhApi.Models.Vps.Ip requestBody,string serviceName,System.Net.IPAddress ipAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipAddress",ipAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Release a given Ip (Additional Ip)
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipAddress">The effective ip address of the Ip object</param>
							/// </summary>
						public async Task DeleteVpsIps(string serviceName,System.Net.IPAddress ipAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipAddress",ipAddress);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/vps/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipAddress.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Snapshot> GetVpsSnapshot(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Snapshot>(HttpMethod.Get,String.Format("/vps/{0}/snapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task UpdateVpsSnapshot(OvhApi.Models.Vps.Snapshot requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}/snapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Creates a vps.Task that will delete the Snapshot
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> DeleteVpsSnapshot(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Delete,String.Format("/vps/{0}/snapshot",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Revert the Virtual Server to this snapshot
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsSnapshotRevert(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/snapshot/revert",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of VPS options
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.VpsOptionEnum[]> GetVpsOptions(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.VpsOptionEnum[]>(HttpMethod.Get,String.Format("/vps/{0}/option",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="option">The option name</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Option> GetVpsOption(string serviceName,OvhApi.Models.Vps.VpsOptionEnum option)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("option",option);

			
			
			return await RawCall<OvhApi.Models.Vps.Option>(HttpMethod.Get,String.Format("/vps/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(option.ToString())));
		}
				/// <summary>
		/// Release a given option
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="option">The option name</param>
							/// </summary>
						public async Task DeleteVpsOption(string serviceName,OvhApi.Models.Vps.VpsOptionEnum option)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("option",option);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/vps/{0}/option/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(option.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Veeam> GetVpsVeeam(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Veeam>(HttpMethod.Get,String.Format("/vps/{0}/veeam",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Veeam restore points for the VPS
							/// <param name="creationTime">Filter the value of creationTime property (like)</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<long[]> GetVpsVeeamRestorepointIds(string serviceName,DateTime? creationTime = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("creationTime",creationTime);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/veeam/restorePoints{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Veeam.RestorePoint> GetVpsVeeamRestorepoints(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Vps.Veeam.RestorePoint>(HttpMethod.Get,String.Format("/vps/{0}/veeam/restorePoints/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Creates a VPS.Task that will restore the given restorePoint
							/// <param name="changePassword">(Full only) Change the restored VPS root password when done</param>
							/// <param name="export">(Except full) The export method for your restore - defaults to both</param>
							/// <param name="full">Replace your current VPS by the restorePoint</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsVeeamRestorepointsRestore(bool full,string serviceName,long id,OvhApi.Models.Vps.Veeam.ExportTypeEnum? export = null,bool? changePassword = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("full",full);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("changePassword",changePassword);
requestBody.Add("export",export);
requestBody.Add("full",full);

			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/veeam/restorePoints/{1}/restore",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Veeam.RestoredBackup> GetVpsVeeamRestoredbackup(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Veeam.RestoredBackup>(HttpMethod.Get,String.Format("/vps/{0}/veeam/restoredBackup",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Creates a VPS.Task that will unmount the backup
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> DeleteVpsVeeamRestoredbackup(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Delete,String.Format("/vps/{0}/veeam/restoredBackup",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Return all models for the range of the virtual server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Model[]> GetVpsModels(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Model[]>(HttpMethod.Get,String.Format("/vps/{0}/models",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Tasks associated to this virtual server
							/// <param name="type">Filter the value of type property (=)</param>
							/// <param name="state">Filter the value of state property (=)</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<long[]> GetVpsTaskIds(string serviceName,OvhApi.Models.Vps.TaskStateEnum? state = null,OvhApi.Models.Vps.TaskTypeEnum? type = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("type",type);
queryString.Add("state",state);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> GetVpsTasks(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Get,String.Format("/vps/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Reinstall the virtual server
							/// <param name="language">Distribution language. default : en</param>
							/// <param name="softwareId">Id of the vps.Software type fetched in /template/{id}/software</param>
							/// <param name="templateId">Id of the vps.Template fetched in /templates list</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsReinstall(long templateId,string serviceName,long[] softwareId = null,string language = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("templateId",templateId);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("language",language);
requestBody.Add("softwareId",softwareId);
requestBody.Add("templateId",templateId);

			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/reinstall",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Request a reboot of the machine
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsReboot(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/reboot",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Request the machine to stop
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsStop(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/stop",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Template> GetVpsDistribution(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Template>(HttpMethod.Get,String.Format("/vps/{0}/distribution",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available softwares for this template Id
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<long[]> GetVpsDistributionSoftwareIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/distribution/software",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="softwareId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Software> GetVpsDistributionSoftware(string serviceName,long softwareId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("softwareId",softwareId);

			
			
			return await RawCall<OvhApi.Models.Vps.Software>(HttpMethod.Get,String.Format("/vps/{0}/distribution/software/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(softwareId.ToString())));
		}
				/// <summary>
		/// Disks associated to this virtual server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<long[]> GetVpsDiskIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/disks",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Disk> GetVpsDisks(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Vps.Disk>(HttpMethod.Get,String.Format("/vps/{0}/disks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Return many statistics about the disk for a given period
							/// <param name="period">The period the statistics are fetched for</param>
							/// <param name="type">The type of statistic to be fetched</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Vps.VpsTimestampValue>> GetVpsDisksMonitoring(OvhApi.Models.Vps.VpsMonitoringPeriodEnum period,OvhApi.Models.Vps.Disk.StatisticTypeEnum type,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Vps.VpsTimestampValue>>(HttpMethod.Get,String.Format("/vps/{0}/disks/{1}/monitoring{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString()),queryString));
		}
				/// <summary>
		/// Return many statistics about the disk at that time
							/// <param name="type">The type of statistic to be fetched</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValue<double>> GetVpsDisksUse(OvhApi.Models.Vps.Disk.StatisticTypeEnum type,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			var queryString = new QueryString();
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValue<double>>(HttpMethod.Get,String.Format("/vps/{0}/disks/{1}/use{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString()),queryString));
		}
				/// <summary>
		/// Return many statistics about the virtual machine for a given period
							/// <param name="period">The period the statistics are fetched for</param>
							/// <param name="type">The type of statistic to be fetched</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Vps.VpsTimestampValue>> GetVpsMonitoring(OvhApi.Models.Vps.VpsMonitoringPeriodEnum period,OvhApi.Models.Vps.VpsStatisticTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Vps.VpsTimestampValue>>(HttpMethod.Get,String.Format("/vps/{0}/monitoring{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.BackupFtp> GetVpsBackupftp(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.BackupFtp>(HttpMethod.Get,String.Format("/vps/{0}/backupftp",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Change your Backup FTP password
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateVpsBackupftpPassword(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/vps/{0}/backupftp/password",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get all IP blocks that can be used in the ACL
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetVpsBackupftpAuthorizableblocks(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/vps/{0}/backupftp/authorizableBlocks",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of IP blocks (and protocols to allow on these blocks) authorized on your backup FTP
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetVpsBackupftpAccess(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/vps/{0}/backupftp/access",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Create a new Backup FTP ACL
							/// <param name="ftp">Wether to allow the FTP protocol for this ACL</param>
							/// <param name="ipBlock">The IP Block specific to this ACL. It musts belong to your server.</param>
							/// <param name="nfs">Wether to allow the NFS protocol for this ACL</param>
							/// <param name="cifs">Wether to allow the CIFS (SMB) protocol for this ACL</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> CreateVpsBackupftpAccess(OVHApi.IPAddressBlock ipBlock,bool nfs,bool cifs,string serviceName,bool? ftp = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("ipBlock",ipBlock);
Ensure.NotNull("nfs",nfs);
Ensure.NotNull("cifs",cifs);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("ftp",ftp);
requestBody.Add("ipBlock",ipBlock);
requestBody.Add("nfs",nfs);
requestBody.Add("cifs",cifs);

			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Post,String.Format("/vps/{0}/backupftp/access",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.BackupFtpAcl> GetVpsBackupftpAccess(string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.BackupFtpAcl>(HttpMethod.Get,String.Format("/vps/{0}/backupftp/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task UpdateVpsBackupftpAccess(OvhApi.Models.Dedicated.Server.BackupFtpAcl requestBody,string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vps/{0}/backupftp/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())),requestBody);
		}
				/// <summary>
		/// Revoke this ACL
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="ipBlock">The IP Block specific to this ACL</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.Task> DeleteVpsBackupftpAccess(string serviceName,OVHApi.IPAddressBlock ipBlock)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ipBlock",ipBlock);

			
			
			return await RawCall<OvhApi.Models.Dedicated.Server.Task>(HttpMethod.Delete,String.Format("/vps/{0}/backupftp/access/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ipBlock.ToString())));
		}
				/// <summary>
		/// Return the necessary informations to open a VNC connection to your VPS
							/// <param name="protocol">The console protocol you want</param>
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Vnc> CreateVpsOpenconsoleaccess(string serviceName,OvhApi.Models.Vps.VncProtocolEnum? protocol = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("protocol",protocol);

			return await RawCall<OvhApi.Models.Vps.Vnc>(HttpMethod.Post,String.Format("/vps/{0}/openConsoleAccess",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Secondary nameServer available for your Server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer> GetVpsSecondarydnsnameserveravailable(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.SecondaryDns.SecondaryDNSNameServer>(HttpMethod.Get,String.Format("/vps/{0}/secondaryDnsNameServerAvailable",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Start the process in order to set the root password of the virtual machine. Be careful, in case of Cloud model, a reboot is mandatory.
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsSetpassword(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/setPassword",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Request the machine to start
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Task> CreateVpsStart(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vps.Task>(HttpMethod.Post,String.Format("/vps/{0}/start",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Templates available for this virtual server
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// </summary>
						public async Task<long[]> GetVpsTemplateIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/templates",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Template> GetVpsTemplates(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Vps.Template>(HttpMethod.Get,String.Format("/vps/{0}/templates/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// List available softwares for this template Id
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<long[]> GetVpsTemplatesSoftwareIds(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vps/{0}/templates/{1}/software",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your VPS offer</param>
							/// <param name="id">Id of the object</param>
							/// <param name="softwareId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Vps.Software> GetVpsTemplatesSoftware(string serviceName,long id,long softwareId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);
Ensure.IdIsValid("softwareId",softwareId);

			
			
			return await RawCall<OvhApi.Models.Vps.Software>(HttpMethod.Get,String.Format("/vps/{0}/templates/{1}/software/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString()),System.Net.WebUtility.UrlEncode(softwareId.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetVpNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vps"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Vrack> GetVrack(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vrack.Vrack>(HttpMethod.Get,String.Format("/vrack/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task UpdateVrack(OvhApi.Models.Vrack.Vrack requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vrack/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// vrack (1.5) dedicated cloud 
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<string[]> GetVrackDedicatedcloudNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedCloud",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add a dedicatedCloud to this vrack (1.5)
							/// <param name="dedicatedCloud"></param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> CreateVrackDedicatedcloud(string dedicatedCloud,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("dedicatedCloud",dedicatedCloud);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("dedicatedCloud",dedicatedCloud);

			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Post,String.Format("/vrack/{0}/dedicatedCloud",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="dedicatedCloud">your dedicated cloud service</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.DedicatedCloud> GetVrackDedicatedcloud(string serviceName,string dedicatedCloud)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("dedicatedCloud",dedicatedCloud);

			
			
			return await RawCall<OvhApi.Models.Vrack.DedicatedCloud>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedCloud/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(dedicatedCloud.ToString())));
		}
				/// <summary>
		/// remove this a dedicatedCloud from this vrack (1.5)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="dedicatedCloud">your dedicated cloud service</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteVrackDedicatedcloud(string serviceName,string dedicatedCloud)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("dedicatedCloud",dedicatedCloud);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/vrack/{0}/dedicatedCloud/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(dedicatedCloud.ToString())));
		}
				/// <summary>
		/// vrack (1.5) for legacy vrack (1.0)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<string[]> GetVrackLegacyvrackNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vrack/{0}/legacyVrack",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add a legacy vrack (1.0) to this vrack (1.5)
							/// <param name="legacyVrack"></param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> CreateVrackLegacyvrack(string legacyVrack,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("legacyVrack",legacyVrack);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("legacyVrack",legacyVrack);

			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Post,String.Format("/vrack/{0}/legacyVrack",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="legacyVrack">your legacy vrack (1.0) service</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.LegacyVrack> GetVrackLegacyvrack(string serviceName,string legacyVrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("legacyVrack",legacyVrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.LegacyVrack>(HttpMethod.Get,String.Format("/vrack/{0}/legacyVrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(legacyVrack.ToString())));
		}
				/// <summary>
		/// remove this legacy vrack (1.0) from this vrack (1.5)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="legacyVrack">your legacy vrack (1.0) service</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteVrackLegacyvrack(string serviceName,string legacyVrack)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("legacyVrack",legacyVrack);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/vrack/{0}/legacyVrack/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(legacyVrack.ToString())));
		}
				/// <summary>
		/// vrack (1.5) for IP blocks
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OVHApi.IPAddressBlock[]> GetVrackIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OVHApi.IPAddressBlock[]>(HttpMethod.Get,String.Format("/vrack/{0}/ip",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add an IP block to this vrack (1.5)
							/// <param name="block">Your IP block</param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> CreateVrackIp(OVHApi.IPAddressBlock block,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("block",block);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("block",block);

			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Post,String.Format("/vrack/{0}/ip",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Zone available to announce your block
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="ip">Your IP block</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.VrackZoneEnum[]> GetVrackIpAvailablezones(string serviceName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Vrack.VrackZoneEnum[]>(HttpMethod.Get,String.Format("/vrack/{0}/ip/{1}/availableZone",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="ip">Your IP block</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Ip> GetVrackIp(string serviceName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Vrack.Ip>(HttpMethod.Get,String.Format("/vrack/{0}/ip/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// remove this IP block from this vrack (1.5)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="ip">Your IP block</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteVrackIp(string serviceName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/vrack/{0}/ip/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Announce IP to zone for vrack (1.5)
							/// <param name="zone">Zone to announce in</param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="ip">Your IP block</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> CreateVrackIpAnnounceinzone(OvhApi.Models.Vrack.VrackZoneEnum zone,string serviceName,OVHApi.IPAddressBlock ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("zone",zone);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("zone",zone);

			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Post,String.Format("/vrack/{0}/ip/{1}/announceInZone",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// vrack (1.5) tasks
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<long[]> GetVrackTaskIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/vrack/{0}/task",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="taskId">To be written</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> GetVrackTask(string serviceName,long taskId)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("taskId",taskId);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Get,String.Format("/vrack/{0}/task/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(taskId.ToString())));
		}
				/// <summary>
		/// List all services allowed in this vrack (1.5)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.AllowedServices> GetVrackAllowedservices(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Vrack.AllowedServices>(HttpMethod.Get,String.Format("/vrack/{0}/allowedServices",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// vrack (1.5) for dedicated server
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<string[]> GetVrackDedicatedserverNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// add a dedicated server to this vrack (1.5)
							/// <param name="dedicatedServer">Dedicated server to add </param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> CreateVrackDedicatedserver(string dedicatedServer,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("dedicatedServer",dedicatedServer);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("dedicatedServer",dedicatedServer);

			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Post,String.Format("/vrack/{0}/dedicatedServer",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="dedicatedServer">Dedicated Server</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.DedicatedServer> GetVrackDedicatedserver(string serviceName,string dedicatedServer)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("dedicatedServer",dedicatedServer);

			
			
			return await RawCall<OvhApi.Models.Vrack.DedicatedServer>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedServer/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(dedicatedServer.ToString())));
		}
				/// <summary>
		/// remove this server from this vrack (1.5)
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="dedicatedServer">Dedicated Server</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.Task> DeleteVrackDedicatedserver(string serviceName,string dedicatedServer)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("dedicatedServer",dedicatedServer);

			
			
			return await RawCall<OvhApi.Models.Vrack.Task>(HttpMethod.Delete,String.Format("/vrack/{0}/dedicatedServer/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(dedicatedServer.ToString())));
		}
				/// <summary>
		/// Retrieve vrack traffic graph values
							/// <param name="period">mrtg period</param>
							/// <param name="type">mrtg type</param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="dedicatedServer">Dedicated Server</param>
							/// </summary>
						public async Task<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]> GetVrackDedicatedserverMrtgs(OvhApi.Models.Dedicated.Server.MrtgPeriodEnum period,OvhApi.Models.Dedicated.Server.MrtgTypeEnum type,string serviceName,string dedicatedServer)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("dedicatedServer",dedicatedServer);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.Dedicated.Server.MrtgTimestampValue[]>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedServer/{1}/mrtg{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(dedicatedServer.ToString()),queryString));
		}
				/// <summary>
		/// vrack (1.5) dedicated connect
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// </summary>
						public async Task<string[]> GetVrackDedicatedconnectNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedConnect",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="name">A name for your dedicatedConnect link</param>
							/// </summary>
						public async Task<OvhApi.Models.Vrack.DedicatedConnect> GetVrackDedicatedconnect(string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Vrack.DedicatedConnect>(HttpMethod.Get,String.Format("/vrack/{0}/dedicatedConnect/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your vrack (1.5)</param>
							/// <param name="name">A name for your dedicatedConnect link</param>
							/// </summary>
						public async Task UpdateVrackDedicatedconnect(OvhApi.Models.Vrack.DedicatedConnect requestBody,string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			await RawCall(HttpMethod.Put,String.Format("/vrack/{0}/dedicatedConnect/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())),requestBody);
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetVrackNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/vrack"));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Access> GetXdsl(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Access>(HttpMethod.Get,String.Format("/xdsl/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task UpdateXdsl(OvhApi.Models.Xdsl.Access requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// List the radius connection logs
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.RadiusConnectionLog[]> GetXdslRadiusconnectionlogs(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.RadiusConnectionLog[]>(HttpMethod.Get,String.Format("/xdsl/{0}/radiusConnectionLogs",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Incident> GetXdslIncident(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Incident>(HttpMethod.Get,String.Format("/xdsl/{0}/incident",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get various statistics about this access
							/// <param name="period">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Xdsl.TimestampAndValue>> GetXdslStatistics(OvhApi.Models.Xdsl.StatisticsPeriodEnum period,OvhApi.Models.Xdsl.AccessStatisticsTypeEnum type,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Xdsl.TimestampAndValue>>(HttpMethod.Get,String.Format("/xdsl/{0}/statistics{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Send the PPP login informations to the e-mail of the nicAdmin
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task CreateXdslRequestppploginmail(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Post,String.Format("/xdsl/{0}/requestPPPLoginMail",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// The lines of the access
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<string[]> GetXdslLineNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/lines",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Line> GetXdslLines(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Line>(HttpMethod.Get,String.Format("/xdsl/{0}/lines/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// Get various statistics about the line
							/// <param name="period">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Xdsl.TimestampAndValue>> GetXdslLinesStatistics(OvhApi.Models.Xdsl.StatisticsPeriodEnum period,OvhApi.Models.Xdsl.LineStatisticsTypeEnum type,string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("period",period);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			var queryString = new QueryString();
queryString.Add("period",period);
queryString.Add("type",type);

			
			return await RawCall<OvhApi.Models.ComplexType.UnitAndValues<OvhApi.Models.Xdsl.TimestampAndValue>>(HttpMethod.Get,String.Format("/xdsl/{0}/lines/{1}/statistics{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DslamPort> GetXdslLinesDslamport(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			return await RawCall<OvhApi.Models.Xdsl.DslamPort>(HttpMethod.Get,String.Format("/xdsl/{0}/lines/{1}/dslamPort",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// List all availables profiles for this port
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DslamLineProfile[]> GetXdslLinesDslamportAvailableprofiles(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			return await RawCall<OvhApi.Models.Xdsl.DslamLineProfile[]>(HttpMethod.Get,String.Format("/xdsl/{0}/lines/{1}/dslamPort/availableProfiles",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// Reset the port on the DSLAM
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslLinesDslamportReset(string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/lines/{1}/dslamPort/reset",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())));
		}
				/// <summary>
		/// Change the profile of the port
							/// <param name="dslamProfileId">The id of the xdsl.DslamLineProfile</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslLinesDslamportChangeprofile(long dslamProfileId,string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("dslamProfileId",dslamProfileId);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("dslamProfileId",dslamProfileId);

			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/lines/{1}/dslamPort/changeProfile",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString())),requestBody);
		}
				/// <summary>
		/// Get the logs emitted by the DSLAM for this port
							/// <param name="limit">To be written</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="number">The number of the line</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DslamPortLog[]> GetXdslLinesDslamportLogs(long limit,string serviceName,string number)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.IdIsValid("limit",limit);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("number",number);

			var queryString = new QueryString();
queryString.Add("limit",limit);

			
			return await RawCall<OvhApi.Models.Xdsl.DslamPortLog[]>(HttpMethod.Get,String.Format("/xdsl/{0}/lines/{1}/dslamPort/logs{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(number.ToString()),queryString));
		}
				/// <summary>
		/// Switch this access to total deconsolidation
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslRequesttotaldeconsolidation(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/requestTotalDeconsolidation",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Modem> GetXdslModem(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Modem>(HttpMethod.Get,String.Format("/xdsl/{0}/modem",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task UpdateXdslModem(OvhApi.Models.Xdsl.Modem requestBody,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Reboot the modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslModemReboot(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/modem/reboot",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of PortMappings on this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<string[]> GetXdslModemPortmappingNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/portMappings",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a port mapping
							/// <param name="protocol">Protocol of the port mapping (TCP / UDP)</param>
							/// <param name="internalClient">The IP address of the destination of the packets</param>
							/// <param name="internalPort">The port on the Internal Client that will get the connections</param>
							/// <param name="name">Name of the port mapping entry</param>
							/// <param name="description">Description of the Port Mapping</param>
							/// <param name="externalPortStart">External Port that the modem will listen on</param>
							/// <param name="externalPortEnd">The last port of the interval on the External Client that will get the connections</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.PortMapping> CreateXdslModemPortmappings(OvhApi.Models.Xdsl.XdslModemConfig.ProtocolTypeEnum protocol,System.Net.IPAddress internalClient,long internalPort,string name,long externalPortStart,string serviceName,long? externalPortEnd = null,string description = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("protocol",protocol);
Ensure.NotNull("internalClient",internalClient);
Ensure.IdIsValid("internalPort",internalPort);
Ensure.NotNullNorEmpty("name",name);
Ensure.IdIsValid("externalPortStart",externalPortStart);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("protocol",protocol);
requestBody.Add("internalClient",internalClient);
requestBody.Add("internalPort",internalPort);
requestBody.Add("name",name);
requestBody.Add("description",description);
requestBody.Add("externalPortStart",externalPortStart);
requestBody.Add("externalPortEnd",externalPortEnd);

			return await RawCall<OvhApi.Models.Xdsl.PortMapping>(HttpMethod.Post,String.Format("/xdsl/{0}/modem/portMappings",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="name">Name of the port mapping entry</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.PortMapping> GetXdslModemPortmappings(string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Xdsl.PortMapping>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/portMappings/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="name">Name of the port mapping entry</param>
							/// </summary>
						public async Task UpdateXdslModemPortmappings(OvhApi.Models.Xdsl.PortMapping requestBody,string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem/portMappings/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this port mapping
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="name">Name of the port mapping entry</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> DeleteXdslModemPortmappings(string serviceName,string name)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("name",name);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Delete,String.Format("/xdsl/{0}/modem/portMappings/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(name.ToString())));
		}
				/// <summary>
		/// List of devices connected on this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<string[]> GetXdslModemConnecteddeviceNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/connectedDevices",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="macAddress">MAC address of the device</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.ConnectedDevice> GetXdslModemConnecteddevices(string serviceName,string macAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("macAddress",macAddress);

			
			
			return await RawCall<OvhApi.Models.Xdsl.ConnectedDevice>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/connectedDevices/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(macAddress.ToString())));
		}
				/// <summary>
		/// Reset the modem to its default configuration
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslModemReset(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/modem/reset",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of WLANs on this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<string[]> GetXdslModemWifiNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/wifi",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="wifiName">Name of the Wifi</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.WLAN> GetXdslModemWifi(string serviceName,string wifiName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("wifiName",wifiName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.WLAN>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/wifi/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(wifiName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="wifiName">Name of the Wifi</param>
							/// </summary>
						public async Task UpdateXdslModemWifi(OvhApi.Models.Xdsl.WLAN requestBody,string serviceName,string wifiName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("wifiName",wifiName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem/wifi/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(wifiName.ToString())),requestBody);
		}
				/// <summary>
		/// Refresh the list of connected devices on the modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslModemRefreshconnecteddevices(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/modem/refreshConnectedDevices",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of LANs on this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<string[]> GetXdslModemLanNames(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.LAN> GetXdslModemLan(string serviceName,string lanName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.LAN>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// </summary>
						public async Task UpdateXdslModemLan(OvhApi.Models.Xdsl.LAN requestBody,string serviceName,string lanName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem/lan/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString())),requestBody);
		}
				/// <summary>
		/// List of DHCP on this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// </summary>
						public async Task<string[]> GetXdslModemLanDhcpNames(string serviceName,string lanName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DHCP> GetXdslModemLanDhcp(string serviceName,string lanName,string dhcpName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.DHCP>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// </summary>
						public async Task UpdateXdslModemLanDhcp(OvhApi.Models.Xdsl.DHCP requestBody,string serviceName,string lanName,string dhcpName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString())),requestBody);
		}
				/// <summary>
		/// List of DHCP Static Address of this modem
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// </summary>
						public async Task<string[]> GetXdslModemLanDhcpDhcpstaticaddresseNames(string serviceName,string lanName,string dhcpName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);

			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}/DHCPStaticAddresses",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString())));
		}
				/// <summary>
		/// Add a DHCP static lease
							/// <param name="MACAddress">The MAC address of the device</param>
							/// <param name="IPAddress">The IP address of the device</param>
							/// <param name="name">Name of the DHCP static lease</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DHCPStaticAddress> CreateXdslModemLanDhcpDhcpstaticaddresses(string MACAddress,System.Net.IPAddress IPAddress,string serviceName,string lanName,string dhcpName,string name = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("MACAddress",MACAddress);
Ensure.NotNull("IPAddress",IPAddress);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("MACAddress",MACAddress);
requestBody.Add("IPAddress",IPAddress);
requestBody.Add("name",name);

			return await RawCall<OvhApi.Models.Xdsl.DHCPStaticAddress>(HttpMethod.Post,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}/DHCPStaticAddresses",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// <param name="MACAddress">The MAC address of the device</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.DHCPStaticAddress> GetXdslModemLanDhcpDhcpstaticaddresses(string serviceName,string lanName,string dhcpName,string MACAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);
Ensure.NotNullNorEmpty("MACAddress",MACAddress);

			
			
			return await RawCall<OvhApi.Models.Xdsl.DHCPStaticAddress>(HttpMethod.Get,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}/DHCPStaticAddresses/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString()),System.Net.WebUtility.UrlEncode(MACAddress.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// <param name="MACAddress">The MAC address of the device</param>
							/// </summary>
						public async Task UpdateXdslModemLanDhcpDhcpstaticaddresses(OvhApi.Models.Xdsl.DHCPStaticAddress requestBody,string serviceName,string lanName,string dhcpName,string MACAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);
Ensure.NotNullNorEmpty("MACAddress",MACAddress);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}/DHCPStaticAddresses/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString()),System.Net.WebUtility.UrlEncode(MACAddress.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this port mapping
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="lanName">Name of the LAN</param>
							/// <param name="dhcpName">Name of the DHCP</param>
							/// <param name="MACAddress">The MAC address of the device</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> DeleteXdslModemLanDhcpDhcpstaticaddresses(string serviceName,string lanName,string dhcpName,string MACAddress)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNullNorEmpty("lanName",lanName);
Ensure.NotNullNorEmpty("dhcpName",dhcpName);
Ensure.NotNullNorEmpty("MACAddress",MACAddress);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Delete,String.Format("/xdsl/{0}/modem/lan/{1}/dhcp/{2}/DHCPStaticAddresses/{3}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(lanName.ToString()),System.Net.WebUtility.UrlEncode(dhcpName.ToString()),System.Net.WebUtility.UrlEncode(MACAddress.ToString())));
		}
				/// <summary>
		/// List available LNS for this access
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Lns[]> GetXdslAvailablelns(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Lns[]>(HttpMethod.Get,String.Format("/xdsl/{0}/availableLns",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List of IPs addresses for this access
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<System.Net.IPAddress[]> GetXdslIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<System.Net.IPAddress[]>(HttpMethod.Get,String.Format("/xdsl/{0}/ips",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Order an extra /29 range of IPv4 addresses
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslIps(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/ips",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.IP> GetXdslIps(string serviceName,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<OvhApi.Models.Xdsl.IP>(HttpMethod.Get,String.Format("/xdsl/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task UpdateXdslIps(OvhApi.Models.Xdsl.IP requestBody,string serviceName,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Stop renewing this extra IPv4 option
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// </summary>
						public async Task DeleteXdslIps(string serviceName,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/xdsl/{0}/ips/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// [DEPRECATED] use /xdsl/{serviceName}/monitoringNotifications instead
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<long[]> GetXdslIpsMonitoringnotificationIds(string serviceName,System.Net.IPAddress ip)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/xdsl/{0}/ips/{1}/monitoringNotifications",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())));
		}
				/// <summary>
		/// Add a notification
							/// <param name="smsAccount">The SMS account which will be debited for each sent SMS, if the type is sms</param>
							/// <param name="email">The e-mail address, if type is mail</param>
							/// <param name="frequency">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="phone">The phone number, if type is sms</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Xdsl.MonitoringNotification> CreateXdslIpsMonitoringnotifications(OvhApi.Models.Xdsl.MonitoringNotifications.FrequencyEnum frequency,OvhApi.Models.Xdsl.MonitoringNotifications.TypeEnum type,string serviceName,System.Net.IPAddress ip,string phone = null,string email = null,string smsAccount = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("frequency",frequency);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("smsAccount",smsAccount);
requestBody.Add("email",email);
requestBody.Add("frequency",frequency);
requestBody.Add("type",type);
requestBody.Add("phone",phone);

			return await RawCall<OvhApi.Models.Xdsl.MonitoringNotification>(HttpMethod.Post,String.Format("/xdsl/{0}/ips/{1}/monitoringNotifications",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task<OvhApi.Models.Xdsl.MonitoringNotification> GetXdslIpsMonitoringnotifications(string serviceName,System.Net.IPAddress ip,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Xdsl.MonitoringNotification>(HttpMethod.Get,String.Format("/xdsl/{0}/ips/{1}/monitoringNotifications/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task UpdateXdslIpsMonitoringnotifications(OvhApi.Models.Xdsl.MonitoringNotification requestBody,string serviceName,System.Net.IPAddress ip,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/ips/{1}/monitoringNotifications/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this notification
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="ip">The IP address</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						[Obsolete("Deprecated since 01/01/0001 00:00:00")]
				public async Task DeleteXdslIpsMonitoringnotifications(string serviceName,System.Net.IPAddress ip,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.NotNull("ip",ip);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/xdsl/{0}/ips/{1}/monitoringNotifications/{2}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(ip.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Tasks scheduled for this access
							/// <param name="function">Filter the value of function property (=)</param>
							/// <param name="status">Filter the value of status property (=)</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<long[]> GetXdslTaskIds(string serviceName,OvhApi.Models.Xdsl.TaskStatusEnum? status = null,string function = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			var queryString = new QueryString();
queryString.Add("function",function);
queryString.Add("status",status);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/xdsl/{0}/tasks{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> GetXdslTasks(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Get,String.Format("/xdsl/{0}/tasks/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Change the status of the IPv6 for this access
							/// <param name="enabled">Should the IPv6 be enabled ?</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslIpv6(bool enabled,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("enabled",enabled);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("enabled",enabled);

			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/ipv6",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Change the LNS of the access
							/// <param name="lnsName">The name from xdsl.Lns</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslChangelns(string lnsName,string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("lnsName",lnsName);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("lnsName",lnsName);

			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/changeLns",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.PendingAction> GetXdslPendingaction(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.PendingAction>(HttpMethod.Get,String.Format("/xdsl/{0}/pendingAction",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List the notifications for this access
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<long[]> GetXdslMonitoringnotificationIds(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/xdsl/{0}/monitoringNotifications",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Add a notification
							/// <param name="smsAccount">The SMS account which will be debited for each sent SMS, if the type is sms</param>
							/// <param name="email">The e-mail address, if type is mail</param>
							/// <param name="frequency">To be written</param>
							/// <param name="type">To be written</param>
							/// <param name="phone">The phone number, if type is sms</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.MonitoringNotification> CreateXdslMonitoringnotifications(OvhApi.Models.Xdsl.MonitoringNotifications.FrequencyEnum frequency,OvhApi.Models.Xdsl.MonitoringNotifications.TypeEnum type,string serviceName,string phone = null,string email = null,string smsAccount = null)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("frequency",frequency);
Ensure.NotNull("type",type);
Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			var requestBody = new Dictionary<string, object>();
requestBody.Add("smsAccount",smsAccount);
requestBody.Add("email",email);
requestBody.Add("frequency",frequency);
requestBody.Add("type",type);
requestBody.Add("phone",phone);

			return await RawCall<OvhApi.Models.Xdsl.MonitoringNotification>(HttpMethod.Post,String.Format("/xdsl/{0}/monitoringNotifications",System.Net.WebUtility.UrlEncode(serviceName.ToString())),requestBody);
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.MonitoringNotification> GetXdslMonitoringnotifications(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Xdsl.MonitoringNotification>(HttpMethod.Get,String.Format("/xdsl/{0}/monitoringNotifications/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Alter this object properties
							/// <param name="requestBody">New object properties</param>
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task UpdateXdslMonitoringnotifications(OvhApi.Models.Xdsl.MonitoringNotification requestBody,string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNull("requestBody",requestBody);
Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Put,String.Format("/xdsl/{0}/monitoringNotifications/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())),requestBody);
		}
				/// <summary>
		/// Delete this notification
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// <param name="id">Id of the object</param>
							/// </summary>
						public async Task DeleteXdslMonitoringnotifications(string serviceName,long id)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);
Ensure.IdIsValid("id",id);

			
			
			await RawCall(HttpMethod.Delete,String.Format("/xdsl/{0}/monitoringNotifications/{1}",System.Net.WebUtility.UrlEncode(serviceName.ToString()),System.Net.WebUtility.UrlEncode(id.ToString())));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.AccessDiagnostic> GetXdslDiagnostic(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.AccessDiagnostic>(HttpMethod.Get,String.Format("/xdsl/{0}/diagnostic",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// Run diagnostic on the access
							/// <param name="serviceName">The internal name of your XDSL offer</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Task> CreateXdslDiagnostic(string serviceName)
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					Ensure.NotNullNorEmpty("serviceName",serviceName);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Task>(HttpMethod.Post,String.Format("/xdsl/{0}/diagnostic",System.Net.WebUtility.UrlEncode(serviceName.ToString())));
		}
				/// <summary>
		/// List available services
							/// </summary>
						public async Task<string[]> GetXdslNames()
		{
					if(ConsumerKey == null)
				throw new OvhException("This request must be authenticated");
					
			
			
			return await RawCall<string[]>(HttpMethod.Get,String.Format("/xdsl"));
		}
				/// <summary>
		/// List of incidents
							/// <param name="creationDate">Filter the value of creationDate property (>)</param>
							/// <param name="endDate">Filter the value of endDate property (<)</param>
							/// </summary>
						public async Task<long[]> GetXdslIncidentIds(DateTime? endDate = null,DateTime? creationDate = null)
		{
					
			var queryString = new QueryString();
queryString.Add("creationDate",creationDate);
queryString.Add("endDate",endDate);

			
			return await RawCall<long[]>(HttpMethod.Get,String.Format("/xdsl/incidents{0}",queryString));
		}
				/// <summary>
		/// Get this object properties
							/// <param name="id">ID of the incident</param>
							/// </summary>
						public async Task<OvhApi.Models.Xdsl.Incident> GetXdslIncidents(long id)
		{
					Ensure.IdIsValid("id",id);

			
			
			return await RawCall<OvhApi.Models.Xdsl.Incident>(HttpMethod.Get,String.Format("/xdsl/incidents/{0}",System.Net.WebUtility.UrlEncode(id.ToString())));
		}
			}
}