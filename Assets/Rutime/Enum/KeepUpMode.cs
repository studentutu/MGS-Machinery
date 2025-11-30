/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  KeepUpMode.cs
 *  Description  :  Mode of keep up.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  3/20/2025
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.Machineries
{
    /// <summary>
    /// Mode of keep up.
    /// </summary>
    public enum KeepUpMode
    {
        /// <summary>
        /// Base on transform up aixs.
        /// </summary>
        TransformUp = 0,

        /// <summary>
        /// Base on reference transform forward aixs.
        /// </summary>
        ReferenceForward = 1
    }
}