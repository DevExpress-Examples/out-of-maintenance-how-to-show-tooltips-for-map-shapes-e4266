using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Map;

namespace ShowMapTooltips
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void mapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            MapControl mapControl = sender as MapControl;
            #region #MapControl_CalcHitInfo
            MapShape shape = mapControl.CalcHitInfo(e.GetPosition(mapControl)).MapPath as MapShape;
            #endregion #MapControl_CalcHitInfo
            if (shape != null)
            {
                #region #MapItem_Attributes
                string name = (string)shape.Attributes["NAME"].Value;
                name += string.Format(": {0:n2}M", (double)shape.Attributes["POP_EST"].Value / 1000000);
                #endregion #MapItem_Attributes
                shapeTooltip.Show(mapControl, e.GetPosition(mapControl), name);
            }
            else
            {
                shapeTooltip.Hide();
            }

        }
        private void mapControl1_MouseLeave(object sender, MouseEventArgs e)
        {
            shapeTooltip.Hide();
        }

    }
}
