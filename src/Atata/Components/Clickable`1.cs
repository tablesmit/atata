﻿namespace Atata
{
    /// <summary>
    /// Represents any HTML element. Default search is performed by the id attribute.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition("*", ComponentTypeName = "control", IgnoreNameEndings = "Button,Link")]
    [ControlFinding(FindTermBy.Id)]
    public class Clickable<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
