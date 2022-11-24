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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Windows.Threading;

namespace Utilities_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort sp = new SerialPort();
        DispatcherTimer timer_SerialPort = new DispatcherTimer();
        NonePrintableCharacter noneChar = new NonePrintableCharacter();
        string STX = Convert.ToChar(02).ToString();
        string ETX = Convert.ToChar(03).ToString();
        string PLus725_Respond = Convert.ToChar(05).ToString();
        string[] PLUS725_IN = new string[64];
        int[] data_input_by_Plus725 = new int[6];
        DispatcherTimer timer_On_Off_Relay_Plus725;
        public MainWindow()
        {
            InitializeComponent();
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            Grid_Form.RowDefinitions[2].Height = (GridLength)gridLengthConverter.ConvertFrom("20");
            Option_using_with_Plus7225(false);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Minized_Form(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Closed_Form(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        

        #region Serial Port
        private void Show_Option(bool state)
        {
            cbSerialPort.IsEnabled = state;
            cbBaudrate.IsEnabled = state;
            cbParity.IsEnabled = state;
            cbStopBit.IsEnabled = state;
        }
        private Parity ConvertParity(string _Parity)
        {
            Parity parity = Parity.None;
            switch (_Parity)
            {
                case "None":
                    parity = Parity.None;
                    break;

                case "Even":
                    parity = Parity.Even;
                    break;

                case "Odd":
                    parity = Parity.Odd;
                    break;

                case "Mark":
                    parity = Parity.Mark;
                    break;

                case "Space":
                    parity = Parity.Space;
                    break;

                default:
                    break;
            }
            return parity;
        }

        private StopBits ConvertStopBits(string _StopBits)
        {
            StopBits stopBits = StopBits.None;
            switch (_StopBits)
            {
                case "0":
                    stopBits = StopBits.None;
                    break;

                case "1":
                    stopBits = StopBits.One;
                    break;

                case "1.5":
                    stopBits = StopBits.OnePointFive;
                    break;

                case "2":
                    stopBits = StopBits.Two;
                    break;

                default:
                    break;
            }

            return stopBits;
        }

        private void Timer_SerialPort_Tick(object sender, EventArgs e)
        {
            this.timer_SerialPort.IsEnabled = false;
            string temp = sp.ReadExisting();
            Data_Input(temp);
            Write_Log(temp, "Received");
            //this.Dispatcher.Invoke(new Action(() =>
            //{
                
            //}));
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                this.timer_SerialPort.IsEnabled = true;
            }));
        }

        private void Send_data(string data)
        {
            if (sp.IsOpen)
            {
                noneChar = new NonePrintableCharacter(data);
                sp.Write(noneChar._hideChar);
                Write_Log(noneChar._showChar, "Write");
            }
        }
        #endregion

        #region button click

        private void btAdd_ACSII_Click(object sender, RoutedEventArgs e)
        {
            noneChar = new NonePrintableCharacter(Convert.ToChar(numACSII.Value).ToString());
            txtDataSend.Text += noneChar._showChar;
            txtDataSend.Focus();
            txtDataSend.Select(txtDataSend.Text.Length, 0);
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            txtDataSend.Text = "";
        }

        private void btAdd_STX_Click(object sender, RoutedEventArgs e)
        {
            noneChar = new NonePrintableCharacter(Convert.ToChar(2).ToString());
            txtDataSend.Text += noneChar._showChar;
            txtDataSend.Focus();
            txtDataSend.Select(txtDataSend.Text.Length, 0);
        }

        private void btAdd_ETX_Click(object sender, RoutedEventArgs e)
        {
            noneChar = new NonePrintableCharacter(Convert.ToChar(3).ToString());
            txtDataSend.Text += noneChar._showChar;
            txtDataSend.Focus();
            txtDataSend.Select(txtDataSend.Text.Length, 0);
        }

        bool hide_form = false;
        private void btExtend_Grid_Click(object sender, RoutedEventArgs e)
        {
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            if (hide_form == false)
            {
                hide_form = true;
                Grid_Form.RowDefinitions[2].Height = (GridLength)gridLengthConverter.ConvertFrom(Height);
            }
            else
            {
                hide_form = false;
                Grid_Form.RowDefinitions[2].Height = (GridLength)gridLengthConverter.ConvertFrom("20");
            }
        }

        private void btConnect_Click(object sender, RoutedEventArgs e)
        {
            sp.Close();
            if (btConnect.Content.ToString() == "Connect")
            {
                if (cbSerialPort.Text != "")
                {
                    sp.PortName = cbSerialPort.Text;
                    sp.BaudRate = Convert.ToInt32(cbBaudrate.Text);
                    sp.Parity = ConvertParity(cbParity.Text);
                    sp.StopBits = ConvertStopBits(cbStopBit.Text);
                    try
                    {
                        sp.Open();
                        Show_Option(false);
                        timer_SerialPort = new DispatcherTimer();
                        timer_SerialPort.Interval = TimeSpan.FromMilliseconds(100);
                        timer_SerialPort.Tick += Timer_SerialPort_Tick;
                        sp.DataReceived += Sp_DataReceived;
                        btConnect.Content = "Disconnect";
                        btConnect.Background = Brushes.Tomato;
                        btConnect.BorderBrush = Brushes.Tomato;
                        btConnect.Foreground = Brushes.White;
                    }
                    catch (Exception ex)
                    {
                        if (ex.ToString().Contains("Access to the port '" + cbSerialPort.Text + "' is denied."))
                        {
                            MessageBox.Show("Can not connect " + cbSerialPort.Text);
                        }
                        else
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }

                }

            }
            else
            {
                timer_SerialPort.Tick -= Timer_SerialPort_Tick;
                btConnect.Content = "Connect";
                btConnect.Background = new SolidColorBrush(Color.FromRgb(21, 171, 91));
                btConnect.BorderBrush = new SolidColorBrush(Color.FromRgb(21, 171, 80));
                btConnect.Foreground = Brushes.White;
                Show_Option(true);

                //off use Plus 725 if using
                if(ckbUsing_Plus725.IsChecked==true)
                {
                    ckbUsing_Plus725.IsChecked = false;
                }
            }
        }

        

        private void btSend_Click(object sender, RoutedEventArgs e)
        {
            Send_data(txtDataSend.Text);
        }

        private void txtDataSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Send_data(txtDataSend.Text);
            }
        }

        private void btSR1000_ON_Click(object sender, RoutedEventArgs e)
        {
            if (sp.IsOpen)
            {
                string temp = STX + "LON" + ETX;
                sp.Write(temp);
                Write_Log(temp, "Write");
            }
        }

        private void btSR1000_OFF_Click(object sender, RoutedEventArgs e)
        {
            if (sp.IsOpen)
            {
                string temp = STX + "LOFF" + ETX;
                sp.Write(temp);
                Write_Log(temp, "Write");
            }
        }

        private void btSR1000_Focus_Click(object sender, RoutedEventArgs e)
        {
            if (sp.IsOpen)
            {
                string temp = STX + "LOFF" + ETX;
                sp.Write(temp);
                Write_Log(temp, "Write");
                System.Threading.Thread.Sleep(500);
                temp = STX + "FTUNE" + ETX;
                sp.Write(temp);
                Write_Log(temp, "Write");
            }
        }

        private void ckbUsing_Plus725_CheckChanged(object sender, RoutedEventArgs e)
        {
            if (ckbUsing_Plus725.IsChecked == true)
            {
                if (sp.IsOpen)
                {
                    if (sp.BaudRate != 19200)
                    {
                        ckbUsing_Plus725.IsChecked = false;
                        MessageBox.Show("Plus 725 use serial port with Baudrate 19200 !!!");

                    }
                    else
                    {
                        lbUse_Plus725.Text = "Using Plus 725";
                        Variable_Pin_IN_Plus725();
                        Option_using_with_Plus7225(true);
                    }
                }
                else
                {
                    ckbUsing_Plus725.IsChecked = false;
                    lbUse_Plus725.Text = "Use Plus 725";
                    Option_using_with_Plus7225(false);
                }
            }
            else
            {
                lbUse_Plus725.Text = "Use Plus 725";
                Option_using_with_Plus7225(false);
                if (timer_On_Off_Relay_Plus725 != null)
                {
                    timer_On_Off_Relay_Plus725.Tick -= Timer_On_Off_Relay_Plus725_Tick;
                }
            }
        }

        private void Option_using_with_Plus7225 (bool status)
        {
            ckbW0.IsEnabled = status;
            ckbW1.IsEnabled = status;
            ckbW2.IsEnabled = status;
            ckbW3.IsEnabled = status;
            ckbW_Off.IsEnabled = status;
            ckbW0.IsChecked = false;
            ckbW1.IsChecked = false;
            ckbW2.IsChecked = false;
            ckbW3.IsChecked = false;
            ckbW_Off.IsChecked = false;
            ckb_timer_Plus725.IsChecked = false;
            ckb_timer_Plus725.IsEnabled = status;
            numTimer.IsEnabled = status;
            numTimer.Background = Brushes.White;
            Signal_IN_0.Fill = Brushes.Gray;
            Signal_IN_1.Fill = Brushes.Gray;
            Signal_IN_2.Fill = Brushes.Gray;
            Signal_IN_3.Fill = Brushes.Gray;
            Signal_IN_4.Fill = Brushes.Gray;
            Signal_IN_5.Fill = Brushes.Gray;
        }

        #endregion

        private void Data_Input(string data)
        {
            int start = 0;
            int end = 0;
            while(data.Contains(STX) && data.Contains(ETX))
            {
                if (data.Contains(PLus725_Respond))
                {
                    data = data.Replace(PLus725_Respond, "");
                }
                start = data.IndexOf(STX);
                end = data.IndexOf(ETX);
                string temp1 = data.Substring(start, end + 1);
                if (start < end)
                {
                    string temp = temp1.Replace(STX, "").Replace(ETX, "");
                    if (ckbUsing_Plus725.IsChecked == true && ContainsAny(temp, PLUS725_IN) == true)
                    {

                        string value_binary = Convert.ToString(Convert.ToInt32(temp, 16), 2);
                        if (value_binary.Length < 6)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                if (value_binary.Length < 6)
                                {
                                    value_binary = "0" + value_binary;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < value_binary.Length; j++)
                        {
                            data_input_by_Plus725[j] = Convert.ToInt32(value_binary.Substring(5 - j, 1));
                        }
                        Pin_IN(data_input_by_Plus725);
                    }
                }
                data = data.Remove(start, end + 1);
            }
        }

        

        private void Write_Log(string data, string Write_Received)
        {
            noneChar = new NonePrintableCharacter(data);
            if(Write_Received == "Write")
            {
                txtDataReceived.AppendText("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "]W " + noneChar._showChar + "\n");
            }
            else if(Write_Received == "Received")
            {
                txtDataReceived.AppendText("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "]R " + noneChar._showChar + "\n");
            }
            txtDataReceived.ScrollToEnd();
        }

        #region Using Plus 725
        private void Variable_Pin_IN_Plus725()
        {
            for (int i = 0; i < 64; i++)
            {
                string temp = Convert.ToString(i, 16);
                if (temp.Length < 2)
                {
                    temp = "0" + temp;
                }
                PLUS725_IN[i] = temp;
            }
        }

        bool ContainsAny(string haystack, string[] needles)
        {
            bool result = false;
            foreach (string needle in needles)
            {
                if (haystack == needle)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        private void Pin_IN(int[] data)
        {

            if (data[0] == 1)
            {
                Signal_IN_0.Fill = Brushes.Gold;
            }
            else if (data[0] == 0)
            {
                Signal_IN_0.Fill = Brushes.Gray;
            }

            if (data[1] == 1)
            {
                Signal_IN_1.Fill = Brushes.Gold;
            }
            else if (data[1] == 0)
            {
                Signal_IN_1.Fill = Brushes.Gray;
            }

            if (data[2] == 1)
            {
                Signal_IN_2.Fill = Brushes.Gold;
            }
            else if (data[2] == 0)
            {
                Signal_IN_2.Fill = Brushes.Gray;
            }

            if (data[3] == 1)
            {
                Signal_IN_3.Fill = Brushes.Gold;
            }
            else if (data[3] == 0)
            {
                Signal_IN_3.Fill = Brushes.Gray;
            }

            if (data[4] == 1)
            {
                Signal_IN_4.Fill = Brushes.Gold;
            }
            else if (data[4] == 0)
            {
                Signal_IN_4.Fill = Brushes.Gray;
            }

            if (data[5] == 1)
            {
                Signal_IN_5.Fill = Brushes.Gold;
            }
            else if (data[5] == 0)
            {
                Signal_IN_5.Fill = Brushes.Gray;
            }
        }
        #endregion

        
        private void ckb_timer_Plus725_Click(object sender, RoutedEventArgs e)
        {
            if (ckb_timer_Plus725.IsChecked == true)
            {
                timer_On_Off_Relay_Plus725 = new DispatcherTimer();
                timer_On_Off_Relay_Plus725.Interval = TimeSpan.FromMilliseconds(Convert.ToInt32(numTimer.Value));
                timer_On_Off_Relay_Plus725.Tick += Timer_On_Off_Relay_Plus725_Tick;
                timer_On_Off_Relay_Plus725.Start();
            }
            else
            {
                if(timer_On_Off_Relay_Plus725!=null)
                {
                    timer_On_Off_Relay_Plus725.Tick -= Timer_On_Off_Relay_Plus725_Tick;
                    numTimer.Background = Brushes.White;
                }
            }
        }

        bool state_ON = false;
        private void Timer_On_Off_Relay_Plus725_Tick(object sender, EventArgs e)
        {
            timer_On_Off_Relay_Plus725.Interval = TimeSpan.FromMilliseconds(Convert.ToInt32(numTimer.Value));
            if (state_ON == false)
            {
                state_ON = true;
                numTimer.Background = Brushes.Red;
                Pin_Out();
            }
            else
            {
                state_ON = false;
                numTimer.Background = Brushes.White;
                if(sp.IsOpen)
                {
                    string data = STX + "W0" + ETX;
                    sp.Write(data);
                    Write_Log(data, "Write");
                }
                
            }
        }

        string Data_Pin_Out_Plus725 = "0000";
        bool Flag_off_Plus725 = false;
        private void Pin_Out()
        {
            string temp = "0000";
            if (ckbW_Off.IsChecked == true && Flag_off_Plus725 == false)
            {
                temp = "0000";
            }
            if (ckbW0.IsChecked == true && Flag_off_Plus725 == false)
            {
                temp = temp.Remove(3, 1);
                temp = temp.Insert(3, "1");
            }
            else
            {
                temp = temp.Remove(3, 1);
                temp = temp.Insert(3, "0");
            }
            if (ckbW1.IsChecked == true && Flag_off_Plus725 == false)
            {
                temp = temp.Remove(2, 1);
                temp = temp.Insert(2, "1");
            }
            else
            {
                temp = temp.Remove(2, 1);
                temp = temp.Insert(2, "0");
            }
            if (ckbW2.IsChecked == true && Flag_off_Plus725 == false)
            {
                temp = temp.Remove(1, 1);
                temp = temp.Insert(1, "1");
            }
            else
            {
                temp = temp.Remove(1, 1);
                temp = temp.Insert(1, "0");
            }
            if (ckbW3.IsChecked == true && Flag_off_Plus725 == false)
            {
                temp = temp.Remove(0, 1);
                temp = temp.Insert(0, "1");
            }
            else
            {
                temp = temp.Remove(0, 1);
                temp = temp.Insert(0, "0");
            }
            Data_Pin_Out_Plus725 = temp;
            string data_to_Plus725 = "W" + Convert.ToInt32(Data_Pin_Out_Plus725, 2);
            if (sp.IsOpen)
                sp.Write(STX + data_to_Plus725 + ETX);
            Write_Log(STX + data_to_Plus725 + ETX, "Write");
        }

        private void ckbW0_CheckChanged(object sender, RoutedEventArgs e)
        {
            if (Flag_off_Plus725 == false)
            {
                Pin_Out();
            }
        }

        private void ckbW1_CheckChange(object sender, RoutedEventArgs e)
        {
            if (Flag_off_Plus725 == false)
            {
                Pin_Out();
            }
        }

        private void ckbW2_CheckChanged(object sender, RoutedEventArgs e)
        {
            if (Flag_off_Plus725 == false)
            {
                Pin_Out();
            }
        }

        private void ckbW3_CheckChanged(object sender, RoutedEventArgs e)
        {
            if (Flag_off_Plus725 == false)
            {
                Pin_Out();
            }
        }

        private void ckbW_Off_CheckChanged(object sender, RoutedEventArgs e)
        {
            if (Flag_off_Plus725 == false)
            {
                Flag_off_Plus725 = true;
                Pin_Out();
                ckbW0.IsChecked = false;
                ckbW1.IsChecked = false;
                ckbW2.IsChecked = false;
                ckbW3.IsChecked = false;
                ckbW_Off.IsChecked = false;
                Flag_off_Plus725 = false;

            }
        }

        
    }
}
