using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualizedDataUWP.Models
{
    public class SimpleDataModel
    {
        public SimpleDataModel()
        {
            this.RawData = new byte[999];
        }

        /// <summary>
        /// The FeedId 
        /// </summary>
        public int ItemId
        {
            get;
            internal set;
        }

        /// <summary>
        /// Title of this feed
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        public byte[] RawData
        {
            get;
            set;
        }

        /// <summary>
        /// Simple way to see the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Title + " (" + this.ItemId + ")";
        }
    }

}

