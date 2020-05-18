﻿using Devscord.DiscordFramework.Framework.Commands.Parsing.Models;
using Serilog;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Devscord.DiscordFramework.Framework.Commands.Services
{
    public class BotCommandsParsingService
    {
        private readonly BotCommandsPropertyConversionService botCommandPropertyConversionService;

        public BotCommandsParsingService(BotCommandsPropertyConversionService botCommandPropertyConversionService)
        {
            this.botCommandPropertyConversionService = botCommandPropertyConversionService;
        }

        public IBotCommand ParseRequestToCommand(Type commandType, DiscordRequest request, BotCommandTemplate template)
        {
            var instance = Activator.CreateInstance(commandType);
            foreach (var property in commandType.GetProperties())
            {
                var value = request.Arguments.First(x => x.Name.ToLowerInvariant() == property.Name.ToLowerInvariant()).Value;
                var propertyType = template.Properties.First(x => x.Name == property.Name).Type;
                var convertedType = botCommandPropertyConversionService.ConvertType(value, propertyType);
                property.SetValue(instance, convertedType);
            }
            return (IBotCommand)instance;
        }

        public IBotCommand ParseCustomTemplate(Type commandType, BotCommandTemplate template, Regex customTemplate, string input)
        {
            var match = customTemplate.Match(input);
            if(!match.Success 
                || match.Groups.Count < template.Properties.Where(x => !x.IsOptional).Count()
                || template.Properties.Where(x => !x.IsOptional).Any(x => !match.Groups.ContainsKey(x.Name)))
            {
                Log.Warning("Custom template {customTemplate} is not valid for {commandName}", customTemplate, template.CommandName);
                return null;
            }
            var instance = Activator.CreateInstance(commandType);
        }
    }
}
