# virtualizeddatalistUWP

A sample virtualized data list implementation for UWP (C#/XAML).  

I had written this for Silverlight and Windows Phone 7, but the same basic techniques work in UWP with some slight code changes.

The basic idea is that you implement an IList that exposes the interfaces needed to allow you to skip through data, and it doesn't require everything to be loaded before data binding.

Look in Models\ for the simple data model.  Obviously not pulling from anything.
MinimalDataList.cs is the main part of the application.  Puts a 1 MILLION row data virtualized list so that you can jump around it in the application.

I have tested this on Windows 10 Desktops, Phones, and XBox.  

