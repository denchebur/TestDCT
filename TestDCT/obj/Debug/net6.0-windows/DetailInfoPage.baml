   M S B A M L   `   `   `  ����B  >TestDCT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TestDCTTestDCT  5      7 clr-namespace:TestDCT.ViewModelsTestDCT.ViewModels  5          TestDCT.DetailInfoPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:TestDCT     5      6	viewModel clr-namespace:TestDCT.ViewModels     5        N� Title$  DetailInfoPage��5      .��5      �� -   5        $��canvasBackInfo��5      $��0,0,0,10q�6#    � 	Resources 5   
      	BackBrush j� Viewport j� ViewportUnits j� TileMode L� Drawing � Geometry � Brush��%)  &	        L� 5      $ 	0,0,10,10�5      $ Absolute=�5      $
 Tile=�5       5      I� 5      .��5      � + ��        �@B     �@B �� �    �� 	 �#EEEEEE6M   � 5      + ��        �    @B Ѡ� @B Ѡ�     	 �#EEEEEE6M   5      5      5      .+�5"   
   �� -   5        $��
assetsList��5"      $	��350��6%    �� Left$ 10��62   
	 �� Top$	 70��6C   $	��241��6S   $��Center=�5#      $��Center=�60   
 � DataContext
 5$      '   !TestDCT.ViewModels.AssetViewModel  5%       �� View 5'      �� 5(      .P�5)      ��  �� Width$
 auto��6%   $��Symbol��62    �� DisplayMemberBinding 6B   �� *symbol+�� 5*      $
 auto��6%   $��
Asset name��62    6F   �� *name+�� 5+      $ 35��6%   $
��Rank��60    6>   �� *rank+5,      5.      �� 5/   
   -   5         ��Name$ textBox��5/      $��23��6#   $ 12��6/    �� TextWrapping$
 Wrap=�6@   $�� ��6T   $	 26��50      $	��190��6"   $
��Left=�6.   $��Center=�6I   �� 51   
   -   5         ��Name$ searchButton��51      $��Search��6'   $��23��68   $	 207��6D   $	 26��52      $��44��6!   $
��Left=�6,   $��Center=�6G   53      �� 55   
   $��1q�56      
�������$��1��58      $��1��59      $	��175��6!   $	��502��6.   $	 289��6:   $		 245��6L   $��Center=�6]   $	��Top=�6z   ._�5>      �� -   5        $��
drawCanvas��5A      $��	-1,0,0,-1q�6'   5B      �� 5C   
   
���   �$��1q�6%   $	��199��69   $	 289��5D      $	 26��6#   $	��501��63   $��Center=�5E      $��Center=�6.   �� 5F   
   -   5         ��Name$ 
labelPrice��5F      $��Price USD: ��6$   $	 307��6:   $	 38��6L   �� 5G   
   -   5        $ labelVolume��5G      $��Volume USD 24 h: ��6%   $	 307��6A   $	 64��6S   �� 5H   
   -   5        $ labelChange��5H      $"��Change in  percent in 24 h: ��6%   $	 307��6L   $	 90��6^   �� 5I   
   -	   5        $ 
buttonLink��5I      $��Open in Market��6%   $	 307��6>   $		 189��6P    J� RenderTransformOrigin$ 
0.48,0.518&�6a   $
��Left=�6�   $��Center=�6�   $��25��6�   $��97��6�   6�   �� 5J   
   -
   5        $ textBoxPrice��5J      $	 474��6(   $
 Wrap=�6:   $�� ��6N   $	 42��6V   $	��304��6f   $
��Left=�6r   $��Center=�6�   �� 5K   
   -   5        $ textBoxVolume��5K      $	 474��6)   $
 Wrap=�6;   $�� ��6O   $	 68��6W   $	��304��6g   $
��Left=�6s   $��Center=�6�   �� 5L   
   -   5        $ textBoxChange��5L      $	 474��6)   $
 Wrap=�6;   $�� ��6O   $	 94��6W   $	��304��6g   $
��Left=�6s   $��Center=�6�   �� 5M   
   -   5        $ labelMarkets��5M      $��	Markets: ��6&   $	 307��6:   $		 116��6L   $��Center=�6]   $	��Top=�6z   �� 5N   
   -   5         ��Name$ comboBox��5N      $	 474��6%   $		 120��67   $	��304��6H   $��Center=�5O      $��Center=�60    �� Text$ Select market��5Q      5R      5U      