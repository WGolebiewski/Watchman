﻿using Statsman.Core.TimeSplitting.Models;
using Statsman.Core.TimeSplitting.Services;
using Statsman.Models;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Watchman.Common.Models;
using Watchman.Cqrs;
using Watchman.DomainModel.Messages;
using Watchman.DomainModel.Messages.Queries;
using Watchman.Integrations.Quickchart;

namespace Statsman.Core.TimeSplitting
{
    public partial class PeriodStatisticsService
    {
        private readonly IQueryBus queryBus;
        private readonly ChartsService _chartsService;
        private readonly StatisticsGroupingService _statisticsGroupingService;

        public PeriodStatisticsService(IQueryBus queryBus, ChartsService chartsService, StatisticsGroupingService statisticsGroupingService)
        {
            this.queryBus = queryBus;
            this._chartsService = chartsService;
            this._statisticsGroupingService = statisticsGroupingService;
        }

        public Task<(Stream Chart, ResultMessage Message)> PerMinute(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Minute, DateTime.UtcNow);
        }

        public Task<(Stream Chart, ResultMessage Message)> PerHour(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Minute, DateTime.UtcNow);
        }

        public Task<(Stream Chart, ResultMessage Message)> PerDay(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Day, DateTime.Today);
        }

        public Task<(Stream Chart, ResultMessage Message)> PerWeek(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Week, DateTime.Today);
        }

        public Task<(Stream Chart, ResultMessage Message)> PerMonth(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Month, DateTime.Today);
        }

        public Task<(Stream Chart, ResultMessage Message)> PerQuarter(StatisticsRequest request)
        {
            return this.GetResult(request, DetailedPeriod.Quarter, DateTime.Today);
        }

        private async Task<(Stream Chart, ResultMessage Message)> GetResult(StatisticsRequest request, DetailedPeriod period, DateTime startTimeRangeTimeOfDay)
        {
            var timeRange = TimeRange.ToNow(startTimeRangeTimeOfDay.Add(request.TimeBehind));
            var statistics = await this._statisticsGroupingService.GetStatisticsGroupedPerDetailedPeriod(request, timeRange, period);
            return (Chart: await this._chartsService.GetImageStatisticsPerPeriod(statistics, $"Messages per {Enum.GetName(typeof(DetailedPeriod), period).ToLower()}"),
                Message: this.GetMessage(request.UserId, request.ChannelId, period, timeRange));
        }

        private ResultMessage GetMessage(ulong userId, ulong channelId, DetailedPeriod period, TimeRange timeRange)
        {
            return new ResultMessage($"Statistics",
                $"{Enum.GetName(typeof(DetailedPeriod), period)}",
                userId == 0 ? "All users" : $"User <@{userId}>",
                channelId == 0 ? "All channels" : $"Channel <#{channelId}>",
                $"{timeRange}");
        }
    }
}
