﻿using System;
using System.Collections.Generic;
using LessPaper.Shared.Enums;
using LessPaper.Shared.Interfaces.General;

namespace LessPaper.Shared.Models.General
{
    public class Metadata : IMetadata
    {
        public string ObjectName { get; set; }

        public string ObjectId { get; set; }

        public uint SizeInBytes { get; set; }

        public DateTime LatestChangeDate { get; set; }

        public DateTime LatestViewDate { get; set; }

        public Dictionary<string, Permission> Permissions { get; set; }
    }
} 