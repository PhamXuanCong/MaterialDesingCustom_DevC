using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace MaterialDesignThemeCustom_By_DevC
{
    public static class ShadowAssist
    {
       public static readonly DependencyProperty CacheModeProperty = DependencyProperty.RegisterAttached(
           "CacheMode",typeof(CacheMode), typeof(ShadowAssist), new FrameworkPropertyMetadata(null,FrameworkPropertyMetadataOptions.Inherits));

       public static void SetCacheMode(DependencyObject element, CacheMode value)
       {
           element.SetValue(CacheModeProperty, value);
       }

       public static CacheMode GetCacheMode(DependencyObject element)
       {
           return (CacheMode)element.GetValue(CacheModeProperty);
       }
    }
}
