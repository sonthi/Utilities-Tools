   M S B A M L   `   `   `  ???? I  EUtilities Tool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Utilities_ToolUtilities_Tool  M ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089A-clr-namespace:System.IO.Ports;assembly=SystemSystem.IO.Ports     Utilities_Tool.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Utilities_Tool     ?ports-clr-namespace:System.IO.Ports;assembly=System     X TXceed.Wpf.Toolkit, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#???   $??Regular"?$??13(?&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=?   TextRenderingMode$
 Auto=?  MaterialDesignFont#???   ? Title$ 
MainWindow??$	??550??$	??480??$	??360??$	??480?? ? WindowStyle$
 None=? ? WindowStartupLocation$ CenterScreen=? ? AllowsTransparency . 
??????  ? 
ResizeMode$ NoResize=? ? 	Resources  S? 
ObjectType   System.IO.Ports.SerialPort	 S? 
MethodName  	portNames??%'   &	       S? "  $	 GetPortNames??.??? -   
 ?Name$
 	Grid_Form?? ? RowDefinitions ?? $??40 ??? $	??300 ??? $	??300 ?.+?'  !MaterialDesignThemes.Wpf.PackIcon  -      Kind$	 Cat=?
??? ??? K? ZIndex$ 1??$??Center=?$
??Left=?$??40??$??40??$??5 0 0 0q? ? ToolTip$  Create by VD System Member???? -   $??/images/close.png??$ 1??  
Close_Form#??[ ?? -   $??/images/Minimized.png??$ 1??  Minized_Form#??[ ?? -    ??Name$ 	btConnect?? ' #MaterialDesignRaisedSecondaryButton#??[ $??75??$??
0,8,10,217q?+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20?????#15ab5b???#15ab5b
???????$??Connect??$??1??$ 1??$??Right=?$??95??$??4,4,4,4q??? -   $??0??$??1 1 1 0q?
???   ? ?? CornerRadius$ 	10 10 0 0??????  ?? 
StartPoint$	 0,0&? ?? EndPoint$	 1,1&?.???  ? Color$ #347aeb?? ? Offset$ 0Q?? $ #33f2d2??$ 1Q?._?? $??Center=?.+??? -    ??Name$ 
Title_Form??)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Utilities Tools??$??Center=?
??? ???$??26(?$
??Bold"?$??	45 0 90 0q??? $??1??$??1 0 1 0q?
???   ?
???????._??  ?? $??40 ??? $??50 ??? $??75 ??? $	??130 ?.+?? $??0??.+???  ?? Orientation$ 
Horizontal=?$
??Left=?$??Center=?.+??? -    ??Name$ cbSerialPort??$ 
SerialPort?? & "MaterialDesignFloatingHintComboBox#??[ $??90??$??	10 0 20 0q?$??Center=?????  ?? Source# [ ?? -	   $ 
cbBaudrate??$ Baudrate??#??[ $??70??$??0 0 20 0q?$??Center=?.@??? $
??9600???? $??19200???? $??115200?? ?? SelectedIndex$ 0???? -
   $ cbParity??$ Parity??#??[ $??60??$??0 0 20 0q?$??Center=?.@??? $
??None???? $	??Odd???? $
??Even???? $??Space???? $
??Mark??$ 0???? -   $ 	cbStopBit??$ Stop Bit??#??[ $??65??$??0 0 0 0q?$??Center=?.@??? $??0???? $??1???? $	??1.5???? $??2??$ 1??? $??1??.+??? $ 
Horizontal=?$
??Left=?$??Center=?.+?%  Xceed.Wpf.Toolkit.IntegerUpDown  -   $??numACSII??$??50??$??30??$??10 0 0 0q?$??20(??  ?Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$ N0???  ?Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value$ 0X?   Minimum$ 0X?   Maximum$ 31X?$??Center=?$??Center=?$ ACSII Character???? -   $ btAdd_ACSII??#??[ $??60??$??30??$	??ADD??$??10 0 0 0q?
????  ?
????  ?
????????? -   $ 	btAdd_STX??#??[ $??60??$??30??$	??STX??$??10 0 0 0q??? -   $ 	btAdd_ETX??#??[ $??60??$??30??$	??ETX??$??10 0 0 0q??? -   $ btClear??#??[ $??75??$??30??$??CLEAR??$??10 0 0 0q?
???????
???????? $??2??.+??? -   $ txtDataSend?? ! MaterialDesignOutlinedTextBox#??[ $	??Top=?$??50??$??Bottom=?  ?? 	MaxLength$
  2048??$ 	Data Send??$??	10 0 10 0q?$??14(?$??16,16,50,16q?.	  (MaterialDesignThemes.Wpf.TextFieldAssist!! 	  CharacterCounterVisibility! ?? " ?? Path$" 	IsChecked?# ?? ElementName$4# .MaterialDesignOutlinedTextBoxTextCountComboBox??   BooleanToVisibilityConverter$ ?? 	Converter#$ [ ?? -   $ btSend??$
 SEND??$??Right=?$	??Top=?$??0,8,20,0q?$??0,4,0,4q?$??35??$??34????0
  *MaterialDesignThemes.Wpf.PackIconExtension
  % 
  Kind$% 
SendCircle=?& 
  Size$& 25X?? $??3??.+??? -   $ txtDataReceived??#??[ $	??Top=?$	??130??' ?? AcceptsReturn' . ( ?? TextWrapping$
( Wrap=?") ?? VerticalScrollBarVisibility$
) Auto=?$ Data Received??$??	10,0,10,0q?* ?? 
IsReadOnly* . $??
16,16,12,0q?$??12(??? $??2??$??1 0 1 1q?
???   ?$ 	0 0 10 10??
???????$	??Top=?._??  ?? $??* ??? $??20 ?.+?? $??0??+ ? ColumnDefinitions+ ?? $??0.25* ??? $
??0.5* ?.+?? $??0??$??0 16 0 0q? ?? $??30 ??? $??* ?.+??? $??0??$??1q????#08c463???#08c463$ 	20 20 0 0??$??	10 0 10 0q?._??? $??Control SR1000??$??Center=?$??Center=?$??15(?$
??Bold"?
????  ??? $??1??$??2q????#08c463$ 	0 0 10 10??$??	10 0 10 0q?$	??Top=?._??? $ Vertical=?$??10q?.+??? -   $ btSR1000_ON??#??[ $??90??$??30??$??
Scanner ON??$??5 5 5 5q?
????  ?
????  ?
???????$??12(?$??5q??? -   $ btSR1000_OFF??#??[ $??90??$??30??$??Scanner Off??$??5 5 5 5q?
????  ?
????  ?
???????$??12(?$??5q??? -   $ btSR1000_Focus??#??[ $??90??$??30??$??Scanner Focus??$??5 5 5 5q?
??? ???
??? ???
???????$??12(?$??0q?? $??1??$??0 16 0 0q? ?? $??30 ??? $??* ?.+?? $??0??.+??? $??1q????#08c463???#08c463$ 	20 20 0 0??$??	10 0 10 0q??? $ 
Horizontal=?$??Center=?$??Center=?.+?d? -   , d?Name$, ckbUsing_Plus725?? $	  MaterialDesignSwitchToggleButton#??[	 ?? -   - ??Name$- lbUse_Plus725??$??Use Plus 725??$??15(?$
??Bold"?
????  ?$??10 0 0 0q?? $??1??.+?? $??	10 0 10 0q?+ ?? $
??0.4* ??? $
??0.6* ?.+?? $??0??.+??? $??2 2 1 2q????#08c463$ 0 0 0 10???? $ Vertical=?$??10 10 10 10q?$??Center=?.+?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 0??$??Center=?A? -   . A?Name$. Signal_IN_0??$??1??$??15??$??15??
???????$
??Left=?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 1??$??Center=?A? -   $. Signal_IN_1??$??1??$??15??$??15??
???????$
??Left=?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 2??$??Center=?A? -   $. Signal_IN_2??$??1??$??15??$??15??
???????$
??Left=?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 3??$??Center=?A? -   $. Signal_IN_3??$??1??$??15??$??15??
???????$
??Left=?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 4??$??Center=?A? -   $. Signal_IN_4??$??1??$??15??$??15??
???????$
??Left=?? $??0 0 0 5q?$??Center=?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$
??IN 5??$??Center=?A? -   $. Signal_IN_5??$??1??$??15??$??15??
???????$
??Left=?? $??2??.+??? $??1 2 2 2q????#08c463$ 0 0 10 0??? + ?? $
??0.5* ??? $
??0.5* ?.+??? $??0??$??10q?$ Vertical=?$??Center=?.+?? $??0 0 0 5q?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$??Out 0??$??Center=?$??Center=??? -   / ??Name$/ ckbW0??$??1??$
??Left=?$??Center=?? $??0 0 0 5q?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$??Out 1??$??Center=?$??Center=??? -    $/ ckbW1??$??1??$
??Left=?$??Center=?? $??0 0 0 5q?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$??Out 2??$??Center=?$??Center=??? -!   $/ ckbW2??$??1??$
??Left=?$??Center=?? $??0 0 0 5q?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$??Out 3??$??Center=?$??Center=??? -"   $/ ckbW3??$??1??$
??Left=?$??Center=?? $??0 0 0 5q?+ ?? $
??0.6* ??? $
??0.4* ?.+??? $??0??$	??OFF??$??Center=?$??Center=??? -#   $/ ckbW_Off??$??1??$
??Left=?$??Center=??? $??1??$??10q?$ Vertical=?$??Center=?.+?d? -$   $, ckb_timer_Plus725??$ Timer Plus 7225??$??0 0 0 10q?  -%   0  Name$0 numTimer??$	 100X?$ 60000X?$ N0??$	 500X?1   	Increment$	1 100X?$??15(?$??Center=?$??30??? $??1??.+??? -&   $ btExtend_Grid??$??60??$??15??$??Center=?$??Bottom=?
?????? $??0q?$??0 0 0 0q?.???? $ 
Horizontal=?$??Center=?.+?A? $??8??$??8??
??? ???$??0 0 10 0q?A? $??8??$??8?????	#FF6B6BECA? $??8??$??8??
???  ??$??10 0 0 0q??? $??v20221102 b1??
???????$??Right=?$??Bottom=?$??0 0 10 0q?