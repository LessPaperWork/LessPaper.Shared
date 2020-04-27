﻿using System;
using System.Collections.Generic;
using LessPaper.Shared.Enums;

namespace LessPaper.Shared.Interfaces.General
{
    public interface IMetadata
    {
        /// <summary>
        /// Filename
        /// </summary>
        string ObjectName { get; }

        /// <summary>
        /// Unique object id
        /// </summary>
        string ObjectId { get; }

    }
}
