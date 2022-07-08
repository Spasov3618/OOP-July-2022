namespace MilitaryElite
{
    using Models;
    using System.Collections.Generic;

    public interface ICommando
    {
        IReadOnlyList<Mission> Misions { get; }
    }
}