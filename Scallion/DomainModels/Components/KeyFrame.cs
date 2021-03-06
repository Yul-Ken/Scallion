﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Scallion.DomainModels.Components
{
    /// <summary>
    /// Represents a key frame used for transition.
    /// This class is abstract.
    /// </summary>
    public abstract class KeyFrame
    {
        /// <summary>
        /// Gets or sets the index of this key frame.
        /// </summary>
        public int KeyFrameIndex { get; set; }
    }

    /// <summary>
    /// Represents a key frame that indicates whether a object is visible.
    /// </summary>
    public class VisibilityKeyFrame : KeyFrame
    {
        /// <summary>
        /// Gets or sets a value indicating whether the object is visible.
        /// </summary>
        public bool IsVisible { get; set; }
    }
}
