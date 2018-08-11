using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TorrentBox.Api.Models;
using TorrentBox.Api.Rss.Models;

namespace TorrentBox.Api.Rss
{
    internal static class RssItemResolver
    {
        internal static IEnumerable<ResolvedRssItem> ResolveRssItems(JobConfiguration jobConfig, IEnumerable<RssItem> rssItems)
        {
            var resolvedMatches = new List<ResolvedRssItem>();
            var jobRules = jobConfig.Rules.OrderBy(x => x.Priority).ToList();

            foreach (var item in rssItems)
            {
                var resolvedMatch = new ResolvedRssItem()
                {
                    Title = item.Title,
                    Description = item.Description,
                    Link = item.Link
                };
                foreach (var rule in jobRules)
                {
                    try
                    {
                        Regex regex = new Regex(rule.Regex);
                        var match = regex.Match(item.Title);
                        if (match.Success)
                        {
                            resolvedMatch.DownloadPath = CreateDownloadPath(jobConfig, rule, match);
                        }
                    }
                    catch (ArgumentException)
                    {

                    }
                }
                if (String.IsNullOrEmpty(resolvedMatch.DownloadPath))
                {
                    resolvedMatch.DownloadPath = jobConfig.DownloadPath;
                }

                if (resolvedMatch.DownloadPath.Last() != '/')
                {
                    resolvedMatch.DownloadPath += "/";
                }
                resolvedMatches.Add(resolvedMatch);
            }
            return resolvedMatches;
        }

        private static string CreateDownloadPath(JobConfiguration jobConfig, RuleConfiguration rule, Match match)
        {
            var path = rule.Path;

            for (var i = 1; i < match.Groups.Count; i++)
            {
                path = path.Replace("{" + match.Groups[i].Name + "}", match.Groups[i].Value);
            }

            return $"{jobConfig.DownloadPath}{path}";
        }
    }
}
