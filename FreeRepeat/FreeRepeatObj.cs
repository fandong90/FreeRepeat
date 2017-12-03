using System;
using System.Collections.Generic;
namespace FreeRepeat
{
    /// <summary>
    /// Free repeat object.
    /// the class of base core class
    /// FreeRepeat Render object inherit it
    /// </summary>
    public abstract class FreeRepeatObj
    {
        /// <summary>
        /// Insepectors the relaton.
        /// </summary>
        /// <param name="expression">Expression.</param>
        public abstract void  InspectorRelaton(RelationExpression expression);

        /// <summary>
        /// Insepectors the template.
        /// </summary>
        /// <param name="template">Template.</param>
        public abstract void InspectorTemplate(FreeRepeatTemplate template);



    }
}
