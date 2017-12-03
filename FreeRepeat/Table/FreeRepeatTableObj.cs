using System;
using System.Data;
namespace FreeRepeat.Table
{
    public class FreeRepeatTableObj:FreeRepeatObj
    {
        private TableEntity _tableEntityObj;

        private RelationExpression _relationExpression;

        private FreeRepeatTemplate _template;

        private DataTable _queryData;

        public FreeRepeatTableObj(DataTable queryData)
        {
            this._queryData = queryData;
        }

        public FreeRepeatTableObj(DataTable queryData,RelationExpression expression,FreeRepeatTemplate template)
        {
            this._queryData = queryData;
            this._relationExpression = expression;
            this._template = template;
        }

        /// <summary>
        /// Insepectors the relaton.
        /// </summary>
        /// <param name="expression">Expression.</param>
        public override void InspectorRelaton(RelationExpression expression)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insepectors the template.
        /// </summary>
        /// <param name="template">Template.</param>
        public override void InspectorTemplate(FreeRepeatTemplate template)
        {
            throw new NotImplementedException();
        }

        public TableEntity Build(){

            if(this._relationExpression!=null){
                InspectorRelaton(this._relationExpression);
            }
            if(this._template!=null){
                InspectorTemplate(this._template);
            }
            return this._tableEntityObj;
        }

    }
}
