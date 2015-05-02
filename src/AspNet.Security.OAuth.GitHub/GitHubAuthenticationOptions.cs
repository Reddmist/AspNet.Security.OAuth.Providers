﻿using Microsoft.AspNet.Authentication.OAuth;
using Microsoft.AspNet.Http;

namespace AspNet.Security.OAuth.GitHub {
    /// <summary>
    /// Defines a set of options used by <see cref="GitHubAuthenticationHandler"/>.
    /// </summary>
    public class GitHubAuthenticationOptions : OAuthAuthenticationOptions<GitHubAuthenticationNotifications> {
        public GitHubAuthenticationOptions() {
            AuthenticationScheme = GitHubAuthenticationDefaults.AuthenticationScheme;
            Caption = GitHubAuthenticationDefaults.Caption;
            ClaimsIssuer = GitHubAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(GitHubAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = GitHubAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = GitHubAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = GitHubAuthenticationDefaults.UserInformationEndpoint;

            Notifications = new GitHubAuthenticationNotifications();
        }
    }
}
