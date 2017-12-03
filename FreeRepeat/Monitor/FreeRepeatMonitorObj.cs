using System;
namespace FreeRepeat.Monitor
{
    public  class FreeRepeatMonitorObj
    {
        /// <summary>
        /// Gets or sets the method execute.
        /// get method execute time
        /// </summary>
        /// <value>The method execute.</value>
        public string MethodExecute{ get;set;}

        /// <summary>
        /// Gets or sets the error info.
        /// </summary>
        /// <value>The error info.</value>
        public string ErrorInfo { get; set; }

        /// <summary>
        /// Gets or sets the warning info.
        /// </summary>
        /// <value>The warning info.</value>
        public string WarningInfo { get; set; }

        /// <summary>
        /// Gets or sets the name of the method.
        /// </summary>
        /// <value>The name of the method.</value>
        public string MethodName{get;set;}

    }
}
