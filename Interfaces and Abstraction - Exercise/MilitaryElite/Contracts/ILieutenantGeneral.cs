﻿namespace MilitaryElite
{
    using System.Collections.Generic;
    using Models.Soldiers;

    public interface ILieutenantGeneral
    {
        IReadOnlyList<Private> Privates { get; }
    }
}