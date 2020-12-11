using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.V.Store.Features.Shared
{
    public class FailureAction
    {
        protected FailureAction(string errorMessage) =>
            ErrorMessage = errorMessage;

        public string ErrorMessage { get; }
    }
}
