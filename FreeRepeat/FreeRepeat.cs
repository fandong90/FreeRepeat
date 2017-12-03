using System;
using System.Data;
using System.Linq.Expressions;
namespace FreeRepeat
{
    public abstract  class FreeRepeat
    {
        /// <summary>
        /// Queries the data.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="sqlText">Sql text.</param>
        public abstract DataTable QueryData(string sqlText);

        /// <summary>
        /// Queries the data.
        /// </summary>
        /// <returns>The data.</returns>
        /// <param name="sqlExpresssion">Sql expresssion.</param>
        public abstract DataTable QueryData(Expression sqlExpresssion);

        /// <summary>
        /// Sets the relation.
        /// insepector data struct
        /// </summary>
        /// <param name="relationExpression">Relation expression.</param>
        public abstract void SetRelation(RelationExpression relationExpression);

        /// <summary>
        /// Sets the template.
        /// depend on template sequence object
        /// </summary>
        /// <param name="template">Template.</param>
        public abstract void SetTemplate(FreeRepeatTemplate template);

        /// <summary>
        /// Render the specified type.
        /// </summary>
        /// <returns>The render.</returns>
        /// <param name="type">Type.</param>
        public abstract FreeRepeatObj Render(FreeRepeatTypes type);
    }
}
