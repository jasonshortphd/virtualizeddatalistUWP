using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualizedDataUWP.Models;

namespace VirtualizedDataUWP
{
    public class MinimalDataList : IList
    {
        // Total items to show in the list
        public const int TotalItems = 1000000;

        /// <summary>
        /// Count returns the total items in the list.
        /// Important for the scrollbar to have a scale that matches the data
        /// </summary>
        public int Count
        {
            get { return TotalItems; }
        }

        /// <summary>
        /// Find the index of an object in the data list.
        /// Important to allow quick seek access to the data position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int IndexOf(object value)
        {
            if (value == null)
            {
                return -1;
            }

            SimpleDataModel item = (SimpleDataModel)value;
            return item.ItemId;
        }

        /// <summary>
        /// Indexer for the list - this is where XAML runtime will call back to ask for each item that is
        /// needed to fill the virtualized UI elements
        /// </summary>
        /// <param name="index">The index of the item to get</param>
        /// <returns>The item</returns>
        public object this[int index]
        {
            get
            {
                // If using SterlingDB you would simple have to Load<FeedItemDataModel>(index)
                SimpleDataModel loadedItem = null;
                loadedItem = new SimpleDataModel { ItemId = index, Title = "Title " };
                return loadedItem;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        #region NOT REQUIRED FOR ILIST

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
