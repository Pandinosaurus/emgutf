﻿//----------------------------------------------------------------------------
//  Copyright (C) 2004-2020 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;

namespace Emgu.TF.Lite
{
    /// <summary>
    /// TfLiteInvoke for Android
    /// </summary>
    public static class TfLiteInvokeAndroid
    {
        /// <summary>
        /// Return true if the class is loaded.
        /// </summary>
        public static bool Init()
        {
            return TfLiteInvoke.Init();
        }
    }
}
