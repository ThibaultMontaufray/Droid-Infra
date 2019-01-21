﻿using CodeBucket.Client;
using JsonFx.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Bitbucket.Controler
{
    public class RepoClient
    {
        private readonly BitbucketClient _client;

        public RepoClient(BitbucketClient client)
        {
            _client = client;
        }

        public Task<List<Repository>> GetWatched()
        {
            var uri = $"{BitbucketClient.ApiUrl}/user/follows";
            return _client.Get<List<Repository>>(uri);
        }

        public Task<Collection<Repository>> GetAll(string role = null)
        {
            var sb = new StringBuilder();
            sb.Append($"{BitbucketClient.ApiUrl2}/repositories");
            if (role != null)
                sb.Append($"?role={role}");
            return _client.Get<Collection<Repository>>(sb.ToString());
        }

        public Task<Collection<Repository>> GetAllForUser(string username, string role = null)
        {
            var sb = new StringBuilder();
            sb.Append($"{BitbucketClient.ApiUrl2}/repositories/{Uri.EscapeDataString(username)}");
            if (role != null)
                sb.Append($"?role={role}");
            return _client.Get<Collection<Repository>>(sb.ToString());
        }

        public IEnumerable<CodeBucket.Client.V1.GitReference> GetBranches(string username, string repository)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            var ret = _client.Get<Dictionary<string, CodeBucket.Client.V1.GitReference>>($"{uri}/branches");
            foreach (var r in ret.Result)
                r.Value.Name = r.Key;
            return ret.Result.Values;
        }

        public Task<RepositorySearch> Search(string name)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories";
            return _client.Get<RepositorySearch>($"{uri}/?name={name}");
        }

        public Task<Repository> Get(string username, string repository)
        {
            var uri = $"{BitbucketClient.ApiUrl2}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            return _client.Get<Repository>(uri);
        }

        public Task<CodeBucket.Client.V1.Repository> Fork(string username, string repository, string name = null)
        {
            name = name ?? repository;
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}/fork";
            return _client.PostForm<CodeBucket.Client.V1.Repository>(uri, new Dictionary<string, string> { { "name", name } });
        }

        public Task<CodeBucket.Client.V1.Followers> GetFollowers(string username, string repository)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            return _client.Get<CodeBucket.Client.V1.Followers>($"{uri}/followers");
        }

        public async Task<IEnumerable<CodeBucket.Client.V1.GitReference>> GetTags(string username, string repository)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            var ret = await _client.Get<Dictionary<string, CodeBucket.Client.V1.GitReference>>($"{uri}/tags");
            foreach (var r in ret)
                r.Value.Name = r.Key;
            return ret.Values;
        }

        public Task<CodeBucket.Client.V1.EventCollection> GetEvents(string username, string repository, int start = 0, int limit = 25)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            return _client.Get<CodeBucket.Client.V1.EventCollection>($"{uri}/events/?start={start}&limit={limit}");
        }

        public Task<Repository> Fork(string username, string repository, string name, string description = null, string language = null, bool? isPrivate = null)
        {
            var data = new Dictionary<string, string>();
            data.Add("name", name);
            if (description != null)
                data.Add("description", description);
            if (language != null)
                data.Add("language", language);
            if (isPrivate != null)
                data.Add("is_private", isPrivate.Value.ToString());

            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            return _client.Post<Repository>($"{uri}/fork", data);
        }

        public Task<RepositoryFollowModel> ToggleFollow(string username, string repository)
        {
            var uri = $"https://bitbucket.org/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}/follow";
            return _client.Post<RepositoryFollowModel>(uri, null);
        }

        public Task<PrimaryBranchModel> GetPrimaryBranch(string username, string repository)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}";
            return _client.Get<PrimaryBranchModel>($"{uri}/main-branch");
        }

        public Task<CodeBucket.Client.V1.FileModel> GetFile(string username, string repository, string branch, string file)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}"
                + $"/src/{Uri.EscapeUriString(branch)}/{file.TrimStart('/')}";
            return _client.Get<CodeBucket.Client.V1.FileModel>(uri);
        }

        public Task<CodeBucket.Client.V1.SourceDirectory> GetSourceDirectory(string username, string repository, string branch, string path = null)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}"
                + $"/src/{Uri.EscapeUriString(branch)}/{path?.TrimStart('/')}";
            return _client.Get<CodeBucket.Client.V1.SourceDirectory>(uri);
        }

        public Task<CodeBucket.Client.V1.Wiki> GetWiki(string username, string repository, string slug)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}/wiki/{Uri.EscapeDataString(slug)}";
            return _client.Get<CodeBucket.Client.V1.Wiki>(uri);
        }

        public Task<Collection<User>> GetWatchers(string username, string repository)
        {
            return _client.Get<Collection<User>>($"{BitbucketClient.ApiUrl2}/repositories/" +
                                                 $"{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}/watchers");
        }

        public Task<Collection<Repository>> GetForks(string username, string repository)
        {
            return _client.Get<Collection<Repository>>($"{BitbucketClient.ApiUrl2}/repositories/" +
                                                       $"{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}/forks");
        }

        public async Task<string> GetRawFile(string username, string repository, string branch, string path)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}"
                + $"/raw/{Uri.EscapeUriString(branch)}/{path?.TrimStart('/')}";
            var response = await _client.GetRaw(uri);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task GetRawFile(string username, string repository, string branch, string path, Stream output)
        {
            var uri = $"{BitbucketClient.ApiUrl}/repositories/{Uri.EscapeDataString(username)}/{Uri.EscapeDataString(repository)}"
                + $"/raw/{Uri.EscapeUriString(branch)}/{path?.TrimStart('/')}";
            var response = await _client.GetRaw(uri);
            await response.Content.CopyToAsync(output);
        }
    }
}
