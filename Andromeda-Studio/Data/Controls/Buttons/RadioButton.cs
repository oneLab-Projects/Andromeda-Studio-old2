﻿using System.Windows;
using System.Windows.Media;

namespace AndromedaStudio.Controls
{
    class RadioButton : System.Windows.Controls.RadioButton
    {
        #region Properties

        /// <summary>
        /// EN: Gets or sets the geometry value.
        /// RU: Получает или задает значение геометрии.
        /// </summary>
        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        /// <summary>
        /// EN: Gets or sets the System.Windows.Media.Brush
        /// RU: Получает или задает System.Windows.Media.Brush
        /// </summary>
        public Brush IconFill
        {
            get => (Brush)GetValue(IconFillProperty);
            set => SetValue(IconFillProperty, value);
        }

        /// <summary>
        /// EN: Gets or sets the value of the external content field.
        /// RU: Получает или задает значение внешнего поля содержимого.
        /// </summary>
        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        public bool New
        {
            get => (bool)GetValue(NewProperty);
            set => SetValue(NewProperty, value);
        }

        #region DependencyProperties

        public readonly static DependencyProperty IconProperty =
             DependencyProperty.Register("Icon", typeof(Geometry),
             typeof(RadioButton));

        public readonly static DependencyProperty IconFillProperty =
            DependencyProperty.Register("IconFill", typeof(Brush),
            typeof(RadioButton), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 0, 0))));

        public readonly static DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double),
            typeof(RadioButton), new UIPropertyMetadata(14.0));

        public readonly static DependencyProperty NewProperty =
            DependencyProperty.Register("New", typeof(bool),
            typeof(RadioButton), new UIPropertyMetadata(false));

        #endregion

        #endregion
    }
}
