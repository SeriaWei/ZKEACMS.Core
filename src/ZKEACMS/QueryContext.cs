/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS
{
    public class QueryContext
    {
        public string LayoutID { get; set; }
        public string ZoneID { get; set; }
        public string PageID { get; set; }
        public int? RuleID { get; set; }
        public string WidgetID { get; set; }
        public string ReturnUrl { get; set; }
        public string WidgetTemplateID { get; set; }
    }
}
