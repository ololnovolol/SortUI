using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SortUI
{
     class SortedItem : IComparable
     {
            public VerticalProgressBar.VerticalProgressBar VProgBar { get; private set; }
            public Label Label { get; private set; }
            public int Value { get; private set; }
            public int Number { get; private set; }
            public int StartNumber { get; private set; }


            public SortedItem(int value, int number)
            {
                Value = value;
                Number = number;
                StartNumber = number;
                VProgBar = new VerticalProgressBar.VerticalProgressBar();
                Label = new Label();

                var x = number * 20;
                // 
                // verticalProgressBar1
                // 
                VProgBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
                VProgBar.Color = System.Drawing.Color.LightSeaGreen;
                VProgBar.Location = new System.Drawing.Point(x, 3);
                VProgBar.Maximum = 100;
                VProgBar.Minimum = 0;
                VProgBar.Name = "verticalProgressBar1" + number;
                VProgBar.Size = new System.Drawing.Size(18, 96);
                VProgBar.Step = 1;
                VProgBar.Style = VerticalProgressBar.Styles.Solid;
                VProgBar.TabIndex = number;
                VProgBar.Value = value;
                // 
                // label3
                // 
                Label.AutoSize = true;
                Label.Location = new Point(x, 102);
                Label.Name = "label" + number;
                Label.Size = new Size(19, 13);
                Label.TabIndex = number;
                Label.Text = Value.ToString();

            }
        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 20;
            VProgBar.Location = new Point(x, 3);
            VProgBar.Name = "ProgressBar" + number;
            Label.Location = new Point(x, 102);
            Label.Name = "label" + number;
        }

        public void Refresh()
        {
        Number = StartNumber;
        var x = Number * 20;
        VProgBar.Location = new Point(x, 3);
        VProgBar.Name = "ProgressBar" + Number;
        Label.Location = new Point(x, 102);
        Label.Name = "label" + Number;
        }

        public void SetColor(Color color)
        {
        VProgBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}
