using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MakeBitMap
{
    /// <summary>
    /// SetPixelSize.xaml の相互作用ロジック
    /// </summary>
    public partial class SetPixelSize : Window
    {
        public SetPixelSize()
        {
            InitializeComponent();

            MainWindow.disp_width = 8;     // 横のピクセル数(初期値)
            MainWindow.disp_height = 16;    // 縦のピクセル数
            MainWindow.em_font_size = 16;   // デフォルトフォントサイズ
        }


        // 8x16 チェック時
        private void RadioButton_8_16_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.disp_width = 8;     // 横のピクセル数
            MainWindow.disp_height = 16;    // 縦のピクセル数
            MainWindow.em_font_size = 16;   // デフォルトフォントサイズ
        }


        // 48x96 チェック時
        private void RadioButton_48_96_Checked(object sender, RoutedEventArgs e)
        {
            MainWindow.disp_width = 48;
            MainWindow.disp_height = 96;
            MainWindow.em_font_size = 72;
        }


        // OKボタンの処理
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
