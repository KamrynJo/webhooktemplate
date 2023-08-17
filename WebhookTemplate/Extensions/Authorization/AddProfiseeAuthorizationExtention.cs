//==============================================================================
// Copyright (c) Profisee Corporation. All Rights Reserved.
//==============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Profisee.WebhookTemplate.WebApp.Services;

namespace Profisee.WebhookTemplate.WebApp.Extensions.Authentication
{
    internal static class AddProfiseeAuthorizationExtension
    {
        public static IServiceCollection AddProfiseeAuthorization(this IServiceCollection services)
        {
            services
                .Replace(ServiceDescriptor.Transient<IAuthorizationService, ProfiseeAuthorizationService>());

            return services;
        }
    }
}