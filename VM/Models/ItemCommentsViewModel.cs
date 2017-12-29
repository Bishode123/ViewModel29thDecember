using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VM.Models
{
    public class ItemCommentsViewModel
    {

        public ItemModel item { get; set; }
        public List<BuyersCommentsModel> comments { get; set; }
    }
}