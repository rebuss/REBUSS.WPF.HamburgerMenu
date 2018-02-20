﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace REBUSS.WPF.Controls.HamburgerMenu
{
    public class ItemFeed : DependencyObject
    {
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
            "Command", typeof(ICommand), typeof(ItemFeed), new PropertyMetadata(default(ICommand)));

        public static readonly DependencyProperty IconContentProperty = DependencyProperty.Register(
            "IconContent", typeof(object), typeof(ItemFeed), new PropertyMetadata(default(object)));

        public static readonly DependencyProperty KeyProperty = DependencyProperty.Register(
            "Key", typeof(object), typeof(ItemFeed), new PropertyMetadata(default(object)));

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label", typeof(string), typeof(ItemFeed), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty TooltipProperty = DependencyProperty.Register(
            "Tooltip", typeof(string), typeof(ItemFeed), new PropertyMetadata(default(string)));

        public ICommand Command
        {
            get { return (ICommand) GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public object IconContent
        {
            get { return GetValue(IconContentProperty); }
            set { SetValue(IconContentProperty, value); }
        }

        public object Key
        {
            get { return GetValue(KeyProperty); }
            set { SetValue(KeyProperty, value); }
        }

        public string Label
        {
            get { return (string) GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public string Tooltip
        {
            get { return (string) GetValue(TooltipProperty); }
            set { SetValue(TooltipProperty, value); }
        }
    }
}