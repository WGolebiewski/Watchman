﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Watchman.Cqrs;
using Watchman.Discord;
using Watchman.DomainModel;
using Watchman.DomainModel.Settings;
using Watchman.Web.Areas.Administration.Models;

namespace Watchman.Web.Areas.Administration.Controllers
{
    public class ConfigurationController : BaseApiController
    {
        private readonly IQueryBus _queryBus;

        public ConfigurationController(IQueryBus queryBus)
        {
            _queryBus = queryBus;
        }

        [HttpGet]
        public async Task<IEnumerable<ConfigurationItemDto>> GetConfiguration(ulong serverId = 0)
        {
            var query = new GetConfigurationQuery(serverId);
            var responseResult = await _queryBus.ExecuteAsync(query);
            return responseResult.ConfigurationItems.Select(x => new ConfigurationItemDto(x));
        }
    }
}