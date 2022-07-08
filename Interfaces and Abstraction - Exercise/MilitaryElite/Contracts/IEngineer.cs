namespace MilitaryElite
{
    using Models;
    using System.Collections.Generic;

    public interface IEngineer
    {
        IReadOnlyList<Repair> Repairs { get; }
    }
}