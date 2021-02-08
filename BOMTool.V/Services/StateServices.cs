using Fluxor;
using Microsoft.Extensions.Logging;
using BOMTool.V.Store.Features.Locations.Actions.LoadLocations;
using BOMTool.V.Store.Features.PartNums.Actions;
using BOMTool.M;
using BOMTool.V.Store.Features.Locations.Actions.SaveLocation;
using System;
using BOMTool.M.DTOs;
using System.Collections.Generic;

namespace BOMTool.V.Services
{
    public class StateServices
    {
        private readonly ILogger<StateServices> _logger;
        private readonly IDispatcher _dispacher;

        public StateServices(ILogger<StateServices> logger, IDispatcher dispactcher) =>
            (_logger, _dispacher) = (logger, dispactcher);

        public void LoadLocations()
        {
            _logger.LogInformation("Issuing action to load Locations...");
            _dispacher.Dispatch(new LoadLocationsAction());
        }

        public void SaveLocation(Location location, bool isNew)
        {
            _logger.LogInformation("Issuing action to Add Locations...");
            _dispacher.Dispatch(new SaveLocationAction(location, isNew));
        }

        //public void LoadPartNums(string locationCode, string partnum, bool export)
        public void LoadPartNums(PartNumbDto partnumbs, bool OnlyItem)
        {
            try
            {
                _logger.LogInformation("Issuing action to load PartNum...");
                _dispacher.Dispatch(new LoadPartNumsAction(partnumbs, OnlyItem));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error loading PartNumbers, reason: {ex.Message}");
            }
        }
    }
 }

