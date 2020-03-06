﻿using CMS.Base;

/// <summary>
/// Event Handler
/// </summary>
namespace URLRedirection.Events
{
    public class GetRequestCultureEventHandler : AdvancedHandler<GetRequestCultureEventHandler, GetRequestCultureEventArgs>
    {
        public GetRequestCultureEventHandler()
        {

        }

        public GetRequestCultureEventHandler StartEvent(GetRequestCultureEventArgs RequestCultureArgs)
        {
            return base.StartEvent(RequestCultureArgs);
        }

        public void FinishEvent()
        {
            base.Finish();
        }
    }
}
