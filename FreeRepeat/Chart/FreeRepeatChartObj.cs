using System;
using System.Data;
namespace FreeRepeat.Chart
{
    public class FreeRepeatChartObj:FreeRepeatObj
    {
        private Highchart _highchartObj;
        private RelationExpression _relationExpression;

        private FreeRepeatTemplate _template;

        private DataTable _queryData;

        public FreeRepeatChartObj(DataTable queryData)
        {
            this._queryData = queryData;
        }

        public FreeRepeatChartObj(DataTable queryData, RelationExpression expression, FreeRepeatTemplate template)
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
        /// <summary>
        /// Build this instance.
        /// </summary>
        /// <returns>The build.</returns>
        public Highchart Build(){
            if (this._relationExpression != null)
            {
                InspectorRelaton(this._relationExpression);
            }
            if (this._template != null)
            {
                InspectorTemplate(this._template);
            }
            return this._highchartObj;
        }
    }
}
