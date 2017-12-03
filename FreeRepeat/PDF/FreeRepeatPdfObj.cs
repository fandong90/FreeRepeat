using System;
namespace FreeRepeat.PDF
{
    public class FreeRepeatPdfObj:FreeRepeatObj
    {
        private PdfEntity _pdfObj;


        public FreeRepeatPdfObj()
        {
        }

        public override void InspectorRelaton(RelationExpression expression)
        {
            throw new NotImplementedException();
        }

        public override void InspectorTemplate(FreeRepeatTemplate template)
        {
            throw new NotImplementedException();
        }

        public PdfEntity Build(){
            return this._pdfObj;
        }
    }
}
