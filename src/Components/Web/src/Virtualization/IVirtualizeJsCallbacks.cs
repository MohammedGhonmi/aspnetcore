// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

namespace Microsoft.AspNetCore.Components.Virtualization
{
    internal interface IVirtualizeJsCallbacks
    {
        void OnBeforeSpacerVisible(float spacerSize, float containerSize);
        void OnBottomSpacerVisible(float spacerSize, float containerSize);
    }
}
