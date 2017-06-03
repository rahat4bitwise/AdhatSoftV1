using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyShopkeeping.Vo.outward.SellsEntry
{
    class SellsEntryForTraderVO
    {
        private String TRDR_FNAME_TMARK;

        public String TRDR_FNAME_TMARK1
        {
            get { return TRDR_FNAME_TMARK; }
            set { TRDR_FNAME_TMARK = value; }
        }
        private String LOT_SERIAL;

        public String LOT_SERIAL1
        {
            get { return LOT_SERIAL; }
            set { LOT_SERIAL = value; }
        }
        private String LOT_ID;

        public String LOT_ID1
        {
            get { return LOT_ID; }
            set { LOT_ID = value; }
        }
        private String G_ENTRY_ID;

        public String G_ENTRY_ID1
        {
            get { return G_ENTRY_ID; }
            set { G_ENTRY_ID = value; }
        }
        private String STOCK_ID;

        public String STOCK_ID1
        {
            get { return STOCK_ID; }
            set { STOCK_ID = value; }
        }
        private String TRDR_ID;

        public String TRDR_ID1
        {
            get { return TRDR_ID; }
            set { TRDR_ID = value; }
        }
    }
}
