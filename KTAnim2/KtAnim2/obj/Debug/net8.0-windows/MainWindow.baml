   M S B A M L   `   `   `  ����  KtAnim2    KtAnim2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Storyboard Animation��5   	   $	��300��6&   $	��400��63    � 	Resources 5         RectangleAnimation g� RepeatBehavior �� 
TargetName �� TargetProperty W� From	 W� To g� Duration g� AutoReverse��%�  &	        �� 5   
   $ Forever��60   .��5      W� $ animatedRect��5	      $ (Canvas.Left)�5
       05       3006   $ 0:0:3D�6#   $
 True��64   W� 5      $ animatedRect��5      $ Width�5       505       1006   $ 0:0:1.5D�6$   $
 True��67   W� 5      $ animatedRect��5      $ Height�5       505       1006   $ 0:0:1.5D�6$   $
 True��67   5      5      .��5      �� .+�5   
   �� -   5        	 ��Name$	 animatedRect��5      $��50��6*   $��50��65   
����  �
 �� Left$
 0��5      
 �� Top$	 100��6$   5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5       �� #��[  6   5!      5#      