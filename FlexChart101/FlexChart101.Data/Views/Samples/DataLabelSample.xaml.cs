﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexChartDemo.Data.Model;
using Xamarin.Forms;
using Xuni.Forms.FlexChart;
using FlexChartDemo.Data.Resources;

namespace FlexChartDemo.Data.Views.Samples
{
    public partial class DataLabelSample
    {
        public DataLabelSample()
        {
            InitializeComponent();
            Title = AppResources.DataLabelsTitle;

            this.pickerChartType.Items.Add(ChartType.Column.ToString());
            this.pickerChartType.Items.Add(ChartType.Bar.ToString());
            this.pickerChartType.Items.Add(ChartType.Scatter.ToString());
            this.pickerChartType.Items.Add(ChartType.Line.ToString());
            this.pickerChartType.Items.Add(ChartType.LineSymbols.ToString());
            this.pickerChartType.Items.Add(ChartType.Area.ToString());
            this.pickerChartType.Items.Add(ChartType.Spline.ToString());
            this.pickerChartType.Items.Add(ChartType.SplineSymbols.ToString());
            this.pickerChartType.Items.Add(ChartType.SplineArea.ToString());

            // the data labels sample should show a bar chart by default.
            this.pickerChartType.SelectedIndex = 1;
            this.pickerChartType.IsVisible = false;
            this.flexChart.ItemsSource = ChartSampleFactory.CreateEntityList();
            this.flexChart.Palette = Xuni.Forms.ChartCore.ChartPalettes.Organic;

            foreach (var item in Enum.GetNames(typeof(ChartLabelPosition)))
			{
                this.pickPostion.Items.Add(item);
            }
            this.pickPostion.SelectedIndex = 1;
        }

        void pickPostion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flexChart.DataLabel.Position = (ChartLabelPosition)Enum.Parse(typeof(ChartLabelPosition), this.pickPostion.Items[this.pickPostion.SelectedIndex]);
        }
        void pickerChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flexChart.ChartType = (ChartType)Enum.Parse(typeof(ChartType), this.pickerChartType.Items[this.pickerChartType.SelectedIndex]);
        }
    }
}
