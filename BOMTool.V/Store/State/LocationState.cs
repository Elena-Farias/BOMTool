﻿using System.Collections.Generic;
using BOMTool.M;

namespace BOMTool.V.Store.State
{
    public class LocationState : RootState
    {   
        public LocationState(bool isLoading, string currentErrorMessage, IEnumerable<Location> currentEntities, Location currentEntitie)
            : base(isLoading, currentErrorMessage)
         {
            Currents = currentEntities;
            Current = currentEntitie;
         }
        
        public IEnumerable<Location> Currents { get; }
        public Location Current { get; }
    }
}

