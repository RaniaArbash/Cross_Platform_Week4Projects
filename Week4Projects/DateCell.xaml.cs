using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week4Projects
{
    public partial class DateCell : ViewCell
    {
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell));

        public string Label {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }


        public static readonly BindableProperty LabelColorProperty =
            BindableProperty.Create("LabelColor", typeof(Color), typeof(DateCell));
        public Color LabelColor
        {
            get { return (Color)GetValue(LabelColorProperty); }
            set { SetValue(LabelColorProperty, value); }
        }

        public DateCell()
        {
            InitializeComponent();
            BindingContext = this;

        }
    }
}
