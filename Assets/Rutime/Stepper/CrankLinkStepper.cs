/*************************************************************************
 *  Copyright © 2025 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Slider.cs
 *  Description  :  Define CrankLinkStepper component.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0
 *  Date         :  12/08/2022
 *  Description  :  Initial development version.
 *************************************************************************/

using UnityEngine;

namespace MGS.Machineries
{
    /// <summary>
    /// Stepper motor for CrankLinkMechanism.
    /// </summary>
    [AddComponentMenu("MGS/Machinery/CrankLinkStepper")]
    public class CrankLinkStepper : Stepper
    {
        /// <summary>
        /// CrankLinkMechanism drive by stepper.
        /// </summary>
        public CrankLinkMechanism mechanism;

        /// <summary>
        /// Mechanism drive by stepper.
        /// </summary>
        protected override Mechanism Mechanism { get { return mechanism; } }

        /// <summary>
        /// Current mileage.
        /// </summary>
        protected override float Current { get { return mechanism.crank.Angle; } }
    }
}