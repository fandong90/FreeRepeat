using System;
using System.Data;
using System.Linq.Expressions;
using FreeRepeat.Data;
using FreeRepeat.Table;
using FreeRepeat.Excel;
using FreeRepeat.Chart;
using FreeRepeat.PDF;
namespace FreeRepeat
{
    public class FreeRepeatEntity:FreeRepeat
    {
        private DataTable _queryData;

        private RelationExpression _relationExpression;

        private FreeRepeatTemplate _freeRepeatTemplate;

        public override DataTable QueryData(string sqlText)
        {
            FreeRepeatData freeRepeatDat = new FreeRepeatData();
            var dt = freeRepeatDat.GetDataFromSql(sqlText);
            this._queryData = dt;
            return dt;
        }

        public override DataTable QueryData(Expression sqlExpresssion)
        {
            FreeRepeatData freeRepeatDat = new FreeRepeatData();
            var dt = freeRepeatDat.GetDataFromSql(sqlExpresssion.ToString());
            this._queryData = dt;
            return dt;
        }

        /// <summary>
        /// Render the specified type.
        /// </summary>
        /// <returns>The render.</returns>
        /// <param name="type">Type.</param>
        public override FreeRepeatObj Render(FreeRepeatTypes type)
        {
            FreeRepeatObj freeRepeatObj;
            switch(type){
                case FreeRepeatTypes.Chart: freeRepeatObj = new FreeRepeatChartObj(this._queryData, this._relationExpression, this._freeRepeatTemplate); break;
                case FreeRepeatTypes.Excel: freeRepeatObj = new FreeRepeatExcelObj(this._queryData, this._relationExpression, this._freeRepeatTemplate); break;
                case FreeRepeatTypes.Table: freeRepeatObj= new FreeRepeatTableObj(this._queryData,this._relationExpression,this._freeRepeatTemplate); break;
                case FreeRepeatTypes.PDF: freeRepeatObj = new FreeRepeatPdfObj(); break;
                default: freeRepeatObj = null; break; 
            }
            return freeRepeatObj;
        }

        public override void SetRelation(RelationExpression relationExpression)
        {
            this._relationExpression = relationExpression;
        }

        public override void SetTemplate(FreeRepeatTemplate template)
        {
            this._freeRepeatTemplate = template;
        }

    }
}
