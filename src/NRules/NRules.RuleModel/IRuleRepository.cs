using System.Collections.Generic;

namespace NRules.RuleModel
{
    /// <summary>
    /// In-memory database of production rules.
    /// </summary>
    public interface IRuleRepository
    {
        /// <summary>
        /// Retrieves all rules contained in the repository.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IRuleDefinition> GetRules();

        /// <summary>
        /// Retrieves all rule sets contained in the repository.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IRuleSet> GetRuleSets();
    }
}