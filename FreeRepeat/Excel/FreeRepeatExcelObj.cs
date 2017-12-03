using System;
using System.Data;
namespace FreeRepeat.Excel
{
    public class FreeRepeatExcelObj:FreeRepeatObj
    {
        private Excel _excelObj;

        private RelationExpression _relationExpression;

        private FreeRepeatTemplate _template;

        private DataTable _queryData;

        public FreeRepeatExcelObj(DataTable queryData)
        {
            this._queryData = queryData;
        }

        public FreeRepeatExcelObj(DataTable queryData, RelationExpression expression, FreeRepeatTemplate template)
        {
            this._queryData = queryData;
            this._relationExpression = expression;
            this._template = template;
        }

        public override void InspectorRelaton(RelationExpression expression)
        {
            throw new NotImplementedException();
        }

        public override void InspectorTemplate(FreeRepeatTemplate template)
        {
            throw new NotImplementedException();
        }

        public Excel Build(){
            
            if (this._relationExpression != null)
            {
                InspectorRelaton(this._relationExpression);
            }
            if (this._template != null)
            {
                InspectorTemplate(this._template);
            }
            return this._excelObj;
        }
    }
}
