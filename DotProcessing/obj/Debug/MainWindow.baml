   M S B A M L   `   `   `  ����H  DDotProcessing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DotProcessingDotProcessing  5   	   [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms 5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       DotProcessing.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DotProcessing     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  DotProcessing��5
   	   $��529.5��6   $��930.667��6.   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $
��455* �6   �� 5      $
��244* �6   .+�5   
   7  1System.Windows.Forms.Integration.WindowsFormsHost  $	��317��6   $��10,10,151,0q�6(   $	��Top=�6=      Child. 5      %  System.Windows.Forms.PictureBox  -   5        
InputImage��   BorderStyle$ FixedSingle=�5   0   5      5        5   
   $	��317��6   $��473,10,10,0q�6(   $	��Top=�6=   $��2��6U   . 5        -   5        OutputImage��$ FixedSingle=�5   1   5      �� 5   
   -   5         ��Name$ transbutton��5      $��	Transfrom��6&   $
��Left=�6:   $��531,464,0,0q�6U   $	��Top=�6j   $��76��6�   $��26��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
answertext��5      $
��Left=�6&   $��23��6A   $��406,433,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   ��6�   �� *
MaskSize+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   -   5         ��Name$
 Size��5      $��Write Answer��6   $
��Left=�65   $��307,433,0,0q�6P   $	��Top=�6e   $��26��6}   $,��&Segoe UI, Lucida Sans Unicode, Verdana)�6�   $
��Bold"�6�     5   
   $	��147��6   $��186,343,10,0q�6(   $	��Top=�6>   $��1��6V   . 5        -   5        avatarimage��5      5      �� 5   
   -   5        	 ��Name$	 slider��5      $
��Left=�6!   $��307,474,0,0q�6<   $	��Top=�6Q   $	��219��6i   
 � Minimum$
 1Q�6u    � Maximum$	 101Q�6�    � SmallChange$ 1Q�6�   �� 5   
   -   5        $ answer��5      $��Submit��6!   $
��Left=�62   $��531,433,0,0q�6M   $	��Top=�6b   $��76��6z   $��26��6�   $��2��6�   6�     5   
   $
��Left=�6   $��62��66   $��188,332,0,0q�6B   $	��Top=�6W   $��64��6o   . 5         -	   5        nextbtnimage��5    2   5!      �� 5"   
   -
   5        $ score��5"      $��0��6   $��1��6+   $
��Left=�6;   $��113.4,433,0,0q�6V   $	��Top=�6m    J� RenderTransformOrigin$ 0.312,-0.086&�6�   �� 5#   
   -   5        $ label��5#      $��Score : ��6   $��1��62   $
��Left=�6B   $��57.4,433,0,0q�6]   $	��Top=�6s   5$      5%      