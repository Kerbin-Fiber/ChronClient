   M S B A M L   `   `   `  ����F  BChronClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ChronClient.GUIChronClient.GUI  5   	   %    ChronClient.GUI.Template_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ChronClient.GUI     5   	     � Title$  ChronClient��5   	   $	��700��6   $
��1000��6*    � AllowsTransparency .  � WindowStyle$
 None=�6Q    � WindowStartupLocation$ CenterScreen=�6d    � Icon$^ X/ChronClient;component/ChronClient/res/logo/png/ChronClient_Logo_WhiteBlack_Original.png��6�   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 32Q�6      GlassFrameThickness$ 8q�6*   $��Consolas)�6B   $��18(�6b   
�������6z   .��5      � ���	#FF141414.+�5   
   � -   5         �Name$ Chrome��5      $	��Top=�6   $��32��67   ���	#FF1E1E1E.+�5      �� $
��Left=�6   	 �� Orientation$	 
Horizontal=�64   $
��10,0q�6M   .+�5      �� $��25��6   $��25��6#   $_��Y/ChronClient;component/ChronClient/res/logo/png/ChronClient_Logo_Transparent_Original.png��6/   �� 5      -   5        
 ��Name$
 
TitleBlock��5      $
��Wrap=�60   $��ChronClient��6D   $��Center=�6W   $��Consolas)�6r   $��18(�6�   $
��Bold"�6�   
�������$��10,0,0,0q�6�   5      �� 5      -   5         ��Name$ Controls��5      $��Right=�6+   $	 
Horizontal=�6G   $��10,0,5,0q�6`   .+�5      A� -   5         A�Name$ Control_Minimize��5   G      IsHitTestVisibleInChrome . ���	#FFF4F4F5$��20��6r   $��20��6}   $	��5,0q�6�   6�   A� 5      -   5        $ Control_Maximize��5   G    . ���	#FFF4F4F5$��20��6r   $��20��6}   $	��5,6q�6�   6�   A� 5      -   5        $ Control_Close��5   G    . $��20��6^   $��20��6i   $	��5,6q�6u   ���	#FFF4F4F56�   5      5      � 5   
   -   5        $ Content��5      $��0,32,0,0q�6    �� 5   
   ���	#FF1E1E1E$��5q�6)   5      5      