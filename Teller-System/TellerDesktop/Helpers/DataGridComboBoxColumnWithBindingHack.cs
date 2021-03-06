using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TellerDesktop
{
    public class DataGridComboBoxColumnWithBindingHack : DataGridComboBoxColumn
    {
        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
        {
            FrameworkElement element = base.GenerateEditingElement(cell, dataItem);
            CopyItemsSource(element);
            return element;
        }

        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            FrameworkElement element = base.GenerateElement(cell, dataItem);
            CopyItemsSource(element);
            return element;
        }

        private void CopyItemsSource(FrameworkElement element)
        {
            BindingOperations.SetBinding(element, ComboBox.ItemsSourceProperty,
              BindingOperations.GetBinding(this, ComboBox.ItemsSourceProperty));
        }
    }
}
