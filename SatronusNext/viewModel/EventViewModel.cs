using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.ComponentModel﻿;

namespace SatronusNext.viewModel
{
    class EventViewModel : DependencyObject
    {


        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(EventViewModel), new PropertyMetadata("" ,Filter_Change));

        private static void Filter_Change(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as EventViewModel;
            if(current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterEvent;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("MyProperty", typeof(ICollectionView), typeof(EventViewModel), new PropertyMetadata(null));

        public EventViewModel()
        {

        }
        public EventViewModel(Event [] temp)
        {
            Items = CollectionViewSource.GetDefaultView(temp);
            Items.Filter = FilterEvent;
        }

        private bool FilterEvent(object obj)
        {
            bool result = true;
            Event temp = obj as Event;
            if(!string.IsNullOrWhiteSpace(FilterText) && temp!=null && !temp.Name.Contains(FilterText) && !temp.Time.ToString().Contains(FilterText))
            {
                result = false;
            }
            return result;
        }
    }
}
